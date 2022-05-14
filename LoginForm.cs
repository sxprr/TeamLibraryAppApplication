using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace LibraryAppPrototype
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog(); // Shows form1

            Debug.Write("SHOWS FORM 1 WHEN IT IS CLICKED.");


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        // The main login button
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=J:\Documents\BookRentID.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "Select * from tbl_Login Where username = " + userNameText.Text.Trim() + "' and password = " + passwordText.Text.Trim() + " ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if(dtbl.Rows.Count == 1)
            {
                Form2 objFrmMain = new Form2();
                this.Hide();
                objFrmMain.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }
    }
}
