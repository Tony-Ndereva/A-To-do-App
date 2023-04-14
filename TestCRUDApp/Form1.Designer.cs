namespace TestCRUDApp
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
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            TaskDesbtn = new System.Windows.Forms.TextBox();
            TaskTitlebtn = new System.Windows.Forms.TextBox();
            Searchbtn = new System.Windows.Forms.Button();
            Updatebtn = new System.Windows.Forms.Button();
            Deletebtn = new System.Windows.Forms.Button();
            Insertbtn = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label8 = new System.Windows.Forms.Label();
            fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            label2 = new System.Windows.Forms.Label();
            TaskID = new System.Windows.Forms.ComboBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            SearchTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("French Script MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(257, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(146, 38);
            label1.TabIndex = 0;
            label1.Text = "To-Do App";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(9, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 23);
            label3.TabIndex = 0;
            label3.Text = "Task Tittle";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(9, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(141, 23);
            label4.TabIndex = 0;
            label4.Text = "Task Description";
            label4.Click += label4_Click;
            // 
            // TaskDesbtn
            // 
            TaskDesbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TaskDesbtn.Location = new System.Drawing.Point(156, 67);
            TaskDesbtn.Name = "TaskDesbtn";
            TaskDesbtn.Size = new System.Drawing.Size(350, 23);
            TaskDesbtn.TabIndex = 1;
            TaskDesbtn.TextChanged += textBox2_TextChanged;
            // 
            // TaskTitlebtn
            // 
            TaskTitlebtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            TaskTitlebtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            TaskTitlebtn.Location = new System.Drawing.Point(156, 105);
            TaskTitlebtn.Name = "TaskTitlebtn";
            TaskTitlebtn.Size = new System.Drawing.Size(350, 23);
            TaskTitlebtn.TabIndex = 1;
            TaskTitlebtn.TextChanged += textBox3_TextChanged;
            // 
            // Searchbtn
            // 
            Searchbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Searchbtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            Searchbtn.Location = new System.Drawing.Point(430, 311);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new System.Drawing.Size(75, 23);
            Searchbtn.TabIndex = 2;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += button1_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Updatebtn.Location = new System.Drawing.Point(339, 311);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new System.Drawing.Size(75, 23);
            Updatebtn.TabIndex = 2;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = true;
            Updatebtn.Click += button2_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Deletebtn.ForeColor = System.Drawing.Color.Red;
            Deletebtn.Location = new System.Drawing.Point(248, 311);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new System.Drawing.Size(75, 23);
            Deletebtn.TabIndex = 2;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += button3_Click;
            // 
            // Insertbtn
            // 
            Insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Insertbtn.ForeColor = System.Drawing.Color.Lime;
            Insertbtn.Location = new System.Drawing.Point(156, 311);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new System.Drawing.Size(75, 23);
            Insertbtn.TabIndex = 2;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = true;
            Insertbtn.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(9, 146);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(142, 23);
            label7.TabIndex = 0;
            label7.Text = "Make a Schedule";
            label7.Click += label4_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new System.Drawing.Point(156, 223);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new System.Drawing.Size(75, 23);
            dateTimePicker3.TabIndex = 3;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(802, 25);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(85, 23);
            label8.TabIndex = 5;
            label8.Text = "Task List";
            label8.Click += label8_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(9, 185);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 23);
            label2.TabIndex = 0;
            label2.Text = "Completion Date";
            label2.Click += label4_Click;
            // 
            // TaskID
            // 
            TaskID.FormattingEnabled = true;
            TaskID.Location = new System.Drawing.Point(249, 282);
            TaskID.Name = "TaskID";
            TaskID.Size = new System.Drawing.Size(165, 23);
            TaskID.TabIndex = 6;
            TaskID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(156, 146);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(75, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Script MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(9, 223);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(108, 23);
            label5.TabIndex = 0;
            label5.Text = "Date Created";
            label5.Click += label4_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(156, 185);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(75, 23);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(531, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(644, 267);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // SearchTextbox
            // 
            SearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            SearchTextbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            SearchTextbox.Location = new System.Drawing.Point(430, 282);
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new System.Drawing.Size(76, 23);
            SearchTextbox.TabIndex = 1;
            SearchTextbox.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1292, 507);
            Controls.Add(dataGridView1);
            Controls.Add(TaskID);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker3);
            Controls.Add(Insertbtn);
            Controls.Add(Deletebtn);
            Controls.Add(label5);
            Controls.Add(Updatebtn);
            Controls.Add(label2);
            Controls.Add(Searchbtn);
            Controls.Add(label7);
            Controls.Add(TaskDesbtn);
            Controls.Add(SearchTextbox);
            Controls.Add(TaskTitlebtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TaskDesbtn;
        private System.Windows.Forms.TextBox TaskTitlebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox TaskID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchTextbox;
    }
}
