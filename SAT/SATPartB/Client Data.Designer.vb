<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client_Data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client_Data))
        Me.lblClientData = New System.Windows.Forms.Label()
        Me.btnBackC = New System.Windows.Forms.Button()
        Me.btnEnterSearch = New System.Windows.Forms.Button()
        Me.lbxClientSearch = New System.Windows.Forms.ListBox()
        Me.lblSearchCData = New System.Windows.Forms.Label()
        Me.tbxClientName = New System.Windows.Forms.TextBox()
        Me.lblClinetName = New System.Windows.Forms.Label()
        Me.lblNewClient = New System.Windows.Forms.Label()
        Me.lblClientIntro = New System.Windows.Forms.Label()
        Me.btnCDatabase = New System.Windows.Forms.Button()
        Me.lblSearchClient = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblClientData
        '
        Me.lblClientData.AutoSize = True
        Me.lblClientData.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblClientData.Font = New System.Drawing.Font("Candara Light", 64.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblClientData.Location = New System.Drawing.Point(1007, 92)
        Me.lblClientData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientData.Name = "lblClientData"
        Me.lblClientData.Size = New System.Drawing.Size(873, 211)
        Me.lblClientData.TabIndex = 2
        Me.lblClientData.Text = "Client Data"
        '
        'btnBackC
        '
        Me.btnBackC.Font = New System.Drawing.Font("Yu Gothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackC.Location = New System.Drawing.Point(132, 1478)
        Me.btnBackC.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnBackC.Name = "btnBackC"
        Me.btnBackC.Size = New System.Drawing.Size(260, 47)
        Me.btnBackC.TabIndex = 4
        Me.btnBackC.Text = " <-- Back Home"
        Me.btnBackC.UseVisualStyleBackColor = True
        '
        'btnEnterSearch
        '
        Me.btnEnterSearch.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEnterSearch.Location = New System.Drawing.Point(2515, 482)
        Me.btnEnterSearch.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnEnterSearch.Name = "btnEnterSearch"
        Me.btnEnterSearch.Size = New System.Drawing.Size(191, 47)
        Me.btnEnterSearch.TabIndex = 5
        Me.btnEnterSearch.Text = "Search"
        Me.btnEnterSearch.UseVisualStyleBackColor = True
        '
        'lbxClientSearch
        '
        Me.lbxClientSearch.Font = New System.Drawing.Font("Yu Gothic Medium", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbxClientSearch.FormattingEnabled = True
        Me.lbxClientSearch.ItemHeight = 35
        Me.lbxClientSearch.Location = New System.Drawing.Point(1894, 717)
        Me.lbxClientSearch.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lbxClientSearch.Name = "lbxClientSearch"
        Me.lbxClientSearch.Size = New System.Drawing.Size(868, 774)
        Me.lbxClientSearch.TabIndex = 9
        '
        'lblSearchCData
        '
        Me.lblSearchCData.AutoSize = True
        Me.lblSearchCData.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSearchCData.Location = New System.Drawing.Point(2080, 393)
        Me.lblSearchCData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchCData.Name = "lblSearchCData"
        Me.lblSearchCData.Size = New System.Drawing.Size(482, 61)
        Me.lblSearchCData.TabIndex = 10
        Me.lblSearchCData.Text = "Search Client Data:"
        '
        'tbxClientName
        '
        Me.tbxClientName.Location = New System.Drawing.Point(405, 624)
        Me.tbxClientName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.tbxClientName.Name = "tbxClientName"
        Me.tbxClientName.Size = New System.Drawing.Size(472, 39)
        Me.tbxClientName.TabIndex = 15
        '
        'lblClinetName
        '
        Me.lblClinetName.AutoSize = True
        Me.lblClinetName.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClinetName.Location = New System.Drawing.Point(156, 623)
        Me.lblClinetName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClinetName.Name = "lblClinetName"
        Me.lblClinetName.Size = New System.Drawing.Size(223, 42)
        Me.lblClinetName.TabIndex = 16
        Me.lblClinetName.Text = "Client Name:"
        '
        'lblNewClient
        '
        Me.lblNewClient.AutoSize = True
        Me.lblNewClient.Font = New System.Drawing.Font("Yu Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNewClient.Location = New System.Drawing.Point(249, 393)
        Me.lblNewClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNewClient.Name = "lblNewClient"
        Me.lblNewClient.Size = New System.Drawing.Size(564, 61)
        Me.lblNewClient.TabIndex = 21
        Me.lblNewClient.Text = "Enter New Client Data:"
        '
        'lblClientIntro
        '
        Me.lblClientIntro.Font = New System.Drawing.Font("Yu Gothic Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClientIntro.Location = New System.Drawing.Point(1070, 612)
        Me.lblClientIntro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClientIntro.Name = "lblClientIntro"
        Me.lblClientIntro.Size = New System.Drawing.Size(656, 465)
        Me.lblClientIntro.TabIndex = 22
        Me.lblClientIntro.Text = resources.GetString("lblClientIntro.Text")
        Me.lblClientIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCDatabase
        '
        Me.btnCDatabase.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCDatabase.Location = New System.Drawing.Point(345, 717)
        Me.btnCDatabase.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnCDatabase.Name = "btnCDatabase"
        Me.btnCDatabase.Size = New System.Drawing.Size(340, 113)
        Me.btnCDatabase.TabIndex = 26
        Me.btnCDatabase.Text = "Add to Database"
        Me.btnCDatabase.UseVisualStyleBackColor = True
        '
        'lblSearchClient
        '
        Me.lblSearchClient.AutoSize = True
        Me.lblSearchClient.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSearchClient.Location = New System.Drawing.Point(1920, 486)
        Me.lblSearchClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchClient.Name = "lblSearchClient"
        Me.lblSearchClient.Size = New System.Drawing.Size(441, 42)
        Me.lblSearchClient.TabIndex = 45
        Me.lblSearchClient.Text = "Search for client name -->"
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Yu Gothic Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblResults.Location = New System.Drawing.Point(2212, 580)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(134, 42)
        Me.lblResults.TabIndex = 46
        Me.lblResults.Text = "Results"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(85, 454)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(901, 169)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Enter the name of a new client below to add their order to the database"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Yu Gothic Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(2515, 559)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(191, 47)
        Me.btnClear.TabIndex = 48
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Client_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(2926, 1616)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lblSearchClient)
        Me.Controls.Add(Me.btnCDatabase)
        Me.Controls.Add(Me.lblClientIntro)
        Me.Controls.Add(Me.lblNewClient)
        Me.Controls.Add(Me.lblClinetName)
        Me.Controls.Add(Me.tbxClientName)
        Me.Controls.Add(Me.lblSearchCData)
        Me.Controls.Add(Me.lbxClientSearch)
        Me.Controls.Add(Me.btnEnterSearch)
        Me.Controls.Add(Me.btnBackC)
        Me.Controls.Add(Me.lblClientData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Client_Data"
        Me.Text = "Client_Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClientData As Label
    Friend WithEvents btnBackC As Button
    Friend WithEvents btnEnterSearch As Button
    Friend WithEvents lbxClientSearch As ListBox
    Friend WithEvents lblSearchCData As Label
    Friend WithEvents tbxClientName As TextBox
    Friend WithEvents lblClinetName As Label
    Friend WithEvents lblNewClient As Label
    Friend WithEvents lblClientIntro As Label
    Friend WithEvents btnCDatabase As Button
    Friend WithEvents lblSearchClient As Label
    Friend WithEvents lblResults As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
End Class
