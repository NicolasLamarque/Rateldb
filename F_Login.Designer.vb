<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Login
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
        Me.Lbl_ActionRegister = New System.Windows.Forms.Label()
        Me.Button_Cancel = New System.Windows.Forms.Button()
        Me.Button_Ok = New System.Windows.Forms.Button()
        Me.Lbl_TitreInfo = New System.Windows.Forms.Label()
        Me.TextBox_Mp = New System.Windows.Forms.TextBox()
        Me.TextBox_Identifiant = New System.Windows.Forms.TextBox()
        Me.Lbl_MP = New System.Windows.Forms.Label()
        Me.Lbl_Identifiant = New System.Windows.Forms.Label()
        Me.LblByNic = New System.Windows.Forms.Label()
        Me.Lbl_titre = New System.Windows.Forms.Label()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_ActionRegister
        '
        Me.Lbl_ActionRegister.AutoSize = True
        Me.Lbl_ActionRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ActionRegister.ForeColor = System.Drawing.Color.Purple
        Me.Lbl_ActionRegister.Location = New System.Drawing.Point(282, 196)
        Me.Lbl_ActionRegister.Name = "Lbl_ActionRegister"
        Me.Lbl_ActionRegister.Size = New System.Drawing.Size(79, 16)
        Me.Lbl_ActionRegister.TabIndex = 21
        Me.Lbl_ActionRegister.Text = "S'enregister"
        '
        'Button_Cancel
        '
        Me.Button_Cancel.BackColor = System.Drawing.Color.Tomato
        Me.Button_Cancel.FlatAppearance.BorderSize = 0
        Me.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Cancel.Location = New System.Drawing.Point(465, 173)
        Me.Button_Cancel.Name = "Button_Cancel"
        Me.Button_Cancel.Size = New System.Drawing.Size(75, 37)
        Me.Button_Cancel.TabIndex = 20
        Me.Button_Cancel.Text = "Annuler"
        Me.Button_Cancel.UseVisualStyleBackColor = False
        '
        'Button_Ok
        '
        Me.Button_Ok.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button_Ok.FlatAppearance.BorderSize = 0
        Me.Button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Ok.Location = New System.Drawing.Point(367, 173)
        Me.Button_Ok.Name = "Button_Ok"
        Me.Button_Ok.Size = New System.Drawing.Size(92, 37)
        Me.Button_Ok.TabIndex = 19
        Me.Button_Ok.Text = "Ok"
        Me.Button_Ok.UseVisualStyleBackColor = False
        '
        'Lbl_TitreInfo
        '
        Me.Lbl_TitreInfo.AutoSize = True
        Me.Lbl_TitreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Lbl_TitreInfo.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_TitreInfo.Location = New System.Drawing.Point(216, 51)
        Me.Lbl_TitreInfo.Name = "Lbl_TitreInfo"
        Me.Lbl_TitreInfo.Size = New System.Drawing.Size(256, 26)
        Me.Lbl_TitreInfo.TabIndex = 18
        Me.Lbl_TitreInfo.Text = "Formulaire de Connexion"
        '
        'TextBox_Mp
        '
        Me.TextBox_Mp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Mp.Location = New System.Drawing.Point(286, 141)
        Me.TextBox_Mp.Name = "TextBox_Mp"
        Me.TextBox_Mp.Size = New System.Drawing.Size(255, 26)
        Me.TextBox_Mp.TabIndex = 17
        '
        'TextBox_Identifiant
        '
        Me.TextBox_Identifiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Identifiant.Location = New System.Drawing.Point(286, 109)
        Me.TextBox_Identifiant.Name = "TextBox_Identifiant"
        Me.TextBox_Identifiant.Size = New System.Drawing.Size(255, 26)
        Me.TextBox_Identifiant.TabIndex = 16
        '
        'Lbl_MP
        '
        Me.Lbl_MP.AutoSize = True
        Me.Lbl_MP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MP.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_MP.Location = New System.Drawing.Point(151, 141)
        Me.Lbl_MP.Name = "Lbl_MP"
        Me.Lbl_MP.Size = New System.Drawing.Size(129, 24)
        Me.Lbl_MP.TabIndex = 15
        Me.Lbl_MP.Text = "Mot de Passe:"
        '
        'Lbl_Identifiant
        '
        Me.Lbl_Identifiant.AutoSize = True
        Me.Lbl_Identifiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Identifiant.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_Identifiant.Location = New System.Drawing.Point(182, 111)
        Me.Lbl_Identifiant.Name = "Lbl_Identifiant"
        Me.Lbl_Identifiant.Size = New System.Drawing.Size(103, 24)
        Me.Lbl_Identifiant.TabIndex = 14
        Me.Lbl_Identifiant.Text = "Identifiant : "
        '
        'LblByNic
        '
        Me.LblByNic.AutoSize = True
        Me.LblByNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblByNic.Location = New System.Drawing.Point(86, 110)
        Me.LblByNic.Name = "LblByNic"
        Me.LblByNic.Size = New System.Drawing.Size(38, 13)
        Me.LblByNic.TabIndex = 13
        Me.LblByNic.Text = "By Nic"
        '
        'Lbl_titre
        '
        Me.Lbl_titre.AutoSize = True
        Me.Lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_titre.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_titre.Location = New System.Drawing.Point(242, 9)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(206, 39)
        Me.Lbl_titre.TabIndex = 12
        Me.Lbl_titre.Text = "RATEL - DB"
        '
        'PanelLogo
        '
        Me.PanelLogo.BackgroundImage = Global.RatelDB.My.Resources.Resources.ratel_honey_badger_database
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLogo.Controls.Add(Me.LblByNic)
        Me.PanelLogo.Location = New System.Drawing.Point(15, 12)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(127, 126)
        Me.PanelLogo.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 221)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.Lbl_ActionRegister)
        Me.Controls.Add(Me.Button_Cancel)
        Me.Controls.Add(Me.Button_Ok)
        Me.Controls.Add(Me.Lbl_TitreInfo)
        Me.Controls.Add(Me.TextBox_Mp)
        Me.Controls.Add(Me.TextBox_Identifiant)
        Me.Controls.Add(Me.Lbl_MP)
        Me.Controls.Add(Me.Lbl_Identifiant)
        Me.Controls.Add(Me.Lbl_titre)
        Me.Name = "F_Login"
        Me.Text = "RatelDB - Formulaire de connexion"
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ActionRegister As Label
    Friend WithEvents Button_Cancel As Button
    Friend WithEvents Button_Ok As Button
    Friend WithEvents Lbl_TitreInfo As Label
    Friend WithEvents TextBox_Mp As TextBox
    Friend WithEvents TextBox_Identifiant As TextBox
    Friend WithEvents Lbl_MP As Label
    Friend WithEvents Lbl_Identifiant As Label
    Friend WithEvents LblByNic As Label
    Friend WithEvents Lbl_titre As Label
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Button1 As Button
End Class
