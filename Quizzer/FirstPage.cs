using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();

            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Profile form4 = new Profile();
            form4.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void date_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void FirstPage_Load(object sender, EventArgs e)
        {
            time.Start();
            date.Start();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create quest

            Questionnaire qname = new Questionnaire();
            
            this.Hide();

            qname.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // review

            Review form7 = new Review();

            this.Hide();

            form7.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
