<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimChat
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
        Me.UserList = New System.Windows.Forms.ListBox()
        Me.ChatHistory = New System.Windows.Forms.ListBox()
        Me.tmrSimChat = New System.Windows.Forms.Timer(Me.components)
        Me.chkLogChat = New System.Windows.Forms.CheckBox()
        Me.txtSndMsg = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdToggle = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserList
        '
        Me.UserList.FormattingEnabled = True
        Me.UserList.Location = New System.Drawing.Point(9, 19)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(137, 251)
        Me.UserList.Sorted = True
        Me.UserList.TabIndex = 5
        '
        'ChatHistory
        '
        Me.ChatHistory.FormattingEnabled = True
        Me.ChatHistory.Location = New System.Drawing.Point(6, 15)
        Me.ChatHistory.Name = "ChatHistory"
        Me.ChatHistory.ScrollAlwaysVisible = True
        Me.ChatHistory.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ChatHistory.Size = New System.Drawing.Size(479, 277)
        Me.ChatHistory.TabIndex = 4
        '
        'tmrSimChat
        '
        Me.tmrSimChat.Enabled = True
        Me.tmrSimChat.Interval = 1000
        '
        'chkLogChat
        '
        Me.chkLogChat.AutoSize = True
        Me.chkLogChat.Location = New System.Drawing.Point(43, 275)
        Me.chkLogChat.Name = "chkLogChat"
        Me.chkLogChat.Size = New System.Drawing.Size(69, 17)
        Me.chkLogChat.TabIndex = 7
        Me.chkLogChat.Text = "Log Chat"
        Me.chkLogChat.UseVisualStyleBackColor = True
        '
        'txtSndMsg
        '
        Me.txtSndMsg.Location = New System.Drawing.Point(12, 308)
        Me.txtSndMsg.Name = "txtSndMsg"
        Me.txtSndMsg.Size = New System.Drawing.Size(480, 20)
        Me.txtSndMsg.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdToggle)
        Me.GroupBox1.Controls.Add(Me.chkLogChat)
        Me.GroupBox1.Controls.Add(Me.UserList)
        Me.GroupBox1.Location = New System.Drawing.Point(503, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 325)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active"
        '
        'cmdToggle
        '
        Me.cmdToggle.Location = New System.Drawing.Point(9, 295)
        Me.cmdToggle.Name = "cmdToggle"
        Me.cmdToggle.Size = New System.Drawing.Size(137, 24)
        Me.cmdToggle.TabIndex = 9
        Me.cmdToggle.Text = "&Toggle"
        Me.cmdToggle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChatHistory)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(489, 299)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "History"
        '
        'SimChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 334)
        Me.Controls.Add(Me.txtSndMsg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SimChat"
        Me.Text = "SimChat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserList As System.Windows.Forms.ListBox
    Friend WithEvents ChatHistory As System.Windows.Forms.ListBox
    Friend WithEvents tmrSimChat As System.Windows.Forms.Timer
    Friend WithEvents chkLogChat As System.Windows.Forms.CheckBox
    Friend WithEvents txtSndMsg As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdToggle As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
