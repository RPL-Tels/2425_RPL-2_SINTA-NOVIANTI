<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        DataGridView1 = New DataGridView()
        btnCetak = New Button()
        btnBatal = New Button()
        btnEdit = New Button()
        btnCari = New Button()
        btnDelete = New Button()
        txtdouble = New TextBox()
        txtno = New TextBox()
        rbpan = New RadioButton()
        rbbul = New RadioButton()
        rbpen = New RadioButton()
        cbojenis = New ComboBox()
        txtid = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        btnSave = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(btnCetak)
        Panel1.Controls.Add(btnBatal)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnCari)
        Panel1.Controls.Add(btnDelete)
        Panel1.Controls.Add(txtdouble)
        Panel1.Controls.Add(txtno)
        Panel1.Controls.Add(rbpan)
        Panel1.Controls.Add(rbbul)
        Panel1.Controls.Add(rbpen)
        Panel1.Controls.Add(cbojenis)
        Panel1.Controls.Add(txtid)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(51, 223)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(649, 215)
        DataGridView1.TabIndex = 30
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(713, 415)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(75, 23)
        btnCetak.TabIndex = 29
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(713, 164)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 28
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(632, 164)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 27
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(551, 164)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(75, 23)
        btnCari.TabIndex = 26
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(470, 164)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 25
        btnDelete.Text = "Hapus"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtdouble
        ' 
        txtdouble.Location = New Point(469, 89)
        txtdouble.Name = "txtdouble"
        txtdouble.Size = New Size(201, 23)
        txtdouble.TabIndex = 24
        ' 
        ' txtno
        ' 
        txtno.Location = New Point(469, 118)
        txtno.Name = "txtno"
        txtno.Size = New Size(201, 23)
        txtno.TabIndex = 23
        ' 
        ' rbpan
        ' 
        rbpan.AutoSize = True
        rbpan.Location = New Point(127, 187)
        rbpan.Name = "rbpan"
        rbpan.Size = New Size(68, 19)
        rbpan.TabIndex = 22
        rbpan.TabStop = True
        rbpan.Text = "Panjang"
        rbpan.UseVisualStyleBackColor = True
        ' 
        ' rbbul
        ' 
        rbbul.AutoSize = True
        rbbul.Location = New Point(215, 162)
        rbbul.Name = "rbbul"
        rbbul.Size = New Size(52, 19)
        rbbul.TabIndex = 21
        rbbul.TabStop = True
        rbbul.Text = "Bulat"
        rbbul.UseVisualStyleBackColor = True
        ' 
        ' rbpen
        ' 
        rbpen.AutoSize = True
        rbpen.Location = New Point(127, 162)
        rbpen.Name = "rbpen"
        rbpen.Size = New Size(64, 19)
        rbpen.TabIndex = 20
        rbpen.TabStop = True
        rbpen.Text = "Pendek"
        rbpen.UseVisualStyleBackColor = True
        ' 
        ' cbojenis
        ' 
        cbojenis.FormattingEnabled = True
        cbojenis.Items.AddRange(New Object() {"3020", "3070", "3030", "Plate", "Bus"})
        cbojenis.Location = New Point(127, 127)
        cbojenis.Name = "cbojenis"
        cbojenis.Size = New Size(201, 23)
        cbojenis.TabIndex = 19
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(127, 89)
        txtid.Name = "txtid"
        txtid.Size = New Size(201, 23)
        txtid.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(402, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 17
        Label6.Text = "No Good :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(412, 92)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 16
        Label5.Text = "Double :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(64, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 15
        Label4.Text = "Kategori :"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(388, 164)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 14
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(37, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Material :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "ID Material :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(328, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 35)
        Label1.TabIndex = 0
        Label1.Text = "FORM SORTING"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbojenis As ComboBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtdouble As TextBox
    Friend WithEvents txtno As TextBox
    Friend WithEvents rbpan As RadioButton
    Friend WithEvents rbbul As RadioButton
    Friend WithEvents rbpen As RadioButton
End Class
