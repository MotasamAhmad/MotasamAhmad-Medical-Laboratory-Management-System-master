using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Medical_Laboratory_Management_System
{
    public partial class Patient
    {
        private bool isUpdate = false;
        private static Patient _instance;
        public static Patient Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Patient();
                }
                return _instance;
            }
        }

        public Patient()
        {
            InitializeComponent();
        }

        private void clearform()
        {
            txtPatientID.Text = string.Empty;
            txtpatientName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtphoneNO.Text = string.Empty;
            txtAge.Text = string.Empty;
            cmbGender.Text = string.Empty;
            cmbMaritalStatus.Text = string.Empty;
            cmbBloodGroup.Text = string.Empty;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPatientID.Text))
                {
                    MessageBox.Show("Enter Patient ID");
                    return;
                }
                int Patient_ID = Conversions.ToInteger(txtPatientID.Text);
                string Patient_Name = txtpatientName.Text;
                string Address = txtAddress.Text;
                string Phone_No = txtphoneNO.Text;
                string Gender = cmbGender.Text;
                int Age = Conversions.ToInteger(txtAge.Text);
                string Marital_Status = cmbMaritalStatus.Text;
                string Blood_Group = cmbBloodGroup.Text;

                if (isUpdate == false)
                {

                    string query = @" INSERT INTO [dbo].[Patient]
           ([Patient_ID]
           ,[Patient_Name]
           ,[Address]
           ,[Phone_No]
           ,[Gender]
           ,[Age]
           ,[Marital_Status]
           ,[Blood_Group]
           ,[Create_User]
           ,[Create_Date])
            values (@Patient_ID,@Patient_Name,@Address,@Phone_No,@Gender,@Age,@Marital_Status,@Blood_Group,@Create_User,getdate())";
                    using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                    {
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                            cmd.Parameters.AddWithValue("@Patient_Name", Patient_Name);
                            cmd.Parameters.AddWithValue("@Address", Address);
                            cmd.Parameters.AddWithValue("@Phone_No", Phone_No);
                            cmd.Parameters.AddWithValue("@Gender", Gender);
                            cmd.Parameters.AddWithValue("@Age", Age);
                            cmd.Parameters.AddWithValue("@Marital_Status", Marital_Status);
                            cmd.Parameters.AddWithValue("@Blood_Group", Blood_Group);
                            cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Successfully Saved");
                            isUpdate = true;
                            clearform();
                            GBPatientdata.Enabled = false;
                        }

                    }
                }
                else
                {
                    isUpdate = true;
                    string query = @" UPDATE [dbo].[Patient]
   SET Patient_Name = @Patient_Name
      ,Address = @Address
      ,Phone_No = @Phone_No
      ,Gender = @Gender
      ,Age = @Age
      ,Marital_Status = @Marital_Status
      ,Blood_Group = @Blood_Group
      ,Create_User = @Create_User
      ,Create_Date = getdate()
   WHERE Patient_ID = @Patient_ID";
                    using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                    {
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                            cmd.Parameters.AddWithValue("@Patient_Name", Patient_Name);
                            cmd.Parameters.AddWithValue("@Address", Address);
                            cmd.Parameters.AddWithValue("@Phone_No", Phone_No);
                            cmd.Parameters.AddWithValue("@Gender", Gender);
                            cmd.Parameters.AddWithValue("@Age", Age);
                            cmd.Parameters.AddWithValue("@Marital_Status", Marital_Status);
                            cmd.Parameters.AddWithValue("@Blood_Group", Blood_Group);
                            cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Successfully Updated");
                            isUpdate = true;
                            clearform();
                            GBPatientdata.Enabled = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPatientID.Text))
                {
                    MessageBox.Show("Enter Patient ID");
                    return;
                }
                string query = "Delete From Patient WHERE Patient_ID = " + txtPatientID.Text;
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    using (var cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully Deleted");
                        isUpdate = false;
                        clearform();
                        GBPatientdata.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            var SearchForm = new Search();
            SearchForm.sqlselect = "SELECT * FROM Patient";
            SearchForm.searchQuery = "SELECT * FROM [dbo].[Patient] WHERE CONCAT(Patient_ID,Patient_Name,Address,Phone_No,Gender,Age,Marital_Status,Blood_Group,Create_User,Create_Date)";
            SearchForm.ShowDialog();
            if (SearchForm.DGVSearch.DataSource is not null)
            {

                txtPatientID.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_ID"].Value);
                txtpatientName.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_Name"].Value);
                txtAddress.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Address"].Value);
                txtphoneNO.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Phone_No"].Value);
                cmbGender.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Gender"].Value);
                txtAge.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Age"].Value);
                cmbMaritalStatus.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Marital_Status"].Value);
                cmbBloodGroup.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Blood_Group"].Value);
                GBPatientdata.Enabled = true;
                isUpdate = true;
            }
            else
            {
                clearform();
                GBPatientdata.Enabled = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clearform();
                isUpdate = false;
                GBPatientdata.Enabled = true;
                SqlDataAdapter sqlAdp;
                var dt = new DataTable();
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT isnull(Max(Patient_ID),0)+1  FROM Patient ", con);
                    con.Close(); // connection close here , that is disconnected from data source

                    sqlAdp.Fill(dt);
                }
                txtPatientID.Text = Conversions.ToString(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GBPatientdata.Enabled = false;
            clearform();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
    }
}