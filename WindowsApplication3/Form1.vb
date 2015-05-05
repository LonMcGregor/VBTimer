'Léon McGregor
'Update: 09/07/12
'Name: Timer
'Asseses: Visual Basic 2010 Express

Public Class Form1
    Dim time As String
    Dim active As Boolean
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Maximum = time
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            My.Computer.Audio.Play("C:\Users\Lon\Documents\Visual Studio 2010\Projects\Timer\time.wav", AudioPlayMode.Background)
        End If
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        ProgressBar1.Value = 0
        time = timeSec.Text * 10 + timeMin.Text * 600 + timeHr.Text * 36000
        Timer1.Start()
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        Timer1.Stop()
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Timer1.Stop()
        ProgressBar1.Value = 0
    End Sub

    Private Sub cmdSetTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        time = timeSec.Text * 10
    End Sub

    Private Sub cmdResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResume.Click
        Timer1.Start()
    End Sub

    Private Sub cmdSilence_Click(sender As System.Object, e As System.EventArgs) Handles cmdSilence.Click
        My.Computer.Audio.Stop()
    End Sub
End Class
