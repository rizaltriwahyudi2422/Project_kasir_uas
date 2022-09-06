<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasterKasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMasterKasir))
        Me.label_id = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.Label()
        Me.Role = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.TextId = New System.Windows.Forms.TextBox()
        Me.TextUsername = New System.Windows.Forms.TextBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.BoxRole = New System.Windows.Forms.ComboBox()
        Me.BtnInput = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label_id.Location = New System.Drawing.Point(24, 27)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(22, 18)
        Me.label_id.TabIndex = 0
        Me.label_id.Text = "ID"
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Username.Location = New System.Drawing.Point(24, 61)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(77, 18)
        Me.Username.TabIndex = 1
        Me.Username.Text = "Username"
        '
        'Role
        '
        Me.Role.AutoSize = True
        Me.Role.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Role.Location = New System.Drawing.Point(24, 126)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(39, 18)
        Me.Role.TabIndex = 2
        Me.Role.Text = "Role"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Password.Location = New System.Drawing.Point(24, 95)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(75, 18)
        Me.Password.TabIndex = 3
        Me.Password.Text = "Password"
        '
        'TextId
        '
        Me.TextId.Location = New System.Drawing.Point(126, 27)
        Me.TextId.Name = "TextId"
        Me.TextId.Size = New System.Drawing.Size(126, 23)
        Me.TextId.TabIndex = 4
        '
        'TextUsername
        '
        Me.TextUsername.Location = New System.Drawing.Point(126, 61)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(126, 23)
        Me.TextUsername.TabIndex = 5
        '
        'TextPassword
        '
        Me.TextPassword.Location = New System.Drawing.Point(126, 95)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(126, 23)
        Me.TextPassword.TabIndex = 6
        '
        'BoxRole
        '
        Me.BoxRole.FormattingEnabled = True
        Me.BoxRole.Items.AddRange(New Object() {"admin", "kasir"})
        Me.BoxRole.Location = New System.Drawing.Point(126, 126)
        Me.BoxRole.Name = "BoxRole"
        Me.BoxRole.Size = New System.Drawing.Size(126, 23)
        Me.BoxRole.TabIndex = 7
        '
        'BtnInput
        '
        Me.BtnInput.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInput.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnInput.Image = CType(resources.GetObject("BtnInput.Image"), System.Drawing.Image)
        Me.BtnInput.Location = New System.Drawing.Point(22, 165)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(84, 30)
        Me.BtnInput.TabIndex = 8
        Me.BtnInput.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(126, 161)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 39)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.Location = New System.Drawing.Point(222, 164)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 31)
        Me.BtnHapus.TabIndex = 10
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTutup.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.Location = New System.Drawing.Point(316, 165)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 35)
        Me.BtnTutup.TabIndex = 11
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(367, 164)
        Me.DataGridView1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Edit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Delete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Exit"
        '
        'FormMasterKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(418, 408)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnInput)
        Me.Controls.Add(Me.BoxRole)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.TextUsername)
        Me.Controls.Add(Me.TextId)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Role)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.label_id)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormMasterKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMasterKasir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_id As Label
    Friend WithEvents Username As Label
    Friend WithEvents Role As Label
    Friend WithEvents Password As Label
    Friend WithEvents TextId As TextBox
    Friend WithEvents TextUsername As TextBox
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents BoxRole As ComboBox
    Friend WithEvents BtnInput As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnTutup As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
