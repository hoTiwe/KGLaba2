using System;
using System.IO;

namespace KGLaba2
{
    class Program
    {
        static readonly int width = 70;
        static readonly int height = 70;

        static readonly int bitCount = 5;
        static readonly int paletteCount = 15;

        static readonly byte[][] palette = new byte[][]
        {
            new byte[] {255, 255, 165, 0},
            new byte[] {255, 240, 172, 71},
            new byte[] {255, 223, 179, 111},
            new byte[] {255, 196, 146, 85},
            new byte[] {255, 175, 140, 100},
            new byte[] {255, 153, 134, 115},
            new byte[] {255, 128, 128, 128},
            new byte[] {255, 255, 255, 255},
            new byte[] {255, 0, 0, 255},
            new byte[] {255, 0, 0, 255},
            new byte[] {255, 255, 0, 255},
            new byte[] {255, 0, 255, 255},
            new byte[] {255, 255, 0, 255},
            new byte[] {255, 0, 255, 255},
            new byte[] {255, 255, 255, 255}
        };

        static readonly string[] pixels = new string[]
        {
            "00000", "00100", "01000",
            "01100", "10000", "00001",
            "00101", "01001", "01101",
            "10001", "00010", "00110",
            "01010", "01110", "10010"
        };

        static void WriteBitsToFile(FileStream fileStream, string bits)
        {
            int bitBuffer = 0;
            int bitPosition = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                bitBuffer = (bitBuffer << 1) | (bits[i] - '0'); // Преобразуем символ в число
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
                bitBuffer = bitBuffer << (8 - bitPosition); // Дополняем оставшиеся биты нулями
                fileStream.WriteByte((byte)bitBuffer);
            }
        }

        static string Generate7ColorGradientPattern(int width, int height)
        {
            string bitString = "";
            int segmentWidth = width / 7;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int colorIndex = x / segmentWidth;
                    bitString += pixels[colorIndex];
                }
            }

            return bitString;
        }

        static void GenerateFile()
        {
            using (FileStream fileStream = new FileStream(@"D:\tmp\rabotai.glhf", FileMode.Create))
            {
                // Записываем ширину и высоту изображения
                fileStream.WriteByte((byte)(width / 256));
                fileStream.WriteByte((byte)(width % 256));
                fileStream.WriteByte((byte)(height / 256));
                fileStream.WriteByte((byte)(height % 256));

                // Записываем bitCount и paletteCount
                fileStream.WriteByte((byte)bitCount);
                fileStream.WriteByte(0);
                fileStream.WriteByte((byte)paletteCount);

                // Записываем палитру
                for (int i = 0; i < paletteCount; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        fileStream.WriteByte(palette[i][j]);
                    }
                }

                // Генерируем и записываем узор
                string bitString = Generate7ColorGradientPattern(width, height);
                WriteBitsToFile(fileStream, bitString);
            }

            Console.WriteLine("Файл с изображением успешно сгенерирован!");
        }

        static void Main(string[] args)
        {
            GenerateFile();
        }
    }
}
