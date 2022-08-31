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
            cmd = New OdbcCommand(" Select * from t_barang where id_barang = '" & DataGridView1.Rows(e.RowIndex).Cells(0).Value & "'", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                DataGridView1.Rows(e.RowIndex).Cells(1).Value = dr.Item("nama_barang")
                DataGridView1.Rows(e.RowIndex).Cells(2).Value = dr.Item("harga_satuan")
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
            DataGridView1.Rows(e.RowIndex).Cells(4).Value +
            DataGridView1.Rows(e.RowIndex).Cells(3).Value
            DataGridView1.Rows(e.RowIndex).Cells(6).Value =
            DataGridView1.Rows(e.RowIndex).Cells(2).Value *
            DataGridView1.Rows(e.RowIndex).Cells(3).Value
        End If
        Call hitungTotal()
        Call hitungItem()
    End Sub

    Sub suplier()
        Call koneksi()
        cmd = New OdbcCommand("select id_suplier from t_suplier", conn)
        dr = cmd.ExecuteReader
        KodeSuplier.Items.Clear()
        Do While dr.Read
            KodeSuplier.Items.Add(dr.Item(0))
        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
    Sub ClearForm()
        NoFaktur.Text = ""
        LabelTgl.Text = ""
        LabelSuplier.Text = ""
        LabelTotalItem.Text = ""
        LabelTotalBayar.Text = ""
        KodeSuplier.Text = ""
        DataGridView1.Rows.Clear()
    End Sub
    Sub GetNamaSuplier()
        Call koneksi()
        cmd = New OdbcCommand("select nama_suplier from t_suplier where id_suplier = '" & KodeSuplier.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            LabelSuplier.Text = dr.Item(0)
        End If
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

    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ClearForm()
        Call suplier()
        LabelTgl.Text = Format(Now, "dd MMM yyyy")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NoFaktur.Text = "" Then
            MsgBox("Nomor Faktur Belum di isi !! ", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call koneksi()

            Dim simpan As String = "INSERT INTO t_beli(id_faktur, tanggal, id_suplier, total_item, total_bayar) VALUES (?,?,?,?,?)"
            Dim cmd As New OdbcCommand
            Dim simpan1 As String = "INSERT INTO t_detail_beli (id_faktur,id_barang,jumlah) VALUES (@p6,@p7,@p8)"
            Dim ubah As String = "UPDATE t_barang SET stok=stok+@p9 WHERE id_barang = @p10"
            cmd.CommandText = simpan
            cmd.Connection = conn
            cmd.Parameters.Add("@id_faktur", OdbcType.VarChar, 6)
            cmd.Parameters("@id_faktur").Value = NoFaktur.Text
            cmd.Parameters.Add("@tanggal", OdbcType.DateTime)
            cmd.Parameters("@tanggal").Value = Format(Now, "dd/MM/yyyy hh:mm:ss")
            cmd.Parameters.Add("@id_suplier", OdbcType.VarChar)
            cmd.Parameters("@id_suplier").Value = KodeSuplier.Text
            cmd.Parameters.Add("@total_item", OdbcType.Int)
            cmd.Parameters("@total_item").Value = LabelTotalItem.Text
            cmd.Parameters.Add("@total_bayar", OdbcType.Int)
            cmd.Parameters("@total_bayar").Value = LabelTotalBayar.Text
            cmd.ExecuteNonQuery()
            For i As Integer = 0 To DataGridView1.Rows.Count - 2
                cmd.CommandText = simpan1
                cmd.Connection = conn
                cmd.Parameters.Add("@p6", OdbcType.VarChar, 6).Value = NoFaktur.Text
                cmd.Parameters.Add("@p7", OdbcType.VarChar, 20).Value = DataGridView1.Rows(i).Cells(0).Value
                cmd.Parameters.Add("@p8", OdbcType.Int).Value = DataGridView1.Rows(i).Cells(3).Value
                cmd.ExecuteNonQuery()

                cmd.CommandText = ubah
                cmd.Connection = conn
                cmd.Parameters.Add("@p9", OdbcType.Int)
                cmd.Parameters("@p9").Value = DataGridView1.Rows(i).Cells(3).Value
                cmd.Parameters.Add("@p10", OdbcType.VarChar)
                cmd.Parameters("@p10").Value = DataGridView1.Rows(i).Cells(0).Value
                cmd.ExecuteNonQuery()
            Next
        End If
        conn.Close()
        cmd.Dispose()
        ClearForm()
        'If NoFaktur.Text = "" Then
        '    MsgBox("Nomor Faktur Belum di isi !! ", MsgBoxStyle.Exclamation,
        '    "Peringatan")
        'Else
        '    Dim simpan As String
        '    Dim simpan1 As String
        '    Dim ubah As String
        '    Call koneksi()
        '    simpan = "INSERT INTO t_beli (id_faktur,tanggal,id_suplier,total_item,total_bayar) VALUES (@p1,@p2,@p3,@p4,@p5)"
        '    simpan1 = "INSERT INTO t_detail_beli (id_faktur,id_barang,jumlah) VALUES (@p6,@p7,@p8) "
        '    ubah = "UPDATE tbbarang SET stok=stok+@p9 WHERE kodebarang = @p10"
        '    cmd = conn.CreateCommand
        '    With cmd
        '        .CommandText = simpan
        '        .Connection = conn
        '        .Parameters.AddWithValue("@p1", NoFaktur.Text)
        '        .Parameters.AddWithValue("@p2", Format(Now, "dd/MM/yyyy hh:mm:ss"))
        '        .Parameters.AddWithValue("@p3", KodeSuplier.Text)
        '        .Parameters.AddWithValue("@p4", LabelTotalItem.Text)
        '        .Parameters.AddWithValue("@p5", LabelTotalBayar.Text)
        '        .ExecuteNonQuery()
        '    End With
        '    For i As Integer = 0 To DataGridView1.Rows.Count - 2
        '        cmd = conn.CreateCommand
        '        With cmd
        '            .CommandText = simpan1
        '            .Connection = conn
        '            .Parameters.AddWithValue("p6", NoFaktur.Text)
        '            .Parameters.AddWithValue("p7", DataGridView1.Rows(i).Cells(0).Value.ToString())
        '            .Parameters.AddWithValue("p8", DataGridView1.Rows(i).Cells(3).Value.ToString())
        '            .ExecuteNonQuery()
        '        End With
        '        cmd = conn.CreateCommand
        '        With cmd
        '            .CommandText = ubah
        '            .Connection = conn
        '            .Parameters.AddWithValue("p9", DataGridView1.Rows(i).Cells(3).Value.ToString())
        '            .Parameters.AddWithValue("p10", DataGridView1.Rows(i).Cells(0).Value.ToString())
        '            .ExecuteNonQuery()
        '        End With
        '    Next
        'End If
        'conn.Close()
        'cmd.Dispose()
        'ClearForm()
    End Sub
    Private Sub KodeSuplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KodeSuplier.SelectedIndexChanged
        Call GetNamaSuplier()
    End Sub
End Class