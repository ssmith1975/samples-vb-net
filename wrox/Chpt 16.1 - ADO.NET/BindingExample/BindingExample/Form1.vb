
' Import Data nad SqlClient namespace..
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    ' Declare objects..
    Dim objConnection As New SqlConnection _
        ("server=COMPUTERNAME;database=pubs;user id=USER;password=******")

    Dim objDataAdapter As New SqlDataAdapter( _
        "SELECT authors.au_id, au_lname, au_fname, " & _
        "titles.title_id, title, price " & _
        "FROM authors " & _
        "JOIN titleauthor ON authors.au_id = titleauthor.au_id " & _
        "JOIN titles ON titleauthor.title_id = titles.title_id " & _
        "ORDER BY au_lname, au_fname", objConnection)
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Private Sub FillDataSetAndView()
        ' Initialize a new instance ofthe DataSet object..
        objDataSet = New DataSet()

        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "authors")

        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("authors"))

        ' Set our CurrencyManager object to the DataView object..
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub

    Private Sub BindFields()
        ' Clear any previous bindings..
        txtLastName.DataBindings.Clear()
        txtFirstName.DataBindings.Clear()
        txtBookTitle.DataBindings.Clear()
        txtPrice.DataBindings.Clear()

        ' Add new bindings to the DataView object..
        txtLastName.DataBindings.Add("Text", objDataView, "au_lname")
        txtFirstName.DataBindings.Add("Text", objDataView, "au_fname")
        txtBookTitle.DataBindings.Add("Text", objDataView, "title")
        txtPrice.DataBindings.Add("Text", objDataView, "price")

        ' Display a ready status..
        ToolStripStatusLabel1.Text = "Ready"


    End Sub


    Private Sub ShowPosition()
        ' Always format the number in the txtPrice field to include cents
        Try
            txtPrice.Text = Format(CType(txtPrice.Text, Decimal), "##0.00")
        Catch e As System.Exception
            txtPrice.Text = "0"
            txtPrice.Text = Format(CType(txtPrice.Text, Decimal), "##0.00")
        End Try

        ' Display the current position and the number of records
        txtRecordPosition.Text = objCurrencyManager.Position + 1 & _
            " of " & objCurrencyManager.Count()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Add items to the combo box..
        cboField.Items.Add("Last Name")
        cboField.Items.Add("First Name")
        cboField.Items.Add("Book Title")
        cboField.Items.Add("Price")

        ' Make the first item selected..
        cboField.SelectedIndex = 0

        ' Fill the DataSet and bind the fields..
        FillDataSetAndView()
        BindFields()

        ' Show the current record position..
        ShowPosition()

    End Sub

    Private Sub btnMoveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveFirst.Click
        ' Set the record position to the first record..
        objCurrencyManager.Position = 0

        ' Show the current record position..
        ShowPosition()
    End Sub


    Private Sub btnMovePrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMovePrevious.Click
        ' Move to previous record..
        objCurrencyManager.Position -= 1

        ' Show the current record position..
        ShowPosition()
    End Sub


    Private Sub btnMoveNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveNext.Click
        ' Move to previous record..
        objCurrencyManager.Position += 1

        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub btnMoveLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMoveLast.Click
        ' Move to previous record..
        objCurrencyManager.Position = objCurrencyManager.Count - 1

        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub btnPerformSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerformSort.Click
        ' Determine the appropriate item selected and set the
        ' Sort property of the DataView object..

        Select Case cboField.SelectedIndex
            Case 0 'Last Name'
                objDataView.Sort = "au_lname"
            Case 1 'First Name
                objDataView.Sort = "au_fname"
            Case 2 'Book Title
                objDataView.Sort = "title"
            Case 3 'Price
                objDataView.Sort = "price"
        End Select

        ' Call the click event for the MoveFirst button..
        btnMoveFirst_Click(Nothing, Nothing)

        ' Display a message that the records have been sorted..
        ToolStripStatusLabel1.Text = "Records Sorted"

    End Sub

    Private Sub btnPerformSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerformSearch.Click
        ' Declare local variables..
        Dim intPosition As Integer

        ' Determine the appropriate item selected and set the
        ' Sort property of the DataView object..

        Select Case cboField.SelectedIndex
            Case 0 'Last Name'
                objDataView.Sort = "au_lname"
            Case 1 'First Name
                objDataView.Sort = "au_fname"
            Case 2 'Book Title
                objDataView.Sort = "title"
            Case 3 'Price
                objDataView.Sort = "price"
        End Select

        ' If the search field is not price then..
        If cboField.SelectedIndex < 3 Then
            ' Find the last name, first name, or title..
            intPosition = objDataView.Find(txtSearchCriteria.Text)
        Else
            ' otherwise find the price..
            intPosition = objDataView.Find(CType(txtSearchCriteria.Text, Decimal)) '******** may cause error **********
        End If

        If intPosition = -1 Then
            ' Display a message that the record was not found
            ToolStripStatusLabel1.Text = "Record Not Found"
        Else
            ' Otherwise display a message that the record was 
            ' found and reposition the CurrencyManager to that 
            ' record..
            ToolStripStatusLabel1.Text = "Record Found"
            objCurrencyManager.Position = intPosition
        End If


        ' Show the current record position..
        ShowPosition()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        ' Clear the book title and price fields..
        txtBookTitle.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Declare local variables and objects..
        Dim intPosition As Integer, intMaxID As Integer
        Dim strID As String
        Dim objCommand As SqlCommand = New SqlCommand()

        ' Save the current record position..
        intPosition = objCurrencyManager.Position

        ' Create a new SqlCommand object..
        Dim maxIdCommand As SqlCommand = New SqlCommand( _
            "SELECT MAX(title_id) AS MaxID " & _
            "FROM titles WHERE title_id LIKE 'DM%'", objConnection)

        ' Open the connection, execute the command
        objConnection.Open()

        Dim maxId As Object = maxIdCommand.ExecuteScalar()

        ' If the MaxID column is null..
        If maxId Is DBNull.Value Then
            ' Set a default value of 1000..
            intMaxID = 1000
        Else
            ' otherwise set the strID variable to the value in MaxID..
            strID = CType(maxId, String)

            ' Get the integer part of the string..
            intMaxID = CType(strID.Remove(0, 2), Integer)

            ' Increment the value..
            intMaxID += 1
        End If

        ' Finally, set the new ID..
        strID = "DM" & intMaxID.ToString

        ' Set the SqlCommand object properties..
        objCommand.Connection = objConnection
        objCommand.CommandText = "INSERT INTO titles " & _
            "(title_id, title, type, price, pubdate) " & _
            "VALUES(@title_id, @title, @type, @price, @pubdate);" & _
            "INSERT INTO titleauthor(au_id, title_id) VALUES(@au_id,@title_id)"


        ' Add parameters for the placeholders in SQL in the 
        ' CommandText property..


        ' Parameter for the title_id column
        objCommand.Parameters.AddWithValue("@title_id", strID)

        ' Parameter for the title column..
        objCommand.Parameters.AddWithValue("@title", txtBookTitle.Text)

        ' Parameter for the type column
        objCommand.Parameters.AddWithValue("@type", "Demo")

        ' Parameter for the price column..
        objCommand.Parameters.AddWithValue("@price", txtPrice.Text).DbType _
            = DbType.Currency

        ' Parameter for the pubdate column
        objCommand.Parameters.AddWithValue("@pubdate", Date.Now)

        ' Parameter for the au_id column..
        objCommand.Parameters.AddWithValue("@au_id", BindingContext(objDataView).Current("au_id"))

        ' Execute the SqlCommand object to insert the new data..
        Try
            objCommand.ExecuteNonQuery()
        Catch SqlExceptionErr As SqlException
            MessageBox.Show(SqlExceptionErr.Message)
        End Try

        ' Close the connection..
        objConnection.Close()

        ' Fill the dataset and bind the fields..
        FillDataSetAndView()
        BindFields()

        ' Set the record position to hte one you saved..
        objCurrencyManager.Position = intPosition

        ' Show the current record position
        ShowPosition()

        ' Display a message that the record was added..
        ToolStripStatusLabel1.Text = "Record Added"




    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        ' Declare local variables and objects..
        Dim intPosition As Integer
        Dim objCommand As SqlCommand = New SqlCommand()

        ' Save the current record position..
        intPosition = objCurrencyManager.Position

        ' Set the SqlCommand object position..
        objCommand.Connection = objConnection
        objCommand.CommandText = "UPDATE titles " & _
            "SET title = @title, price=@price WHERE title_id = @title_id"
        objCommand.CommandType = CommandType.Text

        ' Add parameters for the placeholders in the SQL in the
        ' CommandText property..

        ' Parameter for the title column..
        objCommand.Parameters.AddWithValue("@title", txtBookTitle.Text)

        ' Parameter for the price column..
        objCommand.Parameters.AddWithValue("@price", txtPrice.Text).DbType _
            = DbType.Currency

        ' Parameter for the title_id column
        objCommand.Parameters.AddWithValue("@title_id", BindingContext(objDataView).Current("title_id"))

        ' Open the connection, execute the command
        objConnection.Open()

        ' Execute the SqlCommnd  oject to update the data..
        objCommand.ExecuteNonQuery()

        ' Close the connection..
        objConnection.Close()

        ' Fill the dataset and bind the fields..
        FillDataSetAndView()
        BindFields()

        ' Set the record position to hte one you saved..
        objCurrencyManager.Position = intPosition

        ' Show the current record position
        ShowPosition()

        ' Display a message that the record was added..
        ToolStripStatusLabel1.Text = "Record Updated"

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ' Declare local variables and objects..
        Dim intPosition As Integer
        Dim objCommand As SqlCommand = New SqlCommand()

        ' Save the current record position-1 for the one to be 
        ' deleted
        intPosition = Me.BindingContext(objDataView).Position - 1

        ' Set the Command object properties..
        objCommand.Connection = objConnection

        objCommand.CommandText = "DELETE FROM titleauthor " & _
            "WHERE  title_id = @title_id;" & _
            "DELETE FROM titles WHERE title_id = @title_id"

        ' If the position is less than 0 set it to 0..
        If intPosition < 0 Then
            intPosition = 0
        End If

        ' Parameter for the title_id column
        objCommand.Parameters.AddWithValue("@title_id", BindingContext(objDataView).Current("title_id"))

        ' Open the database connection
        objConnection.Open()

        ' Execute the SqlCommnd  oject to update the data..
        objCommand.ExecuteNonQuery()

        ' Close the connection..
        objConnection.Close()

        ' Fill the dataset and bind the fields..
        FillDataSetAndView()
        BindFields()

        ' Set the record position to hte one you saved..
        objCurrencyManager.Position = intPosition

        ' Show the current record position
        ShowPosition()

        ' Display a message that the record was added..
        ToolStripStatusLabel1.Text = "Record Deleted"

    End Sub
End Class
