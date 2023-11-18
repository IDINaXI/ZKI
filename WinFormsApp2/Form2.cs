using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private PolybiusCube Cube;
        private string[,] cube = new string[,]
        {
        {"W", "I", "N", "T", "E", "R"},
        {"A", "B", "C", "D", "F", "G"},
        {"H", "J", "K", "L", "M", "O"},
        {"P", "Q", "S", "U", "V", "X"},
        {"Y", "Z", "0", "1", "2", "3"},
        {"4", "5", "6", "7", "8", "9"}
        };
        public Form2()
        {
            InitializeComponent();
            dataGridView3.ColumnCount = cube.GetLength(1);
            dataGridView3.RowCount = cube.GetLength(0);


            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = cube[i, j];
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Cube = new PolybiusCube(cube, textBox5.Text);

        }
        private bool IsEnglishUpperCase(char c)
        {
            return (c >= 'A' && c <= 'Z');
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!IsEnglishUpperCase(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (textBox5.Text != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, Cube.Encrypt());
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                Exception exception = new Exception();
                MessageBox.Show("Ошибка введенной строки!\tНекорректный  ввод!\nError:\n" + exception.Message, "Error! Incorrect enter!",
                MessageBoxButtons.OK);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                textBox7.Text = Cube.Decrypt(textBox6.Text);
            }
            else
            {
                Exception exception = new Exception();
                MessageBox.Show("Ошибка введенной строки!\tНекорректный ввод!\nError:\n" + exception.Message, "Error! Incorrect enter!",
                MessageBoxButtons.OK);
            }
        }
    }
    class PolybiusCube
    {
        private string[,] cube;
        private string inputTxt;
        private string encryptedText;
        private string decryptedText;
        public PolybiusCube(string[,] cube, string inputTxt)
        {
            this.cube = cube;
            this.inputTxt = inputTxt;
            this.encryptedText = new string(' ', inputTxt.Length);
            this.decryptedText = new string(' ', inputTxt.Length);
        }
        public string Encrypt()
        {
            char[] encryptedArray = new char[inputTxt.Length];
            for (int k = 0; k < inputTxt.Length; k++)
            {

                char currentChar = inputTxt[k];
                for (int i = 0; i < cube.GetLength(0); i++)
                {
                    for (int j = 0; j < cube.GetLength(1); j++)
                    {
                        if (currentChar == cube[i, j][0])
                        {
                            if (i < cube.GetLength(0) - 1 && j < cube.GetLength(1) - 1)
                                encryptedArray[k] = cube[i + 1, j][0];
                            break;
                        }
                    }
                }
            }
            encryptedText = new string(encryptedArray);
            return encryptedText;
        }
        public string Decrypt(string encryptedText)
        {
            char[] decryptedArray = new char[encryptedText.Length];
            for (int k = 0; k < encryptedText.Length; k++)
            {
                char currentChar = encryptedText[k];
                bool charFound = false;
                for (int i = 0; i < cube.GetLength(0); i++)
                {
                    for (int j = 0; j < cube.GetLength(1); j++)
                    {
                        if (currentChar == cube[i, j][0])
                        {
                            if (i < cube.GetLength(0) - 1 && j < cube.GetLength(1) - 1)
                                decryptedArray[k] = cube[i - 1, j][0];
                            break;
                        }
                    }
                }
            }
            decryptedText = new string(decryptedArray);

            return decryptedText;
        }
    }
}
