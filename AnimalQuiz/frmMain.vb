Imports System.Text

Public Class frmMain

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' load questions for quiz
        LoadQuiz()

        ' reset Question pointer to first question
        CurrentQuestionNo = 0
        ShowQuestion(0)

    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs)
        Me.Hide()

        ' load questions for quiz
        'LoadQuiz()
        'ShowQuestion(0)


        frmQuiz.Show()
        'For QuestionNo = 0 To (MAX_QUESTIONS - 1)
        '   QuestionForm.Show()
        '    Exit For
        'Next
        'Me.Close
    End Sub
    Private Sub LoadQuiz()
        ' Question 1 (stored in array slot #0) 
        LoadQuestion(0, "What is the name for a group of Crows?", 1)
        LoadOption(0, 1, "Murder", "Correct! Good Job!")
        LoadOption(0, 2, "Flock", "Wrong! Generic. Try thinking outside the box!")
        LoadOption(0, 3, "Hoard", "Nope! Nice Try!")
        LoadOption(0, 4, "Squable", "Wrong! Wow ur REALLY thinking about this huh?")
    End Sub

    Private Sub LoadQuestion(QnNum As Integer, QnText As String, QnAnswer As Integer)
        QuizQuestionText(QnNum) = QnText
        QuizQuestionAnswer(QnNum) = QnAnswer
    End Sub
    Private Sub LoadOption(QnNum As Integer, OptNum As Integer, OptText As String, OptResponse As String)
        Select Case OptNum
            Case 1
                QuizOption1Text(QnNum) = OptText
                QuizOption1Response(QnNum) = OptResponse
            Case 2
                QuizOption2Text(QnNum) = OptText
                QuizOption2Response(QnNum) = OptResponse
            Case 3
                QuizOption3Text(QnNum) = OptText
                QuizOption3Response(QnNum) = OptResponse
            Case 4
                QuizOption4Text(QnNum) = OptText
                QuizOption4Response(QnNum) = OptResponse
        End Select
    End Sub
    Public Sub ShowQuestion(QnNum As Integer)
        ' Housekeeping
        Dim Contents As String

        Dim Title As String = QnNum.ToString & ") - " & QuizQuestionText(QnNum)
        Contents = "O1: " & QuizOption1Text(QnNum) & ", " & QuizOption1Response(QnNum) & vbCrLf
        Contents += "O2: " & QuizOption2Text(QnNum) & ", " & QuizOption2Response(QnNum) & vbCrLf
        Contents += "O3: " & QuizOption3Text(QnNum) & ", " & QuizOption3Response(QnNum) & vbCrLf
        Contents += "O4: " & QuizOption4Text(QnNum) & ", " & QuizOption4Response(QnNum) & vbCrLf

        MsgBox(Contents, vbOKOnly, Title)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This wonderful program was created by Teagan Abbott.")
    End Sub

    Private Sub QuizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuizToolStripMenuItem.Click
        Me.Hide()
        frmQuiz.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        frmHelp.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblShowPoints.Text = "Your score is " & Score.ToString & " points."
    End Sub
End Class
