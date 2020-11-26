namespace GamingDatabase
{
    partial class PlatformSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxPlatformName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxYear = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uxPlatformSalesLookup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Platform Name";
            // 
            // uxPlatformName
            // 
            this.uxPlatformName.Location = new System.Drawing.Point(121, 23);
            this.uxPlatformName.Name = "uxPlatformName";
            this.uxPlatformName.Size = new System.Drawing.Size(159, 22);
            this.uxPlatformName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // uxYear
            // 
            this.uxYear.Location = new System.Drawing.Point(121, 71);
            this.uxYear.Name = "uxYear";
            this.uxYear.Size = new System.Drawing.Size(159, 22);
            this.uxYear.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 280);
            this.dataGridView1.TabIndex = 4;
            // 
            // uxPlatformSalesLookup
            // 
            this.uxPlatformSalesLookup.Location = new System.Drawing.Point(323, 23);
            this.uxPlatformSalesLookup.Name = "uxPlatformSalesLookup";
            this.uxPlatformSalesLookup.Size = new System.Drawing.Size(172, 71);
            this.uxPlatformSalesLookup.TabIndex = 5;
            this.uxPlatformSalesLookup.Text = "Lookup Platform Sales";
            this.uxPlatformSalesLookup.UseVisualStyleBackColor = true;
            // 
            // PlatformSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 409);
            this.Controls.Add(this.uxPlatformSalesLookup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxPlatformName);
            this.Controls.Add(this.label1);
            this.Name = "PlatformSales";
            this.Text = "Platform Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxPlatformName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxYear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uxPlatformSalesLookup;
    }
}