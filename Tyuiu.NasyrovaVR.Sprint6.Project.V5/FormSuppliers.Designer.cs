namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    partial class FormSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuppliers));
            this.PanelTopSuppliers_NVR = new System.Windows.Forms.Panel();
            this.LabelNameSuppliers_NVR = new System.Windows.Forms.Label();
            this.ButtonBackSuppliers_NVR = new System.Windows.Forms.Button();
            this.GroupBoxFiltSuppliers_NVR = new System.Windows.Forms.GroupBox();
            this.ComboBoxFiltSuppliers_NVR = new System.Windows.Forms.ComboBox();
            this.DataGridViewSuppliers_NVR = new System.Windows.Forms.DataGridView();
            this.NumS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonOpenSuppliers_NVR = new System.Windows.Forms.Button();
            this.OpenFileDialogSuppliers_NVR = new System.Windows.Forms.OpenFileDialog();
            this.PanelLeftSuppliers_NVR = new System.Windows.Forms.Panel();
            this.ToolTipSuppliers_NVR = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonAddSuppliers_NVR = new System.Windows.Forms.Button();
            this.ButtonDelete_NVR = new System.Windows.Forms.Button();
            this.ButtonSuppliersSave_NVR = new System.Windows.Forms.Button();
            this.SaveFileDialogSuppliers_NVR = new System.Windows.Forms.SaveFileDialog();
            this.PanelTopSuppliers_NVR.SuspendLayout();
            this.GroupBoxFiltSuppliers_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuppliers_NVR)).BeginInit();
            this.PanelLeftSuppliers_NVR.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopSuppliers_NVR
            // 
            this.PanelTopSuppliers_NVR.BackColor = System.Drawing.Color.SandyBrown;
            this.PanelTopSuppliers_NVR.Controls.Add(this.LabelNameSuppliers_NVR);
            this.PanelTopSuppliers_NVR.Controls.Add(this.ButtonBackSuppliers_NVR);
            this.PanelTopSuppliers_NVR.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopSuppliers_NVR.Location = new System.Drawing.Point(0, 0);
            this.PanelTopSuppliers_NVR.Name = "PanelTopSuppliers_NVR";
            this.PanelTopSuppliers_NVR.Size = new System.Drawing.Size(1264, 100);
            this.PanelTopSuppliers_NVR.TabIndex = 0;
            // 
            // LabelNameSuppliers_NVR
            // 
            this.LabelNameSuppliers_NVR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNameSuppliers_NVR.AutoSize = true;
            this.LabelNameSuppliers_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameSuppliers_NVR.ForeColor = System.Drawing.Color.White;
            this.LabelNameSuppliers_NVR.Location = new System.Drawing.Point(337, 23);
            this.LabelNameSuppliers_NVR.Name = "LabelNameSuppliers_NVR";
            this.LabelNameSuppliers_NVR.Size = new System.Drawing.Size(606, 47);
            this.LabelNameSuppliers_NVR.TabIndex = 14;
            this.LabelNameSuppliers_NVR.Text = "ИНФОРМАЦИЯ О ПОСТАВЩИКАХ";
            // 
            // ButtonBackSuppliers_NVR
            // 
            this.ButtonBackSuppliers_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonBackSuppliers_NVR.BackgroundImage")));
            this.ButtonBackSuppliers_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonBackSuppliers_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBackSuppliers_NVR.Location = new System.Drawing.Point(12, 12);
            this.ButtonBackSuppliers_NVR.Name = "ButtonBackSuppliers_NVR";
            this.ButtonBackSuppliers_NVR.Size = new System.Drawing.Size(78, 47);
            this.ButtonBackSuppliers_NVR.TabIndex = 1;
            this.ButtonBackSuppliers_NVR.UseVisualStyleBackColor = true;
            this.ButtonBackSuppliers_NVR.Click += new System.EventHandler(this.ButtonBackSuppliers_NVR_Click);
            // 
            // GroupBoxFiltSuppliers_NVR
            // 
            this.GroupBoxFiltSuppliers_NVR.Controls.Add(this.ComboBoxFiltSuppliers_NVR);
            this.GroupBoxFiltSuppliers_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxFiltSuppliers_NVR.Location = new System.Drawing.Point(704, 354);
            this.GroupBoxFiltSuppliers_NVR.Name = "GroupBoxFiltSuppliers_NVR";
            this.GroupBoxFiltSuppliers_NVR.Size = new System.Drawing.Size(272, 89);
            this.GroupBoxFiltSuppliers_NVR.TabIndex = 4;
            this.GroupBoxFiltSuppliers_NVR.TabStop = false;
            this.GroupBoxFiltSuppliers_NVR.Text = "Фильтр по месяцу поставки";
            // 
            // ComboBoxFiltSuppliers_NVR
            // 
            this.ComboBoxFiltSuppliers_NVR.FormattingEnabled = true;
            this.ComboBoxFiltSuppliers_NVR.Items.AddRange(new object[] {
            "декабрь",
            "январь",
            "февраль",
            "Все"});
            this.ComboBoxFiltSuppliers_NVR.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxFiltSuppliers_NVR.Name = "ComboBoxFiltSuppliers_NVR";
            this.ComboBoxFiltSuppliers_NVR.Size = new System.Drawing.Size(260, 29);
            this.ComboBoxFiltSuppliers_NVR.TabIndex = 0;
            this.ComboBoxFiltSuppliers_NVR.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFiltSuppliers_NVR_SelectedIndexChanged);
            // 
            // DataGridViewSuppliers_NVR
            // 
            this.DataGridViewSuppliers_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSuppliers_NVR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumS,
            this.DataNameS,
            this.DateS,
            this.MonthS});
            this.DataGridViewSuppliers_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGridViewSuppliers_NVR.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewSuppliers_NVR.Name = "DataGridViewSuppliers_NVR";
            this.DataGridViewSuppliers_NVR.RowHeadersVisible = false;
            this.DataGridViewSuppliers_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewSuppliers_NVR.Size = new System.Drawing.Size(695, 581);
            this.DataGridViewSuppliers_NVR.TabIndex = 5;
            // 
            // NumS
            // 
            this.NumS.HeaderText = "Номер поставщика";
            this.NumS.Name = "NumS";
            this.NumS.Width = 150;
            // 
            // DataNameS
            // 
            this.DataNameS.HeaderText = "Поставщик";
            this.DataNameS.Name = "DataNameS";
            this.DataNameS.Width = 200;
            // 
            // DateS
            // 
            this.DateS.HeaderText = "Дата ближайшей поставки";
            this.DateS.Name = "DateS";
            this.DateS.Width = 200;
            // 
            // MonthS
            // 
            this.MonthS.HeaderText = "Месяц поставки";
            this.MonthS.Name = "MonthS";
            this.MonthS.Width = 150;
            // 
            // ButtonOpenSuppliers_NVR
            // 
            this.ButtonOpenSuppliers_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpenSuppliers_NVR.BackgroundImage")));
            this.ButtonOpenSuppliers_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpenSuppliers_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpenSuppliers_NVR.Location = new System.Drawing.Point(704, 106);
            this.ButtonOpenSuppliers_NVR.Name = "ButtonOpenSuppliers_NVR";
            this.ButtonOpenSuppliers_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonOpenSuppliers_NVR.TabIndex = 8;
            this.ToolTipSuppliers_NVR.SetToolTip(this.ButtonOpenSuppliers_NVR, "Загрузить данные");
            this.ButtonOpenSuppliers_NVR.UseVisualStyleBackColor = true;
            this.ButtonOpenSuppliers_NVR.Click += new System.EventHandler(this.ButtonOpenSuppliers_NVR_Click);
            // 
            // OpenFileDialogSuppliers_NVR
            // 
            this.OpenFileDialogSuppliers_NVR.FileName = "openFileDialog1";
            // 
            // PanelLeftSuppliers_NVR
            // 
            this.PanelLeftSuppliers_NVR.Controls.Add(this.DataGridViewSuppliers_NVR);
            this.PanelLeftSuppliers_NVR.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftSuppliers_NVR.Location = new System.Drawing.Point(0, 100);
            this.PanelLeftSuppliers_NVR.Name = "PanelLeftSuppliers_NVR";
            this.PanelLeftSuppliers_NVR.Size = new System.Drawing.Size(698, 581);
            this.PanelLeftSuppliers_NVR.TabIndex = 9;
            // 
            // ToolTipSuppliers_NVR
            // 
            this.ToolTipSuppliers_NVR.ToolTipTitle = "Подсказка";
            // 
            // ButtonAddSuppliers_NVR
            // 
            this.ButtonAddSuppliers_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAddSuppliers_NVR.BackgroundImage")));
            this.ButtonAddSuppliers_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonAddSuppliers_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddSuppliers_NVR.Location = new System.Drawing.Point(704, 230);
            this.ButtonAddSuppliers_NVR.Name = "ButtonAddSuppliers_NVR";
            this.ButtonAddSuppliers_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonAddSuppliers_NVR.TabIndex = 13;
            this.ToolTipSuppliers_NVR.SetToolTip(this.ButtonAddSuppliers_NVR, "Добавить строку");
            this.ButtonAddSuppliers_NVR.UseVisualStyleBackColor = true;
            this.ButtonAddSuppliers_NVR.Click += new System.EventHandler(this.ButtonAddSuppliers_NVR_Click_1);
            // 
            // ButtonDelete_NVR
            // 
            this.ButtonDelete_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete_NVR.BackgroundImage")));
            this.ButtonDelete_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDelete_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete_NVR.Location = new System.Drawing.Point(704, 292);
            this.ButtonDelete_NVR.Name = "ButtonDelete_NVR";
            this.ButtonDelete_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonDelete_NVR.TabIndex = 19;
            this.ToolTipSuppliers_NVR.SetToolTip(this.ButtonDelete_NVR, "Удалить строку");
            this.ButtonDelete_NVR.UseVisualStyleBackColor = true;
            this.ButtonDelete_NVR.Click += new System.EventHandler(this.ButtonDelete_NVR_Click_1);
            // 
            // ButtonSuppliersSave_NVR
            // 
            this.ButtonSuppliersSave_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSuppliersSave_NVR.BackgroundImage")));
            this.ButtonSuppliersSave_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSuppliersSave_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSuppliersSave_NVR.Location = new System.Drawing.Point(704, 168);
            this.ButtonSuppliersSave_NVR.Name = "ButtonSuppliersSave_NVR";
            this.ButtonSuppliersSave_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonSuppliersSave_NVR.TabIndex = 20;
            this.ToolTipSuppliers_NVR.SetToolTip(this.ButtonSuppliersSave_NVR, "Сохранить данные");
            this.ButtonSuppliersSave_NVR.UseVisualStyleBackColor = true;
            this.ButtonSuppliersSave_NVR.Click += new System.EventHandler(this.ButtonSuppliersSave_NVR_Click);
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ButtonSuppliersSave_NVR);
            this.Controls.Add(this.ButtonDelete_NVR);
            this.Controls.Add(this.ButtonAddSuppliers_NVR);
            this.Controls.Add(this.PanelLeftSuppliers_NVR);
            this.Controls.Add(this.ButtonOpenSuppliers_NVR);
            this.Controls.Add(this.GroupBoxFiltSuppliers_NVR);
            this.Controls.Add(this.PanelTopSuppliers_NVR);
            this.Name = "FormSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelTopSuppliers_NVR.ResumeLayout(false);
            this.PanelTopSuppliers_NVR.PerformLayout();
            this.GroupBoxFiltSuppliers_NVR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuppliers_NVR)).EndInit();
            this.PanelLeftSuppliers_NVR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopSuppliers_NVR;
        private System.Windows.Forms.Button ButtonBackSuppliers_NVR;
        private System.Windows.Forms.GroupBox GroupBoxFiltSuppliers_NVR;
        private System.Windows.Forms.ComboBox ComboBoxFiltSuppliers_NVR;
        private System.Windows.Forms.DataGridView DataGridViewSuppliers_NVR;
        private System.Windows.Forms.Label LabelNameSuppliers_NVR;
        private System.Windows.Forms.Button ButtonOpenSuppliers_NVR;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogSuppliers_NVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthS;
        private System.Windows.Forms.Panel PanelLeftSuppliers_NVR;
        private System.Windows.Forms.ToolTip ToolTipSuppliers_NVR;
        private System.Windows.Forms.Button ButtonAddSuppliers_NVR;
        private System.Windows.Forms.Button ButtonDelete_NVR;
        private System.Windows.Forms.Button ButtonSuppliersSave_NVR;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogSuppliers_NVR;
    }
}