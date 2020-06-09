using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolCanteen
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void LoadedStartForm(object sender, EventArgs e)
        {
            if (DBGate.CheckConnection(Properties.Settings.Default.ConnectionString)) return;
            else
            {
                var result = new DialogResult();
                result = MessageBox.Show("Подключение к базе данных невозможно, т.к. отсутствует корректная строка подключения. Ввести строку подключения вручную?",
                    "Подключение данных невозможно.", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes) GetNewConnectionString(new NewConnection());
                else
                {
                    MessageBox.Show("Дальнейшая работа невозможна, обратитесь к администратору.", "Закрытие программы.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
        }

        private void GetNewConnectionString(NewConnection nc)
        {
            nc.ShowDialog();
            LoadedStartForm(new object(), new EventArgs());
        }

        private void OKClick(object sender, EventArgs e)
        {
            string query = $"select count(*) from Users where login = N'{loginBox.Text}' and password = N'{passwordBox.Text}'";
            if (DBGate.Scalar(Properties.Settings.Default.ConnectionString, query) != "0") RunSpecialForm();
            else { MessageBox.Show("Введенная пара логин-пароль отсутствует в базе данных. Проверьте правильность ввода.", "Ошибка ввода.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void RunSpecialForm()
        {
            string id, role;
            string queryActive = $"select active from Users where login = N'{loginBox.Text}'";
            string queryId = $"select ID from Users where login = N'{loginBox.Text}'";
            string queryRole = $"select role from Users where login = N'{loginBox.Text}'";
            if (DBGate.Scalar(Properties.Settings.Default.ConnectionString, queryActive) != "True")
            {
                MessageBox.Show("Ваша учетная запись заблокирована!"); return;
            }
            id = DBGate.Scalar(Properties.Settings.Default.ConnectionString, queryId);
            role = DBGate.Scalar(Properties.Settings.Default.ConnectionString, queryRole);
            this.Hide();
            switch(role)
            {
                default: 
                    MessageBox.Show("Неизвестная ошибка, обратитесь к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    Environment.Exit(0); 
                    break;
                case "1": new Admin(id).Show(); break;
                case "2": new Worker(id).Show(); break;
                case "3":
                    string query = 
                        $"select count(*) from Teachers where userID = N'{id}'";
                    if (DBGate.Scalar(Properties.Settings.Default.ConnectionString, query) != "0") { new Teacher(id).Show(); break; }
                    else
                    {
                        MessageBox.Show("Вы не являетесь классным руководителем, данный функционал вам не доступен. Обратитесь к администратору, если это не так.");
                        this.Show();
                        break;
                    }
            }
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            { if (e.KeyChar == 13) OKClick(sender, e); }
        }
    }
}
