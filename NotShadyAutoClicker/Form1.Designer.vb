<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ClickType = New System.Windows.Forms.TextBox()
        Me.ClickTypeLabel = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.TopMostCheckbox = New System.Windows.Forms.CheckBox()
        Me.DelayLabel = New System.Windows.Forms.Label()
        Me.ClickDelayTextbox = New System.Windows.Forms.TextBox()
        Me.KeybindCheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AutoClickTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ClickType
        '
        Me.ClickType.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClickType.ForeColor = System.Drawing.Color.White
        Me.ClickType.Location = New System.Drawing.Point(3, 12)
        Me.ClickType.Name = "ClickType"
        Me.ClickType.Size = New System.Drawing.Size(100, 20)
        Me.ClickType.TabIndex = 0
        Me.ClickType.Text = "Left"
        '
        'ClickTypeLabel
        '
        Me.ClickTypeLabel.AutoSize = True
        Me.ClickTypeLabel.ForeColor = System.Drawing.Color.White
        Me.ClickTypeLabel.Location = New System.Drawing.Point(3, 1)
        Me.ClickTypeLabel.Name = "ClickTypeLabel"
        Me.ClickTypeLabel.Size = New System.Drawing.Size(57, 13)
        Me.ClickTypeLabel.TabIndex = 1
        Me.ClickTypeLabel.Text = "ClickType:"
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.Location = New System.Drawing.Point(3, 39)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 2
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopButton.ForeColor = System.Drawing.Color.White
        Me.StopButton.Location = New System.Drawing.Point(84, 39)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 3
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'TopMostCheckbox
        '
        Me.TopMostCheckbox.AutoSize = True
        Me.TopMostCheckbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TopMostCheckbox.ForeColor = System.Drawing.Color.White
        Me.TopMostCheckbox.Location = New System.Drawing.Point(165, 43)
        Me.TopMostCheckbox.Name = "TopMostCheckbox"
        Me.TopMostCheckbox.Size = New System.Drawing.Size(68, 17)
        Me.TopMostCheckbox.TabIndex = 4
        Me.TopMostCheckbox.Text = "TopMost"
        Me.TopMostCheckbox.UseVisualStyleBackColor = False
        '
        'DelayLabel
        '
        Me.DelayLabel.AutoSize = True
        Me.DelayLabel.ForeColor = System.Drawing.Color.White
        Me.DelayLabel.Location = New System.Drawing.Point(109, 1)
        Me.DelayLabel.Name = "DelayLabel"
        Me.DelayLabel.Size = New System.Drawing.Size(70, 13)
        Me.DelayLabel.TabIndex = 6
        Me.DelayLabel.Text = "Delay (in ms):"
        '
        'ClickDelayTextbox
        '
        Me.ClickDelayTextbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClickDelayTextbox.ForeColor = System.Drawing.Color.White
        Me.ClickDelayTextbox.Location = New System.Drawing.Point(109, 12)
        Me.ClickDelayTextbox.Name = "ClickDelayTextbox"
        Me.ClickDelayTextbox.Size = New System.Drawing.Size(100, 20)
        Me.ClickDelayTextbox.TabIndex = 5
        Me.ClickDelayTextbox.Text = "1000"
        '
        'KeybindCheckTimer
        '
        Me.KeybindCheckTimer.Enabled = True
        '
        'AutoClickTimer
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(234, 66)
        Me.Controls.Add(Me.DelayLabel)
        Me.Controls.Add(Me.ClickDelayTextbox)
        Me.Controls.Add(Me.TopMostCheckbox)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ClickTypeLabel)
        Me.Controls.Add(Me.ClickType)
        Me.MaximumSize = New System.Drawing.Size(250, 105)
        Me.MinimumSize = New System.Drawing.Size(250, 105)
        Me.Name = "MainForm"
        Me.Text = "AutoClicker v1.0.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClickType As TextBox
    Friend WithEvents ClickTypeLabel As Label
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents TopMostCheckbox As CheckBox
    Friend WithEvents DelayLabel As Label
    Friend WithEvents ClickDelayTextbox As TextBox
    Friend WithEvents KeybindCheckTimer As Timer
    Friend WithEvents AutoClickTimer As Timer
End Class
