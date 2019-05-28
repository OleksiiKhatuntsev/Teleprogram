using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Teleprogram
{
    public partial class MainForm : Form
    {
        private ICollection<TeleprogramModel> models;

        private readonly DatabaseHelper helper;

        private const string SavedProgramsLocation = @"C:\Temp\SavedPrograms.txt";

        private const string DbLocation = @"C:\Temp\TeleprogramsDb.txt";

        public MainForm()
        {
            InitializeComponent();
            FileManager manager = new FileManager(DbLocation);
            manager.CreateDirectory();
            manager.CreateFile();
            if (WorkWithText.GetAllTeleprograms().Count == 0)
            {
                WorkWithText.AddFakeDb();
            }
            models = WorkWithText.GetAllTeleprograms();
            MainGrid.DataSource = models;
            helper = new DatabaseHelper();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void PinButton_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = models.Where(x => x.isSaved == true).ToList();
            WorkWithText.SaveProgram(models);
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = models;
            WorkWithText.SaveProgram(models);
        }

        private void Today_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = helper.GetProgramsForDay(models);
            WorkWithText.SaveProgram(models);
        }

        private void Month_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = helper.GetProgramsForMonth(models);
            WorkWithText.SaveProgram(models);
        }

        private void NameSearch_TextChanged(object sender, EventArgs e)
        {
            MainGrid.DataSource = models.Where(x => x.Name.ToLower().Contains(NameSearch.Text.ToLower())).ToList();
        }

        private void GenreSearch_TextChanged(object sender, EventArgs e)
        {
            MainGrid.DataSource = models.Where(x => x.Genre.ToLower().Contains(GenreSearch.Text.ToLower())).ToList();
        }

        private void ChannelSearch_TextChanged(object sender, EventArgs e)
        {
            MainGrid.DataSource = models.Where(x => x.Channel.ToLower().Contains(ChannelSearch.Text.ToLower())).ToList();
        }

        private void SaveFavourites_Click(object sender, EventArgs e)
        {
            WorkWithText.SaveProgram(models.Where(x=>x.isSaved == true).ToList(), SavedProgramsLocation);
        }

        private void AddNewProgram_Click(object sender, EventArgs e)
        {
            AddNewProgramForm form = new AddNewProgramForm();
            form.ShowDialog();
            models = WorkWithText.GetAllTeleprograms();
            MainGrid.DataSource = models;
        }

        private void DeletePrograms_Click(object sender, EventArgs e)
        {
            helper.DeleteProgram(models);
            models = WorkWithText.GetAllTeleprograms();
            MainGrid.DataSource = models;
        }
    }
}
