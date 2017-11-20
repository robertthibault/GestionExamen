Public Class Etudiants
    Inherits List(Of Etudiant)


    ''' <summary>
    ''' Cherche l'étudiant dont le code est donné en paramètre
    ''' </summary>
    ''' <param name="UnIdEtudiant">Code de l'étudiant recherché</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Chercher(ByVal UnIdEtudiant As String) As Etudiant
        For Each OBJ As Etudiant In Me
            If OBJ.ID = UnIdEtudiant Then
                Return OBJ
            End If
        Next
        Return Nothing
    End Function


End Class