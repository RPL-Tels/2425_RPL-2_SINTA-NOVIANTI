Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Data
Imports System.Drawing.Printing
Public Class Form3
    Dim conn As OdbcConnection
    Public IsAdmin As Boolean = True
    Sub koneksi()
        Dim str As String = "Driver={Mysql ODBC 3.51 Driver};Database=sorting;Server=localhost;uid=root"
        conn = New OdbcConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub TampilkanData()
        Try
            Dim query As String = "SELECT * FROM sorting_material"
            Dim adapter As New OdbcDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilkanData()
        If IsAdmin Then
            btnCetak.Enabled = False
            btnCetak.Visible = False
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtid.Text = "" Or txtdouble.Text = "" Or txtno.Text = "" Then
                MessageBox.Show("Semua kolom harus di isi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If cbojenis.SelectedItem Is Nothing Then
                MessageBox.Show("Pilih jenis material!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If Not (rbpen.Checked Or rbpan.Checked Or rbbul.Checked) Then
                MessageBox.Show("Pilih kategori material!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim kategori As String = ""
            If rbpen.Checked Then
                kategori = "Pendek"
            ElseIf rbpan.Checked Then
                kategori = "Panjang"
            ElseIf rbbul.Checked Then
                kategori = "Bulet"
            End If
            Dim query As String = "INSERT INTO sorting_material (ID_Material, Jenis_Material, Kategori, Double_, No_Good) VALUES (?, ?, ?, ?, ?)"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", txtid.Text)
            cmd.Parameters.AddWithValue("?", cbojenis.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("?", kategori)
            cmd.Parameters.AddWithValue("?", txtdouble.Text)
            cmd.Parameters.AddWithValue("?", txtno.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Clear()
            txtdouble.Clear()
            txtno.Clear()
            cbojenis.SelectedIndex = -1
            rbpen.Checked = False
            rbpan.Checked = False
            rbbul.Checked = False
            TampilkanData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim idMaterial As String = InputBox("Masukkan ID Material yang ingin dicari:", "Cari ID Material")
        If String.IsNullOrEmpty(idMaterial) Then
            MessageBox.Show("ID Material harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim query As String = "SELECT * FROM sorting_material WHERE ID_Material = ?"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", idMaterial)
            Dim adapter As New OdbcDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                txtid.Text = table.Rows(0)("ID_Material").ToString()
                cbojenis.SelectedItem = table.Rows(0)("Jenis_Material").ToString()
                If table.Rows(0)("Kategori").ToString() = "Pendek" Then
                    rbpen.Checked = True
                ElseIf table.Rows(0)("Kategori").ToString() = "Panjang" Then
                    rbpan.Checked = True
                ElseIf table.Rows(0)("Kategori").ToString() = "Bulet" Then
                    rbbul.Checked = True
                End If
                txtdouble.Text = table.Rows(0)("Double_").ToString()
                txtno.Text = table.Rows(0)("No_Good").ToString()
            Else
                MessageBox.Show("Data dengan ID Material " & idMaterial & " tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim idMaterial As String = InputBox("Masukkan ID Material yang ingin dihapus:", "Hapus ID Material")
        If String.IsNullOrEmpty(idMaterial) Then
            MessageBox.Show("ID Material harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim query As String = "DELETE FROM sorting_material WHERE ID_Material = ?"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", idMaterial)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data dengan ID Material " & idMaterial & " berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Clear()
            txtdouble.Clear()
            txtno.Clear()
            cbojenis.SelectedIndex = -1
            rbpen.Checked = False
            rbpan.Checked = False
            rbbul.Checked = False
            TampilkanData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim idMaterial As String = InputBox("Masukkan ID Material yang ingin diedit:", "Edit ID Material")
        If String.IsNullOrEmpty(idMaterial) Then
            MessageBox.Show("ID Material harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim kategori As String = ""
            If rbpen.Checked Then
                kategori = "Pendek"
            ElseIf rbpan.Checked Then
                kategori = "Panjang"
            ElseIf rbbul.Checked Then
                kategori = "Bulet"
            End If

            Dim query As String = "UPDATE sorting_material SET Jenis_Material = ?, Stok = ?, Tanggal_Bulan = ?, Kategori = ?, Double_ = ?, No_Good = ? WHERE ID_Material = ?"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", cbojenis.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("?", kategori)
            cmd.Parameters.AddWithValue("?", txtdouble.Text)
            cmd.Parameters.AddWithValue("?", txtno.Text)
            cmd.Parameters.AddWithValue("?", idMaterial)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data dengan ID Material " & idMaterial & " berhasil diupdate.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Clear()
            txtdouble.Clear()
            txtno.Clear()
            cbojenis.SelectedIndex = -1
            rbpen.Checked = False
            rbpan.Checked = False
            rbbul.Checked = False
            TampilkanData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private WithEvents PrintDoc As New PrintDocument
    Private PrintFont As New Font("Times New Roman", 12)
    Private DataGridRowIndex As Integer = 0

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        MessageBox.Show("IsAdmin value: " & IsAdmin.ToString())
        If IsAdmin Then
            MessageBox.Show("Admin tidak diperbolehkan mencetak laporan!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim previewDialog As New PrintPreviewDialog
        previewDialog.Document = PrintDoc
        previewDialog.ShowDialog()
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDoc
        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDoc.Print()
        End If
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f9 As New Font("Times New Roman", 12, FontStyle.Bold)
        Dim f8 As New Font("Times New Roman", 16, FontStyle.Bold)
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim pageWidth As Integer = e.MarginBounds.Width
        Dim tengah As New StringFormat With {.Alignment = StringAlignment.Center}
        Dim logoPath As String = Application.StartupPath & "\Resources\logo.jpg"
        If IO.File.Exists(logoPath) Then
            Dim logo As Image = Image.FromFile(logoPath)
            Dim logoWidth As Integer = 200
            Dim logoHeight As Integer = 100
            e.Graphics.DrawImage(logo, leftMargin, topMargin, logoWidth, logoHeight)
        End If
        Dim companyName As String = "PT Surteckariya Indonesia"
        Dim companyAddress As String = "Kawasan Industri Gobel," & vbCrLf &
                                "Jalan Teuku Umar KM. 29, Telaga Asih, Kec. Cikarang Barat," & vbCrLf &
                                "Kabupaten Bekasi, Jawa Barat"
        e.Graphics.DrawString(companyName, f8, Brushes.Black, New RectangleF(leftMargin, topMargin + 110, pageWidth, 40), tengah)
        e.Graphics.DrawString(companyAddress, f10, Brushes.Black, New RectangleF(leftMargin, topMargin + 150, pageWidth, 60), tengah)
        e.Graphics.DrawLine(Pens.Black, leftMargin, topMargin + 210, leftMargin + pageWidth, topMargin + 210)
        Dim rowHeight As Integer = 30
        Dim currentY As Integer = topMargin + 240
        e.Graphics.DrawString("ID_Material", f9, Brushes.Black, leftMargin, currentY)
        e.Graphics.DrawString("Jenis_Material", f9, Brushes.Black, leftMargin + 100, currentY)
        e.Graphics.DrawString("Kategori", f9, Brushes.Black, leftMargin + 250, currentY)
        e.Graphics.DrawString("Double_", f9, Brushes.Black, leftMargin + 350, currentY)
        e.Graphics.DrawString("No_Good", f9, Brushes.Black, leftMargin + 500, currentY)
        currentY += rowHeight
        While DataGridRowIndex < DataGridView1.Rows.Count
            Dim row As DataGridViewRow = DataGridView1.Rows(DataGridRowIndex)
            If row.IsNewRow Then
                DataGridRowIndex += 1
                Continue While
            End If

            e.Graphics.DrawString(row.Cells("ID_Material").Value?.ToString(), f10, Brushes.Black, leftMargin, currentY)
            e.Graphics.DrawString(row.Cells("Jenis_Material").Value?.ToString(), f10, Brushes.Black, leftMargin + 100, currentY)
            e.Graphics.DrawString(row.Cells("Kategori").Value?.ToString(), f10, Brushes.Black, leftMargin + 250, currentY)
            e.Graphics.DrawString(row.Cells("Double_").Value?.ToString(), f10, Brushes.Black, leftMargin + 350, currentY)
            e.Graphics.DrawString(row.Cells("No_Good").Value?.ToString(), f10, Brushes.Black, leftMargin + 500, currentY)
            currentY += rowHeight
            DataGridRowIndex += 1
            If currentY > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        End While
        DataGridRowIndex = 0
        e.HasMorePages = False
        currentY = e.MarginBounds.Bottom - 120
        Dim tandaTanganX As Integer = leftMargin + pageWidth - 200
        e.Graphics.DrawString("Mengetahui,", f10, Brushes.Black, tandaTanganX, currentY)
        Dim jedaAntarBaris As Integer = 80
        e.Graphics.DrawString("_____________________", f10, Brushes.Black, tandaTanganX, currentY + jedaAntarBaris)
        e.Graphics.DrawString("Divisi Produksi", f10, Brushes.Black, tandaTanganX, currentY + jedaAntarBaris + 20)
        Dim printDate As String = "Tanggal Cetak: " & DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
        e.Graphics.DrawString(printDate, f10, Brushes.Black, tandaTanganX, currentY + jedaAntarBaris + 100)
        DataGridRowIndex = 0
        e.HasMorePages = False
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            registrasi.Show()
        End If

    End Sub
End Class