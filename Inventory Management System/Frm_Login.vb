Imports MySql.Data.MySqlClient

Public Class Frm_Login
    Dim ConnectionString As String = "Server=localhost;User Id=root;Password=Pickles1350!;Database=inventory"
    Dim Connection As New MySqlConnection(ConnectionString)

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Connection.Open()

            If Connection.State = ConnectionState.Closed Then
                MsgBox("Connection to DB could not be made!! Log in with offline details")
            End If
        Catch
            MsgBox("Connection Failed")
        End Try

    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click

        Dim UserName As String = TxtBox_UserName.Text
        Dim Password As String = TxtBox_Password.Text

        If Connection.State = ConnectionState.Closed Then
            If UserName = "a" And Password = "a" Then
                Login()
            Else
                MsgBox("Incorrect username of password")
            End If
        Else
            If UserName = "a" And Password = "a" Then

                Dim MyCommand As New MySqlCommand("SELECT * FROM items WHERE ItemID = @id", Connection)
                MyCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = "1"
                Dim Reader As MySqlDataReader = MyCommand.ExecuteReader()



                'Login()
            Else
                MsgBox("Incorrect username of password")
            End If
        End If

    End Sub


    Private Sub Btn_Forgotten_Click(sender As Object, e As EventArgs) Handles Btn_Forgotten.Click
        MsgBox("Please contact the system admin on: " & My.Settings.SystemAdmin)
    End Sub

    Private Sub Login()

        Frm_NonAdminCustomer.Show()

    End Sub


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