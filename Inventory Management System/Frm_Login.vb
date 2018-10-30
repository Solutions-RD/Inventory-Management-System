Imports MySql.Data.MySqlClient

Imports System.Text
Imports System.Security.Cryptography

Public Class Frm_Login
    Dim ConnectionString As String = "Server=DESKTOP-OQPQSOP;User Id=Admin;Password=AdminPickles1350!;Database=inventory"
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

        'https://stackoverflow.com/questions/16027925/select-from-mysql-put-into-variable-vb-net

        Dim UserName As String = LCase(TxtBox_UserName.Text)
        Dim Password As String = TxtBox_Password.Text

        If UserName = "a" And Password = "a" Then 'THIS MUST BE REMOVED BEFORE WE RELEASE!!! HUGE SECURITY FLAW!!!!!!!!!!!!! obviously
            MsgBox("admin login")
            Login()
        Else
            If TxtBox_Password.Text <> "" And TxtBox_UserName.Text <> "" And ConnectionStatus = True Then

                Dim MyCommand As New MySqlCommand("SELECT UserID FROM Users WHERE Username = @EncryptedUserName AND password = @EncryptedPassword", Connection) 'Query template

                With MyCommand
                    .Parameters.Add("@EncryptedUsername", MySqlDbType.LongText).Value = GenerateSHA256String(TxtBox_UserName.Text).ToString 'Adding protected paramaters
                    .Parameters.Add("@EncryptedPassword", MySqlDbType.LongText).Value = GenerateSHA256String(TxtBox_Password.Text).ToString
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


            End If

        End If

    End Sub


    Private Sub Btn_Forgotten_Click(sender As Object, e As EventArgs) Handles Btn_Forgotten.Click
        MsgBox("Please contact the system admin on: " & My.Settings.SystemAdmin)
    End Sub

    Private Sub Login()

        Frm_NonAdminCustomer.Show()

    End Sub


    Public Shared Function GenerateSHA256String(ByVal inputString) As String 'This is not my code, I might implement my own SHA256 hash soon, but for now, this will do. 
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString()
    End Function


    'Private Sub UpdateListView(Which As String)
    '    Dim MaxRow As Integer = xlSheet.Cells(2, 6).value

    '    Try
    '        LstView_DataBase.Items.Clear()

    '        If Which = "System" Then
    '            xlApp.Visible = True
    '        End If

    '        Dim C(4) As String
    '        Dim Done As Boolean = False
    '        Dim Row As Integer = 2
    '        Dim LvItem As New ListViewItem

    '        Do
    '            Dim temp As String = xlSheet.Cells(Row, 1).Value
    '            If temp = "" And Row = MaxRow + 1 Then 'Every value has been added
    '                Done = True
    '            ElseIf temp <> "" Then 'There are still more values to add
    '                C(1) = xlSheet.Cells(Row, 1).value
    '                C(2) = xlSheet.Cells(Row, 2).value
    '                C(3) = xlSheet.Cells(Row, 3).value
    '                C(4) = xlSheet.Cells(Row, 4).value

    '                LvItem = Me.LstView_DataBase.Items.Add(C(1))
    '                LvItem.SubItems.AddRange(New String() {C(2), C(3), C(4)})
    '            End If

    '            Row += 1
    '        Loop Until Done = True
    '    Catch ex As Exception
    '        MsgBox("Failed to load DataBase. Boopies will not be available for this execution!!!!")
    '    End Try
    'End Sub
End Class