Imports System.Formats.Tar
Imports System.IO

Public Class Form1

    Dim fileBuku As String = "buku.txt"
    Dim isNewFile As Boolean = True
    Dim isDirty As Boolean = False
    Dim siapDownload As Boolean = True

    Private Sub Input_Changed(sender As Object, e As EventArgs) Handles txtKode.TextChanged, txtJudul.TextChanged, cmbStatus.SelectedIndexChanged, TxtFile.TextChanged
        isDirty = True
    End Sub

    ' ===============================
    ' Procedure membaca data buku
    ' ===============================
    Sub BacaDataBuku()
        lvBuku.Items.Clear()

        If File.Exists(fileBuku) Then
            Dim data() As String = File.ReadAllLines(fileBuku)

            For Each baris As String In data
                If baris.Trim() <> "" Then
                    Dim pecah() As String = baris.Split(";"c)

                    Dim kode As String = pecah(0)
                    Dim judul As String = pecah(1)
                    Dim status As String = pecah(2)
                    Dim fileLampiran As String = pecah(3)

                    Dim keterangan As String
                    If status = "Tersedia" Then
                        keterangan = "Bisa Dipinjam"
                    Else
                        keterangan = "Sedang Dipinjam"
                    End If

                    Dim item As New ListViewItem(kode)
                    item.SubItems.Add(judul)
                    item.SubItems.Add(status)
                    item.SubItems.Add(keterangan)
                    item.SubItems.Add(Path.GetFileName(fileLampiran))

                    ' Simpan path file di Tag
                    item.Tag = fileLampiran

                    lvBuku.Items.Add(item)
                End If
            Next
        Else
            MessageBox.Show("File buku belum tersedia.")
        End If
    End Sub

    ' ===============================
    ' Procedure menyimpan data buku
    ' ===============================
    Sub SimpanDataBuku()
        If txtKode.Text = "" Or txtJudul.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Data belum lengkap!")
            Exit Sub
        End If

        Dim dataBaru As String = txtKode.Text & ";" & txtJudul.Text & ";" & cmbStatus.Text & ";" & TxtFile.Text

        File.AppendAllText(fileBuku, dataBaru & vbCrLf)

        isDirty = False
        siapDownload = False
        MessageBox.Show("Data berhasil disimpan!")

        txtKode.Clear()
        txtJudul.Clear()
        cmbStatus.SelectedIndex = -1
        BacaDataBuku()
    End Sub

    ' ===============================
    ' Pilih / Tambah File
    ' ===============================
    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Semua File|*.*|Text Files (*.txt)|*.txt"

            If ofd.ShowDialog() = DialogResult.OK Then
                ' Menampilkan path lengkap di textbox agar user tahu lokasinya
                TxtFile.Text = ofd.FileName

                ' Logika deteksi data lama (seperti permintaan sebelumnya)
                If Path.GetExtension(ofd.FileName).ToLower() = ".txt" Then
                    Dim tanya As DialogResult = MessageBox.Show("Buka sebagai data lama?", "Konfirmasi", MessageBoxButtons.YesNo)
                    If tanya = DialogResult.Yes Then
                        fileBuku = ofd.FileName
                        isNewFile = False
                        BacaDataBuku()
                        ' Path tetap ada di txtFile jika user ingin menggunakannya lagi
                    End If
                End If
            End If
            isDirty = False
        End Using
    End Sub

    ' ===============================
    ' Download File
    ' ===============================
    Private Sub btnDownloadSemua_Click(sender As Object, e As EventArgs) Handles btnDownloadSemua.Click
        ' 1. Validasi jika tabel kosong
        If lvBuku.Items.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk didownload.")
            Exit Sub
        End If

        Dim pathSimpan As String = ""

        ' 2. LOGIKA KONFIRMASI (Khusus File Lama)
        If isNewFile = False Then
            Dim tanya As DialogResult = MessageBox.Show("Pilih 'Yes' untuk Download As New (Ganti Nama)" & vbCrLf &
                                                    "Pilih 'No' untuk Overwrite (Tindih file lama ini)",
                                                    "Konfirmasi Download", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If tanya = DialogResult.Yes Then
                Using sfd As New SaveFileDialog
                    sfd.Filter = "Text File (*.txt)|*.txt"
                    If sfd.ShowDialog() = DialogResult.OK Then pathSimpan = sfd.FileName Else Exit Sub
                End Using
            ElseIf tanya = DialogResult.No Then
                pathSimpan = fileBuku
            Else
                Exit Sub
            End If
        Else
            ' Jika file baru, wajib pilih lokasi simpan
            Using sfd As New SaveFileDialog
                sfd.Filter = "Text File (*.txt)|*.txt"
                If sfd.ShowDialog() = DialogResult.OK Then pathSimpan = sfd.FileName Else Exit Sub
            End Using
        End If

        ' 3. PROSES EKSEKUSI DOWNLOAD
        Try
            ' AMBIL DATA DARI LISTVIEW (Agar tidak bentrok dengan proses lain)
            Dim barisData As New List(Of String)
            For Each item As ListViewItem In lvBuku.Items
                ' Format: Kode;Judul;Status;Path
                barisData.Add($"{item.Text};{item.SubItems(1).Text};{item.SubItems(2).Text};{item.Tag}")
            Next

            ' Tulis ke file TXT
            System.IO.File.WriteAllLines(pathSimpan, barisData)

            ' 4. RESET STATUS (Agar pop-up peringatan di Image 3b1b7f hilang)
            isDirty = False
            siapDownload = True

            MessageBox.Show("Berhasil didownload ke: " & System.IO.Path.GetFileName(pathSimpan))

            ' Buka folder tujuan
            Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(pathSimpan))

        Catch ex As Exception
            ' Menampilkan pesan error jika file sedang dibuka di Notepad
            MessageBox.Show("Kesalahan: " & ex.Message)
        End Try
    End Sub


    ' ===============================
    ' Event Button
    ' ===============================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        SimpanDataBuku()
    End Sub

    Sub ResetAplikasi()
        ' Kosongkan input
        txtKode.Clear()
        txtJudul.Clear()
        TxtFile.Clear()
        cmbStatus.SelectedIndex = -1

        ' Kosongkan ListView
        isDirty = False
        lvBuku.Items.Clear()
    End Sub


    ' ===============================
    ' Load Form
    ' ===============================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvBuku.View = View.Details
        lvBuku.FullRowSelect = True
        lvBuku.GridLines = True

        lvBuku.Columns.Clear()
        lvBuku.Columns.Add("Kode Buku", 100)
        lvBuku.Columns.Add("Judul Buku", 200)
        lvBuku.Columns.Add("Status", 100)
        lvBuku.Columns.Add("Keterangan", 150)


        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Tersedia")
        cmbStatus.Items.Add("Dipinjam")
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList

        ' 🔥 RESET FILE DATA (INI YANG KURANG)
        If File.Exists(fileBuku) Then
            File.WriteAllText(fileBuku, "")
        End If

        ' Reset tampilan
        ResetAplikasi()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isDirty Then
            Dim tanya As DialogResult = MessageBox.Show("Ada perubahan yang belum disimpan. Tetap keluar?",
                                                    "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            ' Jika user pilih 'No', maka pembatalan penutupan aplikasi
            If tanya = DialogResult.No Then
                e.Cancel = True
            End If
            Application.Exit()
        End If
    End Sub
    Private Sub cmbStatus_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbStatus.SelectionChangeCommitted

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If lvBuku.SelectedItems.Count > 0 Then
            For i As Integer = lvBuku.SelectedItems.Count - 1 To 0 Step -1
                lvBuku.Items.Remove(lvBuku.SelectedItems(i))
            Next
            ' Jangan panggil fungsi tulis file di sini agar tidak memicu error "Process access"
            isDirty = True
            siapDownload = False
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class
