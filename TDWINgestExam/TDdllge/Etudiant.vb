Public Class Etudiant
    Private s_Id As String
    Private s_Nom As String
    Private s_Prenom As String
    Private b_Garcon As Boolean
    Private o_SesNotes As Notes

    ''' <summary>
    ''' Constructeur
    ''' </summary>
    ''' <param name="TheId">Code de l'etudiant</param>
    ''' <param name="TheNom">Nom d l'etudiant</param>
    ''' <param name="ThePrenom">Prenom de l'etudiant</param>
    ''' <remarks></remarks>
    Public Sub New(TheId As String,
                   ThePrenom As String,
                   TheNom As String,
                   TheGarcon As Boolean)

        s_Id = TheId
        s_Nom = TheNom
        s_Prenom = ThePrenom
        b_Garcon = TheGarcon
        o_SesNotes = New Notes

    End Sub

    Public Property ID As String
        Get
            Return s_Id
        End Get
        Set(value As String)
            s_Id = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return s_Nom
        End Get
        Set(value As String)
            s_Nom = value
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return s_Prenom
        End Get
        Set(value As String)
            s_Prenom = value
        End Set
    End Property


    Public Property Garcon As Boolean
        Get
            Return b_Garcon
        End Get
        Set(value As Boolean)

        End Set
    End Property

    Public ReadOnly Property EstGarcon As String
        Get
            If Garcon Then
                Return "G"
            Else
                Return "F"
            End If
        End Get
    End Property

    Public ReadOnly Property SesNotes As Notes
        Get
            Return o_SesNotes
        End Get
    End Property

    ''' <summary>
    ''' Calcule la moyenne de point
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property MoyennePoint As Decimal
        Get
            Dim SOMME As Decimal = 0
            For Each MOY As Note In o_SesNotes
                SOMME += MOY.Note
            Next
            Return SOMME / SI.DonneMoisLeSI.Matieres.TotalCoefficients
        End Get
    End Property

    ''' <summary>
    ''' Calcule la moyenne d'un élève
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Moyenne As Decimal
        Get
            Dim moy As Decimal = (Me.totalPoints / SI.DonneMoisLeSI.Matieres.TotalCoefficients())
            Return ((moy * 100) \ 1) / 100
        End Get
    End Property

    ''' <summary>
    ''' Calcule le nombre total de point pour un élève
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property totalPoints As Decimal
        Get
            Dim total As Integer = 0
            For Each TOT As Note In o_SesNotes
                total += TOT.TotalPoints
            Next
            Return total
        End Get
    End Property

    ''' <summary>
    ''' Permet de savoir si un élève a eu son BTS ou non
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property EstRecut As Boolean
        Get
            If Me.Moyenne >= 10 Then
                Return True
            End If
            Return False
        End Get
    End Property

    ''' <summary>
    ''' Permet d'afficher correctement le nom puis prénom puis le sexe de chaque élève
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return s_Nom & " " & s_Prenom & " / " & EstGarcon
    End Function

End Class
