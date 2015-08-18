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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.studno = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.sect = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.MaskedTextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Middle Initial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Section"
        '
        'studno
        '
        Me.studno.Location = New System.Drawing.Point(142, 39)
        Me.studno.Name = "studno"
        Me.studno.Size = New System.Drawing.Size(132, 20)
        Me.studno.TabIndex = 6
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(142, 111)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(132, 20)
        Me.fname.TabIndex = 7
        '
        'mname
        '
        Me.mname.Location = New System.Drawing.Point(142, 145)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(132, 20)
        Me.mname.TabIndex = 8
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(142, 181)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(132, 20)
        Me.lname.TabIndex = 9
        '
        'sect
        '
        Me.sect.Location = New System.Drawing.Point(142, 217)
        Me.sect.Name = "sect"
        Me.sect.Size = New System.Drawing.Size(132, 20)
        Me.sect.TabIndex = 10
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(142, 75)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(132, 20)
        Me.pass.TabIndex = 11
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(67, 268)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(166, 268)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdClear.TabIndex = 13
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 365)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdSave)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents studno As System.Windows.Forms.TextBox
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents sect As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button

End Class
