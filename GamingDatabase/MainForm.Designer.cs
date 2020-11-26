﻿namespace GamingDatabase
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
            this.uxLookupGameButton.Text = "Lookup Game";
            this.uxLookupGameButton.UseVisualStyleBackColor = true;
            this.uxLookupGameButton.Click += new System.EventHandler(this.uxLookupGameButton_Click);
            // 
            // uxCompanyLookupButton
            // 
            this.uxCompanyLookupButton.Location = new System.Drawing.Point(22, 116);
            this.uxCompanyLookupButton.Name = "uxCompanyLookupButton";
            this.uxCompanyLookupButton.Size = new System.Drawing.Size(124, 53);
            this.uxCompanyLookupButton.TabIndex = 2;
            this.uxCompanyLookupButton.Text = "Lookup Company";
            this.uxCompanyLookupButton.UseVisualStyleBackColor = true;
            this.uxCompanyLookupButton.Click += new System.EventHandler(this.uxCompanyLookupButton_Click);
            // 
            // uxUpdateGameButton
            // 
            this.uxUpdateGameButton.Location = new System.Drawing.Point(396, 31);
            this.uxUpdateGameButton.Name = "uxUpdateGameButton";
            this.uxUpdateGameButton.Size = new System.Drawing.Size(124, 53);
            this.uxUpdateGameButton.TabIndex = 3;
            this.uxUpdateGameButton.Text = "Update Game";
            this.uxUpdateGameButton.UseVisualStyleBackColor = true;
            this.uxUpdateGameButton.Click += new System.EventHandler(this.uxUpdateGameButton_Click);
            // 
            // uxPlatformSalesButton
            // 
            this.uxPlatformSalesButton.Location = new System.Drawing.Point(216, 116);
            this.uxPlatformSalesButton.Name = "uxPlatformSalesButton";
            this.uxPlatformSalesButton.Size = new System.Drawing.Size(124, 53);
            this.uxPlatformSalesButton.TabIndex = 4;
            this.uxPlatformSalesButton.Text = "Platform Sales";
            this.uxPlatformSalesButton.UseVisualStyleBackColor = true;
            this.uxPlatformSalesButton.Click += new System.EventHandler(this.uxPlatformSalesButton_Click);
            // 
            // uxGameSalesButton
            // 
            this.uxGameSalesButton.Location = new System.Drawing.Point(396, 116);
            this.uxGameSalesButton.Name = "uxGameSalesButton";
            this.uxGameSalesButton.Size = new System.Drawing.Size(124, 53);
            this.uxGameSalesButton.TabIndex = 5;
            this.uxGameSalesButton.Text = "Game Sales";
            this.uxGameSalesButton.UseVisualStyleBackColor = true;
            this.uxGameSalesButton.Click += new System.EventHandler(this.uxGameSalesButton_Click);
            // 
            // GamingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 409);
            this.Controls.Add(this.uxGameSalesButton);
            this.Controls.Add(this.uxPlatformSalesButton);
            this.Controls.Add(this.uxUpdateGameButton);
            this.Controls.Add(this.uxCompanyLookupButton);
            this.Controls.Add(this.uxLookupGameButton);
            this.Controls.Add(this.uxAddGameButton);
            this.Name = "GamingDatabase";
            this.Text = "Gaming Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxAddGameButton;
        private System.Windows.Forms.Button uxLookupGameButton;
        private System.Windows.Forms.Button uxCompanyLookupButton;
        private System.Windows.Forms.Button uxUpdateGameButton;
        private System.Windows.Forms.Button uxPlatformSalesButton;
        private System.Windows.Forms.Button uxGameSalesButton;
    }
}
