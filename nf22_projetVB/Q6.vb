Public Class Q6

    'Activation/désactivation bouton "Suivant"
    Private Sub Q6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ6.Enabled = False

        'Initialisation chrono

        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsLong
        Timer1.Start()


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            cmdSuivQ6.Enabled = True
        End If
    End Sub


    'Vérification de la réponse (n'accepte que les mots attendus et n'accepte pas les chiffres)
    Private Sub cmdSuivQ6_Click(sender As Object, e As EventArgs) Handles cmdSuivQ6.Click

        Dim textBoxes() As TextBox = {TextBox1, TextBox2, TextBox3, TextBox4}
        Dim erreur As Boolean = False
        Dim motsAttendus() As String = {"Engagement", "Solidarité", "Education", "Collaboration", "engagement", "solidarité", "education", "collaboration", "éducation"}
        For Each tb As TextBox In textBoxes
            Dim userInput As String = tb.Text 'Vérification de la réponse 
            Dim motTrouve As Boolean = False

            For Each mot As String In motsAttendus
                If userInput.ToLower() = mot.ToLower() Then
                    motTrouve = True 'Le mot a été trouvé donc on marque la variable
                    Exit For
                End If
            Next

            If Not motTrouve OrElse userInput.Any(Function(c) Char.IsDigit(c)) Then
                erreur = True
            End If
        Next
        If erreur Then
            MessageBox.Show("Vérifiez l'orthographe des mots que vous avez saisi.", "Orthographe incorrecte")
        End If

        If erreur = False Then
            QuestionFini()
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
        If TextBox1.Text.ToLower.Trim() = "engagement" And
       TextBox2.Text.ToLower.Trim() = "solidarité" And
       TextBox3.Text.ToLower.Trim() = "collaboration" And
       TextBox4.Text.ToLower.Trim() = "education" Then
            t2q3 = True
        End If

        'variable pour griser le thème 2 sur l'écran d'acceuil
        Form_ecran_acceuil.Show()
        T2 = True
        Me.Close()
    End Sub

End Class