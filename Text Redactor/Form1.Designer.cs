namespace Text_Redactor
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
            panel1 = new Panel();
            panel4 = new Panel();
            checkOverwrite = new CheckBox();
            txtOutputFile = new TextBox();
            btnOutputFile = new Button();
            numericLength = new NumericUpDown();
            checkMarks = new CheckBox();
            checkLength = new CheckBox();
            btnRedact = new Button();
            label1 = new Label();
            panel3 = new Panel();
            listBox1 = new ListBox();
            panel2 = new Panel();
            btnClear = new Button();
            btnAddFile = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericLength).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 406);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(checkOverwrite);
            panel4.Controls.Add(txtOutputFile);
            panel4.Controls.Add(btnOutputFile);
            panel4.Controls.Add(numericLength);
            panel4.Controls.Add(checkMarks);
            panel4.Controls.Add(checkLength);
            panel4.Controls.Add(btnRedact);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 145);
            panel4.Name = "panel4";
            panel4.Size = new Size(317, 198);
            panel4.TabIndex = 4;
            // 
            // checkOverwrite
            // 
            checkOverwrite.AutoSize = true;
            checkOverwrite.Checked = true;
            checkOverwrite.CheckState = CheckState.Checked;
            checkOverwrite.Location = new Point(12, 140);
            checkOverwrite.Name = "checkOverwrite";
            checkOverwrite.Size = new Size(134, 19);
            checkOverwrite.TabIndex = 10;
            checkOverwrite.Text = "Перезаписать файл";
            checkOverwrite.UseVisualStyleBackColor = true;
            // 
            // txtOutputFile
            // 
            txtOutputFile.Location = new Point(12, 35);
            txtOutputFile.Name = "txtOutputFile";
            txtOutputFile.ReadOnly = true;
            txtOutputFile.Size = new Size(256, 23);
            txtOutputFile.TabIndex = 9;
            // 
            // btnOutputFile
            // 
            btnOutputFile.Location = new Point(12, 6);
            btnOutputFile.Name = "btnOutputFile";
            btnOutputFile.Size = new Size(256, 23);
            btnOutputFile.TabIndex = 8;
            btnOutputFile.Text = "Выбрать файл для записи";
            btnOutputFile.UseVisualStyleBackColor = true;
            btnOutputFile.Click += btnOutputFile_Click;
            // 
            // numericLength
            // 
            numericLength.Location = new Point(201, 90);
            numericLength.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericLength.Name = "numericLength";
            numericLength.Size = new Size(46, 23);
            numericLength.TabIndex = 7;
            numericLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericLength.KeyDown += numericLength_KeyDown;
            numericLength.KeyPress += numericLength_KeyPress;
            // 
            // checkMarks
            // 
            checkMarks.AutoSize = true;
            checkMarks.Checked = true;
            checkMarks.CheckState = CheckState.Checked;
            checkMarks.Location = new Point(12, 115);
            checkMarks.Name = "checkMarks";
            checkMarks.Size = new Size(173, 19);
            checkMarks.TabIndex = 6;
            checkMarks.Text = "Удалять знаки препинания";
            checkMarks.UseVisualStyleBackColor = true;
            // 
            // checkLength
            // 
            checkLength.AutoSize = true;
            checkLength.Checked = true;
            checkLength.CheckState = CheckState.Checked;
            checkLength.Location = new Point(12, 90);
            checkLength.Name = "checkLength";
            checkLength.Size = new Size(192, 19);
            checkLength.TabIndex = 5;
            checkLength.Text = "Удалять слова длинной менее";
            checkLength.UseVisualStyleBackColor = true;
            // 
            // btnRedact
            // 
            btnRedact.Location = new Point(10, 165);
            btnRedact.Name = "btnRedact";
            btnRedact.Size = new Size(125, 23);
            btnRedact.TabIndex = 4;
            btnRedact.Text = "Обработать файлы";
            btnRedact.UseVisualStyleBackColor = true;
            btnRedact.Click += btnRedact_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 91);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "символов";
            // 
            // panel3
            // 
            panel3.Controls.Add(listBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 45);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(12, 0, 12, 0);
            panel3.Size = new Size(317, 100);
            panel3.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 100);
            listBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnAddFile);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 45);
            panel2.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(143, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Очистить список";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddFile
            // 
            btnAddFile.Location = new Point(12, 12);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(125, 23);
            btnAddFile.TabIndex = 0;
            btnAddFile.Text = "Добавить файл";
            btnAddFile.UseVisualStyleBackColor = true;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 406);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обработчик текста";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericLength).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddFile;
        private ListBox listBox1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private RadioButton radioButton1;
        private Label label1;
        private Button btnRedact;
        private CheckBox checkMarks;
        private CheckBox checkLength;
        private RadioButton radioButton2;
        private NumericUpDown numericLength;
        private Button btnClear;
        private TextBox txtOutputFile;
        private Button btnOutputFile;
        private CheckBox checkOverwrite;
    }
}
