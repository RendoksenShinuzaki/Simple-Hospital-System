using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_System
{
    
    public partial class DoctorFormView : Form
    {
        //private IMongoCollection<DoctorModel> collection;
        public DoctorFormView()
        {
            InitializeComponent();
        }

        private void DoctorList_Load(object sender, EventArgs e)
        {
            DoctorController doctor = new DoctorController();
            txtFname.KeyPress += new KeyPressEventHandler(doctor.TextBox_KeyPress);
            txtMiddleIn.KeyPress += new KeyPressEventHandler(doctor.TextBox_KeyPress);
            txtLname.KeyPress += new KeyPressEventHandler(doctor.TextBox_KeyPress);
            txtAge.KeyPress += new KeyPressEventHandler(doctor.Numbox_KeyPress);
            txtFee.KeyPress += new KeyPressEventHandler(doctor.Numbox_KeyPress);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtMiddleIn.Text == "" || txtLname.Text == "" || txtAge.Text == "" || txtFee.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Error: Please complete necessary Informations.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DoctorModel doctor = new DoctorModel(txtFname.Text, txtMiddleIn.Text, txtLname.Text, int.Parse(txtAge.Text), int.Parse(txtFee.Text));
                DoctorController doctorController = new DoctorController();
                doctorController.InsertDoctor(doctor);
                MessageBox.Show("Doctor Information Sucessfully Added", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFname.Text = "";
                txtMiddleIn.Text = "";
                txtLname.Text = "";
                txtAge.Text = "";
                txtFee.Text = "";
            }
        }
    }
}
