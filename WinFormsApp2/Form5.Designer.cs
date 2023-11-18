namespace WinFormsApp2
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 24);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(191, 15);
            label1.TabIndex = 2;
            label1.Text = "Сообщение ключ* для Виженера";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Текущий ключ";
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Location = new Point(234, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox2.Location = new Point(12, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 24);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(194, 15);
            label3.TabIndex = 6;
            label3.Text = "Ключ для шифрования Виженера";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(355, 140);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(327, 168);
            richTextBox2.TabIndex = 12;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(293, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Принять";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(688, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(272, 233);
            dataGridView1.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(766, 270);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 16;
            button3.Text = "Расшифровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(766, 241);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 15;
            button2.Text = "Зашифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 122);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(284, 15);
            label4.TabIndex = 17;
            label4.Text = "Сообщение для шифрования шифром Плейфера";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vigenere_cipher_0;
            pictureBox1.Location = new Point(12, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "";
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 454);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private RichTextBox richTextBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}