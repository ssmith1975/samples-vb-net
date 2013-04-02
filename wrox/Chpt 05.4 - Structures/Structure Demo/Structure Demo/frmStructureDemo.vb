Public Class frmStructureDemo
    'Form level members
    'Private objCustomers As New ArrayList
    Private objCustomers As New CustomerCollection

    'Selected Customer
    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            If lstCustomers.SelectedIndex <> -1 Then
                'Return the selected customer
                'Return CType(objCustomers(lstCustomers.SelectedIndex), Customer)
                Return objCustomers(lstCustomers.SelectedIndex)
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Sub CreateCustomer(ByVal firstName As String, _
        ByVal lastName As String, ByVal email As String)

        'Declare a Customer object
        Dim objNewCustomer As Customer

        'Create the new customer
        objNewCustomer.FirstName = firstName
        objNewCustomer.LastNAme = lastName
        objNewCustomer.Email = email

        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)

        'Add the new customer to the ListBox control
        lstCustomers.Items.Add(objNewCustomer)
    End Sub

    Public Sub DisplayCustomer(ByVal customer As Customer)
        'Display the customer details on the form
        txtName.Text = customer.Name
        txtFirstName.Text = customer.FirstName
        txtLastName.Text = customer.LastNAme
        txtEmail.Text = customer.Email

    End Sub

    Private Sub btnListCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListCustomer.Click
        'Clear list
        'ClearList()
        objCustomers.Clear()
        lstCustomers.Items.Clear()
        'Create some customers

        CreateCustomer("Darrel", "Hilton", "dhilton@somecompany.com")
        CreateCustomer("Frank", "Peoples", "fpeoples@somecompany.com")
        CreateCustomer("Bill", "Scott", "bscott@somecompany.com")

    
    End Sub

    Private Sub ClearList()
        lstCustomers.Items.Clear()
    End Sub

 
    Private Sub btnDeleteCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteCustomer.Click
        'If no customer is selected
        If lstCustomers.SelectedIndex = -1 Then
            'Display a message

            MessageBox.Show("You must select a customer to delete.", "Structure Demo")
            'Exit this method
            Exit Sub
        End If

        'Prompt the user to delete the selected customer
        If MessageBox.Show("Are you sure you want to delete " & _
            SelectedCustomer.Name & "?", "Structure Demo", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
            DialogResult.Yes Then

            'Get the customer to be deleted
            Dim objCustomerToDelete As Customer = SelectedCustomer

            'Remove the customer from the arraylist
            objCustomers.Remove(objCustomerToDelete)

            'Remove the customer from the list box
            lstCustomers.Items.Remove(objCustomerToDelete)
        End If

    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCustomers.SelectedIndexChanged
        'Display customer details
        DisplayCustomer(SelectedCustomer)
    End Sub

    Private Sub btnLookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookup.Click
        'Declare a customer object and set it to the customer
        'with the email address to be found
        Dim objFoundCustomer As Customer = objCustomers(txtEmail.Text)

        If Not IsNothing(objFoundCustomer.Email) Then
            'Display the customers name
            MessageBox.Show("The customers name is: " & _
                objFoundCustomer.Name, "Structure Demo")
        Else
            'Display an error
            MessageBox.Show("There is no customer with the e-mail" & _
                " address " & txtEmail.Text & ".", "Structure Demo")
        End If
    End Sub
End Class
