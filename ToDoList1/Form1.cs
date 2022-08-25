using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(text_name.Text, text_batch.Text, text_field.Text);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells["name"].Value=text_name.Text; 
                dataGridView1.CurrentRow.Cells["batch"].Value = text_batch.Text;
                dataGridView1.CurrentRow.Cells["field"].Value = text_field.Text;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
        private void card_click(object sender, EventArgs e)
        {
            MessageBox.Show("card clicked");
        }
    }

}
