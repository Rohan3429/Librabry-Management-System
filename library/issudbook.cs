using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class issudbook : UserControl
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Documents\ram.mdf;Integrated Security=True;Connect Timeout=30";
        public issudbook()
        {
            InitializeComponent();
        }

        private void issueBookButton_Click(object sender, EventArgs e)
        {
            //string enrollment = enrollmentNumberTextBox.Text;
            //string bookNumber = bookNumberTextBox.Text;

            string enrollmentNo = enrollmentNumberTextBox.Text;
            string bookId = bookNumberTextBox.Text;

            if (string.IsNullOrEmpty(enrollmentNo) || string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter Enrollment No and Book ID");
                return;
            }

            string studentName = "";
            string bookTitle = "";
            bool isBookAvailable = false;

            // Check if student is registered
            string studentQuery = "SELECT * FROM student_detail WHERE enrollment='" + enrollmentNo + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(studentQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            studentName = reader.GetString(reader.GetOrdinal("name"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student is not registered");
                        return;
                    }
                }
            }

            // Check if book is available
            string bookQuery = "SELECT * FROM Books WHERE id='" + bookId + "' AND Quantity>0";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(bookQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            bookTitle = reader.GetString(reader.GetOrdinal("title"));
                            isBookAvailable = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book is not available");
                        return;
                    }
                }
            }

            // Issue book
            if (isBookAvailable)
            {
                string issueDate = DateTime.Now.ToString("yyyy-MM-dd");
                string returnDate = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");
                string issueQuery = "INSERT INTO IssuedBooks (enrollment, bookid, DateOfIssue, return_date) " +
                                    "VALUES ('" + enrollmentNo + "', '" + bookId + "', '" + issueDate + "', '" + returnDate + "')";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(issueQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book has been issued to " + studentName + " with return date " + returnDate);
                            enrollmentNumberTextBox.Text = "";
                            bookNumberTextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to issue book");
                        }
                    }
                }
            }
        }

        private void enrollmentNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bookNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void issudbook_Load(object sender, EventArgs e)
        {

        }
    }
}
