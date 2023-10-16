<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Q8
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
        Me.LblQ9 = New System.Windows.Forms.Label()
        Me.CorpsQ9 = New System.Windows.Forms.Label()
        Me.cmdSuivQ8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LabelChrono = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.CorpsQ9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorpsQ9.ForeColor = System.Drawing.Color.Black
        Me.CorpsQ9.Location = New System.Drawing.Point(180, 162)
        Me.CorpsQ9.Name = "CorpsQ9"
        Me.CorpsQ9.Size = New System.Drawing.Size(473, 25)
        Me.CorpsQ9.TabIndex = 2
        Me.CorpsQ9.Text = "Laquelle de ces mesures correspond à une taxation écologique ?"
        '
        'cmdSuivQ8
        '
        Me.cmdSuivQ8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuivQ8.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cmdSuivQ8.Location = New System.Drawing.Point(738, 500)
        Me.cmdSuivQ8.Name = "cmdSuivQ8"
        Me.cmdSuivQ8.Size = New System.Drawing.Size(75, 26)
        Me.cmdSuivQ8.TabIndex = 7
        Me.cmdSuivQ8.Text = "Suivant"
        Me.cmdSuivQ8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.planete
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(62, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 133)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Imposition forfaitaire sur les entreprises de réseaux (IFER)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.planete
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(249, 256)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 133)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Réglementation thermique de 2012"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.planete
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(434, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 133)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Protocole de Kyoto"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.planete
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(620, 256)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 133)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Cotisation Foncière des Entreprises (CFE)"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LabelChrono
        '
        Me.LabelChrono.AutoSize = True
        Me.LabelChrono.BackColor = System.Drawing.Color.Transparent
        Me.LabelChrono.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChrono.Location = New System.Drawing.Point(112, 503)
        Me.LabelChrono.Name = "LabelChrono"
        Me.LabelChrono.Size = New System.Drawing.Size(49, 20)
        Me.LabelChrono.TabIndex = 12
        Me.LabelChrono.Text = "Label1"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 503)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Temps restant :"
        '
        'Q8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.Capture_ecran
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 541)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelChrono)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdSuivQ8)
        Me.Controls.Add(Me.CorpsQ9)
        Me.Controls.Add(Me.LblQ9)
        Me.DoubleBuffered = True
        Me.Name = "Q8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizz Développement Durable : Thème 3 Question 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQ9 As Label
    Friend WithEvents CorpsQ9 As Label
    Friend WithEvents cmdSuivQ8 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LabelChrono As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
End Class
