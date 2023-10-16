Public Class Q8
    Dim dernier_click As Integer

    Private Sub Q8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ8.Enabled = False

        'Initialisation chrono
        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsCourt
        Timer1.Start()
    End Sub

    Private Sub cmdSuivQ8_Click(sender As Object, e As EventArgs) Handles cmdSuivQ8.Click
        QuestionFini()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmdSuivQ8.Enabled = True
        dernier_click = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cmdSuivQ8.Enabled = True
        dernier_click = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmdSuivQ8.Enabled = True
        dernier_click = 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cmdSuivQ8.Enabled = True
        dernier_click = 4
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelChrono.Text = Val(LabelChrono.Text) - 1

        If LabelChrono.Text = 0 Then
            Timer1.Stop()
            QuestionFini()
        End If

    End Sub

    Private Sub QuestionFini()
        If dernier_click = 1 Then
            t3q2 = True
        End If

        Q9.Show()
        Me.Close()

    End Sub
End Class