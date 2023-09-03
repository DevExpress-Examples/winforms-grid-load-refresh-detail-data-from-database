Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication297

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim dt As DataTable = New DataTable()
            LoadData(dt, "SELECT * FROM CUSTOMERS")
            gridControl1.DataSource = dt.DefaultView
        End Sub

        Private Function GetRowKey(ByVal view As ColumnView, ByVal rowHandle As Integer) As Object
            Return view.GetRowCellValue(rowHandle, "CustomerID")
        End Function

        Private Function GetDetailQuery(ByVal key As Object) As String
            Return String.Format("SELECT * FROM ORDERS WHERE CustomerID='{0}'", key)
        End Function

        Private cache As Dictionary(Of Object, IList) = New Dictionary(Of Object, IList)()

        Private Function LoadData(ByVal table As DataTable, ByVal query As String) As Integer
            Using connection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb;Persist Security Info=True")
                Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(query, connection)
                Try
                    Dim num As Integer = adapter.Fill(table)
                    textBox1.AppendText(String.Format("{0} data rows fetched" & Environment.NewLine, num))
                    Return num
                Catch
                    Return 0
                Finally
                    adapter.Dispose()
                End Try
            End Using
        End Function

        Private Function GetDetailData(ByVal view As ColumnView, ByVal rowHandle As Integer) As IList
            Dim key As Object = GetRowKey(view, rowHandle)
            If Not cache.ContainsKey(key) Then
                Dim dt As DataTable = New DataTable()
                LoadData(dt, GetDetailQuery(key))
                cache(key) = dt.DefaultView
            End If

            Return cache(key)
        End Function

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim view As ColumnView = CType(gridControl1.FocusedView, ColumnView)
            If Not view.IsDetailView Then Return
            Dim key As Object = GetRowKey(CType(view.ParentView, ColumnView), view.SourceRowHandle)
            Dim dv As DataView = TryCast(cache(key), DataView)
            If dv IsNot Nothing Then
                Dim dt As DataTable = dv.Table
                dt.Clear()
                LoadData(dt, GetDetailQuery(key))
            End If
        End Sub

        Private Sub gridView1_MasterRowEmpty(ByVal sender As Object, ByVal e As MasterRowEmptyEventArgs)
            e.IsEmpty = False
        End Sub

        Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As MasterRowGetChildListEventArgs)
            e.ChildList = GetDetailData(CType(sender, ColumnView), e.RowHandle)
        End Sub

        Private Sub gridView1_MasterRowGetRelationCount(ByVal sender As Object, ByVal e As MasterRowGetRelationCountEventArgs)
            e.RelationCount = 1
        End Sub

        Private Sub gridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs)
            e.RelationName = "Details"
        End Sub
    End Class
End Namespace
