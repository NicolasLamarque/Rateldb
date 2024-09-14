<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbl_SousTitre = New System.Windows.Forms.Label()
        Me.Lbl_Titre = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button02 = New System.Windows.Forms.Button()
        Me.Button03 = New System.Windows.Forms.Button()
        Me.Button04 = New System.Windows.Forms.Button()
        Me.Button05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(0, 421)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 30)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button1.Location = New System.Drawing.Point(36, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Clients"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lbl_SousTitre
        '
        Me.Lbl_SousTitre.AutoSize = True
        Me.Lbl_SousTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Lbl_SousTitre.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_SousTitre.Location = New System.Drawing.Point(131, 54)
        Me.Lbl_SousTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_SousTitre.Name = "Lbl_SousTitre"
        Me.Lbl_SousTitre.Size = New System.Drawing.Size(83, 26)
        Me.Lbl_SousTitre.TabIndex = 24
        Me.Lbl_SousTitre.Text = "Accueil"
        '
        'Lbl_Titre
        '
        Me.Lbl_Titre.AutoSize = True
        Me.Lbl_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titre.ForeColor = System.Drawing.Color.Teal
        Me.Lbl_Titre.Location = New System.Drawing.Point(128, 14)
        Me.Lbl_Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Titre.Name = "Lbl_Titre"
        Me.Lbl_Titre.Size = New System.Drawing.Size(128, 39)
        Me.Lbl_Titre.TabIndex = 23
        Me.Lbl_Titre.Text = "RATEL"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.RatelDB.My.Resources.Resources.ratel_honey_badger_database
        Me.Button2.Location = New System.Drawing.Point(12, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 111)
        Me.Button2.TabIndex = 22
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button02
        '
        Me.Button02.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button02.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button02.Location = New System.Drawing.Point(36, 189)
        Me.Button02.Name = "Button02"
        Me.Button02.Size = New System.Drawing.Size(199, 48)
        Me.Button02.TabIndex = 25
        Me.Button02.Text = "Taches"
        Me.Button02.UseVisualStyleBackColor = True
        '
        'Button03
        '
        Me.Button03.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button03.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button03.Location = New System.Drawing.Point(36, 243)
        Me.Button03.Name = "Button03"
        Me.Button03.Size = New System.Drawing.Size(199, 48)
        Me.Button03.TabIndex = 26
        Me.Button03.Text = "RPA"
        Me.Button03.UseVisualStyleBackColor = True
        '
        'Button04
        '
        Me.Button04.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button04.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button04.Location = New System.Drawing.Point(36, 297)
        Me.Button04.Name = "Button04"
        Me.Button04.Size = New System.Drawing.Size(199, 48)
        Me.Button04.TabIndex = 27
        Me.Button04.Text = "Form1"
        Me.Button04.UseVisualStyleBackColor = True
        '
        'Button05
        '
        Me.Button05.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button05.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button05.Location = New System.Drawing.Point(36, 351)
        Me.Button05.Name = "Button05"
        Me.Button05.Size = New System.Drawing.Size(199, 48)
        Me.Button05.TabIndex = 28
        Me.Button05.Text = "Form1"
        Me.Button05.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 450)
        Me.Controls.Add(Me.Button05)
        Me.Controls.Add(Me.Button04)
        Me.Controls.Add(Me.Button03)
        Me.Controls.Add(Me.Button02)
        Me.Controls.Add(Me.Lbl_SousTitre)
        Me.Controls.Add(Me.Lbl_Titre)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormAccueil"
        Me.Text = "FormAccueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Lbl_SousTitre As Label
    Friend WithEvents Lbl_Titre As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button02 As Button
    Friend WithEvents Button03 As Button
    Friend WithEvents Button04 As Button
    Friend WithEvents Button05 As Button
End Class
