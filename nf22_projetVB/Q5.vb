Public Class Q5

    'Activation/désactivation bouton "Suivant"
    Private Sub Q5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ5.Enabled = False

        'Initialisation chrono

        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsLong
        Timer1.Start()
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        Label1.Visible = False
        Label2.Visible = False
    End Sub

    'Afficher les réponses
    Private Sub cmdAfficher_Click(sender As Object, e As EventArgs) Handles cmdAfficher.Click
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True

    End Sub
    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
            cmdSuivQ5.Enabled = True
        End If
    End Sub

    'Vérification de la réponse
    Private Sub cmdSuivQ5_Click(sender As Object, e As EventArgs) Handles cmdSuivQ5.Click
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
        If ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 0 Then
            t2q2 = True
        End If
        Q6.Show()
        Me.Close()

    End Sub

End Class