Imports MySql.Data.MySqlClient

Public Class frmLogin
	Dim conn As MySqlConnection


	Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
		Application.Exit()
	End Sub

	Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
		conn = New MySqlConnection()
		conn.ConnectionString = "server=" & txtServer.Text & ";" _
		 & "user id=" & txtUsername.Text & ";" _
		 & "password=" & txtPassword.Text & ";" _
		 & "database=in_out"

		Try
			conn.Open()
			MessageBox.Show("Connection Opened Successfully")
			conn.Close()
		Catch myerror As MySqlException
			MessageBox.Show("Error Connecting to Database: " & myerror.Message)
		Finally
			conn.Dispose()
		End Try
	End Sub
End Class
