<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGO
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainText = New System.Windows.Forms.Label()
        Me.Picture_LOGO = New System.Windows.Forms.PictureBox()
        Me.lbl_subtitle = New System.Windows.Forms.Label()
        CType(Me.Picture_LOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainText
        '
        Me.MainText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainText.Location = New System.Drawing.Point(12, 57)
        Me.MainText.Name = "MainText"
        Me.MainText.Size = New System.Drawing.Size(251, 36)
        Me.MainText.TabIndex = 0
        Me.MainText.Text = "LOGO"
        Me.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Picture_LOGO
        '
        Me.Picture_LOGO.Location = New System.Drawing.Point(107, 1)
        Me.Picture_LOGO.Name = "Picture_LOGO"
        Me.Picture_LOGO.Size = New System.Drawing.Size(60, 60)
        Me.Picture_LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture_LOGO.TabIndex = 1
        Me.Picture_LOGO.TabStop = False
        '
        'lbl_subtitle
        '
        Me.lbl_subtitle.Location = New System.Drawing.Point(12, 93)
        Me.lbl_subtitle.Name = "lbl_subtitle"
        Me.lbl_subtitle.Size = New System.Drawing.Size(251, 21)
        Me.lbl_subtitle.TabIndex = 2
        Me.lbl_subtitle.Text = "Label1"
        Me.lbl_subtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LOGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 128)
        Me.Controls.Add(Me.lbl_subtitle)
        Me.Controls.Add(Me.Picture_LOGO)
        Me.Controls.Add(Me.MainText)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LOGO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.Picture_LOGO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents MainText As Label
    Friend WithEvents Picture_LOGO As PictureBox
    Friend WithEvents lbl_subtitle As Label
End Class
