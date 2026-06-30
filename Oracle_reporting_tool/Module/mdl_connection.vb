Option Explicit On
Imports ADODB
Imports System.Data.SqlClient

Module mdl_connection
    Public ServerMySQL As String
    Public UserNameMySQL As String
    Public PwdMySQL As String
    Public DBNameMySQL As String
    Public con As New SqlConnection


    Public Sub DisconnMy()
        con.Close()
        con.Dispose()
    End Sub

    Public Sub ConnDB()
        con.Close()
        Try
            con.ConnectionString = "Data Source = '" & ServerMySQL & "'; " &
                                          "Initial Catalog = '" & DBNameMySQL & "'; " &
                                          "User ID = '" & UserNameMySQL & "'; " &
                                          "Password = '" & PwdMySQL & "';" &
                                         "Connection Timeout = 500;"

            con.Open()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub


    Sub SaveData()
        Dim AppName As String = Application.ProductName

        SaveSetting(AppName, "DBSection", "DB_Name", DBNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_IP", ServerMySQL)
        SaveSetting(AppName, "DBSection", "DB_User", UserNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_Password", PwdMySQL)

        MsgBox("Database connection settings are saved.", MsgBoxStyle.Information)
    End Sub

    Sub getData()
        Dim AppName As String = Application.ProductName
        Try
            DBNameMySQL = GetSetting(AppName, "DBSection", "DB_Name", "temp")
            ServerMySQL = GetSetting(AppName, "DBSection", "DB_IP", "temp")
            UserNameMySQL = GetSetting(AppName, "DBSection", "DB_User", "temp")
            PwdMySQL = GetSetting(AppName, "DBSection", "DB_Password", "temp")
        Catch ex As Exception
            MsgBox("System registry was not established, you can set/save " &
            "these settings by pressing F1", MsgBoxStyle.Information)
        End Try
    End Sub




End Module
