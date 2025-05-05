Imports System.Data.Odbc
Imports System.Data
Imports System.Drawing.Printing


Public Class input_data
    Private WithEvents PD As New PrintDocument
    Dim conn As OdbcConnection
    Dim command As OdbcCommand
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Public IsAdmin As Boolean = True

    Sub koneksi()
        Try
            Dim str As String = "Driver={MySQL ODBC 3.51 Driver};Database=sorting;Server=localhost;Uid=root;Pwd=;"
            conn = New OdbcConnection(str)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub TampilkanData()
        Try
            Dim query As String = "SELECT * FROM input_data"
            Dim adapter As New OdbcDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub input_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        TampilkanData()
        If IsAdmin Then
            btncetak.Enabled = False
            btncetak.Visible = False
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtid.Text = "" Or txtstok.Text = "" Or txttgl.Text = "" Then
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If Not (rbgo.Checked Or rbter.Checked) Then
                MessageBox.Show("Pilih jenis material!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If Not (rbham.Checked Or rbrhy.Checked) Then
                MessageBox.Show("Pilih supplier!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim Nama_Material As String
            If rbgo.Checked Then
                Nama_Material = "Go No Go"
            Else
                Nama_Material = "Terminal"
            End If
            Dim Supplier As String
            If rbham.Checked Then
                Supplier = "PT HAMDEN INDONESIA"
            Else
                Supplier = "PT RHYTHM KYOSIN INDONESIA"
            End If
            Dim query As String = "INSERT INTO input_data (ID_Material, Nama_Material, Stok, Tanggal_Bulan, Supplier) VALUES (?, ?, ?, ?, ?)"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", txtid.Text)
            cmd.Parameters.AddWithValue("?", Nama_Material)
            cmd.Parameters.AddWithValue("?", txtstok.Text)
            cmd.Parameters.AddWithValue("?", txttgl.Text)
            cmd.Parameters.AddWithValue("?", Supplier)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Clear()
            txtstok.Clear()
            txttgl.Clear()
            rbgo.Checked = False
            rbter.Checked = False
            rbham.Checked = False
            rbrhy.Checked = False
            TampilkanData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim idMaterial As String = InputBox("Masukkan ID_Material yang ingin dicari:", "Cari ID Material")
        If String.IsNullOrEmpty(idMaterial) Then
            MessageBox.Show("ID Material harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim query As String = "SELECT * FROM input_data WHERE ID_Material = ?"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", idMaterial)
            Dim adapter As New OdbcDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count > 0 Then
                txtid.Text = table.Rows(0)("ID_Material").ToString()
                txtstok.Text = table.Rows(0)("Stok").ToString()
                txttgl.Text = table.Rows(0)("Tanggal_Bulan").ToString()
                If table.Rows(0)("Nama_Material").ToString() = "Go No Go" Then
                    rbgo.Checked = True
                Else
                    rbter.Checked = True
                End If
                If table.Rows(0)("Supplier").ToString() = "PT HAMDEN INDONESIA" Then
                    rbham.Checked = True
                Else
                    rbrhy.Checked = True
                End If
            Else
                MessageBox.Show("Data dengan ID_Material " & idMaterial & " tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim idMaterial As String = InputBox("Masukkan ID_Material yang ingin dihapus:", "Hapus ID Material")
        If String.IsNullOrEmpty(idMaterial) Then
            MessageBox.Show("ID Material harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim query As String = "DELETE FROM input_data WHERE ID_Material = ?"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", idMaterial)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data dengan ID Material " & idMaterial & " berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Clear()
            txtstok.Clear()
            txttgl.Clear()
            rbgo.Checked = False
            rbter.Checked = False
            rbham.Checked = False
            rbrhy.Checked = False
            TampilkanData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim idMaterial As String = InputBox("Masukkan ID_Material yang ingin diedit:", "Edit ID Material")
        If String.IsNullOrEmpty(idMaterial) Then
            MessageBox.Show("ID Material harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim Nama_Material As String = If(rbgo.Checked, "Go No Go", "Terminal")
            Dim Supplier As String = If(rbham.Checked, "PT HAMDEN INDONESIA", "PT RHYTHM KYOSIN INDONESIA")
            Dim query As String = "UPDATE input_data SET Nama_Material = ?, Stok = ?, Tanggal_Bulan = ?, Supplier = ? WHERE ID_Material = ?"
            Dim cmd As New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", Nama_Material)
            cmd.Parameters.AddWithValue("?", txtstok.Text)
            cmd.Parameters.AddWithValue("?", txttgl.Text)
            cmd.Parameters.AddWithValue("?", Supplier)
            cmd.Parameters.AddWithValue("?", idMaterial)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data dengan ID_Material " & idMaterial & " berhasil diupdate.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtid.Clear()
            txtstok.Clear()
            txttgl.Clear()
            rbgo.Checked = False
            rbter.Checked = False
            rbham.Checked = False
            rbrhy.Checked = False
            TampilkanData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari form ini?", "Konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Dim pindah As DialogResult = MessageBox.Show("Apakah Anda ingin melanjutkan ke form berikutnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If pindah = DialogResult.Yes Then
                Form3.Show()
            End If
            Me.Close()
        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Anda memilih untuk tetap di form ini.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Anda membatalkan tindakan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private WithEvents PrintDoc As New PrintDocument
    Private PrintFont As New Font("Times New Roman", 12)
    Private DataGridRowIndex As Integer = 0
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
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
        Dim kanan As New StringFormat With {.Alignment = StringAlignment.Far}
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
        e.Graphics.DrawString("Nama_Material", f9, Brushes.Black, leftMargin + 100, currentY)
        e.Graphics.DrawString("Stok", f9, Brushes.Black, leftMargin + 250, currentY)
        e.Graphics.DrawString("Tanggal_Bulan", f9, Brushes.Black, leftMargin + 350, currentY)
        e.Graphics.DrawString("Supplier", f9, Brushes.Black, leftMargin + 500, currentY)
        currentY += rowHeight
        While DataGridRowIndex < DataGridView1.Rows.Count
            Dim row As DataGridViewRow = DataGridView1.Rows(DataGridRowIndex)
            If row.IsNewRow Then
                DataGridRowIndex += 1
                Continue While
            End If
            e.Graphics.DrawString(row.Cells("ID_Material").Value?.ToString(), f10, Brushes.Black, leftMargin, currentY)
            e.Graphics.DrawString(row.Cells("Nama_Material").Value?.ToString(), f10, Brushes.Black, leftMargin + 100, currentY)
            e.Graphics.DrawString(row.Cells("Stok").Value?.ToString(), f10, Brushes.Black, leftMargin + 250, currentY)
            e.Graphics.DrawString(row.Cells("Tanggal_Bulan").Value?.ToString(), f10, Brushes.Black, leftMargin + 350, currentY)
            e.Graphics.DrawString(row.Cells("Supplier").Value?.ToString(), f10, Brushes.Black, leftMargin + 500, currentY)
            currentY += rowHeight
            DataGridRowIndex += 1
            If currentY > e.MarginBounds.Bottom - 150 Then
                e.HasMorePages = True
                Return
            End If
        End While
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
End Class






