namespace Teleprogram
{
    partial class AddNewProgramForm
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgramName = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.TextBox();
            this.Channel = new System.Windows.Forms.TextBox();
            this.AddNewProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(73, 86);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Channel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date:";
            // 
            // ProgramName
            // 
            this.ProgramName.Location = new System.Drawing.Point(73, 6);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(200, 20);
            this.ProgramName.TabIndex = 5;
            this.ProgramName.TextChanged += new System.EventHandler(this.ProgramName_TextChanged);
            // 
            // Genre
            // 
            this.Genre.Location = new System.Drawing.Point(73, 33);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(200, 20);
            this.Genre.TabIndex = 6;
            this.Genre.TextChanged += new System.EventHandler(this.Genre_TextChanged);
            // 
            // Channel
            // 
            this.Channel.Location = new System.Drawing.Point(73, 59);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(200, 20);
            this.Channel.TabIndex = 7;
            this.Channel.TextChanged += new System.EventHandler(this.Channel_TextChanged);
            // 
            // AddNewProgram
            // 
            this.AddNewProgram.Location = new System.Drawing.Point(12, 112);
            this.AddNewProgram.Name = "AddNewProgram";
            this.AddNewProgram.Size = new System.Drawing.Size(267, 23);
            this.AddNewProgram.TabIndex = 8;
            this.AddNewProgram.Text = "Add ";
            this.AddNewProgram.UseVisualStyleBackColor = true;
            this.AddNewProgram.Click += new System.EventHandler(this.AddNewProgram_Click);
            // 
            // AddNewProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 140);
            this.Controls.Add(this.AddNewProgram);
            this.Controls.Add(this.Channel);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.ProgramName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Name = "AddNewProgramForm";
            this.Text = "AddNewProgramForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProgramName;
        private System.Windows.Forms.TextBox Genre;
        private System.Windows.Forms.TextBox Channel;
        private System.Windows.Forms.Button AddNewProgram;
    }
}