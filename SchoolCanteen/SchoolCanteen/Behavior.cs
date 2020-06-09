using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCanteen
{
    /// <summary>
    /// Поведение отдельных элементов управления
    /// </summary>
    static class Behavior
    {
        /// <summary>
        /// Подсвечивает зеленым строки в dataGridView, которые содержат символы из searchBox
        /// </summary>
        public static void LightRowsForSearch(DataGridView dataGridView, TextBox searchBox)
        {
            ClearColor(dataGridView);

            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                        if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains(searchBox.Text))
                        {
                            dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        }
            }
            if (searchBox.Text == "") ClearColor(dataGridView);
        }

        /// <summary>
        /// Фильтрует вывод в dataGridView по отдельному столбцу
        /// </summary>
        public static void DelRowsForSearch(DataGridView dataGridView, TextBox searchBox, string header)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataGridView.CurrentCell = null;
                if (dataGridView.Rows[i].Cells[header].Value.ToString() != searchBox.Text) dataGridView.Rows[i].Visible = false;
            }
            if (searchBox.Text == "") ClearColor(dataGridView);
        }

        /// <summary>
        /// Возвращает цвет строк в dataGrigView на стандартный
        /// </summary>
        private static void ClearColor(DataGridView dataGridView1)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.DefaultCellStyle.BackColor = Color.White;
        }

        /// <summary>
        /// Сбрасывает значение searchBox
        /// </summary>
        public static void ResetEnterText(TextBox searchBox)
        {
            if (searchBox.Text == "") { searchBox.Text = "Поиск...";  searchBox.ForeColor = Color.Gray; }
        }

        /// <summary>
        /// Готовит searchBox для ввода
        /// </summary>
        public static void PrepareForEnterText(TextBox searchBox)
        {
            if (searchBox.ForeColor == Color.Gray) { searchBox.Text = ""; searchBox.ForeColor = Color.Black; }
        }
    }
}
