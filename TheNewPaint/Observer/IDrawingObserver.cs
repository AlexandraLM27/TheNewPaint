using System.Drawing;

namespace TheNewPaint.Observers
{
    public interface IDrawingObserver
    {
        void UpdateColor(Color color);
        void UpdateTool(IDrawingTool tool);
        void UpdateThickness(int thickness);
    }
}
