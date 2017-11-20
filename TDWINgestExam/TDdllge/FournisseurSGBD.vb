Imports System.Data.OleDb
Public Class FournisseurSGBD

    Private s_Path As String
    Private WithEvents o_Cnx As OleDbConnection


    Public Event IamConnected(sender As FournisseurSGBD)
    Public Event JeSuisDeconnecte(sender As FournisseurSGBD)

    ''' <summary>
    ''' Chemin de la BDD
    ''' </summary>
    Public Sub New()
        s_Path = "D:\BTS SIO\SLAM2\TDWINgestExam\Epreuve_BTSSIO.mdb"
        o_Cnx = New OleDbConnection
    End Sub
    ''' <summary>
    ''' si la connection ne se fait pas ou essaye un nouveau chemin
    ''' </summary>
    ''' <returns></returns>
    Public Property Fichier As String
        Get
            Return s_Path
        End Get
        Set(value As String)
            If o_Cnx.State = ConnectionState.Closed Then
                s_Path = value
                Me.o_Cnx.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""" & s_Path & """"
                OuvrirConnexion()
            End If
        End Set
    End Property
    ''' <summary>
    ''' Ouvrir la connection si elle est fermée
    ''' </summary>
    Private Sub OuvrirConnexion()
        Try
            If o_Cnx.State = ConnectionState.Closed Then
                o_Cnx.Open()
            End If
        Catch ex As Exception
            Dim toto As Integer = 5
        End Try
    End Sub
    ''' <summary>
    ''' Renvoie les matières
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReaderAllMatieres() As OleDbDataReader
        Dim RDR As OleDbDataReader
        Static CMD As OleDbCommand
        If CMD Is Nothing Then
            '                                0         1          2             3
            CMD = New OleDbCommand("Select CodeM, IntituleM, Facultatif, CoefficientM FROM MATIERES ORDER BY CoefficientM DESC")
            CMD.Connection = o_Cnx
        End If
        Try
            OuvrirConnexion()
            RDR = CMD.ExecuteReader
        Catch ex As Exception
            RDR = Nothing
        End Try
        Return RDR
    End Function

    ''' <summary>
    ''' Renvoie les Etudiants
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReaderAllEtudiant() As OleDbDataReader
        Dim RDR As OleDbDataReader
        Static CMD As OleDbCommand
        If CMD Is Nothing Then
            '                                0       1      2       3
            CMD = New OleDbCommand("Select IdE, PrenomE, NomE, Garcon FROM ETUDIANTS ORDER BY NomE, PrenomE")
            CMD.Connection = o_Cnx
        End If
        Try
            OuvrirConnexion()
            RDR = CMD.ExecuteReader
        Catch ex As Exception
            RDR = Nothing
        End Try
        Return RDR
    End Function

    ''' <summary>
    ''' Renvoie les notes
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ReadAllNotes() As OleDbDataReader
        Dim RDR As OleDbDataReader
        Static CMD As OleDbCommand
        If CMD Is Nothing Then
            '                                   0             1          2
            CMD = New OleDbCommand("SELECT IdEtudiant , CodeMatiere, Notesur20 FROM NOTES")
            CMD.Connection = o_Cnx
        End If
        Try
            OuvrirConnexion()
            RDR = CMD.ExecuteReader
        Catch ex As Exception
            RDR = Nothing
        End Try
        Return RDR
    End Function

    Public Sub Fermer()
        Try
            o_Cnx.Close()
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Exécutée quand l'état de la connexion o_Cnx change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub FaireCnxChange(sender As Object, e As StateChangeEventArgs) Handles o_Cnx.StateChange
        If o_Cnx.State = ConnectionState.Open Then
            RaiseEvent IamConnected(Me)
        ElseIf o_Cnx.State = ConnectionState.Closed Then
            RaiseEvent JeSuisDeconnecte(Me)
        End If
    End Sub

End Class
