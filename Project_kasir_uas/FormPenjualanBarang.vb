Imports System.Data.Odbc
Public Class FormPenjualanBarang
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
    Sub ClearForm()
        NoFaktur.Text = ""
        LabelTgl.Text = ""
        LabelNamaKasir.Text = ""
        LabelTotalItem.Text = ""
        LabelTotalBayar.Text = ""
        KodeKasir.Text = ""
        DataGridView1.Rows.Clear()
    End Sub
    Sub hitungItem()
        Dim cari As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            cari = cari + DataGridView1.Rows(i).Cells(3).Value
            LabelTotalItem.Text = cari
        Next
    End Sub
    Sub hitungTotal()
        Dim cari As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            cari = cari + DataGridView1.Rows(i).Cells(6).Value
            LabelTotalBayar.Text = cari
        Next
    End Sub
    Sub GetNamaKasir()
        Call koneksi()
        cmd = New OdbcCommand("select nama_kasir from t_kasir where id_kasir = '" & KodeKasir.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            LabelNamaKasir.Text = dr.Item(0)
        End If
    End Sub
    Sub IdKasir()
        Call koneksi()
        cmd = New OdbcCommand("select id_kasir from t_kasir", conn)
        dr = cmd.ExecuteReader
        KodeKasir.Items.Clear()
        Do While dr.Read
            KodeKasir.Items.Add(dr.Item(0))
        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub

    Private Sub KodeKasir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KodeKasir.SelectedIndexChanged
        Call GetNamaKasir()
    End Sub

    Private Sub FormPenjualanBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call ClearForm()
        Call IdKasir()
        LabelTgl.Text = Format(Now, "dd MMM yyyy")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ClearForm()
    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 0 Then
            DataGridView1.Rows(e.RowIndex).Cells(0).Value =
                UCase(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Call koneksi()
            cmd = New OdbcCommand(" Select * from t_barang where id_barang = '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = dr.Item("nama_barang")
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = dr.Item("harga_jual")
                DataGridView1.Rows(e.RowIndex).Cells(3).Value = 0
                DataGridView1.Rows(e.RowIndex).Cells(4).Value = dr.Item("stok")
                DataGridView1.Rows(e.RowIndex).Cells(5).Value = 0
                DataGridView1.Rows(e.RowIndex).Cells(6).Value = 0
            Else
                MsgBox("Maaf, Data Barang Tidak ditemukan!", MsgBoxStyle.Exclamation, "Peringatan")
                DataGridView1.Focus()
            End If
        End If
        If e.ColumnIndex = 3 Then
            DataGridView1.Rows(e.RowIndex).Cells(5).Value =
            DataGridView1.Rows(e.RowIndex).Cells(4).Value -
            DataGridView1.Rows(e.RowIndex).Cells(3).Value
            DataGridView1.Rows(e.RowIndex).Cells(6).Value =
            DataGridView1.Rows(e.RowIndex).Cells(2).Value *
            DataGridView1.Rows(e.RowIndex).Cells(3).Value
        End If
        Call hitungTotal()
        Call hitungItem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NoFaktur.Text = "" Then
            MsgBox("Nomor Faktur Belum di isi !! ", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call koneksi()
            Dim simpan As String = "INSERT INTO t_jual (id_faktur_jual, tanggal, id_kasir, total_item, total_bayar) VALUES (?, ?, ?, ?, ?)"
            Dim simpan1 As String = "INSERT INTO t_detail_jual (id_faktur_jual, id_barang, jumlah) VALUES (?, ?, ?)"
            Dim ubah As String = "UPDATE t_barang SET stok = ? WHERE id_barang = ?"
            cmd = conn.CreateCommand
            With cmd
                .CommandText = simpan
                .Connection = conn
                .Parameters.Add("id_faktur_jual", OdbcType.VarChar, 6).Value = NoFaktur.Text
                .Parameters.Add("tanggal", OdbcType.DateTime).Value = Format(Now, "dd/MM/yyyy hh:mm:ss")
                .Parameters.Add("id_kasir", OdbcType.VarChar).Value = KodeKasir.Text
                .Parameters.Add("total_item", OdbcType.Int).Value = LabelTotalItem.Text
                .Parameters.Add("total_bayar", OdbcType.Int).Value = LabelTotalBayar.Text
                .ExecuteNonQuery()
            End With
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                cmd = conn.CreateCommand
                With cmd
                    .CommandText = simpan1
                    .Connection = conn
                    .Parameters.Add("id_faktur_jual", OdbcType.VarChar, 6).Value = NoFaktur.Text
                    .Parameters.Add("id_barang", OdbcType.VarChar, 20).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    .Parameters.Add("jumlah", OdbcType.Int).Value = DataGridView1.Rows(i).Cells(3).Value.ToString()
                    .ExecuteNonQuery()
                End With
                cmd = conn.CreateCommand
                With cmd
                    .CommandText = ubah
                    .Connection = conn
                    .Parameters.Add("stok", OdbcType.Int).Value = DataGridView1.Rows(i).Cells(5).Value.ToString()
                    .Parameters.Add("id_barang", OdbcType.VarChar).Value = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    .ExecuteNonQuery()
                End With
            Next
        End If
        conn.Close()
        cmd.Dispose()
        ClearForm()
    End Sub
End Class