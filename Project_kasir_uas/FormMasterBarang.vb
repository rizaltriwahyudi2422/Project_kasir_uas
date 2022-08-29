Imports System.Data.Odbc
Public Class FormMasterBarang
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
        KodeBarang.Text = ""
        NamaBarang.Text = ""
        HargaBarang.Text = ""
        Stok.Text = ""
        Call koneksi()
        da = New OdbcDataAdapter("Select * From t_barang", conn)
        ds = New DataSet
        da.Fill(ds, "t_barang")
        DataGridView1.DataSource = ds.Tables("t_barang")
        DataGridView1.ReadOnly = True
    End Sub
    Sub barang()
        Call koneksi()
        cmd = New OdbcCommand("Select nama_suplier from t_suplier", conn)
        dr = cmd.ExecuteReader
        NamaSuplier.Items.Clear()
        Do While dr.Read
            NamaSuplier.Items.Add(dr.Item(0))
        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
    Private Sub FormMasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call barang()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            KodeBarang.Text = row.Cells(0).Value.ToString()
            NamaBarang.Text = row.Cells(1).Value.ToString()
            HargaBarang.Text = row.Cells(2).Value.ToString()
            Stok.Text = row.Cells(3).Value.ToString()
            NamaSuplier.Text = row.Cells(4).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormPembelian.Show()
        'If KodeBarang.Text = "" Or NamaBarang.Text = "" Or HargaBarang.Text = "" Or Stok.Text = "" Then
        '    MsgBox("Data Barang Wajib Di isi!")
        'Else
        '    Try
        '        Call koneksi()
        '        cmd = New OdbcCommand("Select id_barang From t_barang where id_barang = '" & KodeBarang.Text & "'", conn)
        '        dr = cmd.ExecuteReader
        '        dr.Read()
        '        If dr.HasRows Then
        '            MsgBox(" Maaf, Data dengan kode tersebut sudah ada", MsgBoxStyle.Exclamation, "peringatan!")
        '        Else
        '            Call koneksi()
        '            Dim InputData As String = "insert into t_barang values ('" & KodeBarang.Text & "','" & NamaBarang.Text & "','" & HargaBarang.Text & "','" & Stok.Text & "')"
        '            cmd = New OdbcCommand(InputData, conn)
        '            cmd.ExecuteNonQuery()
        '            MsgBox("Data Disimpan")
        '            Call KondisiAwal()
        '        End If

        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If KodeBarang.Text = "" Or NamaBarang.Text = "" Or HargaBarang.Text = "" Or Stok.Text = "" Or NamaSuplier.Text = "" Then
            MsgBox("Data Barang Wajib Di isi!")
        Else
            Call koneksi()
            Dim EditData As String = "update t_barang set nama_barang='" & NamaBarang.Text & "',harga_satuan='" & HargaBarang.Text & "',stok='" & Stok.Text & "',nama_suplier='" & NamaSuplier.Text & "'where id_barang='" & KodeBarang.Text & "' "
            cmd = New OdbcCommand(EditData, conn)
            cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil di Edit")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Close()
    End Sub

    Private Sub BtnCariData_Click(sender As Object, e As EventArgs) Handles BtnCariData.Click
        Call koneksi()
        cmd = New OdbcCommand("select  * from t_barang where id_barang like '%'" & CariData.Text & "'%'", conn)
        dr = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While dr.Read = True
            DataGridView1.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4))
        Loop
    End Sub
End Class