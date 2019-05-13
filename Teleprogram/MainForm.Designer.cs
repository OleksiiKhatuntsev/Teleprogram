namespace Teleprogram
{
    partial class MainForm
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
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.PinButton = new System.Windows.Forms.Button();
            this.ViewAll = new System.Windows.Forms.Button();
            this.Today = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.Location = new System.Drawing.Point(-1, 0);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(821, 394);
            this.MainGrid.TabIndex = 0;
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            // 
            // PinButton
            // 
            this.PinButton.Location = new System.Drawing.Point(12, 429);
            this.PinButton.Name = "PinButton";
            this.PinButton.Size = new System.Drawing.Size(396, 23);
            this.PinButton.TabIndex = 1;
            this.PinButton.Text = "Favourites";
            this.PinButton.UseVisualStyleBackColor = true;
            this.PinButton.Click += new System.EventHandler(this.PinButton_Click);
            // 
            // ViewAll
            // 
            this.ViewAll.Location = new System.Drawing.Point(414, 429);
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(396, 23);
            this.ViewAll.TabIndex = 2;
            this.ViewAll.Text = "All programs";
            this.ViewAll.UseVisualStyleBackColor = true;
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // Today
            // 
            this.Today.Location = new System.Drawing.Point(13, 400);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(395, 23);
            this.Today.TabIndex = 3;
            this.Today.Text = "For today";
            this.Today.UseVisualStyleBackColor = true;
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(414, 400);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(395, 23);
            this.Month.TabIndex = 4;
            this.Month.Text = "Month";
            this.Month.UseVisualStyleBackColor = true;
            this.Month.Click += new System.EventHandler(this.Month_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(821, 458);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.ViewAll);
            this.Controls.Add(this.PinButton);
            this.Controls.Add(this.MainGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button PinButton;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button Today;
        private System.Windows.Forms.Button Month;
    }
}

