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
        Me.imgLoend = New System.Windows.Forms.ImageList(Me.components)
        Me.PbEmoticon = New System.Windows.Forms.PictureBox()
        CType(Me.PbEmoticon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLoend
        '
        Me.imgLoend.ImageStream = CType(resources.GetObject("imgLoend.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLoend.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLoend.Images.SetKeyName(0, "confused.png")
        Me.imgLoend.Images.SetKeyName(1, "cool.png")
        Me.imgLoend.Images.SetKeyName(2, "smile.png")
        Me.imgLoend.Images.SetKeyName(3, "star.png")
        Me.imgLoend.Images.SetKeyName(4, "teeth.png")
        Me.imgLoend.Images.SetKeyName(5, "yell.png")
        '
        'PbEmoticon
        '
        Me.PbEmoticon.Image = Global.PrjFaces.My.Resources.Resources.confused
        Me.PbEmoticon.Location = New System.Drawing.Point(52, 27)
        Me.PbEmoticon.Name = "PbEmoticon"
        Me.PbEmoticon.Size = New System.Drawing.Size(32, 32)
        Me.PbEmoticon.TabIndex = 1
        Me.PbEmoticon.TabStop = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PbEmoticon)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(800, 450)
        CType(Me.PbEmoticon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PbEmoticon As PictureBox
    Friend WithEvents imgLoend As ImageList
End Class
