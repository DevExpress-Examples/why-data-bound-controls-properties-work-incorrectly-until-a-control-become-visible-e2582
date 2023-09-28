Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Private _GridControl As GridControl

        Private _ShowSolution As Boolean

        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Number", GetType(Integer))
            tbl.Columns.Add("Date", GetType(Date))
            For i As Integer = 0 To RowCount - 1
                tbl.Rows.Add(New Object() {String.Format("Name{0}", i), i, 3 - i, Date.Now.AddDays(i)})
            Next

            Return tbl
        End Function

        Public Sub New(ByVal showSolution As Boolean)
            _ShowSolution = showSolution
            InitializeComponent()
            Dim tbl As DataTable = CreateTable(3)
            textBox1.DataBindings.Add("Text", tbl, "Name")
            textBox2.DataBindings.Add("Text", tbl, "Name")
            _GridControl = New GridControl()
            If showSolution Then
                _GridControl.BindingContext = New BindingContext()
            End If

            _GridControl.MainView = New GridView(_GridControl)
            _GridControl.DataSource = tbl
            _GridControl.Dock = DockStyle.Bottom
            _GridControl.Height = 200
        End Sub

        Private Sub timer1_Elapsed(ByVal sender As Object, ByVal e As Timers.ElapsedEventArgs)
            label1.Text = String.Format("textBox1.Text = {0}", textBox1.Text)
            label2.Text = String.Format("textBox1.Text = {0}", textBox2.Text)
            label3.Text = String.Format("gridView1.DataRowCount = {0}", TryCast(_GridControl.MainView, GridView).DataRowCount)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            panel2.Controls.Add(_GridControl)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            If _ShowSolution Then tabControl1.SelectedIndex = 1
            tabControl1.SelectedIndex = 0
        End Sub
    End Class
End Namespace
