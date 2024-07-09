using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public class PatientController
    {
        
        public void InsertPatient<PatientModel>(PatientModel patient)
        {

            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<PatientModel>("Patients");
            collection.InsertOne(patient);
            //MessageBox.Show("Patient Information Sucessfully Added", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void UpdatePatient<PatientModel>(ObjectId id, UpdateDefinition<PatientModel> upPatient)
        {
            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<PatientModel>("Patients");
            var filter = Builders<PatientModel>.Filter.Eq("First Name", id);
            //var update = Builders<PatientModel>.Update;
            collection.UpdateOne(filter, upPatient);
        }

        public void ViewList(DataGridView datalist)
        {
            var controller = new PatientController();
            PatientView patientform = new PatientView();
            var mongosingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongosingleton.GetCollection<PatientModel>("Patients");
            List<PatientModel> List = collection.AsQueryable().ToList();
            datalist.DataSource = List;
        }

        public void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        public void Numbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        public void UpdatePatientInformation()
        {
            PatientList pList = new PatientList();
            DoTForm DoTForm = new DoTForm();
            var mongosingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongosingleton.GetCollection<PatientModel>("Patients");
            List<PatientModel> patientList = collection.AsQueryable().ToList();
            pList.dataGridView1.DataSource = patientList;
            DoTForm.txtFname.Text = pList.dataGridView1.Rows[0].Cells[1].Value.ToString();
            DoTForm.txtMiddleName.Text = pList.dataGridView1.Rows[0].Cells[2].Value.ToString();
            DoTForm.txtLname.Text = pList.dataGridView1.Rows[0].Cells[3].Value.ToString();
            DoTForm.txtAge.Text = pList.dataGridView1.Rows[0].Cells[4].Value.ToString();
            DoTForm.txtSymptoms.Text = pList.dataGridView1.Rows[0].Cells[5].Value.ToString();
            //pForm.txtTreatment.Text = pList.dataGridView1.Rows[0].Cells[6].Value.ToString();
            //pForm.txtDiagnosis.Text = pList.dataGridView1.Rows[0].Cells[7].Value.ToString();
        }

       /* public void Delete()
        {
            PatientList pList = new PatientList();
            foreach (DataGridViewRow item in pList.dataGridView1.SelectedRows)
            {
                pList.dataGridView1.Rows.RemoveAt(item.Index);
            }
        }*/
        public void SaveTreatment<PatientModel>(string PatientID, UpdateDefinition<PatientModel> Diagnosis)
        {
            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<PatientModel>("Patients");
            var filter = Builders<PatientModel>.Filter.Eq("Patient ID", PatientID);
            collection.UpdateOne(filter, Diagnosis);
        }
    }
}


