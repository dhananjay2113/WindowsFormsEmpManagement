using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace WindowsFormsStudManagement
{
    public partial class Form2 : Form
    {
        
        string cs = ConfigurationManager.ConnectionStrings["project1"].ConnectionString;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            BindGridView();

            //SqlConnection con = new SqlConnection(cs);

            //string query = "INSERT INTO KWemployee VALUES(@id, @name, @role, @gender)";
            //SqlCommand cmd = new SqlCommand(query, con);

            //cmd.Parameters.AddWithValue("@id",);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.Show();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM KWemployee";
            
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BindGridView();
        }
    }
}
