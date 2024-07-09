using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_System
{
    internal class DoctorController
    {
        private IMongoCollection<DoctorModel> collection;
        public void InsertDoctor<DoctorModel>(DoctorModel doctor)
        {
            var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongodbsingleton.GetCollection<DoctorModel>("Doctors");
            collection.InsertOne(doctor);
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
        public void ViewList(DataGridView datalist)
        {
            var controller = new PatientController();
            DoctorFormView doctorFormView = new DoctorFormView();
            var mongosingleton = DataBaseSingleton.GetInstance().GetDatabase();
            var collection = mongosingleton.GetCollection<DoctorModel>("Doctors");
            List<DoctorModel> List = collection.AsQueryable().ToList();
            datalist.DataSource = List;
        }
    }
}
