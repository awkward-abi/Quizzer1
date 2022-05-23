using System.Data.SqlClient;



namespace Quizzer
{
    public partial class SignUpPage : Form
    {

        public SignUpPage()
        {
            InitializeComponent();
        }

        SqlConnection CString = new SqlConnection(@"Data Source=DESKTOP-LARUPAY\SQLEXPRESS1;Initial Catalog=quizzerDB;Integrated Security=True");

        //login button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();

            

            form1.ShowDialog();
        }

        private void btnSignup1_Click(object sender, EventArgs e)
        {
            if (rbtnstud.Checked == true)
            {

                String fn = this.txtbxFN.Text;
                String ln = this.txtbxLN.Text;
                String usern = this.txtbxuserN1.Text;
                String pass = this.txtbxPass1.Text;


                if (fn.Length == 0 || ln.Length == 0 || usern.Length == 0 || pass.Length == 0)
                {
                    MessageBox.Show("Please Fill in all the need information");
  
                }

                try
                {

                    CString.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT (FIRSTNAME, LASTNAME, USERNAME, PASSWORD) " +
                        "VALUES ('" + txtbxFN.Text + "', '" + txtbxLN.Text + "', " +
                        "'" + txtbxuserN1.Text + "', '" + txtbxPass1.Text + "')", CString);

                    int x = cmd.ExecuteNonQuery();


                    if (x == 0)
                    {
                        MessageBox.Show("Error!");
                        txtbxFN.Clear();
                        txtbxLN.Clear();
                        txtbxuserN1.Clear();
                        txtbxPass1.Clear();
                    }

                    else
                    {
                        MessageBox.Show("You have succesfully registered.");
                        txtbxFN.Clear();
                        txtbxLN.Clear();
                        txtbxuserN1.Clear();
                        txtbxPass1.Clear();

                    }

                    CString.Close();
                }

                catch
                {
                    MessageBox.Show("Error");
                    txtbxFN.Clear();
                    txtbxLN.Clear();
                    txtbxuserN1.Clear();
                    txtbxPass1.Clear();

                }
                finally
                {

                }

            }

            if (rbtnteach.Checked == true)
            {
                String fn = this.txtbxFN.Text;
                String ln = this.txtbxLN.Text;
                String usern = this.txtbxuserN1.Text;
                String pass = this.txtbxPass1.Text;

                if (fn.Length == 0 || ln.Length == 0 || usern.Length == 0 || pass.Length == 0)
                {
                   // MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                    MessageBox.Show("Please Fill in all the need information");
                }

                try
                {
                    CString.Open();


                    SqlCommand cmd = new SqlCommand("INSERT INTO TEACHERS (FIRSTNAME, LASTNAME, USERNAME, PASSWORD) VALUES ('" + txtbxFN.Text + "', '" + txtbxLN.Text + "', " +
                        "'" + txtbxuserN1.Text + "', '" + txtbxPass1.Text + "')", CString);

                    int x = cmd.ExecuteNonQuery();


                    if (x == 0)
                    {
                       MessageBox.Show("Error. Please Try Again.");
                        txtbxFN.Clear();
                        txtbxLN.Clear();
                        txtbxuserN1.Clear();
                        txtbxPass1.Clear();
                    }


                    else
                    {

                        MessageBox.Show("You have succesfully registered.");
                        txtbxFN.Clear();
                        txtbxLN.Clear();
                        txtbxuserN1.Clear();
                        txtbxPass1.Clear();
                    }

                    CString.Close();
                }

                catch
                {
                  MessageBox.Show("Error");
                    txtbxFN.Clear();
                    txtbxLN.Clear();
                    txtbxuserN1.Clear();
                    txtbxPass1.Clear();
                }
                finally
                {

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            txtbxFN.Clear();
            txtbxLN.Clear();
            txtbxPass1.Clear();
            txtbxuserN1.Clear();
        }

        private void txtbxPass1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }
    }
}

