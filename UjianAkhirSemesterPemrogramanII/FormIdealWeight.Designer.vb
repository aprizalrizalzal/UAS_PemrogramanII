<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIdealWeight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIdealWeight))
        Me.GrbSelectGender = New System.Windows.Forms.GroupBox()
        Me.LblKg = New System.Windows.Forms.Label()
        Me.RadioBtnFemale = New System.Windows.Forms.RadioButton()
        Me.TbWeightNow = New System.Windows.Forms.TextBox()
        Me.LblWightNow = New System.Windows.Forms.Label()
        Me.RadioBtnMale = New System.Windows.Forms.RadioButton()
        Me.LblCm = New System.Windows.Forms.Label()
        Me.BtnResult = New System.Windows.Forms.Button()
        Me.TbHeight = New System.Windows.Forms.TextBox()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.GrbResult = New System.Windows.Forms.GroupBox()
        Me.LblResultGender = New System.Windows.Forms.Label()
        Me.LblResultWeightNow = New System.Windows.Forms.Label()
        Me.LblResultHeight = New System.Windows.Forms.Label()
        Me.LblResultAge = New System.Windows.Forms.Label()
        Me.LblResultName = New System.Windows.Forms.Label()
        Me.LblBMIInformation = New System.Windows.Forms.Label()
        Me.LblBMI = New System.Windows.Forms.Label()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.GbrInformation = New System.Windows.Forms.GroupBox()
        Me.TbAge = New System.Windows.Forms.TextBox()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.CbRating = New System.Windows.Forms.ComboBox()
        Me.LblRating = New System.Windows.Forms.Label()
        Me.GrbSelectGender.SuspendLayout()
        Me.GrbResult.SuspendLayout()
        Me.GbrInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrbSelectGender
        '
        Me.GrbSelectGender.BackColor = System.Drawing.Color.Transparent
        Me.GrbSelectGender.Controls.Add(Me.LblKg)
        Me.GrbSelectGender.Controls.Add(Me.RadioBtnFemale)
        Me.GrbSelectGender.Controls.Add(Me.TbWeightNow)
        Me.GrbSelectGender.Controls.Add(Me.LblWightNow)
        Me.GrbSelectGender.Controls.Add(Me.RadioBtnMale)
        Me.GrbSelectGender.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrbSelectGender.ForeColor = System.Drawing.SystemColors.Window
        Me.GrbSelectGender.Location = New System.Drawing.Point(406, 12)
        Me.GrbSelectGender.Name = "GrbSelectGender"
        Me.GrbSelectGender.Size = New System.Drawing.Size(366, 131)
        Me.GrbSelectGender.TabIndex = 8
        Me.GrbSelectGender.TabStop = False
        Me.GrbSelectGender.Text = "Pilih jenis kelamin dan masukkan berat badan Anda"
        '
        'LblKg
        '
        Me.LblKg.AutoSize = True
        Me.LblKg.Location = New System.Drawing.Point(211, 89)
        Me.LblKg.Name = "LblKg"
        Me.LblKg.Size = New System.Drawing.Size(21, 15)
        Me.LblKg.TabIndex = 13
        Me.LblKg.Text = "kg"
        '
        'RadioBtnFemale
        '
        Me.RadioBtnFemale.AutoSize = True
        Me.RadioBtnFemale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioBtnFemale.Location = New System.Drawing.Point(7, 53)
        Me.RadioBtnFemale.Name = "RadioBtnFemale"
        Me.RadioBtnFemale.Size = New System.Drawing.Size(89, 19)
        Me.RadioBtnFemale.TabIndex = 10
        Me.RadioBtnFemale.TabStop = True
        Me.RadioBtnFemale.Text = "Perempuan"
        Me.RadioBtnFemale.UseVisualStyleBackColor = True
        '
        'TbWeightNow
        '
        Me.TbWeightNow.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TbWeightNow.Location = New System.Drawing.Point(90, 86)
        Me.TbWeightNow.Name = "TbWeightNow"
        Me.TbWeightNow.Size = New System.Drawing.Size(115, 23)
        Me.TbWeightNow.TabIndex = 12
        '
        'LblWightNow
        '
        Me.LblWightNow.AutoSize = True
        Me.LblWightNow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblWightNow.Location = New System.Drawing.Point(7, 89)
        Me.LblWightNow.Name = "LblWightNow"
        Me.LblWightNow.Size = New System.Drawing.Size(74, 15)
        Me.LblWightNow.TabIndex = 11
        Me.LblWightNow.Text = "Berat badan"
        '
        'RadioBtnMale
        '
        Me.RadioBtnMale.AutoSize = True
        Me.RadioBtnMale.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioBtnMale.Location = New System.Drawing.Point(7, 28)
        Me.RadioBtnMale.Name = "RadioBtnMale"
        Me.RadioBtnMale.Size = New System.Drawing.Size(74, 19)
        Me.RadioBtnMale.TabIndex = 9
        Me.RadioBtnMale.TabStop = True
        Me.RadioBtnMale.Text = "Laki-Laki"
        Me.RadioBtnMale.UseVisualStyleBackColor = True
        '
        'LblCm
        '
        Me.LblCm.AutoSize = True
        Me.LblCm.Location = New System.Drawing.Point(194, 89)
        Me.LblCm.Name = "LblCm"
        Me.LblCm.Size = New System.Drawing.Size(24, 15)
        Me.LblCm.TabIndex = 7
        Me.LblCm.Text = "cm"
        '
        'BtnResult
        '
        Me.BtnResult.BackColor = System.Drawing.Color.White
        Me.BtnResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnResult.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnResult.Location = New System.Drawing.Point(697, 149)
        Me.BtnResult.Name = "BtnResult"
        Me.BtnResult.Size = New System.Drawing.Size(75, 23)
        Me.BtnResult.TabIndex = 14
        Me.BtnResult.Text = "Hasil"
        Me.BtnResult.UseVisualStyleBackColor = False
        '
        'TbHeight
        '
        Me.TbHeight.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TbHeight.Location = New System.Drawing.Point(73, 86)
        Me.TbHeight.Name = "TbHeight"
        Me.TbHeight.Size = New System.Drawing.Size(115, 23)
        Me.TbHeight.TabIndex = 6
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHeight.Location = New System.Drawing.Point(7, 89)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(41, 15)
        Me.LblHeight.TabIndex = 5
        Me.LblHeight.Text = "Tinggi"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnExit.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnExit.Location = New System.Drawing.Point(697, 346)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "Keluar"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnRefresh
        '
        Me.BtnRefresh.BackColor = System.Drawing.Color.White
        Me.BtnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRefresh.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnRefresh.Location = New System.Drawing.Point(406, 346)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 16
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = False
        '
        'GrbResult
        '
        Me.GrbResult.BackColor = System.Drawing.Color.Transparent
        Me.GrbResult.Controls.Add(Me.LblResultGender)
        Me.GrbResult.Controls.Add(Me.LblResultWeightNow)
        Me.GrbResult.Controls.Add(Me.LblResultHeight)
        Me.GrbResult.Controls.Add(Me.LblResultAge)
        Me.GrbResult.Controls.Add(Me.LblResultName)
        Me.GrbResult.Controls.Add(Me.LblBMIInformation)
        Me.GrbResult.Controls.Add(Me.LblBMI)
        Me.GrbResult.Controls.Add(Me.LblResult)
        Me.GrbResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GrbResult.ForeColor = System.Drawing.SystemColors.Window
        Me.GrbResult.Location = New System.Drawing.Point(12, 178)
        Me.GrbResult.Name = "GrbResult"
        Me.GrbResult.Size = New System.Drawing.Size(760, 162)
        Me.GrbResult.TabIndex = 15
        Me.GrbResult.TabStop = False
        Me.GrbResult.Text = "Hasil"
        '
        'LblResultGender
        '
        Me.LblResultGender.AutoSize = True
        Me.LblResultGender.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblResultGender.Location = New System.Drawing.Point(7, 68)
        Me.LblResultGender.Name = "LblResultGender"
        Me.LblResultGender.Size = New System.Drawing.Size(81, 15)
        Me.LblResultGender.TabIndex = 21
        Me.LblResultGender.Text = "Jenis kelamin"
        '
        'LblResultWeightNow
        '
        Me.LblResultWeightNow.AutoSize = True
        Me.LblResultWeightNow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblResultWeightNow.Location = New System.Drawing.Point(6, 84)
        Me.LblResultWeightNow.Name = "LblResultWeightNow"
        Me.LblResultWeightNow.Size = New System.Drawing.Size(74, 15)
        Me.LblResultWeightNow.TabIndex = 22
        Me.LblResultWeightNow.Text = "Berat badan"
        '
        'LblResultHeight
        '
        Me.LblResultHeight.AutoSize = True
        Me.LblResultHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblResultHeight.Location = New System.Drawing.Point(7, 52)
        Me.LblResultHeight.Name = "LblResultHeight"
        Me.LblResultHeight.Size = New System.Drawing.Size(41, 15)
        Me.LblResultHeight.TabIndex = 20
        Me.LblResultHeight.Text = "Tinggi"
        '
        'LblResultAge
        '
        Me.LblResultAge.AutoSize = True
        Me.LblResultAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblResultAge.Location = New System.Drawing.Point(7, 36)
        Me.LblResultAge.Name = "LblResultAge"
        Me.LblResultAge.Size = New System.Drawing.Size(39, 15)
        Me.LblResultAge.TabIndex = 19
        Me.LblResultAge.Text = "Umur"
        '
        'LblResultName
        '
        Me.LblResultName.AutoSize = True
        Me.LblResultName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblResultName.Location = New System.Drawing.Point(7, 21)
        Me.LblResultName.Name = "LblResultName"
        Me.LblResultName.Size = New System.Drawing.Size(39, 15)
        Me.LblResultName.TabIndex = 18
        Me.LblResultName.Text = "Nama"
        '
        'LblBMIInformation
        '
        Me.LblBMIInformation.AutoSize = True
        Me.LblBMIInformation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblBMIInformation.Location = New System.Drawing.Point(7, 133)
        Me.LblBMIInformation.Name = "LblBMIInformation"
        Me.LblBMIInformation.Size = New System.Drawing.Size(85, 15)
        Me.LblBMIInformation.TabIndex = 25
        Me.LblBMIInformation.Text = "IMT Informasi"
        '
        'LblBMI
        '
        Me.LblBMI.AutoSize = True
        Me.LblBMI.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblBMI.Location = New System.Drawing.Point(7, 116)
        Me.LblBMI.Name = "LblBMI"
        Me.LblBMI.Size = New System.Drawing.Size(112, 15)
        Me.LblBMI.TabIndex = 24
        Me.LblBMI.Text = "Indeks Masa Tubuh"
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblResult.Location = New System.Drawing.Point(6, 100)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(105, 15)
        Me.LblResult.TabIndex = 23
        Me.LblResult.Text = "Berat Badan Ideal"
        '
        'GbrInformation
        '
        Me.GbrInformation.BackColor = System.Drawing.Color.Transparent
        Me.GbrInformation.Controls.Add(Me.LblCm)
        Me.GbrInformation.Controls.Add(Me.TbAge)
        Me.GbrInformation.Controls.Add(Me.TbHeight)
        Me.GbrInformation.Controls.Add(Me.LblHeight)
        Me.GbrInformation.Controls.Add(Me.TbName)
        Me.GbrInformation.Controls.Add(Me.LblAge)
        Me.GbrInformation.Controls.Add(Me.LblName)
        Me.GbrInformation.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GbrInformation.ForeColor = System.Drawing.SystemColors.Window
        Me.GbrInformation.Location = New System.Drawing.Point(12, 12)
        Me.GbrInformation.Name = "GbrInformation"
        Me.GbrInformation.Size = New System.Drawing.Size(366, 131)
        Me.GbrInformation.TabIndex = 0
        Me.GbrInformation.TabStop = False
        Me.GbrInformation.Text = "Informasi"
        '
        'TbAge
        '
        Me.TbAge.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TbAge.Location = New System.Drawing.Point(73, 57)
        Me.TbAge.Name = "TbAge"
        Me.TbAge.Size = New System.Drawing.Size(145, 23)
        Me.TbAge.TabIndex = 4
        '
        'TbName
        '
        Me.TbName.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TbName.Location = New System.Drawing.Point(73, 28)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(277, 23)
        Me.TbName.TabIndex = 2
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblAge.Location = New System.Drawing.Point(7, 60)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(39, 15)
        Me.LblAge.TabIndex = 3
        Me.LblAge.Text = "Umur"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblName.Location = New System.Drawing.Point(7, 31)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(39, 15)
        Me.LblName.TabIndex = 1
        Me.LblName.Text = "Nama"
        '
        'CbRating
        '
        Me.CbRating.FormattingEnabled = True
        Me.CbRating.Location = New System.Drawing.Point(99, 346)
        Me.CbRating.Name = "CbRating"
        Me.CbRating.Size = New System.Drawing.Size(279, 23)
        Me.CbRating.TabIndex = 27
        '
        'LblRating
        '
        Me.LblRating.AutoSize = True
        Me.LblRating.BackColor = System.Drawing.Color.Transparent
        Me.LblRating.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblRating.ForeColor = System.Drawing.SystemColors.Window
        Me.LblRating.Location = New System.Drawing.Point(19, 349)
        Me.LblRating.Name = "LblRating"
        Me.LblRating.Size = New System.Drawing.Size(74, 15)
        Me.LblRating.TabIndex = 26
        Me.LblRating.Text = "Nilai aplikasi"
        '
        'FormIdealWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 381)
        Me.Controls.Add(Me.LblRating)
        Me.Controls.Add(Me.CbRating)
        Me.Controls.Add(Me.GbrInformation)
        Me.Controls.Add(Me.BtnResult)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.GrbResult)
        Me.Controls.Add(Me.GrbSelectGender)
        Me.MaximumSize = New System.Drawing.Size(800, 420)
        Me.MinimumSize = New System.Drawing.Size(800, 420)
        Me.Name = "FormIdealWeight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ideal Weight"
        Me.GrbSelectGender.ResumeLayout(False)
        Me.GrbSelectGender.PerformLayout()
        Me.GrbResult.ResumeLayout(False)
        Me.GrbResult.PerformLayout()
        Me.GbrInformation.ResumeLayout(False)
        Me.GbrInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrbSelectGender As GroupBox
    Friend WithEvents BtnResult As Button
    Friend WithEvents TbHeight As TextBox
    Friend WithEvents LblHeight As Label
    Friend WithEvents RadioBtnFemale As RadioButton
    Friend WithEvents RadioBtnMale As RadioButton
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblCm As Label
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents GrbResult As GroupBox
    Friend WithEvents LblBMI As Label
    Friend WithEvents GbrInformation As GroupBox
    Friend WithEvents TbAge As TextBox
    Friend WithEvents TbName As TextBox
    Friend WithEvents LblAge As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblKg As Label
    Friend WithEvents TbWeightNow As TextBox
    Friend WithEvents LblWightNow As Label
    Friend WithEvents LblResult As Label
    Friend WithEvents LblBMIInformation As Label
    Friend WithEvents LblResultGender As Label
    Friend WithEvents LblResultWeightNow As Label
    Friend WithEvents LblResultHeight As Label
    Friend WithEvents LblResultAge As Label
    Friend WithEvents LblResultName As Label
    Friend WithEvents CbRating As ComboBox
    Friend WithEvents LblRating As Label
End Class
