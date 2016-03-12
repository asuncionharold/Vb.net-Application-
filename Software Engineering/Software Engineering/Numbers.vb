Public Class Numbers

    Dim Answer1 As Boolean
    Dim Answer2 As Boolean
    Dim Answer3 As Boolean
    Dim display As Boolean
    Dim ctr As Integer = 0

    Private Sub Numbers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        display = True

        If Mother_Form.OnBt.Enabled = False Or Mother_Form.OffBt.Enabled = True Then
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If

        '>>>>>>>>>>> Declaration
        Pic1Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\5.png")
        Pic1Vb.SizeMode = PictureBoxSizeMode.StretchImage
        Answer1 = False
        Pic2Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\0.png")
        Pic2Vb.SizeMode = PictureBoxSizeMode.StretchImage
        Answer2 = True
        Pic3Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\5.png")
        Pic3Vb.SizeMode = PictureBoxSizeMode.StretchImage
        Answer3 = False

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


    Private Sub Pic1Vb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic1Vb.Click
        If Answer1 = False And ctr = 0 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Answer1 = True And ctr = 1 Then
            My.Computer.Audio.Play(My.Resources.star, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            Pic1Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\4.png")
            Pic1Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer1 = False
            Pic2Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\4.png")
            Pic2Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer2 = False
            Pic3Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\2.png")
            Pic3Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer3 = True
            ctr = ctr + 1 '3

        ElseIf Answer1 = False And ctr = 2 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Answer1 = False And ctr = 2 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

        End If


    End Sub

    Private Sub Pic2Vb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic2Vb.Click
        If Answer2 = True And ctr = 0 Then
            My.Computer.Audio.Play(My.Resources.star, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            Pic1Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\1.png")
            Pic1Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer1 = True
            Pic2Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\9.png")
            Pic2Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer2 = False
            Pic3Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\9.png")
            Pic3Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer3 = False
            ctr = ctr + 1 '2

        ElseIf Answer2 = False And ctr = 1 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Answer2 = False And ctr = 2 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Answer2 = False And ctr = 3 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else

        End If
    End Sub

    Private Sub Pic3Vb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic3Vb.Click
        If Answer3 = False And ctr = 0 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Answer3 = False And ctr = 1 Then
            My.Computer.Audio.Play(My.Resources.button3, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            MessageBox.Show("Wrong Answer. Please Try Again.", "Sorry ", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        ElseIf Answer3 = True And ctr = 2 Then
            My.Computer.Audio.Play(My.Resources.star, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.musicAbc, AudioPlayMode.BackgroundLoop)
            Pic1Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\6.png")
            Pic1Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer1 = False
            Pic2Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\6.png")
            Pic2Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer2 = False
            Pic3Vb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Numbers\3.png")
            Pic3Vb.SizeMode = PictureBoxSizeMode.StretchImage
            Answer3 = True
            ctr = ctr + 1 '4

        ElseIf Answer3 = True And ctr = 3 Then
            Timer1.Stop()
            Me.Enabled = False
            Congrats.Show()

        Else

        End If
    End Sub
End Class