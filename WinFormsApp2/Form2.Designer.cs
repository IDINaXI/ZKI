namespace WinFormsApp2
{
    partial class Form2
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
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button6 = new Button();
            button5 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, Column6 });
            dataGridView3.Location = new Point(12, 12);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 20;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(635, 341);
            dataGridView3.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Column1";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Column2";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Column3";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Column4";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Column5";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(688, 123);
            label7.Name = "label7";
            label7.Size = new Size(134, 15);
            label7.TabIndex = 17;
            label7.Text = "Зашифрованный текст";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(690, 36);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 16;
            label6.Text = "Текст для зашифровки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(887, 36);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 15;
            label5.Text = "Расшифрованный текст";
            // 
            // button6
            // 
            button6.Location = new Point(835, 199);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 14;
            button6.Text = "расшифровать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(701, 199);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 13;
            button5.Text = "Зашифровать";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(887, 54);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(690, 141);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(690, 54);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox5.KeyPress += textBox5_KeyPress_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(dataGridView3);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Column6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button6;
        private Button button5;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}