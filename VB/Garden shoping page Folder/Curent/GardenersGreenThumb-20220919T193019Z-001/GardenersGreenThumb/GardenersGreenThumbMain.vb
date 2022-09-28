Public Class GardenersGreenThumbMain

    Private Sub GardenersGreenThumbMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        'initialization of global variables
        Texas_Mountain_Laurel_Quantity = 0
        Texas_Mountain_Laurel_Total_Price = 0
        Texas_Mountain_Laurel_Quantity_In_Cart = 0
        Texas_Mountain_Laurel_Total_Price_In_Cart = 0
        Texas_Mountain_Laurel_Price = 11.0



    End Sub






    'Trees
    Private Sub Texas_Mountain_Laurel_Button_Click(sender As Object, e As EventArgs) Handles Texas_Mountain_Laurel_Button.Click
        Texas_Mountain_Laurel_Form.Show()
        Cart_and_casher_Form.Close() ' close cart form if going to other form
    End Sub
    Private Sub Texas_Mountain_Laurel_PicturBox_Click(sender As Object, e As EventArgs) Handles Texas_Mountain_Laurel_PictureBox.Click
        Texas_Mountain_Laurel_Form.Show()
        Cart_and_casher_Form.Close()
    End Sub



    'Flowers
    Private Sub Eye_of_Africa_Flower_Button_Click(sender As Object, e As EventArgs) Handles Eye_of_Africa_Flower_Button.Click
        Eye_of_Africa_Flower_Form.Show()
        Cart_and_casher_Form.Close()
    End Sub
    Private Sub Eye_of_Africa_Flower_PicturBox_Click(sender As Object, e As EventArgs) Handles Eye_of_Africa_Flower_PictureBox.Click
        Eye_of_Africa_Flower_Form.Show()
        Cart_and_casher_Form.Close()
    End Sub



    'Small Plants
    Private Sub Eagle_fern_Button_Click(sender As Object, e As EventArgs) Handles Eagle_fern_Button.Click
        Eagle_fern_Form.Show()
        Cart_and_casher_Form.Close()
    End Sub
    Private Sub Eagle_fern_PicturBox_Click(sender As Object, e As EventArgs) Handles Eagle_Fern_PictureBox.Click
        Eagle_fern_Form.Show()
        Cart_and_casher_Form.Close()
    End Sub
















    Private Sub Show_Caret_Button_Click(sender As Object, e As EventArgs) Handles Show_Caret_Button.Click
        Cart_and_casher_Form.Show()
        Texas_Mountain_Laurel_Form.Close() ' close other forms if going to cart form
    End Sub
End Class
