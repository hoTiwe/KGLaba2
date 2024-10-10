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
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 389);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += PictureBox1_Paint;
            // 
            // textBoxScale
            // 
            textBoxScale.Location = new Point(2, 418);
            textBoxScale.Margin = new Padding(3, 2, 3, 2);
            textBoxScale.Name = "textBoxScale";
            textBoxScale.Size = new Size(88, 23);
            textBoxScale.TabIndex = 1;
            textBoxScale.Text = "15";
            // 
            // buttonSetScale
            // 
            buttonSetScale.Location = new Point(94, 419);
            buttonSetScale.Margin = new Padding(3, 2, 3, 2);
            buttonSetScale.Name = "buttonSetScale";
            buttonSetScale.Size = new Size(98, 22);
            buttonSetScale.TabIndex = 2;
            buttonSetScale.Text = "Изменить";
            buttonSetScale.Click += buttonSetScale_Click;
            // 
            // textBoxOffsetX
            // 
            textBoxOffsetX.Location = new Point(208, 418);
            textBoxOffsetX.Margin = new Padding(3, 2, 3, 2);
            textBoxOffsetX.Name = "textBoxOffsetX";
            textBoxOffsetX.Size = new Size(88, 23);
            textBoxOffsetX.TabIndex = 3;
            textBoxOffsetX.Text = "20";
            // 
            // textBoxOffsetY
            // 
            textBoxOffsetY.Location = new Point(323, 418);
            textBoxOffsetY.Margin = new Padding(3, 2, 3, 2);
            textBoxOffsetY.Name = "textBoxOffsetY";
            textBoxOffsetY.Size = new Size(88, 23);
            textBoxOffsetY.TabIndex = 4;
            textBoxOffsetY.Text = "20";
            // 
            // buttonSetOffset
            // 
            buttonSetOffset.Location = new Point(416, 419);
            buttonSetOffset.Margin = new Padding(3, 2, 3, 2);
            buttonSetOffset.Name = "buttonSetOffset";
            buttonSetOffset.Size = new Size(177, 22);
            buttonSetOffset.TabIndex = 5;
            buttonSetOffset.Text = "Смещение изображения";
            buttonSetOffset.Click += buttonSetOffset_Click;
            // 
            // labelOffsetX
            // 
            labelOffsetX.Location = new Point(208, 397);
            labelOffsetX.Name = "labelOffsetX";
            labelOffsetX.Size = new Size(109, 19);
            labelOffsetX.TabIndex = 6;
            labelOffsetX.Text = "Смещение по X";
            // 
            // label1
            // 
            label1.Location = new Point(323, 397);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 7;
            label1.Text = "Смещение по Y";
            // 
            // checkBoxNet
            // 
            checkBoxNet.Location = new Point(620, 418);
            checkBoxNet.Margin = new Padding(3, 2, 3, 2);
            checkBoxNet.Name = "checkBoxNet";
            checkBoxNet.Size = new Size(158, 19);
            checkBoxNet.TabIndex = 8;
            checkBoxNet.Text = "Задать сетку растра";
            checkBoxNet.CheckedChanged += checkBoxNetX_CheckedChanged;
            // 
            // label2
            // 
            label2.Location = new Point(2, 393);
            label2.Name = "label2";
            label2.Size = new Size(160, 19);
            label2.TabIndex = 9;
            label2.Text = "Коэффициент масштаба";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 487);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(126, 487);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 2;
            button1.Text = "Масштабировать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1;
    }
}
