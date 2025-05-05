<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class input_data
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
        Panel1 = New Panel()
        GroupBox2 = New GroupBox()
        rbham = New RadioButton()
        Label6 = New Label()
        rbrhy = New RadioButton()
        GroupBox1 = New GroupBox()
        rbgo = New RadioButton()
        Label3 = New Label()
        rbter = New RadioButton()
        DataGridView1 = New DataGridView()
        btncetak = New Button()
        btntutup = New Button()
        btnEdit = New Button()
        btnCari = New Button()
        btnDelete = New Button()
        btnSave = New Button()
        txttgl = New TextBox()
        Label5 = New Label()
        txtstok = New TextBox()
        txtid = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(btncetak)
        Panel1.Controls.Add(btntutup)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnCari)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(txttgl)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtstok)
        Panel1.Controls.Add(txtid)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbham)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(rbrhy)
        GroupBox2.Location = New Point(410, 118)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(306, 70)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        ' 
        ' rbham
        ' 
        rbham.AutoSize = True
        rbham.Location = New Point(75, 22)
        rbham.Name = "rbham"
        rbham.Size = New Size(156, 19)
        rbham.TabIndex = 11
        rbham.TabStop = True
        rbham.Text = "PT HAMDEN INDONESIA"
        rbham.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 9
        Label6.Text = "Supplier :"
        ' 
        ' rbrhy
        ' 
        rbrhy.AutoSize = True
        rbrhy.Location = New Point(75, 47)
        rbrhy.Name = "rbrhy"
        rbrhy.Size = New Size(198, 19)
        rbrhy.TabIndex = 12
        rbrhy.TabStop = True
        rbrhy.Text = "PT RHYTHM KYOSIN INDONESIA"
        rbrhy.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbgo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(rbter)
        GroupBox1.Location = New Point(23, 112)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(179, 65)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        ' 
        ' rbgo
        ' 
        rbgo.AutoSize = True
        rbgo.Location = New Point(102, 19)
        rbgo.Name = "rbgo"
        rbgo.Size = New Size(77, 19)
        rbgo.TabIndex = 4
        rbgo.TabStop = True
        rbgo.Text = "Go No Go"
        rbgo.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 2
        Label3.Text = "Nama Material :"
        ' 
        ' rbter
        ' 
        rbter.AutoSize = True
        rbter.Location = New Point(102, 44)
        rbter.Name = "rbter"
        rbter.Size = New Size(70, 19)
        rbter.TabIndex = 5
        rbter.TabStop = True
        rbter.Text = "Terminal"
        rbter.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(48, 228)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(649, 210)
        DataGridView1.TabIndex = 19
        ' 
        ' btncetak
        ' 
        btncetak.Location = New Point(713, 415)
        btncetak.Name = "btncetak"
        btncetak.Size = New Size(75, 23)
        btncetak.TabIndex = 18
        btncetak.Text = "Cetak"
        btncetak.UseVisualStyleBackColor = True
        ' 
        ' btntutup
        ' 
        btntutup.Location = New Point(713, 197)
        btntutup.Name = "btntutup"
        btntutup.Size = New Size(75, 23)
        btntutup.TabIndex = 17
        btntutup.Text = "Batal"
        btntutup.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(622, 197)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 16
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(531, 197)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(75, 23)
        btnCari.TabIndex = 15
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(437, 197)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 14
        btnDelete.Text = "Hapus"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(344, 197)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 13
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txttgl
        ' 
        txttgl.Location = New Point(486, 89)
        txttgl.Name = "txttgl"
        txttgl.Size = New Size(188, 23)
        txttgl.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(391, 90)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 15)
        Label5.TabIndex = 8
        Label5.Text = "Tanggal/Bulan :"
        ' 
        ' txtstok
        ' 
        txtstok.Location = New Point(122, 183)
        txtstok.Name = "txtstok"
        txtstok.Size = New Size(188, 23)
        txtstok.TabIndex = 7
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(122, 89)
        txtid.Name = "txtid"
        txtid.Size = New Size(188, 23)
        txtid.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(82, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 3
        Label4.Text = "Stok :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "ID Material :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(306, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 35)
        Label1.TabIndex = 0
        Label1.Text = "FORM INPUT DATA"
        ' 
        ' input_data
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "input_data"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstok As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents rbter As RadioButton
    Friend WithEvents rbgo As RadioButton
    Friend WithEvents btncetak As Button
    Friend WithEvents btntutup As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents rbrhy As RadioButton
    Friend WithEvents rbham As RadioButton
    Friend WithEvents txttgl As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
