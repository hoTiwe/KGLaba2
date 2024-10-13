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
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1142, 574);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            // 
            // textBoxScale
            // 
            textBoxScale.Location = new Point(6, 612);
            textBoxScale.Name = "textBoxScale";
            textBoxScale.Size = new Size(100, 27);
            textBoxScale.TabIndex = 1;
            textBoxScale.Text = "15";
            // 
            // buttonSetScale
            // 
            buttonSetScale.Location = new Point(112, 614);
            buttonSetScale.Name = "buttonSetScale";
            buttonSetScale.Size = new Size(112, 25);
            buttonSetScale.TabIndex = 2;
            buttonSetScale.Text = "Изменить";
            buttonSetScale.Click += buttonSetScale_Click;
            // 
            // textBoxOffsetX
            // 
            textBoxOffsetX.Location = new Point(242, 612);
            textBoxOffsetX.Name = "textBoxOffsetX";
            textBoxOffsetX.Size = new Size(100, 27);
            textBoxOffsetX.TabIndex = 3;
            textBoxOffsetX.Text = "20";
            // 
            // textBoxOffsetY
            // 
            textBoxOffsetY.Location = new Point(373, 612);
            textBoxOffsetY.Name = "textBoxOffsetY";
            textBoxOffsetY.Size = new Size(100, 27);
            textBoxOffsetY.TabIndex = 4;
            textBoxOffsetY.Text = "20";
            // 
            // buttonSetOffset
            // 
            buttonSetOffset.Location = new Point(479, 614);
            buttonSetOffset.Name = "buttonSetOffset";
            buttonSetOffset.Size = new Size(202, 25);
            buttonSetOffset.TabIndex = 5;
            buttonSetOffset.Text = "Смещение изображения";
            buttonSetOffset.Click += buttonSetOffset_Click;
            // 
            // labelOffsetX
            // 
            labelOffsetX.Location = new Point(242, 584);
            labelOffsetX.Name = "labelOffsetX";
            labelOffsetX.Size = new Size(125, 25);
            labelOffsetX.TabIndex = 6;
            labelOffsetX.Text = "Смещение по X";
            labelOffsetX.Click += labelOffsetX_Click;
            // 
            // label1
            // 
            label1.Location = new Point(373, 584);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 7;
            label1.Text = "Смещение по Y";
            // 
            // checkBoxNet
            // 
            checkBoxNet.Location = new Point(712, 612);
            checkBoxNet.Name = "checkBoxNet";
            checkBoxNet.Size = new Size(181, 25);
            checkBoxNet.TabIndex = 8;
            checkBoxNet.Text = "Задать сетку растра";
            checkBoxNet.CheckedChanged += checkBoxNetX_CheckedChanged;
            // 
            // label2
            // 
            label2.Location = new Point(6, 579);
            label2.Name = "label2";
            label2.Size = new Size(183, 25);
            label2.TabIndex = 9;
            label2.Text = "Коэффициент масштаба";
            // 
            // label3
            // 
            label3.Location = new Point(858, 579);
            label3.Name = "label3";
            label3.Size = new Size(304, 25);
            label3.TabIndex = 10;
            label3.Text = "Коэффициент контрастности (от -1 до 1)";
            // 
            // button1
            // 
            button1.Location = new Point(1019, 614);
            button1.Name = "button1";
            button1.Size = new Size(125, 25);
            button1.TabIndex = 11;
            button1.Text = "Ввод";
            button1.Click += buttonAdjustContrast_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(899, 610);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 12;
            textBox1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 666);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
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
        private Label label3;
        private Button button1;
        private TextBox textBox1;
    }
}
