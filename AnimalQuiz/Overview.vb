Imports AnimalQuiz
Module Overview
    ' ------------------
    ' PUBLIC VARIABLES
    '-------------------

    Public Score As Integer
    Public MAX_QUESTIONS As Integer = 4

    ' -----------------------
    ' QUIZ QUESTION CONTENT
    '------------------------

    ' parallel array version 
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

    ' pointer to current question
    Public CurrentQuestionNo As Integer

End Module

