using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {


        private GridControl _GridControl;
        private bool _ShowSolution;

            DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }
        

        public Form1(bool showSolution)
        {
            _ShowSolution = showSolution;
            InitializeComponent();
            DataTable tbl = CreateTable(3);
            textBox1.DataBindings.Add("Text", tbl, "Name");
            textBox2.DataBindings.Add("Text", tbl, "Name");
            _GridControl =  new GridControl();
            if (showSolution)
            {
                _GridControl.BindingContext = new BindingContext();
            }
            _GridControl.MainView = new GridView(_GridControl);
            _GridControl.DataSource = tbl;
            _GridControl.Dock = DockStyle.Bottom; 
            _GridControl.Height = 200;

        }


        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            label1.Text = String.Format("textBox1.Text = {0}", textBox1.Text);
            label2.Text = String.Format("textBox1.Text = {0}", textBox2.Text);
            label3.Text = String.Format("gridView1.DataRowCount = {0}", (_GridControl.MainView as GridView).DataRowCount);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Add(_GridControl);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_ShowSolution)
                tabControl1.SelectedIndex = 1;
            tabControl1.SelectedIndex = 0;
        }

    }
}