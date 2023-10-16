
Imports System.Diagnostics

Public Class Form_resultats
    Public ListeScoresThemes() As Integer = {0, 0, 0, 0}
    Private Resultats(,) As Boolean = {{Module1.t1q1, Module1.t1q2, Module1.t1q3}, {Module1.t2q1, Module1.t2q2, Module1.t2q3}, {Module1.t3q1, Module1.t3q2, Module1.t3q3}, {Module1.t4q1, Module1.t4q2, Module1.t4q3}}
    Private ListeValeurQuestions() As Integer = {ValeurQuestionBasse, ValeurQuestionMoyenne, ValeurQuestionHaute}
    Private ListeScoreQuestions(11) As Integer
    Private ListeStringThemes() As String = {"Thème 1, Environnement : ", "Thème 2, Société : ", "Thème 3, Economie : ", "Thème 4, Politique : "}


    Private Sub Form_resultats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Décompte des points ici 
        'ListeScoresThemes rajoute la valeur d'une question (qui change en fonctionne de la "colonne" de la question) si seulement le résultat de la questino est juste.
        For row = 0 To 3
            For col = 0 To 2
                If Resultats(row, col) = True Then
                    ListeScoresThemes(row) += ListeValeurQuestions(col)
                End If
            Next
        Next

        For row = 0 To 3
            For col = 0 To 2
                If Resultats(row, col) = True Then
                    ListeScoreQuestions(row * 3 + col) = ListeValeurQuestions(col)
                Else
                    ListeScoreQuestions(row * 3 + col) = 0
                End If
            Next
        Next

        'Ajout des résultats dans chaque thème dans la listebox affichée
        For index = 0 To 3
            ListBox1.Items.Add(ListeStringThemes(index) + CStr(ListeScoresThemes(index)) + "/25")
        Next


        score_tot = ListeScoresThemes(0) + ListeScoresThemes(1) + ListeScoresThemes(2) + ListeScoresThemes(3)

        'Score total dans le label résultat, mis à jour à la fin du quiz car il prend le nom de l'utilisateur en compte.
        LabelResultat.Text = "Vous avez terminé le quizz " & nom & " ! Votre résultat est de" + Str(score_tot) + " sur 100."
        AfficherConseils()


    End Sub


    Private Sub cmdQuitter_Click(sender As Object, e As EventArgs) Handles cmdQuitter.Click
        End
    End Sub

    ' Fonction pour afficher les conseils personnalisés
    Private Sub AfficherConseils()
        ' Conseils pour le thème Environnement

        If ListeScoresThemes(0) < 10 Then
            Label3.Text = "Pour renforcer votre compréhension du développement durable, explorez des initiatives locales et des projets communautaires axés sur la préservation de la biodiverisité. N'hésitez pas à vous diriger vers la section EN APPRENDRE PLUS."

        ElseIf ListeScoresThemes(0) >= 10 And ListeScoresThemes(0) < 18 Then
            Label3.Text = "Vous montrez un bon engagement envers la protection de l'environnement. Continuez à vous impliquer dans des actions qui soutiennent la durabilité pour comprendre davantage quels sont les risques encourus pour la biodiversité."
        ElseIf ListeScoresThemes(0) >= 18 Then
            Label3.Text = "Bravo pour votre excellent score en développement durable et environnement ! Vous êtes un modèle à suivre dans la promotion d'un mode de vie respectueux de la biodiversité."
        End If

        ' Conseils pour le thème Société
        If ListeScoresThemes(1) < 10 Then
            Label4.Text = "Pour approfondir votre compréhension de l'impact social du développement durable, envisagez de vous impliquer dans des projets communautaires qui visent à améliorer la qualité de vie des habitants. N'hésitez pas à vous diriger vers la section EN APPRENDRE PLUS."
        ElseIf ListeScoresThemes(1) >= 10 And ListeScoresThemes(1) < 18 Then
            Label4.Text = "Vous démontrez une bonne sensibilité aux enjeux sociaux du développement durable. Continuez à soutenir les initiatives locales qui favorisent l'équité et l'inclusion."
        ElseIf ListeScoresThemes(1) >= 10 Then
            Label4.Text = "Félicitations pour votre excellent score en matière d'impact social du développement durable ! Vous êtes un moteur de changement positif dans la société."
        End If

        ' Conseils pour le thème Economie
        If ListeScoresThemes(2) < 10 Then
            Label5.Text = "Pour approfondir vos connaissances en économie durable, familiarisez avec les principes de l'économie circulaire. Cela consiste à réduire les déchets et à réutiliser les ressources autant que possible. N'hésitez pas à vous diriger vers la section EN APPRENDRE PLUS."
        ElseIf ListeScoresThemes(2) >= 10 And ListeScoresThemes(2) < 18 Then
            Label5.Text = "Votre intérêt pour l'économie durable est louable. Poursuivez vos efforts en explorant des moyens d'encourager des pratiques commerciales éthiques et écologiques."
        ElseIf ListeScoresThemes(2) >= 18 Then
            Label5.Text = "Bravo pour votre excellent score en économie durable ! Continuez à être un moteur du changement en promouvant des modèles économiques éthiques et écologiques qui visent à créer un impact positif sur la société."
        End If

        ' Conseils pour le thème Politique
        If ListeScoresThemes(3) < 10 Then
            Label6.Text = "Pour approfondir vos connaissances politiques, envisagez de suivre des cours en ligne, de lire des articles politiques et de participer à des discussions avec des politiques durables.N'hésitez pas à vous diriger vers la section EN APPRENDRE PLUS."
        ElseIf ListeScoresThemes(3) >= 10 And ListeScoresThemes(3) < 18 Then
            Label6.Text = "Vous montrez un bon niveau de connaissance en politique durable. Continuez à vous tenir informé(e) des actualités politiques et à participer aux débats sur la mise en place de stratégies environnementales."
        ElseIf ListeScoresThemes(3) >= 18 Then
            Label6.Text = "Bravo pour votre excellent score en connaissances politiques durables ! Vous avez une solide compréhension des enjeux politiques actuels en lien avec le développement durable. Continuez à vous impliquer et à influencer positivement vos proches dans le but de les sensibiliser."
        End If

    End Sub



    Private Sub cmdGraphique_Click(sender As Object, e As EventArgs) Handles cmdGraphique.Click
        Form_graphique.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        System.Diagnostics.Process.Start("https://www.coursera.org/learn/abc-sustainability")
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        System.Diagnostics.Process.Start("https://unccelearn.org/course/view.php?id=51&page=overview")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        System.Diagnostics.Process.Start("https://www.unsdglearn.org/courses/an-introduction-to-e-waste-policy/")
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        System.Diagnostics.Process.Start("https://www.my-mooc.com/fr/categorie/developpement-durable")
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        System.Diagnostics.Process.Start("https://www.rte-france.com/analyses-tendances-et-prospectives/bilan-previsionnel-2050-futurs-energetiques
")
    End Sub




    Private Sub T1Q1_Click(sender As Object, e As EventArgs) Handles T1Q1.Click
        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(0)) + " points sur " + Str(ValeurQuestionBasse) + ".")
    End Sub

    Private Sub T1Q2_Click(sender As Object, e As EventArgs) Handles T1Q2.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(1)) + " points sur " + Str(ValeurQuestionMoyenne) + ".")
    End Sub

    Private Sub T1Q3_Click(sender As Object, e As EventArgs) Handles T1Q3.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(2)) + " points sur " + Str(ValeurQuestionHaute) + ".")
    End Sub

    Private Sub T2Q1_Click(sender As Object, e As EventArgs) Handles T2Q1.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(3)) + " points sur " + Str(ValeurQuestionBasse) + ".")
    End Sub

    Private Sub T3Q1_Click(sender As Object, e As EventArgs) Handles T3Q1.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(6)) + " points sur " + Str(ValeurQuestionBasse) + ".")
    End Sub

    Private Sub T4Q1_Click(sender As Object, e As EventArgs) Handles T4Q1.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(9)) + " points sur " + Str(ValeurQuestionBasse) + ".")
    End Sub

    Private Sub T2Q2_Click(sender As Object, e As EventArgs) Handles T2Q2.Click
        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(4)) + " points sur " + Str(ValeurQuestionMoyenne) + ".")

    End Sub

    Private Sub T3Q2_Click(sender As Object, e As EventArgs) Handles T3Q2.Click
        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(7)) + " points sur " + Str(ValeurQuestionMoyenne) + ".")

    End Sub

    Private Sub T4Q2_Click(sender As Object, e As EventArgs) Handles T4Q2.Click
        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(10)) + " points sur " + Str(ValeurQuestionMoyenne) + ".")

    End Sub

    Private Sub T2Q3_Click(sender As Object, e As EventArgs) Handles T2Q3.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(5)) + " points sur " + Str(ValeurQuestionHaute) + ".")
    End Sub

    Private Sub T3Q3_Click(sender As Object, e As EventArgs) Handles T3Q3.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(8)) + " points sur " + Str(ValeurQuestionHaute) + ".")
    End Sub

    Private Sub T4Q3_Click(sender As Object, e As EventArgs) Handles T4Q3.Click

        MsgBox("Vous avez obtenu " + CStr(ListeScoreQuestions(11)) + " points sur " + Str(ValeurQuestionHaute) + ".")
    End Sub


End Class


