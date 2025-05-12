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

namespace WindowsFormsStudManagement
{
    public partial class InsertForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["project1"].ConnectionString;

        public InsertForm()
        {
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(cs);
            string query2 = "SELECT * FROM KWemploye WHERE VALUES (@id = id)"

            if (IDtextBox.Text != "" && NametextBox.Text != "" && RolecomboBox.Text != "" && GendercomboBox.Text != "")
            {
                SqlConnection conn = new SqlConnection(cs);
                string query = "INSERT INTO KWemployee VALUES(@id, @name, @role, @gender)";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@id", IDtextBox.Text);
                command.Parameters.AddWithValue("@name", NametextBox.Text);
                command.Parameters.AddWithValue("@role", RolecomboBox.SelectedItem);
                command.Parameters.AddWithValue("@gender", GendercomboBox.SelectedItem);

                conn.Open();
                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Inserted Succesfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task Failed", "Failure!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                conn.Close();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill all Fields");
            }
        }
    }
}
