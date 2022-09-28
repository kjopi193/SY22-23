Public Class Cart_and_casher_Form
    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Total As Decimal
        Total = GlobalModule.PriceOfHerbs + PriceOfTrees

        'assign these forms labels based on global variables
        Texas_Mountain_Laurel_Quantity_Label.Text = Texas_Mountain_Laurel_Quantity_In_Cart
        Texas_Mountain_Laurel_Cost_Label.Text = Texas_Mountain_Laurel_Total_Price_In_Cart





    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Texas_Mountain_Laurel_Clear_Button_Click(sender As Object, e As EventArgs) Handles Texas_Mountain_Laurel_Clear_Button.Click

        'clear button clicked for Texas Mountain laurel
        Texas_Mountain_Laurel_Quantity_Label.Text = "==="
        Texas_Mountain_Laurel_Cost_Label.Text = "---"
        Texas_Mountain_Laurel_Quantity_In_Cart = 0
        Texas_Mountain_Laurel_Total_Price_In_Cart = 0.0



    End Sub
End Class