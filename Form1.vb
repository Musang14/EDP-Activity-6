Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        Dim openFileDialog1 As New OpenFileDialog With {
        .Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog1.FileName
            Dim bgWorker As New BackgroundWorker()
            AddHandler bgWorker.DoWork, AddressOf ParseCsvFile
            AddHandler bgWorker.RunWorkerCompleted, AddressOf LoadCsvData
            bgWorker.RunWorkerAsync(fileName)
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        ' Check if the DataGridView is empty or row/column numbers are not specified
        If DataGridView1.RowCount = 0 OrElse DataGridView1.ColumnCount = 0 OrElse String.IsNullOrEmpty(RowTextBox.Text) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) Then
            ' Set the default values to 1 for row and column numbers
            RowTextBox.Text = "1"
            ColumnTextBox.Text = "1"
            Return
        End If

        ' Get the row and column numbers from the text boxes
        Dim row As Integer = CInt(RowTextBox.Text)
        Dim column As Integer = CInt(ColumnTextBox.Text)

        ' Check if the row and column numbers are valid
        If row > 0 AndAlso row <= DataGridView1.RowCount AndAlso column > 0 AndAlso column <= DataGridView1.ColumnCount Then
            ' Set the current cell and scroll to it
            DataGridView1.CurrentCell = DataGridView1(column - 1, row - 1)
            DataGridView1.FirstDisplayedScrollingRowIndex = row - 1
        Else
            ' Display an error message for invalid row or column number
            MessageBox.Show("Invalid input")
        End If
    End Sub

    Public Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If DataGridView1.Rows.Count = 0 Then
            Dim result As DialogResult = MessageBox.Show("oops DataGridView is empty. Do you still want to create a backup?", "Backup Empty DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
        End If
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV Files (.csv)|.csv|All Files (.)|."
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog1.FileName
            Using writer As New StreamWriter(fileName)

                Dim headers As New List(Of String)
                For Each column As DataGridViewColumn In DataGridView1.Columns
                    headers.Add(column.HeaderText)
                Next
                writer.WriteLine(String.Join(",", headers))
                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim fields As New StringBuilder()
                    For Each cell As DataGridViewCell In row.Cells
                        'Check if the cell value if empty or not
                        If Not String.IsNullOrWhiteSpace(cell.Value?.ToString()) Then
                            'Append the cell value to the StringBuilder
                            fields.Append(cell.Value.ToString())
                        End If
                        'Add comma
                        fields.Append(",")
                    Next
                    writer.WriteLine(fields.ToString().TrimEnd(","))
                Next
            End Using
            MessageBox.Show("Saved")
        End If
    End Sub


    Public Sub ParseCsvFile(sender As Object, e As DoWorkEventArgs)
        Dim fileName As String = DirectCast(e.Argument, String)
        Dim csvData As New List(Of String())
        Using reader As New StreamReader(fileName)
            While Not reader.EndOfStream
                ' Read each line  then split it into fields
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split(","c)
                ' Add the fields to the list
                csvData.Add(fields)
            End While
        End Using
        e.Result = csvData
    End Sub

    Public Sub LoadCsvData(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim csvData As List(Of String()) = DirectCast(e.Result, List(Of String()))
        Dim header As String() = csvData(0)
        ' Create a new DataTable and add columns for each field in the header row
        Dim dt As New DataTable()
        For Each colName As String In header
            dt.Columns.Add(New DataColumn(colName, GetType(String)))
        Next
        ' Add each row of data to the DataTable
        For i As Integer = 1 To csvData.Count - 1
            Dim fields As String() = csvData(i)
            Dim row As DataRow = dt.NewRow()
            row.ItemArray = fields
            dt.Rows.Add(row)
        Next
        DataGridView1.DataSource = dt
    End Sub
    Private openFileDialog1 As New OpenFileDialog()
    Private Const FILE_FILTER As String = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
    Private Const FILE_SELECT_TITLE As String = "Select a CSV file to delete"

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        openFileDialog1.Filter = FILE_FILTER
        openFileDialog1.Title = FILE_SELECT_TITLE
        openFileDialog1.Multiselect = False

        If openFileDialog1.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' Get the path and file name 
        Dim filePath As String = openFileDialog1.FileName
        Dim fileName As String = Path.GetFileName(filePath)
        Dim confirmResult = MessageBox.Show($"Are you sure you want to delete the file {fileName}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If confirmResult <> DialogResult.Yes Then
            Return
        End If

        Try
            File.Delete(filePath)
            MessageBox.Show("File deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As IOException
            MessageBox.Show($"An error occurred while deleting the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridView1_CurrentCellChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellChanged
        ' Get the current cell of the DataGridView
        Dim currentCell As DataGridViewCell = DataGridView1.CurrentCell

        If currentCell?.RowIndex IsNot Nothing AndAlso currentCell?.ColumnIndex IsNot Nothing Then
            Dim row As String = (currentCell.RowIndex + 1).ToString("D2")
            Dim column As String = (currentCell.ColumnIndex + 1).ToString("D2")

            CurrentCellTextBox.Text = $"Column {column} Row {row} "
        Else
            CurrentCellTextBox.Text = ""
        End If
    End Sub

    Private Function IsIndexSpecified(indexTextBox As TextBox) As Boolean
        If String.IsNullOrEmpty(indexTextBox.Text) Then
            MessageBox.Show("Index number is not specified")
            Return False
        End If
        Return True
    End Function

    Private Sub RemoveRowButton_Click(sender As Object, e As EventArgs) Handles RemoveRowButton.Click
        Dim rowNumber As Integer
        If String.IsNullOrEmpty(RowTextBox.Text) OrElse Not Integer.TryParse(RowTextBox.Text, rowNumber) Then
            MessageBox.Show("Please indicate valid row number")
            Return
        End If
        If DataGridView1.ColumnHeadersVisible Then
            rowNumber -= 1
        End If

        If rowNumber < 0 OrElse rowNumber >= DataGridView1.Rows.Count Then
            MessageBox.Show($"Row {rowNumber + 1} does not exist")
            Return
        End If

        Dim result = MessageBox.Show($"Are you sure you want to remove row {rowNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            DataGridView1.Rows.RemoveAt(rowNumber)
        End If
    End Sub

    Private Sub RemoveColumnButton_Click(sender As Object, e As EventArgs) Handles RemoveColumnButton.Click
        Dim columnNumber As Integer
        If Not IsIndexSpecified(ColumnTextBox) OrElse String.IsNullOrEmpty(ColumnTextBox.Text) OrElse Not Integer.TryParse(ColumnTextBox.Text, columnNumber) Then
            MessageBox.Show("Please indicate valid column number")
            Return
        End If
        columnNumber -= 1

        If columnNumber < 0 OrElse columnNumber >= DataGridView1.Columns.Count Then
            MessageBox.Show($"Column {columnNumber + 1} does not exist")
            Return
        End If

        Dim result = MessageBox.Show($"Are you sure you want to remove column {columnNumber + 1}?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            DataGridView1.Columns.RemoveAt(columnNumber)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            RowTextBox.Text = $"{e.RowIndex + 1}"
            ColumnTextBox.Text = $"{e.ColumnIndex + 1}"
        Else
            RowTextBox.Clear()
            ColumnTextBox.Clear()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
