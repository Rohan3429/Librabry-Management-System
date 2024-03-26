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
    public partial class bookadding : UserControl
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohan\Documents\ram.mdf;Integrated Security=True;Connect Timeout=30";


        public bookadding()
        {
            InitializeComponent();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            string bookTitle = bookTitleTextBox.Text.Trim();
            int bookid = Convert.ToInt32(bookIdTextBox.Text.Trim());
            string authorName = authorNameTextBox.Text.Trim();
            string publisherName = publisherNameTextBox.Text.Trim();
            int publishedYear = Convert.ToInt32(publishedYearTextBox.Text.Trim());
            int quantity = Convert.ToInt32(quantityTextBox.Text.Trim());

            // Create a SQL query to insert the book into the database
            string query = "INSERT INTO Books (id,Title, Author, Publisher, PublishedYear, Quantity) " +
                "VALUES (@iD,  @Title, @Author, @Publisher, @PublishedYear, @Quantity)";

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set the parameters of the command
                    command.Parameters.AddWithValue("@Title", bookTitle);
                    command.Parameters.AddWithValue("@id", bookid);
                    command.Parameters.AddWithValue("@Author", authorName);
                    command.Parameters.AddWithValue("@Publisher", publisherName);
                    command.Parameters.AddWithValue("@PublishedYear", publishedYear);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    // Open the database connection
                    connection.Open();

                    // Execute the command to insert the book
                    int rowsAffected = command.ExecuteNonQuery();

                    // Close the database connection
                    connection.Close();

                    // Display a message to the user
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book.");
                    }
                }
            }
        }

        private void bookadding_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
