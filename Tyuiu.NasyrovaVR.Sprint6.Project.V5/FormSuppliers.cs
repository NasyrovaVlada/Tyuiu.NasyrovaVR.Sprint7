using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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

                DataGridViewSuppliers_NVR.RowCount = rows + 1;
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
            string valueFilt = ComboBoxFiltSuppliers_NVR.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in DataGridViewSuppliers_NVR.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["MonthS"].Value != null && row.Cells["MonthS"].Value.ToString() == valueFilt)
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

        private void ButtonAddSuppliers_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSuppliers_NVR.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSuppliersSave_NVR_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialogSuppliers_NVR.FileName = ".csv";
                SaveFileDialogSuppliers_NVR.InitialDirectory = @":L";
                if (SaveFileDialogSuppliers_NVR.ShowDialog() == DialogResult.OK)
                {
                    string savepath = SaveFileDialogSuppliers_NVR.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = DataGridViewSuppliers_NVR.RowCount;
                    int columns = DataGridViewSuppliers_NVR.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(DataGridViewSuppliers_NVR.Rows[i].Cells[j].Value);

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

        private void ButtonDelete_NVR_Click(object sender, EventArgs e)
        {
            if (DataGridViewSuppliers_NVR.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = DataGridViewSuppliers_NVR.CurrentCell.RowIndex;
                    DataGridViewSuppliers_NVR.Rows.Remove(DataGridViewSuppliers_NVR.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
