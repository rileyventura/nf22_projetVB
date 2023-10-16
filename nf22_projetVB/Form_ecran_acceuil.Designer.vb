<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_ecran_acceuil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ecran_acceuil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdTheme2 = New System.Windows.Forms.Button()
        Me.cmdTheme3 = New System.Windows.Forms.Button()
        Me.cmdTheme4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdResultats = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdQuitter = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdTheme1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.Label1.Location = New System.Drawing.Point(130, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(587, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quizz Développement Durable"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'cmdTheme2
        '
        Me.cmdTheme2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdTheme2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTheme2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cmdTheme2.Location = New System.Drawing.Point(439, 257)
        Me.cmdTheme2.Name = "cmdTheme2"
        Me.cmdTheme2.Size = New System.Drawing.Size(212, 69)
        Me.cmdTheme2.TabIndex = 3
        Me.cmdTheme2.Text = "Thème 2 : Société"
        Me.cmdTheme2.UseVisualStyleBackColor = False
        '
        'cmdTheme3
        '
        Me.cmdTheme3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdTheme3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTheme3.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cmdTheme3.Location = New System.Drawing.Point(178, 343)
        Me.cmdTheme3.Name = "cmdTheme3"
        Me.cmdTheme3.Size = New System.Drawing.Size(212, 69)
        Me.cmdTheme3.TabIndex = 4
        Me.cmdTheme3.Text = "Thème 3 : Economie"
        Me.cmdTheme3.UseVisualStyleBackColor = False
        '
        'cmdTheme4
        '
        Me.cmdTheme4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdTheme4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTheme4.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cmdTheme4.Location = New System.Drawing.Point(439, 343)
        Me.cmdTheme4.Name = "cmdTheme4"
        Me.cmdTheme4.Size = New System.Drawing.Size(212, 69)
        Me.cmdTheme4.TabIndex = 5
        Me.cmdTheme4.Text = "Thème 4 : Politique"
        Me.cmdTheme4.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 2
        '
        'cmdResultats
        '
        Me.cmdResultats.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdResultats.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResultats.ForeColor = System.Drawing.Color.White
        Me.cmdResultats.Location = New System.Drawing.Point(274, 451)
        Me.cmdResultats.Name = "cmdResultats"
        Me.cmdResultats.Size = New System.Drawing.Size(277, 32)
        Me.cmdResultats.TabIndex = 6
        Me.cmdResultats.Text = "Voir mes résultats"
        Me.cmdResultats.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(86, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(667, 91)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'cmdQuitter
        '
        Me.cmdQuitter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitter.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.cmdQuitter.Location = New System.Drawing.Point(12, 497)
        Me.cmdQuitter.Name = "cmdQuitter"
        Me.cmdQuitter.Size = New System.Drawing.Size(170, 32)
        Me.cmdQuitter.TabIndex = 10
        Me.cmdQuitter.Text = "Quitter l'application"
        Me.cmdQuitter.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.TextBox1.Location = New System.Drawing.Point(264, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 22)
        Me.TextBox1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Veuillez entrer votre prénom :"
        '
        'cmdTheme1
        '
        Me.cmdTheme1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmdTheme1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTheme1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cmdTheme1.Location = New System.Drawing.Point(178, 257)
        Me.cmdTheme1.Name = "cmdTheme1"
        Me.cmdTheme1.Size = New System.Drawing.Size(212, 69)
        Me.cmdTheme1.TabIndex = 13
        Me.cmdTheme1.Text = "Thème 1 : Environnement"
        Me.cmdTheme1.UseVisualStyleBackColor = False
        '
        'Form_ecran_acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.Captu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 541)
        Me.Controls.Add(Me.cmdTheme1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmdQuitter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdResultats)
        Me.Controls.Add(Me.cmdTheme4)
        Me.Controls.Add(Me.cmdTheme3)
        Me.Controls.Add(Me.cmdTheme2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form_ecran_acceuil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizz Développement durable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdTheme2 As Button
    Friend WithEvents cmdTheme3 As Button
    Friend WithEvents cmdTheme4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdResultats As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdQuitter As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdTheme1 As Button
End Class
