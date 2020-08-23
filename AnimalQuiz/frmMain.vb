Imports System.Text

Public Class frmMain

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' load questions for quiz
        LoadQuiz()

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

        Dim Title As String = QnNum.ToString & ") " & QuizQuestionText(QnNum)
        Contents = "O1: " & QuizOption1Text(QnNum) & ", " & QuizOption1Response(QnNum) & vbCrLf
        Contents += "O2: " & QuizOption2Text(QnNum) & ", " & QuizOption2Response(QnNum) & vbCrLf
        Contents += "O3: " & QuizOption3Text(QnNum) & ", " & QuizOption3Response(QnNum) & vbCrLf
        Contents += "O4: " & QuizOption4Text(QnNum) & ", " & QuizOption4Response(QnNum) & vbCrLf

        MsgBox(Contents, vbInformation + vbOKOnly, Title)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This wonderful program was created by Teagan Abbott.")
    End Sub

    Private Sub QuizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuizToolStripMenuItem.Click
        Me.Hide()
        ' set question counter back to start of quiz
        CurrentQuestionNo = 0
        frmQuiz.Show()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Hide()
        frmHelp.Show()
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        lblShowPoints.Text = "Your score is " & Score.ToString & " points."
    End Sub
    Private Sub LoadQuiz()
        ' Question 1 (stored in array slot #0) 
        LoadQuestion(0, "What is the name for a group of Crows?", 1)
        LoadOption(0, 1, "Murder", "Correct! Good Job!")
        LoadOption(0, 2, "Flock", "Wrong! Generic. Try thinking outside the box!")
        LoadOption(0, 3, "Hoard", "Nope! Nice Try!")
        LoadOption(0, 4, "Squable", "Wrong! Wow ur REALLY thinking about this huh?")
        ShowQuestion(0) ' debug only

        ' Question 2 (stored in array slot #1) 
        LoadQuestion(1, "What is the name for a group of Cats?", 2)
        LoadOption(1, 1, "Glare", "Correct! Good Job!")
        LoadOption(1, 1, "Corral", "Wrong! God you wish  you could corral then XD!")
        LoadOption(1, 2, "Glare", "Correct! Good Job!")
        LoadOption(1, 3, "Feral", "Nope! Not the name of the group but yes those buggers really are feral!")
        LoadOption(1, 4, "Clump", "Wrong!.......um..are you ok?")
        ShowQuestion(1) ' debug only

        ' Question 3 (stored in array slot #2) 
        LoadQuestion(2, "What is the name for a group of Aligators?", 3)
        LoadOption(2, 1, "Snap", "Nope! Not the name of the group but the sound they make when they eat you alive!")
        LoadOption(2, 2, "Pack", "Wrong! Generic...")
        LoadOption(2, 3, "Congregation", "Correct! Good Job!")
        LoadOption(2, 4, "Swarm", "Wrong! If they had stingers maybe. Imagine that. *shudders*")
        ShowQuestion(2) ' debug only

        ' Question 4 (stored in array slot #3) 
        LoadQuestion(3, "What is the name for a group of Frogs?", 4)
        LoadOption(3, 1, "Armada", "Wrong!......um..they are preparing for war?")
        LoadOption(3, 2, "Croak", "Wrong! Generic...")
        LoadOption(3, 3, "Ribbit", "Nope! Not the name of the group but the sound they make when they eat you alive!")
        LoadOption(3, 4, "Army", "Correct! Good Job!")
        ShowQuestion(3) ' debug only
    End Sub
End Class
