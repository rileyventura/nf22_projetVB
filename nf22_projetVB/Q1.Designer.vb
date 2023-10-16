<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Q1
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
        Me.LblQ9 = New System.Windows.Forms.Label()
        Me.CorpsQ9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.cmdSuivQ1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelChrono = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
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
        Me.LblQ9.TabIndex = 2
        Me.LblQ9.Text = "Question 1"
        '
        'CorpsQ9
        '
        Me.CorpsQ9.BackColor = System.Drawing.Color.Transparent
        Me.CorpsQ9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorpsQ9.ForeColor = System.Drawing.Color.Black
        Me.CorpsQ9.Location = New System.Drawing.Point(147, 147)
        Me.CorpsQ9.Name = "CorpsQ9"
        Me.CorpsQ9.Size = New System.Drawing.Size(553, 50)
        Me.CorpsQ9.TabIndex = 3
        Me.CorpsQ9.Text = "Parmi ces activités humaines, lesquelles produisent des gaz à effet de serre ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(181, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 200)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Réponses"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Le transport fluvial et maritime", "Le chauffage et l'éclairage des habitats (gaz, électricité)", "Les centrales nucléaires", "La circulation automobile et aérienne", "La déforestation"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(18, 43)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(444, 124)
        Me.CheckedListBox1.TabIndex = 0
        '
        'cmdSuivQ1
        '
        Me.cmdSuivQ1.BackColor = System.Drawing.Color.Transparent
        Me.cmdSuivQ1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuivQ1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.cmdSuivQ1.Location = New System.Drawing.Point(738, 500)
        Me.cmdSuivQ1.Name = "cmdSuivQ1"
        Me.cmdSuivQ1.Size = New System.Drawing.Size(75, 26)
        Me.cmdSuivQ1.TabIndex = 5
        Me.cmdSuivQ1.Text = "Suivant"
        Me.cmdSuivQ1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'LabelChrono
        '
        Me.LabelChrono.AutoSize = True
        Me.LabelChrono.BackColor = System.Drawing.Color.Transparent
        Me.LabelChrono.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChrono.Location = New System.Drawing.Point(112, 503)
        Me.LabelChrono.Name = "LabelChrono"
        Me.LabelChrono.Size = New System.Drawing.Size(49, 20)
        Me.LabelChrono.TabIndex = 6
        Me.LabelChrono.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 503)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Temps restant :"
        '
        'Q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.nf22_projetVB.My.Resources.Resources.Capture_ecran
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 541)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelChrono)
        Me.Controls.Add(Me.cmdSuivQ1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CorpsQ9)
        Me.Controls.Add(Me.LblQ9)
        Me.DoubleBuffered = True
        Me.Name = "Q1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizz Développement Durable : Thème 1 Question 1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQ9 As Label
    Friend WithEvents CorpsQ9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents cmdSuivQ1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelChrono As Label
    Friend WithEvents Label1 As Label
End Class
