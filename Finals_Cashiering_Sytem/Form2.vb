Public Class Form2
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

    Private Sub TobleroneSmall_btn_Click(sender As Object, e As EventArgs) Handles TobleroneSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(TobleroneQty_text.Text)
        price = qty * 75
        order = "Toblerone Icecream"
        size = "Small"
        If TobleroneQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        TobleroneQty_text.Text = ""
    End Sub

    Private Sub TobleroneMedium_btn_Click(sender As Object, e As EventArgs) Handles TobleroneMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(TobleroneQty_text.Text)
        price = qty * 98
        order = "Toblerone Icecream"
        size = "Medium"
        If TobleroneQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        TobleroneQty_text.Text = ""
    End Sub

    Private Sub TobleroneLarge_btn_Click(sender As Object, e As EventArgs) Handles TobleroneLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(TobleroneQty_text.Text)
        price = qty * 120
        order = "Toblerone Icecream"
        size = "Large"
        If TobleroneQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        TobleroneQty_text.Text = ""
    End Sub

    Private Sub ReeseSmall_btn_Click(sender As Object, e As EventArgs) Handles ReeseSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(ReeseQty_text.Text)
        price = qty * 75
        order = "Reese Icecream"
        size = "Small"
        If ReeseQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        ReeseQty_text.Text = ""
    End Sub
    Private Sub ReeseMedium_btn_Click(sender As Object, e As EventArgs) Handles ReeseMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(ReeseQty_text.Text)
        price = qty * 98
        order = "Reese Icecream"
        size = "Medium"
        If ReeseQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        ReeseQty_text.Text = ""
    End Sub
    Private Sub ReeseLarge_btn_Click(sender As Object, e As EventArgs) Handles ReeseLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(ReeseQty_text.Text)
        price = qty * 120
        order = "Reese Icecream"
        size = "Large"
        If ReeseQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        ReeseQty_text.Text = ""
    End Sub
    Private Sub MiniOreoSmall_btn_Click(sender As Object, e As EventArgs) Handles MiniOreoSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MiniOreoQty_text.Text)
        price = qty * 75
        order = "Mini Oreo Icecream"
        size = "Small"
        If MiniOreoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MiniOreoQty_text.Text = ""
    End Sub
    Private Sub MiniOreoMedium_btn_Click(sender As Object, e As EventArgs) Handles MiniOreoMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MiniOreoQty_text.Text)
        price = qty * 98
        order = "Mini Oreo Icecream"
        size = "Medium"
        If MiniOreoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MiniOreoQty_text.Text = ""
    End Sub
    Private Sub MiniOreoLarge_btn_Click(sender As Object, e As EventArgs) Handles MiniOreoLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MiniOreoQty_text.Text)
        price = qty * 120
        order = "Mini Oreo Icecream"
        size = "Large"
        If MiniOreoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MiniOreoQty_text.Text = ""
    End Sub
    Private Sub HersheySmall_btn_Click(sender As Object, e As EventArgs) Handles HersheySmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(HersheyQty_text.Text)
        price = qty * 75
        order = "Hershey Icecream"
        size = "Small"
        If HersheyQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        HersheyQty_text.Text = ""
    End Sub
    Private Sub HersheyMedium_btn_Click(sender As Object, e As EventArgs) Handles HersheyMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(HersheyQty_text.Text)
        price = qty * 98
        order = "Hershey Icecream"
        size = "Medium"
        If HersheyQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        HersheyQty_text.Text = ""
    End Sub
    Private Sub HersheyLarge_btn_Click(sender As Object, e As EventArgs) Handles HersheyLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(HersheyQty_text.Text)
        price = qty * 120
        order = "Hershey Icecream"
        size = "Large"
        If HersheyQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        HersheyQty_text.Text = ""
    End Sub
    Private Sub KitkatSmall_btn_Click(sender As Object, e As EventArgs) Handles KitkatSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(KitkatQty_text.Text)
        price = qty * 75
        order = "Kitkat Icecream"
        size = "Small"
        If KitkatQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        KitkatQty_text.Text = ""
    End Sub
    Private Sub KitkatMedium_btn_Click(sender As Object, e As EventArgs) Handles KitkatMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(KitkatQty_text.Text)
        price = qty * 98
        order = "Kitkat Icecream"
        size = "Medium"
        If KitkatQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        KitkatQty_text.Text = ""
    End Sub
    Private Sub KitkatLarge_btn_Click(sender As Object, e As EventArgs) Handles KitkatLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(KitkatQty_text.Text)
        price = qty * 120
        order = "Kitkat Icecream"
        size = "Large"
        If KitkatQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        KitkatQty_text.Text = ""
    End Sub

    Private Sub SnickersSmall_btn_Click(sender As Object, e As EventArgs) Handles SnickersSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(SnickersQty_text.Text)
        price = qty * 75
        order = "Snickers Icecream"
        size = "Small"
        If SnickersQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        SnickersQty_text.Text = ""
    End Sub

    Private Sub SnickersMedium_btn_Click(sender As Object, e As EventArgs) Handles SnickersMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(SnickersQty_text.Text)
        price = qty * 98
        order = "Snickers Icecream"
        size = "Medium"
        If SnickersQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        SnickersQty_text.Text = ""
    End Sub

    Private Sub SnickersLarge_btn_Click(sender As Object, e As EventArgs) Handles SnickersLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(SnickersQty_text.Text)
        price = qty * 120
        order = "Snickers Icecream"
        size = "Large"
        If SnickersQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        SnickersQty_text.Text = ""
    End Sub

    Private Sub MaltesersSmall_btn_Click(sender As Object, e As EventArgs) Handles MaltesersSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MaltesersQty_text.Text)
        price = qty * 75
        order = "Maltesers Icecream"
        size = "Small"
        If MaltesersQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MaltesersQty_text.Text = ""
    End Sub

    Private Sub MaltesersMedium_btn_Click(sender As Object, e As EventArgs) Handles MaltesersMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MaltesersQty_text.Text)
        price = qty * 98
        order = "Maltesers Icecream"
        size = "Medium"
        If MaltesersQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MaltesersQty_text.Text = ""
    End Sub

    Private Sub MaltesersLarge_btn_Click(sender As Object, e As EventArgs) Handles MaltesersLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MaltesersQty_text.Text)
        price = qty * 120
        order = "Maltesers Icecream"
        size = "Large"
        If MaltesersQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MaltesersQty_text.Text = ""
    End Sub

    Private Sub TwixSmall_btn_Click(sender As Object, e As EventArgs) Handles TwixSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(TwixQty_text.Text)
        price = qty * 75
        order = "Twix Icecream"
        size = "Small"
        If TwixQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        TwixQty_text.Text = ""
    End Sub

    Private Sub TwixMedium_btn_Click(sender As Object, e As EventArgs) Handles TwixMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(TwixQty_text.Text)
        price = qty * 98
        order = "Twix Icecream"
        size = "Medium"
        If TwixQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        TwixQty_text.Text = ""
    End Sub

    Private Sub TwixLarge_btn_Click(sender As Object, e As EventArgs) Handles TwixLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(TwixQty_text.Text)
        price = qty * 120
        order = "Twix Icecream"
        size = "Large"
        If TwixQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        TwixQty_text.Text = ""
    End Sub

    Private Sub PeperoSmall_btn_Click(sender As Object, e As EventArgs) Handles PeperoSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(PeperoQty_text.Text)
        price = qty * 75
        order = "Pepero Icecream"
        size = "Small"
        If PeperoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        PeperoQty_text.Text = ""
    End Sub

    Private Sub PeperoMedium_btn_Click(sender As Object, e As EventArgs) Handles PeperoMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(PeperoQty_text.Text)
        price = qty * 98
        order = "Pepero Icecream"
        size = "Medium"
        If PeperoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        PeperoQty_text.Text = ""
    End Sub

    Private Sub PeperoLarge_btn_Click(sender As Object, e As EventArgs) Handles PeperoLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(PeperoQty_text.Text)
        price = qty * 120
        order = "Pepero Icecream"
        size = "Large"
        If PeperoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        PeperoQty_text.Text = ""
    End Sub

    Private Sub MagnumSmall_btn_Click(sender As Object, e As EventArgs) Handles MagnumSmall_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MagnumQty_text.Text)
        price = qty * 85
        order = "Magnum Icecream"
        size = "Small"
        If MagnumQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MagnumQty_text.Text = ""
    End Sub

    Private Sub MagnumMedium_btn_Click(sender As Object, e As EventArgs) Handles MagnumMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MagnumQty_text.Text)
        price = qty * 108
        order = "Magnum Icecream"
        size = "Medium"
        If MagnumQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MagnumQty_text.Text = ""
    End Sub

    Private Sub MagnumLarge_btn_Click(sender As Object, e As EventArgs) Handles MagnumLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(MagnumQty_text.Text)
        price = qty * 130
        order = "Magnum Icecream"
        size = "Large"
        If MagnumQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        MagnumQty_text.Text = ""
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
    Private Sub OreoMedium_btn_Click(sender As Object, e As EventArgs) Handles OreoMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(OreoQty_text.Text)
        price = qty * 88
        order = "Oreo Icecream"
        size = "Medium"
        If OreoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        OreoQty_text.Text = ""
    End Sub

    Private Sub OreoLarge_btn_Click(sender As Object, e As EventArgs) Handles OreoLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(OreoQty_text.Text)
        price = qty * 98
        order = "Oreo Icecream"
        size = "Large"
        If OreoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        OreoQty_text.Text = ""
    End Sub

    Private Sub ChuckieMedium_btn_Click(sender As Object, e As EventArgs) Handles ChuckieMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(ChuckieQty_text.Text)
        price = qty * 98
        order = "Chuckie Icecream"
        size = "Medium"
        If ChuckieQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        ChuckieQty_text.Text = ""
    End Sub

    Private Sub ChuckieLarge_btn_Click(sender As Object, e As EventArgs) Handles ChuckieLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(ChuckieQty_text.Text)
        price = qty * 118
        order = "Chuckie Icecream"
        size = "Large"
        If ChuckieQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        ChuckieQty_text.Text = ""
    End Sub

    Private Sub CoffeeMedium_btn_Click(sender As Object, e As EventArgs) Handles CoffeeMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(CoffeeQty_text.Text)
        price = qty * 88
        order = "Coffee Icecream"
        size = "Medium"
        If CoffeeQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        CoffeeQty_text.Text = ""
    End Sub

    Private Sub CoffeeLarge_btn_Click(sender As Object, e As EventArgs) Handles CoffeeLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(CoffeeQty_text.Text)
        price = qty * 108
        order = "Coffee Icecream"
        size = "Large"
        If CoffeeQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        CoffeeQty_text.Text = ""
    End Sub

    Private Sub AvocadoMedium_btn_Click(sender As Object, e As EventArgs) Handles AvocadoMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(AvocadoQty_text.Text)
        price = qty * 88
        order = "Avocado Icecream"
        size = "Medium"
        If AvocadoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        AvocadoQty_text.Text = ""
    End Sub

    Private Sub AvocadoLarge_btn_Click(sender As Object, e As EventArgs) Handles AvocadoLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(AvocadoQty_text.Text)
        price = qty * 108
        order = "Avocado Icecream"
        size = "Large"
        If AvocadoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        AvocadoQty_text.Text = ""
    End Sub

    Private Sub ManggoMedium_btn_Click(sender As Object, e As EventArgs) Handles ManggoMedium_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(ManggoQty_text.Text)
        price = qty * 88
        order = "Manggo Graham Icecream"
        size = "Medium"
        If ManggoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        ManggoQty_text.Text = ""
    End Sub

    Private Sub ManggoLarge_btn_Click(sender As Object, e As EventArgs) Handles ManggoLarge_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(ManggoQty_text.Text)
        price = qty * 108
        order = "Manggo Graham Icecream"
        size = "Large"
        If ManggoQty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        ManggoQty_text.Text = ""
    End Sub

    Private Sub Classic3_btn_Click(sender As Object, e As EventArgs) Handles Classic3_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(Classic3Qty_text.Text)
        price = qty * 45
        order = "Classic Mini Corndog"
        size = "3pcs"
        If Classic3Qty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        Classic3Qty_text.Text = ""
    End Sub

    Private Sub Classic6_btn_Click(sender As Object, e As EventArgs) Handles Classic6_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(Classic6Qty_text.Text)
        price = qty * 85
        order = "Classic Mini Corndog"
        size = "6pcs"
        If Classic6Qty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        Classic6Qty_text.Text = ""
    End Sub

    Private Sub Mozza3_btn_Click(sender As Object, e As EventArgs) Handles Mozza3_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(Mozza3Qty_text.Text)
        price = qty * 55
        order = "Classic + Mozza Mini Corndog"
        size = "3pcs"
        If Mozza3Qty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        Mozza3Qty_text.Text = ""
    End Sub

    Private Sub Mozza6_btn_Click(sender As Object, e As EventArgs) Handles Mozza6_btn.Click
        Dim qty, price As Integer
        Dim order, size As String
        qty = Val(Mozza6Qty_text.Text)
        price = qty * 105
        order = "Classic + Mozza Mini Corndog"
        size = "6pcs"
        If Mozza6Qty_text.Text = "" Then
            MsgBox("Please Enter Quantity")
        Else
            Dim otherItems As String() = {order, size, "-", "-", price}
            Orders_list.Items.Add(qty).SubItems.AddRange(otherItems)
        End If
        Mozza6Qty_text.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
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
End Class