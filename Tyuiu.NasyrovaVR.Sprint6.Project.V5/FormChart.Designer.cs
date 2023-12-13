namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    partial class FormChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PanelTopChart_NVR = new System.Windows.Forms.Panel();
            this.ButtonBackChart_NVR = new System.Windows.Forms.Button();
            this.Chart_NVR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBoxChart_NVR = new System.Windows.Forms.GroupBox();
            this.ComboBoxChart_NVR = new System.Windows.Forms.ComboBox();
            this.ToolTipChart_NVR = new System.Windows.Forms.ToolTip(this.components);
            this.LabelNameChart_NVR = new System.Windows.Forms.Label();
            this.DataGridViewChart_NVR = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonOpenChart_NVR = new System.Windows.Forms.Button();
            this.PanelTopChart_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).BeginInit();
            this.GroupBoxChart_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChart_NVR)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTopChart_NVR
            // 
            this.PanelTopChart_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelTopChart_NVR.Controls.Add(this.LabelNameChart_NVR);
            this.PanelTopChart_NVR.Controls.Add(this.ButtonBackChart_NVR);
            this.PanelTopChart_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopChart_NVR.Location = new System.Drawing.Point(0, 0);
            this.PanelTopChart_NVR.Name = "PanelTopChart_NVR";
            this.PanelTopChart_NVR.Size = new System.Drawing.Size(1008, 100);
            this.PanelTopChart_NVR.TabIndex = 0;
            // 
            // ButtonBackChart_NVR
            // 
            this.ButtonBackChart_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonBackChart_NVR.BackgroundImage")));
            this.ButtonBackChart_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonBackChart_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackChart_NVR.Location = new System.Drawing.Point(13, 13);
            this.ButtonBackChart_NVR.Name = "ButtonBackChart_NVR";
            this.ButtonBackChart_NVR.Size = new System.Drawing.Size(78, 47);
            this.ButtonBackChart_NVR.TabIndex = 0;
            this.ToolTipChart_NVR.SetToolTip(this.ButtonBackChart_NVR, "Вернуться на главную страницу");
            this.ButtonBackChart_NVR.UseVisualStyleBackColor = true;
            this.ButtonBackChart_NVR.Click += new System.EventHandler(this.ButtonBackChart_NVR_Click);
            // 
            // Chart_NVR
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart_NVR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart_NVR.Legends.Add(legend1);
            this.Chart_NVR.Location = new System.Drawing.Point(489, 174);
            this.Chart_NVR.Name = "Chart_NVR";
            this.Chart_NVR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart_NVR.Series.Add(series1);
            this.Chart_NVR.Size = new System.Drawing.Size(507, 386);
            this.Chart_NVR.TabIndex = 1;
            this.Chart_NVR.Text = "chart1";
            title1.Name = "Title";
            title1.Text = "График стоимости";
            this.Chart_NVR.Titles.Add(title1);
            // 
            // GroupBoxChart_NVR
            // 
            this.GroupBoxChart_NVR.Controls.Add(this.ComboBoxChart_NVR);
            this.GroupBoxChart_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxChart_NVR.Location = new System.Drawing.Point(12, 106);
            this.GroupBoxChart_NVR.Name = "GroupBoxChart_NVR";
            this.GroupBoxChart_NVR.Size = new System.Drawing.Size(336, 85);
            this.GroupBoxChart_NVR.TabIndex = 3;
            this.GroupBoxChart_NVR.TabStop = false;
            this.GroupBoxChart_NVR.Text = "Выбор категории";
            // 
            // ComboBoxChart_NVR
            // 
            this.ComboBoxChart_NVR.FormattingEnabled = true;
            this.ComboBoxChart_NVR.Location = new System.Drawing.Point(6, 43);
            this.ComboBoxChart_NVR.Name = "ComboBoxChart_NVR";
            this.ComboBoxChart_NVR.Size = new System.Drawing.Size(324, 36);
            this.ComboBoxChart_NVR.TabIndex = 0;
            // 
            // ToolTipChart_NVR
            // 
            this.ToolTipChart_NVR.IsBalloon = true;
            this.ToolTipChart_NVR.ToolTipTitle = "Подсказка";
            // 
            // LabelNameChart_NVR
            // 
            this.LabelNameChart_NVR.AutoSize = true;
            this.LabelNameChart_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameChart_NVR.ForeColor = System.Drawing.Color.White;
            this.LabelNameChart_NVR.Location = new System.Drawing.Point(309, 22);
            this.LabelNameChart_NVR.Name = "LabelNameChart_NVR";
            this.LabelNameChart_NVR.Size = new System.Drawing.Size(402, 47);
            this.LabelNameChart_NVR.TabIndex = 14;
            this.LabelNameChart_NVR.Text = "ГРАФИК СТОИМОСТИ";
            // 
            // DataGridViewChart_NVR
            // 
            this.DataGridViewChart_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChart_NVR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Name,
            this.Category,
            this.Quantity,
            this.Price,
            this.Num});
            this.DataGridViewChart_NVR.Location = new System.Drawing.Point(13, 197);
            this.DataGridViewChart_NVR.Name = "DataGridViewChart_NVR";
            this.DataGridViewChart_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewChart_NVR.Size = new System.Drawing.Size(455, 363);
            this.DataGridViewChart_NVR.TabIndex = 4;
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            // 
            // Name
            // 
            this.Name.HeaderText = "Название";
            this.Name.Name = "Name";
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Количество на складе";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость 1кг";
            this.Price.Name = "Price";
            // 
            // Num
            // 
            this.Num.HeaderText = "Номер поставщика";
            this.Num.Name = "Num";
            // 
            // ButtonOpenChart_NVR
            // 
            this.ButtonOpenChart_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpenChart_NVR.BackgroundImage")));
            this.ButtonOpenChart_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpenChart_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpenChart_NVR.Location = new System.Drawing.Point(389, 135);
            this.ButtonOpenChart_NVR.Name = "ButtonOpenChart_NVR";
            this.ButtonOpenChart_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonOpenChart_NVR.TabIndex = 8;
            this.ButtonOpenChart_NVR.UseVisualStyleBackColor = true;
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.ButtonOpenChart_NVR);
            this.Controls.Add(this.DataGridViewChart_NVR);
            this.Controls.Add(this.GroupBoxChart_NVR);
            this.Controls.Add(this.Chart_NVR);
            this.Controls.Add(this.PanelTopChart_NVR);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelTopChart_NVR.ResumeLayout(false);
            this.PanelTopChart_NVR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).EndInit();
            this.GroupBoxChart_NVR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChart_NVR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopChart_NVR;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_NVR;
        private System.Windows.Forms.Button ButtonBackChart_NVR;
        private System.Windows.Forms.GroupBox GroupBoxChart_NVR;
        private System.Windows.Forms.ComboBox ComboBoxChart_NVR;
        private System.Windows.Forms.ToolTip ToolTipChart_NVR;
        private System.Windows.Forms.Label LabelNameChart_NVR;
        private System.Windows.Forms.DataGridView DataGridViewChart_NVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.Button ButtonOpenChart_NVR;
    }
}