<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RemoveColumnButton = New System.Windows.Forms.Button()
        Me.RemoveRowButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CurrentCellTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ColumnTextBox = New System.Windows.Forms.TextBox()
        Me.RowTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UploadButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(434, 422)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 30)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Row"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(232, 422)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Column"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RemoveColumnButton
        '
        Me.RemoveColumnButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.RemoveColumnButton.FlatAppearance.BorderSize = 0
        Me.RemoveColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveColumnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveColumnButton.ForeColor = System.Drawing.Color.White
        Me.RemoveColumnButton.Location = New System.Drawing.Point(624, 504)
        Me.RemoveColumnButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RemoveColumnButton.Name = "RemoveColumnButton"
        Me.RemoveColumnButton.Size = New System.Drawing.Size(169, 32)
        Me.RemoveColumnButton.TabIndex = 33
        Me.RemoveColumnButton.Text = "Remove Column"
        Me.RemoveColumnButton.UseVisualStyleBackColor = False
        '
        'RemoveRowButton
        '
        Me.RemoveRowButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.RemoveRowButton.FlatAppearance.BorderSize = 0
        Me.RemoveRowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveRowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRowButton.ForeColor = System.Drawing.Color.White
        Me.RemoveRowButton.Location = New System.Drawing.Point(80, 504)
        Me.RemoveRowButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RemoveRowButton.Name = "RemoveRowButton"
        Me.RemoveRowButton.Size = New System.Drawing.Size(169, 32)
        Me.RemoveRowButton.TabIndex = 32
        Me.RemoveRowButton.Text = "Remove Row"
        Me.RemoveRowButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(82, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Focused Cell :"
        '
        'CurrentCellTextBox
        '
        Me.CurrentCellTextBox.BackColor = System.Drawing.Color.White
        Me.CurrentCellTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CurrentCellTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentCellTextBox.ForeColor = System.Drawing.Color.Black
        Me.CurrentCellTextBox.Location = New System.Drawing.Point(188, 385)
        Me.CurrentCellTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CurrentCellTextBox.Name = "CurrentCellTextBox"
        Me.CurrentCellTextBox.ReadOnly = True
        Me.CurrentCellTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CurrentCellTextBox.Size = New System.Drawing.Size(192, 19)
        Me.CurrentCellTextBox.TabIndex = 30
        Me.CurrentCellTextBox.Text = " "
        Me.CurrentCellTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.Chocolate
        Me.SearchButton.FlatAppearance.BorderSize = 0
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(246, 504)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(380, 32)
        Me.SearchButton.TabIndex = 29
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ColumnTextBox
        '
        Me.ColumnTextBox.BackColor = System.Drawing.Color.White
        Me.ColumnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ColumnTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColumnTextBox.ForeColor = System.Drawing.Color.Black
        Me.ColumnTextBox.Location = New System.Drawing.Point(339, 423)
        Me.ColumnTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ColumnTextBox.Name = "ColumnTextBox"
        Me.ColumnTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ColumnTextBox.Size = New System.Drawing.Size(65, 23)
        Me.ColumnTextBox.TabIndex = 28
        Me.ColumnTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RowTextBox
        '
        Me.RowTextBox.BackColor = System.Drawing.Color.White
        Me.RowTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RowTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowTextBox.ForeColor = System.Drawing.Color.Black
        Me.RowTextBox.Location = New System.Drawing.Point(540, 423)
        Me.RowTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RowTextBox.Name = "RowTextBox"
        Me.RowTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RowTextBox.Size = New System.Drawing.Size(67, 23)
        Me.RowTextBox.TabIndex = 27
        Me.RowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(80, 93)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(713, 36)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Datar Grid"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.Peru
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(365, 48)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(155, 41)
        Me.DeleteButton.TabIndex = 25
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'PrintButton
        '
        Me.PrintButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.PrintButton.FlatAppearance.BorderSize = 0
        Me.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.White
        Me.PrintButton.Location = New System.Drawing.Point(624, 48)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(155, 41)
        Me.PrintButton.TabIndex = 24
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 127)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(713, 254)
        Me.DataGridView1.TabIndex = 23
        '
        'UploadButton
        '
        Me.UploadButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.UploadButton.FlatAppearance.BorderSize = 0
        Me.UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UploadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadButton.ForeColor = System.Drawing.Color.White
        Me.UploadButton.Location = New System.Drawing.Point(94, 48)
        Me.UploadButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UploadButton.Name = "UploadButton"
        Me.UploadButton.Size = New System.Drawing.Size(155, 41)
        Me.UploadButton.TabIndex = 22
        Me.UploadButton.Text = "Upload"
        Me.UploadButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(874, 582)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RemoveColumnButton)
        Me.Controls.Add(Me.RemoveRowButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CurrentCellTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ColumnTextBox)
        Me.Controls.Add(Me.RowTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.UploadButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RemoveColumnButton As Button
    Friend WithEvents RemoveRowButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CurrentCellTextBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents ColumnTextBox As TextBox
    Friend WithEvents RowTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UploadButton As Button
End Class
