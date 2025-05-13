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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM KWemployee";
            
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            if (dataTable.Rows.Count == 0 )
            {
                label1.Visible = true;
                label1.Text = "*No Employees registered";
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void EmptyLabel()
        {
            if(dataGridView1.RowCount == 0)
            {
                label1.Visible = true;
                label1.Text = "*No Employees registered";
            }
            else
            {
                BindGridView();
            }
        }
    }
}
