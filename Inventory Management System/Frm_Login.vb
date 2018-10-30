Imports System.Data.SqlClient

Public Class Frm_Login
    Dim ConnectionString As String = "User ID=root;Password=Pickles1350!;Initial Catalog=Inventory;Data Source=10.125.194.171,3066"
    Dim Connection As New SqlConnection(ConnectionString)

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        Connection.Open()

            If Connection.State = ConnectionState.Closed Then
                MsgBox("Connection to DB could not be made!!")
            Else
                MsgBox("Successfully connected")
            End If
        'Catch
        '    MsgBox("Connection Failed")
        'End Try

    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim UserName As String = TxtBox_UserName.Text
        Dim Password As String = TxtBox_Password.Text

        EstablishConnection()

    End Sub

    Private Sub EstablishConnection() 'Make first connection to Server to check login credentials

    End Sub

    Private Sub Btn_Forgotten_Click(sender As Object, e As EventArgs) Handles Btn_Forgotten.Click
        MsgBox("Please contact the system admin on: " & My.Settings.SystemAdmin)
    End Sub
End Class