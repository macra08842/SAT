<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlantData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlantData))
        Me.lblPlantData = New System.Windows.Forms.Label()
        Me.btnBackP = New System.Windows.Forms.Button()
        Me.btnSearchPlants = New System.Windows.Forms.Button()
        Me.lblPlantsearch = New System.Windows.Forms.Label()
        Me.lblPlantName = New System.Windows.Forms.Label()
        Me.lblPlantIntro = New System.Windows.Forms.Label()
        Me.lblNewPlant = New System.Windows.Forms.Label()
        Me.tbxNameChange = New System.Windows.Forms.TextBox()
        Me.lblNameChange = New System.Windows.Forms.Label()
        Me.lblModifyData = New System.Windows.Forms.Label()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.btnClearModify = New System.Windows.Forms.Button()
        Me.lblSearchPlant = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lbxDataBase = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPlantNameN = New System.Windows.Forms.Label()
        Me.tbxNewPlant = New System.Windows.Forms.TextBox()
        Me.btnCleartbx = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPlantData
        '
        Me.lblPlantData.AutoSize = True
        Me.lblPlantData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlantData.Font = New System.Drawing.Font("Candara Light", 64.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlantData.Location = New System.Drawing.Point(975, 75)
        Me.lblPlantData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantData.Name = "lblPlantData"
        Me.lblPlantData.Size = New System.Drawing.Size(837, 211)
        Me.lblPlantData.TabIndex = 2
        Me.lblPlantData.Text = "Plant Data"
        '
        'btnBackP
        '
        Me.btnBackP.Font = New System.Drawing.Font("Yu Gothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackP.Location = New System.Drawing.Point(67, 1457)
        Me.btnBackP.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnBackP.Name = "btnBackP"
        Me.btnBackP.Size = New System.Drawing.Size(260, 47)
        Me.btnBackP.TabIndex = 4
        Me.btnBackP.Text = " <-- Back Home"
        Me.btnBackP.UseVisualStyleBackColor = True
        '
        'btnSearchPlants
        '
        Me.btnSearchPlants.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchPlants.Location = New System.Drawing.Point(2422, 478)
        Me.btnSearchPlants.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnSearchPlants.Name = "btnSearchPlants"
        Me.btnSearchPlants.Size = New System.Drawing.Size(150, 47)
        Me.btnSearchPlants.TabIndex = 5
        Me.btnSearchPlants.Text = "Search"
        Me.btnSearchPlants.UseVisualStyleBackColor = True
        '
        'lblPlantsearch
        '
        Me.lblPlantsearch.AutoSize = True
        Me.lblPlantsearch.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlantsearch.Location = New System.Drawing.Point(2078, 378)
        Me.lblPlantsearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantsearch.Name = "lblPlantsearch"
        Me.lblPlantsearch.Size = New System.Drawing.Size(401, 61)
        Me.lblPlantsearch.TabIndex = 10
        Me.lblPlantsearch.Text = "Plant Database:"
        '
        'lblPlantName
        '
        Me.lblPlantName.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlantName.Location = New System.Drawing.Point(316, 467)
        Me.lblPlantName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantName.Name = "lblPlantName"
        Me.lblPlantName.Size = New System.Drawing.Size(527, 213)
        Me.lblPlantName.TabIndex = 14
        Me.lblPlantName.Text = "Before adding a new plant to the database, make sure you know the plant's name, t" &
    "ype and quantity"
        Me.lblPlantName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlantIntro
        '
        Me.lblPlantIntro.Font = New System.Drawing.Font("Yu Gothic Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlantIntro.Location = New System.Drawing.Point(1020, 388)
        Me.lblPlantIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantIntro.Name = "lblPlantIntro"
        Me.lblPlantIntro.Size = New System.Drawing.Size(761, 772)
        Me.lblPlantIntro.TabIndex = 15
        Me.lblPlantIntro.Text = resources.GetString("lblPlantIntro.Text")
        Me.lblPlantIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNewPlant
        '
        Me.lblNewPlant.AutoSize = True
        Me.lblNewPlant.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewPlant.Location = New System.Drawing.Point(353, 378)
        Me.lblNewPlant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewPlant.Name = "lblNewPlant"
        Me.lblNewPlant.Size = New System.Drawing.Size(466, 61)
        Me.lblNewPlant.TabIndex = 19
        Me.lblNewPlant.Text = "Enter a New Plant:"
        '
        'tbxNameChange
        '
        Me.tbxNameChange.Location = New System.Drawing.Point(431, 1122)
        Me.tbxNameChange.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tbxNameChange.Name = "tbxNameChange"
        Me.tbxNameChange.Size = New System.Drawing.Size(559, 39)
        Me.tbxNameChange.TabIndex = 27
        '
        'lblNameChange
        '
        Me.lblNameChange.AutoSize = True
        Me.lblNameChange.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNameChange.Location = New System.Drawing.Point(186, 1120)
        Me.lblNameChange.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameChange.Name = "lblNameChange"
        Me.lblNameChange.Size = New System.Drawing.Size(212, 42)
        Me.lblNameChange.TabIndex = 30
        Me.lblNameChange.Text = "Plant Name:"
        '
        'lblModifyData
        '
        Me.lblModifyData.AutoSize = True
        Me.lblModifyData.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblModifyData.Location = New System.Drawing.Point(273, 1011)
        Me.lblModifyData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModifyData.Name = "lblModifyData"
        Me.lblModifyData.Size = New System.Drawing.Size(657, 61)
        Me.lblModifyData.TabIndex = 31
        Me.lblModifyData.Text = "Modify Current Plant Data:"
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnModify.Location = New System.Drawing.Point(247, 1225)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(210, 55)
        Me.btnModify.TabIndex = 34
        Me.btnModify.Text = "Update Data"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveNew.Location = New System.Drawing.Point(284, 766)
        Me.btnSaveNew.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(340, 113)
        Me.btnSaveNew.TabIndex = 39
        Me.btnSaveNew.Text = "Add to database"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'btnClearModify
        '
        Me.btnClearModify.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearModify.Location = New System.Drawing.Point(760, 1225)
        Me.btnClearModify.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClearModify.Name = "btnClearModify"
        Me.btnClearModify.Size = New System.Drawing.Size(210, 55)
        Me.btnClearModify.TabIndex = 41
        Me.btnClearModify.Text = "Clear"
        Me.btnClearModify.UseVisualStyleBackColor = True
        '
        'lblSearchPlant
        '
        Me.lblSearchPlant.AutoSize = True
        Me.lblSearchPlant.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSearchPlant.Location = New System.Drawing.Point(1941, 478)
        Me.lblSearchPlant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchPlant.Name = "lblSearchPlant"
        Me.lblSearchPlant.Size = New System.Drawing.Size(433, 42)
        Me.lblSearchPlant.TabIndex = 44
        Me.lblSearchPlant.Text = "Search for plant name -->"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResults.Location = New System.Drawing.Point(2126, 652)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(134, 42)
        Me.lblResults.TabIndex = 45
        Me.lblResults.Text = "Results"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbxDataBase
        '
        Me.lbxDataBase.Font = New System.Drawing.Font("Yu Gothic", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbxDataBase.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lbxDataBase.FormattingEnabled = True
        Me.lbxDataBase.ItemHeight = 35
        Me.lbxDataBase.Location = New System.Drawing.Point(1881, 800)
        Me.lbxDataBase.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lbxDataBase.Name = "lbxDataBase"
        Me.lbxDataBase.Size = New System.Drawing.Size(756, 599)
        Me.lbxDataBase.TabIndex = 46
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(2422, 550)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 47)
        Me.btnClear.TabIndex = 47
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblPlantNameN
        '
        Me.lblPlantNameN.AutoSize = True
        Me.lblPlantNameN.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPlantNameN.Location = New System.Drawing.Point(258, 670)
        Me.lblPlantNameN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlantNameN.Name = "lblPlantNameN"
        Me.lblPlantNameN.Size = New System.Drawing.Size(212, 42)
        Me.lblPlantNameN.TabIndex = 48
        Me.lblPlantNameN.Text = "Plant Name:"
        '
        'tbxNewPlant
        '
        Me.tbxNewPlant.Location = New System.Drawing.Point(505, 670)
        Me.tbxNewPlant.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tbxNewPlant.Name = "tbxNewPlant"
        Me.tbxNewPlant.Size = New System.Drawing.Size(400, 39)
        Me.tbxNewPlant.TabIndex = 49
        '
        'btnCleartbx
        '
        Me.btnCleartbx.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCleartbx.Location = New System.Drawing.Point(659, 766)
        Me.btnCleartbx.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnCleartbx.Name = "btnCleartbx"
        Me.btnCleartbx.Size = New System.Drawing.Size(210, 113)
        Me.btnCleartbx.TabIndex = 50
        Me.btnCleartbx.Text = "Clear"
        Me.btnCleartbx.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.Location = New System.Drawing.Point(505, 1225)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(210, 55)
        Me.btnDelete.TabIndex = 51
        Me.btnDelete.Text = "Delete Data"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'PlantData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(2910, 1632)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCleartbx)
        Me.Controls.Add(Me.tbxNewPlant)
        Me.Controls.Add(Me.lblPlantNameN)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lbxDataBase)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblSearchPlant)
        Me.Controls.Add(Me.btnClearModify)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.lblModifyData)
        Me.Controls.Add(Me.lblNameChange)
        Me.Controls.Add(Me.tbxNameChange)
        Me.Controls.Add(Me.lblNewPlant)
        Me.Controls.Add(Me.lblPlantIntro)
        Me.Controls.Add(Me.lblPlantName)
        Me.Controls.Add(Me.lblPlantsearch)
        Me.Controls.Add(Me.btnSearchPlants)
        Me.Controls.Add(Me.btnBackP)
        Me.Controls.Add(Me.lblPlantData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "PlantData"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlantData As Label
    Friend WithEvents btnBackP As Button
    Friend WithEvents btnSearchPlants As Button
    Friend WithEvents lbxPlantsData As ListBox
    Friend WithEvents lblPlantsearch As Label
    Friend WithEvents lblPlantName As Label
    Friend WithEvents lblPlantIntro As Label
    Friend WithEvents lblNewPlant As Label
    Friend WithEvents tbxNameChange As TextBox
    Friend WithEvents lblNameChange As Label
    Friend WithEvents lblModifyData As Label
    Friend WithEvents btnModify As Button
    Friend WithEvents btnSaveNew As Button
    Friend WithEvents btnClearModify As Button
    Friend WithEvents lblSearchPlant As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents lbxDataBase As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPlantNameN As Label
    Friend WithEvents tbxNewPlant As TextBox
    Friend WithEvents btnCleartbx As Button
    Friend WithEvents btnDelete As Button
End Class
