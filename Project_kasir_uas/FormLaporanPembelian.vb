Imports System.Data.Odbc
Public Class FormLaporanPembelian
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim ds As DataSet
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim MyDB As String
    Sub koneksi()
        MyDB = "Driver={MYSQL ODBC 8.0 Unicode Driver};Database=db_kasir;server=localhost;uid=root;password=123"
        conn = New OdbcConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
    Sub KondisiAwal()
        Call koneksi()
        da = New OdbcDataAdapter("Select * From viewbeli", conn)
        ds = New DataSet
        da.Fill(ds, "viewbeli")
        DataGridView1.DataSource = ds.Tables("viewbeli")
        DataGridView1.ReadOnly = True
        DataGridView1.Refresh()

    End Sub

    Private Sub FormLaporanPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call KondisiAwal()
    End Sub

End Class