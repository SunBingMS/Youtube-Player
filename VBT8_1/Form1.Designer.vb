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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.URLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpacityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem020 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem040 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem060 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem080 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.URLToolStripMenuItem, Me.HideShowToolStripMenuItem, Me.OpacityToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 98)
        '
        'URLToolStripMenuItem
        '
        Me.URLToolStripMenuItem.Image = CType(resources.GetObject("URLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.URLToolStripMenuItem.Name = "URLToolStripMenuItem"
        Me.URLToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.URLToolStripMenuItem.Text = "URL"
        '
        'HideShowToolStripMenuItem
        '
        Me.HideShowToolStripMenuItem.Image = CType(resources.GetObject("HideShowToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HideShowToolStripMenuItem.Name = "HideShowToolStripMenuItem"
        Me.HideShowToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HideShowToolStripMenuItem.Text = "Hide/Show"
        '
        'OpacityToolStripMenuItem
        '
        Me.OpacityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem020, Me.ToolStripMenuItem040, Me.ToolStripMenuItem060, Me.ToolStripMenuItem080, Me.ToolStripMenuItem100})
        Me.OpacityToolStripMenuItem.Image = CType(resources.GetObject("OpacityToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpacityToolStripMenuItem.Name = "OpacityToolStripMenuItem"
        Me.OpacityToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.OpacityToolStripMenuItem.Text = "Opacity"
        '
        'ToolStripMenuItem020
        '
        Me.ToolStripMenuItem020.Name = "ToolStripMenuItem020"
        Me.ToolStripMenuItem020.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem020.Text = "20%"
        '
        'ToolStripMenuItem040
        '
        Me.ToolStripMenuItem040.Name = "ToolStripMenuItem040"
        Me.ToolStripMenuItem040.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem040.Text = "40%"
        '
        'ToolStripMenuItem060
        '
        Me.ToolStripMenuItem060.Name = "ToolStripMenuItem060"
        Me.ToolStripMenuItem060.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem060.Text = "60%"
        '
        'ToolStripMenuItem080
        '
        Me.ToolStripMenuItem080.Name = "ToolStripMenuItem080"
        Me.ToolStripMenuItem080.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem080.Text = "80%"
        '
        'ToolStripMenuItem100
        '
        Me.ToolStripMenuItem100.Name = "ToolStripMenuItem100"
        Me.ToolStripMenuItem100.Size = New System.Drawing.Size(102, 22)
        Me.ToolStripMenuItem100.Text = "100%"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(130, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(120, 90)
        Me.AxShockwaveFlash1.TabIndex = 0
        '
        'WebBrowser
        '
        Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(120, 90)
        Me.WebBrowser.TabIndex = 1
        Me.WebBrowser.Visible = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(120, 90)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents URLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpacityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem020 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem040 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem060 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem080 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem100 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser

End Class
