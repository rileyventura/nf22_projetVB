<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Q5
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Q5))
        Me.LblQ9 = New System.Windows.Forms.Label()
        Me.CorpsQ9 = New System.Windows.Forms.Label()
        Me.cmdAfficher = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSuivQ5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LabelChrono = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblQ9
        '
        Me.LblQ9.AutoSize = True
        Me.LblQ9.BackColor = System.Drawing.Color.Transparent
        Me.LblQ9.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQ9.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.LblQ9.Location = New System.Drawing.Point(327, 79)
        Me.LblQ9.Name = "LblQ9"
        Me.LblQ9.Size = New System.Drawing.Size(182, 37)
        Me.LblQ9.TabIndex = 1
        Me.LblQ9.Text = "Question 2"
        '
        'CorpsQ9
        '
        Me.CorpsQ9.BackColor = System.Drawing.Color.Transparent
        Me.CorpsQ9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorpsQ9.ForeColor = System.Drawing.Color.Black
        Me.CorpsQ9.Location = New System.Drawing.Point(10, 133)
        Me.CorpsQ9.Name = "CorpsQ9"
        Me.CorpsQ9.Size = New System.Drawing.Size(813, 170)
        Me.CorpsQ9.TabIndex = 2
        Me.CorpsQ9.Text = resources.GetString("CorpsQ9.Text")
        '
        'cmdAfficher
        '
        Me.cmdAfficher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAfficher.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdAfficher.Location = New System.Drawing.Point(295, 309)
        Me.cmdAfficher.Name = "cmdAfficher"
        Me.cmdAfficher.Size = New System.Drawing.Size(242, 26)
        Me.cmdAfficher.TabIndex = 3
        Me.cmdAfficher.Text = "Afficher les réponses"
        Me.cmdAfficher.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 420)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(780, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Quelle mesure Thomas pourrait-il prendre pour minimiser sa consommation d'énergie" &
    " tout en regardant des films en streaming ?"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(118, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(598, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Comment Thomas pourrait-il optimiser ses déplacements pour minimiser son empreint" &
    "e carbone ?"
        '
        'cmdSuivQ5
        '
        Me.cmdSuivQ5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuivQ5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cmdSuivQ5.Location = New System.Drawing.Point(738, 500)
        Me.cmdSuivQ5.Name = "cmdSuivQ5"
        Me.cmdSuivQ5.Size = New System.Drawing.Size(75, 26)
        Me.cmdSuivQ5.TabIndex = 8
        Me.cmdSuivQ5.Text = "Suivant"
        Me.cmdSuivQ5.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Utiliser un écran d'ordinateur plus petit", "Régler la qualité vidéo à un niveau inférieur", "Regarder des films pendant les heures creuses d'utilisation d'internet"})
        Me.ComboBox1.Location = New System.Drawing.Point(191, 447)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(464, 28)
        Me.ComboBox1.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Planifier ses trajets pour éviter les embouteillages", "Utiliser sa voiture, plus rapide que les transports en commun, pour tous ses dépl" &
                "acements  ", "Prendre des chemins plus longs pour profiter du paysage"})
        Me.ComboBox2.Location = New System.Drawing.Point(100, 382)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(628, 28)
        Me.ComboBox2.TabIndex = 10
        '
        'LabelChrono
        '
        Me.LabelChrono.AutoSize = True
        Me.LabelChrono.BackColor = System.Drawing.Color.Transparent
        Me.LabelChrono.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChrono.ForeColor = System.Drawing.Color.Black
        Me.LabelChrono.Location = New System.Drawing.Point(112, 503)
        Me.LabelChrono.Name = "LabelChrono"
        Me.LabelChrono.Size = New System.Drawing.Size(49, 20)
        Me.LabelChrono.TabIndex = 11
        Me.LabelChrono.Text = "Label3"
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 503)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Temps restant :"
        '
        'Q5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.Capture_ecran
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 541)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelChrono)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmdSuivQ5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAfficher)
        Me.Controls.Add(Me.CorpsQ9)
        Me.Controls.Add(Me.LblQ9)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Q5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizz Développement Durable : Thème 2 Question 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQ9 As Label
    Friend WithEvents CorpsQ9 As Label
    Friend WithEvents cmdAfficher As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdSuivQ5 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents LabelChrono As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
End Class
