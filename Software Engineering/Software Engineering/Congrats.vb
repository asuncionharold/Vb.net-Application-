Public Class Congrats

    Private Sub Congrats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.stageClear, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Letters.Enabled = True
        Letters.Close()
        Color.Enabled = True
        Color.Close()
        Shapes.Enabled = True
        Shapes.Close()
        Mother_Form.Show()
        Me.Close()
    End Sub
End Class