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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void ButtonChart_NVR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChart formChart = new FormChart();
            formChart.Show();
        }

        private void ButtonSuppliers_NVR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSuppliers formSuppliers = new FormSuppliers();
            formSuppliers.Show();
        }

        private void ButtonInfo_NVR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ButtonOpen_NVR_Click(object sender, EventArgs e)
        {
            OpenFileDialogMain_NVR.ShowDialog();
            openFilePath = OpenFileDialogMain_NVR.FileName;

            string[,] matrix = ds.LoadFromDataFile(openFilePath);

            //количество строк и столбцов в массиве matrix
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);


            //количество строк и столбцов
            DataGridViewMain_NVR.RowCount = 150;
            DataGridViewMain_NVR.ColumnCount = 20;

            //ширина столбцов
            for (int i = 0; i < rows; i++)
            {
                DataGridViewMain_NVR.Columns[i].Width = 150;
            }

            //добавление данных
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridViewMain_NVR.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            DataGridViewMain_NVR.ScrollBars = ScrollBars.Both;

        }
    }
}
