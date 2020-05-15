using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCanteen
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            string query = "select name from Roles";
            roleBox.DataSource = DBGate.GetColumnFromDB(Properties.Settings.Default.ConnectionString, query);
        }

        private void OKClick(object sender, EventArgs e)
        {
            if (loginBox.Text != "" & passwordBox.Text != "" & nameBox.Text != "" & roleBox.SelectedIndex >= 0)
            if (InsertNewRow()) { this.DialogResult = DialogResult.OK; this.Close(); }
        }

        private bool InsertNewRow()
        {
            string query = 
                $"insert into Users (login, password, name, role) " +
                $"values('{loginBox.Text}', '{passwordBox.Text}', '{nameBox.Text}', {roleBox.SelectedIndex + 1})";
            Exception result = DBGate.NonQuery(Properties.Settings.Default.ConnectionString, query);
            if (result != null) 
            { MessageBox.Show(
                $"Критическая ошибка при добавлении. \r\nВведенное имя пользователя уже занято.",
                "Ошибка", 
                MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            return true;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) OKClick(sender, e);
        }
    }
}
