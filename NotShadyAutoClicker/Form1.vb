Public Class MainForm

    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Shared autoclickval As String
    Shared keybindpressed As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        keybindpressed = "False"
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        autoclickval = "True"
        AutoClickTimer.Interval = ClickDelayTextbox.Text
        AutoClickTimer.Start()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        autoclickval = "False"
    End Sub

    Private Sub TopMost_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostCheckbox.CheckedChanged
        Me.TopMost = TopMostCheckbox.Checked
    End Sub

    Private Sub KeybindCheckTimer_Tick(sender As Object, e As EventArgs) Handles KeybindCheckTimer.Tick
        If (GetAsyncKeyState(Keys.F7)) Then
            If keybindpressed = "False" Then
                If autoclickval = "True" Then
                    autoclickval = "False"
                Else
                    autoclickval = "True"
                    AutoClickTimer.Interval = ClickDelayTextbox.Text
                    AutoClickTimer.Start()
                End If
                keybindpressed = "True"
            End If
        Else
            keybindpressed = "False"
        End If
    End Sub

    Private Sub AutoClickTimer_Tick(sender As Object, e As EventArgs) Handles AutoClickTimer.Tick
        'LEFTDOWN = &H2
        'LEFTUP = &H4
        'RIGHTDOWN = &H8
        'RIGHTUP = &H10
        If ClickType.Text.ToLower = "left" Then
            mouse_event(&H2, 0, 0, 0, 0)
            mouse_event(&H4, 0, 0, 0, 0)
        ElseIf ClickType.Text.ToLower = "right" Then
            mouse_event(&H8, 0, 0, 0, 0)
            mouse_event(&H10, 0, 0, 0, 0)
        End If
        If autoclickval = "False" Then
            AutoClickTimer.Stop()
        End If
    End Sub

End Class