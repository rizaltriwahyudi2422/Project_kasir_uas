Imports System.Data.Odbc
Public Class FormMenuUtama
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

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Sub Terkunci()
        Login.Visible = True
        Logout.Visible = False
        Master.Visible = False
        Transaksi.Visible = False
        Laporan.Visible = False
        Utility.Visible = False
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        End
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        FormLogin.Show()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Call Terkunci()
    End Sub

    Private Sub Kasir_Click(sender As Object, e As EventArgs) Handles Kasir.Click
        FormMasterKasir.Show()
    End Sub

    Private Sub Barang_Click(sender As Object, e As EventArgs) Handles Barang.Click
        FormMasterBarang.Show()
    End Sub

    Private Sub Suplier_Click(sender As Object, e As EventArgs) Handles Suplier.Click
        FormMasterSuplier.Show()
    End Sub

    Private Sub Pembelian_Click(sender As Object, e As EventArgs) Handles Pembelian.Click
        FormPembelian.Show()
    End Sub
End Class