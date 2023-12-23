using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string[,] gridData;

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
        private void ButtonHelp_NVR_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void ButtonOpen_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialogMain_NVR.ShowDialog();
                openFilePath = OpenFileDialogMain_NVR.FileName;

                gridData = ds.LoadFromDataFile(openFilePath);

                rows = gridData.GetLength(0);
                columns = gridData.GetLength(1);

                DataGridViewMain_NVR.RowCount = rows+1;
                DataGridViewMain_NVR.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataGridViewMain_NVR.Rows[i].Cells[j].Value = gridData[i, j];
                    }
                }
                DataGridViewMain_NVR.AutoResizeColumns();
                DataGridViewMain_NVR.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSave_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialogMain_NVR.FileName = ".csv";
                SaveFileDialogMain_NVR.InitialDirectory = @":L";
                if (SaveFileDialogMain_NVR.ShowDialog() == DialogResult.OK)
                {
                    string savepath = SaveFileDialogMain_NVR.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);
                    int rows = gridData.GetLength(0);
                    int columns = gridData.GetLength(1);

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(gridData[i, j]);

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

        private void TextBoxSearch_NVR_TextChanged(object sender, EventArgs e)
        {
            string searchText = TextBoxSearch_NVR.Text.ToLower(); //приведение к нижнему регистру
            for (int i = 0; i < DataGridViewMain_NVR.Rows.Count; i++)
            {
                // Проверяем, есть ли данные в массиве gridData для текущей строки
                if (gridData.GetLength(0) > i && gridData.GetLength(1) >= 3)
                {
                    if (DataGridViewMain_NVR.Rows[i].Visible)
                    {
                        string column1Text = gridData[i, 0].ToLower();
                        string column2Text = gridData[i, 1].ToLower();
                        string column3Text = gridData[i, 2].ToLower();

                        if (column1Text.Contains(searchText) || column2Text.Contains(searchText) || column3Text.Contains(searchText))
                        {
                            DataGridViewMain_NVR.Rows[i].Visible = true;
                        }
                        else
                        {
                            DataGridViewMain_NVR.Rows[i].Visible = false;
                        }
                    }
                }
            }
        }

        private void ButtonSum_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                int visibleRowCount = 0;
                double[] values = new double[rows]; 

                for (int i = 0; i < rows; i++)
                {
                    if (DataGridViewMain_NVR.Rows[i].Visible)
                    {
                        double cellValue;
                        if (double.TryParse(gridData[i, 3], out cellValue))
                        {
                            values[visibleRowCount] = cellValue;
                            visibleRowCount++;
                        }
                    }
                }

                if (visibleRowCount > 0)
                {
                    double res = ds.CalculateSum(values);
                    TextBoxSum_NVR.Text = Math.Round(res, 2).ToString();
                }
                else
                {
                    TextBoxSum_NVR.Text = "Нет данных для подсчета";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAverage_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                int visibleRowCount = 0;
                double sumVisibleValues = 0;
                double[] valuesAv = new double[rows];
               
                for (int i = 0; i < rows; i++)
                {
                    if (DataGridViewMain_NVR.Rows[i].Visible)
                    {
                        double valuesAverage;
                        if (double.TryParse(gridData[i, 4], out valuesAverage))
                        {
                            valuesAv[visibleRowCount] = valuesAverage;
                            sumVisibleValues += valuesAverage;
                            visibleRowCount++;
                        }
                    }
                }
                
                if (visibleRowCount > 0)
                {
                    double average = ds.CalculateAverage(valuesAv, visibleRowCount);
                    TextBoxAverage_NVR.Text = Math.Round(average, 2).ToString();
                }
                else
                {
                    TextBoxAverage_NVR.Text = "Нет данных для подсчета";
                }
               
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDelete_NVR_Click(object sender, EventArgs e)
        {
            if (DataGridViewMain_NVR.RowCount != 0)
            {
                if (DataGridViewMain_NVR.RowCount != 0)
                {
                    int valueDel = 0;
                    var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes) valueDel = 1;
                    if (valueDel == 1)
                    {
                        int del = DataGridViewMain_NVR.CurrentCell.RowIndex;
                        DataGridViewMain_NVR.Rows.Remove(DataGridViewMain_NVR.Rows[del]);
                    }
                }
                else
                {
                    MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonAdd_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewMain_NVR.Rows.Add();

            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxFilt_NVR_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string valueFilt = ComboBoxFilt_NVR.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
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
                        if (valueFilt == "Все")
                        {
                            row.Visible = true;
                        }
                    }
                }
            }
        }

        private void ComboBoxSort_NVR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort_NVR.SelectedItem != null)
            {
                int columnIndex = 3;
                string selectedItem = ComboBoxSort_NVR.SelectedItem.ToString();
                bool empty = false;

                for (int i = 0; i < DataGridViewMain_NVR.Rows.Count - 1; i++) // исключение последней строки
                {
                    if (DataGridViewMain_NVR.Rows[i].Cells[columnIndex].Value == null ||
                        string.IsNullOrWhiteSpace(DataGridViewMain_NVR.Rows[i].Cells[columnIndex].Value.ToString()))
                    {
                        empty = true;
                        break; // если есть пустая - выход из цикла
                    }
                }

                if (empty)
                {
                    MessageBox.Show("Удалите пустые строки (кроме последней)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // прерывает выполнение
                }

                foreach (DataGridViewRow row in DataGridViewMain_NVR.Rows)
                {
                    double cellValue;
                    if (row.Cells[columnIndex].Value != null && double.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }
                }
                try
                {
                    DataGridViewColumn column = DataGridViewMain_NVR.Columns[3];

                    if (selectedItem == "All")
                    {
                        int rows = gridData.GetLength(0);
                        int columns = gridData.GetLength(1);
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                DataGridViewMain_NVR.Rows[i].Cells[j].Value = gridData[i, j];
                            }
                            DataGridViewMain_NVR.Rows[i].Visible = true;
                        }
                        return; // Выход из метода, так как "All" не требует сортировки
                    }
                    if (selectedItem == "Min")
                    {
                        DataGridViewMain_NVR.Sort(column, ListSortDirection.Ascending);
                    }
                    if (selectedItem == "Max")
                    {
                        DataGridViewMain_NVR.Sort(column, ListSortDirection.Descending);
                    }

                }
                catch
                {
                    MessageBox.Show("Невозможно выполнить сортировку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataGridViewMain_NVR_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 3) 
            {
                if (e.Value != null)
                {
                    double cellValue = 0.0;
                    if (double.TryParse(e.Value.ToString(), out cellValue))
                    {
                        e.ParsingApplied = true; // сообщает элементу управления, что конвертация выполнена и ее необходимо применить к значению ячейки
                        e.Value = cellValue;
                    }
                }
            }
        }

        private void ButtonMin_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                int columnIndex = 4;
                bool foundValue = false;
                double minValue = double.MaxValue; // Инициализация переменной минимального значения большим числом

                for (int i = 0; i < rows; i++) // Проходим по строкам массива gridData
                {
                    if (DataGridViewMain_NVR.Rows[i].Visible)
                    {
                        if (!string.IsNullOrWhiteSpace(gridData[i, columnIndex])) // Проверяем, что ячейка не пустая
                        {
                            double currentValue;
                            if (double.TryParse(gridData[i, columnIndex], out currentValue)) // Пробуем преобразовать значение ячейки в число
                            {
                                foundValue = true; // Устанавливаем флаг, что были найдены действительные значения
                                if (currentValue < minValue) // Если текущее значение меньше минимального, обновляем минимальное значение
                                {
                                    minValue = currentValue;
                                }
                            }
                        }
                    }
                }

                if (foundValue) // Если были найдены действительные значения
                {
                    TextBoxMin_NVR.Text = minValue.ToString();
                }
                else
                {
                    TextBoxMin_NVR.Text = "Нет данных для нахождения минимума";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMax_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                double[] values = new double[gridData.GetLength(0)];

                for (int i = 0; i < gridData.GetLength(0); i++)
                {
                    if (DataGridViewMain_NVR.Rows[i].Visible)
                    {
                        double valuesMax;
                        if (double.TryParse(gridData[i, 4], out valuesMax))
                        {
                            values[i] = valuesMax;
                        }
                    }
                }
                double max = ds.FindMaximumValue(values);
                TextBoxMax_NVR.Text = max.ToString();
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить действие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

