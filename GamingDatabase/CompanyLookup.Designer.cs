namespace GamingDatabase
{
    partial class CompanyLookup
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.uxCompanyName = new System.Windows.Forms.TextBox();
            this.uxFindCompanyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 350);
            this.dataGridView.TabIndex = 0;
            // 
            // uxCompanyName
            // 
            this.uxCompanyName.Location = new System.Drawing.Point(114, 31);
            this.uxCompanyName.Name = "uxCompanyName";
            this.uxCompanyName.Size = new System.Drawing.Size(168, 22);
            this.uxCompanyName.TabIndex = 1;
            // 
            // uxFindCompanyBtn
            // 
            this.uxFindCompanyBtn.Location = new System.Drawing.Point(321, 26);
            this.uxFindCompanyBtn.Name = "uxFindCompanyBtn";
            this.uxFindCompanyBtn.Size = new System.Drawing.Size(138, 32);
            this.uxFindCompanyBtn.TabIndex = 2;
            this.uxFindCompanyBtn.Text = "Find Company";
            this.uxFindCompanyBtn.UseVisualStyleBackColor = true;
            this.uxFindCompanyBtn.Click += new System.EventHandler(this.uxFindCompanyBtn_Click);
            // 
            // CompanyLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxFindCompanyBtn);
            this.Controls.Add(this.uxCompanyName);
            this.Controls.Add(this.dataGridView);
            this.Name = "CompanyLookup";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox uxCompanyName;
        private System.Windows.Forms.Button uxFindCompanyBtn;
    }
}