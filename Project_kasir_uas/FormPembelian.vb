Imports System.Data.Odbc
Public Class FormPembelian
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
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(0).Value =
                UCase(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Call koneksi()
            cmd = New OdbcCommand(" Select * t_barang where id_barang='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = dr.Item("NamaBarang")
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = dr.Item("Harga")
                DataGridView1.Rows(e.RowIndex).Cells(3).Value = 0
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = dr.Item("Stok")
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = 0
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0
            Else
                MsgBox("Maaf, Data Barang Tidak ditemukan!", MsgBoxStyle.Exclamation, "Peringatan")
                DataGridView1.Focus()
            End If
        End If
    End Sub
End Class