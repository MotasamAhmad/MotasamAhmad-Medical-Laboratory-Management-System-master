using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Medical_Laboratory_Management_System
{
    public partial class Login
    {
        public string UserName;
        public string UserType = "User";
        public string conection = "Data Source = localhost; Initial Catalog = Medicallab; integrated security = true";
        public SqlConnection sqlcon;

        public Login()
        {
            sqlcon = new SqlConnection(conection);
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;
            UserName = txtUserName.Text;
            string radioValue;
            if (RBUser.Checked == true)
            {
                radioValue = "User";
            }
            else if (RBAdmin.Checked == true)
            {
                radioValue = "Admin";
            }
            else
            {
                Interaction.MsgBox("Please select permission", MsgBoxStyle.Information, "Missing");
                return;
            }
            var command = new SqlCommand("select * from User_Settings where User_Name = @User_Name  and Password = @Password and Permission = @permission", sqlcon);
            command.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@permission", SqlDbType.VarChar).Value = radioValue;
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Please Enter Valid Data");
                return;
            }
            else
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(table.Rows[0][3], "User", false)))
                {
                    Settings.Instance.btnAdd.Enabled = false;
                    Settings.Instance.btnsave.Enabled = true;
                    Settings.Instance.btndelete.Enabled = false;
                    Settings.Instance.btncancel.Enabled = true;
                    Settings.Instance.txtUserName.Enabled = false;
                    Settings.Instance.GroupBox1.Enabled = false;
                    Settings.Instance.RBUser.Checked = true;
                    Settings.Instance.RBAdmin.Checked = false;
                    UserType = "User";
                    sqlcon.Open();
                    var commands = new SqlCommand("SELECT User_ID,User_Name,Password,Permission FROM User_Settings where User_Name = '" + txtUserName.Text + "' and Password = '" + txtPassword.Text + "' and Permission = '" + radioValue + "' ", sqlcon);
                    var adapters = new SqlDataAdapter(commands);
                    var dataset = new DataSet();
                    adapters.Fill(dataset, "User_Name");
                    Settings.Instance.DGVSettings.DataSource = dataset.Tables["User_Name"];
                    sqlcon.Close();
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(table.Rows[0][3], "Admin", false)))
                {
                    Settings.Instance.btnAdd.Enabled = true;
                    Settings.Instance.btnsave.Enabled = true;
                    Settings.Instance.btndelete.Enabled = true;
                    Settings.Instance.btncancel.Enabled = true;
                    Settings.Instance.txtUserName.Enabled = true;
                    Settings.Instance.GroupBox1.Enabled = true;
                    sqlcon.Open();
                    UserType = "Admin";
                    var commands = new SqlCommand("SELECT User_ID,User_Name,Password,Permission FROM User_Settings ", sqlcon);
                    var adapters = new SqlDataAdapter(commands);
                    var dataset = new DataSet();
                    adapters.Fill(dataset, "User_Name");
                    Settings.Instance.DGVSettings.DataSource = dataset.Tables["User_Name"];
                    sqlcon.Close();
                }
                My.MyProject.Forms.Main.Show();
                Hide();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}