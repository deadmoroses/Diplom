using SchoolCanteen.UserControls;
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
    public partial class Teacher : Form
    {
        public Teacher(string id)
        {
            InitializeComponent();
            //Получаем имя позователя для приветствия
            salutationLabel.Text = DBGate.GetSalutation(Properties.Settings.Default.ConnectionString, id);

            Students students = new Students { Dock = DockStyle.Fill };
            string yearID = DBGate.Scalar(Properties.Settings.Default.ConnectionString, $"select yearID from Teachers where userID = {id}");
            string classID = DBGate.Scalar(Properties.Settings.Default.ConnectionString, $"select classID from Teachers where userID = {id}");
            students.query =
                "select ID as 'ID', " +
                "name as 'Имя', " +
                "birth as 'Дата рождения', " +
                "year as 'Год обучения', " +
                "(select name from Classes where Classes.ID = Students.class) as 'Класс', " +
                "paySumm as 'Задолженность', " +
                "activeFlag as 'Питание' " +
                "from Students " +
                $"where year = {yearID} and class = {classID}";
            students.Controls["panel4"].Controls["addUser"].Enabled = false;
            students.Controls["panel1"].Controls["deleteStudent"].Enabled = false;
            students.Start();
            ClassPage.Controls.Add(students);
        }

        private void Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
