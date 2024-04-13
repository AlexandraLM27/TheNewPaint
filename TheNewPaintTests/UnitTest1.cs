using System.Drawing;
using System.Windows.Forms;
using TheNewPaint.Factories;
using TheNewPaint.Observers;
using TheNewPaint.Command;
using Xunit;

namespace TheNewPaint.Tests
{
    public class Form1Tests
    {
        private readonly Form1 _form;

        public Form1Tests()
        {
            _form = new Form1();
        }
        [Fact]
        public void SelectTool_PenTool_ReturnsCorrectTool()
        {
            // Arrange


            // Act
            IDrawingTool selectedTool = DrawingToolFactory.CreateDrawingTool(DrawingToolFactory.ToolType.Pen);

            // Assert
            Assert.IsType<PenTool>(selectedTool);
        }
        [Fact]
        public void InitializeDrawing_InitialValuesAreSetCorrectly()
        {
            // Arrange

            // Act
            _form.InitializeDrawing();

            // Assert
            Assert.Equal(Color.Black, _form._currentColor);
            Assert.NotNull(_form._currentTool);
            Assert.Equal(0, _form._currentThickness);
            Assert.NotNull(_form._observer);
        }

        [Fact]
        public void DrawingObserver_UpdateColor_StatusStripUpdatedWithColor()
        {
            // Arrange
            var statusStrip = new StatusStrip();
            var observer = new DrawingObserver(statusStrip);
            var color = Color.Blue;

            // Act
            observer.UpdateColor(color);

            // Assert
            Assert.Single(statusStrip.Items);
            Assert.Equal($"Color updated: {color}", statusStrip.Items[0].Text);
        }
    }
}
