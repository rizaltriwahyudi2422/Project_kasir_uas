<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualanBarang
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
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.LabelNamaKasir = New System.Windows.Forms.Label()
        Me.LabelTgl = New System.Windows.Forms.Label()
        Me.LabelTotalBayar = New System.Windows.Forms.Label()
        Me.TotalBayarBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TotalItem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeKasir = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TglBox = New System.Windows.Forms.TextBox()
        Me.NoFaktur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(139, 356)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(47, 15)
        Me.LabelTotalItem.TabIndex = 37
        Me.LabelTotalItem.Text = "Label10"
        '
        'LabelNamaKasir
        '
        Me.LabelNamaKasir.AutoSize = True
        Me.LabelNamaKasir.Location = New System.Drawing.Point(519, 51)
        Me.LabelNamaKasir.Name = "LabelNamaKasir"
        Me.LabelNamaKasir.Size = New System.Drawing.Size(41, 15)
        Me.LabelNamaKasir.TabIndex = 36
        Me.LabelNamaKasir.Text = "Label9"
        '
        'LabelTgl
        '
        Me.LabelTgl.AutoSize = True
        Me.LabelTgl.Location = New System.Drawing.Point(97, 51)
        Me.LabelTgl.Name = "LabelTgl"
        Me.LabelTgl.Size = New System.Drawing.Size(41, 15)
        Me.LabelTgl.TabIndex = 35
        Me.LabelTgl.Text = "Label8"
        '
        'LabelTotalBayar
        '
        Me.LabelTotalBayar.AutoSize = True
        Me.LabelTotalBayar.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalBayar.Location = New System.Drawing.Point(457, 353)
        Me.LabelTotalBayar.Name = "LabelTotalBayar"
        Me.LabelTotalBayar.Size = New System.Drawing.Size(136, 50)
        Me.LabelTotalBayar.TabIndex = 34
        Me.LabelTotalBayar.Text = "Label7"
        '
        'TotalBayarBox
        '
        Me.TotalBayarBox.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalBayarBox.Location = New System.Drawing.Point(446, 333)
        Me.TotalBayarBox.Name = "TotalBayarBox"
        Me.TotalBayarBox.Size = New System.Drawing.Size(277, 93)
        Me.TotalBayarBox.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Total Bayar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TotalItem
        '
        Me.TotalItem.Location = New System.Drawing.Point(139, 353)
        Me.TotalItem.Name = "TotalItem"
        Me.TotalItem.Size = New System.Drawing.Size(186, 23)
        Me.TotalItem.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Total Item"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.NamaBarang, Me.Harga, Me.JumlahBeli, Me.StokAwal, Me.StokAkhir, Me.TotalBayar})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(744, 210)
        Me.DataGridView1.TabIndex = 27
        '
        'KodeBarang
        '
        Me.KodeBarang.HeaderText = "Kode Barang"
        Me.KodeBarang.Name = "KodeBarang"
        '
        'NamaBarang
        '
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        '
        'JumlahBeli
        '
        Me.JumlahBeli.HeaderText = "Jumlah Beli"
        Me.JumlahBeli.Name = "JumlahBeli"
        '
        'StokAwal
        '
        Me.StokAwal.HeaderText = "Stok Awal"
        Me.StokAwal.Name = "StokAwal"
        '
        'StokAkhir
        '
        Me.StokAkhir.HeaderText = "Stok Akhir"
        Me.StokAkhir.Name = "StokAkhir"
        '
        'TotalBayar
        '
        Me.TotalBayar.HeaderText = "Total Bayar"
        Me.TotalBayar.Name = "TotalBayar"
        '
        'KodeKasir
        '
        Me.KodeKasir.FormattingEnabled = True
        Me.KodeKasir.Location = New System.Drawing.Point(517, 17)
        Me.KodeKasir.Name = "KodeKasir"
        Me.KodeKasir.Size = New System.Drawing.Size(203, 23)
        Me.KodeKasir.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Kode Kasir"
        '
        'Nama
        '
        Me.Nama.Location = New System.Drawing.Point(514, 48)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(206, 23)
        Me.Nama.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama Kasir"
        '
        'TglBox
        '
        Me.TglBox.Location = New System.Drawing.Point(97, 48)
        Me.TglBox.Name = "TglBox"
        Me.TglBox.Size = New System.Drawing.Size(186, 23)
        Me.TglBox.TabIndex = 22
        '
        'NoFaktur
        '
        Me.NoFaktur.Location = New System.Drawing.Point(97, 14)
        Me.NoFaktur.Name = "NoFaktur"
        Me.NoFaktur.Size = New System.Drawing.Size(186, 23)
        Me.NoFaktur.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hari Ini"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "No. Faktur"
        '
        'FormPenjualanBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelTotalItem)
        Me.Controls.Add(Me.LabelNamaKasir)
        Me.Controls.Add(Me.LabelTgl)
        Me.Controls.Add(Me.LabelTotalBayar)
        Me.Controls.Add(Me.TotalBayarBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.KodeKasir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TglBox)
        Me.Controls.Add(Me.NoFaktur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPenjualanBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenjualanBarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTotalItem As Label
    Friend WithEvents LabelNamaKasir As Label
    Friend WithEvents LabelTgl As Label
    Friend WithEvents LabelTotalBayar As Label
    Friend WithEvents TotalBayarBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TotalItem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeli As DataGridViewTextBoxColumn
    Friend WithEvents StokAwal As DataGridViewTextBoxColumn
    Friend WithEvents StokAkhir As DataGridViewTextBoxColumn
    Friend WithEvents TotalBayar As DataGridViewTextBoxColumn
    Friend WithEvents KodeKasir As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TglBox As TextBox
    Friend WithEvents NoFaktur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
