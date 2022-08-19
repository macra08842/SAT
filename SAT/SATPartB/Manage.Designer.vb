<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manage))
        Me.lblManagement = New System.Windows.Forms.Label()
        Me.btnBackM = New System.Windows.Forms.Button()
        Me.lblManageIntro = New System.Windows.Forms.Label()
        Me.lbxClientD = New System.Windows.Forms.ListBox()
        Me.lbxPlantD = New System.Windows.Forms.ListBox()
        Me.lblPlants = New System.Windows.Forms.Label()
        Me.lblClients = New System.Windows.Forms.Label()
        Me.lblSearchPlant = New System.Windows.Forms.Button()
        Me.btnSortC = New System.Windows.Forms.Button()
        Me.btnPSort = New System.Windows.Forms.Button()
        Me.btnSearchC = New System.Windows.Forms.Button()
        Me.btnClearPData = New System.Windows.Forms.Button()
        Me.btnClearCData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblManagement
        '
        Me.lblManagement.AutoSize = True
        Me.lblManagement.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblManagement.Font = New System.Drawing.Font("Candara Light", 64.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblManagement.Location = New System.Drawing.Point(999, 96)
        Me.lblManagement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManagement.Name = "lblManagement"
        Me.lblManagement.Size = New System.Drawing.Size(1060, 211)
        Me.lblManagement.TabIndex = 2
        Me.lblManagement.Text = "Management"
        '
        'btnBackM
        '
        Me.btnBackM.Font = New System.Drawing.Font("Yu Gothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackM.Location = New System.Drawing.Point(50, 1596)
        Me.btnBackM.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnBackM.Name = "btnBackM"
        Me.btnBackM.Size = New System.Drawing.Size(260, 47)
        Me.btnBackM.TabIndex = 3
        Me.btnBackM.Text = " <-- Back Home"
        Me.btnBackM.UseVisualStyleBackColor = True
        '
        'lblManageIntro
        '
        Me.lblManageIntro.Font = New System.Drawing.Font("Yu Gothic Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblManageIntro.Location = New System.Drawing.Point(1174, 433)
        Me.lblManageIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblManageIntro.Name = "lblManageIntro"
        Me.lblManageIntro.Size = New System.Drawing.Size(654, 806)
        Me.lblManageIntro.TabIndex = 4
        Me.lblManageIntro.Text = resources.GetString("lblManageIntro.Text")
        Me.lblManageIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbxClientD
        '
        Me.lbxClientD.Font = New System.Drawing.Font("Yu Gothic Medium", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbxClientD.FormattingEnabled = True
        Me.lbxClientD.ItemHeight = 35
        Me.lbxClientD.Location = New System.Drawing.Point(2034, 486)
        Me.lbxClientD.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lbxClientD.Name = "lbxClientD"
        Me.lbxClientD.Size = New System.Drawing.Size(934, 914)
        Me.lbxClientD.TabIndex = 7
        '
        'lbxPlantD
        '
        Me.lbxPlantD.Font = New System.Drawing.Font("Yu Gothic Medium", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbxPlantD.FormattingEnabled = True
        Me.lbxPlantD.ItemHeight = 35
        Me.lbxPlantD.Location = New System.Drawing.Point(123, 486)
        Me.lbxPlantD.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lbxPlantD.Name = "lbxPlantD"
        Me.lbxPlantD.Size = New System.Drawing.Size(934, 914)
        Me.lbxPlantD.TabIndex = 8
        '
        'lblPlants
        '
        Me.lblPlants.AutoSize = True
        Me.lblPlants.Font = New System.Drawing.Font("Yu Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlants.Location = New System.Drawing.Point(446, 333)
        Me.lblPlants.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlants.Name = "lblPlants"
        Me.lblPlants.Size = New System.Drawing.Size(290, 62)
        Me.lblPlants.TabIndex = 9
        Me.lblPlants.Text = "Plant Data:"
        '
        'lblClients
        '
        Me.lblClients.AutoSize = True
        Me.lblClients.Font = New System.Drawing.Font("Yu Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClients.Location = New System.Drawing.Point(2355, 333)
        Me.lblClients.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClients.Name = "lblClients"
        Me.lblClients.Size = New System.Drawing.Size(305, 62)
        Me.lblClients.TabIndex = 10
        Me.lblClients.Text = "Client Data:"
        '
        'lblSearchPlant
        '
        Me.lblSearchPlant.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSearchPlant.Location = New System.Drawing.Point(267, 412)
        Me.lblSearchPlant.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lblSearchPlant.Name = "lblSearchPlant"
        Me.lblSearchPlant.Size = New System.Drawing.Size(150, 47)
        Me.lblSearchPlant.TabIndex = 11
        Me.lblSearchPlant.Text = "Search Data"
        Me.lblSearchPlant.UseVisualStyleBackColor = True
        '
        'btnSortC
        '
        Me.btnSortC.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSortC.Location = New System.Drawing.Point(2448, 420)
        Me.btnSortC.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnSortC.Name = "btnSortC"
        Me.btnSortC.Size = New System.Drawing.Size(150, 47)
        Me.btnSortC.TabIndex = 12
        Me.btnSortC.Text = "Sort Data"
        Me.btnSortC.UseVisualStyleBackColor = True
        '
        'btnPSort
        '
        Me.btnPSort.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPSort.Location = New System.Drawing.Point(505, 412)
        Me.btnPSort.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnPSort.Name = "btnPSort"
        Me.btnPSort.Size = New System.Drawing.Size(150, 47)
        Me.btnPSort.TabIndex = 19
        Me.btnPSort.Text = "Sort Data"
        Me.btnPSort.UseVisualStyleBackColor = True
        '
        'btnSearchC
        '
        Me.btnSearchC.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchC.Location = New System.Drawing.Point(2247, 420)
        Me.btnSearchC.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnSearchC.Name = "btnSearchC"
        Me.btnSearchC.Size = New System.Drawing.Size(150, 47)
        Me.btnSearchC.TabIndex = 21
        Me.btnSearchC.Text = "Search Data"
        Me.btnSearchC.UseVisualStyleBackColor = True
        '
        'btnClearPData
        '
        Me.btnClearPData.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearPData.Location = New System.Drawing.Point(737, 412)
        Me.btnClearPData.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClearPData.Name = "btnClearPData"
        Me.btnClearPData.Size = New System.Drawing.Size(150, 47)
        Me.btnClearPData.TabIndex = 24
        Me.btnClearPData.Text = "Clear Database"
        Me.btnClearPData.UseVisualStyleBackColor = True
        '
        'btnClearCData
        '
        Me.btnClearCData.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearCData.Location = New System.Drawing.Point(2645, 420)
        Me.btnClearCData.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClearCData.Name = "btnClearCData"
        Me.btnClearCData.Size = New System.Drawing.Size(150, 47)
        Me.btnClearCData.TabIndex = 25
        Me.btnClearCData.Text = "Clear Database"
        Me.btnClearCData.UseVisualStyleBackColor = True
        '
        'Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(3118, 1720)
        Me.Controls.Add(Me.btnClearCData)
        Me.Controls.Add(Me.btnClearPData)
        Me.Controls.Add(Me.btnSearchC)
        Me.Controls.Add(Me.btnPSort)
        Me.Controls.Add(Me.btnSortC)
        Me.Controls.Add(Me.lblSearchPlant)
        Me.Controls.Add(Me.lblClients)
        Me.Controls.Add(Me.lblPlants)
        Me.Controls.Add(Me.lbxPlantD)
        Me.Controls.Add(Me.lbxClientD)
        Me.Controls.Add(Me.lblManageIntro)
        Me.Controls.Add(Me.btnBackM)
        Me.Controls.Add(Me.lblManagement)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Manage"
        Me.Text = "Manager's Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblManagement As Label
    Friend WithEvents btnBackM As Button
    Friend WithEvents lblManageIntro As Label
    Friend WithEvents lbxClientD As ListBox
    Friend WithEvents lbxPlantD As ListBox
    Friend WithEvents lblPlants As Label
    Friend WithEvents lblClients As Label
    Friend WithEvents lblSearchPlant As Button
    Friend WithEvents btnSortC As Button
    Friend WithEvents btnPSort As Button
    Friend WithEvents btnSearchC As Button
    Friend WithEvents btnClearPData As Button
    Friend WithEvents btnClearCData As Button
End Class
