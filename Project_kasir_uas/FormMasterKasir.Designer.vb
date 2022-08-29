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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label_id.Location = New System.Drawing.Point(22, 27)
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
        Me.TextId.Location = New System.Drawing.Point(128, 27)
        Me.TextId.Name = "TextId"
        Me.TextId.Size = New System.Drawing.Size(124, 23)
        Me.TextId.TabIndex = 4
        '
        'TextUsername
        '
        Me.TextUsername.Location = New System.Drawing.Point(126, 61)
        Me.TextUsername.Name = "TextUsername"
        Me.TextUsername.Size = New System.Drawing.Size(124, 23)
        Me.TextUsername.TabIndex = 5
        '
        'TextPassword
        '
        Me.TextPassword.Location = New System.Drawing.Point(126, 95)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(124, 23)
        Me.TextPassword.TabIndex = 6
        '
        'BoxRole
        '
        Me.BoxRole.FormattingEnabled = True
        Me.BoxRole.Items.AddRange(New Object() {"admin", "kasir"})
        Me.BoxRole.Location = New System.Drawing.Point(126, 126)
        Me.BoxRole.Name = "BoxRole"
        Me.BoxRole.Size = New System.Drawing.Size(121, 23)
        Me.BoxRole.TabIndex = 7
        '
        'BtnInput
        '
        Me.BtnInput.Location = New System.Drawing.Point(24, 169)
        Me.BtnInput.Name = "BtnInput"
        Me.BtnInput.Size = New System.Drawing.Size(75, 23)
        Me.BtnInput.TabIndex = 8
        Me.BtnInput.Text = "INPUT"
        Me.BtnInput.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(126, 169)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.Text = "EDIT"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(222, 169)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 10
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(316, 169)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 23)
        Me.BtnTutup.TabIndex = 11
        Me.BtnTutup.Text = "TUTUP"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 222)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(367, 164)
        Me.DataGridView1.TabIndex = 12
        '
        'FormMasterKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 408)
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
End Class
