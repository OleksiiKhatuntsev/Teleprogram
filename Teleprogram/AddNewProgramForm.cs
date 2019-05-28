using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teleprogram
{
    public partial class AddNewProgramForm : Form
    {
        public AddNewProgramForm()
        {
            InitializeComponent();
            this.AddNewProgram.Enabled = false;
        }

        private void AddNewProgram_Click(object sender, EventArgs e)
        {
            var models = WorkWithText.GetAllTeleprograms();
            models.Add(ReadFromForm());
            WorkWithText.SaveProgram(models);
            this.Close();
        }

        private TeleprogramModel ReadFromForm()
        {
            return new TeleprogramModel{ Channel = this.Channel.Text, Genre = this.Genre.Text, Date = WorkWithText.ConvertDateToString(this.Date.Value), Name = this.ProgramName.Text, isSaved = false};
        }

        private void ProgramName_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void Genre_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void Channel_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void EnableButton()
        {
            if (Channel.Text == string.Empty || ProgramName.Text == string.Empty || Genre.Text == string.Empty)
            { }
            else
            {
                AddNewProgram.Enabled = true;
            }
        }
    }
}
