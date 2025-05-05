Imports System.Data.Odbc
Public Class Form1
    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim isAdmin As Boolean = False
    Sub koneksi()
        Dim str As String = "Driver={MySQL ODBC 3.51 Driver};Database=sorting;Server=localhost;uid=root;password=;"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtPassword.UseSystemPasswordChar = True
        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda admin? Pilih Yes untuk admin, No untuk user.", "Konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            isAdmin = True
            btnDaftar.Visible = False
            Label6.Visible = False
            MessageBox.Show("Mode Admin diaktifkan. Hanya Admin dapat login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf hasil = DialogResult.No Then
            isAdmin = False
            btnDaftar.Visible = True
            MessageBox.Show("Mode User diaktifkan. Hanya User dapat login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Application.Exit()
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            koneksi()
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If isAdmin Then
                If txtUsername.Text.ToLower() = "admin" And txtPassword.Text = "admin1" Then
                    MessageBox.Show("Selamat Datang Admin!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    input_data.Show()
                Else
                    MessageBox.Show("Hanya Admin yang dapat login dalam mode ini!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If txtUsername.Text.ToLower() = "admin" Then
                    MessageBox.Show("Admin tidak dapat login dalam mode User!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                Dim query As String = "SELECT Password FROM login WHERE Username = ?"
                Dim cmd As New OdbcCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                Dim reader As OdbcDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim hashedPassword As String = reader("Password").ToString()
                    If BCrypt.Net.BCrypt.Verify(txtPassword.Text, hashedPassword) Then
                        MessageBox.Show("Selamat Datang User!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        input_data.Show()
                    Else
                        MessageBox.Show("Password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Akun tidak ditemukan! Silakan daftar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If isAdmin Then
            MessageBox.Show("Admin tidak dapat mengakses halaman registrasi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim register As New registrasi()
            register.Show()
            Me.Hide()
        End If
    End Sub
End Class
