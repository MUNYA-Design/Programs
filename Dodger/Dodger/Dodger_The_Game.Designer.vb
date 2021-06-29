<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDodgerTheGame
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlGameFrame = New System.Windows.Forms.Panel()
        Me.pctBlock6 = New System.Windows.Forms.PictureBox()
        Me.pnlRoof = New System.Windows.Forms.Panel()
        Me.pnlfloor1 = New System.Windows.Forms.Panel()
        Me.pnlfloor0 = New System.Windows.Forms.Panel()
        Me.picDoor2 = New System.Windows.Forms.Panel()
        Me.pnlfloor2 = New System.Windows.Forms.Panel()
        Me.picDoor3 = New System.Windows.Forms.Panel()
        Me.picDoor4 = New System.Windows.Forms.Panel()
        Me.picDoor5 = New System.Windows.Forms.Panel()
        Me.picDoor6 = New System.Windows.Forms.Panel()
        Me.picDoor1 = New System.Windows.Forms.Panel()
        Me.pctBlock1 = New System.Windows.Forms.PictureBox()
        Me.pctBlock2 = New System.Windows.Forms.PictureBox()
        Me.pctBlock5 = New System.Windows.Forms.PictureBox()
        Me.pctBlock4 = New System.Windows.Forms.PictureBox()
        Me.pctBlock3 = New System.Windows.Forms.PictureBox()
        Me.pctDodger = New System.Windows.Forms.PictureBox()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.pnlControls = New System.Windows.Forms.Panel()
        Me.tmrOne = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.tmrPlayer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGameFrame.SuspendLayout()
        CType(Me.pctBlock6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlock5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlock4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBlock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDodger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGameFrame
        '
        Me.pnlGameFrame.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnlGameFrame.Controls.Add(Me.pctBlock6)
        Me.pnlGameFrame.Controls.Add(Me.pnlRoof)
        Me.pnlGameFrame.Controls.Add(Me.pnlfloor1)
        Me.pnlGameFrame.Controls.Add(Me.pnlfloor0)
        Me.pnlGameFrame.Controls.Add(Me.picDoor2)
        Me.pnlGameFrame.Controls.Add(Me.pnlfloor2)
        Me.pnlGameFrame.Controls.Add(Me.picDoor3)
        Me.pnlGameFrame.Controls.Add(Me.picDoor4)
        Me.pnlGameFrame.Controls.Add(Me.picDoor5)
        Me.pnlGameFrame.Controls.Add(Me.picDoor6)
        Me.pnlGameFrame.Controls.Add(Me.picDoor1)
        Me.pnlGameFrame.Controls.Add(Me.pctBlock1)
        Me.pnlGameFrame.Controls.Add(Me.pctBlock2)
        Me.pnlGameFrame.Controls.Add(Me.pctBlock5)
        Me.pnlGameFrame.Controls.Add(Me.pctBlock4)
        Me.pnlGameFrame.Controls.Add(Me.pctBlock3)
        Me.pnlGameFrame.Controls.Add(Me.pctDodger)
        Me.pnlGameFrame.Location = New System.Drawing.Point(11, 12)
        Me.pnlGameFrame.Name = "pnlGameFrame"
        Me.pnlGameFrame.Size = New System.Drawing.Size(990, 452)
        Me.pnlGameFrame.TabIndex = 1
        '
        'pctBlock6
        '
        Me.pctBlock6.Image = Global.Dodger.My.Resources.Resources.block
        Me.pctBlock6.Location = New System.Drawing.Point(820, 16)
        Me.pctBlock6.Name = "pctBlock6"
        Me.pctBlock6.Size = New System.Drawing.Size(25, 25)
        Me.pctBlock6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlock6.TabIndex = 0
        Me.pctBlock6.TabStop = False
        '
        'pnlRoof
        '
        Me.pnlRoof.BackColor = System.Drawing.SystemColors.Desktop
        Me.pnlRoof.Location = New System.Drawing.Point(0, 0)
        Me.pnlRoof.Name = "pnlRoof"
        Me.pnlRoof.Size = New System.Drawing.Size(990, 10)
        Me.pnlRoof.TabIndex = 6
        '
        'pnlfloor1
        '
        Me.pnlfloor1.BackColor = System.Drawing.SystemColors.Desktop
        Me.pnlfloor1.Location = New System.Drawing.Point(11, 280)
        Me.pnlfloor1.Name = "pnlfloor1"
        Me.pnlfloor1.Size = New System.Drawing.Size(969, 10)
        Me.pnlfloor1.TabIndex = 6
        '
        'pnlfloor0
        '
        Me.pnlfloor0.BackColor = System.Drawing.SystemColors.Desktop
        Me.pnlfloor0.Location = New System.Drawing.Point(11, 420)
        Me.pnlfloor0.Name = "pnlfloor0"
        Me.pnlfloor0.Size = New System.Drawing.Size(969, 10)
        Me.pnlfloor0.TabIndex = 6
        '
        'picDoor2
        '
        Me.picDoor2.BackColor = System.Drawing.SystemColors.Desktop
        Me.picDoor2.Location = New System.Drawing.Point(11, 84)
        Me.picDoor2.Name = "picDoor2"
        Me.picDoor2.Size = New System.Drawing.Size(37, 50)
        Me.picDoor2.TabIndex = 6
        '
        'pnlfloor2
        '
        Me.pnlfloor2.BackColor = System.Drawing.SystemColors.Desktop
        Me.pnlfloor2.Location = New System.Drawing.Point(11, 140)
        Me.pnlfloor2.Name = "pnlfloor2"
        Me.pnlfloor2.Size = New System.Drawing.Size(969, 10)
        Me.pnlfloor2.TabIndex = 6
        '
        'picDoor3
        '
        Me.picDoor3.BackColor = System.Drawing.SystemColors.Desktop
        Me.picDoor3.Location = New System.Drawing.Point(11, 224)
        Me.picDoor3.Name = "picDoor3"
        Me.picDoor3.Size = New System.Drawing.Size(37, 50)
        Me.picDoor3.TabIndex = 6
        '
        'picDoor4
        '
        Me.picDoor4.BackColor = System.Drawing.SystemColors.Desktop
        Me.picDoor4.Location = New System.Drawing.Point(943, 224)
        Me.picDoor4.Name = "picDoor4"
        Me.picDoor4.Size = New System.Drawing.Size(37, 50)
        Me.picDoor4.TabIndex = 6
        '
        'picDoor5
        '
        Me.picDoor5.BackColor = System.Drawing.SystemColors.Desktop
        Me.picDoor5.Location = New System.Drawing.Point(943, 364)
        Me.picDoor5.Name = "picDoor5"
        Me.picDoor5.Size = New System.Drawing.Size(37, 50)
        Me.picDoor5.TabIndex = 6
        '
        'picDoor6
        '
        Me.picDoor6.BackColor = System.Drawing.SystemColors.Desktop
        Me.picDoor6.Location = New System.Drawing.Point(11, 364)
        Me.picDoor6.Name = "picDoor6"
        Me.picDoor6.Size = New System.Drawing.Size(37, 50)
        Me.picDoor6.TabIndex = 6
        '
        'picDoor1
        '
        Me.picDoor1.BackColor = System.Drawing.SystemColors.Desktop
        Me.picDoor1.Location = New System.Drawing.Point(911, 16)
        Me.picDoor1.Name = "picDoor1"
        Me.picDoor1.Size = New System.Drawing.Size(69, 118)
        Me.picDoor1.TabIndex = 6
        '
        'pctBlock1
        '
        Me.pctBlock1.Image = Global.Dodger.My.Resources.Resources.block
        Me.pctBlock1.Location = New System.Drawing.Point(100, 16)
        Me.pctBlock1.Name = "pctBlock1"
        Me.pctBlock1.Size = New System.Drawing.Size(25, 25)
        Me.pctBlock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlock1.TabIndex = 0
        Me.pctBlock1.TabStop = False
        '
        'pctBlock2
        '
        Me.pctBlock2.Image = Global.Dodger.My.Resources.Resources.block
        Me.pctBlock2.Location = New System.Drawing.Point(244, 16)
        Me.pctBlock2.Name = "pctBlock2"
        Me.pctBlock2.Size = New System.Drawing.Size(25, 25)
        Me.pctBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlock2.TabIndex = 0
        Me.pctBlock2.TabStop = False
        '
        'pctBlock5
        '
        Me.pctBlock5.Image = Global.Dodger.My.Resources.Resources.block
        Me.pctBlock5.Location = New System.Drawing.Point(676, 16)
        Me.pctBlock5.Name = "pctBlock5"
        Me.pctBlock5.Size = New System.Drawing.Size(25, 25)
        Me.pctBlock5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlock5.TabIndex = 0
        Me.pctBlock5.TabStop = False
        '
        'pctBlock4
        '
        Me.pctBlock4.Image = Global.Dodger.My.Resources.Resources.block
        Me.pctBlock4.Location = New System.Drawing.Point(532, 16)
        Me.pctBlock4.Name = "pctBlock4"
        Me.pctBlock4.Size = New System.Drawing.Size(25, 25)
        Me.pctBlock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlock4.TabIndex = 0
        Me.pctBlock4.TabStop = False
        '
        'pctBlock3
        '
        Me.pctBlock3.Image = Global.Dodger.My.Resources.Resources.block
        Me.pctBlock3.Location = New System.Drawing.Point(388, 16)
        Me.pctBlock3.Name = "pctBlock3"
        Me.pctBlock3.Size = New System.Drawing.Size(25, 25)
        Me.pctBlock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBlock3.TabIndex = 0
        Me.pctBlock3.TabStop = False
        '
        'pctDodger
        '
        Me.pctDodger.Image = Global.Dodger.My.Resources.Resources.character
        Me.pctDodger.Location = New System.Drawing.Point(54, 364)
        Me.pctDodger.Name = "pctDodger"
        Me.pctDodger.Size = New System.Drawing.Size(36, 50)
        Me.pctDodger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctDodger.TabIndex = 0
        Me.pctDodger.TabStop = False
        '
        'btnLeft
        '
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New System.Drawing.Point(9, 16)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(62, 43)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "←"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(77, 16)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(62, 43)
        Me.btnRight.TabIndex = 0
        Me.btnRight.Text = "→"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'pnlControls
        '
        Me.pnlControls.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.pnlControls.Controls.Add(Me.btnLeft)
        Me.pnlControls.Controls.Add(Me.btnRight)
        Me.pnlControls.Location = New System.Drawing.Point(438, 470)
        Me.pnlControls.Name = "pnlControls"
        Me.pnlControls.Size = New System.Drawing.Size(150, 74)
        Me.pnlControls.TabIndex = 1
        '
        'tmrOne
        '
        Me.tmrOne.Interval = 500
        '
        'btnStartGame
        '
        Me.btnStartGame.BackColor = System.Drawing.Color.Green
        Me.btnStartGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStartGame.Location = New System.Drawing.Point(11, 470)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(125, 74)
        Me.btnStartGame.TabIndex = 4
        Me.btnStartGame.Text = "Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.ForeColor = System.Drawing.SystemColors.Control
        Me.btnexit.Location = New System.Drawing.Point(894, 504)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(107, 35)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'tmrPlayer
        '
        '
        'frmDodgerTheGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 551)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.pnlControls)
        Me.Controls.Add(Me.pnlGameFrame)
        Me.Name = "frmDodgerTheGame"
        Me.Text = "Dodger The Game"
        Me.pnlGameFrame.ResumeLayout(False)
        CType(Me.pctBlock6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlock5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlock4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBlock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDodger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControls.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlGameFrame As Panel
    Friend WithEvents pctBlock3 As PictureBox
    Friend WithEvents pctDodger As PictureBox
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents pnlControls As Panel
    Friend WithEvents tmrOne As Timer
    Friend WithEvents btnStartGame As Button
    Friend WithEvents pctBlock1 As PictureBox
    Friend WithEvents pctBlock2 As PictureBox
    Friend WithEvents pctBlock6 As PictureBox
    Friend WithEvents pctBlock5 As PictureBox
    Friend WithEvents pctBlock4 As PictureBox
    Friend WithEvents pnlfloor1 As Panel
    Friend WithEvents pnlRoof As Panel
    Friend WithEvents picDoor5 As Panel
    Friend WithEvents picDoor6 As Panel
    Friend WithEvents picDoor1 As Panel
    Friend WithEvents picDoor2 As Panel
    Friend WithEvents picDoor3 As Panel
    Friend WithEvents picDoor4 As Panel
    Friend WithEvents pnlfloor0 As Panel
    Friend WithEvents pnlfloor2 As Panel
    Friend WithEvents btnexit As Button
    Friend WithEvents tmrPlayer As Timer
End Class
