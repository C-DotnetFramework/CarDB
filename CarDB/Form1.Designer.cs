namespace CarDB
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 345);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 124);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 322);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "차량 목록";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 322);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "고객 목록";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(168, 345);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 124);
            listBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(324, 378);
            button1.Name = "button1";
            button1.Size = new Size(250, 91);
            button1.TabIndex = 4;
            button1.Text = "렌탈";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1011, 304);
            dataGridView1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(324, 345);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(773, 378);
            button2.Name = "button2";
            button2.Size = new Size(250, 91);
            button2.TabIndex = 8;
            button2.Text = "반납";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 322);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 9;
            label3.Text = "렌탈 일자";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 483);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Label label3;
    }
}