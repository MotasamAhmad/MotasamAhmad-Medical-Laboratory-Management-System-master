using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    public partial class Main
    {
        public string conection = "Data Source=localhost;Initial Catalog=Medicallab ;integrated security=true";
        public SqlConnection sqlcon;
        public string User_Name = "OSAMAH";

        public Main()
        {
            sqlcon = new SqlConnection(conection);
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Panel4.Controls.Contains(Patient.Instance))
            {
                Panel4.Controls.Add(Patient.Instance);
                Patient.Instance.Dock = DockStyle.Fill;
                Patient.Instance.BringToFront();
                Patient.Instance.Visible = true;
            }
            Patient.Instance.BringToFront();
            Patient.Instance.Visible = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!Panel4.Controls.Contains(Test.Instance))
            {
                Panel4.Controls.Add(Test.Instance);
                Test.Instance.Dock = DockStyle.Fill;
                Test.Instance.BringToFront();
                Test.Instance.Visible = true;
            }
            Test.Instance.BringToFront();
            Test.Instance.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (!Panel4.Controls.Contains(Result_1.Instance))
            {
                Panel4.Controls.Add(Result_1.Instance);
                Result_1.Instance.Dock = DockStyle.Fill;
                Result_1.Instance.BringToFront();
                Result_1.Instance.Visible = true;
            }
            Result_1.Instance.BringToFront();
            Result_1.Instance.Visible = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (!Panel4.Controls.Contains(Settings.Instance))
            {
                Panel4.Controls.Add(Settings.Instance);
                Settings.Instance.Dock = DockStyle.Fill;
                Settings.Instance.BringToFront();
                Settings.Instance.Visible = true;
            }
            Settings.Instance.BringToFront();
            Settings.Instance.Visible = true;
        }

        private void btnanalysis_Click(object sender, EventArgs e)
        {
            if (!Panel4.Controls.Contains(Bills.Instance))
            {
                Panel4.Controls.Add(Bills.Instance);
                Bills.Instance.Dock = DockStyle.Fill;
                Bills.Instance.BringToFront();
                Bills.Instance.Visible = true;
            }
            Bills.Instance.BringToFront();
            Bills.Instance.Visible = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Hide();
            My.MyProject.Forms.Login.Show();
            Settings.Instance.txtUserID.Text = string.Empty;
            Settings.Instance.txtUserName.Text = string.Empty;
            Settings.Instance.txtPassword.Text = string.Empty;

        }
    }
}