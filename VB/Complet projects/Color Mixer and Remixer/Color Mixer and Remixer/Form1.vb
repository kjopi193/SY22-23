Public Class ColorMixerRemixer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inputRed As Integer
        Dim inputGreen As Integer
        Dim inputBlue As Integer

        Integer.TryParse(Red_TextBox.Text, inputRed)
        Integer.TryParse(Green_TextBox.Text, inputGreen)
        Integer.TryParse(Blue_TextBox.Text, inputBlue)

    Private Sub View_Color_Button_Click(sender As Object, e As EventArgs) Handles View_Color_Button.Click

        The_real_simular_oval.BackColor =
        Color.FromArgb(inputRed, inputGreen, inputBlue)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub
End Class
