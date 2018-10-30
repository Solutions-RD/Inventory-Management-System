Imports System.Data.SqlClient

Public Class Frm_Login
    Dim Connection As New SqlConnection("")


    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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