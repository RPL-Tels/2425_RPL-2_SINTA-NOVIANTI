<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrasi
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
        Label5 = New Label()
        btnLogin = New Button()
        btnSimpan = New Button()
        chkShowPassword = New CheckBox()
        Label4 = New Label()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtKonfirmasi = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        Label1 = New Label()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(chkShowPassword)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtKonfirmasi)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtUsername)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(592, 348)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 15)
        Label5.TabIndex = 11
        Label5.Text = "Sudah punya akun ?" & vbCrLf
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(711, 344)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 10
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(711, 313)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 9
        btnSimpan.Text = "DAFTAR"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(627, 287)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(133, 19)
        chkShowPassword.TabIndex = 8
        chkShowPassword.Text = "Tampilkan password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(604, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 30)
        Label4.TabIndex = 7
        Label4.Text = "LOGIN"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(629, 224)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(137, 23)
        txtPassword.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(509, 227)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 15)
        Label3.TabIndex = 5
        Label3.Text = "Masukan Password :"
        ' 
        ' txtKonfirmasi
        ' 
        txtKonfirmasi.Location = New Point(629, 253)
        txtKonfirmasi.Name = "txtKonfirmasi"
        txtKonfirmasi.Size = New Size(137, 23)
        txtKonfirmasi.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(500, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 15)
        Label2.TabIndex = 3
        Label2.Text = "Konfirmasi Password :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(629, 195)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(137, 23)
        txtUsername.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(506, 198)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 15)
        Label1.TabIndex = 1
        Label1.Text = "Masukan Username :"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(522, 37)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(232, 70)
        Panel3.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.logo
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(232, 70)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(465, 450)
        Panel2.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.icon
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(465, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' registrasi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "registrasi"
        Text = "registrasi"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKonfirmasi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents chkShowPassword As CheckBox
End Class
