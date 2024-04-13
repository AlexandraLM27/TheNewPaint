using System;

namespace TheNewPaint.Factories
{
    public class DrawingToolFactory
    {
        public enum ToolType
        {
            Pen,
            Brush,
            Eraser
        }

        public static IDrawingTool CreateDrawingTool(ToolType toolType)
        {
            switch (toolType)
            {
                case ToolType.Pen:
                    return new PenTool();
                case ToolType.Brush:
                    return new BrushTool();
                case ToolType.Eraser:
                    return new EraserTool();
                default:
                    throw new ArgumentException("Invalid tool type.");
            }
        }
    }
}
