<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        txtUser = New TextBox()
        txtPassword = New TextBox()
        lblUser = New Label()
        lblPassword = New Label()
        Label1 = New Label()
        btnlogin = New Button()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.Silver
        txtUser.BorderStyle = BorderStyle.None
        txtUser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUser.Location = New Point(177, 175)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(380, 22)
        txtUser.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Silver
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(177, 212)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(379, 22)
        txtPassword.TabIndex = 1
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.BackColor = Color.White
        lblUser.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.Location = New Point(53, 175)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(118, 21)
        lblUser.TabIndex = 2
        lblUser.Text = "USERNAME : "
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(58, 216)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(113, 21)
        lblPassword.TabIndex = 3
        lblPassword.Text = "PASSWORD: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Coral
        Label1.Font = New Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(562, 35)
        Label1.TabIndex = 4
        Label1.Text = "MASUKAN USERNAME DAN PASSWORD"
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = SystemColors.ActiveBorder
        btnlogin.Cursor = Cursors.Hand
        btnlogin.Location = New Point(274, 262)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(145, 38)
        btnlogin.TabIndex = 5
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AcceptButton = btnlogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(618, 642)
        Controls.Add(btnlogin)
        Controls.Add(Label1)
        Controls.Add(lblPassword)
        Controls.Add(lblUser)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin As Button
End Class
