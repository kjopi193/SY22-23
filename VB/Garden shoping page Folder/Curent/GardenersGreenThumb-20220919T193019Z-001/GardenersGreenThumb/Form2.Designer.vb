﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2_Back_Copy
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
        Me.Plant_Info_Label = New System.Windows.Forms.Label()
        Me.Disscription_Label = New System.Windows.Forms.Label()
        Me.Add_To_Cart_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Quantati_Cost_Label = New System.Windows.Forms.Label()
        Me.CostFor1_Label = New System.Windows.Forms.Label()
        Me.Quantaty_TextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Plant_Info_Box = New System.Windows.Forms.PictureBox()
        Me.Price_Box = New System.Windows.Forms.PictureBox()
        Me.Plant_Name_Label = New System.Windows.Forms.Label()
        Me.Plant_PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Gardeners_Green_Thumb_Label = New System.Windows.Forms.Label()
        CType(Me.Plant_Info_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Price_Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Plant_PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Plant_Info_Label
        '
        Me.Plant_Info_Label.AutoSize = True
        Me.Plant_Info_Label.BackColor = System.Drawing.Color.SeaGreen
        Me.Plant_Info_Label.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Plant_Info_Label.Location = New System.Drawing.Point(667, 243)
        Me.Plant_Info_Label.Name = "Plant_Info_Label"
        Me.Plant_Info_Label.Size = New System.Drawing.Size(201, 21)
        Me.Plant_Info_Label.TabIndex = 48
        Me.Plant_Info_Label.Text = "Information about the plant"
        '
        'Disscription_Label
        '
        Me.Disscription_Label.AutoSize = True
        Me.Disscription_Label.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Disscription_Label.Location = New System.Drawing.Point(679, 208)
        Me.Disscription_Label.Name = "Disscription_Label"
        Me.Disscription_Label.Size = New System.Drawing.Size(137, 24)
        Me.Disscription_Label.TabIndex = 47
        Me.Disscription_Label.Text = "Discription"
        '
        'Add_To_Cart_Button
        '
        Me.Add_To_Cart_Button.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Add_To_Cart_Button.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Add_To_Cart_Button.Location = New System.Drawing.Point(360, 703)
        Me.Add_To_Cart_Button.Name = "Add_To_Cart_Button"
        Me.Add_To_Cart_Button.Size = New System.Drawing.Size(115, 31)
        Me.Add_To_Cart_Button.TabIndex = 46
        Me.Add_To_Cart_Button.Text = "Add to Cart"
        Me.Add_To_Cart_Button.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label3.Location = New System.Drawing.Point(403, 664)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Trees"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label.Location = New System.Drawing.Point(305, 663)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(52, 15)
        Me.Label.TabIndex = 44
        Me.Label.Text = "Cost for "
        '
        'Quantati_Cost_Label
        '
        Me.Quantati_Cost_Label.AutoSize = True
        Me.Quantati_Cost_Label.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Quantati_Cost_Label.Location = New System.Drawing.Point(490, 664)
        Me.Quantati_Cost_Label.Name = "Quantati_Cost_Label"
        Me.Quantati_Cost_Label.Size = New System.Drawing.Size(25, 15)
        Me.Quantati_Cost_Label.TabIndex = 43
        Me.Quantati_Cost_Label.Text = "l4 $"
        '
        'CostFor1_Label
        '
        Me.CostFor1_Label.AutoSize = True
        Me.CostFor1_Label.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CostFor1_Label.Location = New System.Drawing.Point(490, 622)
        Me.CostFor1_Label.Name = "CostFor1_Label"
        Me.CostFor1_Label.Size = New System.Drawing.Size(40, 15)
        Me.CostFor1_Label.TabIndex = 42
        Me.CostFor1_Label.Text = "11.00$"
        '
        'Quantaty_TextBox
        '
        Me.Quantaty_TextBox.Location = New System.Drawing.Point(365, 661)
        Me.Quantaty_TextBox.Name = "Quantaty_TextBox"
        Me.Quantaty_TextBox.Size = New System.Drawing.Size(21, 23)
        Me.Quantaty_TextBox.TabIndex = 41
        Me.Quantaty_TextBox.Text = "4"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label13.Location = New System.Drawing.Point(305, 622)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 15)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Plant name"
        '
        'Plant_Info_Box
        '
        Me.Plant_Info_Box.BackColor = System.Drawing.Color.SeaGreen
        Me.Plant_Info_Box.Location = New System.Drawing.Point(659, 235)
        Me.Plant_Info_Box.Name = "Plant_Info_Box"
        Me.Plant_Info_Box.Size = New System.Drawing.Size(420, 170)
        Me.Plant_Info_Box.TabIndex = 39
        Me.Plant_Info_Box.TabStop = False
        '
        'Price_Box
        '
        Me.Price_Box.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Price_Box.Location = New System.Drawing.Point(294, 599)
        Me.Price_Box.Name = "Price_Box"
        Me.Price_Box.Size = New System.Drawing.Size(254, 154)
        Me.Price_Box.TabIndex = 38
        Me.Price_Box.TabStop = False
        '
        'Plant_Name_Label
        '
        Me.Plant_Name_Label.AutoSize = True
        Me.Plant_Name_Label.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Plant_Name_Label.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Plant_Name_Label.Location = New System.Drawing.Point(220, 122)
        Me.Plant_Name_Label.Name = "Plant_Name_Label"
        Me.Plant_Name_Label.Size = New System.Drawing.Size(145, 24)
        Me.Plant_Name_Label.TabIndex = 37
        Me.Plant_Name_Label.Text = "Plant Name"
        '
        'Plant_PictureBox1
        '
        Me.Plant_PictureBox1.Location = New System.Drawing.Point(220, 150)
        Me.Plant_PictureBox1.Name = "Plant_PictureBox1"
        Me.Plant_PictureBox1.Size = New System.Drawing.Size(433, 430)
        Me.Plant_PictureBox1.TabIndex = 36
        Me.Plant_PictureBox1.TabStop = False
        '
        'Gardeners_Green_Thumb_Label
        '
        Me.Gardeners_Green_Thumb_Label.AutoSize = True
        Me.Gardeners_Green_Thumb_Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Gardeners_Green_Thumb_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Gardeners_Green_Thumb_Label.Font = New System.Drawing.Font("Lucida Calligraphy", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Gardeners_Green_Thumb_Label.Location = New System.Drawing.Point(697, 55)
        Me.Gardeners_Green_Thumb_Label.Name = "Gardeners_Green_Thumb_Label"
        Me.Gardeners_Green_Thumb_Label.Size = New System.Drawing.Size(417, 39)
        Me.Gardeners_Green_Thumb_Label.TabIndex = 35
        Me.Gardeners_Green_Thumb_Label.Text = "Gardeners Green Thumb"
        '
        'Form2_Back_Copy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 808)
        Me.Controls.Add(Me.Plant_Info_Label)
        Me.Controls.Add(Me.Disscription_Label)
        Me.Controls.Add(Me.Add_To_Cart_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Quantati_Cost_Label)
        Me.Controls.Add(Me.CostFor1_Label)
        Me.Controls.Add(Me.Quantaty_TextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Plant_Info_Box)
        Me.Controls.Add(Me.Price_Box)
        Me.Controls.Add(Me.Plant_Name_Label)
        Me.Controls.Add(Me.Plant_PictureBox1)
        Me.Controls.Add(Me.Gardeners_Green_Thumb_Label)
        Me.Name = "Form2_Back_Copy"
        Me.Text = "Form2"
        CType(Me.Plant_Info_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Price_Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Plant_PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Plant_Info_Label As Label
    Friend WithEvents Disscription_Label As Label
    Friend WithEvents Add_To_Cart_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Quantati_Cost_Label As Label
    Friend WithEvents CostFor1_Label As Label
    Friend WithEvents Quantaty_TextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Plant_Info_Box As PictureBox
    Friend WithEvents Price_Box As PictureBox
    Friend WithEvents Plant_Name_Label As Label
    Friend WithEvents Plant_PictureBox1 As PictureBox
    Friend WithEvents Gardeners_Green_Thumb_Label As Label
End Class