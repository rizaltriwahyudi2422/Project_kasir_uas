<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NoFaktur = New System.Windows.Forms.TextBox()
        Me.TglBox = New System.Windows.Forms.TextBox()
        Me.NamaSuplier = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KodeSuplier = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TotalItem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TotalBayarBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelTotalBayar = New System.Windows.Forms.Label()
        Me.LabelTgl = New System.Windows.Forms.Label()
        Me.LabelSuplier = New System.Windows.Forms.Label()
        Me.LabelTotalItem = New System.Windows.Forms.Label()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokAwal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokAkhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalBayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Faktur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hari Ini"
        '
        'NoFaktur
        '
        Me.NoFaktur.Location = New System.Drawing.Point(83, 22)
        Me.NoFaktur.Name = "NoFaktur"
        Me.NoFaktur.Size = New System.Drawing.Size(186, 23)
        Me.NoFaktur.TabIndex = 2
        '
        'TglBox
        '
        Me.TglBox.Location = New System.Drawing.Point(83, 51)
        Me.TglBox.Name = "TglBox"
        Me.TglBox.Size = New System.Drawing.Size(186, 23)
        Me.TglBox.TabIndex = 3
        '
        'NamaSuplier
        '
        Me.NamaSuplier.Location = New System.Drawing.Point(451, 60)
        Me.NamaSuplier.Name = "NamaSuplier"
        Me.NamaSuplier.Size = New System.Drawing.Size(206, 23)
        Me.NamaSuplier.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(357, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama Suplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(357, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kode Suplier"
        '
        'KodeSuplier
        '
        Me.KodeSuplier.FormattingEnabled = True
        Me.KodeSuplier.Location = New System.Drawing.Point(454, 22)
        Me.KodeSuplier.Name = "KodeSuplier"
        Me.KodeSuplier.Size = New System.Drawing.Size(203, 23)
        Me.KodeSuplier.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarang, Me.NamaBarang, Me.Harga, Me.JumlahBeli, Me.StokAwal, Me.StokAkhir, Me.TotalBayar})
        Me.DataGridView1.Location = New System.Drawing.Point(34, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(643, 210)
        Me.DataGridView1.TabIndex = 8
        '
        'TotalItem
        '
        Me.TotalItem.Location = New System.Drawing.Point(83, 351)
        Me.TotalItem.Name = "TotalItem"
        Me.TotalItem.Size = New System.Drawing.Size(186, 23)
        Me.TotalItem.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Item"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TotalBayarBox
        '
        Me.TotalBayarBox.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TotalBayarBox.Location = New System.Drawing.Point(390, 331)
        Me.TotalBayarBox.Name = "TotalBayarBox"
        Me.TotalBayarBox.Size = New System.Drawing.Size(277, 93)
        Me.TotalBayarBox.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Bayar"
        '
        'LabelTotalBayar
        '
        Me.LabelTotalBayar.AutoSize = True
        Me.LabelTotalBayar.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelTotalBayar.Location = New System.Drawing.Point(401, 351)
        Me.LabelTotalBayar.Name = "LabelTotalBayar"
        Me.LabelTotalBayar.Size = New System.Drawing.Size(136, 50)
        Me.LabelTotalBayar.TabIndex = 15
        Me.LabelTotalBayar.Text = "Label7"
        '
        'LabelTgl
        '
        Me.LabelTgl.AutoSize = True
        Me.LabelTgl.Location = New System.Drawing.Point(83, 54)
        Me.LabelTgl.Name = "LabelTgl"
        Me.LabelTgl.Size = New System.Drawing.Size(41, 15)
        Me.LabelTgl.TabIndex = 16
        Me.LabelTgl.Text = "Label8"
        '
        'LabelSuplier
        '
        Me.LabelSuplier.AutoSize = True
        Me.LabelSuplier.Location = New System.Drawing.Point(451, 63)
        Me.LabelSuplier.Name = "LabelSuplier"
        Me.LabelSuplier.Size = New System.Drawing.Size(41, 15)
        Me.LabelSuplier.TabIndex = 17
        Me.LabelSuplier.Text = "Label9"
        '
        'LabelTotalItem
        '
        Me.LabelTotalItem.AutoSize = True
        Me.LabelTotalItem.Location = New System.Drawing.Point(83, 354)
        Me.LabelTotalItem.Name = "LabelTotalItem"
        Me.LabelTotalItem.Size = New System.Drawing.Size(47, 15)
        Me.LabelTotalItem.TabIndex = 18
        Me.LabelTotalItem.Text = "Label10"
        '
        'KodeBarang
        '
        Me.KodeBarang.HeaderText = "Kode Barang"
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
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
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 450)
        Me.Controls.Add(Me.LabelTotalItem)
        Me.Controls.Add(Me.LabelSuplier)
        Me.Controls.Add(Me.LabelTgl)
        Me.Controls.Add(Me.LabelTotalBayar)
        Me.Controls.Add(Me.TotalBayarBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.KodeSuplier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NamaSuplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TglBox)
        Me.Controls.Add(Me.NoFaktur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembelian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NoFaktur As TextBox
    Friend WithEvents TglBox As TextBox
    Friend WithEvents NamaSuplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents KodeSuplier As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TotalItem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TotalBayarBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelTotalBayar As Label
    Friend WithEvents LabelTgl As Label
    Friend WithEvents LabelSuplier As Label
    Friend WithEvents LabelTotalItem As Label
    Friend WithEvents KodeBarang As DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As DataGridViewTextBoxColumn
    Friend WithEvents Harga As DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeli As DataGridViewTextBoxColumn
    Friend WithEvents StokAwal As DataGridViewTextBoxColumn
    Friend WithEvents StokAkhir As DataGridViewTextBoxColumn
    Friend WithEvents TotalBayar As DataGridViewTextBoxColumn
End Class
