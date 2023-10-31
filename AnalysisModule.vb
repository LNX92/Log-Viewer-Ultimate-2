Imports System.Data.SQLite
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.GC
Imports System.Threading

Public Module AnalysisModule

    Dim SQLiteConnectionString As SQLite.SQLiteConnection = New SQLiteConnection("Data Source=C:\\SWQA Log Viewer Ultimate 2\Data\Data.db;Version=3;New=False;Compress=True;")

    Public ErrorTableCount As Integer = 0
    Public rOutput_1 As String = ""
    Public rOutput_2 As String = ""
    Public rOutput_3 As String = ""
    Public rOutput_4 As String = ""
    Public Error_LOG_1 As String = ""
    Public Percentege As String = ""

    Public Favourites_1_List_Count As Integer = 0
    Public Favourites_2_List_Count As Integer = 0
    Public Favourites_3_List_Count As Integer = 0
    Public Sub Large_Error_Table_4_Export()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = Form1.ListBoxControl2.Items.Item(3).ToString()
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.ListBoxControl1.Items.Item(3).ToString())

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_4_Error_List_Table WHERE Count > 0;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If

        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub

    Public Sub Large_Error_Table_3_Export()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = Form1.ListBoxControl2.Items.Item(2).ToString()
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.ListBoxControl1.Items.Item(2).ToString())

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_3_Error_List_Table WHERE Count > 0;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If

        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub
    Public Sub Large_Error_Table_2_Export()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = Form1.ListBoxControl2.Items.Item(1).ToString()
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.ListBoxControl1.Items.Item(1).ToString())

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_2_Error_List_Table WHERE Count > 0;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If

        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub
    Public Sub Large_Error_Table_1_Export()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = Form1.ListBoxControl2.Items.Item(0).ToString()
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.ListBoxControl1.Items.Item(0).ToString())

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_1_Error_List_Table WHERE Count > 0;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If

        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub
    Public Sub LargeScanModule()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim CheckExistError As String
        Dim CheckErrorCount As String

        DeleteAllLogErrorTable()

        Dim selectedRowHandlesTemp As Int32() = Form1.GridView1.GetSelectedRows()
        Dim ITemp As Integer
        For ITemp = 0 To selectedRowHandlesTemp.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandlesTemp(ITemp)
            If (selectedRowHandle >= 0) Then
                Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandlesTemp(ITemp), "Error_Name").ToString(), String)
                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & "0" & "'" & ");"
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()
            End If
        Next

        For ITemp = 0 To selectedRowHandlesTemp.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandlesTemp(ITemp)
            If (selectedRowHandle >= 0) Then
                Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandlesTemp(ITemp), "Error_Name").ToString(), String)
                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & "0" & "'" & ");"
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()
            End If
        Next

        For ITemp = 0 To selectedRowHandlesTemp.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandlesTemp(ITemp)
            If (selectedRowHandle >= 0) Then
                Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandlesTemp(ITemp), "Error_Name").ToString(), String)
                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & "0" & "'" & ");"
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()
            End If
        Next

        For ITemp = 0 To selectedRowHandlesTemp.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandlesTemp(ITemp)
            If (selectedRowHandle >= 0) Then
                Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandlesTemp(ITemp), "Error_Name").ToString(), String)
                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "INSERT INTO LOGC_4_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & "0" & "'" & ");"
                sqlite_cmd.ExecuteNonQuery()
                SQLiteConnectionString.Close()
            End If
        Next

        If (Form1.ListboxItemsCount = 1) Then
            Percentege = "1/1"
            rOutput_1 = Form1.ListBoxControl1.Items.Item(0).ToString()

            Dim fileNumber = 0
            Dim ExtensionDetect As String = System.IO.Path.GetExtension(rOutput_1)

            Using sr As StreamReader = New StreamReader(rOutput_1)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            Dim CurrentFileNumber As Integer = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_1_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber
            Large_Error_Table_1_Export()

            Dim directoryName As String = "C:\SWQA Log Viewer Ultimate 2\LF_Output\"
            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next
        ElseIf (Form1.ListboxItemsCount = 2) Then
            Percentege = "1/2"
            rOutput_1 = Form1.ListBoxControl1.Items.Item(0).ToString()
            rOutput_2 = Form1.ListBoxControl1.Items.Item(1).ToString()

            '----------------------------- File - 1 -------------------------------------------
            Dim fileNumber = 0
            Dim ExtensionDetect As String = System.IO.Path.GetExtension(rOutput_1)

            Using sr As StreamReader = New StreamReader(rOutput_1)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Dim CurrentFileNumber As Integer = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_1_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            Dim directoryName As String = "C:\SWQA Log Viewer Ultimate 2\LF_Output\"
            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Large_Error_Table_1_Export()
            Percentege = "2/2"

            fileNumber = 0
            ExtensionDetect = System.IO.Path.GetExtension(rOutput_2)

            Using sr As StreamReader = New StreamReader(rOutput_2)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            CurrentFileNumber = 1

            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_2_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            Large_Error_Table_2_Export()

            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next
        ElseIf (Form1.ListboxItemsCount = 3) Then
            Percentege = "1/3"
            rOutput_1 = Form1.ListBoxControl1.Items.Item(0).ToString()
            rOutput_2 = Form1.ListBoxControl1.Items.Item(1).ToString()
            rOutput_3 = Form1.ListBoxControl1.Items.Item(2).ToString()

            '----------------------------- File - 1 -------------------------------------------
            Dim fileNumber = 0
            Dim ExtensionDetect As String = System.IO.Path.GetExtension(rOutput_1)

            Using sr As StreamReader = New StreamReader(rOutput_1)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            Dim CurrentFileNumber As Integer = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_1_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            Dim directoryName As String = "C:\SWQA Log Viewer Ultimate 2\LF_Output\"
            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Percentege = "2/3"
            Large_Error_Table_1_Export()

            fileNumber = 0
            ExtensionDetect = System.IO.Path.GetExtension(rOutput_2)

            Using sr As StreamReader = New StreamReader(rOutput_2)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            CurrentFileNumber = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_2_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Percentege = "3/3"
            Large_Error_Table_2_Export()
            fileNumber = 0
            ExtensionDetect = System.IO.Path.GetExtension(rOutput_3)

            Using sr As StreamReader = New StreamReader(rOutput_3)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            CurrentFileNumber = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_3_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Large_Error_Table_3_Export()
        ElseIf (Form1.ListboxItemsCount = 4) Then
            Percentege = "1/4"
            rOutput_1 = Form1.ListBoxControl1.Items.Item(0).ToString()
            rOutput_2 = Form1.ListBoxControl1.Items.Item(1).ToString()
            rOutput_3 = Form1.ListBoxControl1.Items.Item(2).ToString()
            rOutput_4 = Form1.ListBoxControl1.Items.Item(3).ToString()

            '----------------------------- File - 1 -------------------------------------------
            Dim fileNumber = 0
            Dim ExtensionDetect As String = System.IO.Path.GetExtension(rOutput_1)

            Using sr As StreamReader = New StreamReader(rOutput_1)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            Dim CurrentFileNumber As Integer = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_1_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            Dim directoryName As String = "C:\SWQA Log Viewer Ultimate 2\LF_Output\"
            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Percentege = "2/4"
            Large_Error_Table_1_Export()

            fileNumber = 0
            ExtensionDetect = System.IO.Path.GetExtension(rOutput_2)

            Using sr As StreamReader = New StreamReader(rOutput_2)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            CurrentFileNumber = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_2_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Percentege = "3/4"
            Large_Error_Table_2_Export()

            fileNumber = 0
            ExtensionDetect = System.IO.Path.GetExtension(rOutput_3)

            Using sr As StreamReader = New StreamReader(rOutput_3)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            CurrentFileNumber = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_3_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Percentege = "4/4"
            Large_Error_Table_3_Export()

            fileNumber = 0
            ExtensionDetect = System.IO.Path.GetExtension(rOutput_4)

            Using sr As StreamReader = New StreamReader(rOutput_4)

                While Not sr.EndOfStream
                    Dim count = 0

                    Using sw As StreamWriter = New StreamWriter("C:\SWQA Log Viewer Ultimate 2\LF_Output\" & Interlocked.Increment(fileNumber).ToString() & ExtensionDetect)
                        sw.AutoFlush = True

                        While Not sr.EndOfStream AndAlso Interlocked.Increment(count) < 2000000
                            sw.WriteLine(sr.ReadLine())
                        End While
                    End Using
                End While
            End Using

            CurrentFileNumber = 1

            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()

            For CurrentFileNumber = 1 To fileNumber - 1
                Dim StrFile As String = System.IO.File.ReadAllText(CStr("C:\SWQA Log Viewer Ultimate 2\LF_Output\" + CurrentFileNumber.ToString() + ExtensionDetect))

                Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
                Dim I As Integer
                For I = 0 To selectedRowHandles.Length - 1
                    Dim selectedRowHandle As Int32 = selectedRowHandles(I)
                    If (selectedRowHandle >= 0) Then
                        Dim ErrName = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                        Dim m = Regex.Match(StrFile, ErrName, RegexOptions.Compiled)
                        Dim mCount = Regex.Matches(StrFile, ErrName, RegexOptions.Compiled)

                        '----------------------- Temp 1 ------------------------------------
                        If m.Success = True Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "SELECT Error_Name, Count FROM LOGC_4_Error_List_Table WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                            Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                                sdr.Read()
                                CheckExistError = sdr("Error_Name").ToString()
                                CheckErrorCount = sdr("Count").ToString()
                            End Using
                            SQLiteConnectionString.Close()

                            If (CheckExistError = "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "INSERT INTO LOGC_4_Error_List_Table (Error_Name, Count) VALUES (" & "'" & ErrName & "'" & "," & "'" & mCount.Count.ToString() & "'" & ");"
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            ElseIf (CheckErrorCount <> "") Then
                                SQLiteConnectionString.Open()
                                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                                sqlite_cmd.CommandText = "UPDATE LOGC_4_Error_List_Table SET Count = @Count WHERE Error_Name = " & "'" & ErrName & "'" & ";"
                                sqlite_cmd.Parameters.AddWithValue("@Count", (CInt(CheckErrorCount) + CInt(mCount.Count)).ToString())
                                sqlite_cmd.ExecuteNonQuery()
                                SQLiteConnectionString.Close()
                            End If
                        End If
                    End If
                Next
                Percentege = "% " & CInt((CurrentFileNumber / fileNumber) * (100)).ToString()
            Next CurrentFileNumber

            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next

            Large_Error_Table_4_Export()
        End If

        Percentege = ""
        LoadErrorTable()
        rOutput_1 = ""
        rOutput_2 = ""
        rOutput_3 = ""
        rOutput_4 = ""

        Form1.ListBoxControl1.Items.Clear()
        Form1.ListBoxControl2.Items.Clear()

        Form1.CloseProgressPanel(Form1.Handle)
        Form1.CloseProgressPanel2(Form1.Handle2)

        Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(3))
        System.IO.File.WriteAllText("C:\Users\mustafasonk\Desktop\denemeeeeeeeeeeeee.txt", "1")
    End Sub

    Public Sub TableSelection()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand

        If (TableSelectionForm.ComboBoxEdit1.Text = "Favori Listesi 1") Then
            Form1.RibbonPageGroup1.Visible = False
            LoadFavouritesList_1()
            Form1.Handle = Form1.ShowProgressPanel()
            Form1.Handle2 = Form1.ShowProgressPanel2()
            Form1.Timer1.Start()
            TableSelectionForm.Hide()
        ElseIf (TableSelectionForm.ComboBoxEdit1.Text = "Favori Listesi 2") Then
            Form1.RibbonPageGroup1.Visible = False
            LoadFavouritesList_2()
            Form1.Handle = Form1.ShowProgressPanel()
            Form1.Handle2 = Form1.ShowProgressPanel2()
            Form1.Timer1.Start()
            TableSelectionForm.Hide()
        ElseIf (TableSelectionForm.ComboBoxEdit1.Text = "Favori Listesi 3") Then
            Form1.RibbonPageGroup1.Visible = False
            LoadFavouritesList_3()
            Form1.Handle = Form1.ShowProgressPanel()
            Form1.Handle2 = Form1.ShowProgressPanel2()
            Form1.Timer1.Start()
            TableSelectionForm.Hide()
        ElseIf (TableSelectionForm.ComboBoxEdit1.Text = "Tüm Hata Listesi") Then
            Form1.RibbonPageGroup1.Visible = False
            LoadErrorTable()
            Form1.Handle = Form1.ShowProgressPanel()
            Form1.Handle2 = Form1.ShowProgressPanel2()
            Form1.Timer1.Start()
            TableSelectionForm.Hide()
        End If

        Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
    End Sub
    Public Sub Analysis_Check_Favourites()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand

        LoadFavouritesList_1()
        Favourites_1_List_Count = Form1.GridView1.RowCount
        LoadFavouritesList_2()
        Favourites_2_List_Count = Form1.GridView1.RowCount
        LoadFavouritesList_3()
        Favourites_3_List_Count = Form1.GridView1.RowCount

        LoadErrorTable()
        TableSelectionForm.ComboBoxEdit1.Properties.Items.Clear()
        TableSelectionForm.ComboBoxEdit1.Properties.Items.Add("Tüm Hata Listesi")

        If (Favourites_1_List_Count > 0) Then
            TableSelectionForm.ComboBoxEdit1.Properties.Items.Add("Favori Listesi 1")
        End If

        If (Favourites_2_List_Count > 0) Then
            TableSelectionForm.ComboBoxEdit1.Properties.Items.Add("Favori Listesi 2")
        End If

        If (Favourites_3_List_Count > 0) Then
            TableSelectionForm.ComboBoxEdit1.Properties.Items.Add("Favori Listesi 3")
        End If

        If (TableSelectionForm.ComboBoxEdit1.Properties.Items.Count > 1) Then
            TableSelectionForm.ShowDialog()
        ElseIf (TableSelectionForm.ComboBoxEdit1.Properties.Items.Count < 2) Then
            Form1.RibbonPageGroup1.Visible = False
            Form1.Handle = Form1.ShowProgressPanel()
            Form1.Handle2 = Form1.ShowProgressPanel2()
            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(0))
            Form1.Timer1.Start()
        End If
    End Sub
    Public Sub LoadFavouritesList_3()
        On Error Resume Next

        Dim sqlite_cmd As SQLiteCommand
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM Favourites_3;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl1.DataSource = dt
        SQLiteConnectionString.Close()

        Form1.RibbonPageGroup4.Visible = False
        Form1.RibbonPageGroup6.Visible = False
        DatabaseModule.CurrentDatabase = "Favourites_3"
    End Sub
    Public Sub LoadFavouritesList_2()
        On Error Resume Next

        Dim sqlite_cmd As SQLiteCommand
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM Favourites_2;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl1.DataSource = dt
        SQLiteConnectionString.Close()

        Form1.RibbonPageGroup4.Visible = False
        Form1.RibbonPageGroup6.Visible = False
        DatabaseModule.CurrentDatabase = "Favourites_2"
    End Sub
    Public Sub LoadFavouritesList_1()
        On Error Resume Next

        Dim sqlite_cmd As SQLiteCommand
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM Favourites_1;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl1.DataSource = dt
        SQLiteConnectionString.Close()

        Form1.RibbonPageGroup4.Visible = False
        Form1.RibbonPageGroup6.Visible = False

        DatabaseModule.CurrentDatabase = "Favourites_1"
    End Sub
    Public Sub AddFavouriteError_3()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand

        Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim MDAdd_id_getir = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "id").ToString(), String)
                Dim MDAdd_Error_Name_getir = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                Dim CheckExistError As String = ""

                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "SELECT Error_Name FROM Favourites_3 WHERE Error_Name = " & "'" & MDAdd_Error_Name_getir & "'" & ";"
                Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                    sdr.Read()
                    CheckExistError = sdr("Error_Name").ToString()
                End Using
                SQLiteConnectionString.Close()

                If (CheckExistError = "") Then
                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "INSERT INTO Favourites_3 (Error_Name) VALUES (" & "'" & MDAdd_Error_Name_getir & "'" & ");"
                    sqlite_cmd.ExecuteNonQuery()
                    SQLiteConnectionString.Close()
                ElseIf (CheckExistError <> "") Then
                    'Nothing
                End If
            End If
        Next

        LoadErrorTable()
        Form1.RibbonPageGroup4.Visible = False
        Form1.RibbonPageGroup6.Visible = False
        AddTableErrorForm.CloseProgressPanel(AddTableErrorForm.Handle)
        AddTableErrorForm.Hide()
    End Sub
    Public Sub AddFavouriteError_2()
        On Error Resume Next

        Dim sqlite_cmd As SQLiteCommand

        Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim MDAdd_id_getir = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "id").ToString(), String)
                Dim MDAdd_Error_Name_getir = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                Dim CheckExistError As String = ""

                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "SELECT Error_Name FROM Favourites_2 WHERE Error_Name = " & "'" & MDAdd_Error_Name_getir & "'" & ";"
                Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                    sdr.Read()
                    CheckExistError = sdr("Error_Name").ToString()
                End Using
                SQLiteConnectionString.Close()

                If (CheckExistError = "") Then
                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "INSERT INTO Favourites_2 (Error_Name) VALUES (" & "'" & MDAdd_Error_Name_getir & "'" & ");"
                    sqlite_cmd.ExecuteNonQuery()
                    SQLiteConnectionString.Close()
                ElseIf (CheckExistError <> "") Then
                    'Nothing
                End If
            End If
        Next

        LoadErrorTable()
        Form1.RibbonPageGroup4.Visible = False
        Form1.RibbonPageGroup6.Visible = False
        AddTableErrorForm.CloseProgressPanel(AddTableErrorForm.Handle)
        AddTableErrorForm.Hide()
    End Sub
    Public Sub AddFavouriteError_1()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand

        Dim selectedRowHandles As Int32() = Form1.GridView1.GetSelectedRows()
        Dim I As Integer
        For I = 0 To selectedRowHandles.Length - 1
            Dim selectedRowHandle As Int32 = selectedRowHandles(I)
            If (selectedRowHandle >= 0) Then
                Dim MDAdd_id_getir = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "id").ToString(), String)
                Dim MDAdd_Error_Name_getir = CType(Form1.GridView1.GetRowCellValue(selectedRowHandles(I), "Error_Name").ToString(), String)

                Dim CheckExistError As String = ""

                SQLiteConnectionString.Open()
                sqlite_cmd = SQLiteConnectionString.CreateCommand()
                sqlite_cmd.CommandText = "SELECT Error_Name FROM Favourites_1 WHERE Error_Name = " & "'" & MDAdd_Error_Name_getir & "'" & ";"
                Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                    sdr.Read()
                    CheckExistError = sdr("Error_Name").ToString()
                End Using
                SQLiteConnectionString.Close()

                If (CheckExistError = "") Then
                    SQLiteConnectionString.Open()
                    sqlite_cmd = SQLiteConnectionString.CreateCommand()
                    sqlite_cmd.CommandText = "INSERT INTO Favourites_1 (Error_Name) VALUES (" & "'" & MDAdd_Error_Name_getir & "'" & ");"
                    sqlite_cmd.ExecuteNonQuery()
                    SQLiteConnectionString.Close()
                ElseIf (CheckExistError <> "") Then
                    'Nothing
                End If
            End If
        Next

        LoadErrorTable()
        Form1.RibbonPageGroup4.Visible = False
        Form1.RibbonPageGroup6.Visible = False
        AddTableErrorForm.CloseProgressPanel(AddTableErrorForm.Handle)
        AddTableErrorForm.Hide()
    End Sub
    Public Sub DeleteAllLogErrorTable()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand

        SQLiteConnectionString.Open()
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "DELETE FROM LOGC_1_Error_List_Table;"
        sqlite_cmd.ExecuteNonQuery()
        SQLiteConnectionString.Close()

        SQLiteConnectionString.Open()
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "DELETE FROM LOGC_2_Error_List_Table;"
        sqlite_cmd.ExecuteNonQuery()
        SQLiteConnectionString.Close()

        SQLiteConnectionString.Open()
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "DELETE FROM LOGC_3_Error_List_Table;"
        sqlite_cmd.ExecuteNonQuery()
        SQLiteConnectionString.Close()

        SQLiteConnectionString.Open()
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "DELETE FROM LOGC_4_Error_List_Table;"
        sqlite_cmd.ExecuteNonQuery()
        SQLiteConnectionString.Close()
    End Sub
    Public Sub LoadErrorTable_4()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = ""
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.XtraOpenFileDialog1.FileName)


        Form1.ListBoxControl2.SelectedIndex = 3
        LogExcelName = Form1.ListBoxControl2.SelectedItem.ToString()

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_4_Error_List_Table;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If

        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub
    Public Sub LoadErrorTable_3()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = ""
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.XtraOpenFileDialog1.FileName)


        Form1.ListBoxControl2.SelectedIndex = 2
        LogExcelName = Form1.ListBoxControl2.SelectedItem.ToString()

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_3_Error_List_Table;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If
        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub
    Public Sub LoadErrorTable_2()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = ""
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.XtraOpenFileDialog1.FileName)


        Form1.ListBoxControl2.SelectedIndex = 1
        LogExcelName = Form1.ListBoxControl2.SelectedItem.ToString()

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_2_Error_List_Table;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If

        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub
    Public Sub LoadErrorTable_1()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Dim LogExcelName As String = ""
        Dim FileInitialDirectory As String = System.IO.Path.GetDirectoryName(Form1.XtraOpenFileDialog1.FileName)


        Form1.ListBoxControl2.SelectedIndex = 0
        LogExcelName = Form1.ListBoxControl2.SelectedItem.ToString()

        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM LOGC_1_Error_List_Table;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl3.DataSource = dt
        SQLiteConnectionString.Close()

        If (SettingsForm.ToggleSwitch1.IsOn = False) Then
            Form1.Column_Count.Visible = False
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
            Form1.Column_Count.Visible = True
        End If

        Form1.GridControl3.ExportToXlsx(FileInitialDirectory + "\" + LogExcelName + " Hatalar" + ".xlsx")
    End Sub
    Public Sub Analysis()
        On Error Resume Next
        Dim sqlite_cmd As SQLiteCommand
        Form1.Text = "SWQA Log Viewer Ultimate 2 | Analiz Ediliyor : " & ErrorTableCount & "/" & Form1.GridView1.RowCount
        '& " | %" & (CInt((ErrorTableCount / Form1.GridView1.RowCount) * (100))).ToString()
        Percentege = "% " & (CInt((ErrorTableCount / Form1.GridView1.RowCount) * (100))).ToString()

        If (ErrorTableCount < Form1.GridView1.RowCount) Then
            If (Form1.ListboxItemsCount = 1) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            ElseIf (Form1.ListboxItemsCount = 2) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If

                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)
                    Dim m2Count = Regex.Matches(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m2Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            ElseIf (Form1.ListboxItemsCount = 3) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)
                    Dim m2Count = Regex.Matches(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m2Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)
                    Dim m3Count = Regex.Matches(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m3Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            ElseIf (Form1.ListboxItemsCount = 4) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m4 = Regex.Match(rOutput_4, Error_Name, RegexOptions.Compiled)

                    If m4.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_4_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_4_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)
                    Dim m2Count = Regex.Matches(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m2Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)
                    Dim m3Count = Regex.Matches(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m3Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m4 = Regex.Match(rOutput_4, Error_Name, RegexOptions.Compiled)
                    Dim m4Count = Regex.Matches(rOutput_4, Error_Name, RegexOptions.Compiled)

                    If m4.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_4_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_4_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m4Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            End If

            ErrorTableCount += 1
            Form1.GridView1.FocusedRowHandle = ErrorTableCount
        ElseIf (ErrorTableCount = Form1.GridView1.RowCount) Then
            Form1.Text = "SWQA Log Viewer Ultimate 2 | Analiz Ediliyor : " & ErrorTableCount & "/" & Form1.GridView1.RowCount
            Percentege = "% " & (CInt((ErrorTableCount / Form1.GridView1.RowCount) * (100))).ToString()
            '& " | %" & (CInt((ErrorTableCount / Form1.GridView1.RowCount) * (100))).ToString()

            If (Form1.ListboxItemsCount = 1) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            ElseIf (Form1.ListboxItemsCount = 2) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)
                    Dim m2Count = Regex.Matches(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m2Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            ElseIf (Form1.ListboxItemsCount = 3) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)
                    Dim m2Count = Regex.Matches(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m2Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)
                    Dim m3Count = Regex.Matches(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m3Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            ElseIf (Form1.ListboxItemsCount = 4) Then
                If (SettingsForm.ToggleSwitch1.IsOn = False) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m4 = Regex.Match(rOutput_4, Error_Name, RegexOptions.Compiled)

                    If m4.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_4_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_4_Error_List_Table (Error_Name) VALUES (" & "'" & Error_Name & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                ElseIf (SettingsForm.ToggleSwitch1.IsOn = True) Then
                    Dim Error_Name = CType(Form1.GridView1.GetFocusedRowCellValue("Error_Name").ToString(), String)
                    Dim m = Regex.Match(rOutput_1, Error_Name, RegexOptions.Compiled)
                    Dim mCount = Regex.Matches(rOutput_1, Error_Name, RegexOptions.Compiled)

                    If m.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_1_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_1_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & mCount.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m2 = Regex.Match(rOutput_2, Error_Name, RegexOptions.Compiled)
                    Dim m2Count = Regex.Matches(rOutput_2, Error_Name, RegexOptions.Compiled)

                    If m2.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_2_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_2_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m2Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m3 = Regex.Match(rOutput_3, Error_Name, RegexOptions.Compiled)
                    Dim m3Count = Regex.Matches(rOutput_3, Error_Name, RegexOptions.Compiled)

                    If m3.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_3_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_3_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m3Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If

                    Dim m4 = Regex.Match(rOutput_4, Error_Name, RegexOptions.Compiled)
                    Dim m4Count = Regex.Matches(rOutput_4, Error_Name, RegexOptions.Compiled)

                    If m4.Success = True Then
                        Dim CheckExistError As String = ""

                        SQLiteConnectionString.Open()
                        sqlite_cmd = SQLiteConnectionString.CreateCommand()
                        sqlite_cmd.CommandText = "SELECT Error_Name FROM LOGC_4_Error_List_Table WHERE Error_Name = " & "'" & Error_Name & "'" & ";"
                        Using sdr As SQLiteDataReader = sqlite_cmd.ExecuteReader()
                            sdr.Read()
                            CheckExistError = sdr("Error_Name").ToString()
                        End Using
                        SQLiteConnectionString.Close()

                        If (CheckExistError = "") Then
                            SQLiteConnectionString.Open()
                            sqlite_cmd = SQLiteConnectionString.CreateCommand()
                            sqlite_cmd.CommandText = "INSERT INTO LOGC_4_Error_List_Table (Error_Name, Count) VALUES (" & "'" & Error_Name & "'" & "," & "'" & m4Count.Count() & "'" & ");"
                            sqlite_cmd.ExecuteNonQuery()
                            SQLiteConnectionString.Close()
                        ElseIf (CheckExistError <> "") Then
                            'Nothing
                        End If
                    End If
                End If
            End If

            Form1.GridView1.FocusedRowHandle = 0

            If (Form1.ListboxItemsCount = 1) Then
                LoadErrorTable_1()
            ElseIf (Form1.ListboxItemsCount = 2) Then
                LoadErrorTable_1()
                LoadErrorTable_2()
            ElseIf (Form1.ListboxItemsCount = 3) Then
                LoadErrorTable_1()
                LoadErrorTable_2()
                LoadErrorTable_3()
            ElseIf (Form1.ListboxItemsCount = 4) Then
                LoadErrorTable_1()
                LoadErrorTable_2()
                LoadErrorTable_3()
                LoadErrorTable_4()
            End If

            Form1.CloseProgressPanel(Form1.Handle)
            Form1.CloseProgressPanel2(Form1.Handle2)

            Form1.RibbonPageGroup1.Visible = True
            Form1.RibbonPageGroup2.Visible = False
            Form1.Text = "SWQA Log Viewer Ultimate 2"
            Form1.RibbonPageGroup4.Visible = False
            Form1.RibbonPageGroup6.Visible = False
            Form1.GridView1.OptionsSelection.MultiSelect = True
            System.GC.Collect()

            rOutput_1 = ""
            rOutput_2 = ""
            rOutput_3 = ""
            rOutput_4 = ""

            LoadErrorTable()
            DatabaseModule.CurrentDatabase = "Main"
            Form1.ToastNotificationsManager1.ShowNotification(Form1.ToastNotificationsManager1.Notifications(3))
            Form1.Timer1.Stop()
        End If

    End Sub

    Public Sub LoadErrorTable()
        On Error Resume Next

        Dim sqlite_cmd As SQLiteCommand
        sqlite_cmd = SQLiteConnectionString.CreateCommand()
        sqlite_cmd.CommandText = "SELECT * FROM Error_List_Table;"

        Dim sqlite_dataadapter As New SQLite.SQLiteDataAdapter
        sqlite_dataadapter.SelectCommand = sqlite_cmd
        Dim dt As New DataTable

        sqlite_dataadapter.Fill(dt)
        SQLiteConnectionString.Open()

        Form1.GridControl1.DataSource = dt
        SQLiteConnectionString.Close()

        DatabaseModule.CurrentDatabase = "Main"
    End Sub

End Module
