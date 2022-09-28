Public Class Form1

    'Cauculate Button
    Private Sub Cauculate_Button_Click(sender As Object, e As EventArgs) Handles Cauculate_Button.Click
        Dim Decaf As Decimal
        Dim Regular As Decimal
        Decimal.TryParse(Regular_TextBox.Text, Regular)
        Decimal.TryParse(Decaf_TextBox.Text, Decaf)
        Pounds_TextBox.Text = Regular + Decaf
        Total_Price_TextBox.Text = (Regular + Decaf) * 4.99
    End Sub
    Private Sub Print_Button_Click(sender As Object, e As EventArgs) Handles Print_Button.Click
        Eror_Mesage_Label.Visible = True
        Printer_Fail_Label.Visible = True
    End Sub
    Private Sub Cancle_Button_Click(sender As Object, e As EventArgs) Handles Cancle_Button.Click
        Regular_TextBox.Text = ""
        Decaf_TextBox.Text = ""
        Pounds_TextBox.Text = ""
        Total_Price_TextBox.Text = ""
        Eror_Mesage_Label.Visible = False
        Printer_Fail_Label.Visible = False
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub


End Class
