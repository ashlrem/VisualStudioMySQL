<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.pass = New System.Windows.Forms.MaskedTextBox()
        Me.sect = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.studno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(133, 71)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(132, 20)
        Me.pass.TabIndex = 23
        '
        'sect
        '
        Me.sect.Location = New System.Drawing.Point(133, 213)
        Me.sect.Name = "sect"
        Me.sect.Size = New System.Drawing.Size(132, 20)
        Me.sect.TabIndex = 22
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(133, 177)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(132, 20)
        Me.lname.TabIndex = 21
        '
        'mname
        '
        Me.mname.Location = New System.Drawing.Point(133, 141)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(132, 20)
        Me.mname.TabIndex = 20
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(133, 107)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(132, 20)
        Me.fname.TabIndex = 19
        '
        'studno
        '
        Me.studno.Location = New System.Drawing.Point(133, 35)
        Me.studno.Name = "studno"
        Me.studno.Size = New System.Drawing.Size(132, 20)
        Me.studno.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Section"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Middle Initial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Student Number"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(282, 33)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 24
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(282, 69)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 25
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(282, 105)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 26
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 406)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.sect)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.mname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.studno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents sect As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents studno As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
End Class
