Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
			Me.rgSkins = New DevExpress.XtraEditors.RadioGroup()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.rgStyles = New DevExpress.XtraEditors.RadioGroup()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			Me.xtraScrollableControl1.SuspendLayout()
			CType(Me.rgSkins.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.rgStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 22)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(502, 407)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2, Me.bar3})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barStaticItem1})
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 3
			Me.barManager1.StatusBar = Me.bar3
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "File"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "Options"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1)})
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Caption = "Some text"
			Me.barStaticItem1.Id = 2
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(702, 22)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 429)
			Me.barDockControlBottom.Size = New System.Drawing.Size(702, 25)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(702, 22)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.groupControl3)
			Me.groupControl1.Controls.Add(Me.groupControl2)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Right
			Me.groupControl1.Location = New System.Drawing.Point(502, 22)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(200, 407)
			Me.groupControl1.TabIndex = 5
			Me.groupControl1.Text = "Appliation LookAndFeel"
			' 
			' groupControl3
			' 
			Me.groupControl3.Controls.Add(Me.xtraScrollableControl1)
			Me.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl3.Location = New System.Drawing.Point(2, 209)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(196, 196)
			Me.groupControl3.TabIndex = 7
			Me.groupControl3.Text = "Skin name"
			' 
			' xtraScrollableControl1
			' 
			Me.xtraScrollableControl1.Controls.Add(Me.rgSkins)
			Me.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraScrollableControl1.Location = New System.Drawing.Point(2, 21)
			Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
			Me.xtraScrollableControl1.Size = New System.Drawing.Size(192, 173)
			Me.xtraScrollableControl1.TabIndex = 0
			' 
			' rgSkins
			' 
			Me.rgSkins.Dock = System.Windows.Forms.DockStyle.Top
			Me.rgSkins.Location = New System.Drawing.Point(0, 0)
			Me.rgSkins.MenuManager = Me.barManager1
			Me.rgSkins.Name = "rgSkins"
			Me.rgSkins.Properties.Columns = 1
			Me.rgSkins.Size = New System.Drawing.Size(175, 900)
			Me.rgSkins.TabIndex = 2
'			Me.rgSkins.EditValueChanged += New System.EventHandler(Me.rgSkins_SelectedIndexChanged);
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.rgStyles)
			Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Top
			Me.groupControl2.Location = New System.Drawing.Point(2, 21)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(196, 188)
			Me.groupControl2.TabIndex = 6
			Me.groupControl2.Text = "Style"
			' 
			' rgStyles
			' 
			Me.rgStyles.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rgStyles.Location = New System.Drawing.Point(2, 21)
			Me.rgStyles.MenuManager = Me.barManager1
			Me.rgStyles.Name = "rgStyles"
			Me.rgStyles.Size = New System.Drawing.Size(192, 165)
			Me.rgStyles.TabIndex = 0
'			Me.rgStyles.SelectedIndexChanged += New System.EventHandler(Me.rgStyles_SelectedIndexChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(702, 454)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.groupControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			Me.xtraScrollableControl1.ResumeLayout(False)
			CType(Me.rgSkins.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.rgStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar2 As DevExpress.XtraBars.Bar
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private bar3 As DevExpress.XtraBars.Bar
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private WithEvents rgStyles As DevExpress.XtraEditors.RadioGroup
		Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
		Private WithEvents rgSkins As DevExpress.XtraEditors.RadioGroup
	End Class
End Namespace

