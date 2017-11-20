<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbPrénom = New System.Windows.Forms.TextBox()
        Me.chkGarcon = New System.Windows.Forms.CheckBox()
        Me.chkResultats = New System.Windows.Forms.CheckBox()
        Me.pnlResultats = New System.Windows.Forms.Panel()
        Me.pnlResultats2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxEpreuveFacultative = New System.Windows.Forms.ComboBox()
        Me.btnAbondon = New System.Windows.Forms.Button()
        Me.btnEnreg = New System.Windows.Forms.Button()
        Me.pnlResultats.SuspendLayout()
        Me.pnlResultats2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modifier / Ajouter un étudiant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Identifiant :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prénom :"
        '
        'tbId
        '
        Me.tbId.Location = New System.Drawing.Point(90, 53)
        Me.tbId.MaxLength = 4
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(100, 20)
        Me.tbId.TabIndex = 4
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(90, 86)
        Me.tbNom.MaxLength = 30
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(100, 20)
        Me.tbNom.TabIndex = 5
        '
        'tbPrénom
        '
        Me.tbPrénom.Location = New System.Drawing.Point(90, 117)
        Me.tbPrénom.MaxLength = 20
        Me.tbPrénom.Name = "tbPrénom"
        Me.tbPrénom.Size = New System.Drawing.Size(100, 20)
        Me.tbPrénom.TabIndex = 6
        '
        'chkGarcon
        '
        Me.chkGarcon.AutoSize = True
        Me.chkGarcon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGarcon.Location = New System.Drawing.Point(25, 152)
        Me.chkGarcon.Name = "chkGarcon"
        Me.chkGarcon.Size = New System.Drawing.Size(71, 20)
        Me.chkGarcon.TabIndex = 7
        Me.chkGarcon.Text = "Garçon"
        Me.chkGarcon.UseVisualStyleBackColor = True
        '
        'chkResultats
        '
        Me.chkResultats.AutoSize = True
        Me.chkResultats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResultats.Location = New System.Drawing.Point(25, 197)
        Me.chkResultats.Name = "chkResultats"
        Me.chkResultats.Size = New System.Drawing.Size(125, 20)
        Me.chkResultats.TabIndex = 8
        Me.chkResultats.Text = "Voir les résultats"
        Me.chkResultats.UseVisualStyleBackColor = True
        '
        'pnlResultats
        '
        Me.pnlResultats.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlResultats.AutoScroll = True
        Me.pnlResultats.BackColor = System.Drawing.Color.White
        Me.pnlResultats.Controls.Add(Me.pnlResultats2)
        Me.pnlResultats.Controls.Add(Me.btnAbondon)
        Me.pnlResultats.Controls.Add(Me.btnEnreg)
        Me.pnlResultats.Location = New System.Drawing.Point(12, 223)
        Me.pnlResultats.Name = "pnlResultats"
        Me.pnlResultats.Size = New System.Drawing.Size(574, 425)
        Me.pnlResultats.TabIndex = 9
        Me.pnlResultats.Visible = False
        '
        'pnlResultats2
        '
        Me.pnlResultats2.BackColor = System.Drawing.Color.LightGray
        Me.pnlResultats2.Controls.Add(Me.Label5)
        Me.pnlResultats2.Controls.Add(Me.cbxEpreuveFacultative)
        Me.pnlResultats2.Location = New System.Drawing.Point(0, 306)
        Me.pnlResultats2.Name = "pnlResultats2"
        Me.pnlResultats2.Size = New System.Drawing.Size(574, 87)
        Me.pnlResultats2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Epreuve Falcultative"
        '
        'cbxEpreuveFacultative
        '
        Me.cbxEpreuveFacultative.BackColor = System.Drawing.SystemColors.Window
        Me.cbxEpreuveFacultative.FormattingEnabled = True
        Me.cbxEpreuveFacultative.Location = New System.Drawing.Point(4, 26)
        Me.cbxEpreuveFacultative.Name = "cbxEpreuveFacultative"
        Me.cbxEpreuveFacultative.Size = New System.Drawing.Size(265, 21)
        Me.cbxEpreuveFacultative.TabIndex = 2
        '
        'btnAbondon
        '
        Me.btnAbondon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbondon.Location = New System.Drawing.Point(496, 399)
        Me.btnAbondon.Name = "btnAbondon"
        Me.btnAbondon.Size = New System.Drawing.Size(75, 23)
        Me.btnAbondon.TabIndex = 1
        Me.btnAbondon.Text = "Abandonner"
        Me.btnAbondon.UseVisualStyleBackColor = True
        '
        'btnEnreg
        '
        Me.btnEnreg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnreg.Location = New System.Drawing.Point(415, 399)
        Me.btnEnreg.Name = "btnEnreg"
        Me.btnEnreg.Size = New System.Drawing.Size(75, 23)
        Me.btnEnreg.TabIndex = 0
        Me.btnEnreg.Text = "Enregistrer"
        Me.btnEnreg.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 660)
        Me.Controls.Add(Me.pnlResultats)
        Me.Controls.Add(Me.chkResultats)
        Me.Controls.Add(Me.chkGarcon)
        Me.Controls.Add(Me.tbPrénom)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.pnlResultats.ResumeLayout(False)
        Me.pnlResultats2.ResumeLayout(False)
        Me.pnlResultats2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbId As System.Windows.Forms.TextBox
    Friend WithEvents tbNom As System.Windows.Forms.TextBox
    Friend WithEvents tbPrénom As System.Windows.Forms.TextBox
    Friend WithEvents chkGarcon As System.Windows.Forms.CheckBox
    Friend WithEvents chkResultats As System.Windows.Forms.CheckBox
    Friend WithEvents pnlResultats As System.Windows.Forms.Panel
    Friend WithEvents btnEnreg As System.Windows.Forms.Button
    Friend WithEvents btnAbondon As System.Windows.Forms.Button
    Friend WithEvents cbxEpreuveFacultative As System.Windows.Forms.ComboBox
    Friend WithEvents pnlResultats2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
