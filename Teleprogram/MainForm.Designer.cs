﻿namespace Teleprogram
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.GenreSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.Location = new System.Drawing.Point(-1, 48);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(821, 346);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search by Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search by Genre:";
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(107, 12);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(100, 20);
            this.NameSearch.TabIndex = 7;
            this.NameSearch.TextChanged += new System.EventHandler(this.NameSearch_TextChanged);
            // 
            // GenreSearch
            // 
            this.GenreSearch.Location = new System.Drawing.Point(550, 12);
            this.GenreSearch.Name = "GenreSearch";
            this.GenreSearch.Size = new System.Drawing.Size(100, 20);
            this.GenreSearch.TabIndex = 8;
            this.GenreSearch.TextChanged += new System.EventHandler(this.GenreSearch_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(821, 458);
            this.Controls.Add(this.GenreSearch);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button PinButton;
        private System.Windows.Forms.Button ViewAll;
        private System.Windows.Forms.Button Today;
        private System.Windows.Forms.Button Month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.TextBox GenreSearch;
    }
}

