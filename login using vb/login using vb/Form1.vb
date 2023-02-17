Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Dim con As SqlConnection = New SqlConnection("SERVER=.\SQLEXPRESS; Database=Restaurant;integrated security=true")
        Dim cmd As SqlCommand = New SqlCommand("select passcode from manager where name='" + Txtname.Text + "'")
        Dim dbpass As String
        con.Open()
        cmd.Connection = con
        dbpass = cmd.ExecuteScalar()
        Dim password As String
        password = Txtpassword.Text
        If (password.Equals(dbpass)) Then
            MessageBox.Show("login success", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        con.Close()
        End If
    End Sub
End Class
