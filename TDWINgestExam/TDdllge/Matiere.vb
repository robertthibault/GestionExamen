Public Class Matiere

    Private s_Code As String
    Private s_Intitule As String
    Private b_Facultatif As Boolean
    Private i_Coefficient As Integer
    Private o_SesNotes As Notes

    Public Sub New(TheCode As String,
                   TheIntitule As String,
                   IfFacultatif As Boolean,
                   TheCoefficient As Decimal)

        s_Code = TheCode
        s_Intitule = TheIntitule
        b_Facultatif = IfFacultatif
        i_Coefficient = TheCoefficient
        o_SesNotes = New Notes

    End Sub

    Public Property Code As String
        Get
            Return s_Code
        End Get
        Set(value As String)
            s_Code = value
        End Set
    End Property

    Public Property Intitule As String
        Get
            Return s_Intitule
        End Get
        Set(value As String)
            s_Intitule = value
        End Set
    End Property

    Public Property Facultatif As Boolean
        Get
            Return b_Facultatif
        End Get
        Set(value As Boolean)
            b_Facultatif = value
        End Set
    End Property

    Public Property Coefficient As Decimal
        Get
            Return i_Coefficient
        End Get
        Set(value As Decimal)
            i_Coefficient = value
        End Set
    End Property

    Public ReadOnly Property SesNotes As Notes
        Get
            Return o_SesNotes
        End Get
    End Property

    Public ReadOnly Property EstOptionnelle As String
        Get
            If Facultatif Then
                Return "(Option)"
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return s_Code & " / " & s_Intitule & " / " & i_Coefficient & "   " & EstOptionnelle
    End Function

End Class
