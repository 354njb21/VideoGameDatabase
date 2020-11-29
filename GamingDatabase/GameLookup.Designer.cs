namespace GamingDatabase
{
    partial class GameLookup
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
            this.uxGameDataGridView = new System.Windows.Forms.DataGridView();
            this.uxGameTitle = new System.Windows.Forms.TextBox();
            this.uxFindGame = new System.Windows.Forms.Button();
            this.FindAllGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxFindGameReleaseYear = new System.Windows.Forms.Button();
            this.uxYearReleased = new System.Windows.Forms.ComboBox();
            this.uxGenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxRating = new System.Windows.Forms.ComboBox();
            this.uxFindGameByGenreButton = new System.Windows.Forms.Button();
            this.uxFindGameByRatingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxGameDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGameDataGridView
            // 
            this.uxGameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGameDataGridView.Location = new System.Drawing.Point(47, 149);
            this.uxGameDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxGameDataGridView.Name = "uxGameDataGridView";
            this.uxGameDataGridView.RowHeadersWidth = 51;
            this.uxGameDataGridView.Size = new System.Drawing.Size(718, 273);
            this.uxGameDataGridView.TabIndex = 0;
            // 
            // uxGameTitle
            // 
            this.uxGameTitle.Location = new System.Drawing.Point(166, 13);
            this.uxGameTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxGameTitle.Name = "uxGameTitle";
            this.uxGameTitle.Size = new System.Drawing.Size(156, 22);
            this.uxGameTitle.TabIndex = 1;
            // 
            // uxFindGame
            // 
            this.uxFindGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uxFindGame.Location = new System.Drawing.Point(330, 7);
            this.uxFindGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxFindGame.Name = "uxFindGame";
            this.uxFindGame.Size = new System.Drawing.Size(221, 26);
            this.uxFindGame.TabIndex = 2;
            this.uxFindGame.Text = "Find Game By Name";
            this.uxFindGame.UseVisualStyleBackColor = true;
            this.uxFindGame.Click += new System.EventHandler(this.uxFindGame_Click);
            // 
            // FindAllGameButton
            // 
            this.FindAllGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAllGameButton.Location = new System.Drawing.Point(641, 29);
            this.FindAllGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.FindAllGameButton.Name = "FindAllGameButton";
            this.FindAllGameButton.Size = new System.Drawing.Size(145, 28);
            this.FindAllGameButton.TabIndex = 3;
            this.FindAllGameButton.Text = "Find All";
            this.FindAllGameButton.UseVisualStyleBackColor = true;
            this.FindAllGameButton.Click += new System.EventHandler(this.FindAllGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Year Released";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Genre";
            // 
            // uxFindGameReleaseYear
            // 
            this.uxFindGameReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uxFindGameReleaseYear.Location = new System.Drawing.Point(328, 40);
            this.uxFindGameReleaseYear.Name = "uxFindGameReleaseYear";
            this.uxFindGameReleaseYear.Size = new System.Drawing.Size(222, 31);
            this.uxFindGameReleaseYear.TabIndex = 9;
            this.uxFindGameReleaseYear.Text = "Find Game By Year";
            this.uxFindGameReleaseYear.UseVisualStyleBackColor = true;
            this.uxFindGameReleaseYear.Click += new System.EventHandler(this.uxFindGameReleaseYear_Click);
            // 
            // uxYearReleased
            // 
            this.uxYearReleased.FormattingEnabled = true;
            this.uxYearReleased.Items.AddRange(new object[] {
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.uxYearReleased.Location = new System.Drawing.Point(166, 48);
            this.uxYearReleased.Name = "uxYearReleased";
            this.uxYearReleased.Size = new System.Drawing.Size(156, 24);
            this.uxYearReleased.TabIndex = 10;
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
            this.uxGenre.Location = new System.Drawing.Point(166, 78);
            this.uxGenre.Name = "uxGenre";
            this.uxGenre.Size = new System.Drawing.Size(156, 24);
            this.uxGenre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rating";
            // 
            // uxRating
            // 
            this.uxRating.FormattingEnabled = true;
            this.uxRating.Items.AddRange(new object[] {
            "E",
            "T",
            "M",
            "NR"});
            this.uxRating.Location = new System.Drawing.Point(166, 109);
            this.uxRating.Name = "uxRating";
            this.uxRating.Size = new System.Drawing.Size(156, 24);
            this.uxRating.TabIndex = 13;
            // 
            // uxFindGameByGenreButton
            // 
            this.uxFindGameByGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uxFindGameByGenreButton.Location = new System.Drawing.Point(328, 77);
            this.uxFindGameByGenreButton.Name = "uxFindGameByGenreButton";
            this.uxFindGameByGenreButton.Size = new System.Drawing.Size(222, 26);
            this.uxFindGameByGenreButton.TabIndex = 14;
            this.uxFindGameByGenreButton.Text = "Find Game By Genre";
            this.uxFindGameByGenreButton.UseVisualStyleBackColor = true;
            this.uxFindGameByGenreButton.Click += new System.EventHandler(this.uxFindGameByGenreButton_Click);
            // 
            // uxFindGameByRatingButton
            // 
            this.uxFindGameByRatingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.uxFindGameByRatingButton.Location = new System.Drawing.Point(328, 109);
            this.uxFindGameByRatingButton.Name = "uxFindGameByRatingButton";
            this.uxFindGameByRatingButton.Size = new System.Drawing.Size(222, 31);
            this.uxFindGameByRatingButton.TabIndex = 15;
            this.uxFindGameByRatingButton.Text = "Find Game By Rating";
            this.uxFindGameByRatingButton.UseVisualStyleBackColor = true;
            this.uxFindGameByRatingButton.Click += new System.EventHandler(this.uxFindGameByRatingButton_Click);
            // 
            // GameLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 447);
            this.Controls.Add(this.uxFindGameByRatingButton);
            this.Controls.Add(this.uxFindGameByGenreButton);
            this.Controls.Add(this.uxRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxGenre);
            this.Controls.Add(this.uxYearReleased);
            this.Controls.Add(this.uxFindGameReleaseYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindAllGameButton);
            this.Controls.Add(this.uxFindGame);
            this.Controls.Add(this.uxGameTitle);
            this.Controls.Add(this.uxGameDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameLookup";
            this.Text = "GameLookup";
            ((System.ComponentModel.ISupportInitialize)(this.uxGameDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxGameDataGridView;
        private System.Windows.Forms.TextBox uxGameTitle;
        private System.Windows.Forms.Button uxFindGame;
        private System.Windows.Forms.Button FindAllGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxFindGameReleaseYear;
        private System.Windows.Forms.ComboBox uxYearReleased;
        private System.Windows.Forms.ComboBox uxGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uxRating;
        private System.Windows.Forms.Button uxFindGameByGenreButton;
        private System.Windows.Forms.Button uxFindGameByRatingButton;
    }
}