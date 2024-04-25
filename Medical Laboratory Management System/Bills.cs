using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Medical_Laboratory_Management_System
{
    public partial class Bills
    {
        private bool isUpdate = false;
        private static Bills _instance;
        public static Bills Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Bills();
                }
                return _instance;
            }
        }

        public Bills()
        {
            InitializeComponent();
        }
        private void clearform()
        {
            txtBill_No.Text = string.Empty;
            txtPatient_ID.Text = string.Empty;
            txtPatient_Name.Text = string.Empty;
            txtTprice.Text = string.Empty;
            DGVBills.Rows.Clear();

        }
        private void Bills_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            clearform();
            isUpdate = false;
            var SearchForm = new Search();
            SearchForm.sqlselect = "SELECT Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Patient.Age,Patient.Gender,Bills.Bill_Date,Bills.Create_User,Bills.Create_Date FROM Bills,Patient WHERE Bills.Patient_ID = Patient.Patient_ID ";
            SearchForm.searchQuery = "SELECT Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Patient.Age,Patient.Gender,Bills.Bill_Date,Bills.Create_User,Bills.Create_Date FROM Bills,Patient WHERE Bills.Patient_ID = Patient.Patient_ID And  CONCAT(Bills.Bill_No,Bills.Patient_ID,Patient.Patient_Name,Bills.Create_User,Bills.Create_Date)";
            SearchForm.ShowDialog();
            if (SearchForm.DGVSearch.DataSource is not null)
            {

                txtBill_No.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Bill_No"].Value);
                dtpDate.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Bill_Date"].Value);
                txtPatient_ID.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_ID"].Value);
                txtPatient_Name.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_Name"].Value);
                // txtTprice.Text = SearchForm.DGVSearch.CurrentRow.Cells("Total_Price").Value
                GBBills.Enabled = true;
                SqlDataAdapter sqlAdp;
                var dt = new DataTable();
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT Patient_Name  FROM Patient WHERE Patient_ID = " + txtPatient_ID.Text, con);
                    con.Close(); // connection close here , that is disconnected from data source

                    sqlAdp.Fill(dt);
                    txtPatient_Name.Text = Conversions.ToString(dt.Rows[0][0]);
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT Order_Detail.*,Test.Test_Name  FROM Order_Detail,Test WHERE Test.Test_ID = Order_Detail.Test_ID AND Bill_No = " + txtBill_No.Text, con);
                    con.Close(); // connection close here , that is disconnected from data source
                    dt = new DataTable();
                    sqlAdp.Fill(dt);
                    double sum = 0d;
                    for (int i = 0, loopTo = dt.Rows.Count - 1; i <= loopTo; i++)
                    {
                        string Test_ID = Conversions.ToString(dt.Rows[i]["Test_ID"]);
                        string Test_Name = Conversions.ToString(dt.Rows[i]["Test_Name"]);
                        string Price = Conversions.ToString(dt.Rows[i]["Price"]);
                        // Dim Sample_Unit As String = dt.Rows(i).Item("Sample_Unit")
                        string Mini_value = Conversions.ToString(dt.Rows[i]["Mini_value"]);
                        string Max_value = Conversions.ToString(dt.Rows[i]["Max_value"]);
                        DGVBills.Rows.Add(new string[] { Test_ID, Test_Name, Price, Mini_value, Max_value });
                        sum += Conversions.ToDouble(DGVBills.Rows[i].Cells[2].Value);
                    }
                    txtTprice.Text = sum.ToString();
                }
                isUpdate = true;
            }
            else
            {
                clearform();
                GBBills.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                clearform();
                GBBills.Enabled = true;
                SqlDataAdapter sqlAdp;
                var dt = new DataTable();
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT isnull(Max(Bill_No),0)+1  FROM Bills ", con);
                    con.Close(); // connection close here , that is disconnected from data source

                    sqlAdp.Fill(dt);
                }
                txtBill_No.Text = Conversions.ToString(dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {

            var SearchForm = new Search();
            SearchForm.sqlselect = "SELECT * FROM Patient";
            SearchForm.searchQuery = "SELECT * FROM [dbo].[Patient] WHERE CONCAT(Patient_ID,Patient_Name,Address,Phone_No,Gender,Age,Marital_Status,Blood_Group,Create_User,Create_Date)";
            SearchForm.ShowDialog();
            if (SearchForm.DGVSearch.DataSource is not null)
            {

                txtPatient_ID.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_ID"].Value);
                txtPatient_Name.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_Name"].Value);

            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            var SearchForm = new Search();
            SearchForm.sqlselect = "SELECT * FROM Test";
            SearchForm.searchQuery = "SELECT * FROM [dbo].[Test] WHERE CONCAT(Test_ID,Test_Name,Test_Type,Sample_Type,Sample_Unit,Mini_value,Max_value,Price)";
            SearchForm.ShowDialog();

            if (SearchForm.DGVSearch.DataSource is not null)
            {

                string Test_ID = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Test_ID"].Value);
                string Test_Name = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Test_Name"].Value);
                string Price = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Price"].Value);
                // Dim Sample_Unit As String = SearchForm.DGVSearch.CurrentRow.Cells("Sample_Unit").Value
                string Mini_value = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Mini_value"].Value);
                string Max_value = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Max_value"].Value);
                DGVBills.Rows.Add(new string[] { Test_ID, Test_Name, Price, Mini_value, Max_value });

            }
            double sum = 0d;
            for (int i = 0, loopTo = DGVBills.RowCount - 1; i <= loopTo; i++)
                sum += Conversions.ToDouble(DGVBills.Rows[i].Cells[2].Value);

            txtTprice.Text = sum.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBill_No.Text))
                {
                    MessageBox.Show("Enter Bill No");
                    return;
                }
                int Bill_No = Conversions.ToInteger(txtBill_No.Text);
                string Bill_Date = Conversions.ToString(dtpDate.Value);
                string Patient_ID = txtPatient_ID.Text;
                string Total_Price = txtTprice.Text;


                if (isUpdate == false)
                {
                    string query = @" INSERT INTO [dbo].[Bills]
           ([Bill_No]
           ,[Bill_Date]
           ,[Patient_ID]
           ,[Total_Price]
           ,[Create_User]
           ,[Create_Date])
            values (@Bill_No,@Bill_Date,@Patient_ID,@Total_Price,@Create_User,getdate())";
                    using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                    {
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Bill_No", Bill_No);
                            cmd.Parameters.AddWithValue("@Bill_Date", Bill_Date);
                            cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                            cmd.Parameters.AddWithValue("@Total_Price", Total_Price);
                            cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        for (int i = 0, loopTo = DGVBills.RowCount - 1; i <= loopTo; i++)
                        {
                            query = @"INSERT INTO [dbo].[Order_Detail]
           ([Bill_No]
           ,[Test_ID]           
           ,[Price]           
           ,[Mini_value]
           ,[Max_value]
           ,[Patient_ID]
           ,[Create_User]
           ,[Create_Date])
           VALUES(@Bill_No,@Test_ID,@Price,@Mini_value,@Max_value,@Patient_ID,@Create_User,getdate())";
                            using (var cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Bill_No", Bill_No);
                                cmd.Parameters.AddWithValue("@Test_ID", DGVBills.Rows[i].Cells["Test_ID"].Value);
                                cmd.Parameters.AddWithValue("@Price", DGVBills.Rows[i].Cells["Price"].Value);
                                cmd.Parameters.AddWithValue("@Mini_value", DGVBills.Rows[i].Cells["Mini_value"].Value);
                                cmd.Parameters.AddWithValue("@Max_value", DGVBills.Rows[i].Cells["Max_value"].Value);
                                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                                cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        MessageBox.Show("Successfully Saved");
                        isUpdate = true;
                        clearform();
                        GBBills.Enabled = false;
                    }
                }

                else
                {
                    isUpdate = true;
                    string query = @"Update [dbo].[Bills]
            SET Bill_Date = Bill_Date
             ,Patient_ID = Patient_ID
             ,Total_Price = Total_Price
             ,Create_User = Create_User
             ,Create_Date = getdate()
            WHERE Bill_No = Bill_No";
                    using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                    {
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Bill_No", Bill_No);
                            cmd.Parameters.AddWithValue("@Bill_Date", Bill_Date);
                            cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                            cmd.Parameters.AddWithValue("@Total_Price", Total_Price);
                            cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        query = "Delete From Order_Detail WHERE Bill_No = " + txtBill_No.Text;
                        using (var cmd = new SqlCommand(query, con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        for (int i = 0, loopTo1 = DGVBills.RowCount - 1; i <= loopTo1; i++)
                        {
                            query = @"INSERT INTO [dbo].[Order_Detail]
           ([Bill_No]
           ,[Test_ID]           
           ,[Price]           
           ,[Mini_value]
           ,[Max_value]
           ,[Patient_ID]
           ,[Create_User]
           ,[Create_Date])
           VALUES(@Bill_No,@Test_ID,@Price,@Mini_value,@Max_value,@Patient_ID,@Create_User,getdate())";
                            using (var cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Bill_No", Bill_No);
                                cmd.Parameters.AddWithValue("@Test_ID", DGVBills.Rows[i].Cells["Test_ID"].Value);
                                cmd.Parameters.AddWithValue("@Price", DGVBills.Rows[i].Cells["Price"].Value);
                                cmd.Parameters.AddWithValue("@Mini_value", DGVBills.Rows[i].Cells["Mini_value"].Value);
                                cmd.Parameters.AddWithValue("@Max_value", DGVBills.Rows[i].Cells["Max_value"].Value);
                                cmd.Parameters.AddWithValue("@Patient_ID", Patient_ID);
                                cmd.Parameters.AddWithValue("@Create_User", My.MyProject.Forms.Main.User_Name);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        MessageBox.Show("Successfully Updated");
                        isUpdate = true;
                        clearform();
                        GBBills.Enabled = false;
                    }
                }
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
                if (string.IsNullOrEmpty(txtBill_No.Text))
                {
                    MessageBox.Show("Enter Bill No");
                    return;
                }
                string query = "Delete From Order_Detail WHERE Bill_No = " + txtBill_No.Text + " Delete From Bills WHERE Bill_No = " + txtBill_No.Text;
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
                        GBBills.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GBBills.Enabled = false;
            clearform();
        }

        private void DGVBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVBills.Columns["Delete"].Index == e.ColumnIndex & e.RowIndex >= 0)
            {
                DGVBills.Rows.Remove(DGVBills.CurrentRow);
            }
        }
    }
}