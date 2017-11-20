Public Class Matieres
    Inherits List(Of Matiere)

    ''' <summary>
    ''' Cherche le devoir dont le code est donné en paramètre
    ''' </summary>
    ''' <param name="unCodeMatiere">Code du devoir recherché</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Chercher(ByVal unCodeMatiere As String) As Matiere
        For Each OBJ As Matiere In Me
            If OBJ.Code = unCodeMatiere Then
                Return OBJ
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Calcule la somme des coefficients des matières
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TotalCoefficients As Integer
        Get
            Dim SOMME As Integer = 0
            For Each COEFF As Matiere In Me
                If Not COEFF.Facultatif Then
                    SOMME += COEFF.Coefficient
                End If
            Next
            Return SOMME
        End Get
    End Property

End Class
