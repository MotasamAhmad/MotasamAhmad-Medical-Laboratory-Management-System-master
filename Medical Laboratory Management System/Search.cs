using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Medical_Laboratory_Management_System
{
    public partial class Search
    {
        public DataTable dt = new DataTable();
        public string sqlselect = "SELECT * FROM Patient";
        public string searchQuery = "SELECT * FROM Test";

        public Search()
        {
            InitializeComponent();
            DGVSearch = _DGVSearch;
            _DGVSearch.Name = "DGVSearch";
        }
        private void Search_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sqlAdp;
                using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
                {
                    con.Open();
                    sqlAdp = new SqlDataAdapter(sqlselect, con);
                    con.Close(); // connection close here , that is disconnected from data source

                    sqlAdp.Fill(dt);
                }
                DGVSearch.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FilterData(string valuetoSearch)
        {
            string SearchText = searchQuery + " Like '%" + TextBox2.Text + "%'";
            using (var con = new SqlConnection(My.MyProject.Forms.Main.conection))
            {
                var command = new SqlCommand(SearchText, con);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                DGVSearch.DataSource = table;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DGVSearch.DataSource = null;
            Close();
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            FilterData(TextBox2.Text);
        }
    }
}