Module QuizStorage
    ' ------------------
    ' PUBLIC VARIABLES
    '-------------------

    Public points As Integer
    Public MAX_QUESTIONS As Integer = 20

    ' -----------------------
    ' QUIZ QUESTION CONTENT
    '------------------------

    Public QuizQuestionText(MAX_QUESTIONS) As String
    Public QuizOption1Text(MAX_QUESTIONS) As String
    Public QuizOption1Response(MAX_QUESTIONS) As String
    Public QuizOption2Text(MAX_QUESTIONS) As String
    Public QuizOption2Response(MAX_QUESTIONS) As String
    Public QuizOption3Text(MAX_QUESTIONS) As String
    Public QuizOption3Response(MAX_QUESTIONS) As String
    Public QuizOption4Text(MAX_QUESTIONS) As String
    Public QuizOption4Response(MAX_QUESTIONS) As String
    Public QuizQuestionAnswer(MAX_QUESTIONS) As Integer

    Public QuestionNo As Integer
End Module

