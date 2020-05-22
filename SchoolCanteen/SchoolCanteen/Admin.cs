using SchoolCanteen.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCanteen
{
    public partial class Admin : Form
    {
        public Admin(string id)
        {
            InitializeComponent();
            //Получаем имя позователя для приветствия
            salutationLabel.Text = DBGate.GetSalutation(Properties.Settings.Default.ConnectionString, id);

            Users users = new Users { Dock = DockStyle.Fill };
            usersTab.Controls.Add(users);

            Students students = new Students { Dock = DockStyle.Fill };
            studentsTab.Controls.Add(students);

            Teachers teachers = new Teachers { Dock = DockStyle.Fill };
            teachersTab.Controls.Add(teachers);

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
