<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnHowToPlay = New System.Windows.Forms.Button()
        Me.btnScoring = New System.Windows.Forms.Button()
        Me.btnGeneral = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(-1, 14)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1109, 130)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "HELP"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHelp
        '
        Me.lblHelp.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHelp.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ForeColor = System.Drawing.Color.White
        Me.lblHelp.Location = New System.Drawing.Point(210, 165)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(660, 290)
        Me.lblHelp.TabIndex = 4
        Me.lblHelp.Text = "Text goes here"
        '
        'PictureBox
        '
        Me.PictureBox.BackgroundImage = Global.WordMax.My.Resources.Resources.in_gamehelp
        Me.PictureBox.Location = New System.Drawing.Point(135, 125)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(833, 491)
        Me.PictureBox.TabIndex = 5
        Me.PictureBox.TabStop = False
        Me.PictureBox.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(968, 14)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(124, 39)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "CLOSE"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnHowToPlay
        '
        Me.btnHowToPlay.BackColor = System.Drawing.Color.GreenYellow
        Me.btnHowToPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnHowToPlay.ForeColor = System.Drawing.Color.Black
        Me.btnHowToPlay.Location = New System.Drawing.Point(448, 622)
        Me.btnHowToPlay.Name = "btnHowToPlay"
        Me.btnHowToPlay.Size = New System.Drawing.Size(217, 39)
        Me.btnHowToPlay.TabIndex = 10
        Me.btnHowToPlay.Text = "HOW TO PLAY"
        Me.btnHowToPlay.UseVisualStyleBackColor = False
        '
        'btnScoring
        '
        Me.btnScoring.BackColor = System.Drawing.Color.GreenYellow
        Me.btnScoring.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnScoring.ForeColor = System.Drawing.Color.Black
        Me.btnScoring.Location = New System.Drawing.Point(751, 622)
        Me.btnScoring.Name = "btnScoring"
        Me.btnScoring.Size = New System.Drawing.Size(217, 39)
        Me.btnScoring.TabIndex = 11
        Me.btnScoring.Text = "SCORING"
        Me.btnScoring.UseVisualStyleBackColor = False
        '
        'btnGeneral
        '
        Me.btnGeneral.BackColor = System.Drawing.Color.GreenYellow
        Me.btnGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnGeneral.ForeColor = System.Drawing.Color.Black
        Me.btnGeneral.Location = New System.Drawing.Point(135, 622)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(217, 39)
        Me.btnGeneral.TabIndex = 12
        Me.btnGeneral.Text = "GENERAL"
        Me.btnGeneral.UseVisualStyleBackColor = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1104, 662)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.btnScoring)
        Me.Controls.Add(Me.btnHowToPlay)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.lblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnHowToPlay As System.Windows.Forms.Button
    Friend WithEvents btnScoring As System.Windows.Forms.Button
    Friend WithEvents btnGeneral As System.Windows.Forms.Button
End Class
