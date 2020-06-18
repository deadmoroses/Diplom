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
    public partial class ShowCsvFile : Form
    {
        private string filename;
        private Data data;
        private DataGridView dgv;

        public ShowCsvFile(string filename)
        {
            InitializeComponent();

            this.filename = filename;

            dgv = new DataGridView { Parent = this, VirtualMode = true, AllowUserToAddRows = false, Dock = DockStyle.Fill };
            dgv.BackgroundColor = Color.White;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ReadOnly = true;
            dgv.CellValueNeeded += dgv_CellValueNeeded;
            dgv.CellValuePushed += dgv_CellValuePushed;

                data = OpenFile(filename);
                BuildGrid();
        }

        void dgv_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (data == null) return;
            if (e.ColumnIndex >= data.ColumnNames.Count || e.ColumnIndex < 0 || e.RowIndex >= data.Count) return;

            data[e.RowIndex].Items[e.ColumnIndex] = e.Value.ToString();
        }

        void dgv_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (data == null) return;
            if (e.ColumnIndex >= data.ColumnNames.Count || e.ColumnIndex < 0 || e.RowIndex >= data.Count) return;

            e.Value = data[e.RowIndex].Items[e.ColumnIndex];
        }

        private Data OpenFile(string fileName)
        {
            var parser = new CsvParser() { Separator = ';' };
            parser.Parse(fileName, Encoding.Default);
            var data = new Data();
            data.AddRange(parser.Rows.Select(r => new DataRow { Items = r }));
            data.ColumnNames = parser.ColumnNames;

            return data;
        }

        void BuildGrid()
        {
            dgv.ColumnCount = data.ColumnNames.Count;
            for (int i = 0; i < data.ColumnNames.Count; i++)
                dgv.Columns[i].Name = data.ColumnNames[i];

            dgv.RowCount = 0;
            dgv.RowCount = data.Count;
            dgv.Invalidate();
        }
    }

    /// <summary>
    /// Данные
    /// </summary>
    public class Data : List<DataRow>
    {
        public List<string> ColumnNames;
    }

    /// <summary>
    /// Строка данных
    /// </summary>
    public class DataRow
    {
        public List<string> Items;
    }
}
