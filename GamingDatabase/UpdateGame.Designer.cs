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
            this.uxGamePrice = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // uxGameName
            // 
            this.uxGameName.Location = new System.Drawing.Point(132, 77);
            this.uxGameName.Name = "uxGameName";
            this.uxGameName.Size = new System.Drawing.Size(236, 20);
            this.uxGameName.TabIndex = 0;
            // 
            // uxYearReleased
            // 
            this.uxYearReleased.Location = new System.Drawing.Point(132, 193);
            this.uxYearReleased.Name = "uxYearReleased";
            this.uxYearReleased.Size = new System.Drawing.Size(236, 20);
            this.uxYearReleased.TabIndex = 0;
            // 
            // uxGamePrice
            // 
            this.uxGamePrice.Location = new System.Drawing.Point(132, 236);
            this.uxGamePrice.Name = "uxGamePrice";
            this.uxGamePrice.Size = new System.Drawing.Size(236, 20);
            this.uxGamePrice.TabIndex = 0;
            // 
            // uxGameReviewScore
            // 
            this.uxGameReviewScore.Location = new System.Drawing.Point(132, 279);
            this.uxGameReviewScore.Name = "uxGameReviewScore";
            this.uxGameReviewScore.Size = new System.Drawing.Size(236, 20);
            this.uxGameReviewScore.TabIndex = 0;
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
            this.uxGameGenre.Location = new System.Drawing.Point(132, 113);
            this.uxGameGenre.Name = "uxGameGenre";
            this.uxGameGenre.Size = new System.Drawing.Size(236, 21);
            this.uxGameGenre.TabIndex = 1;
            // 
            // uxGameRating
            // 
            this.uxGameRating.FormattingEnabled = true;
            this.uxGameRating.Items.AddRange(new object[] {
            "E",
            "T",
            "M",
            "NR"});
            this.uxGameRating.Location = new System.Drawing.Point(132, 154);
            this.uxGameRating.Name = "uxGameRating";
            this.uxGameRating.Size = new System.Drawing.Size(236, 21);
            this.uxGameRating.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Released";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Review Score (0-100)";
            // 
            // uxUpdateGameButton
            // 
            this.uxUpdateGameButton.Location = new System.Drawing.Point(185, 317);
            this.uxUpdateGameButton.Name = "uxUpdateGameButton";
            this.uxUpdateGameButton.Size = new System.Drawing.Size(126, 23);
            this.uxUpdateGameButton.TabIndex = 4;
            this.uxUpdateGameButton.Text = "Update Game";
            this.uxUpdateGameButton.UseVisualStyleBackColor = true;
            this.uxUpdateGameButton.Click += new System.EventHandler(this.uxUpdateGameButton_Click);
            // 
            // UpdateGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 352);
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
            this.Controls.Add(this.uxGamePrice);
            this.Controls.Add(this.uxYearReleased);
            this.Controls.Add(this.uxGameName);
            this.Name = "UpdateGame";
            this.Text = "UpdateGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxGameName;
        private System.Windows.Forms.TextBox uxYearReleased;
        private System.Windows.Forms.TextBox uxGamePrice;
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
    }
}