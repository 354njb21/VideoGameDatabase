namespace GamingDatabase
{
    partial class GamingDatabase
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
            this.uxAddGameButton = new System.Windows.Forms.Button();
            this.uxLookupGameButton = new System.Windows.Forms.Button();
            this.uxCompanyLookupButton = new System.Windows.Forms.Button();
            this.uxUpdateGameButton = new System.Windows.Forms.Button();
            this.uxPlatformSalesButton = new System.Windows.Forms.Button();
            this.uxGameSalesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAddGameButton
            // 
            this.uxAddGameButton.Location = new System.Drawing.Point(22, 31);
            this.uxAddGameButton.Name = "uxAddGameButton";
            this.uxAddGameButton.Size = new System.Drawing.Size(124, 53);
            this.uxAddGameButton.TabIndex = 0;
            this.uxAddGameButton.Text = "Add Game";
            this.uxAddGameButton.UseVisualStyleBackColor = true;
            this.uxAddGameButton.Click += new System.EventHandler(this.uxAddGameButton_Click);
            // 
            // uxLookupGameButton
            // 
            this.uxLookupGameButton.Location = new System.Drawing.Point(216, 31);
            this.uxLookupGameButton.Name = "uxLookupGameButton";
            this.uxLookupGameButton.Size = new System.Drawing.Size(124, 53);
            this.uxLookupGameButton.TabIndex = 1;
            this.uxLookupGameButton.Text = "Game Lookup";
            this.uxLookupGameButton.UseVisualStyleBackColor = true;
            // 
            // uxCompanyLookupButton
            // 
            this.uxCompanyLookupButton.Location = new System.Drawing.Point(396, 31);
            this.uxCompanyLookupButton.Name = "uxCompanyLookupButton";
            this.uxCompanyLookupButton.Size = new System.Drawing.Size(124, 53);
            this.uxCompanyLookupButton.TabIndex = 2;
            this.uxCompanyLookupButton.Text = "Lookup Company";
            this.uxCompanyLookupButton.UseVisualStyleBackColor = true;
            this.uxCompanyLookupButton.Click += new System.EventHandler(this.uxCompanyLookupButton_Click);
            // 
            // uxUpdateGameButton
            // 
            this.uxUpdateGameButton.Location = new System.Drawing.Point(22, 116);
            this.uxUpdateGameButton.Name = "uxUpdateGameButton";
            this.uxUpdateGameButton.Size = new System.Drawing.Size(124, 53);
            this.uxUpdateGameButton.TabIndex = 3;
            this.uxUpdateGameButton.Text = "Update Game";
            this.uxUpdateGameButton.UseVisualStyleBackColor = true;
            // 
            // uxPlatformSalesButton
            // 
            this.uxPlatformSalesButton.Location = new System.Drawing.Point(216, 116);
            this.uxPlatformSalesButton.Name = "uxPlatformSalesButton";
            this.uxPlatformSalesButton.Size = new System.Drawing.Size(124, 53);
            this.uxPlatformSalesButton.TabIndex = 4;
            this.uxPlatformSalesButton.Text = "Platform Sales";
            this.uxPlatformSalesButton.UseVisualStyleBackColor = true;
            // 
            // uxGameSalesButton
            // 
            this.uxGameSalesButton.Location = new System.Drawing.Point(396, 116);
            this.uxGameSalesButton.Name = "uxGameSalesButton";
            this.uxGameSalesButton.Size = new System.Drawing.Size(124, 53);
            this.uxGameSalesButton.TabIndex = 5;
            this.uxGameSalesButton.Text = "Game Sales";
            this.uxGameSalesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Report Query";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Report Query";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Report Query";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Report Query";
            // 
            // GamingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGameSalesButton);
            this.Controls.Add(this.uxPlatformSalesButton);
            this.Controls.Add(this.uxUpdateGameButton);
            this.Controls.Add(this.uxCompanyLookupButton);
            this.Controls.Add(this.uxLookupGameButton);
            this.Controls.Add(this.uxAddGameButton);
            this.Name = "GamingDatabase";
            this.Text = "Gaming Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddGameButton;
        private System.Windows.Forms.Button uxLookupGameButton;
        private System.Windows.Forms.Button uxCompanyLookupButton;
        private System.Windows.Forms.Button uxUpdateGameButton;
        private System.Windows.Forms.Button uxPlatformSalesButton;
        private System.Windows.Forms.Button uxGameSalesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

