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
    public partial class Students : UserControl
    {
        public Students()
        {
            InitializeComponent();
            Start();
        }
        private void Start()
        {
            searchBox.TextChanged += (s, a) => Behavior.LightRowsForSearch(dataGridView1, searchBox);
            searchBox.Enter += (s, a) => Behavior.PrepareForEnterText(searchBox);
            searchBox.Leave += (s, a) => Behavior.ResetEnterText(searchBox);
            searchButton.Click += (s, a) => Behavior.DelRowsForSearch(dataGridView1, searchBox, comboBox1.Text);

            Behavior.ResetEnterText(searchBox);
            string query = "select ID as 'ID', " +
                "name as 'Имя', " +
                "birth as 'Дата рождения', " +
                "year as 'Год обучения', " +
                "(select name from Classes where Classes.ID = Students.class) as 'Класс', " +
                "paySumm as 'Задолженность', " +
                "activeFlag as 'Питание' " +
                "from Students " +
                "where year <> 12";
            DataSet ds = DBGate.GetFilledDataSet(Properties.Settings.Default.ConnectionString, query);
            dataGridView1.DataSource = ds.Tables[0];

            comboBox1.Items.Clear();
            for (int i = 0; i < dataGridView1.ColumnCount; i++) { comboBox1.Items.Add(dataGridView1.Columns[i].HeaderText); }
            comboBox1.SelectedIndex = 1;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                selectedStudent.Text = $"{dataGridView1.SelectedRows[0].Cells[1].Value.ToString()}, " +
                $"{dataGridView1.SelectedRows[0].Cells[3].Value.ToString() + dataGridView1.SelectedRows[0].Cells[4].Value.ToString()}";
            }
        }

        private void cencelSearchButton_Click(object sender, EventArgs e)
        {
            Start();
            searchBox.Text = "";
            Behavior.ResetEnterText(searchBox);
        }

        private void deleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(
                $"Вы уверены в том, что " +
                $"{dataGridView1.SelectedRows[0].Cells[1].Value}" +
                $" больше не учится в образовательном учреждении? Это действие необратимо.",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows[0] != null)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    DBGate.NonQuery(Properties.Settings.Default.ConnectionString,
                            $"update Students set year = 12 where ID = {dataGridView1.SelectedRows[0].Cells[0].Value}");
                    Start();
                    dataGridView1.Rows[index].Selected = true;
                }
            }
        }

        private void activator_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool isTrue = (bool)dataGridView1.SelectedRows[0].Cells[6].Value;
                DBGate.NonQuery(Properties.Settings.Default.ConnectionString,
                        $"update Students set activeFlag = {Convert.ToByte(!isTrue)} where ID = {dataGridView1.SelectedRows[0].Cells[0].Value}");
                Start();
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool isTrue = (bool)dataGridView1.SelectedRows[0].Cells[6].Value;
                DBGate.NonQuery(Properties.Settings.Default.ConnectionString,
                        $"update Students set paySumm = {Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value) - Convert.ToInt32(paySumm.Value)} where ID = {dataGridView1.SelectedRows[0].Cells[0].Value}");
                Start();
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            new AddStudent().ShowDialog();
            Start();
        }
    }
}
