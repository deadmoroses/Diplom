using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolCanteen.UserControls
{
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Start()
        {
            Behavior.ResetEnterText(searchBox);
            string query = "select ID as 'ID', " +
                "login as 'Логин', " +
                "password as 'Пароль', " +
                "name as 'Имя', " +
                "(select name from Roles where Roles.ID = Users.role) as 'Роль', " +
                "active as 'Статус учетной записи' " +
                "from Users";
            DataSet ds = DBGate.GetFilledDataSet(Properties.Settings.Default.ConnectionString, query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Start();
            dataGridView1.Rows[0].Selected = true;
            nameBox.Enabled = false;
            passwordBox.Enabled = false;
            userEditor.Enabled = false;
        }

        private void Search(object sender, EventArgs e)
        {
            Behavior.LightRowsForSearch(dataGridView1, searchBox);
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            Behavior.PrepareForEnterText(searchBox);
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            Behavior.ResetEnterText(searchBox);
        }

        private void ActivatorClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool isTrue = (bool)dataGridView1.SelectedRows[0].Cells[5].Value;
                DBGate.NonQuery(Properties.Settings.Default.ConnectionString,
                        $"update Users set active = {Convert.ToByte(!isTrue)} where ID = {dataGridView1.SelectedRows[0].Cells[0].Value}");
                Start();
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void EditUser(object sender, EventArgs e)
        {
            int index = dataGridView1.SelectedRows[0].Index;

            if (passwordBox.Text != "")
            {
                string name = nameBox.Text;
                if (nameBox.Text == "") name = "Имя не указано";
                DBGate.NonQuery(Properties.Settings.Default.ConnectionString,
                        $"update Users set password = '{passwordBox.Text}', name = '{name}' where ID = {idBox.Text}");
            }
            else MessageBox.Show("Пароль не может быть пустым.", "Ошибка ввода.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Start();
            dataGridView1.Rows[index].Selected = true;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nameBox.Enabled = true;
                passwordBox.Enabled = true;
                userEditor.Enabled = true;

                if (dataGridView1.SelectedRows[0] != null)
                {
                    idBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    loginBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    passwordBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    nameBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    roleBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            DialogResult dr = new AddUser().ShowDialog();
            if (dr == DialogResult.OK) Start();
        }
    }
}
