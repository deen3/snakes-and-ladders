<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Play
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Play))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtnSingle = New System.Windows.Forms.RadioButton
        Me.rbtnDual = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtnHard = New System.Windows.Forms.RadioButton
        Me.rbtnAverage = New System.Windows.Forms.RadioButton
        Me.rbtnEasy = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.pic1 = New System.Windows.Forms.PictureBox
        Me.pic2 = New System.Windows.Forms.PictureBox
        Me.pic3 = New System.Windows.Forms.PictureBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPlayer1 = New System.Windows.Forms.TextBox
        Me.txtPlayer2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblRemark = New System.Windows.Forms.Label
        Me.lblAvatarChosen = New System.Windows.Forms.Label
        Me.pic6 = New System.Windows.Forms.PictureBox
        Me.pic4 = New System.Windows.Forms.PictureBox
        Me.pic5 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnexit = New System.Windows.Forms.Button
        Me.btnInstruc = New System.Windows.Forms.Button
        Me.gbInstruct = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.picAvatar2 = New System.Windows.Forms.PictureBox
        Me.picAvatar1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInstruct.SuspendLayout()
        CType(Me.picAvatar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAvatar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox1.Controls.Add(Me.rbtnSingle)
        Me.GroupBox1.Controls.Add(Me.rbtnDual)
        Me.GroupBox1.Location = New System.Drawing.Point(322, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 74)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'rbtnSingle
        '
        Me.rbtnSingle.AutoSize = True
        Me.rbtnSingle.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnSingle.Location = New System.Drawing.Point(18, 15)
        Me.rbtnSingle.Name = "rbtnSingle"
        Me.rbtnSingle.Size = New System.Drawing.Size(93, 22)
        Me.rbtnSingle.TabIndex = 1
        Me.rbtnSingle.TabStop = True
        Me.rbtnSingle.Text = "Single Player"
        Me.rbtnSingle.UseVisualStyleBackColor = True
        '
        'rbtnDual
        '
        Me.rbtnDual.AutoSize = True
        Me.rbtnDual.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDual.Location = New System.Drawing.Point(18, 43)
        Me.rbtnDual.Name = "rbtnDual"
        Me.rbtnDual.Size = New System.Drawing.Size(88, 22)
        Me.rbtnDual.TabIndex = 2
        Me.rbtnDual.TabStop = True
        Me.rbtnDual.Text = "Dual Player"
        Me.rbtnDual.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.NavajoWhite
        Me.GroupBox2.Controls.Add(Me.rbtnHard)
        Me.GroupBox2.Controls.Add(Me.rbtnAverage)
        Me.GroupBox2.Controls.Add(Me.rbtnEasy)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 83)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'rbtnHard
        '
        Me.rbtnHard.AutoSize = True
        Me.rbtnHard.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnHard.Location = New System.Drawing.Point(18, 60)
        Me.rbtnHard.Name = "rbtnHard"
        Me.rbtnHard.Size = New System.Drawing.Size(54, 22)
        Me.rbtnHard.TabIndex = 3
        Me.rbtnHard.TabStop = True
        Me.rbtnHard.Text = "Hard"
        Me.rbtnHard.UseVisualStyleBackColor = True
        '
        'rbtnAverage
        '
        Me.rbtnAverage.AutoSize = True
        Me.rbtnAverage.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAverage.Location = New System.Drawing.Point(18, 32)
        Me.rbtnAverage.Name = "rbtnAverage"
        Me.rbtnAverage.Size = New System.Drawing.Size(69, 22)
        Me.rbtnAverage.TabIndex = 2
        Me.rbtnAverage.TabStop = True
        Me.rbtnAverage.Text = "Average"
        Me.rbtnAverage.UseVisualStyleBackColor = True
        '
        'rbtnEasy
        '
        Me.rbtnEasy.AutoSize = True
        Me.rbtnEasy.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnEasy.Location = New System.Drawing.Point(18, 4)
        Me.rbtnEasy.Name = "rbtnEasy"
        Me.rbtnEasy.Size = New System.Drawing.Size(50, 22)
        Me.rbtnEasy.TabIndex = 1
        Me.rbtnEasy.TabStop = True
        Me.rbtnEasy.Text = "Easy"
        Me.rbtnEasy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose your Avatar:"
        '
        'pic1
        '
        Me.pic1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(320, 242)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(41, 58)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 5
        Me.pic1.TabStop = False
        Me.pic1.Tag = "Mindy"
        '
        'pic2
        '
        Me.pic2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(367, 242)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(41, 58)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 6
        Me.pic2.TabStop = False
        Me.pic2.Tag = "Claire"
        '
        'pic3
        '
        Me.pic3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(414, 242)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(41, 58)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 7
        Me.pic3.TabStop = False
        Me.pic3.Tag = "Chloe"
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.SandyBrown
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(391, 421)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(136, 43)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(310, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Player 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(474, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Player 2:"
        '
        'txtPlayer1
        '
        Me.txtPlayer1.Enabled = False
        Me.txtPlayer1.Location = New System.Drawing.Point(355, 216)
        Me.txtPlayer1.Name = "txtPlayer1"
        Me.txtPlayer1.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer1.TabIndex = 14
        '
        'txtPlayer2
        '
        Me.txtPlayer2.Enabled = False
        Me.txtPlayer2.Location = New System.Drawing.Point(518, 216)
        Me.txtPlayer2.Name = "txtPlayer2"
        Me.txtPlayer2.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayer2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 473)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "© 2013 Kienah Corporation. All rights reserved."
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.BackColor = System.Drawing.Color.Transparent
        Me.lblRemark.Font = New System.Drawing.Font("Peak 5pt", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark.Location = New System.Drawing.Point(189, 9)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(438, 29)
        Me.lblRemark.TabIndex = 19
        Me.lblRemark.Text = "Snakes and Ladder"
        '
        'lblAvatarChosen
        '
        Me.lblAvatarChosen.AutoSize = True
        Me.lblAvatarChosen.BackColor = System.Drawing.Color.Transparent
        Me.lblAvatarChosen.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvatarChosen.Location = New System.Drawing.Point(319, 300)
        Me.lblAvatarChosen.Name = "lblAvatarChosen"
        Me.lblAvatarChosen.Size = New System.Drawing.Size(98, 18)
        Me.lblAvatarChosen.TabIndex = 20
        Me.lblAvatarChosen.Text = "You have chose..."
        Me.lblAvatarChosen.Visible = False
        '
        'pic6
        '
        Me.pic6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic6.Image = CType(resources.GetObject("pic6.Image"), System.Drawing.Image)
        Me.pic6.Location = New System.Drawing.Point(577, 242)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(41, 58)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6.TabIndex = 27
        Me.pic6.TabStop = False
        Me.pic6.Tag = "Dylan"
        '
        'pic4
        '
        Me.pic4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic4.Image = CType(resources.GetObject("pic4.Image"), System.Drawing.Image)
        Me.pic4.Location = New System.Drawing.Point(483, 242)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(41, 58)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 26
        Me.pic4.TabStop = False
        Me.pic4.Tag = "Ryan"
        '
        'pic5
        '
        Me.pic5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic5.Image = CType(resources.GetObject("pic5.Image"), System.Drawing.Image)
        Me.pic5.Location = New System.Drawing.Point(530, 242)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(41, 58)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 24
        Me.pic5.TabStop = False
        Me.pic5.Tag = "Jasper"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Minion Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(480, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "You have chose..."
        Me.Label5.Visible = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.BackgroundImage = Global.Snakes_and_Ladders.My.Resources.Resources._exit
        Me.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnexit.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(7, 9)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(67, 68)
        Me.btnexit.TabIndex = 29
        Me.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnInstruc
        '
        Me.btnInstruc.BackColor = System.Drawing.Color.Transparent
        Me.btnInstruc.BackgroundImage = Global.Snakes_and_Ladders.My.Resources.Resources.more
        Me.btnInstruc.Location = New System.Drawing.Point(80, 7)
        Me.btnInstruc.Name = "btnInstruc"
        Me.btnInstruc.Size = New System.Drawing.Size(75, 76)
        Me.btnInstruc.TabIndex = 30
        Me.btnInstruc.UseVisualStyleBackColor = False
        '
        'gbInstruct
        '
        Me.gbInstruct.BackgroundImage = Global.Snakes_and_Ladders.My.Resources.Resources.bckInstruc
        Me.gbInstruct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbInstruct.Controls.Add(Me.Button1)
        Me.gbInstruct.Font = New System.Drawing.Font("Minion Pro SmBd", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInstruct.ForeColor = System.Drawing.Color.Green
        Me.gbInstruct.Location = New System.Drawing.Point(355, 397)
        Me.gbInstruct.Name = "gbInstruct"
        Me.gbInstruct.Size = New System.Drawing.Size(406, 459)
        Me.gbInstruct.TabIndex = 31
        Me.gbInstruct.TabStop = False
        Me.gbInstruct.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Snakes_and_Ladders.My.Resources.Resources.huge_61_306629
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(238, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picAvatar2
        '
        Me.picAvatar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAvatar2.Location = New System.Drawing.Point(159, 332)
        Me.picAvatar2.Name = "picAvatar2"
        Me.picAvatar2.Size = New System.Drawing.Size(100, 132)
        Me.picAvatar2.TabIndex = 32
        Me.picAvatar2.TabStop = False
        Me.picAvatar2.Visible = False
        '
        'picAvatar1
        '
        Me.picAvatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAvatar1.Location = New System.Drawing.Point(53, 332)
        Me.picAvatar1.Name = "picAvatar1"
        Me.picAvatar1.Size = New System.Drawing.Size(100, 132)
        Me.picAvatar1.TabIndex = 33
        Me.picAvatar1.TabStop = False
        Me.picAvatar1.Visible = False
        '
        'Play
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.picAvatar1)
        Me.Controls.Add(Me.gbInstruct)
        Me.Controls.Add(Me.picAvatar2)
        Me.Controls.Add(Me.btnInstruc)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.lblAvatarChosen)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPlayer2)
        Me.Controls.Add(Me.txtPlayer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Play"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE AVATAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInstruct.ResumeLayout(False)
        CType(Me.picAvatar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAvatar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDual As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSingle As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnHard As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAverage As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnEasy As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlayer1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPlayer2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents lblAvatarChosen As System.Windows.Forms.Label
    Friend WithEvents pic6 As System.Windows.Forms.PictureBox
    Friend WithEvents pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents pic5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnInstruc As System.Windows.Forms.Button
    Friend WithEvents gbInstruct As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents picAvatar2 As System.Windows.Forms.PictureBox
    Friend WithEvents picAvatar1 As System.Windows.Forms.PictureBox
End Class
