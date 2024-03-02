using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LR1_CD
{
    public partial class Form1 : Form
    {
        private const string connectionString = @"Data Source=LAPTOP-Q2BTLFDL\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, Title, Author, Publication_Year, Genre, Client FROM BookJournal";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}