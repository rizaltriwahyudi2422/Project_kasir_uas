Imports System.Data.Odbc
Public Class FormMasterKasir
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

    Private Sub FormMasterKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub KondisiAwal()
        TextUsername.Text = ""
        TextId.Text = ""
        TextPassword.Text = ""
        BoxRole.Text = ""

        Call koneksi()
        da = New OdbcDataAdapter("Select * From t_kasir", conn)
        ds = New DataSet
        da.Fill(ds, "t_kasir")
        DataGridView1.DataSource = ds.Tables("t_kasir")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try
            TextId.Text = row.Cells(0).Value.ToString()
            TextUsername.Text = row.Cells(1).Value.ToString()
            TextPassword.Text = row.Cells(2).Value.ToString()
            BoxRole.Text = row.Cells(3).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If TextUsername.Text = "" Or TextId.Text = "" Or TextPassword.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            Try
                Call koneksi()
                cmd = New OdbcCommand("Select id_kasir From t_kasir where id_kasir = '" & TextId.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox(" Maaf, Data dengan ID tersebut sudah ada", MsgBoxStyle.Exclamation, "peringatan!")
                Else
                    Call koneksi()
                    Dim InputData As String = "insert into t_kasir values ('" & TextId.Text & "','" & TextUsername.Text & "','" & TextPassword.Text & "','" & BoxRole.Text & "' )"
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
        If TextUsername.Text = "" Or TextId.Text = "" Or TextPassword.Text = "" Then
            MsgBox("Data Tidak Boleh Kosong")
        Else
            Call koneksi()
            Dim EditData As String = "update t_kasir set nama_kasir='" & TextUsername.Text & "',password_kasir='" & TextPassword.Text & "',level_kasir='" & BoxRole.Text & "' where id_kasir='" & TextId.Text & "'"
            cmd = New OdbcCommand(EditData, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Dirubah!")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If TextUsername.Text = "" Or TextId.Text = "" Or TextPassword.Text = "" Then
            MsgBox("Pilih Data yang akan di hapus!")
        Else
            Call koneksi()
            Dim HapusData As String = " Delete From t_kasir where id_kasir='" & TextId.Text & "'"
            cmd = New OdbcCommand(HapusData, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Dihapus!")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Close()
    End Sub
End Class