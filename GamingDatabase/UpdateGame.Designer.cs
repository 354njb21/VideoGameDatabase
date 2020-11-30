namespace GamingDatabase
{
    partial class UpdateGame
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
            this.uxGameName = new System.Windows.Forms.TextBox();
            this.uxYearReleased = new System.Windows.Forms.TextBox();
            this.uxPrice = new System.Windows.Forms.TextBox();
            this.uxGameReviewScore = new System.Windows.Forms.TextBox();
            this.uxGameGenre = new System.Windows.Forms.ComboBox();
            this.uxGameRating = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxUpdateGameButton = new System.Windows.Forms.Button();
            this.uxGameID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxCompanyID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxGameName
            // 
            this.uxGameName.Location = new System.Drawing.Point(176, 95);
            this.uxGameName.Margin = new System.Windows.Forms.Padding(4);
            this.uxGameName.Name = "uxGameName";
            this.uxGameName.Size = new System.Drawing.Size(313, 22);
            this.uxGameName.TabIndex = 2;
            // 
            // uxYearReleased
            // 
            this.uxYearReleased.Location = new System.Drawing.Point(176, 238);
            this.uxYearReleased.Margin = new System.Windows.Forms.Padding(4);
            this.uxYearReleased.Name = "uxYearReleased";
            this.uxYearReleased.Size = new System.Drawing.Size(313, 22);
            this.uxYearReleased.TabIndex = 5;
            // 
            // uxPrice
            // 
            this.uxPrice.Location = new System.Drawing.Point(176, 290);
            this.uxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.uxPrice.Name = "uxPrice";
            this.uxPrice.Size = new System.Drawing.Size(313, 22);
            this.uxPrice.TabIndex = 6;
            // 
            // uxGameReviewScore
            // 
            this.uxGameReviewScore.Location = new System.Drawing.Point(176, 343);
            this.uxGameReviewScore.Margin = new System.Windows.Forms.Padding(4);
            this.uxGameReviewScore.Name = "uxGameReviewScore";
            this.uxGameReviewScore.Size = new System.Drawing.Size(313, 22);
            this.uxGameReviewScore.TabIndex = 7;
            // 
            // uxGameGenre
            // 
            this.uxGameGenre.FormattingEnabled = true;
            this.uxGameGenre.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Educational",
            "Racing / Driving",
            "Role-Playing (RPG)",
            "Simulation",
            "Sports",
            "Strategy"});
            this.uxGameGenre.Location = new System.Drawing.Point(176, 139);
            this.uxGameGenre.Margin = new System.Windows.Forms.Padding(4);
            this.uxGameGenre.Name = "uxGameGenre";
            this.uxGameGenre.Size = new System.Drawing.Size(313, 24);
            this.uxGameGenre.TabIndex = 3;
            // 
            // uxGameRating
            // 
            this.uxGameRating.FormattingEnabled = true;
            this.uxGameRating.Items.AddRange(new object[] {
            "E",
            "T",
            "M",
            "NR"});
            this.uxGameRating.Location = new System.Drawing.Point(176, 190);
            this.uxGameRating.Margin = new System.Windows.Forms.Padding(4);
            this.uxGameRating.Name = "uxGameRating";
            this.uxGameRating.Size = new System.Drawing.Size(313, 24);
            this.uxGameRating.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Year Released";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Review Score (0-100)";
            // 
            // uxUpdateGameButton
            // 
            this.uxUpdateGameButton.Location = new System.Drawing.Point(247, 390);
            this.uxUpdateGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.uxUpdateGameButton.Name = "uxUpdateGameButton";
            this.uxUpdateGameButton.Size = new System.Drawing.Size(168, 28);
            this.uxUpdateGameButton.TabIndex = 8;
            this.uxUpdateGameButton.Text = "Update Game";
            this.uxUpdateGameButton.UseVisualStyleBackColor = true;
            this.uxUpdateGameButton.Click += new System.EventHandler(this.uxUpdateGameButton_Click);
            // 
            // uxGameID
            // 
            this.uxGameID.Location = new System.Drawing.Point(176, 17);
            this.uxGameID.Name = "uxGameID";
            this.uxGameID.Size = new System.Drawing.Size(313, 22);
            this.uxGameID.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "GameID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "CompanyID";
            // 
            // uxCompanyID
            // 
            this.uxCompanyID.Location = new System.Drawing.Point(176, 57);
            this.uxCompanyID.Name = "uxCompanyID";
            this.uxCompanyID.Size = new System.Drawing.Size(313, 22);
            this.uxCompanyID.TabIndex = 1;
            // 
            // UpdateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 433);
            this.Controls.Add(this.uxCompanyID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uxGameID);
            this.Controls.Add(this.uxUpdateGameButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGameRating);
            this.Controls.Add(this.uxGameGenre);
            this.Controls.Add(this.uxGameReviewScore);
            this.Controls.Add(this.uxPrice);
            this.Controls.Add(this.uxYearReleased);
            this.Controls.Add(this.uxGameName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateGame";
            this.Text = "UpdateGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxGameName;
        private System.Windows.Forms.TextBox uxYearReleased;
        private System.Windows.Forms.TextBox uxPrice;
        private System.Windows.Forms.TextBox uxGameReviewScore;
        private System.Windows.Forms.ComboBox uxGameGenre;
        private System.Windows.Forms.ComboBox uxGameRating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button uxUpdateGameButton;
        private System.Windows.Forms.TextBox uxGameID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox uxCompanyID;
    }
}