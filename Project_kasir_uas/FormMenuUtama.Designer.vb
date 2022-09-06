<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Master = New System.Windows.Forms.ToolStripMenuItem()
        Me.Kasir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Barang = New System.Windows.Forms.ToolStripMenuItem()
        Me.Suplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.Transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.Laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelian = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnFile, Me.Master, Me.Transaksi, Me.Laporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnFile
        '
        Me.MnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Login, Me.Logout, Me.Keluar})
        Me.MnFile.Name = "MnFile"
        Me.MnFile.Size = New System.Drawing.Size(37, 20)
        Me.MnFile.Text = "File"
        '
        'Login
        '
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(112, 22)
        Me.Login.Text = "Login"
        '
        'Logout
        '
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(112, 22)
        Me.Logout.Text = "Logout"
        '
        'Keluar
        '
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(112, 22)
        Me.Keluar.Text = "Keluar"
        '
        'Master
        '
        Me.Master.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Kasir, Me.Barang, Me.Suplier})
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(55, 20)
        Me.Master.Text = "Master"
        '
        'Kasir
        '
        Me.Kasir.Name = "Kasir"
        Me.Kasir.Size = New System.Drawing.Size(111, 22)
        Me.Kasir.Text = "User"
        '
        'Barang
        '
        Me.Barang.Name = "Barang"
        Me.Barang.Size = New System.Drawing.Size(111, 22)
        Me.Barang.Text = "Barang"
        '
        'Suplier
        '
        Me.Suplier.Name = "Suplier"
        Me.Suplier.Size = New System.Drawing.Size(111, 22)
        Me.Suplier.Text = "Suplier"
        '
        'Transaksi
        '
        Me.Transaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Penjualan, Me.Pembelian})
        Me.Transaksi.Name = "Transaksi"
        Me.Transaksi.Size = New System.Drawing.Size(66, 20)
        Me.Transaksi.Text = "Transaksi"
        '
        'Penjualan
        '
        Me.Penjualan.Name = "Penjualan"
        Me.Penjualan.Size = New System.Drawing.Size(130, 22)
        Me.Penjualan.Text = "Penjualan"
        '
        'Pembelian
        '
        Me.Pembelian.Name = "Pembelian"
        Me.Pembelian.Size = New System.Drawing.Size(130, 22)
        Me.Pembelian.Text = "Pembelian"
        '
        'Laporan
        '
        Me.Laporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualan, Me.LaporanPembelian})
        Me.Laporan.Name = "Laporan"
        Me.Laporan.Size = New System.Drawing.Size(62, 20)
        Me.Laporan.Text = "Laporan"
        '
        'LaporanPenjualan
        '
        Me.LaporanPenjualan.Name = "LaporanPenjualan"
        Me.LaporanPenjualan.Size = New System.Drawing.Size(176, 22)
        Me.LaporanPenjualan.Text = "Laporan Penjualan"
        '
        'LaporanPembelian
        '
        Me.LaporanPembelian.Name = "LaporanPembelian"
        Me.LaporanPembelian.Size = New System.Drawing.Size(176, 22)
        Me.LaporanPembelian.Text = "Laporan Pembelian"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.Text = "Main Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnFile As ToolStripMenuItem
    Friend WithEvents Login As ToolStripMenuItem
    Friend WithEvents Logout As ToolStripMenuItem
    Friend WithEvents Keluar As ToolStripMenuItem
    Friend WithEvents Master As ToolStripMenuItem
    Friend WithEvents Kasir As ToolStripMenuItem
    Friend WithEvents Barang As ToolStripMenuItem
    Friend WithEvents Transaksi As ToolStripMenuItem
    Friend WithEvents Penjualan As ToolStripMenuItem
    Friend WithEvents Laporan As ToolStripMenuItem
    Friend WithEvents LaporanPenjualan As ToolStripMenuItem
    Friend WithEvents Suplier As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelian As ToolStripMenuItem
    Friend WithEvents Pembelian As ToolStripMenuItem
End Class
