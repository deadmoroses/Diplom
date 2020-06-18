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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.salutationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.studentsTab = new System.Windows.Forms.TabPage();
            this.teachersTab = new System.Windows.Forms.TabPage();
            this.reportsTab = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salutationLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // salutationLabel
            // 
            this.salutationLabel.Enabled = false;
            this.salutationLabel.Name = "salutationLabel";
            this.salutationLabel.Size = new System.Drawing.Size(764, 17);
            this.salutationLabel.Spring = true;
            this.salutationLabel.Text = "Приветствие";
            this.salutationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salutationLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.usersTab);
            this.tabControl1.Controls.Add(this.studentsTab);
            this.tabControl1.Controls.Add(this.teachersTab);
            this.tabControl1.Controls.Add(this.reportsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 539);
            this.tabControl1.TabIndex = 1;
            // 
            // usersTab
            // 
            this.usersTab.Location = new System.Drawing.Point(4, 25);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(776, 510);
            this.usersTab.TabIndex = 0;
            this.usersTab.Text = "Пользователи";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // studentsTab
            // 
            this.studentsTab.Location = new System.Drawing.Point(4, 25);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.studentsTab.Size = new System.Drawing.Size(776, 510);
            this.studentsTab.TabIndex = 1;
            this.studentsTab.Text = "Ученики";
            this.studentsTab.UseVisualStyleBackColor = true;
            // 
            // teachersTab
            // 
            this.teachersTab.Location = new System.Drawing.Point(4, 25);
            this.teachersTab.Name = "teachersTab";
            this.teachersTab.Padding = new System.Windows.Forms.Padding(3);
            this.teachersTab.Size = new System.Drawing.Size(776, 510);
            this.teachersTab.TabIndex = 2;
            this.teachersTab.Text = "Классное руководство";
            this.teachersTab.UseVisualStyleBackColor = true;
            // 
            // reportsTab
            // 
            this.reportsTab.Location = new System.Drawing.Point(4, 25);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTab.Size = new System.Drawing.Size(776, 510);
            this.reportsTab.TabIndex = 3;
            this.reportsTab.Text = "Отчеты для столовой";
            this.reportsTab.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel salutationLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.TabPage studentsTab;
        private System.Windows.Forms.TabPage teachersTab;
        private System.Windows.Forms.TabPage reportsTab;
    }
}