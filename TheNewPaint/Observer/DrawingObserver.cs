// DrawingObserver.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheNewPaint.Observers
{
    public class DrawingObserver : IDrawingObserver
    {
        private readonly StatusStrip _statusStrip;

        public DrawingObserver(StatusStrip statusStrip)
        {
            _statusStrip = statusStrip;
        }


        public void UpdateColor(Color color)
        {
            UpdateStatus($"Color updated: {color}");
        }

        public void UpdateTool(IDrawingTool tool)
        {
            UpdateStatus($"Tool updated: {tool.GetType().Name}");
        }

        public void UpdateThickness(int thickness)
        {
            UpdateStatus($"Thickness updated: {thickness}");
        }

        private void UpdateStatus(string message)
        {
            _statusStrip.Items.Clear(); 
            _statusStrip.Items.Add(message); 
        }
    }
}
