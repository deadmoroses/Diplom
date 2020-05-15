namespace SchoolCanteen
{
    partial class Admin
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.salutationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.usersPage = new System.Windows.Forms.TabPage();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.activatorForUser = new System.Windows.Forms.Button();
            this.userEditor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addUser = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.usersPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salutationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(890, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // salutationLabel
            // 
            this.salutationLabel.Enabled = false;
            this.salutationLabel.Name = "salutationLabel";
            this.salutationLabel.Size = new System.Drawing.Size(870, 17);
            this.salutationLabel.Spring = true;
            this.salutationLabel.Text = "Приветствие";
            this.salutationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salutationLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.usersPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // usersPage
            // 
            this.usersPage.Controls.Add(this.addUser);
            this.usersPage.Controls.Add(this.searchBox);
            this.usersPage.Controls.Add(this.panel1);
            this.usersPage.Controls.Add(this.dataGridView1);
            this.usersPage.Location = new System.Drawing.Point(4, 25);
            this.usersPage.Margin = new System.Windows.Forms.Padding(4);
            this.usersPage.Name = "usersPage";
            this.usersPage.Padding = new System.Windows.Forms.Padding(4);
            this.usersPage.Size = new System.Drawing.Size(882, 503);
            this.usersPage.TabIndex = 0;
            this.usersPage.Text = "Управление пользователями";
            this.usersPage.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Location = new System.Drawing.Point(427, 6);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(440, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Поиск...";
            this.searchBox.TextChanged += new System.EventHandler(this.Search);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.roleBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.loginBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.activatorForUser);
            this.panel1.Controls.Add(this.userEditor);
            this.panel1.Location = new System.Drawing.Point(4, 391);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 108);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Роль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roleBox
            // 
            this.roleBox.Enabled = false;
            this.roleBox.Location = new System.Drawing.Point(67, 65);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(218, 22);
            this.roleBox.TabIndex = 2;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(354, 9);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(218, 22);
            this.nameBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(291, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Имя";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(354, 37);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(218, 22);
            this.passwordBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(291, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginBox
            // 
            this.loginBox.Enabled = false;
            this.loginBox.Location = new System.Drawing.Point(67, 37);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(218, 22);
            this.loginBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idBox
            // 
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(67, 9);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(218, 22);
            this.idBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // activatorForUser
            // 
            this.activatorForUser.Location = new System.Drawing.Point(579, 52);
            this.activatorForUser.Margin = new System.Windows.Forms.Padding(4);
            this.activatorForUser.Name = "activatorForUser";
            this.activatorForUser.Size = new System.Drawing.Size(284, 41);
            this.activatorForUser.TabIndex = 0;
            this.activatorForUser.Text = "Активировать/деактивировать запись";
            this.activatorForUser.UseVisualStyleBackColor = true;
            this.activatorForUser.Click += new System.EventHandler(this.ActivatorClick);
            // 
            // userEditor
            // 
            this.userEditor.Location = new System.Drawing.Point(579, 9);
            this.userEditor.Margin = new System.Windows.Forms.Padding(4);
            this.userEditor.Name = "userEditor";
            this.userEditor.Size = new System.Drawing.Size(284, 41);
            this.userEditor.TabIndex = 0;
            this.userEditor.Text = "Зафиксировать изменения";
            this.userEditor.UseVisualStyleBackColor = true;
            this.userEditor.Click += new System.EventHandler(this.EditUser);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(871, 342);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(882, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(7, 6);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(208, 23);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Добавить пользователя";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(890, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.usersPage.ResumeLayout(false);
            this.usersPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel salutationLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage usersPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button activatorForUser;
        private System.Windows.Forms.Button userEditor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roleBox;
        private System.Windows.Forms.Button addUser;
    }
}