using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class student : UserControl
    {
        public student()
        {
            InitializeComponent();
        }

        private void PhonetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string enrollment = EnrollmentTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string phone = PhonetextBox.Text.Trim();
            string department = comboBox1.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(enrollment) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please fill all the required fields!");
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format!");
                return;
            }

            // Save data to database
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Documents\ram.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Student_detail (Name, Enrollment, Email, Phone, Department) VALUES (@Name, @Enrollment, @Email, @Phone, @Department)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Enrollment", enrollment);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Department", department);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Student registered successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to register student!");
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
