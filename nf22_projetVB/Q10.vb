Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Q10

    Dim souris As Boolean = False
    Private Property cursorimage As Image
    Private Sub Q10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdSuivQ10.Enabled = False

        'Initialisation chrono

        Timer1.Enabled = True
        Timer1.Interval = 1000
        LabelChrono.Text = TempsLong
        Timer1.Start()
    End Sub

    'les procédures 6 à 11 permettent de déplacer des images sources (picturebox1,2,3) vers des picturebox cible (4,5,6)
    'en transportant l'image sur le curseur

    '6 : on change la propriété AllowDrp des images dans la procédure de chargement du formulaire
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.AllowDrop = True
        PictureBox2.AllowDrop = True
        PictureBox3.AllowDrop = True
        PictureBox4.AllowDrop = True
        PictureBox5.AllowDrop = True
        PictureBox6.AllowDrop = True
        PictureBox7.AllowDrop = True
        PictureBox8.AllowDrop = True
    End Sub
    '7
    Private Sub Pbsources_mousemove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove, PictureBox2.MouseMove, PictureBox3.MouseMove, PictureBox4.MouseMove
        If souris Then
            If sender.image Is Nothing Then Exit Sub
            sender.dodragdrop(sender.image, DragDropEffects.Move)
        Else
            souris = False
        End If
    End Sub
    '8
    Private Sub Pbsources_mousedown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown, PictureBox2.MouseDown, PictureBox3.MouseDown, PictureBox4.MouseDown
        souris = True
    End Sub

    '9

    Private Sub feedback(sender As Object, e As GiveFeedbackEventArgs) Handles PictureBox1.GiveFeedback, PictureBox2.GiveFeedback, PictureBox3.GiveFeedback, PictureBox4.GiveFeedback
        e.UseDefaultCursors = False
        Dim mypic As New Bitmap(CType(sender, PictureBox).Image)
        cursorimage = mypic.GetThumbnailImage(25, 25, Nothing, IntPtr.Zero)
        Cursor.Current = New Cursor(CType(cursorimage, System.Drawing.Bitmap).GetHicon())

    End Sub

    '10

    Private Sub Pbcibles_dragenter(sender As Object, e As DragEventArgs) Handles PictureBox5.DragEnter, PictureBox6.DragEnter, PictureBox7.DragEnter, PictureBox8.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            If e.KeyState = 9 Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    '11

    Private Sub Pbcibles_dragdrop(sender As Object, e As DragEventArgs) Handles PictureBox5.DragDrop, PictureBox6.DragDrop, PictureBox7.DragDrop, PictureBox8.DragDrop
        sender.image = e.Data.GetData(DataFormats.Bitmap)
        If PictureBox5.Image IsNot Nothing AndAlso PictureBox6.Image IsNot Nothing AndAlso PictureBox7.Image IsNot Nothing AndAlso PictureBox8.Image IsNot Nothing Then
            ' Activer le bouton suivant si toutes les boîtes sont remplies
            cmdSuivQ10.Enabled = True

        End If

    End Sub

    Private Sub cmdSuivQ10_Click(sender As Object, e As EventArgs) Handles cmdSuivQ10.Click
        Timer1.Stop()
        QuestionFini()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelChrono.Text = Val(LabelChrono.Text) - 1

        If LabelChrono.Text = 0 Then
            QuestionFini()
        End If

    End Sub
    Private Sub QuestionFini()
        If PictureBox1.Image Is PictureBox7.Image AndAlso PictureBox2.Image Is PictureBox6.Image AndAlso
       PictureBox3.Image Is PictureBox5.Image AndAlso PictureBox4.Image Is PictureBox8.Image Then

            t4q1 = True ' Si les images sont dans les bonnes boîtes, mettez t1q1 à True
        End If

        Q11.Show()
        Me.Close()
    End Sub


End Class




