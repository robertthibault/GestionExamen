Public Class Note
    Private o_Matiere As Matiere
    Private o_Etudiant As Etudiant
    Private d_NoteSur20 As Decimal

    Public Sub New(TheMatiere As Matiere,
                   TheEtudiant As Etudiant,
                   TheNote As Decimal
                   )
        o_Matiere = TheMatiere
        o_Etudiant = TheEtudiant
        d_NoteSur20 = TheNote

        o_Matiere.SesNotes.Add(Me)
        o_Etudiant.SesNotes.Add(Me)
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public ReadOnly Property Matiere As Matiere
        Get
            Return o_Matiere
        End Get
    End Property

    Public ReadOnly Property Etudiant As Etudiant
        Get
            Return o_Etudiant
        End Get
    End Property

    Public ReadOnly Property Note As Decimal
        Get
            Return d_NoteSur20
        End Get
    End Property

    Public ReadOnly Property Points As Decimal
        Get
            'Si l'épreuve est falcutatif
            If o_Matiere.Facultatif And d_NoteSur20 < 10 Then
                Return Nothing
            Else
                Return d_NoteSur20 * o_Matiere.Coefficient

            End If
        End Get
    End Property

    Public ReadOnly Property TotalPoints As Decimal
        Get
            If Not o_Matiere.Facultatif Then
                Return o_Matiere.Coefficient * d_NoteSur20
            Else
                If d_NoteSur20 > 10 Then
                    Return d_NoteSur20 - 10
                Else
                    Return 0
                End If
            End If
        End Get
    End Property

End Class
