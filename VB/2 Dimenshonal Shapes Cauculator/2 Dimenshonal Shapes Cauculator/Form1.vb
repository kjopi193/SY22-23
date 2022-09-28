Public Class Two_Dimenshonal_Shapes_Cauculator_Form

    'Clear Button
    Sub Clear()
        Length_TextBox.Clear()
        Width_TextBox.Clear()
        Area_Outcom_Label.Text = ""
        Perimeter_Outcom_Label.Text = ""



    End Sub

    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        clear()
        highlight(Color.Beige)
    End Sub

    'Exit_Button
    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Me.Close()
    End Sub



    Sub highlight(C As Color)
        Length_TextBox.BackColor = Color.Yellow
        Width_TextBox.BackColor = Color.Yellow
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click BackColor.Change
        highlight(sender.backcolor)

    End Sub


    Private Sub Cauculate_Button_Click(sender As Object, e As EventArgs) Handles Cauculate_Button.Click
        Dim Length As Integer
        Dim Width As Integer
        Integer.TryParse(Length_TextBox.Text, Length)
        Integer.TryParse(Width_TextBox.Text, Width)
        Area_Label.Text = Area(Length, Width)
    End Sub

    'hear ear up above the adobe.

    Function Area(L As Integer, W As Integer) As Integer
        Return L * W
    End Function

    Function Perimiter(L As Integer, W As Integer) As Integer
        Return 2 * L * Width
    End Function


    Function Circle(Radius As Integer)
        Return Math.PI * Radius * Radius
    End Function

    Private Sub Cercle_Area_Lable_Click(sender As Object, e As EventArgs) Handles Circle_Area_Lable.Click
        Dim Length As Integer

        Integer.TryParse(Length_TextBox.Text, Length)
        Area_Outcom_Label.Text = Circle(Length)
    End Sub

    Function CirclrPerimeter(Radius As Integer) As Decimal
        Return 2 * Math.PI * Radius
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Perimiter_lableLabel.Click
        Perimiter_lableLabel.Text = Circle() Perimiter
    End Sub
End Class
