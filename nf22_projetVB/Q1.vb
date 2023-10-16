Public Class Q1

    'Activation/désactivation bouton "Suivant"
    Private Sub Q1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ1.Enabled = False
        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsCourt
        Timer1.Start()
        t1q1 = False
    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Select Case CheckedListBox1.CheckedItems.Count
            Case <> 0 : cmdSuivQ1.Enabled = True
            Case = 0 : cmdSuivQ1.Enabled = False
        End Select
    End Sub

    'Vérification de la réponse
    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmdSuivQ1.Click
        QuestionFini()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LabelChrono.Text = Val(LabelChrono.Text) - 1

        If LabelChrono.Text = 0 Then
            Timer1.Stop()
            QuestionFini()
        End If

    End Sub

    Private Sub QuestionFini()
        If CheckedListBox1.GetItemChecked(0) = True And CheckedListBox1.GetItemChecked(1) = True And CheckedListBox1.GetItemChecked(3) = True And CheckedListBox1.GetItemChecked(4) = True Then
            t1q1 = True
        End If

        Q2.Show()
        Me.Close()
    End Sub


End Class