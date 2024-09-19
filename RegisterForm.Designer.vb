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
        Me.PanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLogo
        '
        Me.PanelLogo.BackgroundImage = Global.RatelDB.My.Resources.Resources.ratel_honey_badger_database
        Me.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelLogo.Controls.Add(Me.LblByNic)
        Me.PanelLogo.Location = New System.Drawing.Point(12, 12)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(84, 86)
        Me.PanelLogo.TabIndex = 30
        '
        'LblByNic
        '
        Me.LblByNic.AutoSize = True
        Me.LblByNic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblByNic.Location = New System.Drawing.Point(46, 73)
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
        Me.Lbl_TitreInfo.Location = New System.Drawing.Point(116, 67)
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
        Me.Lbl_titre.Location = New System.Drawing.Point(114, 28)
        Me.Lbl_titre.Name = "Lbl_titre"
        Me.Lbl_titre.Size = New System.Drawing.Size(206, 39)
        Me.Lbl_titre.TabIndex = 28
        Me.Lbl_titre.Text = "RATEL - DB"
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Location = New System.Drawing.Point(531, 384)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(106, 44)
        Me.Btn_Submit.TabIndex = 31
        Me.Btn_Submit.Text = "Ok"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.Location = New System.Drawing.Point(643, 384)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(122, 44)
        Me.Btn_Cancel.TabIndex = 32
        Me.Btn_Cancel.Text = "Cancel"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_Submit)
        Me.Controls.Add(Me.PanelLogo)
        Me.Controls.Add(Me.Lbl_TitreInfo)
        Me.Controls.Add(Me.Lbl_titre)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
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
End Class
