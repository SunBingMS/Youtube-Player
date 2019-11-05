Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class Form1

#Region "Var"

    Public Const MOD_ALT As Integer = &H1 'Alt key
    Public Const WM_HOTKEY As Integer = &H312

    <DllImport("User32.dll")> _
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, _
                        ByVal id As Integer, ByVal fsModifiers As Integer, _
                        ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")> _
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, _
                        ByVal id As Integer) As Integer
    End Function

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"
                    AxShockwaveFlash1.Stop()
                    Me.TopMost = False
                    Me.Visible = False
                Case "200"
                    Call HideAndShow()
                Case "300"
                    Call SetURL()
                Case "400"
                    Call SwitchMode()
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

#End Region

#Region "Form"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxShockwaveFlash1.Visible = True
        WebBrowser.Visible = False
        RegisterHotKey(Me.Handle, 100, MOD_ALT, Keys.Z)
        RegisterHotKey(Me.Handle, 200, MOD_ALT, Keys.X)
        RegisterHotKey(Me.Handle, 300, MOD_ALT, Keys.A)
        RegisterHotKey(Me.Handle, 400, MOD_ALT, Keys.Q)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle, 100)
        UnregisterHotKey(Me.Handle, 200)
        UnregisterHotKey(Me.Handle, 300)
        UnregisterHotKey(Me.Handle, 400)
    End Sub

#End Region

#Region "TrayMenu"

    Private Sub URLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles URLToolStripMenuItem.Click
        Call SetURL()
    End Sub

    Private Sub HideShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideShowToolStripMenuItem.Click
        Call HideAndShow()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Visible = True
        Me.TopMost = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem020.Click
        Me.Opacity = 0.2
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem040.Click
        Me.Opacity = 0.4
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem060.Click
        Me.Opacity = 0.6
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem080.Click
        Me.Opacity = 0.8
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem100.Click
        Me.Opacity = 1.0
    End Sub

#End Region

#Region "Process"

    Private Sub SetURL()
        Dim url As String = String.Empty
        If AxShockwaveFlash1.Visible = True Then
            url = InputBox("url", "Input", "").Replace("/watch?v=", "/v/")
        Else
            url = InputBox("url", "Input", "")
        End If
        If url.Equals("") Then
            Exit Sub
        End If
        If AxShockwaveFlash1.Visible = True Then
            If Not url.StartsWith("https://") Then
                url = "https://" & url
            End If
            AxShockwaveFlash1.Movie = url
        Else
            WebBrowser.Navigate(url)
        End If

    End Sub

    Private Sub HideAndShow()
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub

    Private Sub SwitchMode()
        If AxShockwaveFlash1.Visible Then
            AxShockwaveFlash1.Visible = False
            WebBrowser.Visible = True
        Else
            AxShockwaveFlash1.Visible = True
            WebBrowser.Visible = False
        End If
    End Sub

#End Region

    Private Sub WebBrowser_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser.NewWindow
        e.Cancel = True
        WebBrowser.Navigate(WebBrowser.StatusText)
    End Sub
End Class