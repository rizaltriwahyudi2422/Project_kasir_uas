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
    Sub terbuka()
        FormMenuUtama.Login.Visible = False
        FormMenuUtama.Logout.Visible = True
        FormMenuUtama.Master.Visible = True
        FormMenuUtama.Transaksi.Visible = True
        FormMenuUtama.Laporan.Visible = True
        FormMenuUtama.Utility.Visible = True
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
        If TextUsername.Text = "" Or TextPassword.Text = "" Then
            MsgBox("user atau password wajib di isi")
        Else
            Call koneksi()
            Dim LoginUser As String = "Select * from t_kasir where id_kasir='" & TextUsername.Text & "' and password_kasir='" & TextPassword.Text & "'"
            cmd = New OdbcCommand(LoginUser, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Anda Berhasil Login")
            Call terbuka()
            Me.Hide()
        End If
    End Sub
End Class