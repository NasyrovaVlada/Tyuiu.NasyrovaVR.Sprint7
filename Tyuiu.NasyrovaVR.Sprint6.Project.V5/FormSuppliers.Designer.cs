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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuppliers));
            this.PanelTopSuppliers_NVR = new System.Windows.Forms.Panel();
            this.ButtonBackSuppliers_NVR = new System.Windows.Forms.Button();
            this.GroupBoxSortSuppliers_NVR = new System.Windows.Forms.GroupBox();
            this.ComboBoxSortSuppliers_NVR = new System.Windows.Forms.ComboBox();
            this.DataGridViewSuppliers_NVR = new System.Windows.Forms.DataGridView();
            this.NumS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelNameSuppliers_NVR = new System.Windows.Forms.Label();
            this.ButtonOpenSuppliers_NVR = new System.Windows.Forms.Button();
            this.PanelTopSuppliers_NVR.SuspendLayout();
            this.GroupBoxSortSuppliers_NVR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuppliers_NVR)).BeginInit();
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
            this.PanelTopSuppliers_NVR.Size = new System.Drawing.Size(1008, 100);
            this.PanelTopSuppliers_NVR.TabIndex = 0;
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
            // GroupBoxSortSuppliers_NVR
            // 
            this.GroupBoxSortSuppliers_NVR.Controls.Add(this.ComboBoxSortSuppliers_NVR);
            this.GroupBoxSortSuppliers_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxSortSuppliers_NVR.Location = new System.Drawing.Point(227, 121);
            this.GroupBoxSortSuppliers_NVR.Name = "GroupBoxSortSuppliers_NVR";
            this.GroupBoxSortSuppliers_NVR.Size = new System.Drawing.Size(288, 77);
            this.GroupBoxSortSuppliers_NVR.TabIndex = 4;
            this.GroupBoxSortSuppliers_NVR.TabStop = false;
            this.GroupBoxSortSuppliers_NVR.Text = "Сортировка";
            // 
            // ComboBoxSortSuppliers_NVR
            // 
            this.ComboBoxSortSuppliers_NVR.FormattingEnabled = true;
            this.ComboBoxSortSuppliers_NVR.Location = new System.Drawing.Point(6, 42);
            this.ComboBoxSortSuppliers_NVR.Name = "ComboBoxSortSuppliers_NVR";
            this.ComboBoxSortSuppliers_NVR.Size = new System.Drawing.Size(276, 29);
            this.ComboBoxSortSuppliers_NVR.TabIndex = 0;
            // 
            // DataGridViewSuppliers_NVR
            // 
            this.DataGridViewSuppliers_NVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewSuppliers_NVR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumS,
            this.NameS,
            this.DateS});
            this.DataGridViewSuppliers_NVR.Location = new System.Drawing.Point(227, 204);
            this.DataGridViewSuppliers_NVR.Name = "DataGridViewSuppliers_NVR";
            this.DataGridViewSuppliers_NVR.RowHeadersVisible = false;
            this.DataGridViewSuppliers_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewSuppliers_NVR.Size = new System.Drawing.Size(546, 385);
            this.DataGridViewSuppliers_NVR.TabIndex = 5;
            // 
            // NumS
            // 
            this.NumS.HeaderText = "Номер поставщика";
            this.NumS.Name = "NumS";
            this.NumS.Width = 150;
            // 
            // NameS
            // 
            this.NameS.HeaderText = "Поставщик";
            this.NameS.Name = "NameS";
            this.NameS.Width = 200;
            // 
            // DateS
            // 
            this.DateS.HeaderText = "Дата ближайшей поставки";
            this.DateS.Name = "DateS";
            this.DateS.Width = 200;
            // 
            // LabelNameSuppliers_NVR
            // 
            this.LabelNameSuppliers_NVR.AutoSize = true;
            this.LabelNameSuppliers_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameSuppliers_NVR.ForeColor = System.Drawing.Color.White;
            this.LabelNameSuppliers_NVR.Location = new System.Drawing.Point(203, 25);
            this.LabelNameSuppliers_NVR.Name = "LabelNameSuppliers_NVR";
            this.LabelNameSuppliers_NVR.Size = new System.Drawing.Size(606, 47);
            this.LabelNameSuppliers_NVR.TabIndex = 14;
            this.LabelNameSuppliers_NVR.Text = "ИНФОРМАЦИЯ О ПОСТАВЩИКАХ";
            // 
            // ButtonOpenSuppliers_NVR
            // 
            this.ButtonOpenSuppliers_NVR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonOpenSuppliers_NVR.BackgroundImage")));
            this.ButtonOpenSuppliers_NVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpenSuppliers_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOpenSuppliers_NVR.Location = new System.Drawing.Point(694, 142);
            this.ButtonOpenSuppliers_NVR.Name = "ButtonOpenSuppliers_NVR";
            this.ButtonOpenSuppliers_NVR.Size = new System.Drawing.Size(79, 56);
            this.ButtonOpenSuppliers_NVR.TabIndex = 8;
            this.ButtonOpenSuppliers_NVR.UseVisualStyleBackColor = true;
            // 
            // FormSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.ButtonOpenSuppliers_NVR);
            this.Controls.Add(this.DataGridViewSuppliers_NVR);
            this.Controls.Add(this.GroupBoxSortSuppliers_NVR);
            this.Controls.Add(this.PanelTopSuppliers_NVR);
            this.Name = "FormSuppliers";
            this.PanelTopSuppliers_NVR.ResumeLayout(false);
            this.PanelTopSuppliers_NVR.PerformLayout();
            this.GroupBoxSortSuppliers_NVR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSuppliers_NVR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTopSuppliers_NVR;
        private System.Windows.Forms.Button ButtonBackSuppliers_NVR;
        private System.Windows.Forms.GroupBox GroupBoxSortSuppliers_NVR;
        private System.Windows.Forms.ComboBox ComboBoxSortSuppliers_NVR;
        private System.Windows.Forms.DataGridView DataGridViewSuppliers_NVR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateS;
        private System.Windows.Forms.Label LabelNameSuppliers_NVR;
        private System.Windows.Forms.Button ButtonOpenSuppliers_NVR;
    }
}