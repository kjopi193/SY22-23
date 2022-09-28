Public Class Texas_Mountain_Laurel_Form
    Private Sub Texas_Mountain_Laurel_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'assign the description here
        Texas_Mountain_Laurel_Info_Box.Text = "Dermatophyllum secundiflorum is a species of flowering shrub or small tree in the family Fabaceae, that is native to the southwestern United States and Mexico. Common names include Texas mountain Texas mescalbean, frijolito, and frijolillo."

        'set the price for label based on the variable Price_Texas_Mountain_Laurel
        CostFor1_Label.Text = "$" + GlobalModule.Texas_Mountain_Laurel_Price.ToString()

        ' zero out these variables everytime we enter this form
        Texas_Mountain_Laurel_Quantity = 0
        Texas_Mountain_Laurel_Total_Price = 0


    End Sub

    Private Sub Quantaty_of_Texas_Mountain_Laurel_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Quantaty_of_Texas_Mountain_Laurel_TextBox.TextChanged

        ' get value from quantity text box and assign it to global variable 
        Integer.TryParse(Quantaty_of_Texas_Mountain_Laurel_TextBox.Text, Texas_Mountain_Laurel_Quantity)

        'calculate total price for all 
        Texas_Mountain_Laurel_Total_Price = Texas_Mountain_Laurel_Quantity * Texas_Mountain_Laurel_Price

        'assign calculated total to label
        Quantati_Cost_Label.Text = Texas_Mountain_Laurel_Total_Price.ToString("C2")

    End Sub

    Private Sub Add_Texas_Mountain_Laurel_To_Cart_Button_Click(sender As Object, e As EventArgs) Handles Add_Texas_Mountain_Laurel_To_Cart_Button.Click

        'add to shopping cart from this form
        Texas_Mountain_Laurel_Quantity_In_Cart = Texas_Mountain_Laurel_Quantity_In_Cart + Texas_Mountain_Laurel_Quantity
        Texas_Mountain_Laurel_Total_Price_In_Cart = Texas_Mountain_Laurel_Total_Price_In_Cart + Texas_Mountain_Laurel_Total_Price

        'close myself and open cart form
        Me.Close()
        Cart_and_casher_Form.Show()

    End Sub

    Private Sub Texas_Mountain_Laurel_Info_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Texas_Mountain_Laurel_Info_Box.TextChanged

    End Sub
End Class