Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim x As Integer = 80
        Dim y As Integer = 10
        Dim w As Integer = 300
        Dim h As Integer = 200
        Dim c As Integer = 0
        Dim g As Graphics = e.Graphics

        Dim myPen As New Pen(Color.Blue, 10)

        For x = 0 To 6 Step 1
            Select Case c
                Case 0
                    g.FillRectangle(Brushes.Blue, x, y, w, h)
                Case 1
                    g.FillRectangle(Brushes.Red, x, y, w, h)
                Case 2
                    g.FillRectangle(Brushes.Yellow, x, y, w, h)
                Case 3
                    g.FillRectangle(Brushes.Green, x, y, w, h)
                Case 4
                    g.FillRectangle(Brushes.Violet, x, y, w, h)
                Case 5
                    g.FillRectangle(Brushes.Brown, x, y, w, h)
            End Select
            x = x + 5
            y = y + 5
            w = w - 10
            h = h - 10
            c = c + 1
        Next
    End Sub
End Class
