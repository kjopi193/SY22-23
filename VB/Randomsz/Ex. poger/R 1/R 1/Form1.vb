Public Class R_1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Information_Button1.Click
        Name_Lable.Text = TextBox1.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Name_TextBox.Clear()
        CC_TextBox.Clear()
        ExpiorationDate_TextBox.Clear()
        ZIP_TextBox.Clear()
        Amount_TextBox.Clear()

        Dim Amount As Decimal
        Decimal.TryParse(Amount_TextBox.Text, Amount)
        Dim fee As Decimal
        fee = Amount
    End Sub

    Private Sub Fee_Text_Box_TextChanged(sender As Object, e As EventArgs) Handles Fee_Text_Box.TextChanged

    End Sub

    Private Sub Amount_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Amount_TextBox.TextChanged
    End Sub
End Class
