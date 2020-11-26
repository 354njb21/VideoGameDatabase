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
            this.uxGameName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uxLookupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Name";
            // 
            // uxGameName
            // 
            this.uxGameName.Location = new System.Drawing.Point(107, 28);
            this.uxGameName.Name = "uxGameName";
            this.uxGameName.Size = new System.Drawing.Size(243, 22);
            this.uxGameName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(441, 268);
            this.dataGridView1.TabIndex = 2;
            // 
            // uxLookupButton
            // 
            this.uxLookupButton.Location = new System.Drawing.Point(380, 24);
            this.uxLookupButton.Name = "uxLookupButton";
            this.uxLookupButton.Size = new System.Drawing.Size(101, 30);
            this.uxLookupButton.TabIndex = 3;
            this.uxLookupButton.Text = "Lookup Sales";
            this.uxLookupButton.UseVisualStyleBackColor = true;
            // 
            // GameSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 378);
            this.Controls.Add(this.uxLookupButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxGameName);
            this.Controls.Add(this.label1);
            this.Name = "GameSales";
            this.Text = "Game Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxGameName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uxLookupButton;
    }
}