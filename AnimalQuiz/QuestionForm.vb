Imports AnimalQuiz
Public Class QuestionForm
    Private Sub QuestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load question details in form
        'ShowQuestion(QuestionNo)

        labQNum.Text = (QuestionNo + 1) & ")"
        labQuestionText.Text = QuizQuestionText(QuestionNo).ToString
        rbtOption1.Text = QuizOption1Text(QuestionNo)
        rbtOption2.Text = QuizOption2Text(QuestionNo)
        rbtOption3.Text = QuizOption3Text(QuestionNo)
        rbtOption4.Text = QuizOption4Text(QuestionNo)

    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Close()
    End Sub
End Class