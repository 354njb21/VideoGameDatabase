namespace Players
{
    partial class Streamers
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
            this.uxStreamerDataView = new System.Windows.Forms.DataGridView();
            this.uxSubscriberFilterButton = new System.Windows.Forms.Button();
            this.uxFilterByViewsButton = new System.Windows.Forms.Button();
            this.uxMaxSubscribers = new System.Windows.Forms.TextBox();
            this.uxMinSubscribers = new System.Windows.Forms.TextBox();
            this.uxMinViews = new System.Windows.Forms.TextBox();
            this.uxMaxViews = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxStreamerDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxStreamerDataView
            // 
            this.uxStreamerDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxStreamerDataView.Location = new System.Drawing.Point(12, 141);
            this.uxStreamerDataView.Name = "uxStreamerDataView";
            this.uxStreamerDataView.Size = new System.Drawing.Size(631, 297);
            this.uxStreamerDataView.TabIndex = 0;
            // 
            // uxSubscriberFilterButton
            // 
            this.uxSubscriberFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSubscriberFilterButton.Location = new System.Drawing.Point(416, 36);
            this.uxSubscriberFilterButton.Name = "uxSubscriberFilterButton";
            this.uxSubscriberFilterButton.Size = new System.Drawing.Size(159, 31);
            this.uxSubscriberFilterButton.TabIndex = 1;
            this.uxSubscriberFilterButton.Text = "Filter By # Subscribers";
            this.uxSubscriberFilterButton.UseVisualStyleBackColor = true;
            this.uxSubscriberFilterButton.Click += new System.EventHandler(this.uxSubscriberFilterButton_Click);
            // 
            // uxFilterByViewsButton
            // 
            this.uxFilterByViewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFilterByViewsButton.Location = new System.Drawing.Point(416, 92);
            this.uxFilterByViewsButton.Name = "uxFilterByViewsButton";
            this.uxFilterByViewsButton.Size = new System.Drawing.Size(159, 31);
            this.uxFilterByViewsButton.TabIndex = 1;
            this.uxFilterByViewsButton.Text = "Filter By # Views";
            this.uxFilterByViewsButton.UseVisualStyleBackColor = true;
            this.uxFilterByViewsButton.Click += new System.EventHandler(this.uxFilterByViewsButton_Click);
            // 
            // uxMaxSubscribers
            // 
            this.uxMaxSubscribers.Location = new System.Drawing.Point(187, 42);
            this.uxMaxSubscribers.Name = "uxMaxSubscribers";
            this.uxMaxSubscribers.Size = new System.Drawing.Size(68, 20);
            this.uxMaxSubscribers.TabIndex = 2;
            // 
            // uxMinSubscribers
            // 
            this.uxMinSubscribers.Location = new System.Drawing.Point(333, 42);
            this.uxMinSubscribers.Name = "uxMinSubscribers";
            this.uxMinSubscribers.Size = new System.Drawing.Size(68, 20);
            this.uxMinSubscribers.TabIndex = 2;
            // 
            // uxMinViews
            // 
            this.uxMinViews.Location = new System.Drawing.Point(333, 98);
            this.uxMinViews.Name = "uxMinViews";
            this.uxMinViews.Size = new System.Drawing.Size(68, 20);
            this.uxMinViews.TabIndex = 2;
            // 
            // uxMaxViews
            // 
            this.uxMaxViews.Location = new System.Drawing.Point(187, 98);
            this.uxMaxViews.Name = "uxMaxViews";
            this.uxMaxViews.Size = new System.Drawing.Size(68, 20);
            this.uxMaxViews.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Min:";
            // 
            // Streamers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMaxViews);
            this.Controls.Add(this.uxMinViews);
            this.Controls.Add(this.uxMinSubscribers);
            this.Controls.Add(this.uxMaxSubscribers);
            this.Controls.Add(this.uxFilterByViewsButton);
            this.Controls.Add(this.uxSubscriberFilterButton);
            this.Controls.Add(this.uxStreamerDataView);
            this.Name = "Streamers";
            this.Text = "Streamers";
            ((System.ComponentModel.ISupportInitialize)(this.uxStreamerDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxStreamerDataView;
        private System.Windows.Forms.Button uxSubscriberFilterButton;
        private System.Windows.Forms.Button uxFilterByViewsButton;
        private System.Windows.Forms.TextBox uxMaxSubscribers;
        private System.Windows.Forms.TextBox uxMinSubscribers;
        private System.Windows.Forms.TextBox uxMinViews;
        private System.Windows.Forms.TextBox uxMaxViews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

