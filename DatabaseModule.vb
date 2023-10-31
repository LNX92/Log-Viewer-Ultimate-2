Imports System.Data.SQLite
Public Module DatabaseModule
    Dim SQLiteConnectionString As SQLite.SQLiteConnection = New SQLiteConnection("Data Source=C:\\SWQA Log Viewer Ultimate 2\Data\Data.db;Version=3;New=False;Compress=True;")
    Dim SQLiteConnectionStringOnline As SQLite.SQLiteConnection = New SQLiteConnection("Data Source=\\\\10.3.21.22\\Yazılım Kalite Güvence\\Public_Errors_Prints\\Data.db;Version=3;New=False;Compress=True;")


    Public CurrentDatabase As String = ""

    Public Sub LoadOnlineData()
        On Error Resume Next

        Dim sqlite_cmd As SQLiteCommand
        sqlite_cmd = SQLiteConnectionStringOnline.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM Error_List_Table;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionStringOnline.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionStringOnline.Close()
    End Sub
    Public Sub SyncOnlineDatabase()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand

        If (CurrentDatabase = "Main") Then
            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(4))
            Form1.Handle2 = Form1.ShowProgressPanel2()

            AnalysisModule.LoadErrorTable()
            LoadOnlineData()
            Form1.GridView1.OptionsSelection.MultiSelect = True
            Form1.GridView3.OptionsSelection.MultiSelect = True

            Form1.GridView3.SelectAll()
            Dim selectedRowHandles As Int32() = Form1.GridView3.GetSelectedRows()
            Dim I As Integer
            For I = 0 To selectedRowHandles.Length - 1
                Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                If (selectedRowHandle >= 0) Then
                    Dim MDAdd_id_getir = CType(Form1.GridView3.GetRowCellValue(selectedRowHandles(I), "id").ToString(), String)
                    Dim MDAdd_Error_Name_getir = CType(Form1.GridView3.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                    Dim CheckExistError As String = ""

                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "SELECT Error_Name FROM Error_List_Table WHERE Error_Name = " & "'" & MDAdd_Error_Name_getir & "'" & ";"
                    Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                        sdr.Read()
                        CheckExistError = sdr("Error_Name").ToString()
                    End Using
                    SQLiteConnectionString.Close()

                    If (CheckExistError = "") Then
                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "INSERT INTO Error_List_Table (Error_Name) VALUES (" & "'" & MDAdd_Error_Name_getir & "'" & ");"
                        sqlite_cmd.ExecuteNonQuery()
                        SQLiteConnectionString.Close()
                    ElseIf (CheckExistError <> "") Then
                        'Nothing
                    End If
                End If
            Next

            Form1.GridView3.OptionsSelection.MultiSelect = False
        ElseIf (CurrentDatabase <> "Main") Then
            'Nothing
        End If

        AnalysisModule.LoadErrorTable()
        CurrentDatabase = "Main"

        Form1.CloseProgressPanel2(Form1.Handle2)
        Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(5))
    End Sub
    Public Sub DeleteSelectedErrors()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand

        Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim MDAdd_id_getir = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "id").ToString(), String)

                If (CurrentDatabase = "Main") Then
                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "DELETE FROM Error_List_Table WHERE id = " & "'" & MDAdd_id_getir & "'" & ";"
                    sqlite_cmd.ExecuteNonQuery()
                    SQLiteConnectionString.Close()
                ElseIf (CurrentDatabase = "Favourites_1") Then
                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "DELETE FROM Favourites_1 WHERE id = " & "'" & MDAdd_id_getir & "'" & ";"
                    sqlite_cmd.ExecuteNonQuery()
                    SQLiteConnectionString.Close()
                ElseIf (CurrentDatabase = "Favourites_2") Then
                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "DELETE FROM Favourites_2 WHERE id = " & "'" & MDAdd_id_getir & "'" & ";"
                    sqlite_cmd.ExecuteNonQuery()
                    SQLiteConnectionString.Close()
                ElseIf (CurrentDatabase = "Favourites_3") Then
                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "DELETE FROM Favourites_3 WHERE id = " & "'" & MDAdd_id_getir & "'" & ";"
                    sqlite_cmd.ExecuteNonQuery()
                    SQLiteConnectionString.Close()
                End If
            End If
        Next

        Form1.RibbonPageGroup4.Visible = False
        Form1.RibbonPageGroup6.Visible = False

        If (CurrentDatabase = "Main") Then
            AnalysisModule.LoadErrorTable()
        ElseIf (CurrentDatabase = "Favourites_1") Then
            AnalysisModule.LoadFavouritesList_1()
        ElseIf (CurrentDatabase = "Favourites_2") Then
            AnalysisModule.LoadFavouritesList_2()
        ElseIf (CurrentDatabase = "Favourites_3") Then
            AnalysisModule.LoadFavouritesList_3()
        End If
    End Sub
    Public Sub AddError()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim CheckExistError As String = ""

        If (AddErrorForm.TextEdit1.Text <> "") Then
            SQLiteConnectionString.Open()
            sqlite_cmd = SQLiteConnectionString.CreateCommand()
            sqlite_cmd.CommandText = "SELECT Error_Name FROM Error_List_Table WHERE Error_Name = " & "'" & AddErrorForm.TextEdit1.Text.ToString() & "'" & ";"
            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                sdr.Read()
                CheckExistError = sdr("Error_Name").ToString()
            End Using
            SQLiteConnectionString.Close()

            If (CheckExistError = "") Then
                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "INSERT INTO Error_List_Table (Error_Name) VALUES (" & "'" & AddErrorForm.TextEdit1.Text.ToString() & "'" & ");"
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()

                AddErrorForm.TextEdit1.Clear()
                Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(2))
            ElseIf (CheckExistError <> "") Then
                Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(1))
            End If
        ElseIf (AddErrorForm.TextEdit1.Text = "") Then
            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(6))
        End If
    End Sub

End Module
