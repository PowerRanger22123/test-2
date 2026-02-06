<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewItem1 As ListViewItem = New ListViewItem("")
        txtKode = New TextBox()
        txtJudul = New TextBox()
        cmbStatus = New ComboBox()
        btnTambah = New Button()
        btnAddFile = New Button()
        lvBuku = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnDownloadSemua = New Button()
        TxtFile = New TextBox()
        BtnHapus = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(110, 25)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(265, 23)
        txtKode.TabIndex = 0
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(110, 70)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(265, 23)
        txtJudul.TabIndex = 1
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.Items.AddRange(New Object() {"Dipinjam", "Tersedia"})
        cmbStatus.Location = New Point(110, 115)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(164, 23)
        cmbStatus.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.Cursor = Cursors.Hand
        btnTambah.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), Image)
        btnTambah.ImageAlign = ContentAlignment.MiddleLeft
        btnTambah.Location = New Point(451, 27)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(330, 53)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah Dan Simpan"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnAddFile
        ' 
        btnAddFile.Cursor = Cursors.Hand
        btnAddFile.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddFile.Image = CType(resources.GetObject("btnAddFile.Image"), Image)
        btnAddFile.ImageAlign = ContentAlignment.MiddleLeft
        btnAddFile.Location = New Point(451, 95)
        btnAddFile.Name = "btnAddFile"
        btnAddFile.Size = New Size(330, 53)
        btnAddFile.TabIndex = 4
        btnAddFile.Text = "Add File"
        btnAddFile.UseVisualStyleBackColor = True
        ' 
        ' lvBuku
        ' 
        lvBuku.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lvBuku.Items.AddRange(New ListViewItem() {ListViewItem1})
        lvBuku.Location = New Point(12, 167)
        lvBuku.Name = "lvBuku"
        lvBuku.Size = New Size(621, 271)
        lvBuku.TabIndex = 5
        lvBuku.UseCompatibleStateImageBehavior = False
        lvBuku.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Kode Buku"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Judul Buku"
        ColumnHeader2.Width = 200
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Status"
        ColumnHeader3.Width = 200
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(9, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 19)
        Label1.TabIndex = 6
        Label1.Text = "Kode Buku :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(9, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 19)
        Label2.TabIndex = 7
        Label2.Text = "Judul Buku :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 19)
        Label3.TabIndex = 8
        Label3.Text = "Status"
        ' 
        ' btnDownloadSemua
        ' 
        btnDownloadSemua.Cursor = Cursors.Hand
        btnDownloadSemua.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDownloadSemua.Image = CType(resources.GetObject("btnDownloadSemua.Image"), Image)
        btnDownloadSemua.ImageAlign = ContentAlignment.MiddleLeft
        btnDownloadSemua.Location = New Point(639, 391)
        btnDownloadSemua.Name = "btnDownloadSemua"
        btnDownloadSemua.Size = New Size(368, 47)
        btnDownloadSemua.TabIndex = 10
        btnDownloadSemua.Text = "Save As File"
        btnDownloadSemua.UseVisualStyleBackColor = True
        ' 
        ' TxtFile
        ' 
        TxtFile.AccessibleRole = AccessibleRole.Document
        TxtFile.Location = New Point(639, 350)
        TxtFile.Name = "TxtFile"
        TxtFile.ReadOnly = True
        TxtFile.Size = New Size(367, 23)
        TxtFile.TabIndex = 11
        ' 
        ' BtnHapus
        ' 
        BtnHapus.Cursor = Cursors.Hand
        BtnHapus.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), Image)
        BtnHapus.ImageAlign = ContentAlignment.MiddleLeft
        BtnHapus.Location = New Point(639, 268)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(364, 67)
        BtnHapus.TabIndex = 12
        BtnHapus.Text = "Hapus Buku"
        BtnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(873, 24)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(130, 23)
        btnLogout.TabIndex = 13
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AcceptButton = btnTambah
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Sienna
        ClientSize = New Size(1019, 450)
        Controls.Add(btnLogout)
        Controls.Add(BtnHapus)
        Controls.Add(TxtFile)
        Controls.Add(btnDownloadSemua)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lvBuku)
        Controls.Add(btnAddFile)
        Controls.Add(btnTambah)
        Controls.Add(cmbStatus)
        Controls.Add(txtJudul)
        Controls.Add(txtKode)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "APLIKASI DATA PEIMINJAMAN PERPUSTAKAAN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnAddFile As Button
    Friend WithEvents lvBuku As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnDownloadSemua As Button
    Friend WithEvents TxtFile As TextBox
    Friend WithEvents BtnHapus As Button
    Friend WithEvents btnLogout As Button

End Class
