using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ToDoList1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectString = @"Data source= LAPTOP-NCEDVHBS; Initial Catalog=practice; Integrated Security=True";
                SqlConnection co = new SqlConnection(connectString);
                co.Open();
                MessageBox.Show("Connected");

            }
            catch (Exception)
            {
                MessageBox.Show("Unable to connected");
            }
        }
    }
}
