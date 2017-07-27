Partial Public Class frmLogin
	Inherits System.Windows.Forms.Form

	<System.Diagnostics.DebuggerNonUserCode()> _
	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()

	End Sub

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.txtServer = New System.Windows.Forms.TextBox
		Me.txtUsername = New System.Windows.Forms.TextBox
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.cmdLogin = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.SuspendLayout()
		'
		'txtServer
		'
		Me.txtServer.Location = New System.Drawing.Point(107, 21)
		Me.txtServer.Name = "txtServer"
		Me.txtServer.Size = New System.Drawing.Size(218, 20)
		Me.txtServer.TabIndex = 0
		'
		'txtUsername
		'
		Me.txtUsername.Location = New System.Drawing.Point(107, 57)
		Me.txtUsername.Name = "txtUsername"
		Me.txtUsername.Size = New System.Drawing.Size(218, 20)
		Me.txtUsername.TabIndex = 1
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(107, 96)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.Size = New System.Drawing.Size(218, 20)
		Me.txtPassword.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(40, 27)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(41, 14)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Server:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 63)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 14)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Username:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(24, 102)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(57, 14)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Password:"
		'
		'cmdLogin
		'
		Me.cmdLogin.Location = New System.Drawing.Point(107, 137)
		Me.cmdLogin.Name = "cmdLogin"
		Me.cmdLogin.Size = New System.Drawing.Size(96, 20)
		Me.cmdLogin.TabIndex = 6
		Me.cmdLogin.Text = "Login"
		'
		'cmdCancel
		'
		Me.cmdCancel.Location = New System.Drawing.Point(229, 137)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(96, 20)
		Me.cmdCancel.TabIndex = 7
		Me.cmdCancel.Text = "Cancel"
		'
		'frmLogin
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(360, 184)
		Me.Controls.Add(Me.cmdCancel)
		Me.Controls.Add(Me.cmdLogin)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.txtUsername)
		Me.Controls.Add(Me.txtServer)
		Me.Name = "frmLogin"
		Me.Text = "In-Out - Login"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtServer As System.Windows.Forms.TextBox
	Friend WithEvents txtUsername As System.Windows.Forms.TextBox
	Friend WithEvents txtPassword As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents cmdLogin As System.Windows.Forms.Button
	Friend WithEvents cmdCancel As System.Windows.Forms.Button

End Class
