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
    public partial class NewConnection : Form
    {
        public NewConnection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DBGate.CheckConnection(textBox1.Text)) MessageBox.Show("Успешно!");
            else MessageBox.Show("Подключение невозможно. Проверьте правильность ввода.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = textBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
