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
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain_NVR)).BeginInit();
            this.GroupBoxSort_NVR.SuspendLayout();
            this.GroupBoxFilt_NVR.SuspendLayout();
            this.PanelTop_NVR.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonChart_NVR
            // 
            this.ButtonChart_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.ButtonChart_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonChart_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChart_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonChart_NVR.Location = new System.Drawing.Point(704, 286);
            this.ButtonChart_NVR.Name = "ButtonChart_NVR";
            this.ButtonChart_NVR.Size = new System.Drawing.Size(268, 74);
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
            this.ButtonSuppliers_NVR.Location = new System.Drawing.Point(704, 387);
            this.ButtonSuppliers_NVR.Name = "ButtonSuppliers_NVR";
            this.ButtonSuppliers_NVR.Size = new System.Drawing.Size(268, 74);
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
            this.Name,
            this.Category,
            this.Quantity,
            this.Price,
            this.Num});
            this.DataGridViewMain_NVR.Location = new System.Drawing.Point(12, 286);
            this.DataGridViewMain_NVR.Name = "DataGridViewMain_NVR";
            this.DataGridViewMain_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewMain_NVR.Size = new System.Drawing.Size(643, 274);
            this.DataGridViewMain_NVR.TabIndex = 2;
            // 
            // GroupBoxSort_NVR
            // 
            this.GroupBoxSort_NVR.Controls.Add(this.ComboBoxSort_NVR);
            this.GroupBoxSort_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxSort_NVR.Location = new System.Drawing.Point(183, 203);
            this.GroupBoxSort_NVR.Name = "GroupBoxSort_NVR";
            this.GroupBoxSort_NVR.Size = new System.Drawing.Size(153, 77);
            this.GroupBoxSort_NVR.TabIndex = 3;
            this.GroupBoxSort_NVR.TabStop = false;
            this.GroupBoxSort_NVR.Text = "Сортировка";
            // 
            // ComboBoxSort_NVR
            // 
            this.ComboBoxSort_NVR.FormattingEnabled = true;
            this.ComboBoxSort_NVR.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxSort_NVR.Name = "ComboBoxSort_NVR";
            this.ComboBoxSort_NVR.Size = new System.Drawing.Size(141, 29);
            this.ComboBoxSort_NVR.TabIndex = 0;
            // 
            // GroupBoxFilt_NVR
            // 
            this.GroupBoxFilt_NVR.Controls.Add(this.ComboBoxFilt_NVR);
            this.GroupBoxFilt_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxFilt_NVR.Location = new System.Drawing.Point(12, 203);
            this.GroupBoxFilt_NVR.Name = "GroupBoxFilt_NVR";
            this.GroupBoxFilt_NVR.Size = new System.Drawing.Size(154, 77);
            this.GroupBoxFilt_NVR.TabIndex = 4;
            this.GroupBoxFilt_NVR.TabStop = false;
            this.GroupBoxFilt_NVR.Text = "Фильтр";
            // 
            // ComboBoxFilt_NVR
            // 
            this.ComboBoxFilt_NVR.FormattingEnabled = true;
            this.ComboBoxFilt_NVR.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxFilt_NVR.Name = "ComboBoxFilt_NVR";
            this.ComboBoxFilt_NVR.Size = new System.Drawing.Size(142, 29);
            this.ComboBoxFilt_NVR.TabIndex = 0;
            // 
            // LabelSearch_NVR
            // 
            this.LabelSearch_NVR.AutoSize = true;
            this.LabelSearch_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.LabelSearch_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSearch_NVR.ForeColor = System.Drawing.Color.DarkOrange;
            this.LabelSearch_NVR.Location = new System.Drawing.Point(13, 128);
            this.LabelSearch_NVR.Name = "LabelSearch_NVR";
            this.LabelSearch_NVR.Size = new System.Drawing.Size(200, 28);
            this.LabelSearch_NVR.TabIndex = 5;
            this.LabelSearch_NVR.Text = "Поиск по названию";
            // 
            // TextBoxSearch_NVR
            // 
            this.TextBoxSearch_NVR.Location = new System.Drawing.Point(224, 128);
            this.TextBoxSearch_NVR.Multiline = true;
            this.TextBoxSearch_NVR.Name = "TextBoxSearch_NVR";
            this.TextBoxSearch_NVR.Size = new System.Drawing.Size(227, 28);
            this.TextBoxSearch_NVR.TabIndex = 6;
            // 
            // ButtonOpen_NVR
            // 
            this.ButtonOpen_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpen_NVR.BackgroundImage")));
            this.ButtonOpen_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpen_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpen_NVR.Location = new System.Drawing.Point(406, 224);
            this.ButtonOpen_NVR.Name = "ButtonOpen_NVR";
            this.ButtonOpen_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonOpen_NVR.TabIndex = 7;
            this.ToolTip_NVR.SetToolTip(this.ButtonOpen_NVR, "Загрузить данные");
            this.ButtonOpen_NVR.UseVisualStyleBackColor = true;
            // 
            // ButtonSave_NVR
            // 
            this.ButtonSave_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave_NVR.BackgroundImage")));
            this.ButtonSave_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave_NVR.Location = new System.Drawing.Point(491, 224);
            this.ButtonSave_NVR.Name = "ButtonSave_NVR";
            this.ButtonSave_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonSave_NVR.TabIndex = 8;
            this.ToolTip_NVR.SetToolTip(this.ButtonSave_NVR, "Сохранить данные");
            this.ButtonSave_NVR.UseVisualStyleBackColor = true;
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
            this.PanelTop_NVR.Size = new System.Drawing.Size(1008, 100);
            this.PanelTop_NVR.TabIndex = 11;
            // 
            // LabelName_NVR
            // 
            this.LabelName_NVR.AutoSize = true;
            this.LabelName_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName_NVR.ForeColor = System.Drawing.Color.White;
            this.LabelName_NVR.Location = new System.Drawing.Point(301, 12);
            this.LabelName_NVR.Name = "LabelName_NVR";
            this.LabelName_NVR.Size = new System.Drawing.Size(394, 64);
            this.LabelName_NVR.TabIndex = 13;
            this.LabelName_NVR.Text = "ОПТОВАЯ БАЗА";
            // 
            // ButtonInfo_NVR
            // 
            this.ButtonInfo_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonInfo_NVR.BackgroundImage")));
            this.ButtonInfo_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfo_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInfo_NVR.Location = new System.Drawing.Point(941, 12);
            this.ButtonInfo_NVR.Name = "ButtonInfo_NVR";
            this.ButtonInfo_NVR.Size = new System.Drawing.Size(55, 52);
            this.ButtonInfo_NVR.TabIndex = 12;
            this.ToolTip_NVR.SetToolTip(this.ButtonInfo_NVR, "Информация о разработчике");
            this.ButtonInfo_NVR.UseVisualStyleBackColor = true;
            this.ButtonInfo_NVR.Click += new System.EventHandler(this.ButtonInfo_NVR_Click);
            // 
            // ButtonHelp_NVR
            // 
            this.ButtonHelp_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonHelp_NVR.BackgroundImage")));
            this.ButtonHelp_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonHelp_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHelp_NVR.Location = new System.Drawing.Point(874, 12);
            this.ButtonHelp_NVR.Name = "ButtonHelp_NVR";
            this.ButtonHelp_NVR.Size = new System.Drawing.Size(55, 52);
            this.ButtonHelp_NVR.TabIndex = 11;
            this.ToolTip_NVR.SetToolTip(this.ButtonHelp_NVR, "Руководство пользователя");
            this.ButtonHelp_NVR.UseVisualStyleBackColor = true;
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
            this.ButtonAdd_NVR.Location = new System.Drawing.Point(576, 224);
            this.ButtonAdd_NVR.Name = "ButtonAdd_NVR";
            this.ButtonAdd_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonAdd_NVR.TabIndex = 12;
            this.ToolTip_NVR.SetToolTip(this.ButtonAdd_NVR, "Добавить данные вручную");
            this.ButtonAdd_NVR.UseVisualStyleBackColor = true;
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.ButtonAdd_NVR);
            this.Controls.Add(this.PanelTop_NVR);
            this.Controls.Add(this.ButtonSave_NVR);
            this.Controls.Add(this.ButtonOpen_NVR);
            this.Controls.Add(this.TextBoxSearch_NVR);
            this.Controls.Add(this.LabelSearch_NVR);
            this.Controls.Add(this.GroupBoxFilt_NVR);
            this.Controls.Add(this.GroupBoxSort_NVR);
            this.Controls.Add(this.DataGridViewMain_NVR);
            this.Controls.Add(this.ButtonSuppliers_NVR);
            this.Controls.Add(this.ButtonChart_NVR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMain_NVR)).EndInit();
            this.GroupBoxSort_NVR.ResumeLayout(false);
            this.GroupBoxFilt_NVR.ResumeLayout(false);
            this.PanelTop_NVR.ResumeLayout(false);
            this.PanelTop_NVR.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
    }
}

