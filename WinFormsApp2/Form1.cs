using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
            }
            dataGridView1.Rows[0].Cells[0].Value = "17";
            dataGridView1.Rows[0].Cells[1].Value = "24";
            dataGridView1.Rows[0].Cells[2].Value = "1";
            dataGridView1.Rows[0].Cells[3].Value = "8";
            dataGridView1.Rows[0].Cells[4].Value = "15";
            dataGridView1.Rows[1].Cells[0].Value = "23";
            dataGridView1.Rows[1].Cells[1].Value = "5";
            dataGridView1.Rows[1].Cells[2].Value = "7";
            dataGridView1.Rows[1].Cells[3].Value = "14";
            dataGridView1.Rows[1].Cells[4].Value = "16";
            dataGridView1.Rows[2].Cells[0].Value = "4";
            dataGridView1.Rows[2].Cells[1].Value = "6";
            dataGridView1.Rows[2].Cells[2].Value = "13";
            dataGridView1.Rows[2].Cells[3].Value = "20";
            dataGridView1.Rows[2].Cells[4].Value = "22";
            dataGridView1.Rows[3].Cells[0].Value = "10";
            dataGridView1.Rows[3].Cells[1].Value = "12";
            dataGridView1.Rows[3].Cells[2].Value = "19";
            dataGridView1.Rows[3].Cells[3].Value = "21";
            dataGridView1.Rows[3].Cells[4].Value = "3";
            dataGridView1.Rows[4].Cells[0].Value = "11";
            dataGridView1.Rows[4].Cells[1].Value = "18";
            dataGridView1.Rows[4].Cells[2].Value = "25";
            dataGridView1.Rows[4].Cells[3].Value = "2";
            dataGridView1.Rows[4].Cells[4].Value = "9";

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";


        }

        private string Encrypt(string inputText, int[] colOrder, int[] rowOrder)
        {
            int rows = 4;
            int cols = 4;

            string[] lines = inputText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (lines.Length != rows)
            {
                MessageBox.Show("Количество строк должно быть 4");
                return string.Empty;
            }


            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {

                string[] symbols = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (symbols.Length != cols)
                {
                    MessageBox.Show("Количество символов в строке " + (i + 1) + " должно быть 4");
                    return string.Empty;
                }

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = symbols[j][0];
                }
            }

            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    encryptedText.Append(matrix[rowOrder[i] - 1, colOrder[j] - 1]);
                }
            }
            return encryptedText.ToString();
        }

        private string Decrypt(string inputText, int[] colOrder, int[] rowOrder)
        {
            int rows = 4;
            int cols = 4;
            char[,] matrix = new char[rows, cols];
            StringBuilder decryptedText = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[rowOrder[i] - 1, colOrder[j] - 1] = inputText[i * cols + j];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    decryptedText.Append(matrix[i, j]);
                }
            }

            return decryptedText.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string colOrderText = textBox2.Text;
            string rowOrderText = textBox3.Text;


            if (string.IsNullOrWhiteSpace(colOrderText) || string.IsNullOrWhiteSpace(rowOrderText))
            {
                MessageBox.Show("Введите значения для colOrder и rowOrder.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int[] colOrder = colOrderText.Split(',').Select(int.Parse).ToArray();
            int[] rowOrder = rowOrderText.Split(',').Select(int.Parse).ToArray();


            string encryptedText = Encrypt(inputText, colOrder, rowOrder);

            if (!string.IsNullOrEmpty(encryptedText))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, encryptedText);
                    MessageBox.Show("Текст успешно зашифрован и сохранен в файле.");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string colOrderText = textBox2.Text;
            string rowOrderText = textBox3.Text;

            if (string.IsNullOrWhiteSpace(colOrderText) || string.IsNullOrWhiteSpace(rowOrderText))
            {
                MessageBox.Show("Введите значения для colOrder и rowOrder.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int[] colOrder = colOrderText.Split(',').Select(int.Parse).ToArray();
            int[] rowOrder = rowOrderText.Split(',').Select(int.Parse).ToArray();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string encryptedText = File.ReadAllText(openFileDialog.FileName);
                string decryptedText = Decrypt(encryptedText, colOrder, rowOrder);
                textBox1.Text = decryptedText;
                MessageBox.Show("Текст успешно дешифрован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            dataGridView2.Rows[0].Cells[0].Value = text[17 - 1];
            dataGridView2.Rows[0].Cells[1].Value = text[24 - 1];
            dataGridView2.Rows[0].Cells[2].Value = text[1 - 1];
            dataGridView2.Rows[0].Cells[3].Value = text[8 - 1];
            dataGridView2.Rows[0].Cells[4].Value = text[15 - 1];
            dataGridView2.Rows[1].Cells[0].Value = text[23 - 1];
            dataGridView2.Rows[1].Cells[1].Value = text[5 - 1];
            dataGridView2.Rows[1].Cells[2].Value = text[7 - 1];
            dataGridView2.Rows[1].Cells[3].Value = text[14 - 1];
            dataGridView2.Rows[1].Cells[4].Value = text[16 - 1];
            dataGridView2.Rows[2].Cells[0].Value = text[4 - 1];
            dataGridView2.Rows[2].Cells[1].Value = text[6 - 1];
            dataGridView2.Rows[2].Cells[2].Value = text[13 - 1];
            dataGridView2.Rows[2].Cells[3].Value = text[20 - 1];
            dataGridView2.Rows[2].Cells[4].Value = text[22 - 1];
            dataGridView2.Rows[3].Cells[0].Value = text[10 - 1];
            dataGridView2.Rows[3].Cells[1].Value = text[12 - 1];
            dataGridView2.Rows[3].Cells[2].Value = text[19 - 1];
            dataGridView2.Rows[3].Cells[3].Value = text[21 - 1];
            dataGridView2.Rows[3].Cells[4].Value = text[3 - 1];
            dataGridView2.Rows[4].Cells[0].Value = text[11 - 1];
            dataGridView2.Rows[4].Cells[1].Value = text[18 - 1];
            dataGridView2.Rows[4].Cells[2].Value = text[25 - 1];
            dataGridView2.Rows[4].Cells[3].Value = text[2 - 1];
            dataGridView2.Rows[4].Cells[4].Value = text[9 - 1];
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {

                    try
                    {
                        for (int i = 0; i < dataGridView2.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView2.ColumnCount; j++)
                            {

                                sw.Write(dataGridView2.Rows[i].Cells[j].Value.ToString());
                                if (j < dataGridView2.ColumnCount - 1) sw.Write(" "); // не пишем пробел после последней колонки
                            }
                            sw.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string input = openFileDialog1.FileName;

                string text = File.ReadAllText(input);
                text = text.Replace(" ", "").Replace("\r", "").Replace("\n", "");
                int[] nums = { 17, 24, 1, 8, 15, 23, 5, 7, 14, 16, 4, 6, 13, 20, 22, 10, 12, 19, 21, 3, 11, 18, 25, 2, 9 };
                char[] newText = new char[text.Length];

                for (int i = 0; i < text.Length; i++)
                {
                    int newIndex = nums[i];
                    newText[newIndex - 1] = text[i];
                }
                string result = new string(newText);

                textBox4.Text = result;

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsRussianLowerCase(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private bool IsRussianLowerCase(char c)
        {
            return (c >= 'а' && c <= 'я');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 lr2 = new Form2();
            lr2.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 lr3 = new Form3();
            lr3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 lr4 = new Form4();
            lr4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 lr5 = new Form5();
            lr5.Show();
        }
    }




}


//всемприветктоздесьесть123