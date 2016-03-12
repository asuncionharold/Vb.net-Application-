<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Letters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Letters))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pic1Vb = New System.Windows.Forms.PictureBox()
        Me.Pic2Vb = New System.Windows.Forms.PictureBox()
        Me.Pic3Vb = New System.Windows.Forms.PictureBox()
        CType(Me.Pic1Vb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2Vb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic3Vb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Pic1Vb
        '
        Me.Pic1Vb.BackColor = System.Drawing.Color.Transparent
        Me.Pic1Vb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic1Vb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic1Vb.Location = New System.Drawing.Point(75, 162)
        Me.Pic1Vb.MaximumSize = New System.Drawing.Size(253, 272)
        Me.Pic1Vb.Name = "Pic1Vb"
        Me.Pic1Vb.Size = New System.Drawing.Size(200, 200)
        Me.Pic1Vb.TabIndex = 30
        Me.Pic1Vb.TabStop = False
        '
        'Pic2Vb
        '
        Me.Pic2Vb.BackColor = System.Drawing.Color.Transparent
        Me.Pic2Vb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic2Vb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic2Vb.Location = New System.Drawing.Point(377, 162)
        Me.Pic2Vb.MaximumSize = New System.Drawing.Size(253, 272)
        Me.Pic2Vb.Name = "Pic2Vb"
        Me.Pic2Vb.Size = New System.Drawing.Size(200, 200)
        Me.Pic2Vb.TabIndex = 31
        Me.Pic2Vb.TabStop = False
        '
        'Pic3Vb
        '
        Me.Pic3Vb.BackColor = System.Drawing.Color.Transparent
        Me.Pic3Vb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pic3Vb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic3Vb.Location = New System.Drawing.Point(674, 162)
        Me.Pic3Vb.MaximumSize = New System.Drawing.Size(253, 272)
        Me.Pic3Vb.Name = "Pic3Vb"
        Me.Pic3Vb.Size = New System.Drawing.Size(200, 200)
        Me.Pic3Vb.TabIndex = 32
        Me.Pic3Vb.TabStop = False
        '
        'Letters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(960, 600)
        Me.Controls.Add(Me.Pic3Vb)
        Me.Controls.Add(Me.Pic2Vb)
        Me.Controls.Add(Me.Pic1Vb)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Letters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        CType(Me.Pic1Vb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2Vb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic3Vb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Pic1Vb As System.Windows.Forms.PictureBox
    Friend WithEvents Pic2Vb As System.Windows.Forms.PictureBox
    Friend WithEvents Pic3Vb As System.Windows.Forms.PictureBox
End Class
