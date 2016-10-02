Public Class LOGO
    Dim T As Double
    Dim Form_Top As Integer
    Dim IsAllowClose As Boolean
    Private Sub LOGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Environment.GetCommandLineArgs.Count > 1 Then
            If Environment.GetCommandLineArgs(1) = "-nologo" Then


                MainWindow.Show()
            Else
                Me.Opacity = 0
                With MainWindow
                    .ShowInTaskbar = False
                    .Opacity = 0
                    .Visible = False
                    .Show()
                    '.WindowState = FormWindowState.Minimized
                End With

            End If


        Else
            Dim th As New Threading.Thread(AddressOf Delay)
            th.Start()
            'Form_Top = Me.Top - 10
            'Me.Top = Me.Top - 10
        End If






        IsAllowClose = False
        Picture_LOGO.Image = Image.FromFile(Environment.CurrentDirectory & "\images\logo.png")
        With Me
            .Text = Application.ProductName
            .ShowInTaskbar = False
            .BackColor = Color.FromArgb(0, 122, 204)
        End With
        With MainText
            .Text = Application.ProductName
            .ForeColor = Color.White
        End With
        With lbl_subtitle
            .ForeColor = Color.White
            .Text = "下载、分发线上hosts文件的最佳方式"
        End With
    End Sub

    Private Sub Delay()
        'Do Until Me.Opacity = 1
        '    T = T + 0.1
        '    Me.BeginInvoke(New Action(AddressOf ChangeOpacity))
        '    Form_Top = Form_Top + 1
        '    System.Threading.Thread.Sleep(15)
        'Loop
        System.Threading.Thread.Sleep(2000)

        If UCase(System.Globalization.CultureInfo.InstalledUICulture.Name) = "ZH-HK" Or UCase(System.Globalization.CultureInfo.InstalledUICulture.Name) = "ZH-TW" Then
            Do
                If Me.IsHandleCreated = True Then
                    Me.BeginInvoke(New Action(AddressOf LoadFlag))
                    Exit Do
                End If
            Loop
        End If

        Do
            If Me.IsHandleCreated = True Then
                Me.BeginInvoke(New Action(AddressOf ChangeSub))
                Exit Do
            End If
        Loop

        System.Threading.Thread.Sleep(1500)
        'Do Until Me.Opacity = 0
        '    T = T - 0.1
        '    If Me.IsHandleCreated = True Then Me.BeginInvoke(New Action(AddressOf ChangeOpacity))
        '    System.Threading.Thread.Sleep(15)
        'Loop
        Do
            If Me.IsHandleCreated = True Then
                Me.BeginInvoke(New Action(AddressOf ShowMainForm))
                Exit Do
            End If
        Loop

    End Sub

    Private Sub LoadFlag()
        Me.Height = Me.Height + 50
        lbl_subtitle.Visible = False
        Picture_LOGO.Visible = False
        MainText.Visible = False
        Dim pic As New PictureBox
        With pic
            .Parent = Me
            .Size = Me.Size
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Image = Image.FromFile(Environment.CurrentDirectory & "\images\flag.jpg")
            .Top = 0
            .Left = 0
        End With
    End Sub
    Private Sub ChangeSub()
        lbl_subtitle.Text = "Powered by A-Studio.cn"
    End Sub
    Private Sub ChangeOpacity()

        Me.Opacity = T
        Me.Top = Form_Top
    End Sub

    Private Sub ShowMainForm()
        IsAllowClose = True
        MainWindow.Show()


    End Sub

    Private Sub LOGO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IsAllowClose = False Then e.Cancel = 1
    End Sub
End Class
