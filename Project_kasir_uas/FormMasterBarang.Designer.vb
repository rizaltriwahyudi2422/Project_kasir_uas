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
        Me.BtnCariData = New System.Windows.Forms.Button()
        Me.CariData = New System.Windows.Forms.TextBox()
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(444, 240)
        Me.DataGridView1.TabIndex = 8
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(374, 27)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(101, 38)
        Me.BtnTambah.TabIndex = 9
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(374, 84)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(101, 33)
        Me.BtnEdit.TabIndex = 10
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(374, 139)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(101, 35)
        Me.BtnBatal.TabIndex = 12
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnCariData
        '
        Me.BtnCariData.Location = New System.Drawing.Point(31, 208)
        Me.BtnCariData.Name = "BtnCariData"
        Me.BtnCariData.Size = New System.Drawing.Size(84, 26)
        Me.BtnCariData.TabIndex = 18
        Me.BtnCariData.Text = "Cari Data"
        Me.BtnCariData.UseVisualStyleBackColor = True
        '
        'CariData
        '
        Me.CariData.Location = New System.Drawing.Point(142, 208)
        Me.CariData.Name = "CariData"
        Me.CariData.Size = New System.Drawing.Size(333, 23)
        Me.CariData.TabIndex = 19
        '
        'FormMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 546)
        Me.Controls.Add(Me.CariData)
        Me.Controls.Add(Me.BtnCariData)
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
End Class
