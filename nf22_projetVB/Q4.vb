Imports System.Drawing.Text

Public Class Q4
    'Vérification de la réponse
    Private Sub cmdSuivQ4_Click(sender As Object, e As EventArgs) Handles cmdSuivQ4.Click
        QuestionFini()
    End Sub

    Private Sub Q4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ4.Enabled = False


        'Initialisation chrono

        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsCourt
        Timer1.Start()

    End Sub

    Private Sub cliqueReponse(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged
        cmdSuivQ4.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelChrono.Text = Val(LabelChrono.Text) - 1

        If LabelChrono.Text = 0 Then
            Timer1.Stop()
            QuestionFini()
        End If


    End Sub

    Private Sub QuestionFini()
        If RadioButton2.Checked = True Then
            t2q1 = True
        End If
        Q5.Show()
        Me.Close()
    End Sub




End Class