<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cart_and_casher_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Texas_Mountain_Laurel_Clear_Button = New System.Windows.Forms.Button()
        Me.Texas_Mountain_Laurel_Quantity_Label = New System.Windows.Forms.Label()
        Me.Texas_Mountain_Laurel_Cost_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Texas Mountain Laurel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost"
        '
        'Texas_Mountain_Laurel_Clear_Button
        '
        Me.Texas_Mountain_Laurel_Clear_Button.Location = New System.Drawing.Point(533, 82)
        Me.Texas_Mountain_Laurel_Clear_Button.Name = "Texas_Mountain_Laurel_Clear_Button"
        Me.Texas_Mountain_Laurel_Clear_Button.Size = New System.Drawing.Size(75, 23)
        Me.Texas_Mountain_Laurel_Clear_Button.TabIndex = 3
        Me.Texas_Mountain_Laurel_Clear_Button.Text = "Clear"
        Me.Texas_Mountain_Laurel_Clear_Button.UseVisualStyleBackColor = True
        '
        'Texas_Mountain_Laurel_Quantity_Label
        '
        Me.Texas_Mountain_Laurel_Quantity_Label.AutoSize = True
        Me.Texas_Mountain_Laurel_Quantity_Label.Location = New System.Drawing.Point(294, 86)
        Me.Texas_Mountain_Laurel_Quantity_Label.Name = "Texas_Mountain_Laurel_Quantity_Label"
        Me.Texas_Mountain_Laurel_Quantity_Label.Size = New System.Drawing.Size(22, 15)
        Me.Texas_Mountain_Laurel_Quantity_Label.TabIndex = 4
        Me.Texas_Mountain_Laurel_Quantity_Label.Text = "---"
        '
        'Texas_Mountain_Laurel_Cost_Label
        '
        Me.Texas_Mountain_Laurel_Cost_Label.AutoSize = True
        Me.Texas_Mountain_Laurel_Cost_Label.Location = New System.Drawing.Point(408, 86)
        Me.Texas_Mountain_Laurel_Cost_Label.Name = "Texas_Mountain_Laurel_Cost_Label"
        Me.Texas_Mountain_Laurel_Cost_Label.Size = New System.Drawing.Size(22, 15)
        Me.Texas_Mountain_Laurel_Cost_Label.TabIndex = 5
        Me.Texas_Mountain_Laurel_Cost_Label.Text = "---"
        '
        'Cart_and_casher_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 709)
        Me.Controls.Add(Me.Texas_Mountain_Laurel_Cost_Label)
        Me.Controls.Add(Me.Texas_Mountain_Laurel_Quantity_Label)
        Me.Controls.Add(Me.Texas_Mountain_Laurel_Clear_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cart_and_casher_Form"
        Me.Text = "Your Cart and Cashere"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Texas_Mountain_Laurel_Clear_Button As Button
    Friend WithEvents Texas_Mountain_Laurel_Quantity_Label As Label
    Friend WithEvents Texas_Mountain_Laurel_Cost_Label As Label
End Class
