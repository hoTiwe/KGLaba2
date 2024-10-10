using System.Drawing;
using System.IO;
using System.IO.Pipes;

namespace KGLaba2
{
    public partial class Form1 : Form
    {
        int pictureWidth = 0;
        int pictureHeight = 0;
        int bitCount = 0;
        int paletteCount = 0;

        byte[] palette;
        byte[] pixels;
        int[] pixelValues;
        Pixel[] outputPixels;
        PictureBox[] pictureBoxs = new PictureBox[15];
        int currentValuePixel = 0;

        Graphics graphics;
        string filePath = @"../../../new_picker_1.glhfnewnew";

        // Добавляем поля для смещений
        int offsetX = 20; // Смещение по горизонтали
        int offsetY = 20; // Смещение по вертикали
        int scale = 15;
        int coeffNet = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBoxs = [ pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16];
            ReadPicture();
            parsePixels();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Получаем объект Graphics
            graphics = e.Graphics;
            int netX = 0, netY = 0;
            for (int i = 0; i < pictureHeight * pictureWidth; i++)
            {
                // Учет смещения при выводе
                int x = outputPixels[i].x * scale + offsetX;
                int y = outputPixels[i].y * scale + offsetY;

                Console.WriteLine($"x: {outputPixels[i].x}; y: {outputPixels[i].y} color: {outputPixels[i].color};");
                Console.WriteLine($"x: {outputPixels[i].x}; y: {outputPixels[i].x} color: {outputPixels[i].color};");
                netX = i % pictureWidth * coeffNet;
                netY = i / pictureWidth * coeffNet;
                //с сеткой
                graphics.FillRectangle(new SolidBrush(outputPixels[i].color), x + netX, y + netY, scale, scale);
                // без сетки
                //graphics.FillRectangle(new SolidBrush(outputPixels[i].color), x, y, scale, scale);
            }
        }

        private void buttonSetScale_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxScale.Text, out int newScale))
            {
                scale = newScale; // Устанавливаем новое значение масштаба
                pictureBox1.Invalidate(); // Перерисовываем PictureBox
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for scale."); // Сообщение об ошибке
            }
        }

        private void buttonSetOffset_Click(object sender, EventArgs e)
        {
            // Попытка преобразовать текст из TextBox в целые числа
            if (int.TryParse(textBoxOffsetX.Text, out int newOffsetX) &&
                int.TryParse(textBoxOffsetY.Text, out int newOffsetY))
            {
                // Установка новых значений смещения
                offsetX = newOffsetX;
                offsetY = newOffsetY;

                // Перерисовка PictureBox для применения новых смещений
                pictureBox1.Invalidate();
            }
            else
            {
                // Если преобразование не удалось, выводим сообщение об ошибке
                MessageBox.Show("Please enter valid integers for offsets.");
            }
        }

        private void checkBoxNetX_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNet.Checked)
            {
                coeffNet = 3;
                Console.WriteLine("Сетка включена");
                pictureBox1.Invalidate();
            }
            else
            {
                coeffNet = 0;
                Console.WriteLine("Сетка off");
                pictureBox1.Invalidate();
            }
        }


        public void ReadPicture()
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[2];
                buffer[0] = (byte)fileStream.ReadByte();
                buffer[1] = (byte)fileStream.ReadByte();
                pictureWidth = (buffer[0] << 8) | buffer[1];

                buffer[0] = (byte)fileStream.ReadByte();
                buffer[1] = (byte)fileStream.ReadByte();
                pictureHeight = (buffer[0] << 8) | buffer[1];

                bitCount = fileStream.ReadByte();

                buffer[0] = (byte)fileStream.ReadByte();
                buffer[1] = (byte)fileStream.ReadByte();
                paletteCount = (buffer[0] << 8) | buffer[1];

                Console.WriteLine($"Width: {pictureWidth}; Width: {pictureHeight};");
                Console.WriteLine($"bit count: {bitCount}; palette count: {paletteCount};");
                palette = new byte[4 * paletteCount];

                for (int i = 0; i < 4 * paletteCount; i++)
                {
                    palette[i] = (byte)fileStream.ReadByte();
                    
                    if ((i + 1) % 4 == 0)
                    {
                        pictureBoxs[i / 4].BackColor = Color.FromArgb(palette[i-3], palette[i-2], palette[i-1], palette[i]);
                    }
                }

                int countPixelByte = (int)Math.Ceiling((double)pictureWidth * pictureHeight * bitCount / 8);
                Console.WriteLine($"countPixelByte: {countPixelByte}");
                pixels = new byte[countPixelByte];
                for (int i = 0; i < countPixelByte; i++)
                {
                    pixels[i] = (byte)fileStream.ReadByte();
                    Console.WriteLine($"Pixel {i + 1}: {pixels[i]}");
                }
            }
        }

        public void parsePixels()
        {
            outputPixels = new Pixel[pictureWidth * pictureHeight];
            pixelValues = new int[pictureWidth * pictureHeight];

            int countPixelByte = (int)Math.Ceiling((double)pictureWidth * pictureHeight * bitCount / 8);
            int startPosition = 0;
            int bitsTotal = bitCount * pictureWidth * pictureHeight;

            while (startPosition + bitCount <= bitsTotal)
            {
                int value = 0;

                for (int i = 0; i < 5; i++)
                {
                    int byteIndex = (startPosition + i) / 8;
                    int bitIndex = 7 - ((startPosition + i) % 8);

                    // Получаем значение текущего бита
                    int bit = (pixels[byteIndex] >> bitIndex) & 1;

                    // Сдвигаем бит на нужную позицию и добавляем к значению
                    value = (value << 1) | bit;
                }

                pixelValues[startPosition / 5] = value;

                outputPixels[startPosition / 5] = getPixelByValue(value, startPosition / 5);

                startPosition += 5;
            }
        }

        public Pixel getPixelByValue(int value, int index)
        {
            int xPalette = value >> 2;
            int yPalette = value & 3;

            int indexPalette = 4 * (yPalette * 5 + xPalette);
            Console.WriteLine($"index: {index} x: {index % pictureWidth}; y: {index / pictureWidth} pallett: {xPalette} : {yPalette} [a={palette[indexPalette]}, {palette[indexPalette + 1]}, {palette[indexPalette + 2]}, {palette[indexPalette + 3]};");

            return new Pixel(index % pictureWidth, index / pictureWidth, palette[indexPalette], palette[indexPalette + 1], palette[indexPalette + 2], palette[indexPalette + 3]);
        }

        public void onColorClick(Object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                if (sender is PictureBox pictureBoxr && pictureBoxr == pictureBoxs[i]) {
                    currentValuePixel = ((i % 5) << 2) | (i / 5);
                    Console.WriteLine($"New value {currentValuePixel}");
                }   
            }
        }

        public void changeColorForPixel(object sender, EventArgs e)
        {
            int x, y;
            Int32.TryParse(textBox1.Text, out x);
            Int32.TryParse(textBox2.Text, out y);
            pixelValues[y * pictureWidth + x] = currentValuePixel;
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                fileStream.WriteByte((byte)(pictureWidth >> 8));
                fileStream.WriteByte((byte)(pictureWidth & 255));

                fileStream.WriteByte((byte)(pictureHeight >> 8));
                fileStream.WriteByte((byte)(pictureHeight & 255));

                fileStream.WriteByte((byte)bitCount);

                fileStream.WriteByte((byte)(paletteCount >> 8));
                fileStream.WriteByte((byte)(paletteCount & 255));
                for (int i = 0; i < 4 * paletteCount; i++) fileStream.WriteByte(palette[i]);

                byte currentByte = 0;
                int freePosition = 8;
                for (int i = 0; i < pictureHeight; i++)
                {
                    for (int j = 0; j < pictureWidth; j++)
                    {
                        if (freePosition >= bitCount)
                        {
                            currentByte = (byte)(currentByte | (pixelValues[i * pictureHeight + j] << (freePosition - bitCount)));
                            freePosition -= bitCount;
                        }
                        else
                        {
                            currentByte = (byte)(currentByte | (pixelValues[i * pictureHeight + j] >> (bitCount - freePosition)));
                            int needWrite = bitCount - freePosition;
                            fileStream.WriteByte(currentByte);
                            currentByte = 0;
                            freePosition = 8;
                            currentByte = (byte)(currentByte | (pixelValues[i * pictureHeight + j] << (freePosition - needWrite)));
                            freePosition -= needWrite;
                        }
                    }
                }

                if (currentByte != 0) fileStream.WriteByte(currentByte);
            }

            ReadPicture();
            parsePixels();
            pictureBox1.Invalidate();
        }

    }

    public class Pixel
    {
        public int x, y;
        public Color color;

        public Pixel(int x, int y, int alpha, int red, int green, int blue)
        {
            this.x = x;
            this.y = y;
            this.color = Color.FromArgb(alpha, red, green, blue);
        }
    }
}
