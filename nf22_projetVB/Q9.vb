Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates

Public Class Q9

    Private Sub Q9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ9.Enabled = False

        'Initialisation chrono
        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsCourt
        Timer1.Start()
    End Sub
    Private Sub cmdSuivQ9_Click(sender As Object, e As EventArgs) Handles cmdSuivQ9.Click
        QuestionFini()
    End Sub

    Private Sub TextBox1_Keypress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ("0123456789".Contains(e.KeyChar)) AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> Convert.ToChar(Keys.Delete) AndAlso
                e.KeyChar <> Convert.ToChar(Keys.Enter) AndAlso
                e.KeyChar <> Convert.ToChar(Keys.Tab) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            cmdSuivQ9.Enabled = False
        Else
            If 0 < Val(TextBox1.Text) < 100 Then
                cmdSuivQ9.Enabled = True
            End If
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

        If TextBox1.Text <> "" AndAlso 61 < Val(TextBox1.Text) And Val(TextBox1.Text) < 71 Then
            t3q3 = True
        End If

        Form_ecran_acceuil.Show()
        T3 = True
        Me.Close()

    End Sub

End Class
