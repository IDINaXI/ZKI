namespace WinFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        static string Encrypt(string text, string key)
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

        static string Decrypt(string text, string key)
        {
            string outputText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char nowChar = text[i]; 
                char keyChar = key[i % key.Length];

                char baseChar = 'A';
                char decryptedChar = (char)((nowChar - keyChar + 26 - baseChar + baseChar) % 26 + baseChar); 
                // Decrypt(cn) = (Q + cn - kn) % Q
                outputText += decryptedChar;     
            }
            return outputText;
        }

        string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string key = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = textBox1.Text;
                string outputText = "";
                int sdvig = 1;
                int position = 0;

                textBox1.Clear();

                while (position < inputText.Length)
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (alphabet[i] == inputText[position].ToString())
                        {
                            if ((i + sdvig) <= 25)
                            {
                                outputText += alphabet[i + sdvig];
                            }
                            else
                            {
                                outputText += alphabet[(i + sdvig) - 25];
                            }
                        }
                    }
                    position++;
                }
                textBox3.Text = outputText;
                key = outputText;
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверные значения");
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = richTextBox2.Text;
            string outputText = "";
            richTextBox2.Clear();

            outputText = Encrypt(inputText, key);
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

            outputText = Decrypt(inputText, key);
            richTextBox2.Text = outputText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                key = textBox3.Text;
                label3.Text = $"Текущий ключ - {key}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверные значения");
                textBox3.Clear();
                label3.Text = $"Текущий ключ - ";
            }
        }
    }
}
