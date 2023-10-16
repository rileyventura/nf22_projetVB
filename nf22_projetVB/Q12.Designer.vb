<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Q12
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Q12))
        Me.LblQ9 = New System.Windows.Forms.Label()
        Me.CorpsQ9 = New System.Windows.Forms.Label()
        Me.cmdSuivQ12 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAfficher = New System.Windows.Forms.Button()
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
        Me.LblQ9.Text = "Question 3"
        '
        'CorpsQ9
        '
        Me.CorpsQ9.BackColor = System.Drawing.Color.Transparent
        Me.CorpsQ9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorpsQ9.ForeColor = System.Drawing.Color.Black
        Me.CorpsQ9.Location = New System.Drawing.Point(33, 134)
        Me.CorpsQ9.Name = "CorpsQ9"
        Me.CorpsQ9.Size = New System.Drawing.Size(745, 191)
        Me.CorpsQ9.TabIndex = 2
        Me.CorpsQ9.Text = resources.GetString("CorpsQ9.Text")
        '
        'cmdSuivQ12
        '
        Me.cmdSuivQ12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuivQ12.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdSuivQ12.Location = New System.Drawing.Point(8, 484)
        Me.cmdSuivQ12.Name = "cmdSuivQ12"
        Me.cmdSuivQ12.Size = New System.Drawing.Size(152, 49)
        Me.cmdSuivQ12.TabIndex = 14
        Me.cmdSuivQ12.Text = "Enregistrer et revenir à l'acceuil"
        Me.cmdSuivQ12.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Organiser des festivals culturels ", "Subventionnement d'abonnements de transport en commun", "Construire un nouvel immeuble à haute efficacité énergétique à hauteur de 1 100 0" &
                "00 €"})
        Me.ComboBox1.Location = New System.Drawing.Point(186, 398)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(538, 28)
        Me.ComboBox1.TabIndex = 15
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Planter davantage d'arbres dans les parcs  ", "Mettre en place des zones piétonnes et des pistes cyclables à hauteur de 800 000 " &
                "€", "Organiser des évènements sportifs en plein air "})
        Me.ComboBox2.Location = New System.Drawing.Point(186, 452)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(538, 28)
        Me.ComboBox2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Choisissez une politique pour réduire l'empreinte carbone :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(356, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Choisissez une politique pour améliorer la qualité de l'air :"
        '
        'cmdAfficher
        '
        Me.cmdAfficher.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAfficher.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdAfficher.Location = New System.Drawing.Point(287, 328)
        Me.cmdAfficher.Name = "cmdAfficher"
        Me.cmdAfficher.Size = New System.Drawing.Size(242, 26)
        Me.cmdAfficher.TabIndex = 19
        Me.cmdAfficher.Text = "Afficher les réponses"
        Me.cmdAfficher.UseVisualStyleBackColor = True
        '
        'LabelChrono
        '
        Me.LabelChrono.AutoSize = True
        Me.LabelChrono.BackColor = System.Drawing.Color.Transparent
        Me.LabelChrono.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChrono.Location = New System.Drawing.Point(780, 508)
        Me.LabelChrono.Name = "LabelChrono"
        Me.LabelChrono.Size = New System.Drawing.Size(49, 20)
        Me.LabelChrono.TabIndex = 20
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
        Me.Label3.Location = New System.Drawing.Point(682, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Temps restant :"
        '
        'Q12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.Capture_ecran
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 541)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelChrono)
        Me.Controls.Add(Me.cmdAfficher)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmdSuivQ12)
        Me.Controls.Add(Me.CorpsQ9)
        Me.Controls.Add(Me.LblQ9)
        Me.DoubleBuffered = True
        Me.Name = "Q12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizz Développement Durable : Thème 4 Question 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQ9 As Label
    Friend WithEvents CorpsQ9 As Label
    Friend WithEvents cmdSuivQ12 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdAfficher As Button
    Friend WithEvents LabelChrono As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
End Class
