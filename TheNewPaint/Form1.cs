using System;
using System.Drawing;
using System.Windows.Forms;
using TheNewPaint.Factories;
using TheNewPaint.Observers;
using TheNewPaint.Command;

namespace TheNewPaint
{
    public partial class Form1 : Form
    {
        public IDrawingObserver _observer;
        public IDrawingTool _currentTool;
        public Color _currentColor;
        public int _currentThickness;
        public Point _startPoint;
        public bool _isDrawing;

        public Form1()
        {
            InitializeComponent();
            InitializeDrawing();
        }

        public void InitializeDrawing()
        {
            // Initialize drawing observer with status strip
            _observer = new DrawingObserver(statusStrip1);

            // Set initial values for color, tool, and thickness
            _currentColor = Color.Black; // Default color
            colorPanel.BackColor = _currentColor;
            _currentTool = DrawingToolFactory.CreateDrawingTool(DrawingToolFactory.ToolType.Pen); // Default tool
            _currentThickness = colorThickness.Value; // Default thickness

            // Subscribe the observer to color, tool, and thickness changes
            chooseColorBtn.Click += chooseColorBtn_Click;
            penBtn.Click += penBtn_Click;
            brushBtn.Click += brushBtn_Click;
            eraserBtn.Click += eraserBtn_Click;
            colorThickness.Scroll += colorThickness_Scroll;
            clearBtn.Click += clearBtn_Click;

            // Subscribe mouse events
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }

        public void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDrawing = true;
            _startPoint = e.Location;
        }
        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                Point endPoint = e.Location;

                // Draw the current segment using the current drawing tool on the PictureBox
                using (Graphics graphics = pictureBox1.CreateGraphics())
                {
                    _currentTool.Draw(_startPoint, endPoint, graphics, _currentColor, _currentThickness);
                }

                // Update start point for next segment
                _startPoint = endPoint;
            }
        }



        public void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        public void chooseColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _currentColor = colorDialog.Color;
                colorPanel.BackColor = _currentColor; // Set the color of the color panel
                _observer.UpdateColor(_currentColor);

                // Execute the ChangeColorCommand
                ICommand command = new ChangeColorCommand(_currentColor, _observer);
                command.Execute();
            }
        }

        public void penBtn_Click(object sender, EventArgs e)
        {
            _currentTool = DrawingToolFactory.CreateDrawingTool(DrawingToolFactory.ToolType.Pen);
            _observer.UpdateTool(_currentTool);

            // Execute the ChangeToolCommand
            ICommand command = new ChangeToolCommand(_currentTool, _observer);
            command.Execute();
        }

        public void brushBtn_Click(object sender, EventArgs e)
        {
            _currentTool = DrawingToolFactory.CreateDrawingTool(DrawingToolFactory.ToolType.Brush);
            _observer.UpdateTool(_currentTool);

            // Execute the ChangeToolCommand
            ICommand command = new ChangeToolCommand(_currentTool, _observer);
            command.Execute();
        }

        public void eraserBtn_Click(object sender, EventArgs e)
        {
            _currentTool = DrawingToolFactory.CreateDrawingTool(DrawingToolFactory.ToolType.Eraser);
            _observer.UpdateTool(_currentTool);

            // Execute the ChangeToolCommand
            ICommand command = new ChangeToolCommand(_currentTool, _observer);
            command.Execute();
        }

        public void colorThickness_Scroll(object sender, EventArgs e)
        {
            _currentThickness = colorThickness.Value;
            _observer.UpdateThickness(_currentThickness);

            // Execute the ChangeThicknessCommand
            ICommand command = new ChangeThicknessCommand(_currentThickness, _observer);
            command.Execute();
        }

        public void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear the drawing area
            pictureBox1.Refresh();
        }
    }
}
