Public Class Form1
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        Dim myPen As New Pen(Color.Red)

        Dim side As Integer = 25  '' the length of the side of a hex

        Dim ShortSide As Single = Convert.ToSingle(System.Math.Sin(30 * System.Math.PI / 180) * side)
        Dim LongSide As Single = Convert.ToSingle(System.Math.Cos(30 * System.Math.PI / 180) * side)

        Dim shape(5) As PointF
        shape(0) = (New Point(100, 100))
        shape(1) = (New Point(100 + side, 100))
        shape(2) = (New Point(100 + side + ShortSide, 100 + LongSide))
        shape(3) = (New Point(100 + side, 100 + LongSide + LongSide))
        shape(4) = (New Point(100, 100 + LongSide + LongSide))
        shape(5) = (New Point(100 - ShortSide, 100 + LongSide))
        g.DrawPolygon(myPen, shape)
        g.FillPolygon(Brushes.Red, shape)

        Dim myFont As New Font("Arial", 14, FontStyle.Regular)
        Dim myBrush As Brush = Brushes.Aqua

        g.DrawString("Sam", myFont, myBrush, New Point(100, 150`))

        BackColor = Color.Yellow

    End Sub
End Class
