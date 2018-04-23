using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace WindowsApplication297
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            LoadData(dt, "SELECT * FROM CUSTOMERS");
            gridControl1.DataSource = dt.DefaultView;
        }

        private object GetRowKey(ColumnView view, int rowHandle)
        {
            return view.GetRowCellValue(rowHandle, "CustomerID");
        }

        string GetDetailQuery(object key)
        {
            return string.Format("SELECT * FROM ORDERS WHERE CustomerID='{0}'", key);
        }

        Hashtable cache = new Hashtable();

        OleDbConnection connection;

        private int LoadData(DataTable table, string query)
        {
            if (connection == null)
            {
                connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb;Persist Security Info=True");
            }
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
            try
            {
                int num = adapter.Fill(table);
                textBox1.AppendText(string.Format("{0} data rows fetched" + Environment.NewLine, num));
                return num;
            }
            catch { return 0; }
            finally
            {
                adapter.Dispose();
            }
        }

        private IList GetDetailData(ColumnView view, int rowHandle)
        {
            object key = GetRowKey(view, rowHandle);
            IList list = cache[key] as IList;
            if (list == null)
            {
                DataTable dt = new DataTable();
                LoadData(dt, GetDetailQuery(key));
                list = dt.DefaultView;
                cache[key] = list;
            }
            return list;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ColumnView view = (ColumnView)gridControl1.FocusedView;
            if (!view.IsDetailView) return;

            object key = GetRowKey((ColumnView)view.ParentView, view.SourceRowHandle);
            DataView dv = cache[key] as DataView;
            if (dv != null)
            {
                DataTable dt = dv.Table;
                dt.Clear();
                LoadData(dt, GetDetailQuery(key));
            }
        }

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            e.ChildList = GetDetailData((ColumnView)sender, e.RowHandle);
        }

        private void gridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Details";
        }
    }
}