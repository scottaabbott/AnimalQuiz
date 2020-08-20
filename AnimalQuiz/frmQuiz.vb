Imports AnimalQuiz
Public Class frmQuiz
    Private Sub QuestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load question details in form
        'ShowQuestion(QuestionNo)

        labQNum.Text = (CurrentQuestionNo + 1) & ")"
        labQuestionText.Text = QuizQuestionText(CurrentQuestionNo).ToString
        rbtOption1.Text = QuizOption1Text(CurrentQuestionNo)
        rbtOption2.Text = QuizOption2Text(CurrentQuestionNo)
        rbtOption3.Text = QuizOption3Text(CurrentQuestionNo)
        rbtOption4.Text = QuizOption4Text(CurrentQuestionNo)

    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        frmMain.Show()
    End Sub
End Class