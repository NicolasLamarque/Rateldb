<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Param
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GrBoxTheme = New System.Windows.Forms.GroupBox()
        Me.rbThemeSombre = New System.Windows.Forms.RadioButton()
        Me.rbThemeClair = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GrBoxTheme.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SerifGothic LT", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(166, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 28)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Paramêtres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SerifGothic LT", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(163, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 43)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "RATEL - DB"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.RatelDB.My.Resources.Resources.ratel_honey_badger_database
        Me.Button1.Location = New System.Drawing.Point(18, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 154)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(18, 157)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 15)
        Me.Panel1.TabIndex = 22
        '
        'GrBoxTheme
        '
        Me.GrBoxTheme.Controls.Add(Me.rbThemeSombre)
        Me.GrBoxTheme.Controls.Add(Me.rbThemeClair)
        Me.GrBoxTheme.Font = New System.Drawing.Font("SerifGothic LT", 16.0!, System.Drawing.FontStyle.Italic)
        Me.GrBoxTheme.ForeColor = System.Drawing.Color.Teal
        Me.GrBoxTheme.Location = New System.Drawing.Point(47, 199)
        Me.GrBoxTheme.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrBoxTheme.Name = "GrBoxTheme"
        Me.GrBoxTheme.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrBoxTheme.Size = New System.Drawing.Size(294, 129)
        Me.GrBoxTheme.TabIndex = 24
        Me.GrBoxTheme.TabStop = False
        Me.GrBoxTheme.Text = "Thème"
        '
        'rbThemeSombre
        '
        Me.rbThemeSombre.AutoSize = True
        Me.rbThemeSombre.Location = New System.Drawing.Point(84, 72)
        Me.rbThemeSombre.Name = "rbThemeSombre"
        Me.rbThemeSombre.Size = New System.Drawing.Size(107, 32)
        Me.rbThemeSombre.TabIndex = 28
        Me.rbThemeSombre.TabStop = True
        Me.rbThemeSombre.Text = "Sombre"
        Me.rbThemeSombre.UseVisualStyleBackColor = True
        '
        'rbThemeClair
        '
        Me.rbThemeClair.AutoSize = True
        Me.rbThemeClair.Location = New System.Drawing.Point(84, 34)
        Me.rbThemeClair.Name = "rbThemeClair"
        Me.rbThemeClair.Size = New System.Drawing.Size(72, 32)
        Me.rbThemeClair.TabIndex = 27
        Me.rbThemeClair.TabStop = True
        Me.rbThemeClair.Text = "Clair"
        Me.rbThemeClair.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Font = New System.Drawing.Font("SerifGothic LT", 16.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(391, 199)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(294, 129)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Language"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(84, 72)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(100, 32)
        Me.RadioButton3.TabIndex = 28
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Anglais"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(84, 34)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(106, 32)
        Me.RadioButton4.TabIndex = 27
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Francais"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'F_Param
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 692)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrBoxTheme)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "F_Param"
        Me.Text = "F_Param"
        Me.GrBoxTheme.ResumeLayout(False)
        Me.GrBoxTheme.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GrBoxTheme As GroupBox
    Friend WithEvents rbThemeSombre As RadioButton
    Friend WithEvents rbThemeClair As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
End Class
