<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_galance = New System.Windows.Forms.Button()
        Me.btn_backup = New System.Windows.Forms.Button()
        Me.btn_ext = New System.Windows.Forms.Button()
        Me.btn_customize = New System.Windows.Forms.Button()
        Me.btn_settings = New System.Windows.Forms.Button()
        Me.btn_about = New System.Windows.Forms.Button()
        Me.lbl_bg = New System.Windows.Forms.Label()
        Me.Tab_dd = New System.Windows.Forms.TabControl()
        Me.Tab_galance = New System.Windows.Forms.TabPage()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_UpdateHosts = New System.Windows.Forms.Button()
        Me.lbl_RemoteVer = New System.Windows.Forms.Label()
        Me.lbl_AppVer = New System.Windows.Forms.Label()
        Me.lbl_ExtVer = New System.Windows.Forms.Label()
        Me.lbl_LastCheckDate = New System.Windows.Forms.Label()
        Me.lbl_LastUpdateDate = New System.Windows.Forms.Label()
        Me.lbl_LocalVer = New System.Windows.Forms.Label()
        Me.lbl_Ext = New System.Windows.Forms.Label()
        Me.Tab_backup = New System.Windows.Forms.TabPage()
        Me.btn_Restore = New System.Windows.Forms.Button()
        Me.btn_DelBak = New System.Windows.Forms.Button()
        Me.btn_Bak = New System.Windows.Forms.Button()
        Me.list_backup = New System.Windows.Forms.ListBox()
        Me.Tab_ext = New System.Windows.Forms.TabPage()
        Me.lbl_ExtVersion_Text = New System.Windows.Forms.Label()
        Me.lbl_ExtAuthor_Text = New System.Windows.Forms.Label()
        Me.btn_DownloadExt = New System.Windows.Forms.Button()
        Me.lbl_ExtDescription = New System.Windows.Forms.Label()
        Me.lbl_Description = New System.Windows.Forms.Label()
        Me.btn_ApplyExt = New System.Windows.Forms.Button()
        Me.link_Ext = New System.Windows.Forms.LinkLabel()
        Me.lbl_ExtLink = New System.Windows.Forms.Label()
        Me.lbl_ExtAuthor = New System.Windows.Forms.Label()
        Me.lbl_ExtVersion = New System.Windows.Forms.Label()
        Me.cb_ExtList = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tab_customize = New System.Windows.Forms.TabPage()
        Me.lbl_CStatus = New System.Windows.Forms.Label()
        Me.btn_DelChosts = New System.Windows.Forms.Button()
        Me.btn_Edit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Tab_settings = New System.Windows.Forms.TabPage()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.cb_language = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_AutoBackup = New System.Windows.Forms.CheckBox()
        Me.cb_Flushdns = New System.Windows.Forms.CheckBox()
        Me.cb_AutoUpdate = New System.Windows.Forms.CheckBox()
        Me.cb_Notify = New System.Windows.Forms.CheckBox()
        Me.cb_AutoStart = New System.Windows.Forms.CheckBox()
        Me.Tab_about = New System.Windows.Forms.TabPage()
        Me.btn_faq = New System.Windows.Forms.Button()
        Me.btn_upgrade = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_AppVer2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_Network = New System.Windows.Forms.PictureBox()
        Me.lbl_Network = New System.Windows.Forms.Label()
        Me.lbl_line = New System.Windows.Forms.Label()
        Me.APP_NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.APP_ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.T_ShowWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.T_End = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab_dd.SuspendLayout()
        Me.Tab_galance.SuspendLayout()
        Me.Tab_backup.SuspendLayout()
        Me.Tab_ext.SuspendLayout()
        Me.Tab_customize.SuspendLayout()
        Me.Tab_settings.SuspendLayout()
        Me.Tab_about.SuspendLayout()
        CType(Me.pic_Network, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.APP_ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_galance
        '
        Me.btn_galance.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_galance.FlatAppearance.BorderSize = 0
        Me.btn_galance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_galance.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_galance.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_galance.Location = New System.Drawing.Point(0, 0)
        Me.btn_galance.Name = "btn_galance"
        Me.btn_galance.Size = New System.Drawing.Size(137, 44)
        Me.btn_galance.TabIndex = 0
        Me.btn_galance.Text = " 软件概览"
        Me.btn_galance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_galance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_galance.UseVisualStyleBackColor = False
        '
        'btn_backup
        '
        Me.btn_backup.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_backup.FlatAppearance.BorderSize = 0
        Me.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_backup.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_backup.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_backup.Location = New System.Drawing.Point(0, 44)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.Size = New System.Drawing.Size(137, 44)
        Me.btn_backup.TabIndex = 1
        Me.btn_backup.Text = " 备份还原"
        Me.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_backup.UseVisualStyleBackColor = False
        '
        'btn_ext
        '
        Me.btn_ext.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_ext.FlatAppearance.BorderSize = 0
        Me.btn_ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ext.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_ext.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_ext.Location = New System.Drawing.Point(0, 88)
        Me.btn_ext.Name = "btn_ext"
        Me.btn_ext.Size = New System.Drawing.Size(137, 44)
        Me.btn_ext.TabIndex = 2
        Me.btn_ext.Text = " 扩展配置"
        Me.btn_ext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ext.UseVisualStyleBackColor = False
        '
        'btn_customize
        '
        Me.btn_customize.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_customize.FlatAppearance.BorderSize = 0
        Me.btn_customize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_customize.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_customize.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_customize.Location = New System.Drawing.Point(0, 132)
        Me.btn_customize.Name = "btn_customize"
        Me.btn_customize.Size = New System.Drawing.Size(137, 44)
        Me.btn_customize.TabIndex = 3
        Me.btn_customize.Text = " 本地配置"
        Me.btn_customize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_customize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_customize.UseVisualStyleBackColor = False
        '
        'btn_settings
        '
        Me.btn_settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_settings.FlatAppearance.BorderSize = 0
        Me.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_settings.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_settings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_settings.Location = New System.Drawing.Point(0, 176)
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(137, 44)
        Me.btn_settings.TabIndex = 4
        Me.btn_settings.Text = " 软件设置"
        Me.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_settings.UseVisualStyleBackColor = False
        '
        'btn_about
        '
        Me.btn_about.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btn_about.FlatAppearance.BorderSize = 0
        Me.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_about.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_about.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_about.Location = New System.Drawing.Point(0, 220)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(137, 44)
        Me.btn_about.TabIndex = 5
        Me.btn_about.Text = " 关于软件"
        Me.btn_about.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_about.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_about.UseVisualStyleBackColor = False
        '
        'lbl_bg
        '
        Me.lbl_bg.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lbl_bg.Location = New System.Drawing.Point(0, 0)
        Me.lbl_bg.Name = "lbl_bg"
        Me.lbl_bg.Size = New System.Drawing.Size(137, 1500)
        Me.lbl_bg.TabIndex = 6
        '
        'Tab_dd
        '
        Me.Tab_dd.Controls.Add(Me.Tab_galance)
        Me.Tab_dd.Controls.Add(Me.Tab_backup)
        Me.Tab_dd.Controls.Add(Me.Tab_ext)
        Me.Tab_dd.Controls.Add(Me.Tab_customize)
        Me.Tab_dd.Controls.Add(Me.Tab_settings)
        Me.Tab_dd.Controls.Add(Me.Tab_about)
        Me.Tab_dd.Location = New System.Drawing.Point(103, -51)
        Me.Tab_dd.Name = "Tab_dd"
        Me.Tab_dd.SelectedIndex = 0
        Me.Tab_dd.Size = New System.Drawing.Size(471, 470)
        Me.Tab_dd.TabIndex = 7
        '
        'Tab_galance
        '
        Me.Tab_galance.Controls.Add(Me.btn_clear)
        Me.Tab_galance.Controls.Add(Me.btn_UpdateHosts)
        Me.Tab_galance.Controls.Add(Me.lbl_RemoteVer)
        Me.Tab_galance.Controls.Add(Me.lbl_AppVer)
        Me.Tab_galance.Controls.Add(Me.lbl_ExtVer)
        Me.Tab_galance.Controls.Add(Me.lbl_LastCheckDate)
        Me.Tab_galance.Controls.Add(Me.lbl_LastUpdateDate)
        Me.Tab_galance.Controls.Add(Me.lbl_LocalVer)
        Me.Tab_galance.Controls.Add(Me.lbl_Ext)
        Me.Tab_galance.Location = New System.Drawing.Point(4, 29)
        Me.Tab_galance.Name = "Tab_galance"
        Me.Tab_galance.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_galance.Size = New System.Drawing.Size(463, 437)
        Me.Tab_galance.TabIndex = 0
        Me.Tab_galance.Text = "TabPage1"
        Me.Tab_galance.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Silver
        Me.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Location = New System.Drawing.Point(105, 299)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(120, 29)
        Me.btn_clear.TabIndex = 8
        Me.btn_clear.Text = "清除hosts文件"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_UpdateHosts
        '
        Me.btn_UpdateHosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_UpdateHosts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_UpdateHosts.FlatAppearance.BorderSize = 0
        Me.btn_UpdateHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_UpdateHosts.ForeColor = System.Drawing.Color.White
        Me.btn_UpdateHosts.Location = New System.Drawing.Point(231, 299)
        Me.btn_UpdateHosts.Name = "btn_UpdateHosts"
        Me.btn_UpdateHosts.Size = New System.Drawing.Size(120, 29)
        Me.btn_UpdateHosts.TabIndex = 7
        Me.btn_UpdateHosts.Text = "更新hosts文件"
        Me.btn_UpdateHosts.UseVisualStyleBackColor = False
        '
        'lbl_RemoteVer
        '
        Me.lbl_RemoteVer.AutoSize = True
        Me.lbl_RemoteVer.Location = New System.Drawing.Point(46, 146)
        Me.lbl_RemoteVer.Name = "lbl_RemoteVer"
        Me.lbl_RemoteVer.Size = New System.Drawing.Size(120, 20)
        Me.lbl_RemoteVer.TabIndex = 6
        Me.lbl_RemoteVer.Text = "线上hosts版本：-"
        '
        'lbl_AppVer
        '
        Me.lbl_AppVer.AutoSize = True
        Me.lbl_AppVer.Location = New System.Drawing.Point(46, 268)
        Me.lbl_AppVer.Name = "lbl_AppVer"
        Me.lbl_AppVer.Size = New System.Drawing.Size(113, 20)
        Me.lbl_AppVer.TabIndex = 5
        Me.lbl_AppVer.Text = "应用程序版本：-"
        '
        'lbl_ExtVer
        '
        Me.lbl_ExtVer.AutoSize = True
        Me.lbl_ExtVer.Location = New System.Drawing.Point(46, 68)
        Me.lbl_ExtVer.Name = "lbl_ExtVer"
        Me.lbl_ExtVer.Size = New System.Drawing.Size(99, 20)
        Me.lbl_ExtVer.TabIndex = 4
        Me.lbl_ExtVer.Text = "扩展版本号：-"
        '
        'lbl_LastCheckDate
        '
        Me.lbl_LastCheckDate.AutoSize = True
        Me.lbl_LastCheckDate.Location = New System.Drawing.Point(46, 190)
        Me.lbl_LastCheckDate.Name = "lbl_LastCheckDate"
        Me.lbl_LastCheckDate.Size = New System.Drawing.Size(113, 20)
        Me.lbl_LastCheckDate.TabIndex = 3
        Me.lbl_LastCheckDate.Text = "检查版本时间：-"
        '
        'lbl_LastUpdateDate
        '
        Me.lbl_LastUpdateDate.AutoSize = True
        Me.lbl_LastUpdateDate.Location = New System.Drawing.Point(46, 224)
        Me.lbl_LastUpdateDate.Name = "lbl_LastUpdateDate"
        Me.lbl_LastUpdateDate.Size = New System.Drawing.Size(113, 20)
        Me.lbl_LastUpdateDate.TabIndex = 2
        Me.lbl_LastUpdateDate.Text = "上次更新时间：-"
        '
        'lbl_LocalVer
        '
        Me.lbl_LocalVer.AutoSize = True
        Me.lbl_LocalVer.Location = New System.Drawing.Point(46, 112)
        Me.lbl_LocalVer.Name = "lbl_LocalVer"
        Me.lbl_LocalVer.Size = New System.Drawing.Size(120, 20)
        Me.lbl_LocalVer.TabIndex = 1
        Me.lbl_LocalVer.Text = "本地hosts版本：-"
        '
        'lbl_Ext
        '
        Me.lbl_Ext.AutoSize = True
        Me.lbl_Ext.Location = New System.Drawing.Point(46, 34)
        Me.lbl_Ext.Name = "lbl_Ext"
        Me.lbl_Ext.Size = New System.Drawing.Size(99, 20)
        Me.lbl_Ext.TabIndex = 0
        Me.lbl_Ext.Text = "启用的扩展：-"
        '
        'Tab_backup
        '
        Me.Tab_backup.Controls.Add(Me.btn_Restore)
        Me.Tab_backup.Controls.Add(Me.btn_DelBak)
        Me.Tab_backup.Controls.Add(Me.btn_Bak)
        Me.Tab_backup.Controls.Add(Me.list_backup)
        Me.Tab_backup.Location = New System.Drawing.Point(4, 29)
        Me.Tab_backup.Name = "Tab_backup"
        Me.Tab_backup.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_backup.Size = New System.Drawing.Size(463, 437)
        Me.Tab_backup.TabIndex = 1
        Me.Tab_backup.Text = "TabPage2"
        Me.Tab_backup.UseVisualStyleBackColor = True
        '
        'btn_Restore
        '
        Me.btn_Restore.BackColor = System.Drawing.Color.Silver
        Me.btn_Restore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Restore.FlatAppearance.BorderSize = 0
        Me.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Restore.Location = New System.Drawing.Point(272, 301)
        Me.btn_Restore.Name = "btn_Restore"
        Me.btn_Restore.Size = New System.Drawing.Size(81, 29)
        Me.btn_Restore.TabIndex = 3
        Me.btn_Restore.Text = "还原文件"
        Me.btn_Restore.UseVisualStyleBackColor = False
        '
        'btn_DelBak
        '
        Me.btn_DelBak.BackColor = System.Drawing.Color.Silver
        Me.btn_DelBak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_DelBak.FlatAppearance.BorderSize = 0
        Me.btn_DelBak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DelBak.Location = New System.Drawing.Point(185, 301)
        Me.btn_DelBak.Name = "btn_DelBak"
        Me.btn_DelBak.Size = New System.Drawing.Size(81, 29)
        Me.btn_DelBak.TabIndex = 2
        Me.btn_DelBak.Text = "删除备份"
        Me.btn_DelBak.UseVisualStyleBackColor = False
        '
        'btn_Bak
        '
        Me.btn_Bak.BackColor = System.Drawing.Color.Silver
        Me.btn_Bak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Bak.FlatAppearance.BorderSize = 0
        Me.btn_Bak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Bak.Location = New System.Drawing.Point(97, 301)
        Me.btn_Bak.Name = "btn_Bak"
        Me.btn_Bak.Size = New System.Drawing.Size(81, 29)
        Me.btn_Bak.TabIndex = 1
        Me.btn_Bak.Text = "立即备份"
        Me.btn_Bak.UseVisualStyleBackColor = False
        '
        'list_backup
        '
        Me.list_backup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_backup.FormattingEnabled = True
        Me.list_backup.ItemHeight = 20
        Me.list_backup.Location = New System.Drawing.Point(36, 31)
        Me.list_backup.Name = "list_backup"
        Me.list_backup.ScrollAlwaysVisible = True
        Me.list_backup.Size = New System.Drawing.Size(317, 262)
        Me.list_backup.Sorted = True
        Me.list_backup.TabIndex = 0
        '
        'Tab_ext
        '
        Me.Tab_ext.Controls.Add(Me.lbl_ExtVersion_Text)
        Me.Tab_ext.Controls.Add(Me.lbl_ExtAuthor_Text)
        Me.Tab_ext.Controls.Add(Me.btn_DownloadExt)
        Me.Tab_ext.Controls.Add(Me.lbl_ExtDescription)
        Me.Tab_ext.Controls.Add(Me.lbl_Description)
        Me.Tab_ext.Controls.Add(Me.btn_ApplyExt)
        Me.Tab_ext.Controls.Add(Me.link_Ext)
        Me.Tab_ext.Controls.Add(Me.lbl_ExtLink)
        Me.Tab_ext.Controls.Add(Me.lbl_ExtAuthor)
        Me.Tab_ext.Controls.Add(Me.lbl_ExtVersion)
        Me.Tab_ext.Controls.Add(Me.cb_ExtList)
        Me.Tab_ext.Controls.Add(Me.Label5)
        Me.Tab_ext.Location = New System.Drawing.Point(4, 29)
        Me.Tab_ext.Name = "Tab_ext"
        Me.Tab_ext.Size = New System.Drawing.Size(463, 437)
        Me.Tab_ext.TabIndex = 2
        Me.Tab_ext.Text = " "
        Me.Tab_ext.UseVisualStyleBackColor = True
        '
        'lbl_ExtVersion_Text
        '
        Me.lbl_ExtVersion_Text.AutoSize = True
        Me.lbl_ExtVersion_Text.Location = New System.Drawing.Point(117, 76)
        Me.lbl_ExtVersion_Text.Name = "lbl_ExtVersion_Text"
        Me.lbl_ExtVersion_Text.Size = New System.Drawing.Size(15, 20)
        Me.lbl_ExtVersion_Text.TabIndex = 14
        Me.lbl_ExtVersion_Text.Text = "-"
        '
        'lbl_ExtAuthor_Text
        '
        Me.lbl_ExtAuthor_Text.AutoSize = True
        Me.lbl_ExtAuthor_Text.Location = New System.Drawing.Point(117, 107)
        Me.lbl_ExtAuthor_Text.Name = "lbl_ExtAuthor_Text"
        Me.lbl_ExtAuthor_Text.Size = New System.Drawing.Size(15, 20)
        Me.lbl_ExtAuthor_Text.TabIndex = 13
        Me.lbl_ExtAuthor_Text.Text = "-"
        '
        'btn_DownloadExt
        '
        Me.btn_DownloadExt.BackColor = System.Drawing.Color.Silver
        Me.btn_DownloadExt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_DownloadExt.FlatAppearance.BorderSize = 0
        Me.btn_DownloadExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DownloadExt.Location = New System.Drawing.Point(159, 298)
        Me.btn_DownloadExt.Name = "btn_DownloadExt"
        Me.btn_DownloadExt.Size = New System.Drawing.Size(92, 29)
        Me.btn_DownloadExt.TabIndex = 12
        Me.btn_DownloadExt.Text = "更多扩展"
        Me.btn_DownloadExt.UseVisualStyleBackColor = False
        '
        'lbl_ExtDescription
        '
        Me.lbl_ExtDescription.AutoSize = True
        Me.lbl_ExtDescription.Location = New System.Drawing.Point(36, 169)
        Me.lbl_ExtDescription.Name = "lbl_ExtDescription"
        Me.lbl_ExtDescription.Size = New System.Drawing.Size(79, 20)
        Me.lbl_ExtDescription.TabIndex = 7
        Me.lbl_ExtDescription.Text = "扩展简介："
        '
        'lbl_Description
        '
        Me.lbl_Description.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Description.ForeColor = System.Drawing.Color.Black
        Me.lbl_Description.Location = New System.Drawing.Point(118, 172)
        Me.lbl_Description.Name = "lbl_Description"
        Me.lbl_Description.Size = New System.Drawing.Size(228, 117)
        Me.lbl_Description.TabIndex = 11
        Me.lbl_Description.Text = "-"
        '
        'btn_ApplyExt
        '
        Me.btn_ApplyExt.BackColor = System.Drawing.Color.Silver
        Me.btn_ApplyExt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_ApplyExt.FlatAppearance.BorderSize = 0
        Me.btn_ApplyExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ApplyExt.Location = New System.Drawing.Point(257, 298)
        Me.btn_ApplyExt.Name = "btn_ApplyExt"
        Me.btn_ApplyExt.Size = New System.Drawing.Size(92, 29)
        Me.btn_ApplyExt.TabIndex = 9
        Me.btn_ApplyExt.Text = "使用此扩展"
        Me.btn_ApplyExt.UseVisualStyleBackColor = False
        '
        'link_Ext
        '
        Me.link_Ext.AutoSize = True
        Me.link_Ext.Location = New System.Drawing.Point(117, 138)
        Me.link_Ext.Name = "link_Ext"
        Me.link_Ext.Size = New System.Drawing.Size(15, 20)
        Me.link_Ext.TabIndex = 8
        Me.link_Ext.TabStop = True
        Me.link_Ext.Text = "-"
        '
        'lbl_ExtLink
        '
        Me.lbl_ExtLink.AutoSize = True
        Me.lbl_ExtLink.Location = New System.Drawing.Point(36, 138)
        Me.lbl_ExtLink.Name = "lbl_ExtLink"
        Me.lbl_ExtLink.Size = New System.Drawing.Size(79, 20)
        Me.lbl_ExtLink.TabIndex = 6
        Me.lbl_ExtLink.Text = "支持链接："
        '
        'lbl_ExtAuthor
        '
        Me.lbl_ExtAuthor.AutoSize = True
        Me.lbl_ExtAuthor.Location = New System.Drawing.Point(36, 107)
        Me.lbl_ExtAuthor.Name = "lbl_ExtAuthor"
        Me.lbl_ExtAuthor.Size = New System.Drawing.Size(79, 20)
        Me.lbl_ExtAuthor.TabIndex = 5
        Me.lbl_ExtAuthor.Text = "扩展作者："
        '
        'lbl_ExtVersion
        '
        Me.lbl_ExtVersion.AutoSize = True
        Me.lbl_ExtVersion.Location = New System.Drawing.Point(36, 76)
        Me.lbl_ExtVersion.Name = "lbl_ExtVersion"
        Me.lbl_ExtVersion.Size = New System.Drawing.Size(79, 20)
        Me.lbl_ExtVersion.TabIndex = 4
        Me.lbl_ExtVersion.Text = "扩展版本："
        '
        'cb_ExtList
        '
        Me.cb_ExtList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_ExtList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cb_ExtList.FormattingEnabled = True
        Me.cb_ExtList.Location = New System.Drawing.Point(121, 34)
        Me.cb_ExtList.Name = "cb_ExtList"
        Me.cb_ExtList.Size = New System.Drawing.Size(193, 28)
        Me.cb_ExtList.Sorted = True
        Me.cb_ExtList.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "选择扩展："
        '
        'Tab_customize
        '
        Me.Tab_customize.Controls.Add(Me.lbl_CStatus)
        Me.Tab_customize.Controls.Add(Me.btn_DelChosts)
        Me.Tab_customize.Controls.Add(Me.btn_Edit)
        Me.Tab_customize.Controls.Add(Me.Label11)
        Me.Tab_customize.Location = New System.Drawing.Point(4, 29)
        Me.Tab_customize.Name = "Tab_customize"
        Me.Tab_customize.Size = New System.Drawing.Size(463, 437)
        Me.Tab_customize.TabIndex = 3
        Me.Tab_customize.Text = "TabPage1"
        Me.Tab_customize.UseVisualStyleBackColor = True
        '
        'lbl_CStatus
        '
        Me.lbl_CStatus.AutoSize = True
        Me.lbl_CStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_CStatus.Location = New System.Drawing.Point(36, 262)
        Me.lbl_CStatus.Name = "lbl_CStatus"
        Me.lbl_CStatus.Size = New System.Drawing.Size(168, 20)
        Me.lbl_CStatus.TabIndex = 10
        Me.lbl_CStatus.Text = "Customize Hosts状态：-"
        '
        'btn_DelChosts
        '
        Me.btn_DelChosts.BackColor = System.Drawing.Color.Silver
        Me.btn_DelChosts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_DelChosts.FlatAppearance.BorderSize = 0
        Me.btn_DelChosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_DelChosts.Location = New System.Drawing.Point(110, 297)
        Me.btn_DelChosts.Name = "btn_DelChosts"
        Me.btn_DelChosts.Size = New System.Drawing.Size(116, 29)
        Me.btn_DelChosts.TabIndex = 9
        Me.btn_DelChosts.Text = "清除chosts.txt"
        Me.btn_DelChosts.UseVisualStyleBackColor = False
        '
        'btn_Edit
        '
        Me.btn_Edit.BackColor = System.Drawing.Color.Silver
        Me.btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Edit.FlatAppearance.BorderSize = 0
        Me.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Edit.Location = New System.Drawing.Point(233, 297)
        Me.btn_Edit.Name = "btn_Edit"
        Me.btn_Edit.Size = New System.Drawing.Size(116, 29)
        Me.btn_Edit.TabIndex = 8
        Me.btn_Edit.Text = "编辑chosts.txt"
        Me.btn_Edit.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(36, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(313, 217)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "使用Customize Hosts功能后，软件将会在更新hosts文件的同时加入自定义的hosts文件内容。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请点击下面的""编辑chosts.txt""以使用" &
    "Notepad编辑该内容，编辑完成在Notepad中点击保存即可。如果你不希望使用此功能，请点击""清除chosts.txt"""
        '
        'Tab_settings
        '
        Me.Tab_settings.Controls.Add(Me.btn_Save)
        Me.Tab_settings.Controls.Add(Me.cb_language)
        Me.Tab_settings.Controls.Add(Me.Label14)
        Me.Tab_settings.Controls.Add(Me.Label13)
        Me.Tab_settings.Controls.Add(Me.Label12)
        Me.Tab_settings.Controls.Add(Me.cb_AutoBackup)
        Me.Tab_settings.Controls.Add(Me.cb_Flushdns)
        Me.Tab_settings.Controls.Add(Me.cb_AutoUpdate)
        Me.Tab_settings.Controls.Add(Me.cb_Notify)
        Me.Tab_settings.Controls.Add(Me.cb_AutoStart)
        Me.Tab_settings.Location = New System.Drawing.Point(4, 29)
        Me.Tab_settings.Name = "Tab_settings"
        Me.Tab_settings.Size = New System.Drawing.Size(463, 437)
        Me.Tab_settings.TabIndex = 4
        Me.Tab_settings.Text = "TabPage1"
        Me.Tab_settings.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Silver
        Me.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Location = New System.Drawing.Point(257, 299)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(92, 29)
        Me.btn_Save.TabIndex = 10
        Me.btn_Save.Text = "保存设置"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'cb_language
        '
        Me.cb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_language.FormattingEnabled = True
        Me.cb_language.Items.AddRange(New Object() {"简体中文(中国大陆)", "正體中文(中國台灣)", "English(USA)", "日本語(日本)"})
        Me.cb_language.Location = New System.Drawing.Point(129, 259)
        Me.cb_language.Name = "cb_language"
        Me.cb_language.Size = New System.Drawing.Size(175, 28)
        Me.cb_language.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "language："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(36, 231)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(225, 19)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "语言设置（Not Available Now）"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(36, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 19)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "基本设置"
        '
        'cb_AutoBackup
        '
        Me.cb_AutoBackup.AutoSize = True
        Me.cb_AutoBackup.Location = New System.Drawing.Point(40, 200)
        Me.cb_AutoBackup.Name = "cb_AutoBackup"
        Me.cb_AutoBackup.Size = New System.Drawing.Size(147, 24)
        Me.cb_AutoBackup.TabIndex = 5
        Me.cb_AutoBackup.Text = "自动备份hosts文件"
        Me.cb_AutoBackup.UseVisualStyleBackColor = True
        '
        'cb_Flushdns
        '
        Me.cb_Flushdns.AutoSize = True
        Me.cb_Flushdns.Location = New System.Drawing.Point(40, 164)
        Me.cb_Flushdns.Name = "cb_Flushdns"
        Me.cb_Flushdns.Size = New System.Drawing.Size(142, 24)
        Me.cb_Flushdns.TabIndex = 4
        Me.cb_Flushdns.Text = "自动刷新DNS缓存"
        Me.cb_Flushdns.UseVisualStyleBackColor = True
        '
        'cb_AutoUpdate
        '
        Me.cb_AutoUpdate.AutoSize = True
        Me.cb_AutoUpdate.Location = New System.Drawing.Point(40, 128)
        Me.cb_AutoUpdate.Name = "cb_AutoUpdate"
        Me.cb_AutoUpdate.Size = New System.Drawing.Size(147, 24)
        Me.cb_AutoUpdate.TabIndex = 3
        Me.cb_AutoUpdate.Text = "自动更新hosts文件"
        Me.cb_AutoUpdate.UseVisualStyleBackColor = True
        '
        'cb_Notify
        '
        Me.cb_Notify.AutoSize = True
        Me.cb_Notify.Location = New System.Drawing.Point(40, 92)
        Me.cb_Notify.Name = "cb_Notify"
        Me.cb_Notify.Size = New System.Drawing.Size(154, 24)
        Me.cb_Notify.TabIndex = 1
        Me.cb_Notify.Text = "启动时检查软件更新"
        Me.cb_Notify.UseVisualStyleBackColor = True
        '
        'cb_AutoStart
        '
        Me.cb_AutoStart.AutoSize = True
        Me.cb_AutoStart.Location = New System.Drawing.Point(40, 58)
        Me.cb_AutoStart.Name = "cb_AutoStart"
        Me.cb_AutoStart.Size = New System.Drawing.Size(126, 24)
        Me.cb_AutoStart.TabIndex = 0
        Me.cb_AutoStart.Text = "开机启动本软件"
        Me.cb_AutoStart.UseVisualStyleBackColor = True
        '
        'Tab_about
        '
        Me.Tab_about.Controls.Add(Me.btn_faq)
        Me.Tab_about.Controls.Add(Me.btn_upgrade)
        Me.Tab_about.Controls.Add(Me.Label3)
        Me.Tab_about.Controls.Add(Me.lbl_AppVer2)
        Me.Tab_about.Controls.Add(Me.Label1)
        Me.Tab_about.Location = New System.Drawing.Point(4, 29)
        Me.Tab_about.Name = "Tab_about"
        Me.Tab_about.Size = New System.Drawing.Size(463, 437)
        Me.Tab_about.TabIndex = 5
        Me.Tab_about.Text = "TabPage1"
        Me.Tab_about.UseVisualStyleBackColor = True
        '
        'btn_faq
        '
        Me.btn_faq.BackColor = System.Drawing.Color.Silver
        Me.btn_faq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_faq.FlatAppearance.BorderSize = 0
        Me.btn_faq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_faq.Location = New System.Drawing.Point(251, 298)
        Me.btn_faq.Name = "btn_faq"
        Me.btn_faq.Size = New System.Drawing.Size(98, 29)
        Me.btn_faq.TabIndex = 2
        Me.btn_faq.Text = "作者博客"
        Me.btn_faq.UseVisualStyleBackColor = False
        '
        'btn_upgrade
        '
        Me.btn_upgrade.BackColor = System.Drawing.Color.Silver
        Me.btn_upgrade.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_upgrade.FlatAppearance.BorderSize = 0
        Me.btn_upgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upgrade.Location = New System.Drawing.Point(147, 298)
        Me.btn_upgrade.Name = "btn_upgrade"
        Me.btn_upgrade.Size = New System.Drawing.Size(98, 29)
        Me.btn_upgrade.TabIndex = 4
        Me.btn_upgrade.Text = "检查更新"
        Me.btn_upgrade.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(36, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "生成时间：2016/07/10"
        '
        'lbl_AppVer2
        '
        Me.lbl_AppVer2.AutoSize = True
        Me.lbl_AppVer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_AppVer2.Location = New System.Drawing.Point(36, 235)
        Me.lbl_AppVer2.Name = "lbl_AppVer2"
        Me.lbl_AppVer2.Size = New System.Drawing.Size(85, 20)
        Me.lbl_AppVer2.TabIndex = 5
        Me.lbl_AppVer2.Text = "软件版本：-"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(36, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 164)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "点点hosts文件管理器提供一种简单的方式下载线上的hosts文件以及更新本地的hosts文件。软件提供了""扩展""功能，你可以在其它地方下载并使用适用于本软件的h" &
    "osts扩展配置。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pic_Network
        '
        Me.pic_Network.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pic_Network.Location = New System.Drawing.Point(4, 276)
        Me.pic_Network.Name = "pic_Network"
        Me.pic_Network.Size = New System.Drawing.Size(35, 35)
        Me.pic_Network.TabIndex = 8
        Me.pic_Network.TabStop = False
        '
        'lbl_Network
        '
        Me.lbl_Network.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lbl_Network.Location = New System.Drawing.Point(37, 277)
        Me.lbl_Network.Name = "lbl_Network"
        Me.lbl_Network.Size = New System.Drawing.Size(94, 33)
        Me.lbl_Network.TabIndex = 9
        Me.lbl_Network.Text = " "
        Me.lbl_Network.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_line
        '
        Me.lbl_line.BackColor = System.Drawing.Color.Silver
        Me.lbl_line.Location = New System.Drawing.Point(0, 272)
        Me.lbl_line.Name = "lbl_line"
        Me.lbl_line.Size = New System.Drawing.Size(137, 1)
        Me.lbl_line.TabIndex = 10
        '
        'APP_NotifyIcon
        '
        Me.APP_NotifyIcon.ContextMenuStrip = Me.APP_ContextMenuStrip
        Me.APP_NotifyIcon.Text = "NotifyIcon1"
        Me.APP_NotifyIcon.Visible = True
        '
        'APP_ContextMenuStrip
        '
        Me.APP_ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.T_ShowWindow, Me.ToolStripMenuItem1, Me.T_End})
        Me.APP_ContextMenuStrip.Name = "APP_ContextMenuStrip"
        Me.APP_ContextMenuStrip.ShowImageMargin = False
        Me.APP_ContextMenuStrip.ShowItemToolTips = False
        Me.APP_ContextMenuStrip.Size = New System.Drawing.Size(128, 76)
        '
        'T_ShowWindow
        '
        Me.T_ShowWindow.Name = "T_ShowWindow"
        Me.T_ShowWindow.Size = New System.Drawing.Size(127, 22)
        Me.T_ShowWindow.Text = "打开主界面"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(124, 6)
        '
        'T_End
        '
        Me.T_End.Name = "T_End"
        Me.T_End.Size = New System.Drawing.Size(127, 22)
        Me.T_End.Text = "退出本软件"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 314)
        Me.Controls.Add(Me.pic_Network)
        Me.Controls.Add(Me.lbl_line)
        Me.Controls.Add(Me.lbl_Network)
        Me.Controls.Add(Me.btn_galance)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.btn_ext)
        Me.Controls.Add(Me.btn_customize)
        Me.Controls.Add(Me.btn_settings)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.lbl_bg)
        Me.Controls.Add(Me.Tab_dd)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainWindow"
        Me.Tab_dd.ResumeLayout(False)
        Me.Tab_galance.ResumeLayout(False)
        Me.Tab_galance.PerformLayout()
        Me.Tab_backup.ResumeLayout(False)
        Me.Tab_ext.ResumeLayout(False)
        Me.Tab_ext.PerformLayout()
        Me.Tab_customize.ResumeLayout(False)
        Me.Tab_customize.PerformLayout()
        Me.Tab_settings.ResumeLayout(False)
        Me.Tab_settings.PerformLayout()
        Me.Tab_about.ResumeLayout(False)
        Me.Tab_about.PerformLayout()
        CType(Me.pic_Network, System.ComponentModel.ISupportInitialize).EndInit()
        Me.APP_ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_galance As Button
    Friend WithEvents btn_backup As Button
    Friend WithEvents btn_ext As Button
    Friend WithEvents btn_customize As Button
    Friend WithEvents btn_settings As Button
    Friend WithEvents btn_about As Button
    Friend WithEvents lbl_bg As Label
    Friend WithEvents Tab_dd As TabControl
    Friend WithEvents Tab_galance As TabPage
    Friend WithEvents Tab_backup As TabPage
    Friend WithEvents Tab_ext As TabPage
    Friend WithEvents Tab_customize As TabPage
    Friend WithEvents Tab_settings As TabPage
    Friend WithEvents Tab_about As TabPage
    Friend WithEvents pic_Network As PictureBox
    Friend WithEvents lbl_Network As Label
    Friend WithEvents lbl_line As Label
    Friend WithEvents lbl_LastCheckDate As Label
    Friend WithEvents lbl_LastUpdateDate As Label
    Friend WithEvents lbl_LocalVer As Label
    Friend WithEvents lbl_Ext As Label
    Friend WithEvents lbl_AppVer As Label
    Friend WithEvents lbl_ExtVer As Label
    Friend WithEvents lbl_RemoteVer As Label
    Friend WithEvents list_backup As ListBox
    Friend WithEvents btn_Restore As Button
    Friend WithEvents btn_DelBak As Button
    Friend WithEvents btn_Bak As Button
    Friend WithEvents btn_faq As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_upgrade As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_AppVer2 As Label
    Friend WithEvents btn_UpdateHosts As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents cb_ExtList As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_ExtDescription As Label
    Friend WithEvents lbl_ExtLink As Label
    Friend WithEvents lbl_ExtAuthor As Label
    Friend WithEvents lbl_ExtVersion As Label
    Friend WithEvents link_Ext As LinkLabel
    Friend WithEvents btn_ApplyExt As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_DelChosts As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents cb_AutoBackup As CheckBox
    Friend WithEvents cb_Flushdns As CheckBox
    Friend WithEvents cb_AutoUpdate As CheckBox
    Friend WithEvents cb_Notify As CheckBox
    Friend WithEvents cb_AutoStart As CheckBox
    Friend WithEvents APP_NotifyIcon As NotifyIcon
    Friend WithEvents APP_ContextMenuStrip As ContextMenuStrip
    Friend WithEvents T_ShowWindow As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents T_End As ToolStripMenuItem
    Friend WithEvents lbl_CStatus As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cb_language As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl_Description As Label
    Friend WithEvents btn_DownloadExt As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents lbl_ExtVersion_Text As Label
    Friend WithEvents lbl_ExtAuthor_Text As Label
End Class
