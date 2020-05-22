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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();

        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            string query = "select name from Classes";
            classBox.DataSource = DBGate.GetColumnFromDB(Properties.Settings.Default.ConnectionString, query);
            query = "select name from Years where ID <> '12'";
            yearBox.DataSource = DBGate.GetColumnFromDB(Properties.Settings.Default.ConnectionString, query);
        }

        private bool InsertNewRow()
        {
            string query = 
                $"insert into Students (name, birth, year, class) " +
                $"values('{nameBox.Text}', '{birthPicker.Value.ToString()}', '{yearBox.SelectedIndex + 1}', {classBox.SelectedIndex + 1})";
            Exception result = DBGate.NonQuery(Properties.Settings.Default.ConnectionString, query);
            if (result != null) 
            { MessageBox.Show(
                $"Критическая ошибка при добавлении." + result.Message,
                "Ошибка", 
                MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            return true;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) saveOnDb_Click(sender, e);
        }

        private void saveOnDb_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "" & birthPicker.Value.Year < DateTime.Today.Year - 6)
            {
                InsertNewRow();
                this.Close();
            }
            else MessageBox.Show("Необходимо ввести корректные данные!");
        }
    }
}
