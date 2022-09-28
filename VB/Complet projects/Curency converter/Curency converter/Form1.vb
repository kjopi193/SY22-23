Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Convert_Button.Click
        Dim Dollars As Decimal
        Decimal.TryParse(TextBox1.Text, Dollars)
        Dim Pesos As Decimal
        Pesos = Dollars * 20
        Label1.Text = Pesos.ToString("n2")

        'Uniq curency Czech - Russia - POLLKSA!!!! 
        'Contries that use Euro- Montenegro - Slovakia - Slovania - Estonia - Lituania - Latvia
        'older currencys retired- Montenegro - Slovakia - Slovania
    End Sub
End Class
