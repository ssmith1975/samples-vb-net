Imports System.Collections.Generic

Public Class Debugging
    'Using the Generics class
    Private objStringValues As New Generics(Of String)
    Private objIntegerValues As New Generics(Of Integer)

    'Using the List(Of T)(Of T) class
    Private objCustomerList As New List(Of Customer)

    Private Sub ListCustomer(ByVal customerToList As Customer)
        lstData.Items.Add(customerToList.CustomerID & _
        " = " & customerToList.CustomerName)
    End Sub


    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.Click
        'Declare variables
        Dim strData As String
        'strData = String.Empty
        lstData.Items.Add("String variable data:")

        Try
            If strData.Length > 0 Then
                lstData.Items.Add(strData)
            End If
        Catch NullReferenceExceptionErr As NullReferenceException
            strData = "String now initialized"
            lstData.Items.Add(strData)
        End Try




        'Add an empty string to the Listbox
        lstData.Items.Add(String.Empty)

        'Demonstrates the use of the List(Of T) class
        lstData.Items.Add("Customers in the Customer Class:")
        objCustomerList.Add(New Customer(1001, "Henry Ford"))
        objCustomerList.Add(New Customer(1002, "Orville Wright"))

        For Each objCustomer As Customer In objCustomerList
            ListCustomer(objCustomer)
        Next

        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)

        'Demonstrates the use of Generics
        lstData.Items.Add("Generics Class Key/Value Pairs using String variables: ")
        objStringValues.Add("1001", "Henry Ford")
        lstData.Items.Add(objStringValues.Key(0) & " = " & _
            objStringValues.Value(0))

        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)

        'Demonstrates the use of Generics
        lstData.Items.Add("Generics Class Key/Value Pairs using Integer variables: ")
        objIntegerValues.Add("Henry Ford", 1001)
        lstData.Items.Add(objIntegerValues.Key(0) & " = " & _
            objIntegerValues.Value(0))

        'Add an empty string to the ListBox
        lstData.Items.Add(String.Empty)

        'Demonstrates the use of the Using statement
        Dim strPassword As String = "POpPassword"
        Dim strLowerCaseLetters As String = String.Empty

        'Extract lowercase characters from string
        For intIndex As Integer = 0 To strPassword.Length - 1
            'Demonstrates the use of the Continue statement
            'If no uppercase character is found, continue the loop
            If Not strPassword.Substring(intIndex, 1) Like "[a-z]" Then
                'No upper case character found, continue loop
                Continue For


            End If

            'Lowercase character found, save it
            strLowerCaseLetters &= strPassword.Substring(intIndex, 1)
        Next

        'Display lowercase characters
        lstData.Items.Add("Password lower case characters:")
        lstData.Items.Add(strLowerCaseLetters)

    End Sub
End Class
