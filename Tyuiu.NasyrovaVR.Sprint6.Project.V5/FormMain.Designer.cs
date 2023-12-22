namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ButtonChart_NVR = new System.Windows.Forms.Button();
            this.ButtonSuppliers_NVR = new System.Windows.Forms.Button();
            this.DataGridViewMain_NVR = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxSort_NVR = new System.Windows.Forms.GroupBox();
            this.ComboBoxSort_NVR = new System.Windows.Forms.ComboBox();
            this.GroupBoxFilt_NVR = new System.Windows.Forms.GroupBox();
            this.ComboBoxFilt_NVR = new System.Windows.Forms.ComboBox();
            this.LabelSearch_NVR = new System.Windows.Forms.Label();
            this.TextBoxSearch_NVR = new System.Windows.Forms.TextBox();
            this.ButtonOpen_NVR = new System.Windows.Forms.Button();
            this.ButtonSave_NVR = new System.Windows.Forms.Button();
            this.PanelTop_NVR = new System.Windows.Forms.Panel();
            this.LabelName_NVR = new System.Windows.Forms.Label();
            this.ButtonInfo_NVR = new System.Windows.Forms.Button();
            this.ButtonHelp_NVR = new System.Windows.Forms.Button();
            this.ToolTip_NVR = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonAdd_NVR = new System.Windows.Forms.Button();
            this.ButtonSum_NVR = new System.Windows.Forms.Button();
            this.ButtonAverage_NVR = new System.Windows.Forms.Button();
            this.ButtonDelete_NVR = new System.Windows.Forms.Button();
            this.OpenFileDialogMain_NVR = new System.Windows.Forms.OpenFileDialog();
            this.PanelLeft_NVR = new System.Windows.Forms.Panel();
            this.TextBoxSum_NVR = new System.Windows.Forms.TextBox();
            this.TextBoxAverage_NVR = new System.Windows.Forms.TextBox();
            this.SaveFileDialogMain_NVR = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain_NVR)).BeginInit();
            this.GroupBoxSort_NVR.SuspendLayout();
            this.GroupBoxFilt_NVR.SuspendLayout();
            this.PanelTop_NVR.SuspendLayout();
            this.PanelLeft_NVR.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonChart_NVR
            // 
            this.ButtonChart_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.ButtonChart_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChart_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChart_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChart_NVR.Location = new System.Drawing.Point(849, 456);
            this.ButtonChart_NVR.Name = "ButtonChart_NVR";
            this.ButtonChart_NVR.Size = new System.Drawing.Size(393, 74);
            this.ButtonChart_NVR.TabIndex = 0;
            this.ButtonChart_NVR.Text = "Построить график стоимости";
            this.ButtonChart_NVR.UseVisualStyleBackColor = false;
            this.ButtonChart_NVR.Click += new System.EventHandler(this.ButtonChart_NVR_Click);
            // 
            // ButtonSuppliers_NVR
            // 
            this.ButtonSuppliers_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.ButtonSuppliers_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSuppliers_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSuppliers_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSuppliers_NVR.Location = new System.Drawing.Point(849, 552);
            this.ButtonSuppliers_NVR.Name = "ButtonSuppliers_NVR";
            this.ButtonSuppliers_NVR.Size = new System.Drawing.Size(393, 74);
            this.ButtonSuppliers_NVR.TabIndex = 1;
            this.ButtonSuppliers_NVR.Text = "Информация о поставщиках";
            this.ButtonSuppliers_NVR.UseVisualStyleBackColor = false;
            this.ButtonSuppliers_NVR.Click += new System.EventHandler(this.ButtonSuppliers_NVR_Click);
            // 
            // DataGridViewMain_NVR
            // 
            this.DataGridViewMain_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMain_NVR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.DataName,
            this.Category,
            this.Quantity,
            this.Price,
            this.Num});
            this.DataGridViewMain_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridViewMain_NVR.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewMain_NVR.Name = "DataGridViewMain_NVR";
            this.DataGridViewMain_NVR.RowHeadersVisible = false;
            this.DataGridViewMain_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DataGridViewMain_NVR.Size = new System.Drawing.Size(647, 581);
            this.DataGridViewMain_NVR.TabIndex = 2;
            this.DataGridViewMain_NVR.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.DataGridViewMain_NVR_CellParsing);
            // 
            // Code
            // 
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            // 
            // DataName
            // 
            this.DataName.HeaderText = "Название";
            this.DataName.Name = "DataName";
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
            this.Num.Width = 150;
            // 
            // GroupBoxSort_NVR
            // 
            this.GroupBoxSort_NVR.Controls.Add(this.ComboBoxSort_NVR);
            this.GroupBoxSort_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxSort_NVR.Location = new System.Drawing.Point(1026, 168);
            this.GroupBoxSort_NVR.Name = "GroupBoxSort_NVR";
            this.GroupBoxSort_NVR.Size = new System.Drawing.Size(216, 77);
            this.GroupBoxSort_NVR.TabIndex = 3;
            this.GroupBoxSort_NVR.TabStop = false;
            this.GroupBoxSort_NVR.Text = "Сортировка по стоимости";
            // 
            // ComboBoxSort_NVR
            // 
            this.ComboBoxSort_NVR.FormattingEnabled = true;
            this.ComboBoxSort_NVR.Items.AddRange(new object[] {
            "Max",
            "Min",
            "All"});
            this.ComboBoxSort_NVR.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxSort_NVR.Name = "ComboBoxSort_NVR";
            this.ComboBoxSort_NVR.Size = new System.Drawing.Size(204, 29);
            this.ComboBoxSort_NVR.TabIndex = 0;
            this.ComboBoxSort_NVR.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_NVR_SelectedIndexChanged);
            // 
            // GroupBoxFilt_NVR
            // 
            this.GroupBoxFilt_NVR.Controls.Add(this.ComboBoxFilt_NVR);
            this.GroupBoxFilt_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxFilt_NVR.Location = new System.Drawing.Point(849, 168);
            this.GroupBoxFilt_NVR.Name = "GroupBoxFilt_NVR";
            this.GroupBoxFilt_NVR.Size = new System.Drawing.Size(171, 77);
            this.GroupBoxFilt_NVR.TabIndex = 4;
            this.GroupBoxFilt_NVR.TabStop = false;
            this.GroupBoxFilt_NVR.Text = "Выбор категории";
            // 
            // ComboBoxFilt_NVR
            // 
            this.ComboBoxFilt_NVR.FormattingEnabled = true;
            this.ComboBoxFilt_NVR.Items.AddRange(new object[] {
            "Яблоки",
            "Груши",
            "Бананы",
            "Огурцы",
            "Киви",
            "Лимоны",
            "Апельсины",
            "Все"});
            this.ComboBoxFilt_NVR.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxFilt_NVR.Name = "ComboBoxFilt_NVR";
            this.ComboBoxFilt_NVR.Size = new System.Drawing.Size(159, 29);
            this.ComboBoxFilt_NVR.TabIndex = 0;
            this.ComboBoxFilt_NVR.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilt_NVR_SelectedIndexChanged_1);
            // 
            // LabelSearch_NVR
            // 
            this.LabelSearch_NVR.AutoSize = true;
            this.LabelSearch_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.LabelSearch_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSearch_NVR.ForeColor = System.Drawing.Color.Chocolate;
            this.LabelSearch_NVR.Location = new System.Drawing.Point(843, 110);
            this.LabelSearch_NVR.Name = "LabelSearch_NVR";
            this.LabelSearch_NVR.Size = new System.Drawing.Size(98, 36);
            this.LabelSearch_NVR.TabIndex = 5;
            this.LabelSearch_NVR.Text = "Поиск:";
            // 
            // TextBoxSearch_NVR
            // 
            this.TextBoxSearch_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearch_NVR.Location = new System.Drawing.Point(963, 110);
            this.TextBoxSearch_NVR.Multiline = true;
            this.TextBoxSearch_NVR.Name = "TextBoxSearch_NVR";
            this.TextBoxSearch_NVR.Size = new System.Drawing.Size(279, 36);
            this.TextBoxSearch_NVR.TabIndex = 6;
            this.TextBoxSearch_NVR.TextChanged += new System.EventHandler(this.TextBoxSearch_NVR_TextChanged);
            // 
            // ButtonOpen_NVR
            // 
            this.ButtonOpen_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpen_NVR.BackgroundImage")));
            this.ButtonOpen_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpen_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpen_NVR.Location = new System.Drawing.Point(653, 106);
            this.ButtonOpen_NVR.Name = "ButtonOpen_NVR";
            this.ButtonOpen_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonOpen_NVR.TabIndex = 7;
            this.ToolTip_NVR.SetToolTip(this.ButtonOpen_NVR, "Загрузить данные");
            this.ButtonOpen_NVR.UseVisualStyleBackColor = true;
            this.ButtonOpen_NVR.Click += new System.EventHandler(this.ButtonOpen_NVR_Click);
            // 
            // ButtonSave_NVR
            // 
            this.ButtonSave_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave_NVR.BackgroundImage")));
            this.ButtonSave_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave_NVR.Location = new System.Drawing.Point(653, 168);
            this.ButtonSave_NVR.Name = "ButtonSave_NVR";
            this.ButtonSave_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonSave_NVR.TabIndex = 8;
            this.ToolTip_NVR.SetToolTip(this.ButtonSave_NVR, "Сохранить данные");
            this.ButtonSave_NVR.UseVisualStyleBackColor = true;
            this.ButtonSave_NVR.Click += new System.EventHandler(this.ButtonSave_NVR_Click);
            // 
            // PanelTop_NVR
            // 
            this.PanelTop_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelTop_NVR.Controls.Add(this.LabelName_NVR);
            this.PanelTop_NVR.Controls.Add(this.ButtonInfo_NVR);
            this.PanelTop_NVR.Controls.Add(this.ButtonHelp_NVR);
            this.PanelTop_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop_NVR.Location = new System.Drawing.Point(0, 0);
            this.PanelTop_NVR.Name = "PanelTop_NVR";
            this.PanelTop_NVR.Size = new System.Drawing.Size(1264, 100);
            this.PanelTop_NVR.TabIndex = 11;
            // 
            // LabelName_NVR
            // 
            this.LabelName_NVR.AutoSize = true;
            this.LabelName_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName_NVR.ForeColor = System.Drawing.Color.White;
            this.LabelName_NVR.Location = new System.Drawing.Point(434, 12);
            this.LabelName_NVR.Name = "LabelName_NVR";
            this.LabelName_NVR.Size = new System.Drawing.Size(394, 64);
            this.LabelName_NVR.TabIndex = 13;
            this.LabelName_NVR.Text = "ОПТОВАЯ БАЗА";
            // 
            // ButtonInfo_NVR
            // 
            this.ButtonInfo_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInfo_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo_NVR.BackgroundImage")));
            this.ButtonInfo_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfo_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInfo_NVR.Location = new System.Drawing.Point(1197, 12);
            this.ButtonInfo_NVR.Name = "ButtonInfo_NVR";
            this.ButtonInfo_NVR.Size = new System.Drawing.Size(55, 52);
            this.ButtonInfo_NVR.TabIndex = 12;
            this.ToolTip_NVR.SetToolTip(this.ButtonInfo_NVR, "Информация о разработчике");
            this.ButtonInfo_NVR.UseVisualStyleBackColor = true;
            this.ButtonInfo_NVR.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // ButtonHelp_NVR
            // 
            this.ButtonHelp_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHelp_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonHelp_NVR.BackgroundImage")));
            this.ButtonHelp_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonHelp_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHelp_NVR.Location = new System.Drawing.Point(1130, 12);
            this.ButtonHelp_NVR.Name = "ButtonHelp_NVR";
            this.ButtonHelp_NVR.Size = new System.Drawing.Size(55, 52);
            this.ButtonHelp_NVR.TabIndex = 11;
            this.ToolTip_NVR.SetToolTip(this.ButtonHelp_NVR, "Руководство пользователя");
            this.ButtonHelp_NVR.UseVisualStyleBackColor = true;
            this.ButtonHelp_NVR.Click += new System.EventHandler(this.ButtonHelp_NVR_Click);
            // 
            // ToolTip_NVR
            // 
            this.ToolTip_NVR.IsBalloon = true;
            this.ToolTip_NVR.ToolTipTitle = "Подсказка";
            // 
            // ButtonAdd_NVR
            // 
            this.ButtonAdd_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAdd_NVR.BackgroundImage")));
            this.ButtonAdd_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonAdd_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAdd_NVR.Location = new System.Drawing.Point(653, 230);
            this.ButtonAdd_NVR.Name = "ButtonAdd_NVR";
            this.ButtonAdd_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonAdd_NVR.TabIndex = 12;
            this.ToolTip_NVR.SetToolTip(this.ButtonAdd_NVR, "Добавить строку");
            this.ButtonAdd_NVR.UseVisualStyleBackColor = true;
            this.ButtonAdd_NVR.Click += new System.EventHandler(this.ButtonAdd_NVR_Click);
            // 
            // ButtonSum_NVR
            // 
            this.ButtonSum_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.ButtonSum_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSum_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSum_NVR.Location = new System.Drawing.Point(849, 260);
            this.ButtonSum_NVR.Name = "ButtonSum_NVR";
            this.ButtonSum_NVR.Size = new System.Drawing.Size(171, 59);
            this.ButtonSum_NVR.TabIndex = 14;
            this.ButtonSum_NVR.Text = "Количество продуктов на складе";
            this.ToolTip_NVR.SetToolTip(this.ButtonSum_NVR, "Посчитать количество всех продуктов на складе");
            this.ButtonSum_NVR.UseVisualStyleBackColor = false;
            this.ButtonSum_NVR.Click += new System.EventHandler(this.ButtonSum_NVR_Click);
            // 
            // ButtonAverage_NVR
            // 
            this.ButtonAverage_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.ButtonAverage_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAverage_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAverage_NVR.Location = new System.Drawing.Point(849, 325);
            this.ButtonAverage_NVR.Name = "ButtonAverage_NVR";
            this.ButtonAverage_NVR.Size = new System.Drawing.Size(171, 59);
            this.ButtonAverage_NVR.TabIndex = 16;
            this.ButtonAverage_NVR.Text = "Средняя цена";
            this.ToolTip_NVR.SetToolTip(this.ButtonAverage_NVR, "Посчитать среднюю цену за 1кг продукта");
            this.ButtonAverage_NVR.UseVisualStyleBackColor = false;
            this.ButtonAverage_NVR.Click += new System.EventHandler(this.ButtonAverage_NVR_Click);
            // 
            // ButtonDelete_NVR
            // 
            this.ButtonDelete_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete_NVR.BackgroundImage")));
            this.ButtonDelete_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDelete_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete_NVR.Location = new System.Drawing.Point(653, 292);
            this.ButtonDelete_NVR.Name = "ButtonDelete_NVR";
            this.ButtonDelete_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonDelete_NVR.TabIndex = 18;
            this.ToolTip_NVR.SetToolTip(this.ButtonDelete_NVR, "Удалить строку");
            this.ButtonDelete_NVR.UseVisualStyleBackColor = true;
            this.ButtonDelete_NVR.Click += new System.EventHandler(this.ButtonDelete_NVR_Click);
            // 
            // OpenFileDialogMain_NVR
            // 
            this.OpenFileDialogMain_NVR.FileName = "openFileDialog1";
            // 
            // PanelLeft_NVR
            // 
            this.PanelLeft_NVR.Controls.Add(this.DataGridViewMain_NVR);
            this.PanelLeft_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_NVR.Location = new System.Drawing.Point(0, 100);
            this.PanelLeft_NVR.Name = "PanelLeft_NVR";
            this.PanelLeft_NVR.Size = new System.Drawing.Size(647, 581);
            this.PanelLeft_NVR.TabIndex = 13;
            // 
            // TextBoxSum_NVR
            // 
            this.TextBoxSum_NVR.BackColor = System.Drawing.Color.White;
            this.TextBoxSum_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSum_NVR.Location = new System.Drawing.Point(1032, 274);
            this.TextBoxSum_NVR.Multiline = true;
            this.TextBoxSum_NVR.Name = "TextBoxSum_NVR";
            this.TextBoxSum_NVR.ReadOnly = true;
            this.TextBoxSum_NVR.Size = new System.Drawing.Size(210, 35);
            this.TextBoxSum_NVR.TabIndex = 15;
            // 
            // TextBoxAverage_NVR
            // 
            this.TextBoxAverage_NVR.BackColor = System.Drawing.Color.White;
            this.TextBoxAverage_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxAverage_NVR.Location = new System.Drawing.Point(1032, 339);
            this.TextBoxAverage_NVR.Multiline = true;
            this.TextBoxAverage_NVR.Name = "TextBoxAverage_NVR";
            this.TextBoxAverage_NVR.ReadOnly = true;
            this.TextBoxAverage_NVR.Size = new System.Drawing.Size(210, 35);
            this.TextBoxAverage_NVR.TabIndex = 17;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ButtonDelete_NVR);
            this.Controls.Add(this.TextBoxAverage_NVR);
            this.Controls.Add(this.ButtonAverage_NVR);
            this.Controls.Add(this.TextBoxSum_NVR);
            this.Controls.Add(this.ButtonSum_NVR);
            this.Controls.Add(this.PanelLeft_NVR);
            this.Controls.Add(this.ButtonAdd_NVR);
            this.Controls.Add(this.PanelTop_NVR);
            this.Controls.Add(this.ButtonSave_NVR);
            this.Controls.Add(this.ButtonOpen_NVR);
            this.Controls.Add(this.TextBoxSearch_NVR);
            this.Controls.Add(this.LabelSearch_NVR);
            this.Controls.Add(this.GroupBoxFilt_NVR);
            this.Controls.Add(this.GroupBoxSort_NVR);
            this.Controls.Add(this.ButtonSuppliers_NVR);
            this.Controls.Add(this.ButtonChart_NVR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain_NVR)).EndInit();
            this.GroupBoxSort_NVR.ResumeLayout(false);
            this.GroupBoxFilt_NVR.ResumeLayout(false);
            this.PanelTop_NVR.ResumeLayout(false);
            this.PanelTop_NVR.PerformLayout();
            this.PanelLeft_NVR.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonChart_NVR;
        private System.Windows.Forms.Button ButtonSuppliers_NVR;
        private System.Windows.Forms.DataGridView DataGridViewMain_NVR;
        private System.Windows.Forms.GroupBox GroupBoxSort_NVR;
        private System.Windows.Forms.ComboBox ComboBoxSort_NVR;
        private System.Windows.Forms.GroupBox GroupBoxFilt_NVR;
        private System.Windows.Forms.ComboBox ComboBoxFilt_NVR;
        private System.Windows.Forms.Label LabelSearch_NVR;
        private System.Windows.Forms.TextBox TextBoxSearch_NVR;
        private System.Windows.Forms.Button ButtonOpen_NVR;
        private System.Windows.Forms.Button ButtonSave_NVR;
        private System.Windows.Forms.Panel PanelTop_NVR;
        private System.Windows.Forms.Label LabelName_NVR;
        private System.Windows.Forms.Button ButtonInfo_NVR;
        private System.Windows.Forms.Button ButtonHelp_NVR;
        private System.Windows.Forms.ToolTip ToolTip_NVR;
        private System.Windows.Forms.Button ButtonAdd_NVR;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogMain_NVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.Panel PanelLeft_NVR;
        private System.Windows.Forms.Button ButtonSum_NVR;
        private System.Windows.Forms.TextBox TextBoxSum_NVR;
        private System.Windows.Forms.Button ButtonAverage_NVR;
        private System.Windows.Forms.TextBox TextBoxAverage_NVR;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogMain_NVR;
        private System.Windows.Forms.Button ButtonDelete_NVR;
    }
}

