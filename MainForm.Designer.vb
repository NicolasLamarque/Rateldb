<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.Lbl_TitreInfo = New System.Windows.Forms.Label()
        Me.Lbl_titre = New System.Windows.Forms.Label()
        Me.BtnPrev = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LblByNic = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanNav = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelGroupIdent = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxCP = New System.Windows.Forms.TextBox()
        Me.TextBoxAdd = New System.Windows.Forms.TextBox()
        Me.PanNav.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_TitreInfo
        '
        Me.Lbl_TitreInfo.AutoSize = True
        Me.Lbl_TitreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TitreInfo.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_TitreInfo.Location = New System.Drawing.Point(68, 33)
        Me.Lbl_TitreInfo.Name = "Lbl_TitreInfo"
        Me.Lbl_TitreInfo.Size = New System.Drawing.Size(126, 16)
        Me.Lbl_TitreInfo.TabIndex = 32
        Me.Lbl_TitreInfo.Text = "Formulaire Principal"
        '
        'Lbl_titre
        '
        Me.Lbl_titre.AutoSize = True
        Me.Lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_titre.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_titre.Location = New System.Drawing.Point(67, 9)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(112, 24)
        Me.Lbl_titre.TabIndex = 31
        Me.Lbl_titre.Text = "RATEL - DB"
        '
        'BtnPrev
        '
        Me.BtnPrev.BackgroundImage = Global.RatelDB.My.Resources.Resources.navigate_left
        Me.BtnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPrev.FlatAppearance.BorderSize = 0
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrev.Location = New System.Drawing.Point(415, 580)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(39, 32)
        Me.BtnPrev.TabIndex = 35
        Me.BtnPrev.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.BackgroundImage = Global.RatelDB.My.Resources.Resources.navigate_right
        Me.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Location = New System.Drawing.Point(607, 580)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(38, 32)
        Me.BtnNext.TabIndex = 36
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnLast
        '
        Me.BtnLast.BackgroundImage = Global.RatelDB.My.Resources.Resources.navigate_right2
        Me.BtnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLast.FlatAppearance.BorderSize = 0
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLast.Location = New System.Drawing.Point(711, 580)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(31, 32)
        Me.BtnLast.TabIndex = 37
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.BackgroundImage = Global.RatelDB.My.Resources.Resources.navigate_left2
        Me.BtnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFirst.FlatAppearance.BorderSize = 0
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFirst.Location = New System.Drawing.Point(318, 580)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(34, 32)
        Me.BtnFirst.TabIndex = 34
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.BackgroundImage = Global.RatelDB.My.Resources.Resources.ratel_honey_badger_database
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLogo.Location = New System.Drawing.Point(12, 12)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(49, 47)
        Me.PanelLogo.TabIndex = 33
        '
        'LblByNic
        '
        Me.LblByNic.AutoSize = True
        Me.LblByNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 2.25!, System.Drawing.FontStyle.Italic)
        Me.LblByNic.Location = New System.Drawing.Point(47, 54)
        Me.LblByNic.Name = "LblByNic"
        Me.LblByNic.Size = New System.Drawing.Size(12, 4)
        Me.LblByNic.TabIndex = 13
        Me.LblByNic.Text = "By Nic"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.RatelDB.My.Resources.Resources.pawn_blue_add
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(511, 580)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 32)
        Me.Button1.TabIndex = 38
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Location = New System.Drawing.Point(0, 557)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 10)
        Me.Panel1.TabIndex = 39
        '
        'PanNav
        '
        Me.PanNav.Controls.Add(Me.GroupBox1)
        Me.PanNav.Location = New System.Drawing.Point(0, 61)
        Me.PanNav.Name = "PanNav"
        Me.PanNav.Size = New System.Drawing.Size(1094, 490)
        Me.PanNav.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxCP)
        Me.GroupBox1.Controls.Add(Me.TextBoxAdd)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrenom)
        Me.GroupBox1.Controls.Add(Me.TextBoxNom)
        Me.GroupBox1.Controls.Add(Me.LabelAdresse)
        Me.GroupBox1.Controls.Add(Me.LabelMail)
        Me.GroupBox1.Controls.Add(Me.LabelPrenom)
        Me.GroupBox1.Controls.Add(Me.LabelNom)
        Me.GroupBox1.Controls.Add(Me.LabelGroupIdent)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(13, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LabelGroupIdent
        '
        Me.LabelGroupIdent.AutoSize = True
        Me.LabelGroupIdent.Location = New System.Drawing.Point(18, 0)
        Me.LabelGroupIdent.Name = "LabelGroupIdent"
        Me.LabelGroupIdent.Size = New System.Drawing.Size(57, 18)
        Me.LabelGroupIdent.TabIndex = 0
        Me.LabelGroupIdent.Text = "Label1"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(32, 44)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(51, 18)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Label1"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrenom.Location = New System.Drawing.Point(32, 78)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(51, 18)
        Me.LabelPrenom.TabIndex = 2
        Me.LabelPrenom.Text = "Label1"
        '
        'LabelMail
        '
        Me.LabelMail.AutoSize = True
        Me.LabelMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMail.Location = New System.Drawing.Point(32, 146)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(51, 18)
        Me.LabelMail.TabIndex = 3
        Me.LabelMail.Text = "Label1"
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdresse.Location = New System.Drawing.Point(32, 112)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(51, 18)
        Me.LabelAdresse.TabIndex = 4
        Me.LabelAdresse.Text = "Label1"
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(138, 41)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(219, 24)
        Me.TextBoxNom.TabIndex = 5
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(137, 75)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(219, 24)
        Me.TextBoxPrenom.TabIndex = 6
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Location = New System.Drawing.Point(137, 143)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.Size = New System.Drawing.Size(116, 24)
        Me.TextBoxCP.TabIndex = 8
        '
        'TextBoxAdd
        '
        Me.TextBoxAdd.Location = New System.Drawing.Point(138, 109)
        Me.TextBoxAdd.Name = "TextBoxAdd"
        Me.TextBoxAdd.Size = New System.Drawing.Size(219, 24)
        Me.TextBoxAdd.TabIndex = 7
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 624)
        Me.Controls.Add(Me.PanNav)
        Me.Controls.Add(Me.LblByNic)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnPrev)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.Lbl_TitreInfo)
        Me.Controls.Add(Me.Lbl_titre)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.PanNav.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LblByNic As Label
    Friend WithEvents Lbl_TitreInfo As Label
    Friend WithEvents Lbl_titre As Label
    Friend WithEvents BtnFirst As Button
    Friend WithEvents BtnPrev As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanNav As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelGroupIdent As Label
    Friend WithEvents TextBoxCP As TextBox
    Friend WithEvents TextBoxAdd As TextBox
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents LabelMail As Label
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelNom As Label
End Class
