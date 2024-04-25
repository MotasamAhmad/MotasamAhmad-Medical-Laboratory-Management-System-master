using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Medical_Laboratory_Management_System
{
    public partial class Test
    {
        private bool isUpdate = false;
        private static Test _instance;
        public static Test Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Test();
                }
                return _instance;
            }
        }

        public Test()
        {
            InitializeComponent();
        }
        private void clearform()
        {
            txtTestID.Text = string.Empty;
            txtTestName.Text = string.Empty;
            CmbTestType.Text = string.Empty;
            CmbSampleType.Text = string.Empty;
            cmbSampleUnit.Text = string.Empty;
            txtMini.Text = string.Empty;
            txtMax.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }
        private void Test_Load(object sender, EventArgs e)
        {


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            var SearchForm = new Search();
            SearchForm.sqlselect = "SELECT * FROM Test";
            SearchForm.searchQuery = "SELECT * FROM [dbo].[Test] WHERE CONCAT(Test_ID,Test_Name,Test_Type,Sample_Type,Sample_Unit,Mini_value,Max_value,Price,Create_User,Create_Date)";
            SearchForm.ShowDialog();
            if (SearchForm.DGVSearch.DataSource is not null)
            {

                txtTestID.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Test_ID"].Value);
                txtTestName.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Test_Name"].Value);
                CmbTestType.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Test_Type"].Value);
                CmbSampleType.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Sample_Type"].Value);
                cmbSampleUnit.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Sample_Unit"].Value);
                txtMini.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Mini_value"].Value);
                txtMax.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Max_value"].Value);
                txtPrice.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Price"].Value);
                GBTest.Enabled = true;
                isUpdate = true;
            }
            else
            {
                clearform();
                GBTest.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTestID.Text))
                {
                    MessageBox.Show("Enter Test ID");
                    return;
                }
                int Test_ID = Conversions.ToInteger(txtTestID.Text);
                string Test_Name = txtTestName.Text;
                string Test_Type = CmbTestType.Text;
                string Sample_Type = CmbSampleType.Text;
                string Sample_Unit = cmbSampleUnit.Text;
                string Mini_value = txtMini.Text;
                string Max_value = txtMax.Text;
                int Price = Conversions.ToInteger(txtPrice.Text);


                if (isUpdate == false)
                {

                    string query = @"INSERT INTO [dbo].[Test]
           ([Test_ID]
           ,[Test_Name]
           ,[Test_Type]
           ,[Sample_Type]
           ,[Sample_Unit]
           ,[Mini_value]
           ,[Max_value]
           ,[Price]
           ,[Create_User]
           ,[Create_Date])
            values(@Test_ID,@Test_Name,@Test_Type,@Sample_Type,@Sample_Unit,@Mini_value,@Max_value,@Price,@Create_User,getdate())";
                    using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                    {
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Test_ID", Test_ID);
                            cmd.Parameters.AddWithValue("@Test_Name", Test_Name);
                            cmd.Parameters.AddWithValue("@Test_Type", Test_Type);
                            cmd.Parameters.AddWithValue("@Sample_Type", Sample_Type);
                            cmd.Parameters.AddWithValue("@Sample_Unit", Sample_Unit);
                            cmd.Parameters.AddWithValue("@Mini_value", Mini_value);
                            cmd.Parameters.AddWithValue("@Max_value", Max_value);
                            cmd.Parameters.AddWithValue("@Price", Price);
                            cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Successfully Saved");
                            isUpdate = true;
                            GBTest.Enabled = false;
                            clearform();
                        }
                    }
                }
                else
                {
                    isUpdate = true;
                    string query = @"Update [dbo].[Test]
   SET Test_Name = @Test_Name
      ,Test_Type = @Test_Type
      ,Sample_Type = @Sample_Type
      ,Sample_Unit = @Sample_Unit
      ,Mini_value = @Mini_value
      ,Max_value = @Max_value
      ,Price = @Price
      ,Create_User = @Create_User
      ,Create_Date = getdate()
 WHERE Test_ID = @Test_ID ";
                    using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                    {
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Test_ID", Test_ID);
                            cmd.Parameters.AddWithValue("@Test_Name", Test_Name);
                            cmd.Parameters.AddWithValue("@Test_Type", Test_Type);
                            cmd.Parameters.AddWithValue("@Sample_Type", Sample_Type);
                            cmd.Parameters.AddWithValue("@Sample_Unit", Sample_Unit);
                            cmd.Parameters.AddWithValue("@Mini_value", Mini_value);
                            cmd.Parameters.AddWithValue("@Max_value", Max_value);
                            cmd.Parameters.AddWithValue("@Price", Price);
                            cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Successfully Updated");
                            GBTest.Enabled = false;
                            isUpdate = true;
                            clearform();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                clearform();
                isUpdate = false;
                GBTest.Enabled = true;
                SqlDataAdapter sqlAdp;
                var dt = new DataTable();
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT isnull(Max(Test_ID),0)+1  FROM Test ", con);
                    con.Close(); // connection close here , that is disconnected from data source

                    sqlAdp.Fill(dt);
                }
                txtTestID.Text = Conversions.ToString(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTestID.Text))
                {
                    MessageBox.Show("Enter Test ID");
                    return;
                }
                string query = "Delete From Test WHERE Test_ID = " + txtTestID.Text;
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
                        GBTest.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GBTest.Enabled = false;
            clearform();
        }
    }
}