using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class HistoryList : Form
    {
        public HistoryList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientHistory_Load(object sender, EventArgs e)
        {
            HistoryListController historyListController = new HistoryListController();
            historyListController.ViewList(dataGridView1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<PatientModel>("PatientsHistory");
            var builder = Builders<PatientModel>.Filter;
            var filter = builder.Eq("First Name", txtSearch.Text);

            var result = collection.Find(filter).ToList();

            dataGridView1.DataSource = result;
        }

        private void btnRefreshForm_Click(object sender, EventArgs e)
        {
            HistoryListController historyListController = new HistoryListController();
            historyListController.ViewList(dataGridView1);
        }
    }
}
