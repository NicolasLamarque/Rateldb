<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_NotesSuivi
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Lbl_titre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelIdClient = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.DateTimePicker_Saisie = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Intervention = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBoxFont = New System.Windows.Forms.ComboBox()
        Me.BtnFontColorPicker = New System.Windows.Forms.Button()
        Me.Btn_Underscore = New System.Windows.Forms.Button()
        Me.Btn_Italic = New System.Windows.Forms.Button()
        Me.Btn_bold = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_Summit = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LblByNic = New System.Windows.Forms.Label()
        Me.LabelInfosTheme = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 156)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(776, 392)
        Me.RichTextBox1.TabIndex = 31
        Me.RichTextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Lbl_titre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LabelIdClient)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.LabelPrenom)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.LabelNom)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Teal
        Me.Panel1.Location = New System.Drawing.Point(-1, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 99)
        Me.Panel1.TabIndex = 35
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.RatelDB.My.Resources.Resources.Trash_Empty
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(731, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 37)
        Me.Button3.TabIndex = 45
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(361, 36)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(243, 26)
        Me.ComboBox2.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(361, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(243, 26)
        Me.ComboBox1.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(76, 68)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(713, 24)
        Me.TextBox6.TabIndex = 12
        '
        'Lbl_titre
        '
        Me.Lbl_titre.AutoSize = True
        Me.Lbl_titre.Location = New System.Drawing.Point(15, 71)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(52, 18)
        Me.Lbl_titre.TabIndex = 11
        Me.Lbl_titre.Text = "Titre :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Lieu :"
        '
        'LabelIdClient
        '
        Me.LabelIdClient.AutoSize = True
        Me.LabelIdClient.Location = New System.Drawing.Point(303, 10)
        Me.LabelIdClient.Name = "LabelIdClient"
        Me.LabelIdClient.Size = New System.Drawing.Size(60, 18)
        Me.LabelIdClient.TabIndex = 5
        Me.LabelIdClient.Text = "Mode :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(73, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 24)
        Me.TextBox2.TabIndex = 4
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(13, 36)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(54, 18)
        Me.LabelPrenom.TabIndex = 3
        Me.LabelPrenom.Text = "Nom :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 24)
        Me.TextBox1.TabIndex = 2
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(13, 3)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(54, 18)
        Me.LabelNom.TabIndex = 0
        Me.LabelNom.Text = "Nom :"
        '
        'DateTimePicker_Saisie
        '
        Me.DateTimePicker_Saisie.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Saisie.CalendarForeColor = System.Drawing.Color.CornflowerBlue
        Me.DateTimePicker_Saisie.CalendarMonthBackground = System.Drawing.Color.Turquoise
        Me.DateTimePicker_Saisie.CalendarTitleBackColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker_Saisie.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker_Saisie.CalendarTrailingForeColor = System.Drawing.Color.Green
        Me.DateTimePicker_Saisie.Location = New System.Drawing.Point(226, 554)
        Me.DateTimePicker_Saisie.Name = "DateTimePicker_Saisie"
        Me.DateTimePicker_Saisie.Size = New System.Drawing.Size(171, 20)
        Me.DateTimePicker_Saisie.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(140, 560)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date de saisie :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 586)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Date de l'intervention :"
        '
        'DateTimePicker_Intervention
        '
        Me.DateTimePicker_Intervention.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Intervention.Location = New System.Drawing.Point(226, 580)
        Me.DateTimePicker_Intervention.Name = "DateTimePicker_Intervention"
        Me.DateTimePicker_Intervention.Size = New System.Drawing.Size(171, 20)
        Me.DateTimePicker_Intervention.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.ComboBoxFont)
        Me.Panel2.Controls.Add(Me.BtnFontColorPicker)
        Me.Panel2.Controls.Add(Me.Btn_Underscore)
        Me.Panel2.Controls.Add(Me.Btn_Italic)
        Me.Panel2.Controls.Add(Me.Btn_bold)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(13, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 50)
        Me.Panel2.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.RatelDB.My.Resources.Resources.text_list_bullets
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(213, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 37)
        Me.Button1.TabIndex = 44
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.RatelDB.My.Resources.Resources.font
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(397, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(31, 28)
        Me.Panel3.TabIndex = 43
        '
        'ComboBoxFont
        '
        Me.ComboBoxFont.FormattingEnabled = True
        Me.ComboBoxFont.Location = New System.Drawing.Point(434, 9)
        Me.ComboBoxFont.Name = "ComboBoxFont"
        Me.ComboBoxFont.Size = New System.Drawing.Size(319, 28)
        Me.ComboBoxFont.TabIndex = 42
        '
        'BtnFontColorPicker
        '
        Me.BtnFontColorPicker.BackgroundImage = Global.RatelDB.My.Resources.Resources.color_wheel
        Me.BtnFontColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFontColorPicker.FlatAppearance.BorderSize = 0
        Me.BtnFontColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFontColorPicker.Location = New System.Drawing.Point(155, 6)
        Me.BtnFontColorPicker.Name = "BtnFontColorPicker"
        Me.BtnFontColorPicker.Size = New System.Drawing.Size(45, 37)
        Me.BtnFontColorPicker.TabIndex = 41
        Me.BtnFontColorPicker.UseVisualStyleBackColor = True
        '
        'Btn_Underscore
        '
        Me.Btn_Underscore.BackgroundImage = Global.RatelDB.My.Resources.Resources.text_underlined2
        Me.Btn_Underscore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Underscore.FlatAppearance.BorderSize = 0
        Me.Btn_Underscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Underscore.Location = New System.Drawing.Point(104, 6)
        Me.Btn_Underscore.Name = "Btn_Underscore"
        Me.Btn_Underscore.Size = New System.Drawing.Size(45, 37)
        Me.Btn_Underscore.TabIndex = 40
        Me.Btn_Underscore.UseVisualStyleBackColor = True
        '
        'Btn_Italic
        '
        Me.Btn_Italic.BackgroundImage = Global.RatelDB.My.Resources.Resources.text_italics
        Me.Btn_Italic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Italic.FlatAppearance.BorderSize = 0
        Me.Btn_Italic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Italic.Location = New System.Drawing.Point(53, 6)
        Me.Btn_Italic.Name = "Btn_Italic"
        Me.Btn_Italic.Size = New System.Drawing.Size(45, 37)
        Me.Btn_Italic.TabIndex = 39
        Me.Btn_Italic.UseVisualStyleBackColor = True
        '
        'Btn_bold
        '
        Me.Btn_bold.BackgroundImage = Global.RatelDB.My.Resources.Resources.text_bold
        Me.Btn_bold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_bold.FlatAppearance.BorderSize = 0
        Me.Btn_bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_bold.Location = New System.Drawing.Point(2, 6)
        Me.Btn_bold.Name = "Btn_bold"
        Me.Btn_bold.Size = New System.Drawing.Size(45, 37)
        Me.Btn_bold.TabIndex = 38
        Me.Btn_bold.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.RatelDB.My.Resources.Resources.Cancel_256x256
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(688, 560)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 40)
        Me.Button2.TabIndex = 33
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_Summit
        '
        Me.Btn_Summit.BackgroundImage = Global.RatelDB.My.Resources.Resources.checks
        Me.Btn_Summit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Summit.FlatAppearance.BorderSize = 0
        Me.Btn_Summit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Summit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Summit.Location = New System.Drawing.Point(745, 560)
        Me.Btn_Summit.Name = "Btn_Summit"
        Me.Btn_Summit.Size = New System.Drawing.Size(43, 40)
        Me.Btn_Summit.TabIndex = 32
        Me.Btn_Summit.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackgroundImage = Global.RatelDB.My.Resources.Resources.ratel_honey_badger_database
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLogo.Controls.Add(Me.LblByNic)
        Me.PanelLogo.Location = New System.Drawing.Point(12, 549)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(64, 62)
        Me.PanelLogo.TabIndex = 30
        '
        'LblByNic
        '
        Me.LblByNic.AutoSize = True
        Me.LblByNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblByNic.Location = New System.Drawing.Point(26, 49)
        Me.LblByNic.Name = "LblByNic"
        Me.LblByNic.Size = New System.Drawing.Size(38, 13)
        Me.LblByNic.TabIndex = 13
        Me.LblByNic.Text = "By Nic"
        '
        'LabelInfosTheme
        '
        Me.LabelInfosTheme.AutoSize = True
        Me.LabelInfosTheme.Location = New System.Drawing.Point(444, 598)
        Me.LabelInfosTheme.Name = "LabelInfosTheme"
        Me.LabelInfosTheme.Size = New System.Drawing.Size(84, 13)
        Me.LabelInfosTheme.TabIndex = 43
        Me.LabelInfosTheme.Text = "LabelInfoTheme"
        '
        'F_NotesSuivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 616)
        Me.Controls.Add(Me.LabelInfosTheme)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DateTimePicker_Intervention)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker_Saisie)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_Summit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PanelLogo)
        Me.Name = "F_NotesSuivi"
        Me.Text = "F_NotesSuivi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LblByNic As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Btn_Summit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelNom As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelIdClient As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Lbl_titre As Label
    Friend WithEvents DateTimePicker_Saisie As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker_Intervention As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Btn_bold As Button
    Friend WithEvents Btn_Italic As Button
    Friend WithEvents Btn_Underscore As Button
    Friend WithEvents BtnFontColorPicker As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboBoxFont As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LabelInfosTheme As Label
End Class
