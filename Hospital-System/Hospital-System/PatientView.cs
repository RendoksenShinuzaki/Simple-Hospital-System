using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_System
{
    public partial class PatientView : Form
    {
        string gender;

        private void PatientForm_Load(object sender, EventArgs e)
        {
            PatientController patient = new PatientController();
            txtFname.KeyPress += new KeyPressEventHandler(patient.TextBox_KeyPress);
            txtMiddleName.KeyPress += new KeyPressEventHandler(patient.TextBox_KeyPress);
            txtLname.KeyPress += new KeyPressEventHandler(patient.TextBox_KeyPress);
            txtSymptoms.KeyPress += new KeyPressEventHandler(patient.TextBox_KeyPress);
            //txtDiagnosis.KeyPress += new KeyPressEventHandler(patient.TextBox_KeyPress);
            //txtTreatment.KeyPress += new KeyPressEventHandler(patient.TextBox_KeyPress);
            txtAge.KeyPress += new KeyPressEventHandler(patient.Numbox_KeyPress);
        }

        private IMongoCollection<PatientModel> collection;
        public PatientView()
        {
            InitializeComponent();
            //cmbDocFee.Enabled = false;

            var connection = DataBaseSingleton.GetInstance();
            collection = connection.GetDatabase().GetCollection<PatientModel>("Patients");
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int PatientID = 1;
            var idMax = collection.Find(x => true).SortByDescending(x => x.PatientID).Limit(1).FirstOrDefault();
            if (rdbMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (txtFname.Text == "" || txtMiddleName.Text == "" || txtLname.Text == "" || txtAge.Text == "" || txtSymptoms.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Error: Please complete necessary Informations.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PatientModel patient = new PatientModel(string PatientID, txtFname.Text, txtMiddleName.Text, txtLname.Text, gender, int.Parse(txtAge.Text), txtSymptoms.Text);
                PatientController patientController = new PatientController();
                patientController.InsertPatient(patient);
                //patientController.UpdatePatientInformation();
                MessageBox.Show("Patient Information Sucessfully Added", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFname.Text = "";
                txtMiddleName.Text = "";
                txtLname.Text = "";
                txtAge.Text = "";

                txtSymptoms.Text = "";
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //var mongosingleton = DataBaseSingleton.GetInstance().GetDatabase();
            //var collection = mongosingleton.GetCollection<PatientModel>("Patients");
            //var updateInfo = Builders<PatientModel>.Update.Set("First Name", txtFname.Text).Set("Middle In", txtMiddleName.Text).Set("Last Name", txtLname.Text);
            //collection.UpdateOne(PatientInfo => PatientInfo.PatientID == ObjectId.Parse(txtFname.Text), updateInfo);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
