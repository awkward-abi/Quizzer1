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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();

            this.Hide();

            firstPage.ShowDialog();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();

            form1.ShowDialog();
        }
    }
}
