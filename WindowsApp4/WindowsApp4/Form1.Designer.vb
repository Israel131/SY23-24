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
        Me.components = New System.ComponentModel.Container()
        Me.PicPlayer = New System.Windows.Forms.PictureBox()
        Me.PicAir = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicPlayer
        '
        Me.PicPlayer.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PicPlayer.Location = New System.Drawing.Point(12, 318)
        Me.PicPlayer.Name = "PicPlayer"
        Me.PicPlayer.Size = New System.Drawing.Size(39, 37)
        Me.PicPlayer.TabIndex = 0
        Me.PicPlayer.TabStop = False
        '
        'PicAir
        '
        Me.PicAir.Location = New System.Drawing.Point(-4, 0)
        Me.PicAir.Name = "PicAir"
        Me.PicAir.Size = New System.Drawing.Size(805, 312)
        Me.PicAir.TabIndex = 1
        Me.PicAir.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.Location = New System.Drawing.Point(-4, 388)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(805, 50)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        '
        'tmrRight
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicGround)
        Me.Controls.Add(Me.PicAir)
        Me.Controls.Add(Me.PicPlayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicPlayer As PictureBox
    Friend WithEvents PicAir As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents tmrRight As Timer
End Class
