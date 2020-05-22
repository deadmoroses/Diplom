namespace SchoolCanteen.UserControls
{
    partial class Students
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.addUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.cencelSearchButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.activator = new System.Windows.Forms.Button();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.selectedStudent = new System.Windows.Forms.Label();
            this.paySumm = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paySumm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.cencelSearchButton);
            this.panel4.Controls.Add(this.addUser);
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.searchBox);
            this.panel4.Location = new System.Drawing.Point(10, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 305);
            this.panel4.TabIndex = 9;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(0, 7);
            this.addUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(226, 28);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "Добавить ученика";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(880, 251);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(524, 10);
            this.searchBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(304, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Поиск...";
            // 
            // cencelSearchButton
            // 
            this.cencelSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cencelSearchButton.BackgroundImage = global::SchoolCanteen.Properties.Resources.cencel;
            this.cencelSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cencelSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cencelSearchButton.Location = new System.Drawing.Point(861, 10);
            this.cencelSearchButton.Name = "cencelSearchButton";
            this.cencelSearchButton.Size = new System.Drawing.Size(22, 22);
            this.cencelSearchButton.TabIndex = 3;
            this.cencelSearchButton.Text = " ";
            this.cencelSearchButton.UseVisualStyleBackColor = true;
            this.cencelSearchButton.Click += new System.EventHandler(this.cencelSearchButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackgroundImage = global::SchoolCanteen.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(833, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(22, 22);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(395, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.payButton);
            this.panel1.Controls.Add(this.paySumm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectedStudent);
            this.panel1.Controls.Add(this.deleteStudent);
            this.panel1.Controls.Add(this.activator);
            this.panel1.Location = new System.Drawing.Point(11, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 79);
            this.panel1.TabIndex = 10;
            // 
            // activator
            // 
            this.activator.Location = new System.Drawing.Point(0, 5);
            this.activator.Margin = new System.Windows.Forms.Padding(5);
            this.activator.Name = "activator";
            this.activator.Size = new System.Drawing.Size(226, 28);
            this.activator.TabIndex = 0;
            this.activator.Text = "Снять/поставить на питание";
            this.activator.UseVisualStyleBackColor = true;
            this.activator.Click += new System.EventHandler(this.activator_Click);
            // 
            // deleteStudent
            // 
            this.deleteStudent.Location = new System.Drawing.Point(0, 43);
            this.deleteStudent.Margin = new System.Windows.Forms.Padding(5);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(226, 28);
            this.deleteStudent.TabIndex = 0;
            this.deleteStudent.Text = "Ученик выбыл";
            this.deleteStudent.UseVisualStyleBackColor = true;
            this.deleteStudent.Click += new System.EventHandler(this.deleteStudent_Click);
            // 
            // selectedStudent
            // 
            this.selectedStudent.AutoSize = true;
            this.selectedStudent.Location = new System.Drawing.Point(249, 31);
            this.selectedStudent.Name = "selectedStudent";
            this.selectedStudent.Size = new System.Drawing.Size(0, 16);
            this.selectedStudent.TabIndex = 1;
            // 
            // paySumm
            // 
            this.paySumm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paySumm.Location = new System.Drawing.Point(734, 38);
            this.paySumm.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.paySumm.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.paySumm.Name = "paySumm";
            this.paySumm.Size = new System.Drawing.Size(58, 22);
            this.paySumm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Внести оплату";
            // 
            // payButton
            // 
            this.payButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.payButton.Location = new System.Drawing.Point(842, 33);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(38, 28);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "ОК";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(794, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "р.";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Students";
            this.Size = new System.Drawing.Size(898, 397);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paySumm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cencelSearchButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.Button activator;
        private System.Windows.Forms.NumericUpDown paySumm;
        private System.Windows.Forms.Label selectedStudent;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
