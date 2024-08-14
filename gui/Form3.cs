using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gui
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadBorrowedBooks();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowBook();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            ReturnBook();
           
        }

        private void LoadBorrowedBooks()
        {
            SqlConnection connect = new SqlConnection("Data Source=HPI5\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
            // Fetch book details from the database
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT BorrowerID, BookID FROM LMSBorrowers", connect);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Assuming you have a DataGridView named 'bookstable'
            borrowedBooksTable.DataSource = dataTable;

        }

        private void borrowedBooksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BorrowBook()
        {
            try
            {
                // Assuming you have textboxes named txtBorrowerId and TXTbookId
                string borrowerId = TXTBorrowerID.Text;
                string bookId = TXTbookId.Text;

                // Check if the book is available for borrowing
                if (IsBookAvailable(bookId))
                {
                    // Insert the borrowing record into the Borrowers table
                    using (SqlConnection connect = new SqlConnection("Data Source=HPI5\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"))
                    {
                        connect.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO LMSBorrowers (BorrowerID, BookID) VALUES (@BorrowerID, @BookID)", connect);
                        cmd.Parameters.AddWithValue("@BorrowerID", borrowerId);
                        cmd.Parameters.AddWithValue("@BookID", bookId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Book borrowed successfully.");

                        // Optionally, update the book status or perform other actions

                       LoadBorrowedBooks(); // Refresh the DataGridView

                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The selected book is not available for borrowing.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsBookAvailable(string bookId)
        {
            using (SqlConnection connect = new SqlConnection("Data Source=HPI5\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT BookID FROM LMSBorrowers WHERE BookID = @BookID", connect);
                cmd.Parameters.AddWithValue("@BookID", bookId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // If there is no record in LMSBorrowers for the given BookID, the book is available
                    return !reader.HasRows;
                }
            }
        }
        private void ReturnBook()
        {
            try
            {
                // Assuming you have textboxes named TXTReturnBorrowerID and TXTReturnBookID
                string borrowerId = TXTReturnBorrowerID.Text;
                string bookId = TXTReturnBookID.Text;

                // Check if the book has been borrowed by the specified borrower
                if (IsBookBorrowed(bookId, borrowerId))
                {
                    // Remove the borrowing record from the Borrowers table
                    using (SqlConnection connect = new SqlConnection("  "))
                    {
                        connect.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM LMSBorrowers WHERE BorrowerID = @BorrowerID AND BookID = @BookID", connect);
                        cmd.Parameters.AddWithValue("@BorrowerID", borrowerId);
                        cmd.Parameters.AddWithValue("@BookID", bookId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Book returned successfully.");

                        // Optionally, update the book status or perform other actions

                        LoadBorrowedBooks(); // Refresh the DataGridView

                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("The selected book is not currently borrowed by the specified borrower.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsBookBorrowed(string bookId, string borrowerId)
        {
            using (SqlConnection connect = new SqlConnection("Data Source=HPI5\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True"))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT BorrowerID FROM LMSBorrowers WHERE BookID = @BookID AND BorrowerID = @BorrowerID", connect);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                cmd.Parameters.AddWithValue("@BorrowerID", borrowerId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // If there is a record in LMSBorrowers for the given BookID and BorrowerID, the book is borrowed
                    return reader.HasRows;
                }
            }
        }

    }
}
