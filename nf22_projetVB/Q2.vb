Imports System.Threading

Public Class Q2

    'Activation/désactivation bouton "Suivant"
    Private Sub Q2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ2.Enabled = False

        'Initialisation chrono

        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsCourt
        Timer1.Start()

    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        cmdSuivQ2.Enabled = True
    End Sub

    'Vérification de la réponse
    Private Sub cmdSuivQ2_Click(sender As Object, e As EventArgs) Handles cmdSuivQ2.Click
        QuestionFini()
    End Sub

    Private Sub QuestionFini()
        If TrackBar1.Value = 2 Then
            t1q2 = True
        Else
            t1q2 = False

        End If
        Q3.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelChrono.Text = Val(LabelChrono.Text) - 1

        If LabelChrono.Text = 0 Then

            Timer1.Stop()
            QuestionFini()
        End If
    End Sub
End Class