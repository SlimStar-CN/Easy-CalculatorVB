<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aboutme
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aboutme))
        Picture = New PictureBox()
        MyName = New Label()
        Label1 = New Label()
        LinkLabel = New LinkLabel()
        CType(Picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Picture
        ' 
        Picture.Anchor = AnchorStyles.None
        Picture.BorderStyle = BorderStyle.FixedSingle
        Picture.Image = CType(resources.GetObject("Picture.Image"), Image)
        Picture.Location = New Point(28, 28)
        Picture.Name = "Picture"
        Picture.Size = New Size(142, 139)
        Picture.SizeMode = PictureBoxSizeMode.Zoom
        Picture.TabIndex = 0
        Picture.TabStop = False
        ' 
        ' MyName
        ' 
        MyName.Anchor = AnchorStyles.None
        MyName.AutoSize = True
        MyName.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MyName.Location = New Point(210, 34)
        MyName.Name = "MyName"
        MyName.Size = New Size(190, 26)
        MyName.TabIndex = 1
        MyName.Text = "简易计算器 V1.0"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(210, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 26)
        Label1.TabIndex = 2
        Label1.Text = "版权所有 © 2026 DonGhost"
        ' 
        ' LinkLabel
        ' 
        LinkLabel.Anchor = AnchorStyles.None
        LinkLabel.AutoSize = True
        LinkLabel.Font = New Font("Times New Roman", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel.Location = New Point(288, 141)
        LinkLabel.Name = "LinkLabel"
        LinkLabel.Size = New Size(112, 26)
        LinkLabel.TabIndex = 3
        LinkLabel.TabStop = True
        LinkLabel.Text = "我的网址"
        ' 
        ' Aboutme
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(531, 188)
        Controls.Add(LinkLabel)
        Controls.Add(Label1)
        Controls.Add(MyName)
        Controls.Add(Picture)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "Aboutme"
        Text = "帮助"
        CType(Picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Picture As PictureBox
    Friend WithEvents MyName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel As LinkLabel
End Class
