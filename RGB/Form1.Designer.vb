<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.txtBoxGreen = New System.Windows.Forms.TextBox()
        Me.txtBoxBleu = New System.Windows.Forms.TextBox()
        Me.txtBoxRed = New System.Windows.Forms.TextBox()
        Me.generatRBG_color = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label_RGB = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RBG COLOR"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GREEN"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BLEU"
        '
        'label
        '
        Me.label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(47, 104)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(30, 13)
        Me.label.TabIndex = 0
        Me.label.Text = "RED"
        '
        'txtBoxGreen
        '
        Me.txtBoxGreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBoxGreen.Location = New System.Drawing.Point(278, 141)
        Me.txtBoxGreen.Name = "txtBoxGreen"
        Me.txtBoxGreen.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxGreen.TabIndex = 1
        '
        'txtBoxBleu
        '
        Me.txtBoxBleu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBoxBleu.Location = New System.Drawing.Point(523, 141)
        Me.txtBoxBleu.Name = "txtBoxBleu"
        Me.txtBoxBleu.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxBleu.TabIndex = 1
        '
        'txtBoxRed
        '
        Me.txtBoxRed.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBoxRed.Location = New System.Drawing.Point(50, 141)
        Me.txtBoxRed.Name = "txtBoxRed"
        Me.txtBoxRed.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxRed.TabIndex = 1
        '
        'generatRBG_color
        '
        Me.generatRBG_color.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.generatRBG_color.BackColor = System.Drawing.SystemColors.Control
        Me.generatRBG_color.Location = New System.Drawing.Point(523, 185)
        Me.generatRBG_color.Name = "generatRBG_color"
        Me.generatRBG_color.Size = New System.Drawing.Size(100, 48)
        Me.generatRBG_color.TabIndex = 2
        Me.generatRBG_color.Text = "Generate Color"
        Me.generatRBG_color.UseVisualStyleBackColor = False
        '
        'Label_RGB
        '
        Me.Label_RGB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_RGB.Location = New System.Drawing.Point(50, 239)
        Me.Label_RGB.Name = "Label_RGB"
        Me.Label_RGB.Size = New System.Drawing.Size(328, 151)
        Me.Label_RGB.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(33, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 197)
        Me.Label4.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(680, 437)
        Me.Controls.Add(Me.Label_RGB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.generatRBG_color)
        Me.Controls.Add(Me.txtBoxRed)
        Me.Controls.Add(Me.txtBoxBleu)
        Me.Controls.Add(Me.txtBoxGreen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "RGB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label As Label
    Friend WithEvents txtBoxGreen As TextBox
    Friend WithEvents txtBoxBleu As TextBox
    Friend WithEvents txtBoxRed As TextBox
    Friend WithEvents generatRBG_color As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label_RGB As Label
    Friend WithEvents Label4 As Label
End Class
