Public Class Form_ecran_acceuil


    Private Sub Form_ecran_acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Bienvenue sur ce quizz sur le développement durable !" & Chr(13) & Chr(10) & "Celui-ci est composé de 4 parties de 3 questions, chacune portant sur un thème en particulier. Ceci est un test de connaissances, un score en fonction de vos résultats vous sera attribué à la fin du quizz." & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "Bonne chance !", "Quizz Développement durable")
        cmdResultats.Enabled = False


        t1q1 = t1q2 = t1q3 = t2q1 = t2q2 = t2q3 = t3q1 = t3q2 = t3q3 = t4q1 = t4q2 = t4q3 = False
        T1 = False
        T2 = T3 = T4 = False
    End Sub


    'Affichage des questions liées au thème cliqué
    Private Sub cmdTheme1_Click(sender As Object, e As EventArgs) Handles cmdTheme1.Click
        Q1.Show()
        TextBox1.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub cmdTheme2_Click(sender As Object, e As EventArgs) Handles cmdTheme2.Click
        Q4.Show()
        TextBox1.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub cmdTheme3_Click(sender As Object, e As EventArgs) Handles cmdTheme3.Click
        Q7.Show()
        TextBox1.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub cmdTheme4_Click(sender As Object, e As EventArgs) Handles cmdTheme4.Click
        Q10.Show()
        TextBox1.Visible = False
        Label5.Visible = False
    End Sub


    Private Sub grisage(sender As Object, e As EventArgs) Handles cmdTheme1.MouseHover, cmdTheme2.MouseHover, cmdTheme3.MouseHover, cmdTheme4.MouseHover, Me.MouseHover
        'Griser les thèmes si finis
        If T1 = True Then
            cmdTheme1.Enabled = False
        End If
        If T2 = True Then
            cmdTheme2.Enabled = False
        End If
        If T3 = True Then
            cmdTheme3.Enabled = False
        End If
        If T4 = True Then
            cmdTheme4.Enabled = False
        End If

        'Dégriser boutton résultats

        If Not cmdTheme1.Enabled AndAlso Not cmdTheme2.Enabled AndAlso Not cmdTheme3.Enabled AndAlso Not cmdTheme4.Enabled Then
            cmdResultats.Enabled = True
        End If
    End Sub



    Private Sub cmdResultats_Click(sender As Object, e As EventArgs) Handles cmdResultats.Click
        Form_resultats.Show()
        Me.Hide()
    End Sub

    'Boutton Quitter
    Private Sub cmdQuitter_Click_1(sender As Object, e As EventArgs) Handles cmdQuitter.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        nom = TextBox1.Text
    End Sub
End Class