Public Class Form1
    Private Sub Cauculate_Button_Click(sender As Object, e As EventArgs) Handles Cauculate_Button.Click
        Dim Toatal As Decimal
        Decimal.TryParse(Toatal_TextBox.Text, Toatal)
        Dim grandToatal As Decimal
        grandToatal = Toatal * 1.15
        Grand_Toatal_Label.Text = grandToatal.ToString("C2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
