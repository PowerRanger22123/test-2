Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim user As String = txtUser.Text
        Dim pass As String = txtPassword.Text

        ' Validasi sederhana
        If user = "admin" And pass = "admin123" Then
            MessageBox.Show("Login Berhasil! Selamat Datang.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Membuka Form1 dan menyembunyikan LoginForm
            Form1.Show()
            Me.Hide()
        ElseIf user = "" Or pass = "" Then
            MessageBox.Show("Harap isi username dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtUser.Focus()
        End If

    End Sub

    Private Sub btnlogin_Paint(sender As Object, e As PaintEventArgs) Handles btnlogin.Paint

    End Sub
End Class