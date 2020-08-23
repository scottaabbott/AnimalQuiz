Imports System.Text
Imports AnimalQuiz
Public Class frmQuiz

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' check answer & if correct increment score
        If Check_Answer() = True Then
            Score += 1
        End If

        ' hide quiz screen (even if more questions)
        Me.Hide()

        ' increment question counter
        CurrentQuestionNo += 1

        ' if no more questions, then return to main screen
        If CurrentQuestionNo = MAX_QUESTIONS Then
            frmMain.Show()
        Else
            ' display quiz window again to load next question
            Me.Show()
        End If
    End Sub

    ' function to check quiz answer and return if correct or not (correct = TRUE, incorrect = FALSE)
    Private Function Check_Answer() As Boolean
        ' define a variable to hold which option was selected
        Dim Selection As Integer = 0
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
        ' debug
        ' MsgBox("Selection: " & Selection.ToString & " QuizQuestionAnswer(qnum): " & QuizQuestionAnswer(CurrentQuestionNo), vbOKOnly, "Debug")

        ' display appropriate response based on selection & whether correct
        Show_Response(Selection, fCorrect)

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
            Case Else
                Feedback = "You must select one of the options!"
        End Select

        ' set title to indicate if correct or not
        If isCorrect Then
            Title = "CORRECT!"
            ' display response in message box
            MsgBox(Feedback, vbInformation + vbOKOnly, Title)
        Else
            ' display response in message box
            MsgBox(Feedback, vbCritical + vbOKOnly, Title)
        End If

    End Sub

    Private Sub frmQuiz_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' remove any previous selections
        ClearSelections()

        ' load question details in form
        'ShowQuestion(QuestionNo)
        lblQnNum.Text = "#" & (CurrentQuestionNo + 1).ToString
        gbxQuestion.Text = QuizQuestionText(CurrentQuestionNo).ToString
        'gbxQuestion.Text = (CurrentQuestionNo + 1).ToString & ") " & QuizQuestionText(CurrentQuestionNo).ToString
        optChoice1.Text = QuizOption1Text(CurrentQuestionNo)
        optChoice2.Text = QuizOption2Text(CurrentQuestionNo)
        optChoice3.Text = QuizOption3Text(CurrentQuestionNo)
        optChoice4.Text = QuizOption4Text(CurrentQuestionNo)
    End Sub

    Private Sub ClearSelections()
        optChoice1.Checked = False
        optChoice2.Checked = False
        optChoice3.Checked = False
        optChoice4.Checked = False
    End Sub
End Class