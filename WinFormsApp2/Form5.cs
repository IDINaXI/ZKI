namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        string currentKey;
        public Form5()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static class PlayfairCipher
        {
            public static string Encrypt(string input, char[,] matrix)
            {
                input = input.Replace("J", "I").Replace(" ", ""); // замена 'J' на 'I' и удаление пробелов

                string encryptedText = "";
                for (int i = 0; i < input.Length; i += 2)
                {
                    char firstChar = input[i];
                    char secondChar = (i + 1 < input.Length) ? input[i + 1] : 'X';

                    int[] firstPosition = GetPosition(matrix, firstChar);
                    int[] secondPosition = GetPosition(matrix, secondChar);

                    if (firstPosition[0] == secondPosition[0])
                    {
                        encryptedText += matrix[firstPosition[0], (firstPosition[1] + 1) % 5];
                        encryptedText += matrix[secondPosition[0], (secondPosition[1] + 1) % 5];
                    }
                    else if (firstPosition[1] == secondPosition[1])
                    {
                        encryptedText += matrix[(firstPosition[0] + 1) % 5, firstPosition[1]];
                        encryptedText += matrix[(secondPosition[0] + 1) % 5, secondPosition[1]];
                    }
                    else
                    {
                        encryptedText += matrix[firstPosition[0], secondPosition[1]];
                        encryptedText += matrix[secondPosition[0], firstPosition[1]];
                    }
                }

                return encryptedText;
            }
            public static string Decrypt(string input, char[,] matrix)
            {
                string decryptedText = "";
                for (int i = 0; i < input.Length; i += 2)
                {
                    char firstChar = input[i];
                    char secondChar = input[i + 1];

                    int[] firstPosition = GetPosition(matrix, firstChar);
                    int[] secondPosition = GetPosition(matrix, secondChar);

                    if (firstPosition[0] == secondPosition[0])
                    {
                        decryptedText += matrix[firstPosition[0], (firstPosition[1] - 1 + 5) % 5];
                        decryptedText += matrix[secondPosition[0], (secondPosition[1] - 1 + 5) % 5];
                    }
                    else if (firstPosition[1] == secondPosition[1])
                    {
                        decryptedText += matrix[(firstPosition[0] - 1 + 5) % 5, firstPosition[1]];
                        decryptedText += matrix[(secondPosition[0] - 1 + 5) % 5, secondPosition[1]];
                    }
                    else
                    {
                        decryptedText += matrix[firstPosition[0], secondPosition[1]];
                        decryptedText += matrix[secondPosition[0], firstPosition[1]];
                    }
                }

                return decryptedText;
            }
            public static char[,] GenerateMatrix(string key)
            {
                char[,] matrix = new char[5, 5];
                string keyWithoutDuplicates = "";
                foreach (char c in key + "ABCDEFGHIKLMNOPQRSTUVWXYZ")
                {
                    if (keyWithoutDuplicates.IndexOf(c) == -1)
                    {
                        keyWithoutDuplicates += c;
                    }
                }

                int index = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matrix[i, j] = keyWithoutDuplicates[index++];
                    }
                }

                return matrix;
            }
            public static int[] GetPosition(char[,] matrix, char target)
            {
                int[] position = new int[2];
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == target)
                        {
                            position[0] = i;
                            position[1] = j;
                            return position;
                        }
                    }
                }

                return null;
            }
        }




        static string VigenereEncrypt(string text, string key)
        {
            string outputText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char nowChar = text[i];
                char keyChar = key[i % key.Length];
                char baseChar = 'A';
                char encryptedChar = (char)((nowChar - baseChar + keyChar - baseChar) % 26 + baseChar);
                // Encrypt(mn) = (Q + mn + kn) % Q
                outputText += encryptedChar;
            }
            return outputText;
        }
        public void ArrayToDatagrid(char[,] data)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = data[i, j];
                }
            }
        }
        static bool IsAllLetters(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsAllLetters(textBox1.Text) && IsAllLetters(textBox1.Text))
            {
                currentKey = VigenereEncrypt(textBox1.Text, textBox2.Text);
                ArrayToDatagrid(PlayfairCipher.GenerateMatrix(currentKey));
                label2.Text = $"Текущий ключ - {currentKey}";
            }
            else
            {
                MessageBox.Show("Неверные значения");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox2.Text;
            string outputText = "";
            richTextBox2.Clear();

            outputText = PlayfairCipher.Encrypt(inputText, PlayfairCipher.GenerateMatrix(currentKey));
            richTextBox2.Text = outputText;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, outputText);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox2.Text;
            string outputText = "";
            richTextBox2.Clear();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
                openFileDialog.Title = "Выберите файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    using (StreamReader reader = new StreamReader(selectedFilePath))
                    {
                        inputText = reader.ReadToEnd();
                    }
                }
            }

            outputText = PlayfairCipher.Decrypt(inputText, PlayfairCipher.GenerateMatrix(currentKey));
            richTextBox2.Text = outputText;
        }
    }

}
