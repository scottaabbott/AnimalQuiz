Imports System.Text
Imports AnimalQuiz
Public Class frmQuiz
    Private Sub QuestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load question details in form
        'ShowQuestion(QuestionNo)

        lblQNum.Text = (CurrentQuestionNo + 1) & ")"
        lblQText.Text = QuizQuestionText(CurrentQuestionNo).ToString
        optChoice1.Text = QuizOption1Text(CurrentQuestionNo)
        optChoice2.Text = QuizOption2Text(CurrentQuestionNo)
        optChoice3.Text = QuizOption3Text(CurrentQuestionNo)
        optChoice4.Text = QuizOption4Text(CurrentQuestionNo)

    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Check_Answer() = True Then
            Score += 1
        End If
        Me.Hide()
        frmMain.Show()
    End Sub

    ' function to check quiz answer and return if correct or not (correct = TRUE, incorrect = FALSE)
    Private Function Check_Answer() As Boolean
        ' define a variable to hold which option was selected
        Dim Selection As Integer
        ' define variable to hodl whether correct answer or not - assume incorrect
        Dim fCorrect As Boolean = False

        ' work out which option was selected
        If optChoice1.Checked Then
            Selection = 1
        ElseIf optChoice2.Checked Then
            Selection = 2
        ElseIf optChoice3.Checked Then
            Selection = 3
        ElseIf optChoice4.Checked Then
            Selection = 4
        End If

        ' compare to answer and return if correct or not
        If QuizQuestionAnswer(CurrentQuestionNo) = Selection Then
            fCorrect = True
        End If

        ' display appropriate response based on selection & whether correct
        Show_Response(fCorrect, Selection)

        Return fCorrect

    End Function

    Private Sub Show_Response(selection As Integer, isCorrect As Boolean)

        Dim Title As String = "WRONG!"
        Dim Feedback As String = ""

        ' get appropriate response for selected choice
        Select Case selection
            Case 1
                Feedback = QuizOption1Response(CurrentQuestionNo)
            Case 2
                Feedback = QuizOption2Response(CurrentQuestionNo)
            Case 3
                Feedback = QuizOption3Response(CurrentQuestionNo)
            Case 4
                Feedback = QuizOption4Response(CurrentQuestionNo)
        End Select

        ' set title to indicate if correct or not
        If isCorrect Then
            Title = "CORRECT!"
        End If

        ' display response in message box
        MsgBox(Feedback, vbOKOnly, Title)

    End Sub
End Class