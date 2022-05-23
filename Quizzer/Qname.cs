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

namespace Quizzer
{
    public partial class Questionnaire : Form
    {


        SqlConnection CString = new SqlConnection(@"Data Source=DESKTOP-LARGHOE\SQLEXPRESS;Initial Catalog=quizzer;Integrated Security=True");
        public Questionnaire()
        {
            InitializeComponent();
          // String Qname1 = txtbxQName.Text.ToString();
        }

       public void btnAddQ_Click(object sender, EventArgs e)
        {
           

               //String ques = this.rtxtbxQ.Text;
               // String ans = this.txtbxAns.Text;
               String Qname = txtbxQName.Text;

           if (Qname.Length == 0)
           {     MessageBox.Show("Please input a name.");
           }

           else
           {

                try
                {

                CString.Open();
                //String sqlQuery = "CREATE TABLE " + txtbxQName.Text + "(QNAME_ID INT PRIMARY KEY IDENTITY(01,1) AND QNAME " + txtbxQName.Text + " ' )";

                //SqlCommand cmd = new SqlCommand(sqlQuery, CString);

                // SqlCommand cmd = new SqlCommand("CREATE TABLE =' + " txtbxQName.Text  "' + (ID COUNTER, [Name] INTEGER) + "'), CString);

                //SqlCommand cmd = new SqlCommand("CREATE TABLE " + txtbxQName.Text + "(ID INT PRIMARY KEY IDENTITY(01,1) AND QNAME VARCHAR (50) " + txtbxQName.Text + "')", CString);

                //SqlCommand cmd = new SqlCommand("CREATE TABLE ='" + txtbxQName.Text + "'ID INT PRIMARY KEY IDENTITY(01,1), QNAME='" + txtbxQName.Text + "'");

                //SqlDataReader read = cmd.ExecuteReader();

                //SqlCommand cmd = new SqlCommand("CREATE TABLE " + txtbxQName.Text + "(ID int,Naziv Char(50),Sjediste Char(50),Adresa Char (50),Ziroracun Char (50),sifra Char(50),JIB Char(50));", CString);

                //SqlCommand cmd = new SqlCommand("CREATE TABLE " + txtbxQName.Text + "(ID INT PRIMARY KEY IDENTITY (01,1),QNAME VARCHAR (50));", CString);


                // cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@QNAME", txtbxQName.Text);
                //cmd.Parameters["@QNAME"].Value = Qname;


                //SqlDataReader read = cmd2.ExecuteReader();

                //if(read.HasRows)
                // {
                //    while (read.Read())
                //   MessageBox.Show("That name has already been used. Please Try again.");
                // }

                //  else
                //   {

                //}

                //string Sql = "IF NOT EXISTS SELECT * FROM " +txtbxQName+ " WHERE QNAME='" + txtbxQName.Text + "' CREATE TABLE " + txtbxQName.Text + " " +
                // "QNAME_ID INT PRIMARY KEY IDENTITY (01,1),QNAME  VARCHAR (50) UNIQUE)" ;

                //SqlCommand cmd = new SqlCommand("CREATE TABLE " + txtbxQName.Text + "( QNAME_ID INT PRIMARY KEY IDENTITY (01,1) ,QNAME VARCHAR (50) UNIQUE)", CString);

               
                   // SqlCommand cmd = new SqlCommand("CREATE TABLE " + txtbxQName.Text + "(QNAME VARCHAR (50), QUESTION VARCHAR(MAX), ANSWER VARCHAR (MAX))", CString);

                   // int x = cmd.ExecuteNonQuery();


                    //SqlCommand cmd2 = new SqlCommand("INSERT INTO " + txtbxQName.Text + " (QNAME) VALUES ('" + txtbxQName.Text + "' )", CString);

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO QUESTIONNAIRE (QNAME, QUESTION, ANSWER) VALUES ('" + txtbxQName.Text + "', '" + rtxtbxQ.Text + "' , '" + txtbxAns.Text + "')", CString);
                    int y = cmd2.ExecuteNonQuery();


                    // SqlCommand cmd3 = new SqlCommand("INSERT INTO " + txtbxQName.Text + " (QUESTION, ASNWER) VALUES ('" + rtxtbxQ.Text + "' + '" + txtbxAns.Text + "' )", CString);
                    // int i = cmd3.ExecuteNonQuery();

                    if (y == 0)
                    {
                        MessageBox.Show("di na record sis");
                    }

                    else
                    {
                        rtxtbxQ.Clear();
                        txtbxAns.Clear();

                    }

                    CString.Close();
                }

              

                catch 
                {
                   MessageBox.Show("mali");
                    txtbxQName.Clear();
                    rtxtbxQ.Clear();
                    txtbxAns.Clear();

                }
               
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
       {
          /*   String ques = this.rtxtbxQ.Text;
            String ans = this.txtbxAns.Text;
           // String qname = this.txtbxQName.Text;


            if (ques.Length == 0 || ans.Length == 0)
            {
                MessageBox.Show("Please enter the needed details.");
            }

            else
            {
                try
                {
                  
                    CString.Open();

                   SqlCommand cmd3 = new SqlCommand("ALTER TABLE " + txtbxQName.Text + " ADD (QUESTION VARCHAR(MAX), ANSWER VARCHAR (MAX))", CString);

                    // SqlCommand cmd = new SqlCommand("INSERT INTO='" + txtbxQName.Text + " (QUESTION, ANSWER) VALUES ('" + rtxtbxQ.Text + "', '" + txtbxAns.Text + "')", CString);

                    // int x = cmd.ExecuteNonQuery();

                    //SqlCommand cmd3 = new SqlCommand ("ALTER='" + txtbxQName + " ALTER QUESTION VARCHAR (MAX) ='" +rtxtbxQ + "' ANSWER VALUES ='" + txtbxAns+ "'");


                    //SqlCommand cmd3 = new SqlCommand("INSERT INTO " + txtbxQName.Text + " ( QUESTION, ANSWER) VALUES ('" + txtbxQName.Text + "' , '" + rtxtbxQ.Text + "' , '" + txtbxAns.Text + "' )", CString);
                    

                    int i = cmd3.ExecuteNonQuery();

                    if (i == 0)
                    {
                        MessageBox.Show("Error. Please Try again.");
                        txtbxAns.Clear();
                        rtxtbxQ.Clear();
                    }

                    else
                    {
                       txtbxAns.Clear();
                        rtxtbxQ.Clear();
                    }

                    CString.Close();

                }

                catch
                {
                    MessageBox.Show("mali nanaman");
                }


            } */
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Questionnaire Complete.");

            FirstPage firstPage = new FirstPage();

            this.Hide();

            firstPage.Show();
            
        }
    }
}
