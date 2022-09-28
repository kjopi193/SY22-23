Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NorthMacidoniaButton.Click
        Displaypicturbox.Image = NorthMacidonianFlag.Image
        Capitallable_2.Text = "Skopje"
        CurencyLabl_2.Text = "Macedonian denar"
        LandAreaLabl_2.Text = "9,928 miles"
        NaboringContryiesLabl_2 = ""
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles BulgariaFlag.Click

    End Sub
End Class
