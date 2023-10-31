Imports System.ComponentModel
Imports System.Text
Imports System.Data.SQLite
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Utils.Extensions
Imports System.Threading
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraPrinting.Native.Extensions
Imports System.GC

Partial Public Class Form1
    Class CustomOverlayPainter
        Inherits OverlayWindowPainterBase
        'Defines the string’s font.
        Shared ReadOnly drawFont As Font
        Shared Sub New()
            drawFont = New Font("Microsoft YaHei", 14)
        End Sub
        Protected Overrides Sub Draw(context As OverlayWindowCustomDrawContext)
            'The Handled event parameter should be set to true  
            'to disable the default drawing algorithm.
            context.Handled = True
            'Provides access to the drawing surface. 
            Dim cache As GraphicsCache = context.DrawArgs.Cache
            'Adjust the TextRenderingHint option 
            'to improve the image quality. 
            cache.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
            'Overlapped control bounds.
            Dim bounds As Rectangle = context.DrawArgs.Bounds
            'Draws the default background.  
            context.DrawBackground()
            'Create the string to draw. 
            Dim drawString As String = AnalysisModule.Percentege.ToString()
            'Get the system black brush. 
            Dim drawBrush As Brush = Brushes.RoyalBlue
            'Calculate the size of the message string. 
            Dim textSize As SizeF = cache.CalcTextSize(drawString, drawFont)
            'A point that specifies the upper-left corner of the rectangle where the string should be drawn.
            Dim drawPoint As PointF = New PointF(bounds.Left + bounds.Width / 2 - textSize.Width / 2, bounds.Top + bounds.Height / 2 - textSize.Height / 2)
            'Draw the string on the screen.
            cache.DrawString(drawString, drawFont, drawBrush, drawPoint)
        End Sub
    End Class

    Public Handle As IOverlaySplashScreenHandle = Nothing
    Public Handle2 As IOverlaySplashScreenHandle = Nothing
    Public ListboxItemsCount As Integer = 0
    Public Function ShowProgressPanel() As IOverlaySplashScreenHandle
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me, customPainter:=New CustomOverlayPainter())
        Return handle
    End Function
    Public Function ShowProgressPanel2() As IOverlaySplashScreenHandle
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Return handle
    End Function
    Public Sub CloseProgressPanel2(ByVal handle As IOverlaySplashScreenHandle)
        If handle IsNot Nothing Then SplashScreenManager.CloseOverlayForm(handle)
    End Sub
    Public Sub CloseProgressPanel(ByVal handle As IOverlaySplashScreenHandle)
        If handle IsNot Nothing Then SplashScreenManager.CloseOverlayForm(handle)
    End Sub

    Public Sub New()
        InitializeComponent()
        If (Not MvvmContext1.IsDesignMode) Then
            InitializeBindings()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        AnalysisModule.LoadErrorTable()
        DatabaseModule.CurrentDatabase = "Main"
        SettingsModule.LoadAnalysisCheckState()
        SettingsModule.FastScanMode = System.IO.File.ReadAllText("C:\SWQA Log Viewer Ultimate 2\Settings\FastScanMode.txt")
        SettingsModule.FastScanModeCheckModule()
        System.Diagnostics.Process.GetCurrentProcess().PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime
        System.GC.Collect()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        On Error Resume Next

        If (XtraOpenFileDialog1.ShowDialog = DialogResult.OK) Then
            RibbonPageGroup2.Visible = True

            ListBoxControl1.Items.Clear()
            ListBoxControl2.Items.Clear()

            ListBoxControl1.Items.AddRange(XtraOpenFileDialog1.FileNames)
            ListBoxControl2.Items.AddRange(XtraOpenFileDialog1.SafeFileNames)
            ListboxItemsCount = ListBoxControl1.ItemCount

            ListBoxControl1.SelectedIndex = 0
            ListBoxControl2.SelectedIndex = 0

            FileButton1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            FileButton2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            FileButton3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            FileButton4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            Handle = ShowProgressPanel2()

            If (ListboxItemsCount = 1) Then
                rOutput_1 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
            ElseIf (ListboxItemsCount = 2) Then
                rOutput_1 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
                ListBoxControl1.SelectedIndex = 1
                rOutput_2 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
            ElseIf (ListboxItemsCount = 3) Then
                rOutput_1 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
                ListBoxControl1.SelectedIndex = 1
                rOutput_2 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
                ListBoxControl1.SelectedIndex = 2
                rOutput_3 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
            ElseIf (ListboxItemsCount = 4) Then
                rOutput_1 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
                ListBoxControl1.SelectedIndex = 1
                rOutput_2 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
                ListBoxControl1.SelectedIndex = 2
                rOutput_3 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
                ListBoxControl1.SelectedIndex = 3
                rOutput_4 = System.IO.File.ReadAllText(ListBoxControl1.SelectedItem.ToString())
            End If
            CloseProgressPanel(Handle)
        Else
            'Nothing
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        AnalysisModule.Analysis()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        On Error Resume Next

        ListBoxControl1.Items.Clear()
        ListBoxControl2.Items.Clear()

        ListBoxControl1.Items.AddRange(XtraOpenFileDialog1.FileNames)
        ListBoxControl2.Items.AddRange(XtraOpenFileDialog1.SafeFileNames)
        ListboxItemsCount = ListBoxControl1.ItemCount

        ListBoxControl1.SelectedIndex = 0
        ListBoxControl2.SelectedIndex = 0

        ListBoxControl1.SelectedIndex = 0
        ListBoxControl2.SelectedIndex = 0
        AnalysisModule.ErrorTableCount = 0
        AnalysisModule.DeleteAllLogErrorTable()
        GridView1.OptionsSelection.MultiSelect = False
        TableSelectionForm.ComboBoxEdit1.Properties.Items.Clear()
        AnalysisModule.Analysis_Check_Favourites()
    End Sub

    Private Sub GridView1_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        On Error Resume Next

        If (DatabaseModule.CurrentDatabase = "Main") Then
            If (GridView1.SelectedRowsCount < 1) Then
                RibbonPageGroup6.Visible = False
                RibbonPageGroup4.Visible = False
            Else
                RibbonPageGroup6.Visible = True
                RibbonPageGroup4.Visible = True
            End If
        Else
            If (GridView1.SelectedRowsCount < 1) Then
                RibbonPageGroup6.Visible = False
            Else
                RibbonPageGroup6.Visible = True
            End If
            RibbonPageGroup4.Visible = False
        End If
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        On Error Resume Next
        AddTableErrorForm.ShowDialog()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        On Error Resume Next
        AddErrorForm.ShowDialog()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        On Error Resume Next
        DatabaseModule.DeleteSelectedErrors()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        On Error Resume Next
        AnalysisModule.LoadFavouritesList_1()
        RibbonPageGroup9.Visible = False
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        On Error Resume Next
        AnalysisModule.LoadFavouritesList_2()
        RibbonPageGroup9.Visible = False
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        On Error Resume Next
        AnalysisModule.LoadFavouritesList_3()
        RibbonPageGroup9.Visible = False
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        On Error Resume Next
        AnalysisModule.LoadErrorTable()
        RibbonPageGroup9.Visible = True
    End Sub

    Sub InitializeBindings()
        Dim fluent = MvvmContext1.OfType(Of Form1ViewModel)()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        On Error Resume Next
        SettingsForm.ShowDialog()
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        On Error Resume Next
        AboutForm.ShowDialog()
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        On Error Resume Next
        DatabaseModule.SyncOnlineDatabase()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        On Error Resume Next

        If (XtraOpenFileDialog1.ShowDialog = DialogResult.OK) Then
            GridView1.SelectAll()
            Handle = ShowProgressPanel()
            Handle2 = ShowProgressPanel2()

            ListBoxControl1.Items.Clear()
            ListBoxControl2.Items.Clear()

            ListBoxControl1.Items.AddRange(XtraOpenFileDialog1.FileNames)
            ListBoxControl2.Items.AddRange(XtraOpenFileDialog1.SafeFileNames)
            ListboxItemsCount = ListBoxControl1.ItemCount

            ListBoxControl1.SelectedIndex = 0
            ListBoxControl2.SelectedIndex = 0

            ListBoxControl1.SelectedIndex = 0
            ListBoxControl2.SelectedIndex = 0

            AnalysisModule.LargeScanModule()
        Else
            'Nothing
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        AnalysisModule.LargeScanModule()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        e.Cancel = False
        Dim directoryName As String = "C:\SWQA Log Viewer Ultimate 2\LF_Output\"
        For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
            File.Delete(deleteFile)
        Next
        Application.Exit()
    End Sub
End Class