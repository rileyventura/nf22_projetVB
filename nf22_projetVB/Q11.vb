Public Class Q11

    Private Sub Q11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ11.Enabled = False
        'Initialisation chrono

        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsCourt
        Timer1.Start()
    End Sub
    Private Sub cmdSuivQ11_Click(sender As Object, e As EventArgs) Handles cmdSuivQ11.Click
        QuestionFini()
    End Sub



    Private Sub cliqueReponse(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged

        cmdSuivQ11.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelChrono.Text = Val(LabelChrono.Text) - 1

        If LabelChrono.Text = 0 Then
            Timer1.Stop()
            QuestionFini()
        End If

    End Sub

    Private Sub QuestionFini()
        If RadioButton4.Checked = True Then
            t4q2 = True
        End If
        Q12.Show()
        Me.Close()
    End Sub


End Class
