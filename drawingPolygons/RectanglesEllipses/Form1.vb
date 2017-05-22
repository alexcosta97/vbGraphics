Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim x As Integer = 80
        Dim y As Integer = 10
        Dim w As Integer = 300
        Dim h As Integer = 200
        Dim g As Graphics = e.Graphics

        Dim myPen As New Pen(Color.Blue, 10)

        g.DrawRectangle(myPen, x, y, w, h)
        g.FillRectangle(Brushes.Red, x, y, w, h)
        g.FillEllipse(Brushes.Yellow, x, y, w, h)
    End Sub
End Class
