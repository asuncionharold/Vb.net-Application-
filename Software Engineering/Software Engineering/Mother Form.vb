Public Class Mother_Form

    Public Hour As Integer
    Public Minute As Integer
    Public Second As Integer
    Dim HourM As Integer
    Dim MinuteM As Integer
    Dim SecondM As Integer

    Private Sub Mother_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OnBt.Enabled = False And OffBt.Enabled = True Then
            If HourTb.Text = "" And MinuteTb.Text = "" And SecondTb.Text = "" Then
                MessageBox.Show("Please enter access time.", "Authentication Error ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                My.Computer.Audio.Play(My.Resources.button1, AudioPlayMode.WaitToComplete)
                Category.Timer1.Interval = HourM + MinuteM + SecondM
                Letters.Timer1.Interval = Category.Timer1.Interval
                Color.Timer1.Interval = Category.Timer1.Interval
                Shapes.Timer1.Interval = Category.Timer1.Interval
                Numbers.Timer1.Interval = Category.Timer1.Interval
                Category.Show()
                Me.Close()
            End If
        Else
            '
            '
            '
            If HourTb.Text = "" And MinuteTb.Text = "" And SecondTb.Text = "" Then
                MessageBox.Show("Please enter access time.", "Authentication Error ",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                My.Computer.Audio.Stop()
                Category.Timer1.Interval = HourM + MinuteM + SecondM
                Letters.Timer1.Interval = Category.Timer1.Interval
                Color.Timer1.Interval = Category.Timer1.Interval
                Shapes.Timer1.Interval = Category.Timer1.Interval
                Numbers.Timer1.Interval = Category.Timer1.Interval
                Category.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Mother_Form_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.backgroundMusic, AudioPlayMode.BackgroundLoop)

        'Upon load'
        OnBt.Enabled = False
        OffBt.Enabled = True
        SoundVb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Senabled.gif")
        SoundVb.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub HourTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HourTb.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = HourTb.Text.Length
        ch = HourTb.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MessageBox.Show("The value you entered is not numeric.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Hour = Val(HourTb.Text)
            HourM = Hour * 3600000 'hours, the interval is in 60,000*milliseconds.

        Next
    End Sub

    Private Sub MinuteTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinuteTb.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = MinuteTb.Text.Length
        ch = MinuteTb.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MessageBox.Show("The value you entered is not numeric.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Minute = Val(MinuteTb.Text)
            MinuteM = Minute * 60000 'minutes, the interval is in 60*milliseconds.

        Next
    End Sub

    Private Sub SecondTb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondTb.TextChanged
        Dim ch(10) As Char
        Dim len As Integer
        len = SecondTb.Text.Length
        ch = SecondTb.Text.ToCharArray()
        For i = 0 To len - 1
            If Not IsNumeric(ch(i)) Then
                MessageBox.Show("The value you entered is not numeric.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Second = Val(SecondTb.Text)
            SecondM = Second * 1000 'seconds, the interval is in milliseconds.

        Next
    End Sub

    Private Sub OnBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnBt.Click
        My.Computer.Audio.Play(My.Resources.backgroundMusic, AudioPlayMode.BackgroundLoop)

        OnBt.Enabled = False
        OffBt.Enabled = True
        SoundVb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Senabled.gif")
        SoundVb.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub OffBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffBt.Click
        My.Computer.Audio.Stop()

        OnBt.Enabled = True
        OffBt.Enabled = False
        SoundVb.Image = Image.FromFile("C:\Users\Harold\Documents\Visual Studio 2010\Projects\Software Engineering\Software Engineering\Sdisabled.gif")
        SoundVb.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub SoundVb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundVb.Click

    End Sub
End Class