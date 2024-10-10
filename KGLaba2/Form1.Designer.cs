using System.Windows.Forms.VisualStyles;

namespace KGLaba2
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
            pictureBox1 = new PictureBox();
            textBoxScale = new TextBox();
            buttonSetScale = new Button();
            textBoxOffsetX = new TextBox();
            textBoxOffsetY = new TextBox();
            buttonSetOffset = new Button();
            labelOffsetX = new Label();
            label1 = new Label();
            checkBoxNet = new CheckBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(912, 519);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            // 
            // textBoxScale
            // 
            textBoxScale.Location = new Point(2, 557);
            textBoxScale.Name = "textBoxScale";
            textBoxScale.Size = new Size(100, 27);
            textBoxScale.TabIndex = 1;
            textBoxScale.Text = "15";
            // 
            // buttonSetScale
            // 
            buttonSetScale.Location = new Point(108, 559);
            buttonSetScale.Name = "buttonSetScale";
            buttonSetScale.Size = new Size(112, 25);
            buttonSetScale.TabIndex = 2;
            buttonSetScale.Text = "Изменить";
            buttonSetScale.Click += buttonSetScale_Click;
            // 
            // textBoxOffsetX
            // 
            textBoxOffsetX.Location = new Point(238, 557);
            textBoxOffsetX.Name = "textBoxOffsetX";
            textBoxOffsetX.Size = new Size(100, 27);
            textBoxOffsetX.TabIndex = 3;
            textBoxOffsetX.Text = "20";
            // 
            // textBoxOffsetY
            // 
            textBoxOffsetY.Location = new Point(369, 557);
            textBoxOffsetY.Name = "textBoxOffsetY";
            textBoxOffsetY.Size = new Size(100, 27);
            textBoxOffsetY.TabIndex = 4;
            textBoxOffsetY.Text = "20";
            // 
            // buttonSetOffset
            // 
            buttonSetOffset.Location = new Point(475, 559);
            buttonSetOffset.Name = "buttonSetOffset";
            buttonSetOffset.Size = new Size(202, 25);
            buttonSetOffset.TabIndex = 5;
            buttonSetOffset.Text = "Смещение изображения";
            buttonSetOffset.Click += buttonSetOffset_Click;
            // 
            // labelOffsetX
            // 
            labelOffsetX.Location = new Point(238, 529);
            labelOffsetX.Name = "labelOffsetX";
            labelOffsetX.Size = new Size(125, 25);
            labelOffsetX.TabIndex = 6;
            labelOffsetX.Text = "Смещение по X";
            labelOffsetX.Click += labelOffsetX_Click;
            // 
            // label1
            // 
            label1.Location = new Point(369, 529);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 7;
            label1.Text = "Смещение по Y";
            // 
            // checkBoxNet
            // 
            checkBoxNet.Location = new Point(708, 557);
            checkBoxNet.Name = "checkBoxNet";
            checkBoxNet.Size = new Size(181, 25);
            checkBoxNet.TabIndex = 8;
            checkBoxNet.Text = "Задать сетку растра";
            checkBoxNet.CheckedChanged += checkBoxNetX_CheckedChanged;
            // 
            // label2
            // 
            label2.Location = new Point(2, 524);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 9;
            label2.Text = "Коэффициент масштаба";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 638);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxScale);
            Controls.Add(buttonSetScale);
            Controls.Add(textBoxOffsetX);
            Controls.Add(textBoxOffsetY);
            Controls.Add(buttonSetOffset);
            Controls.Add(labelOffsetX);
            Controls.Add(checkBoxNet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonSetScale;
        private TextBox textBoxScale;
        private TextBox textBoxOffsetX;
        private TextBox textBoxOffsetY;
        private Button buttonSetOffset;
        private Label labelOffsetX;
        private Label label1;
        private CheckBox checkBoxNet;
        private Label label2;
    }
}
