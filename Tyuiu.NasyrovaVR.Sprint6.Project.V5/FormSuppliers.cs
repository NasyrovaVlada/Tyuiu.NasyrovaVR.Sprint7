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
            OpenFileDialogSuppliers_NVR.ShowDialog();
            openFilePath = OpenFileDialogSuppliers_NVR.FileName;

            string[,] matrix = ds.LoadFromDataFile(openFilePath);

            //количество строк и столбцов в массиве matrix
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);


            //количество строк и столбцов
            DataGridViewSuppliers_NVR.RowCount = 150;
            DataGridViewSuppliers_NVR.ColumnCount = 20;

            //ширина столбцов
            for (int i = 0; i < rows; i++)
            {
                DataGridViewSuppliers_NVR.Columns[i].Width = 150;
            }

            //добавление данных
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    DataGridViewSuppliers_NVR.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            DataGridViewSuppliers_NVR.ScrollBars = ScrollBars.Both;
        }
    }
}
