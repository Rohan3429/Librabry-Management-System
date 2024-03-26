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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(Username.Text == "Rohan" && Password.Text =="103")
            {
                dashbord1 obj = new dashbord1();
                this.Hide();
                obj.Show();
            }
            else
            {
                wrongPassword.Visible= true;
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
