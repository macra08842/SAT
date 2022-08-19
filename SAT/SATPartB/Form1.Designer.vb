<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.btnPlants = New System.Windows.Forms.Button()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnManager = New System.Windows.Forms.Button()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblPlant = New System.Windows.Forms.Label()
        Me.lblManage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCopywright = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlants
        '
        Me.btnPlants.BackgroundImage = CType(resources.GetObject("btnPlants.BackgroundImage"), System.Drawing.Image)
        Me.btnPlants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlants.Font = New System.Drawing.Font("Tahoma", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlants.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnPlants.Location = New System.Drawing.Point(1079, 369)
        Me.btnPlants.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnPlants.Name = "btnPlants"
        Me.btnPlants.Size = New System.Drawing.Size(856, 730)
        Me.btnPlants.TabIndex = 0
        Me.btnPlants.UseVisualStyleBackColor = True
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTitle1.Font = New System.Drawing.Font("Candara Light", 64.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle1.Location = New System.Drawing.Point(808, 98)
        Me.lblTitle1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(1328, 211)
        Me.lblTitle1.TabIndex = 1
        Me.lblTitle1.Text = "Nursery Manager"
        '
        'btnClient
        '
        Me.btnClient.BackgroundImage = CType(resources.GetObject("btnClient.BackgroundImage"), System.Drawing.Image)
        Me.btnClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClient.Font = New System.Drawing.Font("Tahoma", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClient.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnClient.Location = New System.Drawing.Point(100, 369)
        Me.btnClient.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(908, 730)
        Me.btnClient.TabIndex = 2
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'btnManager
        '
        Me.btnManager.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnManager.Font = New System.Drawing.Font("Tahoma", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnManager.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnManager.Image = CType(resources.GetObject("btnManager.Image"), System.Drawing.Image)
        Me.btnManager.Location = New System.Drawing.Point(2015, 369)
        Me.btnManager.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnManager.Name = "btnManager"
        Me.btnManager.Size = New System.Drawing.Size(921, 730)
        Me.btnManager.TabIndex = 3
        Me.btnManager.UseVisualStyleBackColor = False
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.Font = New System.Drawing.Font("Yu Gothic", 10.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblClient.Location = New System.Drawing.Point(462, 1111)
        Me.lblClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(168, 38)
        Me.lblClient.TabIndex = 4
        Me.lblClient.Text = "Client Data"
        '
        'lblPlant
        '
        Me.lblPlant.AutoSize = True
        Me.lblPlant.Font = New System.Drawing.Font("Yu Gothic", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblPlant.Location = New System.Drawing.Point(1434, 1116)
        Me.lblPlant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlant.Name = "lblPlant"
        Me.lblPlant.Size = New System.Drawing.Size(149, 35)
        Me.lblPlant.TabIndex = 5
        Me.lblPlant.Text = "Plant Data"
        '
        'lblManage
        '
        Me.lblManage.AutoSize = True
        Me.lblManage.Font = New System.Drawing.Font("Yu Gothic", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblManage.Location = New System.Drawing.Point(2385, 1116)
        Me.lblManage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManage.Name = "lblManage"
        Me.lblManage.Size = New System.Drawing.Size(180, 35)
        Me.lblManage.TabIndex = 6
        Me.lblManage.Text = "Management"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(943, 1278)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1146, 48)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome to nursery Manager. Click on an icon above to begin."
        '
        'lblCopywright
        '
        Me.lblCopywright.AutoSize = True
        Me.lblCopywright.Font = New System.Drawing.Font("Yu Gothic Light", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblCopywright.ForeColor = System.Drawing.Color.Silver
        Me.lblCopywright.Location = New System.Drawing.Point(1995, 2319)
        Me.lblCopywright.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCopywright.Name = "lblCopywright"
        Me.lblCopywright.Size = New System.Drawing.Size(347, 35)
        Me.lblCopywright.TabIndex = 8
        Me.lblCopywright.Text = "Copywright S.MacRaild 2022"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(3036, 1546)
        Me.Controls.Add(Me.lblCopywright)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblManage)
        Me.Controls.Add(Me.lblPlant)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.btnManager)
        Me.Controls.Add(Me.btnClient)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.btnPlants)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "HomePage"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlants As Button
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents btnClient As Button
    Friend WithEvents btnManager As Button
    Friend WithEvents lblClient As Label
    Friend WithEvents lblPlant As Label
    Friend WithEvents lblManage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCopywright As Label
End Class
