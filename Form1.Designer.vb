Partial Public Class Form1
    Inherits DevExpress.XtraEditors.DirectXForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.RegexReadAllTextProject.SplashScreen1), True, True, True)
        Me.DirectXFormContainerControl1 = New DevExpress.XtraEditors.DirectXFormContainerControl()
        Me.ListBoxControl2 = New DevExpress.XtraEditors.ListBoxControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Column_Count = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.FileButton1 = New DevExpress.XtraBars.BarButtonItem()
        Me.FileButton2 = New DevExpress.XtraBars.BarButtonItem()
        Me.FileButton3 = New DevExpress.XtraBars.BarButtonItem()
        Me.FileButton4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPageCategory2 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Column_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Column_Error_Name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraOpenFileDialog1 = New DevExpress.XtraEditors.XtraOpenFileDialog(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.RegexReadAllTextProject.WaitForm1), True, True, True)
        Me.ToastNotificationsManager1 = New DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MvvmContext1 = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.SkinPaletteDropDownButtonItem1 = New DevExpress.XtraBars.SkinPaletteDropDownButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ThreadCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.DirectXFormContainerControl1.SuspendLayout()
        CType(Me.ListBoxControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToastNotificationsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MvvmContext1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager2
        '
        SplashScreenManager2.ClosingDelay = 1500
        '
        'DirectXFormContainerControl1
        '
        Me.DirectXFormContainerControl1.Controls.Add(Me.ListBoxControl2)
        Me.DirectXFormContainerControl1.Controls.Add(Me.GridControl3)
        Me.DirectXFormContainerControl1.Controls.Add(Me.ListBoxControl1)
        Me.DirectXFormContainerControl1.Controls.Add(Me.RibbonControl1)
        Me.DirectXFormContainerControl1.Controls.Add(Me.GridControl1)
        Me.DirectXFormContainerControl1.Location = New System.Drawing.Point(1, 33)
        Me.DirectXFormContainerControl1.Name = "DirectXFormContainerControl1"
        Me.DirectXFormContainerControl1.Size = New System.Drawing.Size(512, 643)
        Me.DirectXFormContainerControl1.TabIndex = 0
        '
        'ListBoxControl2
        '
        Me.ListBoxControl2.Location = New System.Drawing.Point(392, 466)
        Me.ListBoxControl2.Name = "ListBoxControl2"
        Me.ListBoxControl2.Size = New System.Drawing.Size(109, 110)
        Me.ListBoxControl2.TabIndex = 7
        Me.ListBoxControl2.Visible = False
        '
        'GridControl3
        '
        Me.GridControl3.Location = New System.Drawing.Point(392, 250)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.MenuManager = Me.RibbonControl1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(109, 106)
        Me.GridControl3.TabIndex = 5
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        Me.GridControl3.Visible = False
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.Column_Count})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "HATALAR"
        Me.GridColumn2.FieldName = "Error_Name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'Column_Count
        '
        Me.Column_Count.Caption = "Hata Adeti"
        Me.Column_Count.FieldName = "Count"
        Me.Column_Count.Name = "Column_Count"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.AutoSizeItems = True
        Me.RibbonControl1.ButtonGroupsVertAlign = DevExpress.Utils.VertAlignment.Center
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.FileButton1, Me.FileButton2, Me.FileButton3, Me.FileButton4, Me.BarButtonItem11, Me.BarButtonItem13, Me.BarButtonItem14})
        Me.RibbonControl1.ItemsVertAlign = DevExpress.Utils.VertAlignment.Center
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 550)
        Me.RibbonControl1.MaxItemId = 18
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.OptionsStubGlyphs.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonControl1.OptionsStubGlyphs.UseFont = True
        Me.RibbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.RibbonPageCategory1, Me.RibbonPageCategory2})
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage2})
        Me.RibbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(512, 82)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Dosya Ekle"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.folder128
        Me.BarButtonItem1.ImageOptions.LargeImage = Global.RegexReadAllTextProject.My.Resources.Resources.folder128
        Me.BarButtonItem1.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Analize Başla"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.AllowRightClickInMenu = False
        Me.BarButtonItem3.Caption = "Analizi Başlat"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.analytics128
        Me.BarButtonItem3.ImageOptions.LargeImage = Global.RegexReadAllTextProject.My.Resources.Resources.analytics128
        Me.BarButtonItem3.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.AllowRightClickInMenu = False
        Me.BarButtonItem4.Caption = "Seçili Verileri Ayır"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.check128
        Me.BarButtonItem4.ImageOptions.LargeImage = Global.RegexReadAllTextProject.My.Resources.Resources.check1281
        Me.BarButtonItem4.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Hata Ekle"
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.add128
        Me.BarButtonItem5.ImageOptions.LargeImage = Global.RegexReadAllTextProject.My.Resources.Resources.add128
        Me.BarButtonItem5.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.AllowRightClickInMenu = False
        Me.BarButtonItem6.Caption = "Seçili Verileri Sil"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.bin128
        Me.BarButtonItem6.ImageOptions.LargeImage = Global.RegexReadAllTextProject.My.Resources.Resources.bin128
        Me.BarButtonItem6.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Favori Listesi 1"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.rate24
        Me.BarButtonItem7.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Favori Listesi 2"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.rate24
        Me.BarButtonItem8.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Favori Listesi 3"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.rate24
        Me.BarButtonItem9.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Ana Liste"
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.home24
        Me.BarButtonItem10.ItemAppearance.Hovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Hovered.Options.UseFont = True
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'FileButton1
        '
        Me.FileButton1.Caption = "File_1"
        Me.FileButton1.Id = 11
        Me.FileButton1.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.doc24
        Me.FileButton1.Name = "FileButton1"
        Me.FileButton1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'FileButton2
        '
        Me.FileButton2.Caption = "File_2"
        Me.FileButton2.Id = 12
        Me.FileButton2.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.doc24
        Me.FileButton2.Name = "FileButton2"
        Me.FileButton2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'FileButton3
        '
        Me.FileButton3.Caption = "File_3"
        Me.FileButton3.Id = 13
        Me.FileButton3.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.doc24
        Me.FileButton3.Name = "FileButton3"
        Me.FileButton3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'FileButton4
        '
        Me.FileButton4.Caption = "File_4"
        Me.FileButton4.Id = 14
        Me.FileButton4.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.doc24
        Me.FileButton4.Name = "FileButton4"
        Me.FileButton4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Ayarlar"
        Me.BarButtonItem11.Id = 15
        Me.BarButtonItem11.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.setting24
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Ana Listeyi Senkronize Et"
        Me.BarButtonItem13.Id = 16
        Me.BarButtonItem13.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.loop512
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "LF Analizi"
        Me.BarButtonItem14.Id = 17
        Me.BarButtonItem14.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.largefile512
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Text = "RibbonPageCategory1"
        '
        'RibbonPageCategory2
        '
        Me.RibbonPageCategory2.Name = "RibbonPageCategory2"
        Me.RibbonPageCategory2.Text = "RibbonPageCategory2"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage1.Appearance.Options.UseFont = True
        Me.RibbonPage1.AppearanceHovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage1.AppearanceHovered.Options.UseFont = True
        Me.RibbonPage1.AppearanceSelected.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage1.AppearanceSelected.Options.UseFont = True
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup10})
        Me.RibbonPage1.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.danalysis24
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Analiz Sayfası"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Visible = False
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.BarButtonItem14)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.Text = "RibbonPageGroup10"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage3.Appearance.Options.UseFont = True
        Me.RibbonPage3.AppearanceHovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage3.AppearanceHovered.Options.UseFont = True
        Me.RibbonPage3.AppearanceSelected.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage3.AppearanceSelected.Options.UseFont = True
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup5, Me.RibbonPageGroup6, Me.RibbonPageGroup9})
        Me.RibbonPage3.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.database24
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Veri"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Visible = False
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Visible = False
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem13)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.Text = "RibbonPageGroup9"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage4.Appearance.Options.UseFont = True
        Me.RibbonPage4.AppearanceHovered.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage4.AppearanceHovered.Options.UseFont = True
        Me.RibbonPage4.AppearanceSelected.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.RibbonPage4.AppearanceSelected.Options.UseFont = True
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7, Me.RibbonPageGroup8})
        Me.RibbonPage4.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.rate24
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Favori Listeleri"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.Text = "RibbonPageGroup7"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.Text = "RibbonPageGroup8"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage2.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.setting24
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Ayarlar"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem11)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.Location = New System.Drawing.Point(392, 362)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(109, 98)
        Me.ListBoxControl1.TabIndex = 3
        Me.ListBoxControl1.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(512, 544)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Column_ID, Me.Column_Error_Name})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplandırmak için sürükleyiniz..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindDelay = 250
        Me.GridView1.OptionsFind.FindNullPrompt = "Herhangi bir kelimeyi arayınız..."
        Me.GridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel
        Me.GridView1.OptionsFind.ParserKind = DevExpress.Data.Filtering.FindPanelParserKind.Mixed
        Me.GridView1.OptionsFind.SearchInPreview = True
        Me.GridView1.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.GridView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'Column_ID
        '
        Me.Column_ID.Caption = "GridColumn1"
        Me.Column_ID.FieldName = "id"
        Me.Column_ID.Name = "Column_ID"
        '
        'Column_Error_Name
        '
        Me.Column_Error_Name.AppearanceCell.Options.UseTextOptions = True
        Me.Column_Error_Name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Column_Error_Name.AppearanceHeader.Options.UseTextOptions = True
        Me.Column_Error_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Column_Error_Name.Caption = "HATA ADI"
        Me.Column_Error_Name.FieldName = "Error_Name"
        Me.Column_Error_Name.Name = "Column_Error_Name"
        Me.Column_Error_Name.OptionsColumn.AllowEdit = False
        Me.Column_Error_Name.OptionsColumn.AllowIncrementalSearch = False
        Me.Column_Error_Name.OptionsColumn.AllowMove = False
        Me.Column_Error_Name.OptionsColumn.AllowShowHide = False
        Me.Column_Error_Name.OptionsFilter.AllowAutoFilter = False
        Me.Column_Error_Name.OptionsFilter.AllowFilter = False
        Me.Column_Error_Name.Visible = True
        Me.Column_Error_Name.VisibleIndex = 1
        '
        'XtraOpenFileDialog1
        '
        Me.XtraOpenFileDialog1.Filter = "Metin Formatı|*.txt|LOG Formatı|*.log|Tüm Dosyalar|*.*"
        Me.XtraOpenFileDialog1.FilterIndex = 2
        Me.XtraOpenFileDialog1.Multiselect = True
        Me.XtraOpenFileDialog1.ShowDragDropConfirmation = True
        Me.XtraOpenFileDialog1.Title = "Dosya Gezgini"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'ToastNotificationsManager1
        '
        Me.ToastNotificationsManager1.ApplicationId = " "
        Me.ToastNotificationsManager1.Notifications.AddRange(New DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties() {New DevExpress.XtraBars.ToastNotifications.ToastNotification("078df40a-e1a1-4a69-aee8-e3666029cd6d", Nothing, "SWQA Log Viewer Ultimate 2", "Logcat dosyaları analiz ediliyor...", "Analiz bittiğinde bildirim gönderilecektir.", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.IM, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.[Long], DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text03), New DevExpress.XtraBars.ToastNotifications.ToastNotification("49f36f19-6889-4824-beca-4cf6b98e5130", Nothing, "Kayıt Hatası", "Eklenilen hata zaten sistemde mevcuttur.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text03), New DevExpress.XtraBars.ToastNotifications.ToastNotification("9ee5f5fe-ad8b-4582-997f-d81e7fc36948", Nothing, "Kayıt Başarılı", "Belirtilen kayıt sisteme başarıyla eklenmiştir.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text03), New DevExpress.XtraBars.ToastNotifications.ToastNotification("23cde94a-93a9-4fdd-b12f-a7a2f6b4ef0c", Nothing, "SWQA Log Viewer Ultimate 2", "Analiz tamamlanmıştır.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text03), New DevExpress.XtraBars.ToastNotifications.ToastNotification("52ff76cd-4bc8-4f78-aa52-437271cc238a", Nothing, "SWQA Log Viewer Ultimate 2", "Senkronizasyon işlemi başlatıldı.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text03), New DevExpress.XtraBars.ToastNotifications.ToastNotification("638da936-3d89-4637-b0db-9d18e177a9e6", Nothing, "SWQA Log Viewer Ultimate 2", "Senkronizasyon işlemi tamamlandı.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text03), New DevExpress.XtraBars.ToastNotifications.ToastNotification("f093d0af-7fa2-4598-8f07-70ee25c76614", Nothing, "SWQA Log Viewer Ultimate 2", "Hata adı girilmelidir.", "", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text03)})
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'MvvmContext1
        '
        Me.MvvmContext1.ContainerControl = Me
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.SkinBarSubItem1.Caption = "SkinBarSubItem1"
        Me.SkinBarSubItem1.Id = 0
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'SkinPaletteDropDownButtonItem1
        '
        Me.SkinPaletteDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.SkinPaletteDropDownButtonItem1.Id = 1
        Me.SkinPaletteDropDownButtonItem1.Name = "SkinPaletteDropDownButtonItem1"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarButtonItem12.Caption = "Hakkında"
        Me.BarButtonItem12.Description = "Hakkında"
        Me.BarButtonItem12.Hint = "Hakkında"
        Me.BarButtonItem12.Id = 0
        Me.BarButtonItem12.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.info2_24
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'Timer2
        '
        '
        'ThreadCheckTimer
        '
        Me.ThreadCheckTimer.Interval = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ChildControls.Add(Me.DirectXFormContainerControl1)
        Me.ClientSize = New System.Drawing.Size(514, 677)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.LogViewer2UFormIcon
        Me.Links.Add(Me.BarButtonItem12)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Viewer Ultimate 2"
        Me.DirectXFormContainerControl1.ResumeLayout(False)
        Me.DirectXFormContainerControl1.PerformLayout()
        CType(Me.ListBoxControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToastNotificationsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MvvmContext1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DirectXFormContainerControl1 As DevExpress.XtraEditors.DirectXFormContainerControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraOpenFileDialog1 As DevExpress.XtraEditors.XtraOpenFileDialog
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Column_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Column_Error_Name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents ToastNotificationsManager1 As DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GD2_Column_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GD2_Column_Text As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListBoxControl2 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents RibbonPageCategory2 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents FileButton1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FileButton2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FileButton3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FileButton4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents MvvmContext1 As DevExpress.Utils.MVVM.MVVMContext
    Friend WithEvents SkinPaletteDropDownButtonItem1 As DevExpress.XtraBars.SkinPaletteDropDownButtonItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Column_Count As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ThreadCheckTimer As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker

#End Region

End Class
