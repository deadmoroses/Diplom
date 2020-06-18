using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCanteen.UserControls
{
    public partial class Teachers : UserControl
    {
        public Teachers()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            searchBox.TextChanged += (s, a) => Behavior.LightRowsForSearch(dataGridView1, searchBox);
            searchBox.Enter += (s, a) => Behavior.PrepareForEnterText(searchBox);
            searchBox.Leave += (s, a) => Behavior.ResetEnterText(searchBox);

            teacherBox.DataSource = DBGate.GetColumnFromDB(Properties.Settings.Default.ConnectionString, "select login from Users where role = 3");
            yearBox.DataSource = DBGate.GetColumnFromDB(Properties.Settings.Default.ConnectionString, "select name from Years where ID <> '12'");
            classBox.DataSource = DBGate.GetColumnFromDB(Properties.Settings.Default.ConnectionString, "select name from Classes");
            teachersList.DataSource = DBGate.GetColumnFromDB(Properties.Settings.Default.ConnectionString, 
                "select login from Users where role = '3' and (select count (*) from Teachers where Teachers.userID = Users.ID) = 0");

            string query = 
                "select " +
                "ID as 'ID', " +
                "(select login from Users where Users.ID = Teachers.userID) as 'Логин', " +
                "(select name from Users where Users.ID = Teachers.userID) as 'Имя', " +
                "yearID as 'Год', " +
                "(select name from Classes where Classes.ID = Teachers.classID) as 'Класс' " +
                "from Teachers";
            DataSet ds = DBGate.GetFilledDataSet(Properties.Settings.Default.ConnectionString, query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string query = $"select ID from Users where login = '{teacherBox.Text}'";
            string teacherID = DBGate.Scalar(Properties.Settings.Default.ConnectionString, query);

            query = $"select ID from Classes where name = '{classBox.Text}'";
            string classID = DBGate.Scalar(Properties.Settings.Default.ConnectionString, query);

            if (CheckEnter(teacherID, classID))
                InsertNewRow(teacherID, classID);
            else MessageBox.Show("Добавление невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Start();
        }

        private bool CheckEnter(string teacherID, string classID)
        {
            if (IsTeacherExist(teacherID))
            {
                string currentClass = "";
                string query = $"select yearID from Teachers where userID = '{teacherID}'";
                currentClass += DBGate.Scalar(Properties.Settings.Default.ConnectionString, query);
                query = $"select name from Classes where ID = (select classID from Teachers where userID = '{teacherID}')";
                currentClass += DBGate.Scalar(Properties.Settings.Default.ConnectionString, query);
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(
                    "Этот преподаватель уже умеет классное руководство в " +
                    $"{currentClass}.\r\n" +
                    "Каждый преподаватель может вести только один класс. \r\n" +
                    "Удалить существующую запись? (текущий класс останется без руководителя)", 
                    "Запись существует", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    query = $"delete from Teachers where userID = '{teacherID}'";
                    DBGate.NonQuery(Properties.Settings.Default.ConnectionString, query);
                }
                else return false;
            }
            if (IsClassExist(classID))
            {
                string currentTeacher = "";
                string query = $"select (select login from Users where ID = Teachers.userID), userID from Teachers where classID = '{classID}' and yearID = '{yearBox.Text}'";
                currentTeacher = DBGate.Scalar(Properties.Settings.Default.ConnectionString, query);
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(
                    "У выбранного класса уже есть классный руководитель, это " +
                    $"{currentTeacher}\r\n" +
                    "Удалить существующую запись?",
                    "Запись существует",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                    );
                if (dr == DialogResult.Yes)
                {
                    query = $"delete from Teachers where classID = '{classID}' and yearID = '{yearBox.Text}'";
                    DBGate.NonQuery(Properties.Settings.Default.ConnectionString, query);
                }
                else return false;
            }
            return true;
        }
        private bool IsTeacherExist(string teacherID)
        {
            string query = $"select count(*) from Teachers where userID = '{teacherID}'";
            if (Convert.ToInt32(DBGate.Scalar(Properties.Settings.Default.ConnectionString, query)) > 0) return true;
            else return false;
        }

        private bool IsClassExist(string classID)
        {
            string query = $"select count(*) from Teachers where classID = '{classID}' and yearID = '{yearBox.Text}'";
            if (Convert.ToInt32(DBGate.Scalar(Properties.Settings.Default.ConnectionString, query)) > 0) return true;
            else return false;
        }

        private bool InsertNewRow(string teacherID, string classID)
        {
            string query =
                $"insert into Teachers (userID, yearID, classID) " +
                $"values('{teacherID}', '{yearBox.Text}', '{classID}')";
            Exception result = DBGate.NonQuery(Properties.Settings.Default.ConnectionString, query);
            if (result != null)
            {
                MessageBox.Show(
                  $"Ошибка при добавлении.\r\n" +
                  $"{result.Message}",
                  "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            return true;
        }

        private void deleteCurrentRow_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"delete from Teachers where ID = '{dataGridView1.CurrentRow.Cells[0].Value.ToString()}'";
                DBGate.NonQuery(Properties.Settings.Default.ConnectionString, query);
                Start();
            }
            catch { }
        }
    }
}
