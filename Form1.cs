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
using System.Diagnostics;

namespace LibraryAppPrototype
{
    public partial class Form1 : Form
    {
        public bool listBoxActive(string box)
        {
            return false;
        }

        // Testing for the push.
        public int JustTestingToday(int A)
        {
            //This is just a test in the main form.
            return A;
        }
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection();

        private void textBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); // Shows form1
            Debug.Write("SHOWS FORM 1 WHEN CLICKED.");
            this.Close();

        }
    }
}
