namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            tabPage2 = new TabPage();
            label4 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            button8 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(235, 60);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Шифровать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 108);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 1;
            button2.Text = "Дешифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 61);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 84);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(235, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 5;
            label1.Text = "Сообщение для шифрования";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 161);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 6;
            label2.Text = "Ключ2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 161);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Ключ1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1403, 772);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button8);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1395, 744);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(218, 364);
            button7.Name = "button7";
            button7.Size = new Size(100, 23);
            button7.TabIndex = 10;
            button7.Text = "Лр4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(112, 364);
            button6.Name = "button6";
            button6.Size = new Size(100, 23);
            button6.TabIndex = 9;
            button6.Text = "Лр3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(6, 364);
            button5.Name = "button5";
            button5.Size = new Size(100, 23);
            button5.TabIndex = 8;
            button5.Text = "polybt";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1395, 744);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 389);
            label4.Name = "label4";
            label4.Size = new Size(199, 15);
            label4.TabIndex = 5;
            label4.Text = "Введите сообщение в 25 символов";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(72, 413);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(481, 23);
            textBox4.TabIndex = 4;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // button4
            // 
            button4.Location = new Point(1233, 252);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Дешифровать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1233, 174);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Шифровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(616, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 20;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(522, 341);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Column1";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Column2";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Column3";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Column4";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Column5";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(522, 341);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button8
            // 
            button8.Location = new Point(324, 364);
            button8.Name = "button8";
            button8.Size = new Size(100, 23);
            button8.TabIndex = 11;
            button8.Text = "Лр5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 427);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label4;
        private TextBox textBox4;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}