using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class dashbord1 : Form
    {
        public dashbord1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            returnbook1.Hide();
            issudbook1.Hide();
            student1.Hide();
            bookadding1.Hide();
            dasbord1.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void dashbord1_Load(object sender, EventArgs e)
        {
            returnbook1.Hide();
            issudbook1.Hide();
            student1.Hide();
            bookadding1.Hide();
            dasbord1.Show();
        }

        private void studentbtn_Click(object sender, EventArgs e)
        {
            returnbook1.Hide();
            issudbook1.Hide();
            dasbord1.Hide();
            bookadding1.Hide();
            student1.Show();
        }

        private void Booksbtn_Click(object sender, EventArgs e)
        {
            returnbook1.Hide();
            issudbook1.Hide();
            dasbord1.Hide();
            student1.Hide();
            bookadding1.Show();
        }

        private void issuedbook_Click(object sender, EventArgs e)
        {
            returnbook1.Hide();
            bookadding1.Hide();
            dasbord1.Hide();
            student1.Hide();
            issudbook1.Show();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            bookadding1.Hide();
            dasbord1.Hide();
            student1.Hide();
            issudbook1.Hide();
            returnbook1.Show();
        }

        private void returnbook1_Load(object sender, EventArgs e)
        {

        }
    }
}
