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
using System.IO;
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
            string valueFilt = ComboBoxChart_NVR.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента

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
                    if (valueFilt == "Все")
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void ButtonDoneChart_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                
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
                            double valueFour = Convert.ToDouble(row.Cells[4].Value);

                            // добавление данных в серию 
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

        private void ButtonSave_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialogChart_NVR.FileName = ".csv";
                SaveFileDialogChart_NVR.InitialDirectory = @":L";
                if (SaveFileDialogChart_NVR.ShowDialog() == DialogResult.OK)
                {
                    string savepath = SaveFileDialogChart_NVR.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = DataGridViewChart_NVR.RowCount;
                    int columns = DataGridViewChart_NVR.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(DataGridViewChart_NVR.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonChartAdd_NVR_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataGridViewChart_NVR.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDelete_NVR_Click(object sender, EventArgs e)
        {

            if (DataGridViewChart_NVR.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = DataGridViewChart_NVR.CurrentCell.RowIndex;
                    DataGridViewChart_NVR.Rows.Remove(DataGridViewChart_NVR.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
