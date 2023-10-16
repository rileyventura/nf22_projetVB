Public Class Q3
    Dim values() As Integer = {1, 2, 3, 4, 5}
    Dim answer As New List(Of Integer)
    Dim count As Integer
    Dim copie As Boolean

    'Activation/désactivation bouton "Suivant"
    Private Sub Q3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ3.Enabled = False

        'Initialisation chrono

        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsLong
        Timer1.Start()

    End Sub
    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged, NumericUpDown3.ValueChanged, NumericUpDown4.ValueChanged, NumericUpDown5.ValueChanged
        answer.Clear()
        answer.Add(NumericUpDown1.Value)
        answer.Add(NumericUpDown2.Value)
        answer.Add(NumericUpDown3.Value)
        answer.Add(NumericUpDown4.Value)
        answer.Add(NumericUpDown5.Value)

        'Compte pour chaque valeur (1, 2, 3, 4, 5) combien de fois elle est égale à la liste des NumericUpDown, si le count vaut 2 alors il y a une copie
        cmdSuivQ3.Enabled = False
        copie = False
        For Each entry In values

            count = 0
            For Each index In answer
                If index = entry Then
                    count += 1
                End If
            Next

            If count > 1 Then

                copie = True
            End If


        Next

        If copie = False Then
            cmdSuivQ3.Enabled = True
        End If

    End Sub

    'Fonctionnement question & vérification de la réponse
    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmdSuivQ3.Click
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
        'variable pour griser le thème 1 sur l'écran d'acceuil
        T1 = True

        Form_ecran_acceuil.Show()
        Me.Close()

        'variable score
        If NumericUpDown1.Value = 4 And NumericUpDown2.Value = 2 And NumericUpDown3.Value = 5 And NumericUpDown4.Value = 1 And NumericUpDown5.Value = 3 Then
            t1q3 = True

        End If
    End Sub
End Class