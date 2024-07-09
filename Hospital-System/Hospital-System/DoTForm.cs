using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Hospital_System
{
    public partial class DoTForm : Form
    {
       
        public DoTForm()
        {
            InitializeComponent();

            if (txtDiagnosis.Text == "")
            {
                txtTreatment.Enabled = false;
                btnSaveTreatment.Enabled = false;
            }

            else
            {
                txtTreatment.Enabled = true;
                btnSaveTreatment.Enabled = true;
            }
        }

        private void DoTForm_Load(object sender, EventArgs e)
        {
            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<BsonDocument>("Doctors");

            var filter = Builders<BsonDocument>.Filter.Empty;
            var documents = collection.Find(filter).ToList();

            //var cmbBoxFee = new ComboBox();
            foreach (var document in documents)
            {
                cmbDocFee.Items.Add(document["Doctor's Fee"].AsInt32);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            //var mongosingleton = DataBaseSingleton.GetInstance().GetDatabase();
            //var collection = mongosingleton.GetCollection<PatientModel>("Patients");
            //var Diagnosis = txtDiagnosis.Text;
            //// Get the patient id
            ////var patientId = PatientIdTextBox.Text;
            //// Create the filter
            //var filter = Builders<PatientModel>.Filter.Eq("Diagnosis", Diagnosis);
            //// Create the update
            //var update = Builders<PatientModel>.Update.Set("data", Diagnosis);
            //try
            //{
            //    // Update the patient data
            //    collection.UpdateOne(filter, update);
            //    // Retrieve the updated patient data and display it in the form
            //    var updatedPatient = collection.Find(filter).FirstOrDefault();
            //    txtDiagnosis.Text = updatedPatient.Diagnosis;
            //    MessageBox.Show("Patient data updated successfully!");
            //}
            //catch (MongoException ex)
            //{
            //    MessageBox.Show("Error updating patient data: " + ex.Message);
            //}
           
        }
        private void btnSaveTreatment_Click(object sender, EventArgs e)
        {

        }
    }
}
