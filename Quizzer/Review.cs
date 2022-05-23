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
    public partial class Review : Form
    {

        

        public Review()
        {
            InitializeComponent();
           
        }

        private void Review_Load(object sender, EventArgs e)
        {
            SqlConnection CString = new SqlConnection(@"Data Source=DESKTOP-LARGHOE\SQLEXPRESS;Initial Catalog=quizzer;Integrated Security=True");
            try
            {
                

                CString.Open();

                cmbQnames.Items.Add("ss"); 

                //SqlCommand cmd = new SqlCommand("SELECT QNAME FROM QUESTIONNAIRE WHERE" , CString);

                //SqlCommand cmd = new SqlCommand("SELECT QNAME FROM QUESTIONNAIRE", CString);

                //SqlCommand cmd = new SqlCommand("SELECT DISTINCT QNAME FROM QUESTIONNAIRE", CString);

                SqlCommand cmd = new SqlCommand("SELECT QNAME FROM QUESTIONNAIRE GROUP BY QNAME", CString);

                cmd.ExecuteNonQuery();

                // if (x == 0)
                //  {
                //     MessageBox.Show("wala");                
                //   }

                //  else
                // {
                //     MessageBox.Show("meron");
                // }
               

                SqlDataAdapter adapt = new SqlDataAdapter();

                adapt.SelectCommand = cmd;

                DataTable QnameTable = new DataTable();

                adapt.Fill(QnameTable);

                // DataRow itemrow = QnameTable.NewRow();
                // itemrow[1] = "Select";
                //QnameTable.Rows.InsertAt(itemrow, 0);

                cmbQnames.DataSource = QnameTable;
                cmbQnames.DisplayMember = "QNAME";
                // cmbQnames.ValueMember = "QNAME";

          
                CString.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CString.Close();
            }

        }

        private void cmbQnames_SelectedIndexChanged(object sender, EventArgs e)
        {


            SqlConnection CString = new SqlConnection(@"Data Source=DESKTOP-LARGHOE\SQLEXPRESS;Initial Catalog=quizzer;Integrated Security=True");

            try
            {
                CString.Open();

                //SqlDataReader read1 = null;

                //SqlCommand cmd2 = new SqlCommand("SELECT QUESTION FROM QUESTIONNAIRE WHERE QNAME = '" + cmbQnames.SelectedItem + "'", CString);

                String query = "SELECT * FROM QUESTIONNAIRE WHERE QNAME='" + cmbQnames.Text + "'";


                SqlCommand cmd2 = new SqlCommand(query, CString);


                // String query = "SELECT * FROM QUESTIONNAIRE WHERE QNAME LIKE '%" + cmbQnames.Text + "%'";
                // String query = "SELECT * FROM QUESTIONNAIRE WHERE QNAME LIKE '%" + cmbQnames.Text + "%'";


                //SqlCommand cmd2 = new SqlCommand("SELECT QUESTION FROM QUESTIONNAIRE WHERE QNAME = '" + cmbQnames.SelectedItem + "'", CString);


                cmd2.ExecuteNonQuery();

                // SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM QUESTIONNAIRE WHERE QNAME='" + cmbQnames.Text + "'", CString);

                


                SqlDataReader read1 = cmd2.ExecuteReader();

              

                

                while (read1.Read())
                {

                    listView1.View = View.Details;

                   if (listView1.Columns.Count == 0)
                    {
                        listView1.Columns.Add("QUESTION");
                        listView1.Columns.Add("ANSWER");

                        

                        var item = new ListViewItem();

                        item.Text = read1["QUESTION"].ToString();
                        item.SubItems.Add(read1["ANSWER"].ToString());
                        listView1.Items.Add(item);

                    }
                    else
                    {
                        var item = new ListViewItem();

                        item.Text = read1["QUESTION"].ToString();
                        item.SubItems.Add(read1["ANSWER"].ToString());
                        listView1.Items.Add(item);

                    }

                  


                    // listView1.Items.Clear();
                }
                //cmbQnames.SelectedIndexChanged -= new System.EventHandler(this.cmbQnames_SelectedValueChanged);

               /// if (cmbQnames.SelectedIndexChanged)
               // {

               // }

              //  listView1.Items.Clear();




                // if (read1.Read())
                /// {
                //     lblQuesV.Text = read1.GetValue(2).ToString();
                // }

                // while (read1.Read())
                //{
                // string question = read1.GetInt32(1).ToString();
                // string answer = read1.GetInt32(2).ToString();

                // lblQuesV.Text = question;
                // lblAnsV.Text = answer;

                //lblQuesV.Text = read1[1].ToString();
                //lblAnsV.Text = read1[2].ToString();

                //}



                // DataSet ds = new DataSet();
                // DataTable dt = new DataTable();
                // adapt.Fill(ds);
                //adapt.Fill(dt);

                // foreach (DataRow row in dt.Rows)
                //{
                //    listView1.Text = (row["QUESTION"].ToString());
                //   listView1.Text = (row["ANSWER"].ToString());
                // label2.Text = (row["ContactNo"].ToString());
                //}

                //dataGridView1.DataSource = adapt;
                //dataGridView1.DataMember = "QUESTIONNNAIRE";
                //dataGridView1.DisplayedRowCount

                CString.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CString.Close();
            }


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblQuesV_Click(object sender, EventArgs e)
        {

        }

        private void lblAnsV_Click(object sender, EventArgs e)
        {

        }

        private void rtxtbxQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
