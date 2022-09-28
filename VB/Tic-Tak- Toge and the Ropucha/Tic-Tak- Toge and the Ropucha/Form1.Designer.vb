<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.Reset_match_Button = New System.Windows.Forms.Button()
        Me.Tic_Tak_tow_Label = New System.Windows.Forms.Label()
        Me.Score1_Tracker = New System.Windows.Forms.Label()
        Me.Player1_score_Label = New System.Windows.Forms.Label()
        Me.Score2_Tracker = New System.Windows.Forms.Label()
        Me.Player2_score_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(448, 213)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(71, 65)
        Me.B1.TabIndex = 0
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(540, 213)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(71, 65)
        Me.B2.TabIndex = 1
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(633, 213)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(71, 65)
        Me.B3.TabIndex = 2
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(448, 298)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(71, 65)
        Me.B4.TabIndex = 3
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(542, 298)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(71, 65)
        Me.B5.TabIndex = 4
        Me.B5.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(633, 298)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(71, 65)
        Me.B6.TabIndex = 5
        Me.B6.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.Location = New System.Drawing.Point(448, 384)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(71, 65)
        Me.B7.TabIndex = 6
        Me.B7.UseVisualStyleBackColor = True
        '
        'B8
        '
        Me.B8.Location = New System.Drawing.Point(540, 384)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(71, 65)
        Me.B8.TabIndex = 7
        Me.B8.UseVisualStyleBackColor = True
        '
        'B9
        '
        Me.B9.Location = New System.Drawing.Point(633, 384)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(71, 65)
        Me.B9.TabIndex = 8
        Me.B9.UseVisualStyleBackColor = True
        '
        'Reset_match_Button
        '
        Me.Reset_match_Button.BackColor = System.Drawing.Color.ForestGreen
        Me.Reset_match_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_match_Button.Location = New System.Drawing.Point(490, 477)
        Me.Reset_match_Button.Name = "Reset_match_Button"
        Me.Reset_match_Button.Size = New System.Drawing.Size(185, 39)
        Me.Reset_match_Button.TabIndex = 9
        Me.Reset_match_Button.Text = "Restart Match"
        Me.Reset_match_Button.UseVisualStyleBackColor = False
        '
        'Tic_Tak_tow_Label
        '
        Me.Tic_Tak_tow_Label.AutoSize = True
        Me.Tic_Tak_tow_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tic_Tak_tow_Label.Location = New System.Drawing.Point(404, 80)
        Me.Tic_Tak_tow_Label.Name = "Tic_Tak_tow_Label"
        Me.Tic_Tak_tow_Label.Size = New System.Drawing.Size(348, 36)
        Me.Tic_Tak_tow_Label.TabIndex = 10
        Me.Tic_Tak_tow_Label.Text = "Tic Tak two one, three?"
        '
        'Score1_Tracker
        '
        Me.Score1_Tracker.AutoSize = True
        Me.Score1_Tracker.Location = New System.Drawing.Point(227, 433)
        Me.Score1_Tracker.Name = "Score1_Tracker"
        Me.Score1_Tracker.Size = New System.Drawing.Size(28, 16)
        Me.Score1_Tracker.TabIndex = 11
        Me.Score1_Tracker.Text = "___"
        '
        'Player1_score_Label
        '
        Me.Player1_score_Label.AutoSize = True
        Me.Player1_score_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1_score_Label.Location = New System.Drawing.Point(171, 374)
        Me.Player1_score_Label.Name = "Player1_score_Label"
        Me.Player1_score_Label.Size = New System.Drawing.Size(148, 25)
        Me.Player1_score_Label.TabIndex = 12
        Me.Player1_score_Label.Text = "Player1 Score"
        '
        'Score2_Tracker
        '
        Me.Score2_Tracker.AutoSize = True
        Me.Score2_Tracker.Location = New System.Drawing.Point(901, 433)
        Me.Score2_Tracker.Name = "Score2_Tracker"
        Me.Score2_Tracker.Size = New System.Drawing.Size(28, 16)
        Me.Score2_Tracker.TabIndex = 13
        Me.Score2_Tracker.Text = "___"
        '
        'Player2_score_Label
        '
        Me.Player2_score_Label.AutoSize = True
        Me.Player2_score_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2_score_Label.Location = New System.Drawing.Point(846, 374)
        Me.Player2_score_Label.Name = "Player2_score_Label"
        Me.Player2_score_Label.Size = New System.Drawing.Size(148, 25)
        Me.Player2_score_Label.TabIndex = 15
        Me.Player2_score_Label.Text = "Player2 Score"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 734)
        Me.Controls.Add(Me.Player2_score_Label)
        Me.Controls.Add(Me.Score2_Tracker)
        Me.Controls.Add(Me.Player1_score_Label)
        Me.Controls.Add(Me.Score1_Tracker)
        Me.Controls.Add(Me.Tic_Tak_tow_Label)
        Me.Controls.Add(Me.Reset_match_Button)
        Me.Controls.Add(Me.B9)
        Me.Controls.Add(Me.B8)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B1 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B7 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B9 As Button
    Friend WithEvents Reset_match_Button As Button
    Friend WithEvents Tic_Tak_tow_Label As Label
    Friend WithEvents Score1_Tracker As Label
    Friend WithEvents Player1_score_Label As Label
    Friend WithEvents Score2_Tracker As Label
    Friend WithEvents Player2_score_Label As Label
End Class
