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

        int offsetX = 20; 
        int offsetY = 20; 
        int scale = 15;
        int coeffNet = 0;

        string bitString = "";

        public Form1()
        {
            InitializeComponent();
            ReadPicture();
            parsePixels();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Получаем объект Graphics
            graphics = e.Graphics;
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
                // Учет смещения при выводе
                int x = outputPixels[i].x * scale + offsetX;
                int y = outputPixels[i].y * scale + offsetY;

                Console.WriteLine($"x: {outputPixels[i].x}; y: {outputPixels[i].y} color: {outputPixels[i].color};");
                Console.WriteLine($"x: {outputPixels[i].x}; y: {outputPixels[i].x} color: {outputPixels[i].color};");
                netX = i % pictureWidth * coeffNet;
                netY = i / pictureWidth * coeffNet;

                graphics.FillRectangle(new SolidBrush(outputPixels[i].color), x + netX, y + netY, scale, scale);
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
            string filePath = @"../../../new_picker_1.glhf";
            bitString = "";
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
                }

                int countPixelByte = (int)Math.Ceiling((double)pictureWidth * pictureHeight * bitCount / 8);
                Console.WriteLine($"countPixelByte: {countPixelByte}");
                pixels = new byte[countPixelByte];
                for (int i = 0; i < countPixelByte; i++)
                {
                    byte currentByte = (byte)fileStream.ReadByte();
                    pixels[i] = currentByte;
                    Console.WriteLine($"Pixel {i + 1}: {pixels[i]}");
                    bitString += Convert.ToString(currentByte, 2).PadLeft(8, '0');
                    Console.WriteLine(bitString);
                }
            }
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

        public void ModifyContrast(double contrastFactor)
        {
            ModifyPaletteContrast(contrastFactor);

            SaveToFile();
        }

        private void ModifyPaletteContrast(double contrastFactor)
        {
            contrastFactor = (100.0 + contrastFactor) / 100.0;
            contrastFactor *= contrastFactor;

            // Каждый цвет в палитре состоит из 4 байт (A, R, G, B)
            for (int i = 0; i < palette.Length; i += 4)
            {
                
                byte alpha = palette[i];       
                byte red = palette[i + 1];     
                byte green = palette[i + 2];   
                byte blue = palette[i + 3];    
                Console.WriteLine($"Before red: {red}, green: {green}, blue: {blue}");
                
                red = (byte)AdjustContrast(red, contrastFactor);
                green = (byte)AdjustContrast(green, contrastFactor);
                blue = (byte)AdjustContrast(blue, contrastFactor);
                Console.WriteLine($"After red: {red}, green: {green}, blue: {blue}");
               
                palette[i] = alpha;     
                palette[i + 1] = red;   
                palette[i + 2] = green; 
                palette[i + 3] = blue;  
            }
        }


        private int AdjustContrast(int colorComponent, double contrastFactor)
        {
            // Приведение значения компонента цвета к диапазону [0, 1]
            double newComponent = colorComponent / 255.0;

            // Применение контрастного смещения относительно среднего значения 0.5
            newComponent = 0.5 + (newComponent - 0.5) * contrastFactor;

            // Приведение обратно к диапазону [0, 255]
            newComponent *= 255;

            // Ограничение в диапазоне 0-255
            return Math.Min(255, Math.Max(0, (int)newComponent));
        }

        public void SaveToFile()
        {
            string filePath = @"../../../rewrite.glhf";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                // Сохраняем заголовок: ширина, высота, bitCount и paletteCount
                fileStream.WriteByte((byte)(pictureWidth >> 8));
                fileStream.WriteByte((byte)pictureWidth);
                fileStream.WriteByte((byte)(pictureHeight >> 8));
                fileStream.WriteByte((byte)pictureHeight);
                fileStream.WriteByte((byte)bitCount);
                fileStream.WriteByte((byte)(paletteCount >> 8));
                fileStream.WriteByte((byte)paletteCount);

                // Записываем палитру
                for (int i = 0; i < palette.Length; i++)
                {
                    fileStream.WriteByte(palette[i]);
                }

                int bitBuffer = 0;
                int bitPosition = 0;

                for (int i = 0; i < bitString.Length; i++)
                {
                    bitBuffer = (bitBuffer << 1) | (bitString[i] - '0'); 
                    bitPosition++;

                    if (bitPosition == 8)
                    {
                        fileStream.WriteByte((byte)bitBuffer);
                        bitBuffer = 0;
                        bitPosition = 0;
                    }
                }

                if (bitPosition > 0)
                {
                    bitBuffer = bitBuffer << (8 - bitPosition);
                    fileStream.WriteByte((byte)bitBuffer);
                }

            }
        }

        private int GetValueFromPixel(Pixel pixel)
        {
            // Кодируем пиксель обратно в исходный формат (пример с использованием палитры)
            int xPalette = Array.IndexOf(palette, pixel.color.R);
            int yPalette = Array.IndexOf(palette, pixel.color.G);
            return (xPalette << 2) | yPalette;
        }
        private void buttonAdjustContrast_Click(object sender, EventArgs e)
        {
            // Получаем коэффициент контрастности из текстового поля (или другого элемента интерфейса)
            if (double.TryParse(textBox1.Text, out double contrastFactor))
            {
                // Вызов метода для изменения контрастности и сохранения в новый файл
                ModifyContrast(contrastFactor);

                MessageBox.Show("Контрастность изменена и изображение сохранено в новый файл.");
            }
            else
            {
                MessageBox.Show("Введите корректное значение коэффициента контрастности.");
            }
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
