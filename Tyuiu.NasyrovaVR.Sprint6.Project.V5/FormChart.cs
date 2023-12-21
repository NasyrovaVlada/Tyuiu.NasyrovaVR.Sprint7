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
            try
            {
                OpenFileDialogChart_NVR.ShowDialog();
                openFilePath = OpenFileDialogChart_NVR.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                DataGridViewChart_NVR.RowCount = rows+1;
                DataGridViewChart_NVR.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataGridViewChart_NVR.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                DataGridViewChart_NVR.AutoResizeColumns();
                DataGridViewChart_NVR.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                this.Chart_NVR.ChartAreas[1].AxisX.Title = "Название продукта";
                this.Chart_NVR.ChartAreas[4].AxisY.Title = "Стоимость продукта";
                Chart_NVR.Series.Clear();

                // новая серия данных для диаграммы
                Chart_NVR.Series.Add("DataSeries");
                Chart_NVR.Series["DataSeries"].ChartType = SeriesChartType.Column; // колоночная диаграмма

                foreach (DataGridViewRow row in DataGridViewChart_NVR.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[4].Value != null)
                    {
                        if (row.Visible)
                        {
                            string labelOne = row.Cells[1].Value.ToString();
                            int valueFour = Convert.ToInt32(row.Cells[4].Value);

                            // добавление данных в серию для диаграммы
                            Chart_NVR.Series["DataSeries"].Points.AddXY(labelOne, valueFour);
                        }
                    }
                }

                Chart_NVR.Update();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonReturnChart_NVR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewChart_NVR.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
