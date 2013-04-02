
' Import Data an SqlClient namespaces
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDataSetExample
    Dim objConnection As New SqlConnection _
        ("server=KUSH-PC;database=pubs;user id=dbuser;password=password")

    Dim objDataAdapter As New SqlDataAdapter()
    Dim objDataSet As New DataSet()


    Private Sub frmDataSetExample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the SelectCommand properties
        objDataAdapter.SelectCommand = New SqlCommand()
        objDataAdapter.SelectCommand.Connection = objConnection
        objDataAdapter.SelectCommand.CommandText = _
            "SELECT au_lname, au_fname, title, price " & _
            "FROM authors " & _
            "JOIN titleauthor ON authors.au_id = titleauthor.au_id " & _
            "JOIN titles ON titleauthor.title_id = titles.title_id " & _
            "ORDER BY au_lname, au_fname"

        objDataAdapter.SelectCommand.CommandType = CommandType.Text

        ' Open the database connection...
        objConnection.Open()

        ' Fill the Dataset object with data
        objDataAdapter.Fill(objDataSet, "authors")

        ' Close the database connection...
        objConnection.Close()

        ' Set the DataGridView properties to bind it to our data...
        grdAuthorTitles.AutoGenerateColumns = True
        grdAuthorTitles.DataSource = objDataSet
        grdAuthorTitles.DataMember = "authors"

        ' Declare and set the currency header alignmet property...
        Dim objAlignRightCellStyle As New DataGridViewCellStyle
        objAlignRightCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ' Declare and set the alternating rows styles...
        Dim objAlternatingCellStyle As New DataGridViewCellStyle()
        objAlternatingCellStyle.BackColor = Color.SkyBlue
        grdAuthorTitles.AlternatingRowsDefaultCellStyle = objAlternatingCellStyle

        ' Declare and set the style for currency cells...
        Dim objCurrencyCellStyle As New DataGridViewCellStyle()
        objCurrencyCellStyle.Format = "c"
        objCurrencyCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        ' Change column names and styles using the column index
        grdAuthorTitles.Columns(0).HeaderText = "Last Name"
        grdAuthorTitles.Columns(1).HeaderText = "First Name"
        grdAuthorTitles.Columns(2).HeaderText = "Book Title"
        grdAuthorTitles.Columns(2).Width = 225

        ' Change the column names and styles using the column names
        grdAuthorTitles.Columns("price").HeaderCell.Value = "Retail Price"
        grdAuthorTitles.Columns("price").HeaderCell.Style = objAlignRightCellStyle
        grdAuthorTitles.Columns("price").DefaultCellStyle = objCurrencyCellStyle

        ' Clean up
        objDataAdapter = Nothing
        objConnection = Nothing
        objCurrencyCellStyle = Nothing
        objAlternatingCellStyle = Nothing
        objAlignRightCellStyle = Nothing

    End Sub
End Class
