<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.Location = New System.Drawing.Point(501, 512)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(214, 86)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.Location = New System.Drawing.Point(249, 274)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(189, 42)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPassword.Location = New System.Drawing.Point(249, 420)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(179, 42)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'tbxPassword
        '
        Me.tbxPassword.Location = New System.Drawing.Point(501, 423)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.Size = New System.Drawing.Size(448, 39)
        Me.tbxPassword.TabIndex = 3
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(501, 277)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(448, 39)
        Me.tbxUser.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Yu Gothic", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(425, 92)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(402, 96)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Welcome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please login to begin"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1228, 830)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents lblTitle As Label
End Class
