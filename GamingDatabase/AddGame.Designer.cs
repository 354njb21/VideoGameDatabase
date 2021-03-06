﻿namespace GamingDatabase
{
    partial class AddGame
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxCompanyID = new System.Windows.Forms.TextBox();
            this.uxYearReleased = new System.Windows.Forms.TextBox();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uxReviewScore = new System.Windows.Forms.TextBox();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxGenre = new System.Windows.Forms.ComboBox();
            this.uxRating = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "What game would you like to add?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "CompanyID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Year Released";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            // 
            // uxCompanyID
            // 
            this.uxCompanyID.Location = new System.Drawing.Point(163, 63);
            this.uxCompanyID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxCompanyID.Name = "uxCompanyID";
            this.uxCompanyID.Size = new System.Drawing.Size(327, 22);
            this.uxCompanyID.TabIndex = 0;
            // 
            // uxYearReleased
            // 
            this.uxYearReleased.Location = new System.Drawing.Point(163, 250);
            this.uxYearReleased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxYearReleased.Name = "uxYearReleased";
            this.uxYearReleased.Size = new System.Drawing.Size(327, 22);
            this.uxYearReleased.TabIndex = 4;
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(163, 118);
            this.uxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(327, 22);
            this.uxName.TabIndex = 1;
            // 
            // uxPrice
            // 
            this.uxPrice.Location = new System.Drawing.Point(163, 292);
            this.uxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPrice.Name = "uxPrice";
            this.uxPrice.Size = new System.Drawing.Size(327, 22);
            this.uxPrice.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Review Score (0-100)";
            // 
            // uxReviewScore
            // 
            this.uxReviewScore.Location = new System.Drawing.Point(163, 338);
            this.uxReviewScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxReviewScore.Name = "uxReviewScore";
            this.uxReviewScore.Size = new System.Drawing.Size(327, 22);
            this.uxReviewScore.TabIndex = 6;
            // 
            // uxAddButton
            // 
            this.uxAddButton.Location = new System.Drawing.Point(163, 379);
            this.uxAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(327, 37);
            this.uxAddButton.TabIndex = 7;
            this.uxAddButton.Text = "Add Game";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // uxGenre
            // 
            this.uxGenre.FormattingEnabled = true;
            this.uxGenre.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Educational",
            "Racing / Driving",
            "Role-Playing (RPG)",
            "Simulation",
            "Sports",
            "Strategy"});
            this.uxGenre.Location = new System.Drawing.Point(164, 162);
            this.uxGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(327, 24);
            this.uxGenre.TabIndex = 2;
            // 
            // uxRating
            // 
            this.uxRating.FormattingEnabled = true;
            this.uxRating.Items.AddRange(new object[] {
            "E",
            "T",
            "M",
            "NR"});
            this.uxRating.Location = new System.Drawing.Point(164, 207);
            this.uxRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxRating.Name = "uxRating";
            this.uxRating.Size = new System.Drawing.Size(327, 24);
            this.uxRating.TabIndex = 3;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 428);
            this.Controls.Add(this.uxRating);
            this.Controls.Add(this.uxGenre);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.uxReviewScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxPrice);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxYearReleased);
            this.Controls.Add(this.uxCompanyID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddGame";
            this.Text = "Add Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uxCompanyID;
        private System.Windows.Forms.TextBox uxYearReleased;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxReviewScore;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.ComboBox uxGenre;
        private System.Windows.Forms.ComboBox uxRating;
    }
}