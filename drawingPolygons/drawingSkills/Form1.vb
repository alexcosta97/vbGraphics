Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Me.BackColor = Color.Blue

        Dim point1 As Point = New Point(65, 140)
        Dim point2 As Point = New Point(115, 140)
        Dim point3 As Point = New Point(90, 110)
        Dim point4 As PointF = New PointF(115.0F, 110.0F)
        Dim point5 As PointF = New PointF(110.0F, 110.0F)
        Dim point6 As PointF = New PointF(110.0F, 137.2363F)

        Dim curvePoints(2) As Point
        curvePoints(0) = point1
        curvePoints(1) = point2
        curvePoints(2) = point3

        Dim chimneyPoints(3) As PointF
        chimneyPoints(0) = point2
        chimneyPoints(1) = point4
        chimneyPoints(2) = point5
        chimneyPoints(3) = point6

        Dim myPen As Pen = New Pen(Color.Brown)

        g.DrawRectangle(myPen, 65, 140, 50, 60)
        g.FillRectangle(Brushes.Beige, 65, 140, 50, 60)
        g.FillRectangle(Brushes.Brown, 85, 180, 10, 20)
        g.FillRectangle(Brushes.Blue, 74, 160, 6, 6)
        g.FillRectangle(Brushes.Blue, 104, 160, 6, 6)
        g.FillPolygon(Brushes.Red, curvePoints)
        g.FillPolygon(Brushes.LightGray, chimneyPoints)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Refresh()
    End Sub

End Class
