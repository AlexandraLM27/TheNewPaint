using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TheNewPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            eraserBtn = new Button();
            brushBtn = new Button();
            penBtn = new Button();
            colorThickness = new TrackBar();
            label1 = new Label();
            clearBtn = new Button();
            colorDialog = new ColorDialog();
            chooseColorBtn = new Button();
            colorPanel = new Panel();
            statusStrip1 = new StatusStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)colorThickness).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Location = new Point(32, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(734, 339);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(eraserBtn);
            groupBox1.Controls.Add(brushBtn);
            groupBox1.Controls.Add(penBtn);
            groupBox1.Location = new Point(110, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 55);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tools";
            // 
            // eraserBtn
            // 
            eraserBtn.Anchor = AnchorStyles.Top;
            eraserBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("eraserBtn.BackgroundImage");
            eraserBtn.BackgroundImageLayout = ImageLayout.Zoom;
            eraserBtn.Cursor = Cursors.Hand;
            eraserBtn.Location = new Point(163, 22);
            eraserBtn.Name = "eraserBtn";
            eraserBtn.Size = new Size(37, 27);
            eraserBtn.TabIndex = 2;
            eraserBtn.UseVisualStyleBackColor = true;
            eraserBtn.Click += eraserBtn_Click;
            // 
            // brushBtn
            // 
            brushBtn.Anchor = AnchorStyles.Top;
            brushBtn.BackColor = SystemColors.Control;
            brushBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("brushBtn.BackgroundImage");
            brushBtn.BackgroundImageLayout = ImageLayout.Zoom;
            brushBtn.Cursor = Cursors.Hand;
            brushBtn.Location = new Point(98, 22);
            brushBtn.Name = "brushBtn";
            brushBtn.Size = new Size(37, 27);
            brushBtn.TabIndex = 1;
            brushBtn.UseVisualStyleBackColor = false;
            brushBtn.Click += brushBtn_Click;
            // 
            // penBtn
            // 
            penBtn.Anchor = AnchorStyles.Top;
            penBtn.BackColor = SystemColors.Control;
            penBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("penBtn.BackgroundImage");
            penBtn.BackgroundImageLayout = ImageLayout.Stretch;
            penBtn.Cursor = Cursors.Hand;
            penBtn.Location = new Point(33, 22);
            penBtn.Name = "penBtn";
            penBtn.Size = new Size(37, 27);
            penBtn.TabIndex = 0;
            penBtn.UseVisualStyleBackColor = false;
            penBtn.Click += penBtn_Click;
            // 
            // colorThickness
            // 
            colorThickness.Anchor = AnchorStyles.Top;
            colorThickness.Location = new Point(438, 21);
            colorThickness.Name = "colorThickness";
            colorThickness.Size = new Size(186, 45);
            colorThickness.TabIndex = 2;
            colorThickness.Scroll += colorThickness_Scroll;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(360, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Thickness";
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearBtn.Location = new Point(49, 415);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // chooseColorBtn
            // 
            chooseColorBtn.Location = new Point(9, 7);
            chooseColorBtn.Name = "chooseColorBtn";
            chooseColorBtn.Size = new Size(84, 22);
            chooseColorBtn.TabIndex = 8;
            chooseColorBtn.Text = "Select color";
            chooseColorBtn.UseVisualStyleBackColor = true;
            chooseColorBtn.Click += chooseColorBtn_Click;
            // 
            // colorPanel
            // 
            colorPanel.Location = new Point(21, 35);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(61, 20);
            colorPanel.TabIndex = 10;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 457);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(810, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 479);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(colorPanel);
            Controls.Add(chooseColorBtn);
            Controls.Add(clearBtn);
            Controls.Add(label1);
            Controls.Add(colorThickness);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "DrawingApp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)colorThickness).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TrackBar colorThickness;
        private Label label1;
        private Button clearBtn;
        private ColorDialog colorDialog;
        private Button chooseColorBtn;
        private Panel colorPanel;
        private Button eraserBtn;
        private Button brushBtn;
        private Button penBtn;
        private StatusStrip statusStrip1;
    }
}