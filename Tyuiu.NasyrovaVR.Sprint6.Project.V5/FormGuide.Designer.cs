namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.TextBoxGuide_NVR = new System.Windows.Forms.TextBox();
            this.ButtonOkGuide_NVR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxGuide_NVR
            // 
            this.TextBoxGuide_NVR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxGuide_NVR.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxGuide_NVR.Location = new System.Drawing.Point(12, 12);
            this.TextBoxGuide_NVR.Multiline = true;
            this.TextBoxGuide_NVR.Name = "TextBoxGuide_NVR";
            this.TextBoxGuide_NVR.ReadOnly = true;
            this.TextBoxGuide_NVR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxGuide_NVR.Size = new System.Drawing.Size(748, 502);
            this.TextBoxGuide_NVR.TabIndex = 3;
            this.TextBoxGuide_NVR.TabStop = false;
            this.TextBoxGuide_NVR.Text = resources.GetString("TextBoxGuide_NVR.Text");
            // 
            // ButtonOkGuide_NVR
            // 
            this.ButtonOkGuide_NVR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOkGuide_NVR.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOkGuide_NVR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOkGuide_NVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOkGuide_NVR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOkGuide_NVR.Location = new System.Drawing.Point(634, 530);
            this.ButtonOkGuide_NVR.Name = "ButtonOkGuide_NVR";
            this.ButtonOkGuide_NVR.Size = new System.Drawing.Size(96, 36);
            this.ButtonOkGuide_NVR.TabIndex = 4;
            this.ButtonOkGuide_NVR.Text = "Ок";
            this.ButtonOkGuide_NVR.UseVisualStyleBackColor = false;
            this.ButtonOkGuide_NVR.Click += new System.EventHandler(this.ButtonOkGuide_NVR_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 578);
            this.Controls.Add(this.ButtonOkGuide_NVR);
            this.Controls.Add(this.TextBoxGuide_NVR);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxGuide_NVR;
        private System.Windows.Forms.Button ButtonOkGuide_NVR;
    }
}