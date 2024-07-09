using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_PatientList_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientList PatientL = new PatientList();
            PatientL.ShowDialog();
            PatientL = null;
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryList PatientHistory = new HistoryList();
            PatientHistory.ShowDialog();
            PatientHistory = null;
            this.Show();
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorsList DocList = new DoctorsList();
            DocList.ShowDialog();
            DocList = null;
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
