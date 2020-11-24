namespace GamingDatabase
{
    partial class UpdateGamePopUp
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
            this.uxGameToUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxGameToUpdate
            // 
            this.uxGameToUpdate.Location = new System.Drawing.Point(101, 86);
            this.uxGameToUpdate.Name = "uxGameToUpdate";
            this.uxGameToUpdate.Size = new System.Drawing.Size(227, 20);
            this.uxGameToUpdate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Game Title To Update";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uxSubmitButton
            // 
            this.uxSubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubmitButton.Location = new System.Drawing.Point(150, 139);
            this.uxSubmitButton.Name = "uxSubmitButton";
            this.uxSubmitButton.Size = new System.Drawing.Size(125, 26);
            this.uxSubmitButton.TabIndex = 2;
            this.uxSubmitButton.Text = "Submit";
            this.uxSubmitButton.UseVisualStyleBackColor = true;
            this.uxSubmitButton.Click += new System.EventHandler(this.uxSubmitButton_Click);
            // 
            // UpdateGamePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 177);
            this.Controls.Add(this.uxSubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGameToUpdate);
            this.Name = "UpdateGamePopUp";
            this.Text = "UpdateGamePopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxGameToUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxSubmitButton;
    }
}