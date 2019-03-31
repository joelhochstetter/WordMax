<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlay
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlay))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.radioAni = New System.Windows.Forms.RadioButton()
        Me.radioComp = New System.Windows.Forms.RadioButton()
        Me.lblSelectHeader = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnSortAlphabetically = New System.Windows.Forms.Button()
        Me.btnSortByLen = New System.Windows.Forms.Button()
        Me.lblWList = New System.Windows.Forms.Label()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.btnEnterName = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblHS = New System.Windows.Forms.Label()
        Me.btnGoToHS = New System.Windows.Forms.Button()
        Me.HoverOverText = New System.Windows.Forms.ToolTip(Me.components)
        Me.BTCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblBTCTime = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Snow
        Me.lblHeader.Location = New System.Drawing.Point(-6, -9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1080, 82)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Classic"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(984, 8)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(118, 39)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnHelp.ForeColor = System.Drawing.Color.Black
        Me.btnHelp.Location = New System.Drawing.Point(856, 8)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(122, 39)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "HELP"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.LimeGreen
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblScore.ForeColor = System.Drawing.Color.Black
        Me.lblScore.Location = New System.Drawing.Point(981, 57)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(121, 33)
        Me.lblScore.TabIndex = 8
        Me.lblScore.Text = "SCORE:"
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.Color.LimeGreen
        Me.lblHighScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblHighScore.ForeColor = System.Drawing.Color.Black
        Me.lblHighScore.Location = New System.Drawing.Point(981, 125)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(36, 33)
        Me.lblHighScore.TabIndex = 9
        Me.lblHighScore.Text = "H"
        '
        'radioAni
        '
        Me.radioAni.AutoSize = True
        Me.radioAni.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.radioAni.Location = New System.Drawing.Point(433, 238)
        Me.radioAni.Name = "radioAni"
        Me.radioAni.Size = New System.Drawing.Size(128, 35)
        Me.radioAni.TabIndex = 10
        Me.radioAni.TabStop = True
        Me.radioAni.Text = "Animals"
        Me.radioAni.UseVisualStyleBackColor = True
        '
        'radioComp
        '
        Me.radioComp.AutoSize = True
        Me.radioComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.radioComp.Location = New System.Drawing.Point(433, 279)
        Me.radioComp.Name = "radioComp"
        Me.radioComp.Size = New System.Drawing.Size(163, 35)
        Me.radioComp.TabIndex = 11
        Me.radioComp.TabStop = True
        Me.radioComp.Text = "Computing"
        Me.radioComp.UseVisualStyleBackColor = True
        '
        'lblSelectHeader
        '
        Me.lblSelectHeader.AutoSize = True
        Me.lblSelectHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectHeader.Location = New System.Drawing.Point(421, 204)
        Me.lblSelectHeader.Name = "lblSelectHeader"
        Me.lblSelectHeader.Size = New System.Drawing.Size(227, 31)
        Me.lblSelectHeader.TabIndex = 12
        Me.lblSelectHeader.Text = "Select Word List"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.LimeGreen
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnConfirm.ForeColor = System.Drawing.Color.Black
        Me.btnConfirm.Location = New System.Drawing.Point(463, 322)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(149, 43)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        Me.btnConfirm.Visible = False
        '
        'btnSortAlphabetically
        '
        Me.btnSortAlphabetically.BackgroundImage = CType(resources.GetObject("btnSortAlphabetically.BackgroundImage"), System.Drawing.Image)
        Me.btnSortAlphabetically.Location = New System.Drawing.Point(742, 78)
        Me.btnSortAlphabetically.Name = "btnSortAlphabetically"
        Me.btnSortAlphabetically.Size = New System.Drawing.Size(75, 44)
        Me.btnSortAlphabetically.TabIndex = 14
        Me.btnSortAlphabetically.UseVisualStyleBackColor = True
        '
        'btnSortByLen
        '
        Me.btnSortByLen.BackgroundImage = CType(resources.GetObject("btnSortByLen.BackgroundImage"), System.Drawing.Image)
        Me.btnSortByLen.Location = New System.Drawing.Point(817, 78)
        Me.btnSortByLen.Name = "btnSortByLen"
        Me.btnSortByLen.Size = New System.Drawing.Size(75, 44)
        Me.btnSortByLen.TabIndex = 15
        Me.btnSortByLen.UseVisualStyleBackColor = True
        '
        'lblWList
        '
        Me.lblWList.AutoSize = True
        Me.lblWList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWList.ForeColor = System.Drawing.Color.Black
        Me.lblWList.Location = New System.Drawing.Point(545, 86)
        Me.lblWList.Name = "lblWList"
        Me.lblWList.Size = New System.Drawing.Size(179, 25)
        Me.lblWList.TabIndex = 16
        Me.lblWList.Text = "Words To Place"
        Me.lblWList.Visible = False
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.Location = New System.Drawing.Point(421, 204)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(179, 31)
        Me.lblFinalScore.TabIndex = 17
        Me.lblFinalScore.Text = "Final Score: "
        Me.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinalScore.Visible = False
        '
        'btnEnterName
        '
        Me.btnEnterName.BackColor = System.Drawing.Color.LimeGreen
        Me.btnEnterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnEnterName.ForeColor = System.Drawing.Color.Black
        Me.btnEnterName.Location = New System.Drawing.Point(497, 322)
        Me.btnEnterName.Name = "btnEnterName"
        Me.btnEnterName.Size = New System.Drawing.Size(82, 43)
        Me.btnEnterName.TabIndex = 18
        Me.btnEnterName.Text = "Enter"
        Me.btnEnterName.UseVisualStyleBackColor = False
        Me.btnEnterName.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.txtName.Location = New System.Drawing.Point(497, 282)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 32)
        Me.txtName.TabIndex = 19
        Me.txtName.Visible = False
        '
        'lblHS
        '
        Me.lblHS.AutoSize = True
        Me.lblHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHS.Location = New System.Drawing.Point(422, 248)
        Me.lblHS.Name = "lblHS"
        Me.lblHS.Size = New System.Drawing.Size(217, 25)
        Me.lblHS.TabIndex = 20
        Me.lblHS.Text = "You got a High Score"
        Me.lblHS.Visible = False
        '
        'btnGoToHS
        '
        Me.btnGoToHS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGoToHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoToHS.ForeColor = System.Drawing.Color.Black
        Me.btnGoToHS.Location = New System.Drawing.Point(427, 378)
        Me.btnGoToHS.Name = "btnGoToHS"
        Me.btnGoToHS.Size = New System.Drawing.Size(218, 39)
        Me.btnGoToHS.TabIndex = 21
        Me.btnGoToHS.Text = "Go To High Scores"
        Me.btnGoToHS.UseVisualStyleBackColor = False
        Me.btnGoToHS.Visible = False
        '
        'HoverOverText
        '
        Me.HoverOverText.AutomaticDelay = 150
        '
        'BTCTimer
        '
        Me.BTCTimer.Interval = 1000
        '
        'lblBTCTime
        '
        Me.lblBTCTime.AutoSize = True
        Me.lblBTCTime.BackColor = System.Drawing.Color.LimeGreen
        Me.lblBTCTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBTCTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBTCTime.ForeColor = System.Drawing.Color.Black
        Me.lblBTCTime.Location = New System.Drawing.Point(10, 73)
        Me.lblBTCTime.Name = "lblBTCTime"
        Me.lblBTCTime.Size = New System.Drawing.Size(141, 33)
        Me.lblBTCTime.TabIndex = 22
        Me.lblBTCTime.Text = "TIME: 120"
        Me.lblBTCTime.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(422, 286)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(74, 25)
        Me.lblName.TabIndex = 23
        Me.lblName.Text = "Name:"
        Me.lblName.Visible = False
        '
        'frmPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(1104, 662)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblBTCTime)
        Me.Controls.Add(Me.btnGoToHS)
        Me.Controls.Add(Me.lblHS)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnEnterName)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lblWList)
        Me.Controls.Add(Me.btnSortByLen)
        Me.Controls.Add(Me.btnSortAlphabetically)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblSelectHeader)
        Me.Controls.Add(Me.radioComp)
        Me.Controls.Add(Me.radioAni)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblHeader)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Play"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents radioAni As System.Windows.Forms.RadioButton
    Friend WithEvents radioComp As System.Windows.Forms.RadioButton
    Friend WithEvents lblSelectHeader As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnSortAlphabetically As System.Windows.Forms.Button
    Friend WithEvents btnSortByLen As System.Windows.Forms.Button
    Friend WithEvents lblWList As System.Windows.Forms.Label
    Friend WithEvents lblFinalScore As System.Windows.Forms.Label
    Friend WithEvents btnEnterName As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblHS As System.Windows.Forms.Label
    Friend WithEvents btnGoToHS As System.Windows.Forms.Button
    Friend WithEvents HoverOverText As System.Windows.Forms.ToolTip
    Friend WithEvents BTCTimer As System.Windows.Forms.Timer
    Friend WithEvents lblBTCTime As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
