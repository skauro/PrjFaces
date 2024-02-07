<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Me.pbEmoticon = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbEmoticon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbEmoticon
        '
        Me.pbEmoticon.Location = New System.Drawing.Point(256, 148)
        Me.pbEmoticon.Name = "pbEmoticon"
        Me.pbEmoticon.Size = New System.Drawing.Size(32, 32)
        Me.pbEmoticon.TabIndex = 0
        Me.pbEmoticon.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "confused.png")
        Me.ImageList1.Images.SetKeyName(1, "cool.png")
        Me.ImageList1.Images.SetKeyName(2, "smile.png")
        Me.ImageList1.Images.SetKeyName(3, "star.png")
        Me.ImageList1.Images.SetKeyName(4, "teeth.png")
        Me.ImageList1.Images.SetKeyName(5, "yell.png")
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbEmoticon)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.pbEmoticon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbEmoticon As PictureBox
    Friend WithEvents ImageList1 As ImageList
End Class
