Public Class Category

    Dim display As Boolean

    Private Sub Category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        display = True

        If Mother_Form.OnBt.Enabled = False And Mother_Form.OffBt.Enabled = True Then
            My.Computer.Audio.Play(My.Resources.backgroundMusic, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        If Mother_Form.OnBt.Enabled = False Or Mother_Form.OffBt.Enabled = True Then
            My.Computer.Audio.Play(My.Resources.button2, AudioPlayMode.WaitToComplete)
            display = False
            Letters.Show()
            Me.Close()

        Else
            My.Computer.Audio.Stop()
            display = False
            Letters.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If display = True Then
            My.Computer.Audio.Play(My.Resources.timesup, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Stop()
            Timer1.Stop()
            MessageBox.Show("Times Up!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Mother_Form.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Mother_Form.OnBt.Enabled = False Or Mother_Form.OffBt.Enabled = True Then
            My.Computer.Audio.Play(My.Resources.button2, AudioPlayMode.WaitToComplete)
            display = False
            Color.Show()
            Me.Close()
        Else
            My.Computer.Audio.Stop()
            display = False
            Color.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Mother_Form.OnBt.Enabled = False Or Mother_Form.OffBt.Enabled = True Then
            My.Computer.Audio.Play(My.Resources.button2, AudioPlayMode.WaitToComplete)
            display = False
            Shapes.Show()
            Me.Close()
        Else
            My.Computer.Audio.Stop()
            display = False
            Shapes.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Mother_Form.OnBt.Enabled = False Or Mother_Form.OffBt.Enabled = True Then
            My.Computer.Audio.Play(My.Resources.button2, AudioPlayMode.WaitToComplete)
            display = False
            Numbers.Show()
            Me.Close()
        Else
            My.Computer.Audio.Stop()
            display = False
            Numbers.Show()
            Me.Close()
        End If
    End Sub

End Class