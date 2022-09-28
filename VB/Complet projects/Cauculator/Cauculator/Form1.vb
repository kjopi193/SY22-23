Public Class Form1

    Dim first As Decimal
    Dim second As Decimal
    Dim oper As String
    Dim Mem As Decimal
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button12.Click, Button10.Click, Button6.Click
        Display_TextBox.Text = Display_TextBox.Text + sender.text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Display_TextBox.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Decimal.TryParse(Display_TextBox.Text, first)
        oper = sender.text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Decimal.TryParse(Display_TextBox.Text, second)
        Display_TextBox.Text = first + second
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Decimal.TryParse(Display_TextBox.Text, second)
        Display_TextBox.Text = first - second
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(Display_TextBox.Text, second)
        Display_TextBox.Text = first * second
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Decimal.TryParse(Display_TextBox.Text, second)
        Display_TextBox.Text = first / second
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Decimal.TryParse(Display_TextBox.Text, first)
        Display_TextBox.Text = Math.Sqrt(first)

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Math.Sin()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Decimal.TryParse(Display_TextBox.Text, first)
        Display_TextBox.Text = Math.PI
    End Sub
End Class

