Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form_graphique
    Private Sub cmdRetour_Click(sender As Object, e As EventArgs) Handles cmdRetour.Click

        Form_resultats.Show()
        Me.Hide()
    End Sub

    Private Sub Form_graphique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Chart1.Series("Note par thème").Points.AddXY("Environnement", Form_resultats.ListeScoresThemes(0))
        Me.Chart1.Series("Note par thème").Points.AddXY("Société", Form_resultats.ListeScoresThemes(1))
        Me.Chart1.Series("Note par thème").Points.AddXY("Economie", Form_resultats.ListeScoresThemes(2))
        Me.Chart1.Series("Note par thème").Points.AddXY("Politique", Form_resultats.ListeScoresThemes(3))

    End Sub

    Private Sub cmdQuitter_Click(sender As Object, e As EventArgs) Handles cmdQuitter.Click
        End
    End Sub
End Class