using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SchoolCanteen.UserControls
{
    public partial class Reports : UserControl
    {
        class CheckBoxListItem
        {
            private string text;
            private string year;
            private string count;

            public CheckBoxListItem(string year, string text, string count)
            {
                Year = year;
                Text = text;
                Count = count;
            }

            public string Year { get => year; set => year = value; }
            public string Text { get => text; set => text = value; }
            public string Count { get => count; set => count = value; }
            public override string ToString() { return Text; }
        }

        private string id;
        public Reports(string id)
        {
            InitializeComponent();
            this.id = id;
            Start();
        }

        void Start() 
        { 
            SetClassesListItems();
            GetFileExists();
        }

        void SetClassesListItems()
        {
            classes.Items.Clear();
            for (int i = 1; i <= 11; i++) { classes.Items.Add(GetClassesItem(i.ToString())); }
        }

        CheckBoxListItem GetClassesItem(string year)
        {
            string count = DBGate.Scalar(Properties.Settings.Default.ConnectionString, $"select count(*) from Students where year = '{year}'");
            return new CheckBoxListItem(year, year + "-е классы", count);
        }

        private void createReport_Click(object sender, EventArgs e)
        {
            if(classes.CheckedItems.Count != 0)
            {
                PreviewReports preview = new PreviewReports(GetReport());
                preview.ShowDialog();
                if (preview.DialogResult == DialogResult.OK) { SetNewPaySumm(); SaveFile(preview); Start(); }
            }
            else { MessageBox.Show("Нужно выбрать классы.\r\nНельзя создать пустой отчет.", "Ошибка"); }
        }

        void SetNewPaySumm()
        {
            string query = "";
            foreach(CheckBoxListItem item in classes.CheckedItems)
            {
                query = $"update Students set paySumm = paySumm + {numericUpDown1.Value} where year = '{item.Year}'";
                DBGate.NonQuery(Properties.Settings.Default.ConnectionString, query);
            }
        }

        void SaveFile(PreviewReports preview)
        {
            try
            {
                string fileCSV = "";
                for (int i = 0; i < (preview.Controls["dataGridView1"] as DataGridView).RowCount - 1; i++)
                {
                    for (int j = 0; j < (preview.Controls["dataGridView1"] as DataGridView).ColumnCount; j++)
                    {
                        fileCSV += ((preview.Controls["dataGridView1"] as DataGridView)[j, i].Value).ToString() + ";";
                    }
                    fileCSV += "\t\n";
                }

                if (!Directory.Exists("reports")) { Directory.CreateDirectory("reports"); }

                StreamWriter wr = new StreamWriter($"reports\\{DateTime.Today.Day}.{DateTime.Today.Month}.{DateTime.Today.Year}_" +
                    $"{DateTime.Now.TimeOfDay.ToString().Substring(0, 2)}-{DateTime.Now.TimeOfDay.ToString().Substring(3, 2)}-{DateTime.Now.TimeOfDay.ToString().Substring(6, 2)}.csv",
                    false,
                    Encoding.GetEncoding("windows-1251"));
                wr.Write(fileCSV);
                wr.Close();
            }
            catch (IOException ex) { MessageBox.Show(ex.Message, "Ошибка ввода-вывода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private List<ReportRow> GetReport()
        {
            List<ReportRow> report = new List<ReportRow>();

            report.Add(new ReportRow());
            report.Add(new ReportRow(
                "Дата: ", $"{DateTime.Today.Day}.{DateTime.Today.Month}.{DateTime.Today.Year}", ""
                ));
            report.Add(new ReportRow(
                "Время: ", $"{DateTime.Now.TimeOfDay.ToString().Substring(0, 8)}", ""
                ));
            report.Add(new ReportRow(
                "Логин сотрудника:", DBGate.GetLoginUser(Properties.Settings.Default.ConnectionString, id), ""
                ));
            report.Add(new ReportRow(
                "Имя сотрудника:", DBGate.GetNameUser(Properties.Settings.Default.ConnectionString, id), ""
                ));

            report.Add(new ReportRow());
            report.Add(new ReportRow("Параллель", "Количество учеников", "Общая сумма (руб.)"));

            int fullCount = 0;
            int fullSumm = 0;

            foreach (CheckBoxListItem item in classes.CheckedItems)
            {
                report.Add(new ReportRow(
                    item.Year, item.Count, $"{Convert.ToInt32(item.Count) * numericUpDown1.Value}"
                    ));
                fullCount += Convert.ToInt32(item.Count);
                fullSumm += Convert.ToInt32(item.Count) * Convert.ToInt32(numericUpDown1.Value);
            }

            report.Add(new ReportRow());
            report.Add(new ReportRow("Итого:", fullCount.ToString(), fullSumm.ToString()));
            report.Add(new ReportRow());

            return report;
        }

        void GetFileExists()
        {
            try
            {
                if (!Directory.Exists("reports")) { Directory.CreateDirectory("reports"); }
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Directory.GetFiles("reports", "*.csv", SearchOption.TopDirectoryOnly));
            }
            catch (IOException ex) { MessageBox.Show(ex.Message, "Ошибка ввода-вывода", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (File.Exists(listBox1.SelectedItem.ToString()))
                    new ShowCsvFile(listBox1.SelectedItem.ToString()).ShowDialog();
                else GetFileExists();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                try
                {
                    if (File.Exists(listBox1.SelectedItem.ToString()))
                    {
                        DialogResult dr = new DialogResult();
                        dr = MessageBox.Show("Вы уверены что хотите удалить отчет?", "Необратимое действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes) File.Delete(listBox1.SelectedItem.ToString());
                    }
                    GetFileExists();
                }
                catch(IOException ex) 
                { 
                    MessageBox.Show(ex.Message, "Ошибка ввода-вывода", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }
    }
}
