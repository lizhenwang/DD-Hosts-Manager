' Powered by lizhenwang.com

Imports System.ComponentModel
Imports DDhosts.dd_functions
Public Class MainWindow
    Public KeyPath As String = "C:\DD-Licence"
    Dim lbl As New Label
    Dim Tab_top As Integer
    Dim IsMoveDown As Boolean
    Dim IsMoveBtn As Boolean
    Dim top_backup, top_ext, top_customize, top_settings, top_about As Integer
    Dim BackupPath As String
    Dim UpgradeUrl As String
    Dim SettingsPath As String
    Dim IsSlientUpdate As Boolean
    Dim APP_HostsPath As String
    Dim DD_Fun As New DDhosts.dd_functions
    Dim Message_Update As String
    Dim Link_Update As String
    Dim ApplyExtPath As String
    Dim IsManualUpdate As Boolean
    Dim CVersion As String
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.GetCommandLineArgs.Count > 1 Then
            If Environment.GetCommandLineArgs(1) = "-hide" Then
                With Me
                    .ShowInTaskbar = False
                    .Opacity = 0
                    .Visible = False
                End With
            End If
        End If

        '===============================================================================================================
        IsManualUpdate = False
        IsSlientUpdate = True
        ChDir(System.IO.Path.GetDirectoryName(Application.ExecutablePath))
        If My.Computer.FileSystem.DirectoryExists(Environment.CurrentDirectory & "\extensions") = False Then
            My.Computer.FileSystem.CreateDirectory(Environment.CurrentDirectory & "\extensions")
        End If
        SettingsPath = Environment.CurrentDirectory & "\settings.ini"
        APP_HostsPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\System32\drivers\etc\hosts"
        BackupPath = Environment.CurrentDirectory & "\backup"
        Me.Text = Application.ProductName
        lbl_AppVer.Text = "应用程序版本：" & Application.ProductVersion
        lbl_AppVer2.Text = "软件版本：" & Application.ProductVersion
        Me.Icon = New Icon(Environment.CurrentDirectory & "\images\icon\icon2.ico")
        'Tab_top = Tab_dd.Top
        'Tab_dd.Top = Tab_top + 20
        'top_backup = btn_backup.Top
        'top_ext = btn_ext.Top
        'top_customize = btn_customize.Top
        'top_settings = btn_settings.Top
        'top_about = btn_about.Top
        'btn_backup.Top = 0 : btn_ext.Top = 0 : btn_customize.Top = 0 : btn_ext.Top = 0 : btn_customize.Top = 0 : btn_settings.Top = 0 : btn_about.Top = 0
        pic_Network.Image = Image.FromFile(Environment.CurrentDirectory & "\images\disconnect.png")
        IsMoveBtn = True
        With lbl
            .Width = 4
            .Height = btn_galance.Height
            .Top = btn_galance.Top
            .Left = 0
            .BackColor = Color.FromArgb(0, 122, 204)
            .Parent = btn_galance
        End With
        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\properties.ini") Then
            DD_Fun.LoadProp(Environment.CurrentDirectory & "\properties.ini")
            If DD_Fun.GetSettings("App_IsBeta") = True Then Me.Text = Me.Text & " (Beta)"
            If Not DD_Fun.GetSettings("app_ExtensionUrl") = "str_null" Then btn_DownloadExt.Tag = DD_Fun.GetSettings("app_ExtensionUrl")
            UpgradeUrl = DD_Fun.GetSettings("app_UpgradeUrl")

        Else
            MessageBox.Show("请为" & Application.ProductName & "创建正确的properties.ini文件，并放置于软件所在目录！", "错误")
            End
        End If
        Call ChangeImage()
        'Dim thr_move As New Threading.Thread(AddressOf Tab_move)
        'thr_move.Start()
        With APP_NotifyIcon
            .Icon = New Icon(Environment.CurrentDirectory & "\images\icon\icon.ico")
            .Visible = True
            .Text = Me.Text
        End With
        Dim NC As New Threading.Thread(AddressOf NetworkCheckerDelay)
        NC.Start()
        DD_Fun.LoadSettings(IIf(My.Computer.FileSystem.FileExists(SettingsPath), SettingsPath, ""))
        GetSettings()
        GetHostsVer()

        If DD_Fun.GetSettings("app_IsNotice") = True Then
            If UpgradeUrl <> "str_null" Or UpgradeUrl <> "" Then
                btn_upgrade.Enabled = False
                btn_upgrade.Text = "请稍等..."
                Dim t As New System.Threading.Thread(AddressOf GetUpdate)
                t.Start()
            End If
        End If


        If DD_Fun.GetSettings("app_Extension") = "str_null" Or DD_Fun.GetSettings("app_Extension") = "" Then
            LOGO.TopMost = False
            MessageBox.Show(Me, "未启用任何扩展，请在扩展配置页面选择并启用一个扩展，否则应用程序无法更新hosts文件！", "设置扩展")
            Tab_dd.SelectedTab = Tab_ext
            lbl.Parent = btn_ext
            Call ChangeImage()
        Else
            If My.Computer.FileSystem.FileExists(DD_Fun.GetSettings("APP_Extension") & "\ext.ini") Then DD_Fun.LoadExtension(DD_Fun.GetSettings("APP_Extension") & "\ext.ini")



        End If
        RefExtList()
        Dim GetVer As New System.Threading.Thread(AddressOf AutoGetVersion)
        GetVer.Start()
        GetTime()
    End Sub

    Private Sub GetHostsVer()
        Dim r As String
        r = DD_Fun.GetLocalVer
        If r = "ERR" Then
            lbl_LocalVer.Text = "本地hosts版本：未更新"
        Else
            lbl_LocalVer.Text = "本地hosts版本：" & r
        End If
    End Sub
    Private Sub NetworkCheckerDelay()
        Do
            Do
                If Me.IsHandleCreated = True Then
                    Me.BeginInvoke(New Action(AddressOf NetworkChecker))
                    Exit Do
                End If
            Loop
            System.Threading.Thread.Sleep(1500)
        Loop

    End Sub
    Private Sub NetworkChecker()
        If My.Computer.Network.IsAvailable Then
            pic_Network.Image = Image.FromFile(Environment.CurrentDirectory & "\images\connect.png")
            lbl_Network.ForeColor = Color.FromArgb(0, 122, 204)
            lbl_Network.Text = "网络已连接"
        Else
            pic_Network.Image = Image.FromFile(Environment.CurrentDirectory & "\images\disconnect.png")
            lbl_Network.Text = "网络未连接"
            lbl_Network.ForeColor = Color.Red
        End If
    End Sub
    Private Sub ChangeImage()
        btn_galance.Image = Image.FromFile(Environment.CurrentDirectory & "\images\galance.png")
        btn_backup.Image = Image.FromFile(Environment.CurrentDirectory & "\images\backup.png")
        btn_ext.Image = Image.FromFile(Environment.CurrentDirectory & "\images\extension.png")
        btn_customize.Image = Image.FromFile(Environment.CurrentDirectory & "\images\customize.png")
        btn_settings.Image = Image.FromFile(Environment.CurrentDirectory & "\images\settings.png")
        btn_about.Image = Image.FromFile(Environment.CurrentDirectory & "\images\about.png")
        btn_galance.ForeColor = Color.FromArgb(0, 0, 0)
        btn_backup.ForeColor = Color.FromArgb(0, 0, 0)
        btn_ext.ForeColor = Color.FromArgb(0, 0, 0)
        btn_customize.ForeColor = Color.FromArgb(0, 0, 0)
        btn_settings.ForeColor = Color.FromArgb(0, 0, 0)
        btn_about.ForeColor = Color.FromArgb(0, 0, 0)
        Select Case Tab_dd.SelectedIndex
            Case 0
                btn_galance.Image = Image.FromFile(Environment.CurrentDirectory & "\images\galance_hover.png")
                btn_galance.ForeColor = Color.FromArgb(0, 122, 204)
            Case 1
                btn_backup.Image = Image.FromFile(Environment.CurrentDirectory & "\images\backup_hover.png")
                btn_backup.ForeColor = Color.FromArgb(0, 122, 204)
            Case 2
                btn_ext.Image = Image.FromFile(Environment.CurrentDirectory & "\images\extension_hover.png")
                btn_ext.ForeColor = Color.FromArgb(0, 122, 204)
            Case 3
                btn_customize.Image = Image.FromFile(Environment.CurrentDirectory & "\images\customize_hover.png")
                btn_customize.ForeColor = Color.FromArgb(0, 122, 204)
            Case 4
                btn_settings.Image = Image.FromFile(Environment.CurrentDirectory & "\images\settings_hover.png")
                btn_settings.ForeColor = Color.FromArgb(0, 122, 204)
            Case 5
                btn_about.Image = Image.FromFile(Environment.CurrentDirectory & "\images\about_hover.png")
                btn_about.ForeColor = Color.FromArgb(0, 122, 204)
        End Select

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Backup(True)
        Dim w As New System.IO.FileStream(APP_HostsPath, IO.FileMode.Create)
        w.Close()
        FileIO.FileSystem.WriteAllText(APP_HostsPath, "", False, System.Text.Encoding.ASCII)
        GetHostsVer()
        MessageBox.Show(Me, "已清除hosts文件！", Me.Text)
    End Sub



    Private Sub APP_NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles APP_NotifyIcon.MouseDoubleClick
        Call ShowWindow(MouseButtons.Left)
    End Sub

    Private Sub ShowWindow(btn As MouseButtons)
        If btn = MouseButtons.Left Then
            With Me
                .Opacity = 1
                .Visible = True
                .ShowInTaskbar = True
                .WindowState = FormWindowState.Normal
            End With
            Try
                AppActivate(Me.Text)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btn_faq_Click(sender As Object, e As EventArgs) Handles btn_faq.Click
        Dim o As New System.Diagnostics.Process
        With o
            Try
                .StartInfo.FileName = "http://www.lizhenwang.com"
                .Start()
            Catch ex As Exception
                .StartInfo.FileName = "iexplore.exe"
                .StartInfo.Arguments = "http://www.lizhenwang.com"
                .Start()
            End Try

        End With
    End Sub

    Private Sub APP_ContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles APP_ContextMenuStrip.Opening

    End Sub

    Private Sub T_End_Click(sender As Object, e As EventArgs) Handles T_End.Click
        APP_NotifyIcon.Visible = False
        End
    End Sub

    Private Sub T_ShowWindow_Click(sender As Object, e As EventArgs) Handles T_ShowWindow.Click
        Call ShowWindow(MouseButtons.Left)
    End Sub



    'Public Sub Tab_move()
    '    Do
    '        If Me.IsHandleCreated = True Then Me.BeginInvoke(New Action(AddressOf Tab_moving))
    '        System.Threading.Thread.Sleep(8)

    '    Loop
    'End Sub

    Private Sub Tab_moving()
        If IsMoveDown = True Then
            If Not Tab_dd.Top >= Tab_top + 20 Then
                Tab_dd.Top = Tab_dd.Top + 1
                If Tab_dd.Top >= Tab_top + 20 Then IsMoveDown = False
                Exit Sub
            End If
        End If
        If Tab_dd.Top >= Tab_top Then
            Tab_dd.Top = Tab_dd.Top - 1
        End If

        If IsMoveBtn = True Then
            If Not btn_about.Top = top_about Then
                btn_about.Top = btn_about.Top + 2
            Else
                IsMoveBtn = False
            End If
            If Not btn_backup.Top = top_backup Then btn_backup.Top = btn_backup.Top + 2
            If Not btn_customize.Top = top_customize Then btn_customize.Top = btn_customize.Top + 2
            If Not btn_ext.Top = top_ext Then btn_ext.Top = btn_ext.Top + 2
            If Not btn_settings.Top = top_settings Then btn_settings.Top = btn_settings.Top + 2
        End If

    End Sub

    Private Sub btn_DelChosts_Click(sender As Object, e As EventArgs) Handles btn_DelChosts.Click
        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\chosts.txt") Then
            My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory & "\chosts.txt")
            RefStatus()
        End If
        ApplyCustomizeHosts()
        MessageBox.Show(Me, "已禁用Customize Hosts功能！", Me.Text)
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn_settings.Click, btn_galance.Click, btn_ext.Click, btn_customize.Click, btn_backup.Click, btn_about.Click
        lbl.Parent = sender

        Select Case sender.Name
            Case btn_galance.Name
                Tab_dd.SelectedTab = Tab_galance
            Case btn_ext.Name
                Tab_dd.SelectedTab = Tab_ext
                RefExtList()
            Case btn_backup.Name
                Tab_dd.SelectedTab = Tab_backup
                RefList()
            Case btn_about.Name
                Tab_dd.SelectedTab = Tab_about
            Case btn_settings.Name
                cb_AutoStart.Checked = DD_Fun.GetSettings("APP_ISAUTOSTART", Application.ExecutablePath)
                GetSettings()
                Tab_dd.SelectedTab = Tab_settings
            Case btn_customize.Name
                Tab_dd.SelectedTab = Tab_customize
                RefStatus()
        End Select
        'Tab_dd.Top = Tab_top + 15
        IsMoveDown = True
        Call ChangeImage()
    End Sub

    Private Sub btn_Bak_Click(sender As Object, e As EventArgs) Handles btn_Bak.Click
        Backup(False)
    End Sub

    Private Sub btn_GotFocus(sender As Object, e As EventArgs) Handles btn_settings.GotFocus, btn_about.GotFocus, btn_backup.GotFocus, btn_customize.GotFocus, btn_ext.GotFocus, btn_galance.GotFocus
        lbl_bg.Focus()
    End Sub

    Private Sub btn_DelBak_Click(sender As Object, e As EventArgs) Handles btn_DelBak.Click
        If list_backup.GetItemText(list_backup.SelectedItem) = "" Then
            MessageBox.Show(Me, "请先选择需要删除的备份！", "注意")
        Else
            Try
                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory & "\backup\" & list_backup.GetItemText(list_backup.SelectedItem))
            Catch ex As Exception

            End Try
            RefList()
        End If
    End Sub

    Private Sub btn_Restore_Click(sender As Object, e As EventArgs) Handles btn_Restore.Click
        If list_backup.GetItemText(list_backup.SelectedItem) <> "" Then
            MessageBox.Show(Me, IIf(DD_Fun.Restore(Environment.CurrentDirectory & "\backup\" & list_backup.GetItemText(list_backup.SelectedItem)), "还原hosts文件成功！", "还原hosts文件失败！"), Me.Text)
            RefList()
            ApplyCustomizeHosts()
            GetHostsVer()
            RefDns()
        Else
            MessageBox.Show(Me, "请先选择需要还原的备份！", "注意")
        End If
    End Sub

    Private Sub btn_DownloadExt_Click(sender As Object, e As EventArgs) Handles btn_DownloadExt.Click
        If Not sender.Tag = "" Then
            DD_Fun.dl_ext()
        Else
            MessageBox.Show(Me, "未在properties.ini中添加下载插件的URL配置，无法继续执行！", "错误")
        End If
    End Sub

    Private Sub btn_upgrade_Click(sender As Object, e As EventArgs) Handles btn_upgrade.Click
        IsSlientUpdate = False
        If UpgradeUrl = "str_null" Or UpgradeUrl = "" Then
            MessageBox.Show(Me, "请在properties.ini中指定一个获取软件更新的URL。", "无法获取更新")
        Else
            btn_upgrade.Enabled = False
            btn_upgrade.Text = "请稍等..."
            Dim t As New System.Threading.Thread(AddressOf GetUpdate)
            t.Start()
        End If
    End Sub

    Private Sub GetUpdate()
        Dim r As String
        r = DD_Fun.GetUpdate(True)
        If r = "ERR" Or r = "" Then
            If Not IsSlientUpdate = True Then
                Message_Update = "检查软件更新失败！"
                Do
                    If Me.IsHandleCreated = True Then
                        Me.BeginInvoke(New Action(AddressOf ShowMessage_Update))
                        Exit Do
                    End If
                Loop
            End If
        Else
            If r.Split("|").Count > 0 Then
                If r.Split("|")(0) <> Application.ProductVersion Then
                    Link_Update = r.Split("|")(1)
                    Do
                        If Me.IsHandleCreated = True Then
                            Me.BeginInvoke(New Action(AddressOf ShowMessage_Isupdate))
                            Exit Do
                        End If
                    Loop
                Else
                    If Not IsSlientUpdate = True Then
                        Message_Update = "已经使用最新版本的点点hosts文件管理器"
                        Do
                            If Me.IsHandleCreated = True Then
                                Me.BeginInvoke(New Action(AddressOf ShowMessage_Update))
                                Exit Do
                            End If
                        Loop
                    End If
                End If
            Else
                If Not IsSlientUpdate = True Then
                    Message_Update = "检查软件更新失败，返回不正确的数据！"
                    Do
                        If Me.IsHandleCreated = True Then
                            Me.BeginInvoke(New Action(AddressOf ShowMessage_Update))
                            Exit Do
                        End If
                    Loop
                End If

            End If
        End If
        Do
            If Me.IsHandleCreated = True Then
                Me.BeginInvoke(New Action(AddressOf ChangeUpdateTxt))
                Exit Do
            End If
        Loop
    End Sub

    Private Sub ShowMessage_Update()
        MessageBox.Show(Me, Message_Update, Me.Text)
    End Sub

    Private Sub ShowMessage_Isupdate()
        If MessageBox.Show(Me, "检查到新版本的点点hosts文件管理器，是否马上下载？", "更新", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim o As New System.Diagnostics.Process
            o.StartInfo.FileName = Link_Update
            Try
                o.Start()
            Catch ex As Exception
                o.StartInfo.FileName = "iexplore.exe"
                o.StartInfo.Arguments = Link_Update
                o.Start()
            End Try
        End If
    End Sub
    Private Sub ChangeUpdateTxt()
        btn_upgrade.Enabled = True
        btn_upgrade.Text = "检查更新"
    End Sub

    Private Sub APP_NotifyIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles APP_NotifyIcon.MouseClick
        If e.Button = MouseButtons.Right Then
            APP_NotifyIcon.ContextMenuStrip.Show()
        End If
    End Sub


    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        DD_Fun.SetAutoStart(Application.ExecutablePath, cb_AutoStart.CheckState)
        cb_AutoStart.Checked = DD_Fun.GetSettings("APP_ISAUTOSTART", Application.ExecutablePath)
        Dim w As New System.IO.FileStream(SettingsPath, IO.FileMode.Create, IO.FileAccess.Write)
        w.Close()
        FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsBackup=" & Int(cb_AutoBackup.Checked) & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsAutoUpdate=" & Int(cb_AutoUpdate.Checked) & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsNotice=" & Int(cb_Notify.Checked) & vbCrLf, True)
        FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsFlushdns=" & Int(cb_Flushdns.Checked) & vbCrLf, True)
        If Not DD_Fun.GetSettings("APP_EXTENSION") = "str_null" Then FileIO.FileSystem.WriteAllText(SettingsPath, "app_Extension=" & DD_Fun.GetSettings("APP_EXTENSION"), True)
        DD_Fun.LoadSettings(SettingsPath)
        MessageBox.Show(Me, "已保存更改的设置！", "保存")
    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = 1
        With Me
            '.Opacity = 0
            .Visible = False
            .ShowInTaskbar = False
            '.WindowState = FormWindowState.Minimized
        End With
    End Sub

    Public Function Backup(IsAuto As Boolean)
        If Not My.Computer.FileSystem.DirectoryExists(BackupPath) Then My.Computer.FileSystem.CreateDirectory(BackupPath)
        If IsAuto = True Then
            If DD_Fun.GetSettings("app_IsBackup") = True Then
                DD_Fun.Backup(BackupPath & "\AutomaticBak " & Format(Now, "yyyy-MM-dd_HHmmss"))
            End If
        Else
            DD_Fun.Backup(BackupPath & "\ManualBak " & Format(Now, "yyyy-MM-dd_HHmmss"))
        End If
        RefList()
    End Function

    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If Not My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\chosts.txt") Then
            Dim w As New System.IO.FileStream(Environment.CurrentDirectory & "\chosts.txt", IO.FileMode.Create)
            w.Close()
        End If
        btn_Edit.Enabled = False
        btn_DelChosts.Enabled = False
        Dim t As New System.Threading.Thread(AddressOf Edit)
        t.Start()

    End Sub

    Private Sub Edit()
        Dim o As New System.Diagnostics.Process
        With o
            .StartInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\notepad.exe"
            .StartInfo.Arguments = (Environment.CurrentDirectory & "\chosts.txt")
            .Start()
            .WaitForExit()
        End With
        Do
            If Me.IsHandleCreated = True Then
                Me.BeginInvoke(New Action(AddressOf EnableEditBtn))
                Exit Do
            End If
        Loop
    End Sub

    Private Sub EnableEditBtn()
        btn_Edit.Enabled = True
        btn_DelChosts.Enabled = True
        RefStatus()
        ApplyCustomizeHosts()
    End Sub



    Public Function RefList()
        list_backup.Items.Clear()
        Dim lst
        lst = My.Computer.FileSystem.GetFiles(Environment.CurrentDirectory & "\backup")
        For Each I In lst
            list_backup.Items.Add(FileIO.FileSystem.GetName(I.ToString))
        Next
    End Function

    Public Function GetSettings()
        cb_AutoBackup.Checked = Int(DD_Fun.GetSettings("app_IsBackup"))
        cb_AutoUpdate.Checked = Int(DD_Fun.GetSettings("app_IsAutoUpdate"))
        cb_Flushdns.Checked = Int(DD_Fun.GetSettings("app_IsFlushdns"))
        cb_Notify.Checked = Int(DD_Fun.GetSettings("app_IsNotice"))
    End Function



    Public Sub RefStatus()
        If Not My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\chosts.txt") Then
            lbl_CStatus.Text = "Customize Hosts状态：未启用"
        ElseIf FileLen(Environment.CurrentDirectory & "\chosts.txt") = 0 Then
            lbl_CStatus.Text = "Customize Hosts状态：未启用"
        Else
            lbl_CStatus.Text = "Customize Hosts状态：已启用"
        End If
    End Sub

    Private Sub btn_ApplyExt_Click(sender As Object, e As EventArgs) Handles btn_ApplyExt.Click
        If Not ApplyExtPath = "" Then
            Dim w As New System.IO.FileStream(SettingsPath, IO.FileMode.Create, IO.FileAccess.Write)
            w.Close()
            FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsBackup=" & IIf(DD_Fun.GetSettings("APP_ISBACKUP"), 1, 0) & vbCrLf, True)
            FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsAutoUpdate=" & IIf(DD_Fun.GetSettings("APP_ISAUTOUPDATE"), 1, 0) & vbCrLf, True)
            FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsNotice=" & IIf(DD_Fun.GetSettings("APP_ISNOTICE"), 1, 0) & vbCrLf, True)
            FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsNotice_Ext=" & IIf(DD_Fun.GetSettings("APP_ISNOTICE_EXT"), 1, 0) & vbCrLf, True)
            FileIO.FileSystem.WriteAllText(SettingsPath, "app_IsFlushdns=" & IIf(DD_Fun.GetSettings("APP_ISFLUSHDNS"), 1, 0) & vbCrLf, True)
            FileIO.FileSystem.WriteAllText(SettingsPath, "app_Extension=" & ApplyExtPath, True)
            MessageBox.Show(Me, "已保存更改的设置，重启点点hosts文件管理器后生效。请点击确定按钮以关闭应用程序，然后手动运行点点hosts文件管理器！", "保存")
            On Error Resume Next

            APP_NotifyIcon.Visible = False
            End


        Else
            MessageBox.Show(Me, "请先选择一个有效的扩展！", "错误")
        End If
    End Sub

    Public Function ApplyCustomizeHosts()
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\chosts.txt") = True Then
            If FileLen(Environment.CurrentDirectory & "\chosts.txt") > 0 Then
                DD_Fun.Customize(FileIO.FileSystem.ReadAllText(Environment.CurrentDirectory & "\chosts.txt"))
            Else
                DD_Fun.Customize("")
            End If
        Else
            DD_Fun.Customize("")
        End If
    End Function





    Private Sub RefExtList()
        Dim Folders As ObjectModel.ReadOnlyCollection(Of String)
        Dim FullPath As String
        cb_ExtList.Items.Clear()
        Folders = My.Computer.FileSystem.GetDirectories(Environment.CurrentDirectory & "\extensions")
        If Folders.Count > 0 Then
            For Each E In Folders
                FullPath = E & "\ext.ini"
                If My.Computer.FileSystem.FileExists(FullPath) = True Then
                    If DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_NAME") <> "str_null" Then
                        cb_ExtList.Items.Add(DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_NAME"))
                    End If
                End If
            Next
        End If
        If DD_Fun.GetSettings("app_Extension") <> "str_null" Or DD_Fun.GetSettings("app_Extension") <> "" Then
            For n = 0 To cb_ExtList.Items.Count - 1
                If cb_ExtList.Items.Item(n).ToString = DD_Fun.GetExtensionProp("EXT_Name") Then
                    cb_ExtList.SelectedIndex = n
                    Exit For
                End If
            Next
            lbl_Ext.Text = "启用的扩展：" & DD_Fun.GetExtensionProp("EXT_Name")
            lbl_ExtVer.Text = "扩展版本号：" & DD_Fun.GetExtensionProp("EXT_VERSION")
            cb_ExtList.SelectedValue = DD_Fun.GetExtensionProp("EXT_Name")
            lbl_ExtAuthor_Text.Text = DD_Fun.GetExtensionProp("EXT_AUTHOR")
            lbl_Description.Text = DD_Fun.GetExtensionProp("EXT_DESCRIPTION")
            lbl_ExtVersion_Text.Text = DD_Fun.GetExtensionProp("EXT_VERSION")
            link_Ext.Text = DD_Fun.GetExtensionProp("EXT_LINK")

        End If
    End Sub

    Private Sub link_Ext_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_Ext.LinkClicked
        If e.Button = MouseButtons.Left Then
            If link_Ext.Text <> "" AndAlso link_Ext.Text <> "-" Then
                Dim o As New System.Diagnostics.Process
                With o
                    Try
                        .StartInfo.FileName = link_Ext.Text
                        .Start()
                    Catch ex As Exception
                        .StartInfo.FileName = "explore.exe"
                        .StartInfo.Arguments = link_Ext.Text
                        .Start()
                    End Try

                End With
            End If
        End If

    End Sub

    Private Sub btn_UpdateHosts_Click(sender As Object, e As EventArgs) Handles btn_UpdateHosts.Click
        If IsManualUpdate = True Then
            IsManualUpdate = False
            btn_UpdateHosts.Text = "更新hosts文件"
        Else
            IsManualUpdate = True
            btn_UpdateHosts.Text = "正在等待更新"
        End If
    End Sub

    Private Sub cb_ExtList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_ExtList.SelectedIndexChanged
        Dim Folders As ObjectModel.ReadOnlyCollection(Of String)
        Dim FullPath As String
        Folders = My.Computer.FileSystem.GetDirectories(Environment.CurrentDirectory & "\extensions")
        If Folders.Count > 0 Then
            For Each l In Folders
                FullPath = l & "\ext.ini"
                If My.Computer.FileSystem.FileExists(FullPath) = True Then
                    If DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_NAME") = cb_ExtList.GetItemText(cb_ExtList.SelectedItem) Then
                        ApplyExtPath = l
                        Exit For
                    End If
                End If
            Next

            lbl_ExtAuthor_Text.Text = IIf(DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_AUTHOR") = "str_null", "未指定", DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_AUTHOR"))
            lbl_Description.Text = IIf(DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_DESCRIPTION") = "str_null", "未指定", DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_DESCRIPTION"))
            lbl_ExtVersion_Text.Text = IIf(DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_VERSION") = "str_null", "未指定", DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_VERSION"))
            link_Ext.Text = IIf(DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_LINK") = "str_null", "未指定", DD_Fun.GetExtensionProp_TEMP(FullPath, "EXT_LINK"))
        End If

    End Sub

    Private Sub ChangeVersion()
        lbl_RemoteVer.Text = "线上hosts版本：" & CVersion
    End Sub
    Private Sub AutoGetVersion()

        System.Threading.Thread.Sleep(1000)


        Do
                'If Me.IsHandleCreated = True Then
                'Me.BeginInvoke(New Action(AddressOf CheckRemoteVersion))
                'Exit Do
                'End If

                Dim v As String
                v = DD_Fun.GetRemoteVer()
            If v.Length <> 0 AndAlso v <> "ERR" Then
                Dim c As New System.IO.FileStream(DD_Fun.GetSettings("app_Extension") & "\CheckTime", IO.FileMode.Create)
                c.Close()
                FileIO.FileSystem.WriteAllText(DD_Fun.GetSettings("app_Extension") & "\CheckTime", Format(Now, "yyyy-MM-dd HH:mm:ss"), False)
                CVersion = v.Split("|")(0)
                Do
                    If Me.IsHandleCreated = True Then
                        Me.BeginInvoke(New Action(AddressOf ChangeVersion))
                        Exit Do
                    End If
                Loop
                If DD_Fun.GetSettings("app_IsAutoUpdate") = True Or IsManualUpdate = True Then
                    If v.Split("|")(0) <> DD_Fun.GetLocalVer Then
                        Backup(True)
                        If DD_Fun.DownloadHosts(v.Split("|")(1)) = "OK" Then
                            Dim u As New System.IO.FileStream(DD_Fun.GetSettings("app_Extension") & "\UpdateTime", IO.FileMode.Create)
                            u.Close()
                            FileIO.FileSystem.WriteAllText(DD_Fun.GetSettings("app_Extension") & "\UpdateTime", Format(Now, "yyyy-MM-dd HH:mm:ss"), False)
                            System.Threading.Thread.Sleep(200)
                            ApplyCustomizeHosts()

                        End If
                    End If
                    IsManualUpdate = False
                    Do
                        If Me.IsHandleCreated = True Then
                            Me.BeginInvoke(New Action(AddressOf ChangeText))
                            Exit Do
                        End If
                    Loop
                End If
                Do
                    If Me.IsHandleCreated = True Then
                        Me.BeginInvoke(New Action(AddressOf GetTime))
                        Exit Do
                    End If
                Loop
                Do
                    If Me.IsHandleCreated = True Then
                        Me.BeginInvoke(New Action(AddressOf GetHostsVer))
                        Exit Do
                    End If
                Loop
                Do
                    If Me.IsHandleCreated = True Then
                        Me.BeginInvoke(New Action(AddressOf RefDns))
                        Exit Do
                    End If
                Loop
            End If
            System.Threading.Thread.Sleep(10000)
        Loop




    End Sub



    'Private Sub CheckRemoteVersion()
    '    Dim v As String
    '    v = DD_Fun.GetRemoteVer()
    '    If v.Length <> 0 AndAlso v <> "ERR" Then
    '        Dim c As New System.IO.FileStream(DD_Fun.GetSettings("app_Extension") & "\CheckTime", IO.FileMode.Create)
    '        c.Close()
    '        FileIO.FileSystem.WriteAllText(DD_Fun.GetSettings("app_Extension") & "\CheckTime", Format(Now, "yyyy-MM-dd HH:mm:ss"), False)
    '        lbl_RemoteVer.Text = "远程hosts版本：" & v.Split("|")(0)
    '        If DD_Fun.GetSettings("app_IsAutoUpdate") = True Or IsManualUpdate = True Then
    '            If v.Split("|")(0) <> DD_Fun.GetLocalVer Then
    '                Backup(True)
    '                If DD_Fun.DownloadHosts(v.Split("|")(1)) = "OK" Then
    '                    Dim u As New System.IO.FileStream(DD_Fun.GetSettings("app_Extension") & "\UpdateTime", IO.FileMode.Create)
    '                    u.Close()
    '                    FileIO.FileSystem.WriteAllText(DD_Fun.GetSettings("app_Extension") & "\UpdateTime", Format(Now, "yyyy-MM-dd HH:mm:ss"), False)
    '                    ApplyCustomizeHosts()

    '                End If
    '            End If
    '            IsManualUpdate = False
    '            Do
    '                If Me.IsHandleCreated = True Then
    '                    Me.BeginInvoke(New Action(AddressOf ChangeText))
    '                    Exit Do
    '                End If
    '            Loop
    '        End If
    '        GetTime()
    '        GetHostsVer()
    '        RefDns()
    '    End If


    Private Sub ChangeText()
        btn_UpdateHosts.Text = "更新hosts文件"
    End Sub

    Private Sub GetTime()
        If DD_Fun.GetSettings("app_Extension") <> "str_null" AndAlso DD_Fun.GetSettings("app_Extension") <> "" Then
            If My.Computer.FileSystem.FileExists(DD_Fun.GetSettings("app_Extension") & "\UpdateTime") Then
                lbl_LastUpdateDate.Text = "上次更新时间：" & FileIO.FileSystem.ReadAllText(DD_Fun.GetSettings("app_Extension") & "\UpdateTime", System.Text.Encoding.GetEncoding("GB2312"))
            Else
                lbl_LastUpdateDate.Text = "上次更新时间：-"
            End If
            If My.Computer.FileSystem.FileExists(DD_Fun.GetSettings("app_Extension") & "\CheckTime") Then
                lbl_LastCheckDate.Text = "检查更新时间：" & FileIO.FileSystem.ReadAllText(DD_Fun.GetSettings("app_Extension") & "\CheckTime", System.Text.Encoding.GetEncoding("GB2312"))
            Else
                lbl_LastCheckDate.Text = "检查更新时间：-"
            End If
        End If

    End Sub

    Private Sub RefDns()
        If DD_Fun.GetSettings("app_IsFlushdns") = True Then DD_Fun.flushdns()
    End Sub

End Class