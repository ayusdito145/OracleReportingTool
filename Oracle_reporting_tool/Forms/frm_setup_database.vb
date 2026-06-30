Imports System.ComponentModel
Imports Guna.UI2.WinForms
Imports ADODB
Imports System.Data.SqlClient
Public Class frm_setup_database
    Private TstServerMySQL As String
    Private TstUserNameMySQL As String
    Private TstPwdMySQL As String
    Private TstDBNameMySQL As String

    Private Sub frm_setup_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServerHost.Text = ServerMySQL
        txtUserName.Text = UserNameMySQL
        txtPassword.Text = PwdMySQL
        txtDatabase.Text = DBNameMySQL
        txtPassword.UseSystemPasswordChar = True

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        TstServerMySQL = txtServerHost.Text
        TstUserNameMySQL = txtUserName.Text
        TstPwdMySQL = txtPassword.Text
        TstDBNameMySQL = txtDatabase.Text
        Try

            con.ConnectionString = "Data Source = " & TstServerMySQL & ";  " _
                                         & "Initial Catalog = " & TstDBNameMySQL & "; " _
                                         & "User ID= " & TstUserNameMySQL & "; " _
                                         & "Password = " & TstPwdMySQL & ";"
            con.Open()
            MsgBox("Test connection successful", MsgBoxStyle.Information, "Database Settings")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Call DisconnMy()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        TstServerMySQL = txtServerHost.Text
        TstUserNameMySQL = txtUserName.Text
        TstPwdMySQL = txtPassword.Text
        TstDBNameMySQL = txtDatabase.Text

        Try
            con.ConnectionString = "Data Source = " & TstServerMySQL & ";  " _
                                          & "Initial Catalog = " & TstDBNameMySQL & "; " _
                                          & "User ID= " & TstUserNameMySQL & "; " _
                                          & "Password = " & TstPwdMySQL & ";"
            con.Open()

            DBNameMySQL = txtDatabase.Text
            ServerMySQL = txtServerHost.Text
            UserNameMySQL = txtUserName.Text
            PwdMySQL = txtPassword.Text

            Call SaveData()
            Me.Close()
        Catch ex As Exception
            MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
        End Try
        Call DisconnMy()
    End Sub


End Class