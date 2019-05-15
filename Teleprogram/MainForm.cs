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
        public MainForm()
        {
            InitializeComponent();
            FileManager manager = new FileManager();
            manager.CreateDirectory();
            manager.CreateFile();
            if (WorkWithText.GetAllTeleprograms().Count == 0)
            {
                WorkWithText.AddFakeDb();
            }
            models = WorkWithText.GetAllTeleprograms();
            MainGrid.DataSource = models;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
 
            
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PinButton_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = models.Where(x => x.isSaved == true).ToList();
            WorkWithText.SaveNewProgram(models);
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = models;
            WorkWithText.SaveNewProgram(models);
        }

        private void Today_Click(object sender, EventArgs e)
        {
            ICollection<TeleprogramModel> todayPrograms = new List<TeleprogramModel>();
            foreach (var model in models)
            {
                var thisDay = "";
                for (int i = 0; i < 10; i++)
                {
                    if (model.Date[i] == '/')
                    {
                        break;
                    }

                    thisDay += model.Date[i];
                }

                if (thisDay == DateTime.Today.Day.ToString())
                {
                    todayPrograms.Add(model);
                }
            }

            MainGrid.DataSource = todayPrograms;
            WorkWithText.SaveNewProgram(models);
        }

        private void Month_Click(object sender, EventArgs e)
        {
            ICollection<TeleprogramModel> monthPrograms = new List<TeleprogramModel>();
            foreach (var model in models)
            {
                var thisMonth = "";
                var counter = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (model.Date[i] == '/' && counter != 0)
                    {
                        break;
                    }
                    else if (model.Date[i] == '/' && counter == 0)
                    {
                        counter++;
                    }
                    else if(model.Date[i] != '/' && counter != 0)
                    {
                        thisMonth += model.Date[i];
                    }
                }

                if (thisMonth == DateTime.Today.Month.ToString())
                {
                    monthPrograms.Add(model);
                }
            }

            MainGrid.DataSource = monthPrograms;
            WorkWithText.SaveNewProgram(models);
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
    }
}
