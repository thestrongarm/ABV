<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userPortal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userPortal))
        Me.cbDropYear = New System.Windows.Forms.ComboBox()
        Me.cbDropMake = New System.Windows.Forms.ComboBox()
        Me.cbDropModel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.radNew = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbDropYear
        '
        Me.cbDropYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbDropYear.FormattingEnabled = True
        Me.cbDropYear.Items.AddRange(New Object() {"2018", "2017", "2016", "2015", "2014", "2013"})
        Me.cbDropYear.Location = New System.Drawing.Point(277, 90)
        Me.cbDropYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDropYear.Name = "cbDropYear"
        Me.cbDropYear.Size = New System.Drawing.Size(160, 24)
        Me.cbDropYear.TabIndex = 3
        Me.cbDropYear.Text = "Select the Year"
        '
        'cbDropMake
        '
        Me.cbDropMake.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbDropMake.FormattingEnabled = True
        Me.cbDropMake.Items.AddRange(New Object() {"Acura", "Honda"})
        Me.cbDropMake.Location = New System.Drawing.Point(489, 90)
        Me.cbDropMake.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDropMake.Name = "cbDropMake"
        Me.cbDropMake.Size = New System.Drawing.Size(160, 24)
        Me.cbDropMake.Sorted = True
        Me.cbDropMake.TabIndex = 4
        Me.cbDropMake.Text = "Select the Make"
        '
        'cbDropModel
        '
        Me.cbDropModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbDropModel.FormattingEnabled = True
        Me.cbDropModel.Location = New System.Drawing.Point(701, 90)
        Me.cbDropModel.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDropModel.Name = "cbDropModel"
        Me.cbDropModel.Size = New System.Drawing.Size(160, 24)
        Me.cbDropModel.TabIndex = 5
        Me.cbDropModel.Text = "Select the Model"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(536, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(743, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(329, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(909, 90)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 26)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'radNew
        '
        Me.radNew.AutoSize = True
        Me.radNew.Checked = True
        Me.radNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNew.ForeColor = System.Drawing.Color.White
        Me.radNew.Location = New System.Drawing.Point(96, 92)
        Me.radNew.Margin = New System.Windows.Forms.Padding(4)
        Me.radNew.Name = "radNew"
        Me.radNew.Size = New System.Drawing.Size(59, 21)
        Me.radNew.TabIndex = 11
        Me.radNew.TabStop = True
        Me.radNew.Text = "New"
        Me.radNew.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(171, 92)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(66, 21)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.Text = "Used"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(92, 25)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(331, 36)
        Me.lblStatus.TabIndex = 9
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'userPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1113, 705)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.radNew)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDropModel)
        Me.Controls.Add(Me.cbDropMake)
        Me.Controls.Add(Me.cbDropYear)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "userPortal"
        Me.Text = "Dealer Management - User "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbDropYear As ComboBox
    Friend WithEvents cbDropMake As ComboBox
    Friend WithEvents cbDropModel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents radNew As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblStatus As Label
End Class
