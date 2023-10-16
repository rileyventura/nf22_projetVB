Public Class Q12
    Private Sub cmdSuivQ12_Click(sender As Object, e As EventArgs) Handles cmdSuivQ12.Click

        QuestionFini()
    End Sub

    Private Sub Q12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ12.Enabled = False

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
    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        If ComboBox1.Text <> "" And ComboBox2.Text <> "" Then
            cmdSuivQ12.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelChrono.Text = Val(LabelChrono.Text) - 1

        If LabelChrono.Text = 0 Then
            Timer1.Stop()
            QuestionFini()
        End If

    End Sub

    Private Sub QuestionFini()
        If ComboBox1.Text = "Subventionnement d'abonnements de transport en commun" And ComboBox2.Text = "Mettre en place des zones piétonnes et des pistes cyclables à hauteur de 800 000 €" Then
            t4q3 = True
        End If

        Form_ecran_acceuil.Show()
        T4 = True
        Me.Close()
    End Sub

    Private Sub cmdAfficher_Click(sender As Object, e As EventArgs) Handles cmdAfficher.Click
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
    End Sub
End Class