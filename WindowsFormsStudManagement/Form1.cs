using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStudManagement
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PassTextBox.Text != "")
            {
                if(PassTextBox.Text == "12345")
                {
                    
                    Form2 form2 = new Form2();
                    
                    form2.Show();
                    
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
