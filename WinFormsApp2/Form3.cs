using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private const string key = "WINTER";
        private char[,] polybiusSquare;
        public Form3()
        {
            InitializeComponent();
            InitializePolybiusSquare();
        }

        private void InitializePolybiusSquare()
        {
            polybiusSquare = new char[6, 6];
            string alphabet = "WINTERABCDFGHJKLMOPQSUVXYZ1234567890";
            int index = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    polybiusSquare[i, j] = alphabet[index++];
                }
            }

            dataGridView1.Rows.Clear();
            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Rows.Add(polybiusSquare[i, 0], polybiusSquare[i, 1], polybiusSquare[i, 2], polybiusSquare[i, 3], polybiusSquare[i, 4], polybiusSquare[i, 5]);
            }
        }

        private string Encrypt(string text)
        {
            text = text.ToUpper();
            string encryptedText = "";

            foreach (char letter in text)
            {
                if (letter == ' ')
                {
                    encryptedText += ' ';
                    continue;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (polybiusSquare[i, j] == letter)
                        {
                            encryptedText += (i + 1).ToString() + (j + 1).ToString() + " ";
                            break;
                        }
                    }
                }
            }

            return encryptedText.Trim();
        }

        private string Decrypt(string encryptedText)
        {
            string decryptedText = "";

            string[] pairs = encryptedText.Split(' ');

            foreach (string pair in pairs)
            {
                if (pair == "")
                    decryptedText += ' ';
                else
                {
                    int row = int.Parse(pair[0].ToString()) - 1;
                    int col = int.Parse(pair[1].ToString()) - 1;
                    decryptedText += polybiusSquare[row, col];
                }
            }

            return decryptedText;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string textToEncrypt = textBox1.Text;
            string encryptedText = Encrypt(textToEncrypt);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, encryptedText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string encryptedText = File.ReadAllText(openFileDialog.FileName);
                string decryptedText = Decrypt(encryptedText);
                textBox2.Text = decryptedText;
            }
        }
    }
}



