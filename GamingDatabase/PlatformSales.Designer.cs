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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uxStartYear = new System.Windows.Forms.TextBox();
            this.uxEndYear = new System.Windows.Forms.TextBox();
            this.uxPlatform = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxFilterPlatformSales = new System.Windows.Forms.Button();
            this.uxMinDollarAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxMaxDollarAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(893, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // uxStartYear
            // 
            this.uxStartYear.Location = new System.Drawing.Point(132, 32);
            this.uxStartYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxStartYear.Name = "uxStartYear";
            this.uxStartYear.Size = new System.Drawing.Size(172, 22);
            this.uxStartYear.TabIndex = 1;
            // 
            // uxEndYear
            // 
            this.uxEndYear.Location = new System.Drawing.Point(441, 32);
            this.uxEndYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxEndYear.Name = "uxEndYear";
            this.uxEndYear.Size = new System.Drawing.Size(172, 22);
            this.uxEndYear.TabIndex = 1;
            // 
            // uxPlatform
            // 
            this.uxPlatform.Location = new System.Drawing.Point(721, 32);
            this.uxPlatform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxPlatform.Name = "uxPlatform";
            this.uxPlatform.Size = new System.Drawing.Size(172, 22);
            this.uxPlatform.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Platform";
            // 
            // uxFilterPlatformSales
            // 
            this.uxFilterPlatformSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFilterPlatformSales.Location = new System.Drawing.Point(327, 138);
            this.uxFilterPlatformSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxFilterPlatformSales.Name = "uxFilterPlatformSales";
            this.uxFilterPlatformSales.Size = new System.Drawing.Size(228, 32);
            this.uxFilterPlatformSales.TabIndex = 3;
            this.uxFilterPlatformSales.Text = "Filter";
            this.uxFilterPlatformSales.UseVisualStyleBackColor = true;
            this.uxFilterPlatformSales.Click += new System.EventHandler(this.uxFilterPlatformSales_Click);
            // 
            // uxMinDollarAmount
            // 
            this.uxMinDollarAmount.Location = new System.Drawing.Point(171, 92);
            this.uxMinDollarAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMinDollarAmount.Name = "uxMinDollarAmount";
            this.uxMinDollarAmount.Size = new System.Drawing.Size(191, 22);
            this.uxMinDollarAmount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Min Dollar Amount";
            // 
            // uxMaxDollarAmount
            // 
            this.uxMaxDollarAmount.Location = new System.Drawing.Point(657, 92);
            this.uxMaxDollarAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxMaxDollarAmount.Name = "uxMaxDollarAmount";
            this.uxMaxDollarAmount.Size = new System.Drawing.Size(191, 22);
            this.uxMaxDollarAmount.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max Dollar Amount";
            // 
            // PlatformSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 554);
            this.Controls.Add(this.uxMaxDollarAmount);
            this.Controls.Add(this.uxMinDollarAmount);
            this.Controls.Add(this.uxFilterPlatformSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPlatform);
            this.Controls.Add(this.uxEndYear);
            this.Controls.Add(this.uxStartYear);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PlatformSales";
            this.Text = "PlatformSales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox uxStartYear;
        private System.Windows.Forms.TextBox uxEndYear;
        private System.Windows.Forms.TextBox uxPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxFilterPlatformSales;
        private System.Windows.Forms.TextBox uxMinDollarAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxMaxDollarAmount;
        private System.Windows.Forms.Label label5;
    }
}