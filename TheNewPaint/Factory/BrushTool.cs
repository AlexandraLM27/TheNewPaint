using System.Drawing;

namespace TheNewPaint
{
    public class BrushTool : IDrawingTool
    {
        public void Draw(Point startPoint, Point endPoint, Graphics graphics, Color color, int thickness)
        {
            using (var brush = new SolidBrush(color))
            {
                graphics.FillRectangle(brush, endPoint.X, endPoint.Y, thickness+3, thickness+3);
            }
        }
    }
}
