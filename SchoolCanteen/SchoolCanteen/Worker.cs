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
    public partial class Worker : Form
    {
        private string id;
        public Worker(string id)
        {
            InitializeComponent();
            this.id = id;
            Start();
        }

        private void Start()
        {
            salutationLabel.Text = DBGate.GetSalutation(Properties.Settings.Default.ConnectionString, id);
            UserControls.Reports reports = new UserControls.Reports(id);
            reports.Dock = DockStyle.Fill;
            this.Controls["panel1"].Controls.Add(reports);
        }

        private void Worker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
