using System.Drawing;

namespace TheNewPaint
{
    public class PenTool : IDrawingTool
    {
        public void Draw(Point startPoint, Point endPoint, Graphics graphics, Color color, int thickness)
        {
            using (var pen = new Pen(color))
            {
                graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, thickness+2 , thickness+2);
            }
        }
    }
}
