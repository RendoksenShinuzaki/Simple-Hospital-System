using MongoDB.Driver;
using System.Runtime.InteropServices;
using System.Drawing;

namespace Hospital_System
{
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {
            LoginController login = new LoginController();
            txtID.KeyPress += new KeyPressEventHandler(login.Numbox_KeyPress);
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtPassword.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show("Error: Please fill out the information.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var mongodbsingleton = DataBaseSingleton.GetInstance().GetDatabase();
                var collection = mongodbsingleton.GetCollection<LoginModel>("Accounts");
                var builder = Builders<LoginModel>.Filter;
                var filter = builder.Eq("ID", txtID.Text) & builder.Eq("Password", txtPassword.Text);
                var result = collection.Find(filter).ToList();

                if (result.Count > 0)
                {
                    MessageBox.Show("Welcome");
                    this.Hide();
                    txtID.Text = "";
                    txtPassword.Text = "";
                    Dashboard dash = new Dashboard();
                    dash.ShowDialog();
                    dash = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Error: Incorrect username or password.");
                    txtID.Text = "";
                    txtPassword.Text = "";
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}