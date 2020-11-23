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
            ((System.ComponentModel.ISupportInitialize)(this.uxGameDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGameDataGridView
            // 
            this.uxGameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGameDataGridView.Location = new System.Drawing.Point(12, 81);
            this.uxGameDataGridView.Name = "uxGameDataGridView";
            this.uxGameDataGridView.Size = new System.Drawing.Size(575, 270);
            this.uxGameDataGridView.TabIndex = 0;
            // 
            // uxGameTitle
            // 
            this.uxGameTitle.Location = new System.Drawing.Point(35, 27);
            this.uxGameTitle.Name = "uxGameTitle";
            this.uxGameTitle.Size = new System.Drawing.Size(195, 20);
            this.uxGameTitle.TabIndex = 1;
            // 
            // uxFindGame
            // 
            this.uxFindGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindGame.Location = new System.Drawing.Point(277, 25);
            this.uxFindGame.Name = "uxFindGame";
            this.uxFindGame.Size = new System.Drawing.Size(109, 23);
            this.uxFindGame.TabIndex = 2;
            this.uxFindGame.Text = "Find Game";
            this.uxFindGame.UseVisualStyleBackColor = true;
            this.uxFindGame.Click += new System.EventHandler(this.uxFindGame_Click);
            // 
            // GameLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 363);
            this.Controls.Add(this.uxFindGame);
            this.Controls.Add(this.uxGameTitle);
            this.Controls.Add(this.uxGameDataGridView);
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
    }
}