Public Class Form1
    Dim rand As New Random
    Dim x As Integer = 200
    Dim y As Integer = 50
    Dim xBall2 As Integer = 0
    Dim yBall2 As Integer = 0
    Dim xmove As Integer = 10
    Dim ymove As Integer = 10
    Dim x2move As Integer = 10
    Dim y2move As Integer = 10
    Dim size As Integer = 30
    Dim time As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = rand.Next(300) + 27
        y = rand.Next(200) + 12
        xBall2 = rand.Next(300) + 27
        yBall2 = rand.Next(200) + 12
    End Sub

    Private Sub pbxDisplay_Paint(sender As Object, e As PaintEventArgs) Handles pbxDisplay.Paint
        Dim g As Graphics = e.Graphics
        g.FillEllipse(Brushes.Red, x, y, size, size)
        g.FillEllipse(Brushes.Red, xBall2, yBall2, size, size)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''Verifies movement against the walls after the new position is set to the draw
        x += xmove
        y += ymove
        If (y + size >= pbxDisplay.Height) Then
            ymove = -ymove
        ElseIf (x + size >= pbxDisplay.Width) Then
            xmove = -xmove
        ElseIf (x + (size - 10) <= pbxDisplay.Location.X) Then
            xmove = -xmove
        ElseIf (y + (size - 15) <= pbxDisplay.Location.Y) Then
            ymove = -ymove
        End If
        Refresh()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ''Verifies movement against the walls after the new position is set to the draw
        xBall2 += x2move
        yBall2 += y2move
        If (yBall2 + size >= pbxDisplay.Height) Then
            y2move = -y2move
        ElseIf (xBall2 + size >= pbxDisplay.Width) Then
            x2move = -x2move
        ElseIf (xBall2 + (size - 10) <= pbxDisplay.Location.X) Then
            x2move = -x2move
        ElseIf (yBall2 + (size - 15) <= pbxDisplay.Location.Y) Then
            y2move = -y2move
        End If

        ''checks if the balls are going against each other or not
        If (calcDist((x - xBall2), (y - yBall2)) <= size + 3) Then
            x2move = -x2move
            y2move = -y2move
            xmove = -xmove
            ymove = -ymove
        End If

        Refresh()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If (keyData = Keys.Up) Then
            size += 5
            Refresh()
            Return True
        ElseIf (keyData = Keys.Down) Then
            size -= 5
            Refresh()
            Return True
        ElseIf (keyData.ToString() = "C") Then
            time += 1
            If (time > 10) Then
                time = 0
            End If
            Select Case time
                Case 0
                    pbxDisplay.BackColor = Color.Aqua
                Case 1
                    pbxDisplay.BackColor = Color.Yellow
                Case 2
                    pbxDisplay.BackColor = Color.Violet
                Case 3
                    pbxDisplay.BackColor = Color.Blue
                Case 4
                    pbxDisplay.BackColor = Color.Green
                Case 5
                    pbxDisplay.BackColor = Color.Gold
                Case 6
                    pbxDisplay.BackColor = Color.Gray
                Case 7
                    pbxDisplay.BackColor = Color.Ivory
                Case 8
                    pbxDisplay.BackColor = Color.LemonChiffon
                Case 9
                    pbxDisplay.BackColor = Color.Chocolate
                Case 10
                    pbxDisplay.BackColor = Color.SlateBlue
            End Select
            Return True
        End If
    End Function

    Private Function calcDist(a As Integer, b As Integer) As Double
        Return Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)))
    End Function


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
