Imports System.Data.Odbc
Public Class FormMasterSuplier
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
        IdSuplier.Text = ""
        NamaSuplier.Text = ""
        Alamat.Text = ""
        Telepon.Text = ""
        Call koneksi()
        da = New OdbcDataAdapter("Select * From t_suplier", conn)
        ds = New DataSet
        da.Fill(ds, "t_suplier")
        DataGridView1.DataSource = ds.Tables("t_suplier")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub FormMasterSuplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            IdSuplier.Text = row.Cells(0).Value.ToString()
            NamaSuplier.Text = row.Cells(2).Value.ToString()
            Alamat.Text = row.Cells(3).Value.ToString()
            Telepon.Text = row.Cells(4).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If IdSuplier.Text = "" Or NamaSuplier.Text = "" Or Alamat.Text = "" Or Telepon.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            Try
                Call koneksi()
                cmd = New OdbcCommand("Select id_suplier From t_suplier where id_suplier = '" & IdSuplier.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox(" Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "peringatan!")
                Else
                    Call koneksi()
                    Dim InputData As String = "insert into t_suplier values ('" & IdSuplier.Text & "','" & NamaSuplier.Text & "','" & Alamat.Text & "','" & Telepon.Text & "' )"
                    cmd = New OdbcCommand(InputData, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Disimpan")
                    Call KondisiAwal()
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If IdSuplier.Text = "" Or NamaSuplier.Text = "" Or Alamat.Text = "" Or Telepon.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            Call koneksi()
            Dim EditData As String = "update t_suplier set nama_suplier='" & NamaSuplier.Text & "', alamat ='" & Alamat.Text & "','" & Telepon.Text & "',where id_suplier='" & IdSuplier.Text & "'"
            cmd = New OdbcCommand(EditData, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Dirubah!")
            Call KondisiAwal()
        End If

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If IdSuplier.Text = "" Or NamaSuplier.Text = "" Or Alamat.Text = "" Or Telepon.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            Call koneksi()
            Dim HapusData As String = " Delete From t_suplier where id_suplier='" & IdSuplier.Text & "'"
            cmd = New OdbcCommand(HapusData, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus!")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub IdBarang_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NamaSuplier_TextChanged(sender As Object, e As EventArgs) Handles NamaSuplier.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class