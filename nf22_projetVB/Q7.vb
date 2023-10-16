Public Class Q7

    Dim mots As Label

    Private Sub Q7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ7.Enabled = False

        'Initialisation chrono
        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsLong
        Timer1.Start()

    End Sub

    Private Sub cmdSuivQ7_Click(sender As Object, e As EventArgs) Handles cmdSuivQ7.Click
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
        If ListBox1.Items.Count = 4 Then
            If ListBox1.Items(0) = "Conférence des Nations Unies à Stockholm" And
            ListBox1.Items(1) = "Création du Protocole de Kyoto" And
            ListBox1.Items(2) = "Mise en place du marché européen des quotas d'émission" And
            ListBox1.Items(3) = "Adoption de l'Accord de Paris lors de la COP21" Then

                t3q1 = True
            End If
        End If
        Q8.Show()
        Me.Close()
    End Sub


    '1 : événements sur les objets source (labels groupés dans la variable mots)
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.MouseDown, Label4.MouseDown, Label1.MouseDown, Label2.MouseDown
        mots = CType(sender, Label)
        mots.DoDragDrop(mots, DragDropEffects.Copy)

    End Sub

    '2 : relargage dans la liste cible
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.DragEnter
        sender.items.add(mots.Text)
        mots.Visible = False
    End Sub

    '3 : Reset 
    Private Sub CmdReset_Click(sender As Object, e As EventArgs) Handles CmdReset.Click
        cmdSuivQ7.Enabled = False

        'Réinitialisez la ListBox
        ListBox1.Items.Clear()
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True

    End Sub

    'Affichage du bouton suivant"
    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.DragEnter
        If ListBox1.Items.Count = 4 Then
            cmdSuivQ7.Enabled = True
        End If
    End Sub
End Class




