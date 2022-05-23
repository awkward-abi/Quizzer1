using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Drawing;


namespace Quizzer
{
    public partial class Form1 : Form
    {
       
        public Form1()
  
        {
            InitializeComponent();
           
        }
        // Source=DESKTOP-LARUPAY\SQLEXPRESS1;Initial Catalog=quizzerDB;Integrated Security=True
        SqlConnection CString = new SqlConnection(@"Data Source=DESKTOP-LARUPAY\SQLEXPRESS1;Initial Catalog=quizzerDB;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            SignUpPage form2 = new SignUpPage();

            this.Hide();
       
            form2.ShowDialog(); 
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           String user = this.txtbxUser.Text;   
           String pass = this.txtbxPass.Text;

            if (rbtnstud1.Checked == true)
            {
                if (user.Length == 0 || pass.Length == 0)
                {
                    MessageBox.Show("Please Fill up all the need information");
                }

                try
                {
                    CString.Open();
                    String sqlQuery = "SELECT * FROM STUDENT WHERE USERNAME='" + txtbxUser.Text + "'AND PASSWORD='" + txtbxPass.Text + "'" ;
                    SqlCommand cmd = new SqlCommand(sqlQuery, CString);

                    SqlDataReader read = cmd.ExecuteReader();

                 
                  if (read.HasRows)
                    {
                        while (read.Read()) { }

                        CString.Close();

                        FirstPage firstPage = new FirstPage();
                        this.Hide();
                        firstPage.ShowDialog();
                    }

                    else
                    {
                         
                        DialogResult res= MessageBox.Show("Please enter the correct details.");
                        if (res == DialogResult.Cancel)
                        {
                            this.Hide();
                        }
                        txtbxUser.Clear();
                        txtbxPass.Clear();
                    }

                    CString.Close();
                }

               catch 
               {
                   MessageBox.Show("Error");
                    txtbxUser.Clear();
                    txtbxPass.Clear();
                }

                finally
                {    
                       CString.Close();
                }

              
            }

            if (rbtnteach1.Checked == true)
            {
                if (user.Length == 0  || pass.Length == 0)
                {
                    MessageBox.Show("Please Fill up all the need information");
                }

                try
                {
                    CString.Open();
                    String sqlQuery = "SELECT * FROM TEACHERS WHERE USERNAME='" + txtbxUser.Text + "'AND PASSWORD='" + txtbxPass.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, CString);

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read()) { }
                        CString.Close();

                        FirstPage firstPage = new FirstPage();
                        this.Hide();
                        firstPage.ShowDialog();
                    }

                    else
                    {
                        MessageBox.Show("Please enter the correct details.");
                        txtbxUser.Clear();
                        txtbxPass.Clear();
                    }

                    CString.Close();
                }

                catch
                {
                    MessageBox.Show("Error");
                    txtbxUser.Clear();
                    txtbxPass.Clear();
                }

                finally
                {
                    CString.Close();
                }
            }



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnstud1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           // this.Close();

            System.Windows.Forms.Application.Exit();
        }
    }
}