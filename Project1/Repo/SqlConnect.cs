using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Models;

namespace Repo
{
    public class SqlConnect
  {
    SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    /// <summary>
    /// Shows existing employees in the syetem
    /// </summary>
    /// <param name="email"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public async Task<bool> ExistsEmployeeAsync(string email, string password)
    {

      using (SqlCommand command = new SqlCommand($"SELECT * FROM Employees WHERE Email = @email AND Password = @password", connect))
      {
        command.Parameters.AddWithValue("@email", email);
        command.Parameters.AddWithValue("@password", password);
        connect.Open();

        SqlDataReader? ret = await command.ExecuteReaderAsync();
        ret.Read();

        if (ret.Read())
        {
          connect.Close();
          return true;
        }
        else
        {
          connect.Close();
          return false;
        }
      }
    }

    /// <summary>
    /// Shows existing expense ticket requests.
    /// </summary>
    /// <param name="EmployeeID"></param>
    /// <returns></returns>
    public async Task<bool> ExistsTicketAsync(int EmployeeID)
    {
      using (SqlCommand command = new SqlCommand($"SELECT * FROM Expenses WHERE EmployeeID = @eid AND TicketID >= 0", connect))
      {
        command.Parameters.AddWithValue("@eid", EmployeeID);
        connect.Open();

        SqlDataReader? ret = await command.ExecuteReaderAsync();
        if (ret.Read())
        {
          connect.Close();
          return true;
        }
        else
        {
          connect.Close();
          return false;
        }
      }
    }

    /// <summary>
    /// Returns the approved ticket requests.
    /// </summary>
    /// <param name="EmployeeID"></param>
    /// <returns></returns>
    public async Task<bool> ApprovedTicketAsync(int EmployeeID)
    {
       using (SqlCommand command = new SqlCommand($"SELECT * FROM Expenses WHERE EmployeeID = @eid and Approved = 'Approved'", connect))
      {
        command.Parameters.AddWithValue("@eid", EmployeeID);
        connect.Open();

        SqlDataReader? ret = await command.ExecuteReaderAsync();
        if (ret.Read())
        {
          connect.Close();
          return true;
        }
        else
        {
          connect.Close();
          return false;
        }
      }
    }

    /// <summary>
    /// Returns the denied expense requests
    /// </summary>
    /// <param name="EmployeeId"></param>
    /// <returns></returns>
    public async Task<bool> DeniedTicketAsync(int EmployeeId) // create guid
    {
       using (SqlCommand command = new SqlCommand($"SELECT * FROM Expenses WHERE EmployeeID = @eid and Approved = 'Approved'", connect))
      {
        command.Parameters.AddWithValue("@eid", EmployeeId);// add dynamic data like this to protect against SQL Injection.
        connect.Open();

        SqlDataReader? ret = await command.ExecuteReaderAsync();
        if (ret.Read())
        {
          connect.Close();
          return true;
        }
        else
        {
          connect.Close();
          return false;
        }
      }
    }

    /// <summary>
    /// Adds a new employee to the database.
    /// </summary>
    /// <param name="e"></param>
    public void NewEmployee(Employees e)
    {
      SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        connect.Open();

        using SqlCommand command = new SqlCommand($"INSERT INTO Employees VALUES (@fName, @lName, @email, @password, @manager)", connect);

        command.Parameters.AddWithValue("@fName", e.FirstName);
        command.Parameters.AddWithValue("@lName", e.LastName);
        command.Parameters.AddWithValue("@email", e.Email);
        command.Parameters.AddWithValue("@IsManager", e.IsManager);
        command.Parameters.AddWithValue("@password", e.Password);

        connect.Close();
    }



  } //end class
} //end namespace
