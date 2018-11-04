Imports MySql.Data.MySqlClient

Imports System.Text
Imports System.Security.Cryptography

Public Class Frm_Login
    Public ConnectionString As String = "Server=DESKTOP-OQPQSOP;User Id=Admin;Password=AdminPickles1350!;Database=inventory"
    Dim Connection As New MySqlConnection(ConnectionString)

    Dim ConnectionStatus As Boolean = True

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Connection.Open()

            If Connection.State = ConnectionState.Closed Then 'DB Connection Test
                MsgBox("Connection to DB could not be made!! Log in with offline details")

                ConnectionStatus = False
            End If

            Connection.Close()
        Catch ex As Exception
            MsgBox("Connection Failed, with error code: " & ex.ToString())

            ConnectionStatus = False
        End Try

    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim UserName As String = LCase(TxtBox_UserName.Text)
        Dim Password As String = TxtBox_Password.Text

        If UserName = "a" And Password = "a" Then 'THIS MUST BE REMOVED BEFORE WE RELEASE!!! HUGE SECURITY FLAW!!!!!!!!!!!!! obviously
            MsgBox("admin login")
            Login()
        Else
            If TxtBox_Password.Text <> "" And TxtBox_UserName.Text <> "" And ConnectionStatus = True Then

                Dim MyCommand As New MySqlCommand("SELECT UserID FROM Users WHERE Username = @EncryptedUserName AND password = @EncryptedPassword", Connection) 'Query template

                With MyCommand
                    .Parameters.Add("@EncryptedUsername", MySqlDbType.LongText).Value = GenerateSHA256String(UserName).ToString 'Adding protected paramaters
                    .Parameters.Add("@EncryptedPassword", MySqlDbType.LongText).Value = GenerateSHA256String(Password).ToString
                End With

                Connection.Open()
                Dim response As String = Convert.ToString(MyCommand.ExecuteScalar()) 'Actual query execution
                Connection.Close()

                If response.Length > 0 Then
                    Login()
                Else
                    MsgBox("Username or password incorrect")
                End If
            ElseIf TxtBox_Password.Text = "" Or TxtBox_UserName.Text = "" Then
                MsgBox("Please fill out both Username and password")

            ElseIf ConnectionStatus = False Then
                MsgBox("There is no connection to the server, please use the offline login details!")
            End If

        End If

    End Sub


    Private Sub Btn_Forgotten_Click(sender As Object, e As EventArgs) Handles Btn_Forgotten.Click
        MsgBox("Please contact the system admin on: " & My.Settings.SystemAdmin)
    End Sub

    Private Sub Login()

        Frm_NonAdminCustomerFullStock.Show()

    End Sub

    Public Shared Function GenerateSHA256String(ByVal inputString) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function
End Class