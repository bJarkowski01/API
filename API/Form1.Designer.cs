namespace API
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox4 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(23, 79);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(275, 187);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(81, 44);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 1;
            button1.Text = "Pobierz dane\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(23, 354);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(454, 84);
            listBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(23, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(275, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "USD", "CHF", "EUR", "GBP", "JPY", "PLN" });
            comboBox1.Location = new Point(69, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(58, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(430, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(530, 359);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 27);
            textBox3.TabIndex = 6;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // button2
            // 
            button2.Location = new Point(596, 270);
            button2.Name = "button2";
            button2.Size = new Size(110, 45);
            button2.TabIndex = 7;
            button2.Text = "Przelicz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "USD", "CHF", "EUR", "GBP", "JPY", "PLN" });
            comboBox2.Location = new Point(69, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(58, 28);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 270);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 9;
            label1.Text = "Wpisz wartość";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(521, 1);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 10;
            label2.Text = "Wybierz walutę";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(487, 126);
            label3.Name = "label3";
            label3.Size = new Size(187, 20);
            label3.TabIndex = 11;
            label3.Text = "Wybierz walutę docelową";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 336);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 12;
            label4.Text = "Wynik:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(487, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 98);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(comboBox2);
            panel2.Location = new Point(487, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 98);
            panel2.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(23, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(275, 27);
            textBox4.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(346, 24);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(346, 78);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 17;
            button4.Text = "Sort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button button2;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox4;
        private Button button3;
        private Button button4;
    }
}
