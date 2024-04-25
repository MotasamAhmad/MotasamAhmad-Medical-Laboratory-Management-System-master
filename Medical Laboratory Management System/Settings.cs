using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Medical_Laboratory_Management_System
{
    public partial class Settings
    {
        private bool isupdate = false;
        public string conection = "Data Source=localhost;Initial Catalog=Medicallab ;integrated security=true";
        public SqlConnection sqlcon;
        private static Settings _instance;
        public static Settings Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Settings();
                }
                return _instance;
            }
        }

        public Settings()
        {
            sqlcon = new SqlConnection(conection);
            InitializeComponent();
        }
        private void clearform()
        {
            txtUserID.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void DGVSettings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index;
                index = e.RowIndex;
                DataGridViewRow selectedRow;
                selectedRow = DGVSettings.Rows[index];
                txtUserID.Text = selectedRow.Cells[0].Value.ToString();
                txtUserName.Text = selectedRow.Cells[1].Value.ToString();
                txtPassword.Text = selectedRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtUserID.Text))
                {
                    MessageBox.Show("Enter User ID");
                    return;
                }
                string User_ID = txtUserID.Text;
                string User_Name = txtUserName.Text;
                string Password = txtPassword.Text;
                string radiovalue;
                if (RBUser.Checked == true)
                {
                    radiovalue = "User";
                }
                else if (RBAdmin.Checked == true)
                {
                    radiovalue = "Admin";
                }
                else
                {
                    Interaction.MsgBox("Please select permission", MsgBoxStyle.Information, "Missing");
                    return;

                }
                string query1 = "If exists(SELECT * FROM User_Settings WHERE User_ID =" + txtUserID.Text + @")

                           Update [dbo].[User_Settings]
              SET [User_Name] = @User_Name
                 ,[Password] = @Password
                 ,[Permission] = @radiovalue
            WHERE [User_ID] = @User_ID
           else 
              INSERT INTO [dbo].[User_Settings]
                             ([User_ID]
                             ,[User_Name]
                             ,[Password]
                             ,[Permission])
                            VALUES
                             (@User_ID,@User_Name,@Password,@radiovalue)";
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    using (var cmd = new SqlCommand(query1, con))
                    {
                        cmd.Parameters.AddWithValue("@User_ID", User_ID);
                        cmd.Parameters.AddWithValue("@User_Name", User_Name);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@radiovalue", radiovalue);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully Saved");
                        isupdate = true;
                        load_table();
                        clearform();
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {


            try
            {
                clearform();
                isupdate = false;
                SqlDataAdapter sqlAdp;
                var dt = new DataTable();
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT isnull(Max(User_ID),0)+1  FROM User_settings ", con);
                    con.Close(); // connection close here , that is disconnected from data source

                    sqlAdp.Fill(dt);
                }
                txtUserID.Text = Conversions.ToString(dt.Rows[0][0]);
                load_table();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserID.Text))
                {
                    MessageBox.Show("Enter User ID");
                    return;
                }
                string query = "Delete From User_Settings WHERE User_ID = " + txtUserID.Text;
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully Deleted");
                        isupdate = false;
                        clearform();
                        load_table();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clearform();
        }
        public void load_table()
        {
            string Query = "Select * from User_Settings";
            if (My.MyProject.Forms.Login.UserType == "User")
            {

                Query = "select * from User_Settings where User_ID = '" + txtUserID.Text + "' and Permission ='User' ";
            }
            using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
            {
                using (var cmd = new SqlCommand(Query, con))
                {
                    using (var da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        using (var dt = new DataTable())
                        {
                            da.Fill(dt);
                            DGVSettings.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}