<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterBarang))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KodeBarang = New System.Windows.Forms.TextBox()
        Me.NamaBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HargaBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Stok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.CariData = New System.Windows.Forms.TextBox()
        Me.HargaJual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Simpan = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'KodeBarang
        '
        Me.KodeBarang.Location = New System.Drawing.Point(142, 27)
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.Size = New System.Drawing.Size(148, 23)
        Me.KodeBarang.TabIndex = 1
        '
        'NamaBarang
        '
        Me.NamaBarang.Location = New System.Drawing.Point(142, 69)
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Size = New System.Drawing.Size(148, 23)
        Me.NamaBarang.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'HargaBarang
        '
        Me.HargaBarang.Location = New System.Drawing.Point(142, 109)
        Me.HargaBarang.Name = "HargaBarang"
        Me.HargaBarang.Size = New System.Drawing.Size(148, 23)
        Me.HargaBarang.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(31, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Harga Satuan"
        '
        'Stok
        '
        Me.Stok.Location = New System.Drawing.Point(142, 151)
        Me.Stok.Name = "Stok"
        Me.Stok.Size = New System.Drawing.Size(148, 23)
        Me.Stok.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(31, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stok Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(444, 240)
        Me.DataGridView1.TabIndex = 8
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.SystemColors.Control
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.Location = New System.Drawing.Point(366, 27)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(71, 33)
        Me.BtnTambah.TabIndex = 9
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(366, 63)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(80, 33)
        Me.BtnEdit.TabIndex = 10
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.Location = New System.Drawing.Point(366, 104)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(80, 35)
        Me.BtnBatal.TabIndex = 12
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'CariData
        '
        Me.CariData.Location = New System.Drawing.Point(142, 231)
        Me.CariData.Name = "CariData"
        Me.CariData.Size = New System.Drawing.Size(333, 23)
        Me.CariData.TabIndex = 19
        '
        'HargaJual
        '
        Me.HargaJual.Location = New System.Drawing.Point(142, 191)
        Me.HargaJual.Name = "HargaJual"
        Me.HargaJual.Size = New System.Drawing.Size(148, 23)
        Me.HargaJual.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(31, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Harga Jual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(31, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Cari Data"
        '
        'Simpan
        '
        Me.Simpan.AutoSize = True
        Me.Simpan.Location = New System.Drawing.Point(428, 35)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(47, 15)
        Me.Simpan.TabIndex = 23
        Me.Simpan.Text = "Simpan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(428, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Edit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(428, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Batal"
        '
        'FormMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(510, 552)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Simpan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HargaJual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CariData)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Stok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HargaBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NamaBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KodeBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMasterBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMasterBarang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents KodeBarang As TextBox
    Friend WithEvents NamaBarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents HargaBarang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Stok As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnCariData As Button
    Friend WithEvents CariData As TextBox
    Friend WithEvents HargaJual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Simpan As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
