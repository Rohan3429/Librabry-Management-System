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
    public partial class returnbook : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Documents\ram.mdf;Integrated Security=True;Connect Timeout=30";

        public returnbook()
        {
            InitializeComponent();
        }

        private void issueBookButton_Click(object sender, EventArgs e)
        {
            string enrollmentNo = enrollmentNumberTextBox.Text;
            //int bookId = Convert.ToInt32(bookNumberTextBox.Text);

            //string enrollmentNo = txtEnrollmentNo.Text.Trim();
            string bookId = bookNumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(enrollmentNo) || string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter Enrollment No and Book ID");
                return;
            }

            string studentName = "";
            string bookTitle = "";
            bool isBookIssued = false;

            // Check if student is registered
            string studentQuery = "SELECT * FROM student_detail WHERE Enrollment='" + enrollmentNo + "'";
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

            // Check if book is issued
            string issuedBookQuery = "SELECT * FROM IssuedBooks WHERE Enrollment='" + enrollmentNo + "' AND bookid='" + bookId + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(issuedBookQuery, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //bookTitle = reader.GetString(reader.GetOrdinal("book_title"));
                            isBookIssued = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book is not issued to the student");
                        return;
                    }
                }
            }

            // Return book
            if (isBookIssued)
            {
                string returnDate = DateTime.Now.ToString("yyyy-MM-dd");
                string returnQuery = "UPDATE issuedBooks SET return_date='" + returnDate + "' WHERE Enrollment='" + enrollmentNo + "' AND Bookid='" + bookId + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(returnQuery, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book has been returned by " + studentName + " on " + returnDate);
                            enrollmentNumberTextBox.Text = "";
                            bookNumberTextBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to return book");
                        }
                    }
                }
            }
        }

        private void returnbook_Load(object sender, EventArgs e)
        {

        }
    }
}
