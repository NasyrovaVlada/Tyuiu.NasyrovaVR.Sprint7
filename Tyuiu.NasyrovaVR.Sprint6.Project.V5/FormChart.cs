using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.NasyrovaVR.Sprint6.Project.V5.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void ButtonBackChart_NVR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void ButtonOpenChart_NVR_Click(object sender, EventArgs e)
        {
            OpenFileDialogChart_NVR.ShowDialog();
            openFilePath = OpenFileDialogChart_NVR.FileName;

            string[,] matrix = ds.LoadFromDataFile(openFilePath);

            //количество строк и столбцов в массиве matrix
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);


            //количество строк и столбцов
            DataGridViewChart_NVR.RowCount = 150;
            DataGridViewChart_NVR.ColumnCount = 20;

            //ширина столбцов
            for (int i = 0; i < rows; i++)
            {
                DataGridViewChart_NVR.Columns[i].Width = 150;
            }

            //добавление данных
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridViewChart_NVR.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            DataGridViewChart_NVR.ScrollBars = ScrollBars.Both;
        }

        private void ComboBoxChart_NVR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = ComboBoxChart_NVR.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox

            foreach (DataGridViewRow row in DataGridViewChart_NVR.Rows)
            {
                if (!row.IsNewRow) // проверка новая ли строка
                {
                    if (row.Cells["CategoryCh"].Value != null && row.Cells["CategoryCh"].Value.ToString() == valueFilt)
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

        private void ButtonDoneChart_NVR_Click(object sender, EventArgs e)
        {
            
        }
    }
}
