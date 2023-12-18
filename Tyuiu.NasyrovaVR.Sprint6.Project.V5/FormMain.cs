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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    public partial class FormMain : Form
    {
        private DataView originalDataView;
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

        private void TextBoxSearch_NVR_TextChanged(object sender, EventArgs e)
        {
            string searchText = TextBoxSearch_NVR.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in DataGridViewMain_NVR.Rows)
            {
                if (row.Cells["DataName"].Value != null && row.Cells["Code"].Value != null)
                {
                    string column1Text = row.Cells["DataName"].Value.ToString().ToLower();
                    string column2Text = row.Cells["Code"].Value.ToString().ToLower();
                    string column3Text = row.Cells["Category"].Value.ToString().ToLower();

                    if (column1Text.Contains(searchText) || column2Text.Contains(searchText))
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

        private void ComboBoxFilt_NVR_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = ComboBoxFilt_NVR.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox

            foreach (DataGridViewRow row in DataGridViewMain_NVR.Rows)
            {
                if (!row.IsNewRow) // проверка новая ли строка
                {
                    if (row.Cells["Category"].Value != null && row.Cells["Category"].Value.ToString() == valueFilt)
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

       

        private void ComboBoxSort_NVR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort_NVR.SelectedItem != null) 
            {
                int columnIndex = 4; 

                foreach (DataGridViewRow row in DataGridViewMain_NVR.Rows)
                {
                    int cellValue;
                    if (row.Cells[columnIndex].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }

                }

                DataGridViewColumn column = DataGridViewMain_NVR.Columns[4];
                string selectedItem = ComboBoxSort_NVR.SelectedItem.ToString();

                if (selectedItem == "Max")
                {
                    DataGridViewMain_NVR.Sort(column, ListSortDirection.Ascending); //поменять
                }
                else if (selectedItem == "Min")
                {
                    DataGridViewMain_NVR.Sort(column, ListSortDirection.Descending); 
                }
            }

        }
    }
}
