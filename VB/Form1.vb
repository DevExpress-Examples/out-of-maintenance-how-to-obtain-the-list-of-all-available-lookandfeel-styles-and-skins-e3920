Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Skins

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			For Each  style As Object In System.Enum.GetValues(GetType(LookAndFeelStyle))
				rgStyles.Properties.Items.Add(New RadioGroupItem(style, style.ToString()))
			Next style
			For Each item As SkinContainer In SkinManager.Default.Skins
				rgSkins.Properties.Items.Add(New RadioGroupItem(item.SkinName, item.SkinName))
			Next item
		End Sub

		Private Sub rgStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgStyles.SelectedIndexChanged
			UserLookAndFeel.Default.Style = CType(rgStyles.EditValue, LookAndFeelStyle)
		End Sub

		Private Sub rgSkins_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgSkins.EditValueChanged
			UserLookAndFeel.Default.SkinName = rgSkins.EditValue.ToString()
			rgStyles.EditValue = LookAndFeelStyle.Skin

		End Sub


	End Class
End Namespace
