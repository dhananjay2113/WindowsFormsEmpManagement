using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsStudManagement
{
    public partial class EditForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["project1"].ConnectionString;

        public EditForm()
        {
            InitializeComponent();
            BindGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (IDeditBox.Text != "" && NameEditbox.Text != "" && RoleEditCombo.Text != "" && RoleEditCombo.Text != "")
                {
                    SqlConnection conn = new SqlConnection(cs);
                    string query = "UPDATE KWemployee set Id = @id, name = @name, role = @role ,gender = @gender WHERE Id = @id";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", IDeditBox.Text);
                    command.Parameters.AddWithValue("@name", NameEditbox.Text);
                    command.Parameters.AddWithValue("@role", RoleEditCombo.SelectedItem);
                    command.Parameters.AddWithValue("@gender", GenderEditCombo.SelectedItem);

                    conn.Open();
                    int a = command.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Inserted Succesfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDeditBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            NameEditbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            RoleEditCombo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            GenderEditCombo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); 
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM KWemployee";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (IDeditBox.Text != "" && NameEditbox.Text != "" && RoleEditCombo.Text != "" && GenderEditCombo.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string Deletequery = "DELETE FROM KWemployee WHERE id = @id ";
                SqlCommand command = new SqlCommand(Deletequery, con);
                command.Parameters.AddWithValue("@id", IDeditBox.Text);
                con.Open();

                int a = command.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Deleted Succesfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Task Failed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Please Select an Option", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
