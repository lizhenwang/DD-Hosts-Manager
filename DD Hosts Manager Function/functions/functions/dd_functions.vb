' DD Hosts Manager functions
' Powered by A-Studio.cn
Public Class dd_functions
    Dim HostsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows) & "\System32\drivers\etc\hosts"

    Dim ext_Name As String            '扩展名
    Dim ext_Author As String          '扩展作者
    Dim ext_link As String            '支持链接
    Dim ext_Version As String         '扩展版本
    Dim ext_Description As String     '扩展简介
    Dim ext_UpdateUrl As String       '扩展更新地址
    Dim ext_hostsPath As String       'hosts文件更新地址

    Dim app_UpgradeUrl As String      'DD hosts更新地址
    Dim app_ExtensionUrl As String    '下载扩展的地址
    Dim app_IsBeta As Boolean         '是否为测试版的软件
    Dim app_IsFlushdns As Boolean     '是否刷新DNS缓存
    Dim app_IsShowSubtitle As Boolean '是否在标题栏显示子标题（废弃）
    Dim app_IsAutoUpdate As Boolean   '是否自动更新hosts文件
    Dim app_IsNotice As Boolean       '启动时是否提示升级DD hosts
    Dim app_Extension As String       '启用的插件
    Dim app_Language As String        '启用的语言
    Dim app_IsBackup As Boolean       '是否自动备份hosts文件

#Region "载入DD hosts软件属性"
    Public Function LoadProp(PropPath As String)
        app_UpgradeUrl = "str_null"
        app_ExtensionUrl = "str_null"
        app_IsBeta = False
        Dim r() As String = System.IO.File.ReadAllLines(PropPath, Text.Encoding.GetEncoding("GB2312"))
        If Not PropPath = "" Then
            If My.Computer.FileSystem.FileExists(PropPath) Then
                For Each ItemName As String In r
                    If ItemName.Split("=").Count > 0 Then
                        Select Case UCase(ItemName.Split("=")(0))
                            Case "APP_UPGRADEURL"
                                app_UpgradeUrl = ItemName.Split("=")(1)
                            Case "APP_EXTENSIONURL"
                                app_ExtensionUrl = ItemName.Split("=")(1)
                            Case "APP_ISBETA"
                                app_IsBeta = IIf(ItemName.Split("=")(1) = "1", 1, 0)
                        End Select
                    End If
                Next
            End If
        End If
    End Function

#End Region

#Region "载入DD hosts软件设置"
    Public Function LoadSettings(SettingPath As String)
        app_IsAutoUpdate = False
        app_IsNotice = False
        app_Extension = "str_null"
        app_Language = "zh_cn"
        app_IsBackup = False
        app_IsFlushdns = False
        If Not SettingPath = "" Then
            If My.Computer.FileSystem.FileExists(SettingPath) Then
                Dim r() As String = System.IO.File.ReadAllLines(SettingPath, Text.Encoding.GetEncoding("GB2312"))
                For Each ItemName As String In r
                    If ItemName.Split("=").Count > 0 Then
                        Select Case UCase(ItemName.Split("=")(0))


                            Case "APP_ISAUTOUPDATE"
                                app_IsAutoUpdate = IIf(ItemName.Split("=")(1) = "1", 1, 0)
                            Case "APP_ISNOTICE"
                                app_IsNotice = IIf(ItemName.Split("=")(1) = "1", 1, 0)
                            Case "APP_EXTENSION"
                                app_Extension = ItemName.Split("=")(1)
                            Case "APP_LANGUAGE"
                                app_Language = ItemName.Split("=")(1)
                            Case "APP_ISBACKUP"
                                app_IsBackup = IIf(ItemName.Split("=")(1) = "1", 1, 0)
                            Case "APP_ISFLUSHDNS"
                                app_IsFlushdns = IIf(ItemName.Split("=")(1) = "1", 1, 0)
                        End Select
                    End If
                Next
            End If
        End If
    End Function

#End Region

#Region "调用DD hosts软件设置"
    Public Function GetSettings(ItemName As String, Optional ByVal APP_Path As String = "")
        Select Case UCase(ItemName)
            Case "APP_UPGRADEURL"
                Return app_UpgradeUrl
            Case "APP_EXTENSIONURL"
                Return app_ExtensionUrl
            Case "APP_ISBETA"
                Return app_IsBeta
            Case "APP_ISSHOWSUBTITLE"
                Return app_IsShowSubtitle
            Case "APP_ISAUTOUPDATE"
                Return app_IsAutoUpdate
            Case "APP_ISNOTICE"
                Return app_IsNotice
            Case "APP_EXTENSION"
                Return app_Extension
            Case "APP_LANGUAGE"
                Return app_Language
            Case "APP_ISBACKUP"
                Return app_IsBackup
            Case "APP_ISFLUSHDNS"
                Return app_IsFlushdns
            Case "APP_ISAUTOSTART"
                Dim regChecker
                If Environment.Is64BitOperatingSystem = True Then
                    regChecker = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", True).GetValue("DD Hosts Manager")
                Else
                    regChecker = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).GetValue("DD Hosts Manager")
                End If
                If LCase(regChecker) = LCase(Chr(34) & APP_Path & Chr(34) & " -hide") Then
                    Return True
                Else
                    Return False
                End If
                regChecker.Close()

        End Select
    End Function

#End Region

#Region "设置开机启动"
    Public Function SetAutoStart(App_Path As String, IsAutoStart As Boolean) As Boolean
        On Error Resume Next
        Dim reg
        If IsAutoStart = True Then
            If Environment.Is64BitOperatingSystem = True Then
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", True)
            Else
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            End If
            reg.SetValue("DD Hosts Manager", Chr(34) & App_Path & Chr(34) & " -hide")
            reg.Close()
        Else
            If Environment.Is64BitOperatingSystem = True Then
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run", True)
            Else
                reg = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            End If
            reg.DeleteValue("DD Hosts Manager")
            reg.Close()
        End If
    End Function
#End Region

#Region "载入[扩展]属性"
    Public Function LoadExtension(Optional extPath As String = "")
        ext_Name = "str_null"
        ext_Author = "str_null"
        ext_link = "str_null"
        ext_Version = "str_null"
        ext_Description = "str_null"
        ext_UpdateUrl = "str_null"
        ext_hostsPath = "str_null"
        If Not extPath = "" Then
            If My.Computer.FileSystem.FileExists(extPath) Then
                Dim r() As String = System.IO.File.ReadAllLines(extPath, Text.Encoding.GetEncoding("GB2312"))
                For Each ItemName As String In r
                    If ItemName.Split("=").Count > 0 Then
                        Select Case UCase(ItemName.Split("=")(0))
                            Case "EXT_NAME"
                                ext_Name = ItemName.Split("=")(1)
                            Case "EXT_AUTHOR"
                                ext_Author = ItemName.Split("=")(1)
                            Case "EXT_LINK"
                                ext_link = ItemName.Split("=")(1)
                            Case "EXT_VERSION"
                                ext_Version = ItemName.Split("=")(1)
                            Case "EXT_DESCRIPTION"
                                ext_Description = ItemName.Split("=")(1)
                            Case "EXT_UPDATEURL"
                                ext_UpdateUrl = ItemName.Split("=")(1)
                            Case "EXT_HOSTSPATH"
                                ext_hostsPath = ItemName.Split("=")(1)
                        End Select
                    End If
                Next
            End If
        End If

    End Function

#End Region

#Region "调用[扩展]属性"
    Public Function GetExtensionProp(ItemName As String) As String
        Select Case UCase(ItemName)
            Case "EXT_NAME"
                Return ext_Name
            Case "EXT_AUTHOR"
                Return ext_Author
            Case "EXT_LINK"
                Return ext_link
            Case "EXT_VERSION"
                Return ext_Version
            Case "EXT_DESCRIPTION"
                Return ext_Description
            Case "EXT_UPDATEURL"
                Return ext_UpdateUrl
            Case "EXT_HOSTSPATH"
                Return ext_hostsPath
        End Select
    End Function

#End Region

#Region "获取更新"

    Public Function GetUpdate(APPorEXT As Boolean) As String
        Try
            Dim dl As New System.Net.WebClient
            Dim str As String
            str = dl.DownloadString(IIf(APPorEXT, app_UpgradeUrl, ext_UpdateUrl))
            If str.Length = 0 Then
                Return "ERR"
            Else
                Return str
            End If
        Catch ex As Exception
            Return "ERR"
        End Try
    End Function
#End Region

#Region "备份系统hosts文件，输入保存文件的路径Public Function Backup(ByVal SavePath As String) As Boolean"
    Public Function Backup(ByVal SavePath As String) As Boolean
        If My.Computer.FileSystem.FileExists(HostsPath) = True Then
            My.Computer.FileSystem.CopyFile(HostsPath, SavePath, True)
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "还原备份的hosts文件，输入需要还原的文件路径Public Function Restore(ByVal Source As String) As Boolean"
    Public Function Restore(ByVal Source As String) As Boolean
        Try
            My.Computer.FileSystem.MoveFile(Source, HostsPath, True)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region

#Region "执行flushdns刷新DNS缓存，无需输入参数"
    Public Function flushdns() As String
        Dim f As New System.Diagnostics.Process
        With f
            .StartInfo.FileName = "ipconfig"
            .StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            .StartInfo.Arguments = "/flushdns"
            .Start()
        End With
    End Function

#End Region

#Region "下载更多扩展"
    Public Function dl_ext() As String
        Dim d As New System.Diagnostics.Process
        With d
            .StartInfo.FileName = app_ExtensionUrl
            .StartInfo.WindowStyle = ProcessWindowStyle.Normal
            Try
                .Start()
            Catch ex As Exception
                .StartInfo.FileName = "iexplore.exe"
                .StartInfo.Arguments = app_ExtensionUrl
                .Start()
            End Try

        End With
    End Function

#End Region

#Region "获取本地hosts文件的版本"
    Public Function GetLocalVer() As String
        Try
            If My.Computer.FileSystem.FileExists(HostsPath) Then
                If Not FileLen(HostsPath) = 0 Then
                    Dim FirstLine As String
                    Dim readline As IO.StreamReader
                    readline = FileIO.FileSystem.OpenTextFileReader(HostsPath)
                    FirstLine = readline.ReadLine()
                    readline.Close()
                    If InStr(FirstLine, "# DD Hosts Version") > 0 Then
                        Return Mid(FirstLine, "# DD Hosts Version".Length + 2, FirstLine.Length - "# DD Hosts Version".Length + 1)
                    Else
                        Return "ERR"
                    End If
                Else
                    Return "ERR"
                End If
            Else
                Return "ERR"
            End If
        Catch ex As Exception
            Return "ERR"
        End Try

    End Function

#End Region

#Region "获取远程hosts文件的版本"
    Public Function GetRemoteVer() As String
        Dim str As String
        If My.Computer.Network.IsAvailable Then
            Try
                Dim ds As New System.Net.WebClient
                str = ds.DownloadString(ext_hostsPath)
                If str.Length = 0 Then
                    Return "ERR"
                Else
                    Return str
                End If
            Catch ex As Exception
                Return "ERR"
            End Try
        Else
            Return "ERR"
        End If
    End Function

#End Region

#Region "下载hosts文件，注意返回下载结果"
    Public Function DownloadHosts(ByVal fileURL As String) As String
        Dim dl As New System.Net.WebClient
        Dim str As String
        Try
            dl.Encoding = Text.Encoding.ASCII
            str = dl.DownloadString(fileURL)
            If str.Length = 0 Then
                Return "ERR"
            Else
                Try
                    'Dim WriteHosts As New System.IO.FileStream(HostsPath, IO.FileMode.Create, IO.FileAccess.Write)
                    'WriteHosts.Write(System.Text.Encoding.ASCII.GetBytes(str), System.Text.Encoding.ASCII.GetBytes(str).Length, 0)
                    'WriteHosts.Close()
                    If Not My.Computer.FileSystem.FileExists(HostsPath) Then
                        Dim c As New System.IO.FileStream(HostsPath, IO.FileMode.Create)
                        c.Close()
                    End If
                    Try
                        FileIO.FileSystem.WriteAllText(HostsPath, str, False)
                    Catch ex As Exception
                        Return "ERR"       '无法写入hosts文件
                    End Try

                    Return "OK"
                Catch ex As Exception
                    Return "ERR"
                End Try
            End If
        Catch ex As Exception
            Return "ERR"
        End Try

    End Function

#End Region

#Region "应用自定义的hosts内容，输入自定义的内容，若不存在或清除自定义，则无需输入参数"
    Public Function Customize(Optional ByVal TXT As String = "") As String
        On Error Resume Next
        Dim AllTXT As String
        Dim NewTXT As String = ""
        If My.Computer.FileSystem.FileExists(HostsPath) = True Then
            AllTXT = FileIO.FileSystem.ReadAllText(HostsPath)
            'If My.Computer.FileSystem.FileExists(HostsPath) Then My.Computer.FileSystem.DeleteFile(HostsPath)
            Dim RewriteTXT As New System.IO.FileStream(HostsPath, IO.FileMode.Create, IO.FileAccess.Write)
            If InStr(AllTXT, "# Customize Hosts Start") = 0 Then
                If Not TXT = "" Then
                    NewTXT = AllTXT & vbCrLf & "# Customize Hosts Start" & vbCrLf & TXT & vbCrLf & "# Customize Hosts End"
                Else
                    NewTXT = AllTXT
                End If
            Else
                If TXT = "" Then
                    NewTXT = AllTXT.Replace(Mid(AllTXT, InStr(AllTXT, "# Customize Hosts Start") - 2, InStr(AllTXT, "# Customize Hosts End") - InStr(AllTXT, "# Customize Hosts Start") + "# Customize Hosts End".Length + 2), "")
                Else
                    NewTXT = AllTXT.Replace(Mid(AllTXT, InStr(AllTXT, "# Customize Hosts Start") - 2, InStr(AllTXT, "# Customize Hosts End") - InStr(AllTXT, "# Customize Hosts Start") + "# Customize Hosts End".Length + 2), vbCrLf & "# Customize Hosts Start" & vbCrLf & TXT & vbCrLf & "# Customize Hosts End")
                End If

            End If

            RewriteTXT.Write(System.Text.Encoding.ASCII.GetBytes(NewTXT), 0, System.Text.Encoding.ASCII.GetBytes(NewTXT).Length)
            RewriteTXT.Close()
        Else
            If Not TXT = "" Then
                Dim CreateFile As New System.IO.FileStream(HostsPath, IO.FileMode.Create, IO.FileAccess.Write)
                Dim HostsTXT() As Byte
                HostsTXT = System.Text.Encoding.ASCII.GetBytes("# Created by DD Hosts" & vbCrLf & "# Customize Hosts Start" & vbCrLf & TXT & vbCrLf & "# Customize Hosts End")
                CreateFile.Write(HostsTXT, 0, HostsTXT.Length)
                CreateFile.Close()
            End If

        End If
    End Function

#End Region

#Region "读取[扩展]属性"
    Public Function GetExtensionProp_TEMP(extPath As String, ItemName As String) As String
        If Not extPath = "" Then
            If My.Computer.FileSystem.FileExists(extPath) Then
                Dim r() As String = System.IO.File.ReadAllLines(extPath, System.Text.Encoding.GetEncoding("GB2312"))
                For Each I As String In r
                    If I.Split("=").Count > 1 Then
                        If UCase(I.Split("=")(0)) = UCase(ItemName) Then
                            If Not I.Split("=")(1) = "" Then

                                Return I.Split("=")(1)
                                Exit For
                            Else
                                Return "str_null"
                                Exit For
                            End If
                        End If
                    End If
                Next
            End If
        End If

    End Function

#End Region
End Class
