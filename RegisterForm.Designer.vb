<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LblByNic = New System.Windows.Forms.Label()
        Me.Lbl_TitreInfo = New System.Windows.Forms.Label()
        Me.Lbl_titre = New System.Windows.Forms.Label()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.LabelIdentifiant = New System.Windows.Forms.Label()
        Me.LabelMonPasse = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.TextBoxIdentifiant = New System.Windows.Forms.TextBox()
        Me.TextBoxMotPasse = New System.Windows.Forms.TextBox()
        Me.TextBoxMail = New System.Windows.Forms.TextBox()
        Me.CheckBoxAdmin = New System.Windows.Forms.CheckBox()
        Me.TextBoxAdminCode = New System.Windows.Forms.TextBox()
        Me.LabelAdminCode = New System.Windows.Forms.Label()
        Me.PanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogo
        '
        Me.PanelLogo.BackgroundImage = Global.RatelDB.My.Resources.Resources.ratel_honey_badger_database
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLogo.Controls.Add(Me.LblByNic)
        Me.PanelLogo.Location = New System.Drawing.Point(14, 14)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(140, 139)
        Me.PanelLogo.TabIndex = 30
        '
        'LblByNic
        '
        Me.LblByNic.AutoSize = True
        Me.LblByNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblByNic.Location = New System.Drawing.Point(97, 126)
        Me.LblByNic.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LblByNic.Name = "LblByNic"
        Me.LblByNic.Size = New System.Drawing.Size(38, 13)
        Me.LblByNic.TabIndex = 13
        Me.LblByNic.Text = "By Nic"
        '
        'Lbl_TitreInfo
        '
        Me.Lbl_TitreInfo.AutoSize = True
        Me.Lbl_TitreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Lbl_TitreInfo.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_TitreInfo.Location = New System.Drawing.Point(172, 58)
        Me.Lbl_TitreInfo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_TitreInfo.Name = "Lbl_TitreInfo"
        Me.Lbl_TitreInfo.Size = New System.Drawing.Size(283, 26)
        Me.Lbl_TitreInfo.TabIndex = 29
        Me.Lbl_TitreInfo.Text = "Formulaire d'enregistrement"
        '
        'Lbl_titre
        '
        Me.Lbl_titre.AutoSize = True
        Me.Lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_titre.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_titre.Location = New System.Drawing.Point(170, 19)
        Me.Lbl_titre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(206, 39)
        Me.Lbl_titre.TabIndex = 28
        Me.Lbl_titre.Text = "RATEL - DB"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Location = New System.Drawing.Point(533, 291)
        Me.Btn_Submit.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(117, 35)
        Me.Btn_Submit.TabIndex = 31
        Me.Btn_Submit.Text = "Ok"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Location = New System.Drawing.Point(660, 291)
        Me.Btn_Cancel.Margin = New System.Windows.Forms.Padding(5)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(118, 35)
        Me.Btn_Cancel.TabIndex = 32
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'LabelIdentifiant
        '
        Me.LabelIdentifiant.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelIdentifiant.AutoSize = True
        Me.LabelIdentifiant.Location = New System.Drawing.Point(207, 106)
        Me.LabelIdentifiant.Name = "LabelIdentifiant"
        Me.LabelIdentifiant.Size = New System.Drawing.Size(61, 21)
        Me.LabelIdentifiant.TabIndex = 33
        Me.LabelIdentifiant.Text = "Label1"
        Me.LabelIdentifiant.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelMonPasse
        '
        Me.LabelMonPasse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMonPasse.AutoSize = True
        Me.LabelMonPasse.Location = New System.Drawing.Point(207, 139)
        Me.LabelMonPasse.Name = "LabelMonPasse"
        Me.LabelMonPasse.Size = New System.Drawing.Size(61, 21)
        Me.LabelMonPasse.TabIndex = 34
        Me.LabelMonPasse.Text = "Label2"
        Me.LabelMonPasse.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelMail
        '
        Me.LabelMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMail.AutoSize = True
        Me.LabelMail.Location = New System.Drawing.Point(207, 172)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(61, 21)
        Me.LabelMail.TabIndex = 35
        Me.LabelMail.Text = "Label3"
        Me.LabelMail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBoxIdentifiant
        '
        Me.TextBoxIdentifiant.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIdentifiant.Location = New System.Drawing.Point(396, 100)
        Me.TextBoxIdentifiant.Name = "TextBoxIdentifiant"
        Me.TextBoxIdentifiant.Size = New System.Drawing.Size(308, 27)
        Me.TextBoxIdentifiant.TabIndex = 36
        '
        'TextBoxMotPasse
        '
        Me.TextBoxMotPasse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMotPasse.Location = New System.Drawing.Point(396, 133)
        Me.TextBoxMotPasse.Name = "TextBoxMotPasse"
        Me.TextBoxMotPasse.Size = New System.Drawing.Size(308, 27)
        Me.TextBoxMotPasse.TabIndex = 37
        '
        'TextBoxMail
        '
        Me.TextBoxMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMail.Location = New System.Drawing.Point(396, 166)
        Me.TextBoxMail.Name = "TextBoxMail"
        Me.TextBoxMail.Size = New System.Drawing.Size(308, 27)
        Me.TextBoxMail.TabIndex = 38
        '
        'CheckBoxAdmin
        '
        Me.CheckBoxAdmin.AutoSize = True
        Me.CheckBoxAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CheckBoxAdmin.FlatAppearance.BorderSize = 2
        Me.CheckBoxAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua
        Me.CheckBoxAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBoxAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan
        Me.CheckBoxAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxAdmin.Location = New System.Drawing.Point(211, 214)
        Me.CheckBoxAdmin.Name = "CheckBoxAdmin"
        Me.CheckBoxAdmin.Size = New System.Drawing.Size(191, 25)
        Me.CheckBoxAdmin.TabIndex = 39
        Me.CheckBoxAdmin.Text = "Je suis administrateur"
        Me.CheckBoxAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxAdmin.UseVisualStyleBackColor = True
        '
        'TextBoxAdminCode
        '
        Me.TextBoxAdminCode.Location = New System.Drawing.Point(513, 212)
        Me.TextBoxAdminCode.Name = "TextBoxAdminCode"
        Me.TextBoxAdminCode.Size = New System.Drawing.Size(80, 27)
        Me.TextBoxAdminCode.TabIndex = 40
        '
        'LabelAdminCode
        '
        Me.LabelAdminCode.AutoSize = True
        Me.LabelAdminCode.Location = New System.Drawing.Point(434, 216)
        Me.LabelAdminCode.Name = "LabelAdminCode"
        Me.LabelAdminCode.Size = New System.Drawing.Size(61, 21)
        Me.LabelAdminCode.TabIndex = 41
        Me.LabelAdminCode.Text = "Label4"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(792, 339)
        Me.Controls.Add(Me.LabelAdminCode)
        Me.Controls.Add(Me.TextBoxAdminCode)
        Me.Controls.Add(Me.CheckBoxAdmin)
        Me.Controls.Add(Me.TextBoxMail)
        Me.Controls.Add(Me.TextBoxMotPasse)
        Me.Controls.Add(Me.TextBoxIdentifiant)
        Me.Controls.Add(Me.LabelMail)
        Me.Controls.Add(Me.LabelMonPasse)
        Me.Controls.Add(Me.LabelIdentifiant)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.Lbl_TitreInfo)
        Me.Controls.Add(Me.Lbl_titre)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "RegisterForm"
        Me.Text = " "
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LblByNic As Label
    Friend WithEvents Lbl_TitreInfo As Label
    Friend WithEvents Lbl_titre As Label
    Friend WithEvents Btn_Submit As Button
    Friend WithEvents Btn_Cancel As Button
    Friend WithEvents LabelIdentifiant As Label
    Friend WithEvents LabelMonPasse As Label
    Friend WithEvents LabelMail As Label
    Friend WithEvents TextBoxIdentifiant As TextBox
    Friend WithEvents TextBoxMotPasse As TextBox
    Friend WithEvents TextBoxMail As TextBox
    Friend WithEvents CheckBoxAdmin As CheckBox
    Friend WithEvents TextBoxAdminCode As TextBox
    Friend WithEvents LabelAdminCode As Label
End Class
