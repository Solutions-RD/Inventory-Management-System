﻿Public Class Frm_Login
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim UserName As String = TxtBox_UserName.Text
        Dim Password As String = TxtBox_Password.Text

        EstablishConnection()

    End Sub

    Private Sub EstablishConnection() 'Make first connection to Server to check login credentials



    End Sub
End Class