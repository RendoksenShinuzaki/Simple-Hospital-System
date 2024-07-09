using MongoDB.Bson;
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
    public partial class PatientList : Form
    {
       
        int index;
        public PatientList()
        {
            InitializeComponent();
            
            
        }
        private void PatientList_Load(object sender, EventArgs e)
        {
            PatientController patientController = new PatientController();
            patientController.ViewList(dataGridView1);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<PatientModel>("Patients");
            var builder = Builders<PatientModel>.Filter;
            var filter = builder.Eq("First Name", SearchBox.Text);

            var result = collection.Find(filter).ToList();

            dataGridView1.DataSource = result;   
        }

       /* private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedItem = dataGridView1.SelectedRows[0].DataBoundItem;
                var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
                var collection = mongodbsingleton.GetCollection<PatientModel>("Patients");
                var filter = Builders<PatientModel>.Filter.Eq("FirstName", ((PatientModel)selectedItem).FirstName);
                collection.DeleteOneAsync(filter);
                var dataSource = dataGridView1.DataSource as List<PatientModel>;
                dataSource.Remove((PatientModel)selectedItem);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataSource;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }*/

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PatientView form = new PatientView();
            form.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientController pControl = new PatientController();
            DoTForm DoTForm = new DoTForm();
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            //PatientID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            DoTForm.txtFname.Text = row.Cells[1].Value.ToString();
            DoTForm.txtMiddleName.Text = row.Cells[2].Value.ToString();
            DoTForm.txtLname.Text = row.Cells[3].Value.ToString();
            DoTForm.txtAge.Text = row.Cells[4].Value.ToString();
            DoTForm.txtSymptoms.Text = row.Cells[5].Value.ToString();

            //FormPatient.cmbDocFee.Enabled = true;
            //FormPatient.btnSubmit.Enabled = false;
            //FormPatient.txtDiagnosis.ReadOnly = false;
            //FormPatient.txtTreatment.ReadOnly = false;
            //FormPatient.txtSymptoms.ReadOnly = false;
            pControl.UpdatePatientInformation();
            DoTForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedItem = dataGridView1.SelectedRows[0].DataBoundItem;
                var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
                var collection1 = mongodbsingleton.GetCollection<PatientModel>("Patients");
                var collection2 = mongodbsingleton.GetCollection<PatientModel>("PatientsHistory");
                var filter = Builders<PatientModel>.Filter.Eq("FirstName", ((PatientModel)selectedItem).FirstName);
                var document = collection1.Find(filter).FirstOrDefault();
                collection1.DeleteOneAsync(filter);
                collection2.InsertOne(document);
                var dataSource = dataGridView1.DataSource as List<PatientModel>;
                dataSource.Remove((PatientModel)selectedItem);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dataSource;
            }
            else
            {
                MessageBox.Show("Please select a row to move.");
            }
        }

        private void btnRefreshForm_Click(object sender, EventArgs e)
        {
            PatientController patientController = new PatientController();
            patientController.ViewList(dataGridView1);
        }
    }
}
