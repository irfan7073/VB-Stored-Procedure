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
        Me.Insert = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IDText = New System.Windows.Forms.TextBox()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.AddressText = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.TextBox()
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Insert.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Location = New System.Drawing.Point(79, 453)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(80, 35)
        Me.Insert.TabIndex = 0
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = False
        '
        'Update
        '
        Me.Update.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Update.Location = New System.Drawing.Point(184, 453)
        Me.Update.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(85, 35)
        Me.Update.TabIndex = 1
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(79, 501)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(80, 35)
        Me.Delete.TabIndex = 0
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(184, 501)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(85, 35)
        Me.Search.TabIndex = 1
        Me.Search.Text = "Search"
        Me.Search.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(299, 474)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(80, 35)
        Me.Clear.TabIndex = 0
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(404, 474)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 35)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Email"
        '
        'IDText
        '
        Me.IDText.BackColor = System.Drawing.SystemColors.Menu
        Me.IDText.Location = New System.Drawing.Point(164, 132)
        Me.IDText.Name = "IDText"
        Me.IDText.Size = New System.Drawing.Size(100, 22)
        Me.IDText.TabIndex = 3
        '
        'NameText
        '
        Me.NameText.BackColor = System.Drawing.SystemColors.Menu
        Me.NameText.Location = New System.Drawing.Point(164, 168)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(320, 22)
        Me.NameText.TabIndex = 4
        '
        'PhoneText
        '
        Me.PhoneText.BackColor = System.Drawing.SystemColors.Menu
        Me.PhoneText.Location = New System.Drawing.Point(164, 206)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(320, 22)
        Me.PhoneText.TabIndex = 5
        '
        'AddressText
        '
        Me.AddressText.BackColor = System.Drawing.SystemColors.Menu
        Me.AddressText.Location = New System.Drawing.Point(164, 242)
        Me.AddressText.Name = "AddressText"
        Me.AddressText.Size = New System.Drawing.Size(320, 22)
        Me.AddressText.TabIndex = 6
        '
        'EmailText
        '
        Me.EmailText.BackColor = System.Drawing.SystemColors.Menu
        Me.EmailText.Location = New System.Drawing.Point(164, 280)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(320, 22)
        Me.EmailText.TabIndex = 7
        '
        'lblmessage
        '
        Me.lblmessage.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblmessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblmessage.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.ForeColor = System.Drawing.SystemColors.Control
        Me.lblmessage.Location = New System.Drawing.Point(121, 370)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(396, 30)
        Me.lblmessage.TabIndex = 8
        Me.lblmessage.Text = "lblmessage"
        Me.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(600, 596)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.EmailText)
        Me.Controls.Add(Me.AddressText)
        Me.Controls.Add(Me.PhoneText)
        Me.Controls.Add(Me.NameText)
        Me.Controls.Add(Me.IDText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Insert)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Insert As Button
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Search As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IDText As TextBox
    Friend WithEvents NameText As TextBox
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents AddressText As TextBox
    Friend WithEvents EmailText As TextBox
    Friend WithEvents lblmessage As Label
End Class
