using System.Drawing;
using System.IO;

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
        Pixel[] outputPixels;

        Graphics graphics;

        // Добавляем поля для смещений
        int offsetX = 20; // Смещение по горизонтали
        int offsetY = 20; // Смещение по вертикали
        int scale = 15;
        int coeffNet = 0;

        int frameCount;  // Количество кадров
        List<Pixel[]> frames = new List<Pixel[]>();  // Список всех кадров
        int currentFrame = 0;  // Текущий кадр
        System.Windows.Forms.Timer timer;  // Явно указываем таймер из Windows Forms

        public Form1()
        {
            InitializeComponent();
            ReadPicture();
            //parsePixels();
            SetupAnimation();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Получаем объект Graphics
            graphics = e.Graphics;
            Pixel[] framePixels = frames[currentFrame];  // Текущий кадр
            int netX = 0, netY = 0;
            if (coeffNet != 0)
            {
                int x = outputPixels[0].x * scale + offsetX;
                int y = outputPixels[0].y * scale + offsetY;
                netX = pictureWidth * (scale + coeffNet) - coeffNet;
                netY = pictureHeight * (scale + coeffNet) - coeffNet;

                graphics.FillRectangle(Brushes.Black, x, y, netX, netY);
            }
            for (int i = 0; i < pictureHeight * pictureWidth; i++)
            {
                int x = framePixels[i].x * scale + offsetX;
                int y = framePixels[i].y * scale + offsetY;
                Console.WriteLine($"x: {outputPixels[i].x}; y: {outputPixels[i].y} color: {outputPixels[i].color};");
                Console.WriteLine($"x: {outputPixels[i].x}; y: {outputPixels[i].x} color: {outputPixels[i].color};");
                netX = i % pictureWidth * coeffNet;
                netY = i / pictureWidth * coeffNet;
                graphics.FillRectangle(new SolidBrush(framePixels[i].color), x + netX, y + netY, scale, scale);
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
                coeffNet = 1;
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
            string filePath = @"../../../test_gifka.glhf";

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[2];
                buffer[0] = (byte)fileStream.ReadByte();
                buffer[1] = (byte)fileStream.ReadByte();
                frameCount = (buffer[0] << 8) | buffer[1];
                for (int f = 0; f < frameCount; f++)
                {
                    Console.WriteLine($"{f} кадр.");
                    // Читаем ширину, высоту и остальное как раньше
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
                    }
                    int countPixelByte = (int)Math.Ceiling((double)pictureWidth * pictureHeight * bitCount / 8);
                    Console.WriteLine($"countPixelByte: {countPixelByte}");
                    pixels = new byte[countPixelByte];
                    for (int i = 0; i < countPixelByte; i++)
                    {
                        pixels[i] = (byte)fileStream.ReadByte();
                        Console.WriteLine($"Pixel {i + 1}: {pixels[i]}");
                    }
                    // Читаем пиксели кадра
                    parsePixels();

                    // Сохраняем кадр
                    frames.Add(outputPixels);
                }
            }
        }

        private void SetupAnimation()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 333;
            timer.Tick += (sender, e) => {
                currentFrame = (currentFrame + 1) % frameCount;
                pictureBox1.Invalidate();  // Перерисовываем PictureBox
            };
            timer.Start();
        }

        public void parsePixels()
        {
            outputPixels = new Pixel[pictureWidth * pictureHeight];

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

        private void labelOffsetX_Click(object sender, EventArgs e)
        {

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
