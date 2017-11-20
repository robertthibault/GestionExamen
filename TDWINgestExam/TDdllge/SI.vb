Imports System.Data.OleDb
Public Class SI

    Private WithEvents o_MonFournisseur As FournisseurSGBD
    Private o_ToutesLesMatieres As Matieres
    Private o_TousLesEtudiants As Etudiants


    Public Event IamReady(sender As SI)
    Public Event SGBDoff(sender As SI)


    '--------------------------- SINGLETON
    Private Shared os_LeSeulEtUnique As SI
    Private Sub New()
        o_MonFournisseur = New FournisseurSGBD
        o_ToutesLesMatieres = New Matieres
        o_TousLesEtudiants = New Etudiants

    End Sub
    ''' <summary>
    ''' Renvoie le singleton
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function DonneMoisLeSI() As SI
        If (os_LeSeulEtUnique Is Nothing) Then
            os_LeSeulEtUnique = New SI
        End If
        Return os_LeSeulEtUnique
    End Function
    '--------------------------------

    Public ReadOnly Property Fournisseur As FournisseurSGBD
        Get
            Return o_MonFournisseur
        End Get
    End Property

  

    ''' <summary>
    ''' Remplit la liste des matières dès que l'on est connecté à la base de données
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <remarks></remarks>
    Private Sub FaireDesQueConnecte(sender As FournisseurSGBD) Handles o_MonFournisseur.IamConnected
        ChargementMatieres()
        ChargementEtudiants()
        ChargementNotes()
        RaiseEvent IamReady(Me)

    End Sub

    ''' <summary>
    ''' Charge les matieres
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ChargementMatieres()
        Dim RDR As OleDbDataReader = o_MonFournisseur.ReaderAllMatieres()
        Dim MAT As Matiere
        Try
            o_ToutesLesMatieres.Clear()
            Do While RDR.Read
                MAT = New Matiere(RDR.GetString(0),
                                  RDR.GetString(1),
                                  RDR.GetBoolean(2),
                                  RDR.GetValue(3))
                o_ToutesLesMatieres.Add(MAT)
            Loop

            RDR.Close()
        Catch ex As Exception
            Dim toto As Integer = 0
        End Try
    End Sub
    ''' <summary>
    ''' Charge les Etudiants
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ChargementEtudiants()
        Dim RDR As OleDbDataReader = o_MonFournisseur.ReaderAllEtudiant()
        Dim ETU As Etudiant
        Try
            o_TousLesEtudiants.Clear()
            Do While RDR.Read
                ETU = New Etudiant(RDR.GetString(0),
                                RDR.GetString(1),
                                RDR.GetString(2),
                                RDR.GetBoolean(3))
                o_TousLesEtudiants.Add(ETU)
            Loop
            RDR.Close()
        Catch ex As Exception
            Dim toto As Integer = 0
        End Try
    End Sub
    ''' <summary>
    ''' Charge les notes
    ''' </summary>
    Private Sub ChargementNotes()
        Dim RDR As OleDbDataReader = o_MonFournisseur.ReadAllNotes()
        Dim NOTE As Note
        Try

            Do While RDR.Read()
                NOTE = New Note(o_ToutesLesMatieres.Chercher(RDR.GetString(1)),
                                o_TousLesEtudiants.Chercher(RDR.GetString(0)),
                                RDR.GetDecimal(2))
            Loop
            RDR.Close()
        Catch ex As Exception
            Dim toto As Integer = 5
        End Try
    End Sub

    ''' <summary>
    ''' Renvoie la liste des matières
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Matieres As Matieres
        Get
            Return o_ToutesLesMatieres
        End Get
    End Property

    ''' <summary>
    ''' Renvoie la liste des étudiants
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Etudiants As Etudiants
        Get
            Return o_TousLesEtudiants
        End Get
    End Property

   
    Private Sub o_MonFournisseur_JeSuisDeconnecte(sender As FournisseurSGBD) Handles o_MonFournisseur.JeSuisDeconnecte
        RaiseEvent SGBDoff(Me)
    End Sub
End Class
