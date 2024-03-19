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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DollarB = New System.Windows.Forms.Button()
        Me.QuarterB = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(480, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(174, 114)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(127, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(327, 114)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(127, 123)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "slot1.PNG")
        Me.ImageList1.Images.SetKeyName(1, "slot2.PNG")
        Me.ImageList1.Images.SetKeyName(2, "slot3.PNG")
        Me.ImageList1.Images.SetKeyName(3, "slot1.PNG")
        Me.ImageList1.Images.SetKeyName(4, "slot3.PNG")
        Me.ImageList1.Images.SetKeyName(5, "slot2.PNG")
        Me.ImageList1.Images.SetKeyName(6, "slot1.PNG")
        Me.ImageList1.Images.SetKeyName(7, "slot3.PNG")
        Me.ImageList1.Images.SetKeyName(8, "slot2.PNG")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "slot3.PNG")
        Me.ImageList2.Images.SetKeyName(1, "slot2.PNG")
        Me.ImageList2.Images.SetKeyName(2, "slot1.PNG")
        Me.ImageList2.Images.SetKeyName(3, "slot1.PNG")
        Me.ImageList2.Images.SetKeyName(4, "slot2.PNG")
        Me.ImageList2.Images.SetKeyName(5, "slot3.PNG")
        Me.ImageList2.Images.SetKeyName(6, "slot2.PNG")
        Me.ImageList2.Images.SetKeyName(7, "slot1.PNG")
        Me.ImageList2.Images.SetKeyName(8, "slot2.PNG")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "slot2.PNG")
        Me.ImageList3.Images.SetKeyName(1, "slot1.PNG")
        Me.ImageList3.Images.SetKeyName(2, "slot3.PNG")
        Me.ImageList3.Images.SetKeyName(3, "slot1.PNG")
        Me.ImageList3.Images.SetKeyName(4, "slot3.PNG")
        Me.ImageList3.Images.SetKeyName(5, "slot2.PNG")
        Me.ImageList3.Images.SetKeyName(6, "slot1.PNG")
        Me.ImageList3.Images.SetKeyName(7, "slot3.PNG")
        Me.ImageList3.Images.SetKeyName(8, "slot2.PNG")
        '
        'Timer1
        '
        Me.Timer1.Interval = 65
        '
        'DollarB
        '
        Me.DollarB.Location = New System.Drawing.Point(42, 292)
        Me.DollarB.Name = "DollarB"
        Me.DollarB.Size = New System.Drawing.Size(75, 56)
        Me.DollarB.TabIndex = 5
        Me.DollarB.Text = "Button2"
        Me.DollarB.UseVisualStyleBackColor = True
        '
        'QuarterB
        '
        Me.QuarterB.Location = New System.Drawing.Point(157, 292)
        Me.QuarterB.Name = "QuarterB"
        Me.QuarterB.Size = New System.Drawing.Size(75, 56)
        Me.QuarterB.TabIndex = 6
        Me.QuarterB.Text = "Button3"
        Me.QuarterB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuarterB)
        Me.Controls.Add(Me.DollarB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DollarB As Button
    Friend WithEvents QuarterB As Button
    Friend WithEvents Label2 As Label
End Class
