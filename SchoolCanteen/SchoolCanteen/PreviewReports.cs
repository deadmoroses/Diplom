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
    public partial class PreviewReports : Form
    {
        public PreviewReports(List<ReportRow> report)
        {
            InitializeComponent();
            button1.Click += (e, a) => this.DialogResult = DialogResult.OK; 
            button2.Click += (e, a) => this.DialogResult = DialogResult.Cancel;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "A", HeaderText = "" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "B", HeaderText = "" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "C", HeaderText = "" });

            dataGridView1.DataSource = report;
        }
    }
}
