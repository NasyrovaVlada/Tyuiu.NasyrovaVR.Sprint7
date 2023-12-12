using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
    }
}
