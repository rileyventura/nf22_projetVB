Module Module1
    'variables réponses au questions
    Public t1q1, t1q2, t1q3, t2q1, t2q2, t2q3, t3q1, t3q2, t3q3, t4q1, t4q2, t4q3 As Boolean
    Public ValeurQuestionBasse As Integer = 6
    Public ValeurQuestionMoyenne As Integer = 8
    Public ValeurQuestionHaute As Integer = 11

    Public score_tot As Double

    'variables pour griser les thèmes finis (T1 est renommé Tun, suite à des problèmes avec T1)
    Public T1, T2, T3, T4 As Boolean

    'variable prénom
    Public nom As String

    'Temps chrono
    Public TempsCourt = 50
    Public TempsLong = 80

End Module
