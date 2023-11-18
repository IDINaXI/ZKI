namespace WinFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vigenere_cipher_0;
            pictureBox1.Location = new Point(43, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 36);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 1;
            label1.Text = "Сообщение и смещение (Цезарь)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 36);
            label2.Name = "label2";
            label2.Size = new Size(267, 15);
            label2.TabIndex = 2;
            label2.Text = "Ключ для шифровки/расшифровки (Виженер)";
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(407, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox3.Location = new Point(113, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(469, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(743, 226);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 7;
            button2.Text = "Зашифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(743, 255);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 8;
            button3.Text = "Расшифровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(32, 54);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Принять";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 83);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 10;
            label3.Text = "Текущий ключ - ";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(407, 176);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(327, 168);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 414);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private RichTextBox richTextBox2;
    }
}