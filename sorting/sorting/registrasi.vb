Imports System.Data.Odbc

Public Class registrasi
    Dim conn As OdbcConnection
    Sub koneksi()
        Dim str As String = "Driver={MySQL ODBC 3.51 Driver};Database=sorting;Server=localhost;uid=root;password=;"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub registrasi_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            koneksi()
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)
            Dim query As String = "INSERT INTO login (Username, Password) VALUES (?, ?)"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)
            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Registrasi berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Form1.Show()
            Else
                MessageBox.Show("Registrasi gagal!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Close()
        Form1.Show()
    End Sub


End Class
