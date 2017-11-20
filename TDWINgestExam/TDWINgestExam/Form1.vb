Imports System.Data.OleDb
Public Class Form1

    Private WithEvents o_MonSI As SI

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        o_MonSI.Fournisseur.Fichier = "E:\BTS SIO\SLAM2\TDWINgestExam\Epreuve_BTSSIO.mdb"
    End Sub

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        o_MonSI = SI.DonneMoisLeSI()

    End Sub

    ''' <summary>
    ''' Remplir la liste des matières
    ''' </summary>
    Private Sub RemplirMatieres()
        lstbMatiere.Items.Clear()
        For Each MAT As Matiere In o_MonSI.Matieres
            lstbMatiere.Items.Add(MAT)
        Next
    End Sub

    ''' <summary>
    ''' Remplir la liste de étudiants
    ''' </summary>
    Private Sub RemplirEleves()
        lstbEleve.Items.Clear()
        For Each ETU As Etudiant In o_MonSI.Etudiants
            lstbEleve.Items.Add(ETU)
        Next
    End Sub

    ''' <summary>
    ''' Remplir les notes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RemplirNotes(ETU As Etudiant)

        lvNotes.Items.Clear()
        For Each NOTE As Note In ETU.SesNotes
            Dim LVI As New ListViewItem(NOTE.Matiere.Code)
            LVI.SubItems.Add(NOTE.Matiere.Intitule)
            LVI.SubItems.Add(NOTE.Matiere.Coefficient)
            LVI.SubItems.Add(NOTE.Note)
            LVI.SubItems.Add(NOTE.Points)
            lvNotes.Items.Add(LVI)

        Next

        Dim OBJ As Etudiant = ETU
        lbMoyenne.Text = OBJ.Moyenne.ToString(".##")
        lbMoyenne.Visible = True
        lbPointTot.Text = OBJ.totalPoints
        lbPointTot.Visible = True
        If OBJ.EstRecut Then
            lbAdmis.Text = "ADMIS"
            lbAdmis.ForeColor = Color.Green
            lbAdmis.Visible = True
        Else
            lbAdmis.Text = "REFUSÉ"
            lbAdmis.ForeColor = Color.Red
            lbAdmis.Visible = True
        End If
    End Sub

    Private Sub o_MonSI_IamReady(sender As SI) Handles o_MonSI.IamReady
        RemplirMatieres()
        RemplirEleves()
    End Sub


    Private Sub o_MonSI_SGBDoff(sender As SI) Handles o_MonSI.SGBDoff
        lstbMatiere.Items.Clear()
        lstbEleve.Items.Clear()
        lvNotes.Items.Clear()
    End Sub

    Private Sub PreparerListView()
        lvNotes.FullRowSelect = True
        lvNotes.View = View.Details
        lvNotes.Items.Clear()
    End Sub

    Private Sub lsbEtudiants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbEleve.SelectedIndexChanged
        If lstbEleve.SelectedIndex < 0 Then Exit Sub
        Dim ETU As Etudiant = lstbEleve.SelectedItem
        RemplirNotes(ETU)
        lbDb.Visible = lstbEleve.SelectedIndex >= 0
    End Sub

    Private Sub lstbEleve_DoubleClick(sender As Object, e As System.EventArgs) Handles lstbEleve.DoubleClick

        Form2.tbId.Clear()
        Form2.tbNom.Clear()
        Form2.tbPrénom.Clear()

        Dim theEtudiant As Etudiant = lstbEleve.SelectedItems.Item(0)
        Form2.tbId.Text = theEtudiant.ID
        Form2.tbNom.Text = theEtudiant.Nom
        Form2.tbPrénom.Text = theEtudiant.Prenom
        Form2.chkGarcon.Checked = theEtudiant.Garcon
        Form2.Show()

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Form2.Show()
    End Sub
End Class