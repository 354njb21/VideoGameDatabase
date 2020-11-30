namespace GamingDatabase
{
    partial class GameSales
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uxGameSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.uxPlatformName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxGameSalesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter The Game Sales Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Platform Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(305, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.uxFilterBtn_Click);
            // 
            // uxGameSalesDataGridView
            // 
            this.uxGameSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGameSalesDataGridView.Location = new System.Drawing.Point(16, 202);
            this.uxGameSalesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxGameSalesDataGridView.Name = "uxGameSalesDataGridView";
            this.uxGameSalesDataGridView.RowHeadersWidth = 51;
            this.uxGameSalesDataGridView.Size = new System.Drawing.Size(887, 451);
            this.uxGameSalesDataGridView.TabIndex = 6;
            // 
            // uxPlatformName
            // 
            this.uxPlatformName.FormattingEnabled = true;
            this.uxPlatformName.Items.AddRange(new object[] {
            "Nintendo DS",
            "Nintendo Wii",
            "Playstation 3",
            "Sony PSP",
            "Xbox 360"});
            this.uxPlatformName.Location = new System.Drawing.Point(176, 80);
            this.uxPlatformName.Name = "uxPlatformName";
            this.uxPlatformName.Size = new System.Drawing.Size(309, 24);
            this.uxPlatformName.TabIndex = 7;
            // 
            // GameSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 667);
            this.Controls.Add(this.uxPlatformName);
            this.Controls.Add(this.uxGameSalesDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameSales";
            this.Text = "GameSales";
            ((System.ComponentModel.ISupportInitialize)(this.uxGameSalesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView uxGameSalesDataGridView;
        private System.Windows.Forms.ComboBox uxPlatformName;
    }
}