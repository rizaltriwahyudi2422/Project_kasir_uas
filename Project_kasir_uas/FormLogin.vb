Imports System.Data.Odbc
Public Class FormLogin
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
    Sub terbuka_admin()
        FormMenuUtama.Login.Visible = False
        FormMenuUtama.Logout.Visible = True
        FormMenuUtama.Master.Visible = True
        FormMenuUtama.Transaksi.Visible = True
        FormMenuUtama.Laporan.Visible = True

    End Sub
    Sub terbuka_kasir()
        FormMenuUtama.Login.Visible = False
        FormMenuUtama.Logout.Visible = True
        FormMenuUtama.Transaksi.Visible = True
        FormMenuUtama.Laporan.Visible = True
    End Sub

    Sub Awal()
        TextUsername.MaxLength = 6
        TextPassword.MaxLength = 10
        TextPassword.PasswordChar = "*"
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Awal()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TextUsername.Text = ""
        TextPassword.Text = ""
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Call koneksi()
        cmd = New OdbcCommand("Select * from t_kasir where nama_kasir='" & TextUsername.Text & "' and password_kasir='" & TextPassword.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            If dr(3) = "admin" Then
                Me.Hide()
                Call terbuka_admin()
            ElseIf dr(3) = "kasir" Then
                Me.Hide()
                Call terbuka_kasir()
            End If
        Else
            MsgBox("Username dan password salah!")
        End If



        'If TextUsername.Text = "" Or TextPassword.Text = "" Then
        '    MsgBox("user atau password wajib di isi")
        'Else
        '    Call koneksi()
        '    Dim LoginUser As String = "Select * from t_kasir where id_kasir='" & TextUsername.Text & "' and password_kasir='" & TextPassword.Text & "'"
        '    cmd = New OdbcCommand(LoginUser, conn)
        '    dr = cmd.ExecuteReader
        '    dr.Read()
        '    If dr.HasRows Then
        '        Call terbuka_admin()
        '        Me.Hide()
        '        MsgBox("Anda Berhasil Login")
        '    Else
        '        Call terbuka_kasir()
        '        Me.Hide()
        '        MsgBox("Anda Berhasil Login")


        '    End If

        'End If
    End Sub


End Class