Public Class Form2

    Private WithEvents o_MonSI As SI

    ' mémorisation des mat oblig et des textbox
    Private o_MatieresObligatoires As Matieres
    Private o_Lestxtb As List(Of TextBox)

    Private Sub chkResultats_CheckedChanged(sender As Object, e As EventArgs) Handles chkResultats.CheckedChanged
        pnlResultats.Visible = chkResultats.Checked
        btnEnreg.Enabled = False
        
    End Sub

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        o_MonSI = SI.DonneMoisLeSI()

        ' instancier les mémos
        o_MatieresObligatoires = New Matieres
        o_Lestxtb = New List(Of TextBox)

    End Sub

    ''' <summary>
    ''' Permet de remplir le panel des résultats
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function RemplirLesResultatsDynamiquement()

        Dim letop As Integer = 10
        Dim leLeft As Integer = 15

        For Each MAT As Matiere In o_MonSI.Matieres
            If Not MAT.Facultatif Then
                Dim labCode As Label = New Label
                Dim labLibelle As Label = New Label
                Dim txtNote As TextBox = New TextBox
                Dim labNote As Label = New Label

                labCode.Text = MAT.Code
                labCode.Top = letop
                labCode.Left = leLeft

                labLibelle.Text = MAT.Intitule
                labLibelle.Top = letop
                labLibelle.Left = labCode.Width + leLeft
                labLibelle.Width = 300

                txtNote.Top = letop
                txtNote.Left = labLibelle.Right + 15
                txtNote.Width = 35
                txtNote.MaxLength = 2

                o_Lestxtb.Add(txtNote)
                o_MatieresObligatoires.Add(MAT)

                labNote.Text = "/20"
                labNote.Left = txtNote.Right + leLeft
                labNote.Top = letop

                letop += labCode.Height + 10

                If Not pnlResultats.Controls.Contains(labCode) Then
                    pnlResultats.Controls.Add(labCode)
                    pnlResultats.Controls.Add(labLibelle)
                    pnlResultats.Controls.Add(txtNote)
                    pnlResultats.Controls.Add(labNote)
                End If
            Else
                If Not cbxEpreuveFacultative.Items.Contains(MAT) Then
                    cbxEpreuveFacultative.Items.Add(MAT)
                End If
            End If
        Next
        Debug.WriteLine("Affichage des matieres")
    End Function

    ''' <summary>
    ''' Permet de créer les labels et TextBox correspondant à la matière falcultative sélectionnée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbxEpreuveFacultative_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEpreuveFacultative.SelectedIndexChanged
        Dim labCode2 As Label = New Label
        Dim labLibelle2 As Label = New Label
        Dim txtNote2 As TextBox = New TextBox
        Dim labNote2 As Label = New Label
        Dim MAT2 As Matiere = cbxEpreuveFacultative.SelectedItem
        Dim letop As Integer = 10
        Dim leLeft As Integer = 15

        labCode2.Text = MAT2.Code
        labCode2.Top = cbxEpreuveFacultative.Bottom + letop
        labCode2.Left = leLeft

        labLibelle2.Text = MAT2.Intitule
        labLibelle2.Top = cbxEpreuveFacultative.Bottom + letop
        labLibelle2.Left = labCode2.Width + leLeft
        labLibelle2.Width = 300

        txtNote2.Top = cbxEpreuveFacultative.Bottom + letop
        txtNote2.Left = labLibelle2.Right + 15
        txtNote2.Width = 35

        labNote2.Text = "/20"
        labNote2.Left = txtNote2.Right + leLeft
        labNote2.Top = cbxEpreuveFacultative.Bottom + letop

        pnlResultats2.Controls.Add(labCode2)
        pnlResultats2.Controls.Add(labLibelle2)
        pnlResultats2.Controls.Add(txtNote2)
        pnlResultats2.Controls.Add(labNote2)



    End Sub

    ''' <summary>
    ''' Permet d'annuler la modification ou l'ajout d'un étudiant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAbondon_Click(sender As Object, e As EventArgs) Handles btnAbondon.Click
        Me.Close()
    End Sub


    ''' <summary>
    ''' Permet d'enregister les modifications ou d'enregistrer un nouvel élève 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEnreg_Click(sender As Object, e As EventArgs) Handles btnEnreg.Click
        If tbId.Text <> "" And tbNom.Text <> "" And tbPrénom.Text <> "" Then

        End If
    End Sub

    ''' <summary>
    ''' exécuté quandle form est chargé
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        RemplirLesResultatsDynamiquement()
    End Sub

End Class