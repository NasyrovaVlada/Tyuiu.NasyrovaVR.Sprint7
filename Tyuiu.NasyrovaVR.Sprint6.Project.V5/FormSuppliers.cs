using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NasyrovaVR.Sprint6.Project.V5.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void ButtonBackSuppliers_NVR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void ButtonOpenSuppliers_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialogSuppliers_NVR.ShowDialog();
                openFilePath = OpenFileDialogSuppliers_NVR.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                DataGridViewSuppliers_NVR.RowCount = rows;
                DataGridViewSuppliers_NVR.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataGridViewSuppliers_NVR.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                DataGridViewSuppliers_NVR.AutoResizeColumns();
                DataGridViewSuppliers_NVR.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxFiltSuppliers_NVR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValueSuppliers = ComboBoxFiltSuppliers_NVR.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox

            foreach (DataGridViewRow row in DataGridViewSuppliers_NVR.Rows)
            {
                if (!row.IsNewRow) // проверка новая ли строка
                {
                    if (row.Cells["MonthS"].Value != null && row.Cells["MonthS"].Value.ToString() == selectedValueSuppliers)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void ButtonReturnSuppliers_NVR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewSuppliers_NVR.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
