Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Turn As String = "X"
        Dim score1 As Integer
        Dim score2 As Integer
        Reset()
    End Sub

    Sub Reset()
        B1.Text = ""
        B2.Text = ""
        B3.Text = ""
        B4.Text = ""
        B9.Text = ""
        B6.Text = ""
        B7.Text = ""
        B8.Text = ""
        B9.Text = ""

        Player1_score_Label.Text = score1
        Player2_score_Label.Text = score2

    End Sub
    Sub click(B As Button)
        If B.Text = "" Then
            B.Text = "O"
        ElseIf B.Text = "O" Then
            B.Text = "X"
        Else
            B.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Click(sender As Object, e As EventArgs) Handles B9.Click, B8.Click, B7.Click, B6.Click, B5.Click, B4.Click, B3.Click, B2.Click, B1.Click

    End Sub
End Class

