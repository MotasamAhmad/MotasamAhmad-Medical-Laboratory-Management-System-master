using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Medical_Laboratory_Management_System
{
    public partial class Result_1
    {
        private bool isUpdate = false;
        private static Result_1 _instance;
        public static Result_1 Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new Result_1();
                }
                return _instance;
            }
        }

        public Result_1()
        {
            InitializeComponent();
        }
        private void clearform()
        {
            txtBill_No.Text = string.Empty;
            txtPatient_ID.Text = string.Empty;
            txtPatient_Name.Text = string.Empty;
            txtGender.Text = string.Empty;
            txtAge.Text = string.Empty;
            DGVResult.Rows.Clear();
        }
        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                txtPatient_ID.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_ID"].Value);
                txtPatient_Name.Text = Conversions.ToString(SearchForm.DGVSearch.CurrentRow.Cells["Patient_Name"].Value);
                GBResult.Enabled = true;
                SqlDataAdapter sqlAdp;
                var dt = new DataTable();
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT * FROM Patient WHERE Patient_ID = " + txtPatient_ID.Text, con);

                    con.Close(); // connection close here , that is disconnected from data source

                    sqlAdp.Fill(dt);
                    txtPatient_Name.Text = Conversions.ToString(dt.Rows[0][1]);
                    txtGender.Text = Conversions.ToString(dt.Rows[0][4]);
                    txtAge.Text = Conversions.ToString(dt.Rows[0][5]);
                    con.Open();
                    sqlAdp = new SqlDataAdapter("SELECT Order_Detail.*,Test.* FROM Order_Detail,Test WHERE Test.Test_ID = Order_Detail.Test_ID AND Bill_No = " + txtBill_No.Text, con);
                    con.Close(); // connection close here , that is disconnected from data source
                    dt = new DataTable();
                    sqlAdp.Fill(dt);
                    double sum = 0d;
                    for (int i = 0, loopTo = dt.Rows.Count - 1; i <= loopTo; i++)
                    {
                        string Test_ID = Conversions.ToString(dt.Rows[i]["Test_ID"]);
                        string Test_Name = Conversions.ToString(dt.Rows[i]["Test_Name"]);
                        string Result = "";
                        if (!ReferenceEquals(dt.Rows[i]["Result"], DBNull.Value))
                        {
                            Result = Conversions.ToString(dt.Rows[i]["Result"]);
                        }
                        string Sample_Unit = Conversions.ToString(dt.Rows[i]["Sample_Unit"]);
                        string State = "";
                        if (!ReferenceEquals(dt.Rows[i]["State"], DBNull.Value))
                        {
                            State = Conversions.ToString(dt.Rows[i]["State"]);
                        }
                        string Mini_value = Conversions.ToString(dt.Rows[i]["Mini_value"]);
                        string Max_value = Conversions.ToString(dt.Rows[i]["Max_value"]);
                        DGVResult.Rows.Add(new string[] { Test_ID, Test_Name, Result, Sample_Unit, State, Mini_value, Max_value });
                    }
                }
                isUpdate = true;
            }
            else
            {
                clearform();
                GBResult.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GBResult.Enabled = false;
            clearform();
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
                for (int i = 0, loopTo = DGVResult.RowCount - 1; i <= loopTo; i++)
                {
                    string query = @"Update [dbo].[Order_Detail]
            SET Result = @Result
             ,[State] = @State
            WHERE Bill_No = @Bill_No and Test_ID = @Test_ID";
                    using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                    {
                        using (var cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Result", DGVResult.Rows[i].Cells["Result"].Value);
                            cmd.Parameters.AddWithValue("@State", DGVResult.Rows[i].Cells["State"].Value);
                            cmd.Parameters.AddWithValue("@Bill_No", Convert.ToInt32(txtBill_No.Text));
                            cmd.Parameters.AddWithValue("@Test_ID", Convert.ToInt32(DGVResult.Rows[i].Cells["Test_ID"].Value));
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                MessageBox.Show("Successfully Saved");
                clearform();
                GBResult.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVResult_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // e.RowIndex
            try
            {
                var row = DGVResult.Rows[e.RowIndex];
                if (e.ColumnIndex == row.Cells["Result"].ColumnIndex & !string.IsNullOrEmpty(Conversions.ToString(row.Cells["Result"].Value)))
                {
                    // For Each row As DataGridViewRow In DGVResult.Rows
                    if (Convert.ToInt32(row.Cells["Result"].Value) < Convert.ToInt32(row.Cells["Mini_Range"].Value))
                    {
                        DGVResult.CurrentRow.Cells["State"].Value = "Low";
                        DGVResult.CurrentRow.DefaultCellStyle.ForeColor = Color.DarkOrange;
                    }
                    // this.dataGridView1.DefaultCellStyle.BackColor = Color.Beige;
                    else if (Convert.ToInt32(row.Cells["Result"].Value) >= Convert.ToInt32(row.Cells["Mini_Range"].Value) & Convert.ToInt32(row.Cells["Result"].Value) <= Convert.ToInt32(row.Cells["Max_Range"].Value))
                    {
                        DGVResult.CurrentRow.Cells["State"].Value = "Normal";
                        DGVResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else if (Convert.ToInt32(row.Cells["Result"].Value) > Convert.ToInt32(row.Cells["Max_Range"].Value))
                    {
                        DGVResult.CurrentRow.Cells["State"].Value = "High";
                        DGVResult.CurrentRow.DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            // Next
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            string strSelectionfrm = "{Bills.Bill_No}=" + txtBill_No.Text;
            CrystalDecisions.CrystalReports.Engine.ReportDocument rptdoc;
            rptdoc = new CrystalReport2();
            rptdoc.SetDatabaseLogon("sa", "123qwe123QWE/-*");
            // String strSelectionfrm = "{tblLeaveApp.Date_App}='" & ndLeaApprDt & "'"
            if (!string.IsNullOrEmpty(txtBill_No.Text))
            {
                rptdoc.RecordSelectionFormula = strSelectionfrm;
            }
            // rptdoc.DiscardSavedData
            My.MyProject.Forms.Report.CrystalReportViewer1.ReportSource = rptdoc;
            My.MyProject.Forms.Report.ShowDialog();
            My.MyProject.Forms.Report.Dispose();

        }

        private void DGVResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}