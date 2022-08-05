using System;
using System.Data.SqlClient;

namespace SQLAzureConn
{
    class Program
    {
        static void Main(string[] args)
        {
          SqlConnection conn = new SqlConnection("Azure Path");
          SqlCommand command = new SqlCommand("SELECT * FROM Customers", conn);
          conn.Open();
          SqlDataReader myReader = command.ExecuteReader();

          while (myReader.Read())
          {
            Console.WriteLine("\t{0}\t{1}", myReader.GetInt32(0), myReader.GetString(1));
          }

          conn.Close();
        }
    }
}
