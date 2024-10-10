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
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
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
            // button1
            // 
            button1.Location = new Point(208, 536);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 10;
            button1.Text = "Изменить цвет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += changeColorForPixel;
            // 
            // label3
            // 
            label3.Location = new Point(124, 464);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 14;
            label3.Text = "Y";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 485);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 23);
            textBox1.TabIndex = 11;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 485);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 23);
            textBox2.TabIndex = 12;
            textBox2.Text = "0";
            // 
            // label4
            // 
            label4.Location = new Point(12, 464);
            label4.Name = "label4";
            label4.Size = new Size(109, 19);
            label4.TabIndex = 13;
            label4.Text = "X";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(239, 464);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 15);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += onColorClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(260, 464);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(15, 15);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += onColorClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(281, 464);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(15, 15);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            pictureBox4.Click += onColorClick;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(302, 464);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(15, 15);
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            pictureBox5.Click += onColorClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(323, 464);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(15, 15);
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            pictureBox6.Click += onColorClick;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(239, 485);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(15, 15);
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            pictureBox7.Click += onColorClick;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(281, 485);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(15, 15);
            pictureBox9.TabIndex = 21;
            pictureBox9.TabStop = false;
            pictureBox9.Click += onColorClick;
            // 
            // pictureBox10
            // 
            pictureBox10.Location = new Point(302, 485);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(15, 15);
            pictureBox10.TabIndex = 22;
            pictureBox10.TabStop = false;
            pictureBox10.Click += onColorClick;
            // 
            // pictureBox11
            // 
            pictureBox11.Location = new Point(323, 485);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(15, 15);
            pictureBox11.TabIndex = 23;
            pictureBox11.TabStop = false;
            pictureBox11.Click += onColorClick;
            // 
            // pictureBox12
            // 
            pictureBox12.Location = new Point(239, 506);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(15, 15);
            pictureBox12.TabIndex = 24;
            pictureBox12.TabStop = false;
            pictureBox12.Click += onColorClick;
            // 
            // pictureBox13
            // 
            pictureBox13.Location = new Point(260, 506);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(15, 15);
            pictureBox13.TabIndex = 29;
            pictureBox13.TabStop = false;
            pictureBox13.Click += onColorClick;
            // 
            // pictureBox14
            // 
            pictureBox14.Location = new Point(281, 506);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(15, 15);
            pictureBox14.TabIndex = 28;
            pictureBox14.TabStop = false;
            pictureBox14.Click += onColorClick;
            // 
            // pictureBox15
            // 
            pictureBox15.Location = new Point(302, 506);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(15, 15);
            pictureBox15.TabIndex = 27;
            pictureBox15.TabStop = false;
            pictureBox15.Click += onColorClick;
            // 
            // pictureBox16
            // 
            pictureBox16.Location = new Point(323, 506);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(15, 15);
            pictureBox16.TabIndex = 26;
            pictureBox16.TabStop = false;
            pictureBox16.Click += onColorClick;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(260, 485);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(15, 15);
            pictureBox8.TabIndex = 30;
            pictureBox8.TabStop = false;
            pictureBox8.Click += onColorClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 571);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox15);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
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
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox8;
    }
}
