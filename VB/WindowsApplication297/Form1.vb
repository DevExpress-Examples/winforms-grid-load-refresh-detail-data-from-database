Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Namespace WindowsApplication297
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Dim dt As New DataTable()
			LoadData(dt, "SELECT * FROM CUSTOMERS")
			gridControl1.DataSource = dt.DefaultView
		End Sub

		Private Function GetRowKey(ByVal view As ColumnView, ByVal rowHandle As Integer) As Object
			Return view.GetRowCellValue(rowHandle, "CustomerID")
		End Function

		Private Function GetDetailQuery(ByVal key As Object) As String
			Return String.Format("SELECT * FROM ORDERS WHERE CustomerID='{0}'", key)
		End Function

		Private cache As New Hashtable()

		Private connection As OleDbConnection

		Private Function LoadData(ByVal table As DataTable, ByVal query As String) As Integer
			If connection Is Nothing Then
				connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb;Persist Security Info=True")
			End If
			Dim adapter As New OleDbDataAdapter(query, connection)
			Try
				Dim num As Integer = adapter.Fill(table)
				textBox1.AppendText(String.Format("{0} data rows fetched" & Environment.NewLine, num))
				Return num
			Catch
				Return 0
			Finally
				adapter.Dispose()
			End Try
		End Function

		Private Function GetDetailData(ByVal view As ColumnView, ByVal rowHandle As Integer) As IList
			Dim key As Object = GetRowKey(view, rowHandle)
			Dim list As IList = TryCast(cache(key), IList)
			If list Is Nothing Then
				Dim dt As New DataTable()
				LoadData(dt, GetDetailQuery(key))
				list = dt.DefaultView
				cache(key) = list
			End If
			Return list
		End Function

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim view As ColumnView = CType(gridControl1.FocusedView, ColumnView)
			If (Not view.IsDetailView) Then
				Return
			End If

			Dim key As Object = GetRowKey(CType(view.ParentView, ColumnView), view.SourceRowHandle)
			Dim dv As DataView = TryCast(cache(key), DataView)
			If dv IsNot Nothing Then
				Dim dt As DataTable = dv.Table
				dt.Clear()
				LoadData(dt, GetDetailQuery(key))
			End If
		End Sub

		Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs) Handles gridView1.MasterRowEmpty
			e.IsEmpty = False
		End Sub

		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			e.ChildList = GetDetailData(CType(sender, ColumnView), e.RowHandle)
		End Sub

		Private Sub gridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs) Handles gridView1.MasterRowGetRelationCount
			e.RelationCount = 1
		End Sub

		Private Sub gridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs) Handles gridView1.MasterRowGetRelationName
			e.RelationName = "Details"
		End Sub
	End Class
End Namespace