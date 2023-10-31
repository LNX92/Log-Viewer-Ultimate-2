<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits DevExpress.XtraEditors.DirectXForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.DirectXFormContainerControl1 = New DevExpress.XtraEditors.DirectXFormContainerControl()
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.AccordionContentContainer1 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.ToggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.AccordionContentContainer2 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ToggleSwitch2 = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.DirectXFormContainerControl1.SuspendLayout()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionControl1.SuspendLayout()
        Me.AccordionContentContainer1.SuspendLayout()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccordionContentContainer2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ToggleSwitch2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DirectXFormContainerControl1
        '
        Me.DirectXFormContainerControl1.Controls.Add(Me.AccordionControl1)
        Me.DirectXFormContainerControl1.Location = New System.Drawing.Point(1, 33)
        Me.DirectXFormContainerControl1.Name = "DirectXFormContainerControl1"
        Me.DirectXFormContainerControl1.Size = New System.Drawing.Size(409, 499)
        Me.DirectXFormContainerControl1.TabIndex = 0
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer1)
        Me.AccordionControl1.Controls.Add(Me.AccordionContentContainer2)
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement1})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 0)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.Size = New System.Drawing.Size(409, 499)
        Me.AccordionControl1.TabIndex = 0
        '
        'AccordionContentContainer1
        '
        Me.AccordionContentContainer1.Controls.Add(Me.PanelControl2)
        Me.AccordionContentContainer1.Name = "AccordionContentContainer1"
        Me.AccordionContentContainer1.Size = New System.Drawing.Size(360, 181)
        Me.AccordionContentContainer1.TabIndex = 1
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.Location = New System.Drawing.Point(95, 15)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ToggleSwitch1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.ToggleSwitch1.Properties.OffText = "Basit Tarama"
        Me.ToggleSwitch1.Properties.OnText = "Gelişmiş Tarama"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(150, 24)
        Me.ToggleSwitch1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(5, 57)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(331, 117)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        '
        'AccordionContentContainer2
        '
        Me.AccordionContentContainer2.Controls.Add(Me.PanelControl1)
        Me.AccordionContentContainer2.Name = "AccordionContentContainer2"
        Me.AccordionContentContainer2.Size = New System.Drawing.Size(360, 61)
        Me.AccordionContentContainer2.TabIndex = 3
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.ToggleSwitch2)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 3)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(341, 51)
        Me.PanelControl1.TabIndex = 0
        '
        'ToggleSwitch2
        '
        Me.ToggleSwitch2.Location = New System.Drawing.Point(224, 14)
        Me.ToggleSwitch2.Name = "ToggleSwitch2"
        Me.ToggleSwitch2.Properties.AllowFocused = False
        Me.ToggleSwitch2.Properties.OffText = "Pasif"
        Me.ToggleSwitch2.Properties.OnText = "Aktif"
        Me.ToggleSwitch2.Size = New System.Drawing.Size(95, 24)
        Me.ToggleSwitch2.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(15, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(177, 41)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Analizlerde hızlı taramayı erkinleştirir."
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement2, Me.AccordionControlElement3})
        Me.AccordionControlElement1.ImageOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.ssearch16
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Analiz Ayarları"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.ContentContainer = Me.AccordionContentContainer1
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "Analiz Biçimi"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.ContentContainer = Me.AccordionContentContainer2
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement3.Text = "Hızlı Tarama"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.ToggleSwitch1)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Location = New System.Drawing.Point(7, 3)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(341, 171)
        Me.PanelControl2.TabIndex = 2
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ChildControls.Add(Me.DirectXFormContainerControl1)
        Me.ClientSize = New System.Drawing.Size(411, 533)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = Global.RegexReadAllTextProject.My.Resources.Resources.setting24
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ayarlar"
        Me.DirectXFormContainerControl1.ResumeLayout(False)
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionControl1.ResumeLayout(False)
        Me.AccordionContentContainer1.ResumeLayout(False)
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccordionContentContainer2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.ToggleSwitch2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DirectXFormContainerControl1 As DevExpress.XtraEditors.DirectXFormContainerControl
    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionContentContainer1 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents ToggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents AccordionContentContainer2 As DevExpress.XtraBars.Navigation.AccordionContentContainer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ToggleSwitch2 As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
