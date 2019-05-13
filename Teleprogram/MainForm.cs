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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FileManager manager = new FileManager();
            manager.CreateDirectory();
            manager.CreateFile();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (WorkWithText.GetAllTeleprograms().Count == 0)
            {
                WorkWithText.AddFakeDb();
            }

            var models = WorkWithText.GetAllTeleprograms();
            MainGrid.DataSource = models;
            //string s = MainGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PinButton_Click(object sender, EventArgs e)
        {
            string s = MainGrid.SelectedRows[0].Cells[0].Value.ToString();
            var v = 2;
        }
    }
}
