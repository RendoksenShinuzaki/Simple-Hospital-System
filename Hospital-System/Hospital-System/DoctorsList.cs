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
    public partial class DoctorsList : Form
    {
        public DoctorsList()
        {
            InitializeComponent();
        }

        private void DoctorsList_Load(object sender, EventArgs e)
        {
            DoctorController doctorController = new DoctorController();
            doctorController.ViewList(dataGridView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DoctorFormView DocForm = new DoctorFormView();
            DocForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<DoctorModel>("Doctors");
            var builder = Builders<DoctorModel>.Filter;
            var filter = builder.Eq("First Name", txtSearch.Text);

            var result = collection.Find(filter).ToList();

            dataGridView1.DataSource = result;
        }

        private void btnUpdateForm_Click(object sender, EventArgs e)
        {
            DoctorController doctorController = new DoctorController();
            doctorController.ViewList(dataGridView1);
        }
    }
}
