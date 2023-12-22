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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PanelTopChart_NVR = new System.Windows.Forms.Panel();
            this.LabelNameChart_NVR = new System.Windows.Forms.Label();
            this.ButtonBackChart_NVR = new System.Windows.Forms.Button();
            this.GroupBoxChart_NVR = new System.Windows.Forms.GroupBox();
            this.ComboBoxChart_NVR = new System.Windows.Forms.ComboBox();
            this.ToolTipChart_NVR = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonOpenChart_NVR = new System.Windows.Forms.Button();
            this.ButtonDoneChart_NVR = new System.Windows.Forms.Button();
            this.DataGridViewChart_NVR = new System.Windows.Forms.DataGridView();
            this.CodeCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNameCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileDialogChart_NVR = new System.Windows.Forms.OpenFileDialog();
            this.PanelLeftChart_NVR = new System.Windows.Forms.Panel();
            this.Chart_NVR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonChartAdd_NVR = new System.Windows.Forms.Button();
            this.ButtonDelete_NVR = new System.Windows.Forms.Button();
            this.ButtonSave_NVR = new System.Windows.Forms.Button();
            this.SaveFileDialogChart_NVR = new System.Windows.Forms.SaveFileDialog();
            this.PanelTopChart_NVR.SuspendLayout();
            this.GroupBoxChart_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChart_NVR)).BeginInit();
            this.PanelLeftChart_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).BeginInit();
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
            this.PanelTopChart_NVR.Size = new System.Drawing.Size(1264, 100);
            this.PanelTopChart_NVR.TabIndex = 0;
            // 
            // LabelNameChart_NVR
            // 
            this.LabelNameChart_NVR.AutoSize = true;
            this.LabelNameChart_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameChart_NVR.ForeColor = System.Drawing.Color.White;
            this.LabelNameChart_NVR.Location = new System.Drawing.Point(441, 24);
            this.LabelNameChart_NVR.Name = "LabelNameChart_NVR";
            this.LabelNameChart_NVR.Size = new System.Drawing.Size(490, 47);
            this.LabelNameChart_NVR.TabIndex = 14;
            this.LabelNameChart_NVR.Text = "ДИАГРАММА СТОИМОСТИ";
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
            // GroupBoxChart_NVR
            // 
            this.GroupBoxChart_NVR.Controls.Add(this.ComboBoxChart_NVR);
            this.GroupBoxChart_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxChart_NVR.Location = new System.Drawing.Point(950, 106);
            this.GroupBoxChart_NVR.Name = "GroupBoxChart_NVR";
            this.GroupBoxChart_NVR.Size = new System.Drawing.Size(302, 85);
            this.GroupBoxChart_NVR.TabIndex = 3;
            this.GroupBoxChart_NVR.TabStop = false;
            this.GroupBoxChart_NVR.Text = "Выбор категории";
            // 
            // ComboBoxChart_NVR
            // 
            this.ComboBoxChart_NVR.FormattingEnabled = true;
            this.ComboBoxChart_NVR.Items.AddRange(new object[] {
            "Яблоки",
            "Груши",
            "Бананы",
            "Огурцы",
            "Киви",
            "Лимоны",
            "Апельсины",
            "Все"});
            this.ComboBoxChart_NVR.Location = new System.Drawing.Point(6, 43);
            this.ComboBoxChart_NVR.Name = "ComboBoxChart_NVR";
            this.ComboBoxChart_NVR.Size = new System.Drawing.Size(290, 36);
            this.ComboBoxChart_NVR.TabIndex = 0;
            this.ComboBoxChart_NVR.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChart_NVR_SelectedIndexChanged);
            // 
            // ToolTipChart_NVR
            // 
            this.ToolTipChart_NVR.IsBalloon = true;
            this.ToolTipChart_NVR.ToolTipTitle = "Подсказка";
            // 
            // ButtonOpenChart_NVR
            // 
            this.ButtonOpenChart_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpenChart_NVR.BackgroundImage")));
            this.ButtonOpenChart_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpenChart_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpenChart_NVR.Location = new System.Drawing.Point(606, 106);
            this.ButtonOpenChart_NVR.Name = "ButtonOpenChart_NVR";
            this.ButtonOpenChart_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonOpenChart_NVR.TabIndex = 8;
            this.ToolTipChart_NVR.SetToolTip(this.ButtonOpenChart_NVR, "Загрузить данные");
            this.ButtonOpenChart_NVR.UseVisualStyleBackColor = true;
            this.ButtonOpenChart_NVR.Click += new System.EventHandler(this.ButtonOpenChart_NVR_Click);
            // 
            // ButtonDoneChart_NVR
            // 
            this.ButtonDoneChart_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.ButtonDoneChart_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDoneChart_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDoneChart_NVR.Location = new System.Drawing.Point(745, 119);
            this.ButtonDoneChart_NVR.Name = "ButtonDoneChart_NVR";
            this.ButtonDoneChart_NVR.Size = new System.Drawing.Size(175, 72);
            this.ButtonDoneChart_NVR.TabIndex = 10;
            this.ButtonDoneChart_NVR.Text = "Выполнить";
            this.ToolTipChart_NVR.SetToolTip(this.ButtonDoneChart_NVR, "Построить диаграмму стоимости продукта");
            this.ButtonDoneChart_NVR.UseVisualStyleBackColor = false;
            this.ButtonDoneChart_NVR.Click += new System.EventHandler(this.ButtonDoneChart_NVR_Click);
            // 
            // DataGridViewChart_NVR
            // 
            this.DataGridViewChart_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChart_NVR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeCh,
            this.DataNameCh,
            this.CategoryCh,
            this.QuantityCh,
            this.PriceCh,
            this.NumCh});
            this.DataGridViewChart_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridViewChart_NVR.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewChart_NVR.Name = "DataGridViewChart_NVR";
            this.DataGridViewChart_NVR.RowHeadersVisible = false;
            this.DataGridViewChart_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewChart_NVR.Size = new System.Drawing.Size(599, 581);
            this.DataGridViewChart_NVR.TabIndex = 4;
            // 
            // CodeCh
            // 
            this.CodeCh.HeaderText = "Код";
            this.CodeCh.Name = "CodeCh";
            // 
            // DataNameCh
            // 
            this.DataNameCh.HeaderText = "Название";
            this.DataNameCh.Name = "DataNameCh";
            // 
            // CategoryCh
            // 
            this.CategoryCh.HeaderText = "Категория";
            this.CategoryCh.Name = "CategoryCh";
            // 
            // QuantityCh
            // 
            this.QuantityCh.HeaderText = "Количество на складе";
            this.QuantityCh.Name = "QuantityCh";
            // 
            // PriceCh
            // 
            this.PriceCh.HeaderText = "Стоимость 1кг";
            this.PriceCh.Name = "PriceCh";
            // 
            // NumCh
            // 
            this.NumCh.HeaderText = "Номер поставщика";
            this.NumCh.Name = "NumCh";
            // 
            // OpenFileDialogChart_NVR
            // 
            this.OpenFileDialogChart_NVR.FileName = "OpenFileDialogChart_NVR";
            // 
            // PanelLeftChart_NVR
            // 
            this.PanelLeftChart_NVR.Controls.Add(this.DataGridViewChart_NVR);
            this.PanelLeftChart_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftChart_NVR.Location = new System.Drawing.Point(0, 100);
            this.PanelLeftChart_NVR.Name = "PanelLeftChart_NVR";
            this.PanelLeftChart_NVR.Size = new System.Drawing.Size(600, 581);
            this.PanelLeftChart_NVR.TabIndex = 9;
            // 
            // Chart_NVR
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart_NVR.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart_NVR.Legends.Add(legend3);
            this.Chart_NVR.Location = new System.Drawing.Point(745, 197);
            this.Chart_NVR.Name = "Chart_NVR";
            this.Chart_NVR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart_NVR.Series.Add(series3);
            this.Chart_NVR.Size = new System.Drawing.Size(507, 472);
            this.Chart_NVR.TabIndex = 1;
            this.Chart_NVR.Text = "chart1";
            title3.Name = "Title";
            title3.Text = "Диаграмма стоимости";
            this.Chart_NVR.Titles.Add(title3);
            // 
            // ButtonChartAdd_NVR
            // 
            this.ButtonChartAdd_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonChartAdd_NVR.BackgroundImage")));
            this.ButtonChartAdd_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonChartAdd_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChartAdd_NVR.Location = new System.Drawing.Point(606, 230);
            this.ButtonChartAdd_NVR.Name = "ButtonChartAdd_NVR";
            this.ButtonChartAdd_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonChartAdd_NVR.TabIndex = 13;
            this.ToolTipChart_NVR.SetToolTip(this.ButtonChartAdd_NVR, "Добавить строку");
            this.ButtonChartAdd_NVR.UseVisualStyleBackColor = true;
            this.ButtonChartAdd_NVR.Click += new System.EventHandler(this.ButtonChartAdd_NVR_Click);
            // 
            // ButtonDelete_NVR
            // 
            this.ButtonDelete_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete_NVR.BackgroundImage")));
            this.ButtonDelete_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDelete_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete_NVR.Location = new System.Drawing.Point(606, 292);
            this.ButtonDelete_NVR.Name = "ButtonDelete_NVR";
            this.ButtonDelete_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonDelete_NVR.TabIndex = 19;
            this.ToolTipChart_NVR.SetToolTip(this.ButtonDelete_NVR, "Удалить строку");
            this.ButtonDelete_NVR.UseVisualStyleBackColor = true;
            this.ButtonDelete_NVR.Click += new System.EventHandler(this.ButtonDelete_NVR_Click);
            // 
            // ButtonSave_NVR
            // 
            this.ButtonSave_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave_NVR.BackgroundImage")));
            this.ButtonSave_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave_NVR.Location = new System.Drawing.Point(605, 168);
            this.ButtonSave_NVR.Name = "ButtonSave_NVR";
            this.ButtonSave_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonSave_NVR.TabIndex = 20;
            this.ToolTipChart_NVR.SetToolTip(this.ButtonSave_NVR, "Сохранить данные");
            this.ButtonSave_NVR.UseVisualStyleBackColor = true;
            this.ButtonSave_NVR.Click += new System.EventHandler(this.ButtonSave_NVR_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ButtonSave_NVR);
            this.Controls.Add(this.ButtonDelete_NVR);
            this.Controls.Add(this.ButtonChartAdd_NVR);
            this.Controls.Add(this.ButtonDoneChart_NVR);
            this.Controls.Add(this.Chart_NVR);
            this.Controls.Add(this.ButtonOpenChart_NVR);
            this.Controls.Add(this.GroupBoxChart_NVR);
            this.Controls.Add(this.PanelLeftChart_NVR);
            this.Controls.Add(this.PanelTopChart_NVR);
            this.Name = "FormChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelTopChart_NVR.ResumeLayout(false);
            this.PanelTopChart_NVR.PerformLayout();
            this.GroupBoxChart_NVR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChart_NVR)).EndInit();
            this.PanelLeftChart_NVR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_NVR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopChart_NVR;
        private System.Windows.Forms.Button ButtonBackChart_NVR;
        private System.Windows.Forms.GroupBox GroupBoxChart_NVR;
        private System.Windows.Forms.ComboBox ComboBoxChart_NVR;
        private System.Windows.Forms.ToolTip ToolTipChart_NVR;
        private System.Windows.Forms.Label LabelNameChart_NVR;
        private System.Windows.Forms.DataGridView DataGridViewChart_NVR;
        private System.Windows.Forms.Button ButtonOpenChart_NVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNameCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceCh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCh;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogChart_NVR;
        private System.Windows.Forms.Panel PanelLeftChart_NVR;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_NVR;
        private System.Windows.Forms.Button ButtonDoneChart_NVR;
        private System.Windows.Forms.Button ButtonChartAdd_NVR;
        private System.Windows.Forms.Button ButtonDelete_NVR;
        private System.Windows.Forms.Button ButtonSave_NVR;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogChart_NVR;
    }
}