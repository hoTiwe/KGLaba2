namespace KGLaba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                string filePath = @"C:\Users\Magic\source\repos\KGLaba2\KGLaba2\new_picker.glhf";

                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    Console.WriteLine("Reading binary file in chunks of 2 bytes, then 1 byte:");

                    int byteValue;
                    int counter = 0;

                    while ((byteValue = fileStream.ReadByte()) != -1)
                    {
                        // ќпредел€ем количество байтов дл€ чтени€: 2 байта, затем 1 байт
                        int bytesToRead = counter % 2 == 0 ? 2 : 1;
                        byte[] buffer = new byte[bytesToRead];
                        buffer[0] = (byte)byteValue;

                        // „итаем оставшиес€ байты, если это группа из 2 байтов
                        if (bytesToRead > 1 && fileStream.Read(buffer, 1, bytesToRead - 1) == 0)
                        {
                            break; // конец файла
                        }

                        if (bytesToRead == 2)
                        {
                            // ѕреобразуем два байта в одно число
                            int combinedValue = (buffer[0] << 8) | buffer[1];
                            Console.WriteLine($"Bytes read (2): {buffer[0]} {buffer[1]}"); // выводим дес€тичное число
                            Console.WriteLine($"Bytes read (2): {combinedValue}"); // выводим дес€тичное число
                        }
                        else
                        {
                            Console.WriteLine($"Bytes read (1): {buffer[0]}");
                        }

                        counter++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
