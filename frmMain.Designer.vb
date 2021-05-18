<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtPull = New System.Windows.Forms.TextBox()
        Me.lblPull = New System.Windows.Forms.Label()
        Me.lblPullScore = New System.Windows.Forms.Label()
        Me.lblScrTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.GrpSex = New System.Windows.Forms.GroupBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.grpPU = New System.Windows.Forms.GroupBox()
        Me.radPush = New System.Windows.Forms.RadioButton()
        Me.radPull = New System.Windows.Forms.RadioButton()
        Me.txtPush = New System.Windows.Forms.TextBox()
        Me.lblPush = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPushScore = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCrunch = New System.Windows.Forms.TextBox()
        Me.lblCrunch = New System.Windows.Forms.Label()
        Me.lblCrunchScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRun = New System.Windows.Forms.TextBox()
        Me.lblRun = New System.Windows.Forms.Label()
        Me.lblRunScore = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPFTtitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltitle5 = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.pbDog = New System.Windows.Forms.PictureBox()
        Me.GrpSex.SuspendLayout()
        Me.grpPU.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPull
        '
        Me.txtPull.BackColor = System.Drawing.Color.White
        Me.txtPull.ForeColor = System.Drawing.Color.Black
        Me.txtPull.Location = New System.Drawing.Point(141, 182)
        Me.txtPull.MaxLength = 2
        Me.txtPull.Name = "txtPull"
        Me.txtPull.Size = New System.Drawing.Size(74, 27)
        Me.txtPull.TabIndex = 7
        '
        'lblPull
        '
        Me.lblPull.BackColor = System.Drawing.Color.DarkGray
        Me.lblPull.ForeColor = System.Drawing.Color.Black
        Me.lblPull.Location = New System.Drawing.Point(141, 153)
        Me.lblPull.Name = "lblPull"
        Me.lblPull.Size = New System.Drawing.Size(74, 20)
        Me.lblPull.TabIndex = 17
        Me.lblPull.Text = "Pullups"
        '
        'lblPullScore
        '
        Me.lblPullScore.BackColor = System.Drawing.Color.DarkGray
        Me.lblPullScore.ForeColor = System.Drawing.Color.Black
        Me.lblPullScore.Location = New System.Drawing.Point(237, 185)
        Me.lblPullScore.Name = "lblPullScore"
        Me.lblPullScore.Size = New System.Drawing.Size(74, 20)
        Me.lblPullScore.TabIndex = 21
        '
        'lblScrTitle
        '
        Me.lblScrTitle.BackColor = System.Drawing.Color.DarkGray
        Me.lblScrTitle.ForeColor = System.Drawing.Color.Black
        Me.lblScrTitle.Location = New System.Drawing.Point(237, 153)
        Me.lblScrTitle.Name = "lblScrTitle"
        Me.lblScrTitle.Size = New System.Drawing.Size(74, 20)
        Me.lblScrTitle.TabIndex = 20
        Me.lblScrTitle.Text = "Score:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(12, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 45)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.Gray
        Me.btnCalc.ForeColor = System.Drawing.Color.Black
        Me.btnCalc.Location = New System.Drawing.Point(12, 293)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(107, 45)
        Me.btnCalc.TabIndex = 11
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'GrpSex
        '
        Me.GrpSex.BackColor = System.Drawing.Color.DarkGray
        Me.GrpSex.Controls.Add(Me.radMale)
        Me.GrpSex.Controls.Add(Me.radFemale)
        Me.GrpSex.ForeColor = System.Drawing.Color.Black
        Me.GrpSex.Location = New System.Drawing.Point(12, 88)
        Me.GrpSex.Name = "GrpSex"
        Me.GrpSex.Size = New System.Drawing.Size(107, 76)
        Me.GrpSex.TabIndex = 0
        Me.GrpSex.TabStop = False
        Me.GrpSex.Text = "Sex:"
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.BackColor = System.Drawing.Color.DarkGray
        Me.radMale.ForeColor = System.Drawing.Color.Black
        Me.radMale.Location = New System.Drawing.Point(6, 19)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(60, 24)
        Me.radMale.TabIndex = 1
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.BackColor = System.Drawing.Color.DarkGray
        Me.radFemale.ForeColor = System.Drawing.Color.Black
        Me.radFemale.Location = New System.Drawing.Point(6, 42)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(75, 24)
        Me.radFemale.TabIndex = 2
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = False
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.Location = New System.Drawing.Point(141, 117)
        Me.txtAge.MaxLength = 2
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(74, 27)
        Me.txtAge.TabIndex = 6
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.DarkGray
        Me.lblAge.ForeColor = System.Drawing.Color.Black
        Me.lblAge.Location = New System.Drawing.Point(141, 88)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(74, 20)
        Me.lblAge.TabIndex = 23
        Me.lblAge.Text = "Input Age"
        '
        'grpPU
        '
        Me.grpPU.BackColor = System.Drawing.Color.DarkGray
        Me.grpPU.Controls.Add(Me.radPush)
        Me.grpPU.Controls.Add(Me.radPull)
        Me.grpPU.ForeColor = System.Drawing.Color.Black
        Me.grpPU.Location = New System.Drawing.Point(12, 181)
        Me.grpPU.Name = "grpPU"
        Me.grpPU.Size = New System.Drawing.Size(107, 89)
        Me.grpPU.TabIndex = 3
        Me.grpPU.TabStop = False
        Me.grpPU.Text = "Type"
        '
        'radPush
        '
        Me.radPush.AutoSize = True
        Me.radPush.BackColor = System.Drawing.Color.DarkGray
        Me.radPush.ForeColor = System.Drawing.Color.Black
        Me.radPush.Location = New System.Drawing.Point(6, 51)
        Me.radPush.Name = "radPush"
        Me.radPush.Size = New System.Drawing.Size(86, 24)
        Me.radPush.TabIndex = 5
        Me.radPush.TabStop = True
        Me.radPush.Text = "Push Ups"
        Me.radPush.UseVisualStyleBackColor = False
        '
        'radPull
        '
        Me.radPull.AutoSize = True
        Me.radPull.BackColor = System.Drawing.Color.DarkGray
        Me.radPull.ForeColor = System.Drawing.Color.Black
        Me.radPull.Location = New System.Drawing.Point(7, 22)
        Me.radPull.Name = "radPull"
        Me.radPull.Size = New System.Drawing.Size(80, 24)
        Me.radPull.TabIndex = 4
        Me.radPull.TabStop = True
        Me.radPull.Text = "Pull Ups"
        Me.radPull.UseVisualStyleBackColor = False
        '
        'txtPush
        '
        Me.txtPush.BackColor = System.Drawing.Color.White
        Me.txtPush.ForeColor = System.Drawing.Color.Black
        Me.txtPush.Location = New System.Drawing.Point(141, 247)
        Me.txtPush.MaxLength = 2
        Me.txtPush.Name = "txtPush"
        Me.txtPush.Size = New System.Drawing.Size(74, 27)
        Me.txtPush.TabIndex = 8
        '
        'lblPush
        '
        Me.lblPush.BackColor = System.Drawing.Color.DarkGray
        Me.lblPush.ForeColor = System.Drawing.Color.Black
        Me.lblPush.Location = New System.Drawing.Point(141, 218)
        Me.lblPush.Name = "lblPush"
        Me.lblPush.Size = New System.Drawing.Size(74, 20)
        Me.lblPush.TabIndex = 26
        Me.lblPush.Text = "Pushups"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(237, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Score:"
        '
        'lblPushScore
        '
        Me.lblPushScore.BackColor = System.Drawing.Color.DarkGray
        Me.lblPushScore.ForeColor = System.Drawing.Color.Black
        Me.lblPushScore.Location = New System.Drawing.Point(237, 250)
        Me.lblPushScore.Name = "lblPushScore"
        Me.lblPushScore.Size = New System.Drawing.Size(74, 20)
        Me.lblPushScore.TabIndex = 29
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(12, 344)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(107, 45)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtCrunch
        '
        Me.txtCrunch.BackColor = System.Drawing.Color.White
        Me.txtCrunch.ForeColor = System.Drawing.Color.Black
        Me.txtCrunch.Location = New System.Drawing.Point(141, 312)
        Me.txtCrunch.MaxLength = 3
        Me.txtCrunch.Name = "txtCrunch"
        Me.txtCrunch.Size = New System.Drawing.Size(74, 27)
        Me.txtCrunch.TabIndex = 9
        '
        'lblCrunch
        '
        Me.lblCrunch.BackColor = System.Drawing.Color.DarkGray
        Me.lblCrunch.ForeColor = System.Drawing.Color.Black
        Me.lblCrunch.Location = New System.Drawing.Point(141, 283)
        Me.lblCrunch.Name = "lblCrunch"
        Me.lblCrunch.Size = New System.Drawing.Size(74, 20)
        Me.lblCrunch.TabIndex = 31
        Me.lblCrunch.Text = "Crunches"
        '
        'lblCrunchScore
        '
        Me.lblCrunchScore.BackColor = System.Drawing.Color.DarkGray
        Me.lblCrunchScore.ForeColor = System.Drawing.Color.Black
        Me.lblCrunchScore.Location = New System.Drawing.Point(237, 315)
        Me.lblCrunchScore.Name = "lblCrunchScore"
        Me.lblCrunchScore.Size = New System.Drawing.Size(74, 20)
        Me.lblCrunchScore.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(237, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Score:"
        '
        'txtRun
        '
        Me.txtRun.BackColor = System.Drawing.Color.White
        Me.txtRun.ForeColor = System.Drawing.Color.Black
        Me.txtRun.Location = New System.Drawing.Point(141, 377)
        Me.txtRun.MaxLength = 4
        Me.txtRun.Name = "txtRun"
        Me.txtRun.Size = New System.Drawing.Size(74, 27)
        Me.txtRun.TabIndex = 10
        '
        'lblRun
        '
        Me.lblRun.BackColor = System.Drawing.Color.DarkGray
        Me.lblRun.ForeColor = System.Drawing.Color.Black
        Me.lblRun.Location = New System.Drawing.Point(141, 348)
        Me.lblRun.Name = "lblRun"
        Me.lblRun.Size = New System.Drawing.Size(74, 20)
        Me.lblRun.TabIndex = 35
        Me.lblRun.Text = "Run Time"
        '
        'lblRunScore
        '
        Me.lblRunScore.BackColor = System.Drawing.Color.DarkGray
        Me.lblRunScore.ForeColor = System.Drawing.Color.Black
        Me.lblRunScore.Location = New System.Drawing.Point(237, 380)
        Me.lblRunScore.Name = "lblRunScore"
        Me.lblRunScore.Size = New System.Drawing.Size(74, 20)
        Me.lblRunScore.TabIndex = 38
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.DarkGray
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(353, 126)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 20)
        Me.lblTotal.TabIndex = 37
        '
        'lblPFTtitle
        '
        Me.lblPFTtitle.AutoSize = True
        Me.lblPFTtitle.BackColor = System.Drawing.Color.Gray
        Me.lblPFTtitle.ForeColor = System.Drawing.Color.Black
        Me.lblPFTtitle.Location = New System.Drawing.Point(353, 88)
        Me.lblPFTtitle.Name = "lblPFTtitle"
        Me.lblPFTtitle.Size = New System.Drawing.Size(73, 20)
        Me.lblPFTtitle.TabIndex = 39
        Me.lblPFTtitle.Text = "PFT Score"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(237, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Score:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(465, 57)
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'lbltitle5
        '
        Me.lbltitle5.AutoSize = True
        Me.lbltitle5.BackColor = System.Drawing.Color.Gray
        Me.lbltitle5.ForeColor = System.Drawing.Color.Black
        Me.lbltitle5.Location = New System.Drawing.Point(353, 172)
        Me.lbltitle5.Name = "lbltitle5"
        Me.lbltitle5.Size = New System.Drawing.Size(96, 20)
        Me.lbltitle5.TabIndex = 42
        Me.lbltitle5.Text = "Classification"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.BackColor = System.Drawing.Color.DarkGray
        Me.lblClass.ForeColor = System.Drawing.Color.Black
        Me.lblClass.Location = New System.Drawing.Point(353, 208)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(0, 20)
        Me.lblClass.TabIndex = 43
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(304, 384)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(181, 20)
        Me.LinkLabel1.TabIndex = 14
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Pullup / Pushup Standards"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(353, 404)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(132, 20)
        Me.LinkLabel2.TabIndex = 15
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Crunches Standard"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.Location = New System.Drawing.Point(387, 424)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(98, 20)
        Me.LinkLabel3.TabIndex = 16
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Run Standard"
        '
        'pbDog
        '
        Me.pbDog.Image = CType(resources.GetObject("pbDog.Image"), System.Drawing.Image)
        Me.pbDog.Location = New System.Drawing.Point(334, 259)
        Me.pbDog.Name = "pbDog"
        Me.pbDog.Size = New System.Drawing.Size(143, 122)
        Me.pbDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDog.TabIndex = 47
        Me.pbDog.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(497, 446)
        Me.Controls.Add(Me.pbDog)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lbltitle5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPFTtitle)
        Me.Controls.Add(Me.lblRunScore)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtRun)
        Me.Controls.Add(Me.lblRun)
        Me.Controls.Add(Me.lblCrunchScore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCrunch)
        Me.Controls.Add(Me.lblCrunch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPushScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPush)
        Me.Controls.Add(Me.lblPush)
        Me.Controls.Add(Me.grpPU)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.GrpSex)
        Me.Controls.Add(Me.lblPullScore)
        Me.Controls.Add(Me.lblScrTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPull)
        Me.Controls.Add(Me.txtPull)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2017 USMC PFT Calculator"
        Me.GrpSex.ResumeLayout(False)
        Me.GrpSex.PerformLayout()
        Me.grpPU.ResumeLayout(False)
        Me.grpPU.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPull As System.Windows.Forms.TextBox
    Friend WithEvents lblPull As System.Windows.Forms.Label
    Friend WithEvents lblPullScore As System.Windows.Forms.Label
    Friend WithEvents lblScrTitle As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents GrpSex As System.Windows.Forms.GroupBox
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents grpPU As System.Windows.Forms.GroupBox
    Friend WithEvents radPush As System.Windows.Forms.RadioButton
    Friend WithEvents radPull As System.Windows.Forms.RadioButton
    Friend WithEvents txtPush As System.Windows.Forms.TextBox
    Friend WithEvents lblPush As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPushScore As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtCrunch As System.Windows.Forms.TextBox
    Friend WithEvents lblCrunch As System.Windows.Forms.Label
    Friend WithEvents lblCrunchScore As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRun As System.Windows.Forms.TextBox
    Friend WithEvents lblRun As System.Windows.Forms.Label
    Friend WithEvents lblRunScore As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPFTtitle As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltitle5 As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents pbDog As System.Windows.Forms.PictureBox

End Class
