<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrayDemo
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
        Me.lstFriends = New System.Windows.Forms.ListBox
        Me.btnArrayElement = New System.Windows.Forms.Button
        Me.btnEnumerateArray = New System.Windows.Forms.Button
        Me.btnArraysAsParameters = New System.Windows.Forms.Button
        Me.btnMoreArrayParameters = New System.Windows.Forms.Button
        Me.btnSortingArrays = New System.Windows.Forms.Button
        Me.btnReversingAnArray = New System.Windows.Forms.Button
        Me.btnInitializingArraysWithValues = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.IntegralHeight = False
        Me.lstFriends.Location = New System.Drawing.Point(23, 35)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(97, 197)
        Me.lstFriends.TabIndex = 0
        '
        'btnArrayElement
        '
        Me.btnArrayElement.Location = New System.Drawing.Point(126, 35)
        Me.btnArrayElement.Name = "btnArrayElement"
        Me.btnArrayElement.Size = New System.Drawing.Size(162, 23)
        Me.btnArrayElement.TabIndex = 1
        Me.btnArrayElement.Text = "Array Element"
        Me.btnArrayElement.UseVisualStyleBackColor = True
        '
        'btnEnumerateArray
        '
        Me.btnEnumerateArray.Location = New System.Drawing.Point(126, 64)
        Me.btnEnumerateArray.Name = "btnEnumerateArray"
        Me.btnEnumerateArray.Size = New System.Drawing.Size(162, 23)
        Me.btnEnumerateArray.TabIndex = 2
        Me.btnEnumerateArray.Text = "Enumerate Array"
        Me.btnEnumerateArray.UseVisualStyleBackColor = True
        '
        'btnArraysAsParameters
        '
        Me.btnArraysAsParameters.Location = New System.Drawing.Point(126, 93)
        Me.btnArraysAsParameters.Name = "btnArraysAsParameters"
        Me.btnArraysAsParameters.Size = New System.Drawing.Size(162, 23)
        Me.btnArraysAsParameters.TabIndex = 3
        Me.btnArraysAsParameters.Text = "Arrays as Parameters"
        Me.btnArraysAsParameters.UseVisualStyleBackColor = True
        '
        'btnMoreArrayParameters
        '
        Me.btnMoreArrayParameters.Location = New System.Drawing.Point(126, 122)
        Me.btnMoreArrayParameters.Name = "btnMoreArrayParameters"
        Me.btnMoreArrayParameters.Size = New System.Drawing.Size(162, 23)
        Me.btnMoreArrayParameters.TabIndex = 4
        Me.btnMoreArrayParameters.Text = "More Array Parameters"
        Me.btnMoreArrayParameters.UseVisualStyleBackColor = True
        '
        'btnSortingArrays
        '
        Me.btnSortingArrays.Location = New System.Drawing.Point(126, 151)
        Me.btnSortingArrays.Name = "btnSortingArrays"
        Me.btnSortingArrays.Size = New System.Drawing.Size(162, 23)
        Me.btnSortingArrays.TabIndex = 5
        Me.btnSortingArrays.Text = "Sorting Arrays"
        Me.btnSortingArrays.UseVisualStyleBackColor = True
        '
        'btnReversingAnArray
        '
        Me.btnReversingAnArray.Location = New System.Drawing.Point(126, 180)
        Me.btnReversingAnArray.Name = "btnReversingAnArray"
        Me.btnReversingAnArray.Size = New System.Drawing.Size(162, 23)
        Me.btnReversingAnArray.TabIndex = 6
        Me.btnReversingAnArray.Text = "Reversing an Array"
        Me.btnReversingAnArray.UseVisualStyleBackColor = True
        '
        'btnInitializingArraysWithValues
        '
        Me.btnInitializingArraysWithValues.Location = New System.Drawing.Point(126, 209)
        Me.btnInitializingArraysWithValues.Name = "btnInitializingArraysWithValues"
        Me.btnInitializingArraysWithValues.Size = New System.Drawing.Size(162, 23)
        Me.btnInitializingArraysWithValues.TabIndex = 7
        Me.btnInitializingArraysWithValues.Text = "Initializing Arrays With Values"
        Me.btnInitializingArraysWithValues.UseVisualStyleBackColor = True
        '
        'frmArrayDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 263)
        Me.Controls.Add(Me.btnInitializingArraysWithValues)
        Me.Controls.Add(Me.btnReversingAnArray)
        Me.Controls.Add(Me.btnSortingArrays)
        Me.Controls.Add(Me.btnMoreArrayParameters)
        Me.Controls.Add(Me.btnArraysAsParameters)
        Me.Controls.Add(Me.btnEnumerateArray)
        Me.Controls.Add(Me.btnArrayElement)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "frmArrayDemo"
        Me.Text = "Array Demo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstFriends As System.Windows.Forms.ListBox
    Friend WithEvents btnArrayElement As System.Windows.Forms.Button
    Friend WithEvents btnEnumerateArray As System.Windows.Forms.Button
    Friend WithEvents btnArraysAsParameters As System.Windows.Forms.Button
    Friend WithEvents btnMoreArrayParameters As System.Windows.Forms.Button
    Friend WithEvents btnSortingArrays As System.Windows.Forms.Button
    Friend WithEvents btnReversingAnArray As System.Windows.Forms.Button
    Friend WithEvents btnInitializingArraysWithValues As System.Windows.Forms.Button

End Class
