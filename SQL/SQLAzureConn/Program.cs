using System;
using System.Data.SqlClient;

namespace SQLAzureConn
{
    class Program
    {
        static void Main(string[] args)
        {
          SqlConnection conn = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=SQLDatabase1;Persist Security Info=False;User ID=LarryAzureLogin;Password=--------;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
