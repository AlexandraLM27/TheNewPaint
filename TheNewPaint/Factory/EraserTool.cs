using System.Drawing;

namespace TheNewPaint
{
    public class EraserTool : IDrawingTool
    {
        public void Draw(Point startPoint, Point endPoint, Graphics graphics, Color color, int thickness)
        {
            // Implement eraser drawing logic here
            using (var eraser = new SolidBrush(Color.White)) // Assuming eraser is white
            {
                graphics.FillRectangle(eraser, endPoint.X, endPoint.Y, thickness+3, thickness+3);
            }
        }
    }
}
