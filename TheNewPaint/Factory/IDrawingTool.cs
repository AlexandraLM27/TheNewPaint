using System.Drawing;

namespace TheNewPaint
{
    public interface IDrawingTool
    {
        void Draw(Point startPoint, Point endPoint, Graphics graphics, Color color, int thickness);
    }
}
