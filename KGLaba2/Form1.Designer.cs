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
            textBoxScale = new TextBox(); // Инициализация TextBox
            buttonSetScale = new Button(); // Инициализация Button

            textBoxOffsetX = new TextBox();
            textBoxOffsetY = new TextBox();
            buttonSetOffset = new Button(); // Инициализация Button

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
            textBoxScale.Location = new Point(10, 530); // Позиция TextBox
            textBoxScale.Name = "textBoxScale";
            textBoxScale.Size = new Size(100, 25);
            textBoxScale.Text = "15"; // Значение по умолчанию

            // 
            // buttonSetScale
            // 
            buttonSetScale.Location = new Point(120, 530); // Позиция кнопки
            buttonSetScale.Name = "buttonSetScale";
            buttonSetScale.Size = new Size(75, 25);
            buttonSetScale.Text = "Set Scale";
            buttonSetScale.Click += new EventHandler(buttonSetScale_Click); // Обработчик события
            // 
            // textBoxOffsetX
            // 
            textBoxOffsetX.Location = new Point(10, 580); // Позиция TextBox
            textBoxOffsetX.Name = "textBoxOffsetX";
            textBoxOffsetX.Size = new Size(100, 25);
            textBoxOffsetX.Text = "20"; // Значение по умолчанию
            // 
            // textBoxOffsetX
            // 
            textBoxOffsetY.Location = new Point(120, 580); // Позиция TextBox
            textBoxOffsetY.Name = "textBoxOffsetY";
            textBoxOffsetY.Size = new Size(100, 25);
            textBoxOffsetY.Text = "20"; // Значение по умолчанию
            // 
            // buttonSetOffset
            // 
            buttonSetOffset.Location = new Point(220, 580); // Позиция кнопки
            buttonSetOffset.Name = "buttonSetOffset";
            buttonSetOffset.Size = new Size(75, 25);
            buttonSetOffset.Text = "Смещение";
            buttonSetOffset.Click += new EventHandler(buttonSetOffset_Click); // Обработчик события


            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 638);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxScale); // Добавляем TextBox на форму
            Controls.Add(buttonSetScale); // Добавляем кнопку на форму
            Controls.Add(textBoxOffsetX);
            Controls.Add(textBoxOffsetY);
            Controls.Add(buttonSetOffset);
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
    }
}
