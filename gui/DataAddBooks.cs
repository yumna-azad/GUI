using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace gui
{
    internal class DataAddBooks
    {
        SqlConnection connect = new SqlConnection(@"");

        public int id {  get; set; }
       
        public string BookTitle { set; get; }

        public string Author { set; get; }
       
        public string Pulished {set; get; }
    
        public string Status { set; get; }

        public List<DataAddBooks> addBooksData()
        {
            List<DataAddBooks > listData = new List<DataAddBooks > ();

            if (connect.State != ConnectionState.Open) {
                try
                {
                    connect.Open();
                    string selectDate = "SELECT * FROM bookS WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectDate, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataAddBooks dab = new DataAddBooks();
                        while (reader.Read())
                        {
                            
                            dab.BookTitle = reader["book_title"].ToString();
                            dab.Author = reader["author"].ToString();
                            dab.Pulished = reader["published_date"].ToString();
                            dab.Status = reader["Status"].ToString();

                            listData.Add(dab);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error connecting database" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }


            return listData;









        }
    }
}
