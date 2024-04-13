using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNewPaint.Observers;

namespace TheNewPaint.Command
{
    public class ChangeColorCommand : ICommand
    {
        private readonly Color _newColor;
        private readonly IDrawingObserver _observer;

        public ChangeColorCommand(Color newColor, IDrawingObserver observer)
        {
            _newColor = newColor;
            _observer = observer;
        }

        public void Execute()
        {
            _observer.UpdateColor(_newColor);
        }
    }

    public class ChangeToolCommand : ICommand
    {
        private readonly IDrawingTool _newTool;
        private readonly IDrawingObserver _observer;

        public ChangeToolCommand(IDrawingTool newTool, IDrawingObserver observer)
        {
            _newTool = newTool;
            _observer = observer;
        }

        public void Execute()
        {
            _observer.UpdateTool(_newTool);
        }
    }

    public class ChangeThicknessCommand : ICommand
    {
        private readonly int _newThickness;
        private readonly IDrawingObserver _observer;

        public ChangeThicknessCommand(int newThickness, IDrawingObserver observer)
        {
            _newThickness = newThickness;
            _observer = observer;
        }

        public void Execute()
        {
            _observer.UpdateThickness(_newThickness);
        }
    }
}
