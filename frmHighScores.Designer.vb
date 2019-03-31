<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHighScores))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.listBTCHighScores = New System.Windows.Forms.ListBox()
        Me.listClassicHighScores = New System.Windows.Forms.ListBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Snow
        Me.lblHeader.Location = New System.Drawing.Point(0, -3)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1105, 98)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "High Scores"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listBTCHighScores
        '
        Me.listBTCHighScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.listBTCHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listBTCHighScores.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBTCHighScores.ForeColor = System.Drawing.Color.White
        Me.listBTCHighScores.FormattingEnabled = True
        Me.listBTCHighScores.ItemHeight = 26
        Me.listBTCHighScores.Items.AddRange(New Object() {"Beat The Clock:"})
        Me.listBTCHighScores.Location = New System.Drawing.Point(558, 214)
        Me.listBTCHighScores.Name = "listBTCHighScores"
        Me.listBTCHighScores.Size = New System.Drawing.Size(245, 286)
        Me.listBTCHighScores.TabIndex = 5
        '
        'listClassicHighScores
        '
        Me.listClassicHighScores.BackColor = System.Drawing.Color.Green
        Me.listClassicHighScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listClassicHighScores.Font = New System.Drawing.Font("Candara", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listClassicHighScores.ForeColor = System.Drawing.Color.White
        Me.listClassicHighScores.FormattingEnabled = True
        Me.listClassicHighScores.ItemHeight = 26
        Me.listClassicHighScores.Items.AddRange(New Object() {"Classic:"})
        Me.listClassicHighScores.Location = New System.Drawing.Point(301, 214)
        Me.listClassicHighScores.Name = "listClassicHighScores"
        Me.listClassicHighScores.Size = New System.Drawing.Size(245, 286)
        Me.listClassicHighScores.TabIndex = 4
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(979, 10)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(113, 39)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "HOME"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'frmHighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1104, 662)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.listBTCHighScores)
        Me.Controls.Add(Me.listClassicHighScores)
        Me.Controls.Add(Me.lblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHighScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "High Scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents listBTCHighScores As System.Windows.Forms.ListBox
    Friend WithEvents listClassicHighScores As System.Windows.Forms.ListBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
End Class
