﻿Imports MySql.Data.MySqlClient

Public Class Frm_ChangeLogInDetails

    Dim ConnectionString As String = Frm_Login.ConnectionString
    Dim Connection As New MySqlConnection(ConnectionString)

    Private Sub Frm_ChangeLogInDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Btn_ChangePassword_Click(sender As Object, e As EventArgs) Handles Btn_ChangePassword.Click
        Dim MyCommand As New MySqlCommand

        Dim ValidInput As Boolean = False
        Dim Username, Password As String

        Do
            Username = InputBox("Please enter the User name:", "UserName")
            Password = InputBox("Please enter the current Password:", "Password")

            If Username = "" Or Password = "" Then
                Exit Sub
            Else
                ValidInput = True
            End If
        Loop Until ValidInput = True

        MyCommand = New MySqlCommand("SELECT UserID FROM Users WHERE Username = @EncryptedUsername AND Password = @EncrypterPassword", Connection)

        With MyCommand
            .Parameters.Add("@encrypterUsername", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(Username)
            .Parameters.Add("@encrypterUsername", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(Password)
        End With

        Connection.Open()
        Dim SelectResponse As String = MyCommand.ExecuteScalar()
        Connection.Close()

        If SelectResponse.Length > 0 Then
            Dim NewPassword As String = InputBox("Please enter the new password for: " & Username, "New password")

            MyCommand = New MySqlCommand("UPDATE Users SET Password = @EncryptedPassword WHERE UserID = @ID")

            With MyCommand
                .Parameters.Add("@EncryptedPassword", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(NewPassword)
                .Parameters.Add("@ID", MySqlDbType.Int64).Value = SelectResponse.ToString
            End With

            Connection.Open()
            MyCommand.ExecuteScalar()
            Connection.Close()

            MsgBox("The password for: " & Username & " has been successfully changed")
        Else
            MsgBox("Invalud username")
        End If

    End Sub

    Private Sub Btn_ChangeUsername_Click(sender As Object, e As EventArgs) Handles Btn_ChangeUserName.Click
        Dim MyCommand As New MySqlCommand

        Dim ValidInput As Boolean = False
        Dim Username, Password As String

        Do
            Username = InputBox("Please enter the current User name:", "UserName")
            Password = InputBox("Please enter the Password:", "Password")

            If Username = "" Or Password = "" Then
                Exit Sub
            Else
                ValidInput = True
            End If
        Loop Until ValidInput = True

        MyCommand = New MySqlCommand("SELECT UserID FROM Users WHERE Username = @EncryptedUsername AND Password = @EncrypterPassword", Connection)

        With MyCommand
            .Parameters.Add("@encrypterUsername", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(Username)
            .Parameters.Add("@encrypterUsername", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(Password)
        End With

        Connection.Open()
        Dim SelectResponse As String = MyCommand.ExecuteScalar()
        Connection.Close()

        If SelectResponse.Length > 0 Then
            Dim NewUsername As String = InputBox("Please enter the new Username for: " & Username, "New Username")

            MyCommand = New MySqlCommand("UPDATE Users SET Username = @EncryptedUsername WHERE UserID = @ID")

            With MyCommand
                .Parameters.Add("@EncryptedUsername", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(NewUsername)
                .Parameters.Add("@ID", MySqlDbType.Int64).Value = SelectResponse.ToString
            End With

            Connection.Open()
            MyCommand.ExecuteScalar()
            Connection.Close()

            MsgBox(Username & " has been successfully changed to " & NewUsername)
        Else
            MsgBox("Invalud username")
        End If

    End Sub

    Private Sub Btn_AddUser_Click(sender As Object, e As EventArgs) Handles Btn_AddUser.Click
        Dim ValidInput As Boolean = False

        Dim Username, Password, Rights As String

        Do
            Username = InputBox("Username:", "New Username")
            If Username = "" Then 'Cancel clicked, or no input given
                Exit Sub
            Else
                ValidInput = True
            End If
        Loop Until ValidInput = True

        Dim MyCommand As New MySqlCommand("SELECT UserID FROM users WHERE Username = @EncryptedUsername")

        With MyCommand
            .Parameters.Add("@encryptedUsername", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(Username)
        End With

        Connection.Open()
        Dim UserResponse As String = MyCommand.ExecuteScalar()
        Connection.Close()

        If UserResponse.Length <> 0 Then
            MsgBox("That user already exists!!!")
            Exit Sub
        End If

        ValidInput = False

        Do
            Password = InputBox("Password:", "New Password")
            If Password = "" Then 'Cancel Clicked or no input given
                Exit Sub
            Else
                ValidInput = True
            End If
        Loop Until ValidInput = True

        ValidInput = False

        Do
            Rights = LCase(InputBox("Enter privilage: A) Admin; U) User", "Privilages"))
            If Rights = "" Then 'Cancel clicked or no input
                Exit Sub
            ElseIf Rights <> "u" Or Rights <> "u" Then
                MsgBox("Please enter a valid input")
            Else
                ValidInput = True
            End If
        Loop Until ValidInput = True

        'INSERT QUERY FOR ADDING NEw USER
        MyCommand = New MySqlCommand("INSERT INTO 'Inventory'.'users'('Username','Password','Privilage') VALUES (@Username, @Password, @Privilage)", Connection)

        With MyCommand
            .Parameters.Add("@Username", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(Username)
            .Parameters.Add("@Password", MySqlDbType.LongText).Value = Frm_Login.GenerateSHA256String(Password)
            If Rights = "a" Then
                .Parameters.Add("@Privilage", MySqlDbType.LongText).Value = "Admin"
            ElseIf Rights = "u" Then
                .Parameters.Add("@Privilage", MySqlDbType.LongText).Value = "User"
            End If
        End With

        'May be worth sticking a Try Catch around this area at a later date
        Connection.Open()
        MyCommand.ExecuteScalar() 'Actual query execution
        Connection.Close()


    End Sub

    Private Sub Btn_RemoveUser_Click(sender As Object, e As EventArgs) Handles Btn_RemoveUser.Click

        Dim ValidAnswer As Boolean = False
        Dim user As String = ""

        Do
            user = LCase(InputBox("Please enter the user you with to remove", "User removal"))

            If user = "" Then
                Exit Sub
            Else
                ValidAnswer = True
            End If
        Loop Until ValidAnswer = True

        Dim EncryptedUsername As String = Frm_Login.GenerateSHA256String(user)

        Dim Mycommand As New MySqlCommand("SELECT UserID FROM Users WHERE Username = @EncryptedUserName", Connection)
        Mycommand.Parameters.Add("@EncryptedUsername", MySqlDbType.LongText).Value = EncryptedUsername

        Connection.Open()
        Dim Responce As String = Convert.ToString(Mycommand.ExecuteScalar())
        Connection.Close()

        If Responce.Length > 0 Then 'User exists
            Mycommand = New MySqlCommand("UPDATE `inventory`.`users` SET `UserID` = '', `Username` = '', `Password` = '' WHERE Username = @EncryptedUsername;", Connection)
            Mycommand.Parameters.Add("@EncryptedUsername", MySqlDbType.LongText).Value = EncryptedUsername

            Connection.Open()
            Mycommand.ExecuteScalar()
            Connection.Close()
        Else
            MsgBox("User does not exist")
        End If

    End Sub


    'Dim MyCommand As New MySqlCommand("SELECT UserID FROM Users WHERE Username = @EncryptedUserName AND password = @EncryptedPassword", Connection) 'Query template

    'With MyCommand
    '.Parameters.Add("@EncryptedUsername", MySqlDbType.LongText).Value = GenerateSHA256String(TxtBox_UserName.Text).ToString 'Adding protected paramaters
    '.Parameters.Add("@EncryptedPassword", MySqlDbType.LongText).Value = GenerateSHA256String(TxtBox_Password.Text).ToString
    'End With

    'Connection.Open()
    'Dim response As String = Convert.ToString(MyCommand.ExecuteScalar()) 'Actual query execution
    'Connection.Close()

End Class