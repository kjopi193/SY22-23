<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorMixerRemixer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Back_Round_Box = New System.Windows.Forms.PictureBox()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.View_Color_Button = New System.Windows.Forms.Button()
        Me.Blue_Label = New System.Windows.Forms.Label()
        Me.Green_Label = New System.Windows.Forms.Label()
        Me.Red_Label = New System.Windows.Forms.Label()
        Me.Blue_TextBox = New System.Windows.Forms.TextBox()
        Me.Green_TextBox = New System.Windows.Forms.TextBox()
        Me.Red_TextBox = New System.Windows.Forms.TextBox()
        Me.The_real_simular_oval = New System.Windows.Forms.PictureBox()
        Me.Color_Mixer_Remixer = New System.Windows.Forms.Label()
        CType(Me.Back_Round_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.The_real_simular_oval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back_Round_Box
        '
        Me.Back_Round_Box.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Back_Round_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Back_Round_Box.Location = New System.Drawing.Point(32, 12)
        Me.Back_Round_Box.Name = "Back_Round_Box"
        Me.Back_Round_Box.Size = New System.Drawing.Size(517, 410)
        Me.Back_Round_Box.TabIndex = 9
        Me.Back_Round_Box.TabStop = False
        '
        'Exit_Button
        '
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.Location = New System.Drawing.Point(184, 328)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(75, 31)
        Me.Exit_Button.TabIndex = 18
        Me.Exit_Button.Text = "&Exit"
        Me.Exit_Button.UseVisualStyleBackColor = True
        '
        'View_Color_Button
        '
        Me.View_Color_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_Color_Button.Location = New System.Drawing.Point(391, 328)
        Me.View_Color_Button.Name = "View_Color_Button"
        Me.View_Color_Button.Size = New System.Drawing.Size(128, 31)
        Me.View_Color_Button.TabIndex = 17
        Me.View_Color_Button.Text = "&View Color"
        Me.View_Color_Button.UseVisualStyleBackColor = True
        '
        'Blue_Label
        '
        Me.Blue_Label.AutoSize = True
        Me.Blue_Label.BackColor = System.Drawing.Color.Blue
        Me.Blue_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Blue_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Blue_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Blue_Label.Location = New System.Drawing.Point(109, 278)
        Me.Blue_Label.Name = "Blue_Label"
        Me.Blue_Label.Size = New System.Drawing.Size(48, 24)
        Me.Blue_Label.TabIndex = 16
        Me.Blue_Label.Text = "&Blue"
        '
        'Green_Label
        '
        Me.Green_Label.AutoSize = True
        Me.Green_Label.BackColor = System.Drawing.Color.Lime
        Me.Green_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Green_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Green_Label.Location = New System.Drawing.Point(109, 198)
        Me.Green_Label.Name = "Green_Label"
        Me.Green_Label.Size = New System.Drawing.Size(62, 24)
        Me.Green_Label.TabIndex = 15
        Me.Green_Label.Text = "&Green"
        '
        'Red_Label
        '
        Me.Red_Label.AutoSize = True
        Me.Red_Label.BackColor = System.Drawing.Color.Red
        Me.Red_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Red_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Red_Label.Location = New System.Drawing.Point(109, 123)
        Me.Red_Label.Name = "Red_Label"
        Me.Red_Label.Size = New System.Drawing.Size(45, 24)
        Me.Red_Label.TabIndex = 14
        Me.Red_Label.Text = "&Red"
        '
        'Blue_TextBox
        '
        Me.Blue_TextBox.Location = New System.Drawing.Point(263, 275)
        Me.Blue_TextBox.Name = "Blue_TextBox"
        Me.Blue_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Blue_TextBox.TabIndex = 13
        '
        'Green_TextBox
        '
        Me.Green_TextBox.Location = New System.Drawing.Point(263, 198)
        Me.Green_TextBox.Name = "Green_TextBox"
        Me.Green_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Green_TextBox.TabIndex = 12
        '
        'Red_TextBox
        '
        Me.Red_TextBox.Location = New System.Drawing.Point(263, 123)
        Me.Red_TextBox.Name = "Red_TextBox"
        Me.Red_TextBox.Size = New System.Drawing.Size(100, 22)
        Me.Red_TextBox.TabIndex = 11
        '
        'The_real_simular_oval
        '
        Me.The_real_simular_oval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.The_real_simular_oval.Location = New System.Drawing.Point(405, 113)
        Me.The_real_simular_oval.Name = "The_real_simular_oval"
        Me.The_real_simular_oval.Size = New System.Drawing.Size(101, 199)
        Me.The_real_simular_oval.TabIndex = 10
        Me.The_real_simular_oval.TabStop = False
        '
        'Color_Mixer_Remixer
        '
        Me.Color_Mixer_Remixer.AutoSize = True
        Me.Color_Mixer_Remixer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Color_Mixer_Remixer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Color_Mixer_Remixer.Location = New System.Drawing.Point(156, 45)
        Me.Color_Mixer_Remixer.Name = "Color_Mixer_Remixer"
        Me.Color_Mixer_Remixer.Size = New System.Drawing.Size(254, 31)
        Me.Color_Mixer_Remixer.TabIndex = 19
        Me.Color_Mixer_Remixer.Text = "Color Mixer Remixer"
        '
        'ColorMixerRemixer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 730)
        Me.Controls.Add(Me.Color_Mixer_Remixer)
        Me.Controls.Add(Me.Exit_Button)
        Me.Controls.Add(Me.View_Color_Button)
        Me.Controls.Add(Me.Blue_Label)
        Me.Controls.Add(Me.Green_Label)
        Me.Controls.Add(Me.Red_Label)
        Me.Controls.Add(Me.Blue_TextBox)
        Me.Controls.Add(Me.Green_TextBox)
        Me.Controls.Add(Me.Red_TextBox)
        Me.Controls.Add(Me.The_real_simular_oval)
        Me.Controls.Add(Me.Back_Round_Box)
        Me.Name = "ColorMixerRemixer"
        Me.Text = "Color Mixer Remixer"
        CType(Me.Back_Round_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.The_real_simular_oval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Back_Round_Box As PictureBox
    Friend WithEvents Exit_Button As Button
    Friend WithEvents View_Color_Button As Button
    Friend WithEvents Blue_Label As Label
    Friend WithEvents Green_Label As Label
    Friend WithEvents Red_Label As Label
    Friend WithEvents Blue_TextBox As TextBox
    Friend WithEvents Green_TextBox As TextBox
    Friend WithEvents Red_TextBox As TextBox
    Friend WithEvents The_real_simular_oval As PictureBox
    Friend WithEvents Color_Mixer_Remixer As Label
End Class
