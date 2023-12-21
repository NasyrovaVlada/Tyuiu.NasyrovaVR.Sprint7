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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                DataGridViewMain_NVR.RowCount = rows+1;
                DataGridViewMain_NVR.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        DataGridViewMain_NVR.Rows[i].Cells[j].Value = matrix[i, j];
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

                    int rows = DataGridViewMain_NVR.RowCount;
                    int columns = DataGridViewMain_NVR.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(DataGridViewMain_NVR.Rows[i].Cells[j].Value);

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

        }

        private void ButtonSum_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in DataGridViewMain_NVR.Rows)
                {
                    if (row.Visible)
                    {
                        int[] values = new int[DataGridViewMain_NVR.Rows.Count];

                        for (int i = 0; i < DataGridViewMain_NVR.Rows.Count - 1; i++)
                        {
                            int valuesSum;
                            if (DataGridViewMain_NVR.Rows[i].Cells[3].Value != null && int.TryParse(DataGridViewMain_NVR.Rows[i].Cells[3].Value.ToString(), out valuesSum))
                            {
                                values[i] = valuesSum;
                            }
                        }
                        int sum = ds.CalculateSum(values);
                        TextBoxSum_NVR.Text = sum.ToString();
                    }
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
                int visibleRowCount = DataGridViewMain_NVR.Rows.Cast<DataGridViewRow>().Count(row => row.Visible && !row.IsNewRow); // рассчитывает количество видимых строк кроме последней
                int[] valuesAv = new int[visibleRowCount];

                for (int i = 0; i < DataGridViewMain_NVR.Rows.Count - 1; i++)
                {
                    int valuesAverage;
                    if (DataGridViewMain_NVR.Rows[i].Cells[4].Value != null && int.TryParse(DataGridViewMain_NVR.Rows[i].Cells[4].Value.ToString(), out valuesAverage))
                    {
                        valuesAv[i] = valuesAverage;
                    }
                }

                double average = ds.CalculateAverage(valuesAv);
                TextBoxAverage_NVR.Text = average.ToString();
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
                    }
                }
            }
           
        }

        private void ComboBoxSort_NVR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSort_NVR.SelectedItem != null)
            {
                int columnIndex = 4;
                string selectedItem = ComboBoxSort_NVR.SelectedItem.ToString();
                foreach (DataGridViewRow row in DataGridViewMain_NVR.Rows)
                {
                    int cellValue;
                    if (row.Cells[columnIndex].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }
                    else
                    {

                    }
                }
                try
                {
                    DataGridViewColumn column = DataGridViewMain_NVR.Columns[4];

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

        private void ButtonReturn_NVR_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridViewMain_NVR.Rows)
            {
                row.Visible = true;
            }
        }

        
    }
}

