<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstbMatiere = New System.Windows.Forms.ListBox()
        Me.lstbEleve = New System.Windows.Forms.ListBox()
        Me.lvNotes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMoyenne = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPointTot = New System.Windows.Forms.Label()
        Me.lbAdmis = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lbDb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstbMatiere
        '
        Me.lstbMatiere.FormattingEnabled = True
        Me.lstbMatiere.Location = New System.Drawing.Point(26, 39)
        Me.lstbMatiere.Name = "lstbMatiere"
        Me.lstbMatiere.Size = New System.Drawing.Size(532, 264)
        Me.lstbMatiere.TabIndex = 0
        '
        'lstbEleve
        '
        Me.lstbEleve.FormattingEnabled = True
        Me.lstbEleve.Location = New System.Drawing.Point(627, 39)
        Me.lstbEleve.Name = "lstbEleve"
        Me.lstbEleve.Size = New System.Drawing.Size(257, 238)
        Me.lstbEleve.TabIndex = 1
        '
        'lvNotes
        '
        Me.lvNotes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader3})
        Me.lvNotes.FullRowSelect = True
        Me.lvNotes.Location = New System.Drawing.Point(26, 331)
        Me.lvNotes.Name = "lvNotes"
        Me.lvNotes.Size = New System.Drawing.Size(577, 240)
        Me.lvNotes.TabIndex = 5
        Me.lvNotes.UseCompatibleStateImageBehavior = False
        Me.lvNotes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CodeMatière"
        Me.ColumnHeader1.Width = 72
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Matière"
        Me.ColumnHeader2.Width = 141
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Coef"
        Me.ColumnHeader4.Width = 67
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Note/20"
        Me.ColumnHeader5.Width = 138
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Points"
        Me.ColumnHeader6.Width = 55
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Points"
        Me.ColumnHeader3.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(610, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MOYENNE"
        '
        'lbMoyenne
        '
        Me.lbMoyenne.Location = New System.Drawing.Point(610, 356)
        Me.lbMoyenne.Name = "lbMoyenne"
        Me.lbMoyenne.Size = New System.Drawing.Size(61, 13)
        Me.lbMoyenne.TabIndex = 7
        Me.lbMoyenne.Text = "(moyenne)"
        Me.lbMoyenne.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(610, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "TOTAL DES POINTS"
        '
        'lbPointTot
        '
        Me.lbPointTot.Location = New System.Drawing.Point(610, 416)
        Me.lbPointTot.Name = "lbPointTot"
        Me.lbPointTot.Size = New System.Drawing.Size(81, 18)
        Me.lbPointTot.TabIndex = 9
        Me.lbPointTot.Text = "(points)"
        Me.lbPointTot.Visible = False
        '
        'lbAdmis
        '
        Me.lbAdmis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAdmis.Location = New System.Drawing.Point(610, 492)
        Me.lbAdmis.Name = "lbAdmis"
        Me.lbAdmis.Size = New System.Drawing.Size(168, 33)
        Me.lbAdmis.TabIndex = 10
        Me.lbAdmis.Text = "(Admis ou non)"
        Me.lbAdmis.Visible = False
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(809, 280)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 11
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'lbDb
        '
        Me.lbDb.AutoSize = True
        Me.lbDb.Location = New System.Drawing.Point(626, 285)
        Me.lbDb.Name = "lbDb"
        Me.lbDb.Size = New System.Drawing.Size(177, 13)
        Me.lbDb.TabIndex = 12
        Me.lbDb.Text = "Double cliker pour modifier l'étudiant"
        Me.lbDb.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 590)
        Me.Controls.Add(Me.lbDb)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lbAdmis)
        Me.Controls.Add(Me.lbPointTot)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbMoyenne)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvNotes)
        Me.Controls.Add(Me.lstbEleve)
        Me.Controls.Add(Me.lstbMatiere)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstbMatiere As System.Windows.Forms.ListBox
    Friend WithEvents lstbEleve As System.Windows.Forms.ListBox
    Friend WithEvents lvNotes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbMoyenne As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbPointTot As System.Windows.Forms.Label
    Friend WithEvents lbAdmis As System.Windows.Forms.Label
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents lbDb As System.Windows.Forms.Label

End Class
