<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mother_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mother_Form))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HourTb = New System.Windows.Forms.TextBox()
        Me.MinuteTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SecondTb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SoundVb = New System.Windows.Forms.PictureBox()
        Me.OnBt = New System.Windows.Forms.Button()
        Me.OffBt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.SoundVb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("American Purpose STRIPE 1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(263, 531)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 43)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("American Purpose STRIPE 1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(389, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("American Purpose STRIPE 1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(201, 415)
        Me.Label5.Margin = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SET TIMER"
        '
        'HourTb
        '
        Me.HourTb.Font = New System.Drawing.Font("American Purpose STRIPE 1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HourTb.Location = New System.Drawing.Point(342, 412)
        Me.HourTb.Multiline = True
        Me.HourTb.Name = "HourTb"
        Me.HourTb.Size = New System.Drawing.Size(45, 29)
        Me.HourTb.TabIndex = 10
        '
        'MinuteTb
        '
        Me.MinuteTb.Font = New System.Drawing.Font("American Purpose STRIPE 1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinuteTb.Location = New System.Drawing.Point(408, 412)
        Me.MinuteTb.Multiline = True
        Me.MinuteTb.Name = "MinuteTb"
        Me.MinuteTb.Size = New System.Drawing.Size(45, 29)
        Me.MinuteTb.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("American Purpose STRIPE 1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(455, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = ":"
        '
        'SecondTb
        '
        Me.SecondTb.Font = New System.Drawing.Font("American Purpose STRIPE 1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondTb.Location = New System.Drawing.Point(473, 412)
        Me.SecondTb.Multiline = True
        Me.SecondTb.Name = "SecondTb"
        Me.SecondTb.Size = New System.Drawing.Size(45, 29)
        Me.SecondTb.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("American Purpose STRIPE 1", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(349, 447)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "HH"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("American Purpose STRIPE 1", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(414, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "MM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("American Purpose STRIPE 1", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(481, 447)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "SS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("American Purpose STRIPE 1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(201, 486)
        Me.Label9.Margin = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 29)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "MUSIC"
        '
        'SoundVb
        '
        Me.SoundVb.BackColor = System.Drawing.Color.Transparent
        Me.SoundVb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SoundVb.Location = New System.Drawing.Point(479, 482)
        Me.SoundVb.MaximumSize = New System.Drawing.Size(253, 272)
        Me.SoundVb.Name = "SoundVb"
        Me.SoundVb.Size = New System.Drawing.Size(22, 33)
        Me.SoundVb.TabIndex = 29
        Me.SoundVb.TabStop = False
        '
        'OnBt
        '
        Me.OnBt.Font = New System.Drawing.Font("American Purpose STRIPE 1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnBt.ForeColor = System.Drawing.Color.Black
        Me.OnBt.Location = New System.Drawing.Point(342, 484)
        Me.OnBt.Name = "OnBt"
        Me.OnBt.Size = New System.Drawing.Size(63, 29)
        Me.OnBt.TabIndex = 30
        Me.OnBt.Text = "ON"
        Me.OnBt.UseVisualStyleBackColor = True
        '
        'OffBt
        '
        Me.OffBt.Font = New System.Drawing.Font("American Purpose STRIPE 1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OffBt.ForeColor = System.Drawing.Color.Black
        Me.OffBt.Location = New System.Drawing.Point(408, 484)
        Me.OffBt.Name = "OffBt"
        Me.OffBt.Size = New System.Drawing.Size(63, 29)
        Me.OffBt.TabIndex = 31
        Me.OffBt.Text = "OFF"
        Me.OffBt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("American Purpose STRIPE 1", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(106, 365)
        Me.Label2.Margin = New System.Windows.Forms.Padding(16, 0, 16, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PARENTS ACCESS"
        '
        'Mother_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(33.0!, 62.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(960, 600)
        Me.Controls.Add(Me.OffBt)
        Me.Controls.Add(Me.OnBt)
        Me.Controls.Add(Me.SoundVb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SecondTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MinuteTb)
        Me.Controls.Add(Me.HourTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("American Purpose STRIPE 1", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(16, 14, 16, 14)
        Me.Name = "Mother_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SoundVb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents HourTb As System.Windows.Forms.TextBox
    Friend WithEvents MinuteTb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SecondTb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SoundVb As System.Windows.Forms.PictureBox
    Friend WithEvents OnBt As System.Windows.Forms.Button
    Friend WithEvents OffBt As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
