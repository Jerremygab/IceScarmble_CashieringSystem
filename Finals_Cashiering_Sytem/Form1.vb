Imports System.Runtime
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private syrupstrawberry_rbtn As Object

    Public Sub clearme(ByVal root As Control)

        For Each ctrl As Control In root.Controls
            clearme(ctrl)
            If TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            End If
        Next ctrl

    End Sub
    Private Sub Addtoorder_btn_Click(sender As Object, e As EventArgs) Handles Icescramble_orderbtn.Click

        Dim qty, price As Integer
        Dim order, size, syrup, addon As String
        qty = Val(IcescrambleQuantity_text.Text)

        'Nested if 
        'Order selection
        If OriginalSmall_rbtn.Checked Then
            price = qty * 35
            size = "Small"
            order = "Original Ice Scramble Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf OriginalMedium_rbtn.Checked Then
            price = qty * 50
            size = "Medium"
            order = "Original Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf OriginalLarge_rbtn.Checked Then
            price = qty * 68
            size = "Large"
            order = "Original Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf UbeQuezoSmall_rbtn.Checked Then
            price = qty * 35
            size = "Small"
            order = "UbeQuezo Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf UbeQuezoMedium_rbtn.Checked Then
            price = qty * 50
            size = "Medium"
            order = "UbeQuezo Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf UbeQuezoLarge_rbtn.Checked Then
            price = qty * 68
            size = "Large"
            order = "Ube Quezo Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf BukoPandanSmall_rbtn.Checked Then
            price = qty * 35
            size = "Small"
            order = "Buko Pandan  Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf BukoPandanMedium_rbtn.Checked Then
            price = qty * 50
            size = "Medium"
            order = "Buko Pandan  Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf BukoPandanLarge_rbtn.Checked Then
            price = qty * 68
            size = "Large"
            order = "Buko Pandan  Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf ChocoFudgeSmall_rbtn.Checked Then
            price = qty * 35
            size = "Small"
            order = "Choco Fudge  Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf ChocoFudgeMedium_rbtn.Checked Then
            price = qty * 50
            size = "Medium"
            order = "Choco Fudge Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If

            'Order selection
        ElseIf ChocoFudgeLarge_rbtn.Checked Then
            price = qty * 68
            size = "Large"
            order = "Choco Fudge Ice Scramble"
            'Syrup selection
            If Syrup_chocolaterbtn.Checked Then
                syrup = "Chocolate"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_caramelrbtn.Checked Then
                syrup = "Caramel"
                'Add-ons selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
                'Syrup Selection
            ElseIf Syrup_strawberryrbtn.Checked Then
                syrup = "Strawberry"
                'Add-ons Selection
                If AddonMilk_rbtn.Checked Then
                    price += 5
                    addon = "Milk"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonOreo_rbtn.Checked Then
                    price += 5
                    addon = "Oreo"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonPearl_rbtn.Checked Then
                    price += 5
                    addon = "Pearl"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonCheese_rbtn.Checked Then
                    price += 5
                    addon = "Cheese"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf AddonMarshmallow_rbtn.Checked Then
                    price += 5
                    addon = "Marshmallow"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                ElseIf Addonnone_rbtn.Checked Then
                    addon = "-"
                    If IcescrambleQuantity_text.Text = "" Then
                        MsgBox("Please Enter Quantity")
                    Else
                        Dim otherItems As String() = {order, size, syrup, addon, price}
                        Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                    End If
                Else
                    MsgBox("Please Select Your Add-ons or just select NONE")
                End If
            Else
                MsgBox("Please Select Your Syrup")
            End If
        Else
            MsgBox("Please Select Order")
        End If

        IcescrambleQuantity_text.Text = " "
        clearme(cm1_panel)

    End Sub

    Private Sub Milkshake_orderbtn_Click(sender As Object, e As EventArgs) Handles Milkshake_orderbtn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MilkshakeQuantity_text.Text)
        If OreoMedium_rbtn.Checked Then
            price = qty * 88
            order = "Oreo MilkShake"
            size = "Medium"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf OreoLarge_rbtn.Checked Then
            price = qty * 98
            order = "Oreo MilkShake"
            size = "Large"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf ChuckieMedium_rbtn.Checked Then
            price = qty * 98
            order = "Chuckie MilkShake"
            size = "Medium"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf ChuckieLarge_rbtn.Checked Then
            price = qty * 118
            order = "Chuckie MilkShake"
            size = "Large"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf CoffeeMedium_rbtn.Checked Then
            price = qty * 88
            order = "Coffee MilkShake"
            size = "Medium"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf CoffeeLarge_rbtn.Checked Then
            price = qty * 98
            order = "Coffee MilkShake"
            size = "Large"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf AvocadoMedium_rbtn.Checked Then
            price = qty * 88
            order = "Avocado MilkShake"
            size = "Medium"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf AvocadoLarge_rbtn.Checked Then
            price = qty * 98
            order = "Avocado MilkShake"
            size = "Large"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf ManggoGrahamMedium_rbtn.Checked Then
            price = qty * 98
            order = "Manggo Graham MilkShake"
            size = "Medium"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf ManggoGrahamLarge_rbtn.Checked Then
            price = qty * 118
            order = "Manggo Graham MilkShake"
            size = "Large"
            If MilkshakeQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        Else
            MsgBox("Please Select Order")
        End If
        MilkshakeQuantity_text.Text = " "
        clearme(cm2_panel)
    End Sub

    Private Sub Icecream_orderbtn_Click(sender As Object, e As EventArgs) Handles Icecream_orderbtn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(IcecreamQuantity_text.Text)
        If TobleroneSmall_rbtn.Checked Then
            price = qty * 75
            order = "Toblerone Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf TobleroneMedium_rbtn.Checked Then
            price = qty * 98
            order = "Toblerone Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf TobleroneLarge_rbtn.Checked Then
            price = qty * 120
            order = "Toblerone Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf ReeseSmall_rbtn.Checked Then
            price = qty * 75
            order = "Reese's Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf ReeseMedium_rbtn.Checked Then
            price = qty * 98
            order = "Reese's Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf ReeseLarge_rbtn.Checked Then
            price = qty * 120
            order = "Reese's Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MiniOreoSmall_rbtn.Checked Then
            price = qty * 75
            order = "Mini Oreo Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MiniOreoMedium_rbtn.Checked Then
            price = qty * 98
            order = "Mini Oreo Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MiniOreoLarge_rbtn.Checked Then
            price = qty * 120
            order = "Mini Oreo Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf HersheySmall_rbtn.Checked Then
            price = qty * 75
            order = "Hershey Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf HersheyMedium_rbtn.Checked Then
            price = qty * 98
            order = "Hershey Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf HersheyLarge_rbtn.Checked Then
            price = qty * 120
            order = "Hershey Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf KitkatSmall_rbtn.Checked Then
            price = qty * 75
            order = "Kitkat Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf KitkatMedium_rbtn.Checked Then
            price = qty * 98
            order = "Kitkat Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf KitkatLarge_rbtn.Checked Then
            price = qty * 120
            order = "Kitkat Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf SnickersSmall_rbtn.Checked Then
            price = qty * 75
            order = "Snickers Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf SnickersMedium_rbtn.Checked Then
            price = qty * 98
            order = "Snickers Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf SnickersLarge_rbtn.Checked Then
            price = qty * 120
            order = "Snickers Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MaltesersSmall_rbtn.Checked Then
            price = qty * 75
            order = "Maltesers Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MaltesersMedium_rbtn.Checked Then
            price = qty * 98
            order = "Maltesers Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MaltesersLarge_rbtn.Checked Then
            price = qty * 120
            order = "Maltesers Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf TwixSmall_rbtn.Checked Then
            price = qty * 75
            order = "Twix Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf TwixMedium_rbtn.Checked Then
            price = qty * 98
            order = "Twix Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf TwixLarge_rbtn.Checked Then
            price = qty * 120
            order = "Twix Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf PeperoSmall_rbtn.Checked Then
            price = qty * 75
            order = "Pepero Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf PeperoMedium_rbtn.Checked Then
            price = qty * 98
            order = "Pepero Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf PeperoLarge_rbtn.Checked Then
            price = qty * 120
            order = "Pepero Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MagnumSmall_rbtn.Checked Then
            price = qty * 85
            order = "Magnum Icecream"
            size = "Small"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MagnumMedium_rbtn.Checked Then
            price = qty * 108
            order = "Magnum Icecream"
            size = "Medium"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf MagnumLarge_rbtn.Checked Then
            price = qty * 130
            order = "Magnum Icecream"
            size = "Large"
            If IcecreamQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        Else
            MsgBox("Please Select Order")
        End If
        IcecreamQuantity_text.Text = " "
        clearme(cm3_panel)
    End Sub

    Private Sub Corndog_orderbtn_Click(sender As Object, e As EventArgs) Handles Corndog_orderbtn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(CorndogQuantity_text.Text)
        If Classic3pcs_rbtn.Checked Then
            price = qty * 45
            order = "Classic Mini Corndog"
            size = "3pcs"
            If CorndogQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf Classic6pcs_rbtn.Checked Then
            price = qty * 85
            order = "Classic Mini Corndog"
            size = "6pcs"
            If CorndogQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf Mozza3pcs_rbtn.Checked Then
            price = qty * 45
            order = "Classic + Mozza Mini Corndog"
            size = "3pcs"
            If CorndogQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf Mozza6pcs_rbtn.Checked Then
            price = qty * 85
            order = "Classic + Mozza Mini Corndog"
            size = "6pcs"
            If CorndogQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        Else
            MsgBox("Please Select order ")
        End If
        CorndogQuantity_text.Text = ""
        clearme(cm4_panel)
    End Sub

    Private Sub Poteyto_orderbtn_Click(sender As Object, e As EventArgs) Handles Poteyto_orderbtn.Click
        Dim qty, price As Integer
        Dim order, flavor, size As String
        qty = Val(PoteytoQuantity_text.Text)
        If PoteytoMedium_rbtn.Checked Then
            price = qty * 58
            size = "Medium"
            If FlavorCheese_rbtn.Checked Then
                flavor = "Cheese Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            ElseIf FlavorBBQ_rbtn.Checked Then
                flavor = "Barbeque Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            ElseIf FlavorSournCream_rbtn.Checked Then
                flavor = "Sour n Cream Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            Else
                MsgBox("Please Select Flavor")
            End If

        ElseIf PoteytoLarge_rbtn.Checked Then
            price = qty * 58
            size = "Large"
            If FlavorCheese_rbtn.Checked Then
                flavor = "Cheese Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            ElseIf FlavorBBQ_rbtn.Checked Then
                flavor = "Barbeque Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            ElseIf FlavorSournCream_rbtn.Checked Then
                flavor = "Sour n Cream Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            Else
                MsgBox("Please Select Flavor")
            End If

        ElseIf PoteytoSharing_rbtn.Checked Then
            price = qty * 58
            size = "Sharing"
            If FlavorCheese_rbtn.Checked Then
                flavor = "Cheese Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            ElseIf FlavorBBQ_rbtn.Checked Then
                flavor = "Barbeque Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            ElseIf FlavorSournCream_rbtn.Checked Then
                flavor = "Sour n Cream Poteyto"
                If PoteytoQuantity_text.Text = "" Then
                    MsgBox("Please Enter Quantity")
                Else
                    Dim otherItems As String() = {flavor, size, "-", "-", price}
                    Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
                End If
            Else
                MsgBox("Please Select Flavor")
            End If

        ElseIf AlacarteHasbrown_rbtn.Checked Then
            price = qty * 50
            order = "Hasbrown Ala Carte"
            size = "2pcs"
            If PoteytoQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        ElseIf AlacartCheesesticks_rbtn.Checked Then
            price = qty * 50
            order = "Cheese Sticks Ala Carte"
            size = "15pcs"
            If PoteytoQuantity_text.Text = "" Then
                MsgBox("Please Enter Quantity")
            Else
                Dim otherItems As String() = {order, size, "-", "-", price}
                Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
            End If
        Else
            MsgBox("Please Select order ")
        End If
        PoteytoQuantity_text.Text = ""
        clearme(cm5_panel)
    End Sub
    Private Sub OriginalSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles OriginalSmall_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Original
    End Sub

    Private Sub OriginalMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles OriginalMedium_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Original
    End Sub

    Private Sub OriginalLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles OriginalLarge_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Original
    End Sub

    Private Sub UbeQuezoSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles UbeQuezoSmall_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Ube
    End Sub

    Private Sub UbeQuezoMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles UbeQuezoMedium_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Ube
    End Sub

    Private Sub UbeQuezoLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles UbeQuezoLarge_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Ube
    End Sub

    Private Sub BukoPandanSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles BukoPandanSmall_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Bukopandan
    End Sub

    Private Sub BukoPandanMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles BukoPandanMedium_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Bukopandan
    End Sub

    Private Sub BukoPandanLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles BukoPandanLarge_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.Bukopandan
    End Sub

    Private Sub ChocoFudgeSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles ChocoFudgeSmall_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.logo
    End Sub

    Private Sub ChocoFudgeMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles ChocoFudgeMedium_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.logo

    End Sub

    Private Sub ChocoFudgeLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles ChocoFudgeLarge_rbtn.CheckedChanged
        Icescramble_Picbox.Image = My.Resources.logo
    End Sub

    Private Sub TobleroneSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles TobleroneSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Toblerone
    End Sub

    Private Sub TobleroneMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles TobleroneMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Toblerone
    End Sub

    Private Sub TobleroneLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles TobleroneLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Toblerone
    End Sub

    Private Sub ReeseSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles ReeseSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Reese
    End Sub

    Private Sub ReeseMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles ReeseMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Reese
    End Sub

    Private Sub ReeseLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles ReeseLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Reese
    End Sub

    Private Sub MiniOreoSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MiniOreoSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.MiniOreo
    End Sub

    Private Sub MiniOreoMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MiniOreoMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.MiniOreo
    End Sub

    Private Sub MiniOreoLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MiniOreoLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.MiniOreo
    End Sub

    Private Sub MagnumSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MagnumSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Magnum
    End Sub

    Private Sub MagnumMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MagnumMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Magnum
    End Sub

    Private Sub MagnumLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MagnumLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Magnum
    End Sub

    Private Sub PeperoSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles PeperoSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Pepero
    End Sub

    Private Sub PeperoMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles PeperoMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Pepero
    End Sub

    Private Sub PeperoLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles PeperoLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Pepero
    End Sub

    Private Sub TwixSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles TwixSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Twix
    End Sub

    Private Sub TwixMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles TwixMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Twix
    End Sub

    Private Sub TwixLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles TwixLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Twix
    End Sub

    Private Sub MaltesersSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MaltesersSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Maltesers
    End Sub
    Private Sub MaltesersMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MaltesersMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Maltesers
    End Sub
    Private Sub MaltesersLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles MaltesersLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Maltesers
    End Sub
    Private Sub SnickersSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles SnickersSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Snickers
    End Sub
    Private Sub SnickersMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles SnickersMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Snickers
    End Sub
    Private Sub SnickersLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles SnickersLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Snickers
    End Sub
    Private Sub KitkatSmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles KitkatSmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Kitkat
    End Sub

    Private Sub KitkatMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles KitkatMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Kitkat
    End Sub
    Private Sub KitkatLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles KitkatLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Kitkat
    End Sub
    Private Sub HersheySmall_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles HersheySmall_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Hershey
    End Sub

    Private Sub HersheyMedium_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles HersheyMedium_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Hershey
    End Sub
    Private Sub HersheyLarge_rbtn_CheckedChanged(sender As Object, e As EventArgs) Handles HersheyLarge_rbtn.CheckedChanged
        Icecream_Picbox.Image = My.Resources.Hershey
    End Sub
    Private Sub Proceed_btn_Click(sender As Object, e As EventArgs) Handles Proceed_btn.Click
        Dim Index As Integer
        Dim subtotal As Double

        For Index = 1 To Orders_list.Items.Count - 1
            Dim price As Decimal = CDbl(Orders_list.Items.Item(Index).SubItems(5).Text)
            subtotal += price
        Next

        Dim vat, total_vat As Decimal

        vat = (subtotal * 12) / 100
        total_vat = subtotal + vat

        PaymentSubtotal_text.Text = subtotal
        PaymentTotalDue_text.Text = total_vat
        PaymentVat_text.Text = vat

        Paymentform_panel1.Visible = True
    End Sub

    Private Sub Remove_btn_Click(sender As Object, e As EventArgs) Handles Remove_btn.Click
        For Each item As ListViewItem In Orders_list.SelectedItems
            Orders_list.Items.Remove(item)
        Next
    End Sub

    Private Sub Removeall_btn_Click(sender As Object, e As EventArgs) Handles Removeall_btn.Click
        Orders_list.Items.Clear()
    End Sub

    Private Sub Payment_ProceedBtn_Click(sender As Object, e As EventArgs) Handles Payment_ProceedBtn.Click
        Dim discount, totaldue, TotalDueWithDiscount As Decimal
        Dim NumPWDSEN, NumCustomer As Integer
        NumCustomer = Val(NumCustomer_text.Text)
        NumPWDSEN = Val(NumPWDSEN_text.Text)
        totaldue = Val(PaymentTotalDue_text.Text)

        If NumPWDSEN > NumCustomer Then
            MsgBox("Please Enter Correct Number of Customers")
        Else
            Paymentform_panel2.Visible = True
        End If

        If DiscountSenior_rbtn.Checked Or DiscountPWD_rbtn.Checked = True Then
            discount = ((totaldue / NumCustomer) * 0.2) * NumPWDSEN
            TotalDueWithDiscount = totaldue - discount

            PaymentTotalDue_text.Text = TotalDueWithDiscount
            Payment20Discount_text.Text = discount
        Else
            PaymentTotalDue_text.Text = totaldue
        End If


    End Sub

    Private Sub Payment_DoneBtn_Click(sender As Object, e As EventArgs) Handles Payment_DoneBtn.Click
        Dim totaldue, paid, change As Decimal
        totaldue = Val(PaymentTotalDue_text.Text)
        paid = Val(PaymentPaidAmount_text.Text)


        If totaldue > paid Then
            MsgBox("Please Enter Correct Amount")
        Else
            change = paid - totaldue
            PaymentChange_text.Text = change
            MsgBox("Hello " & Customername_text.Text & " Your Change is " & PaymentChange_text.Text & vbCrLf & "Thank You Come Again!")
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub


End Class
