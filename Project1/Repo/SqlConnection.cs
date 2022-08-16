using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Repo;

  public class SqlConnection
{
  private static readonly SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

  public async Task<> currentEmployee(Email)
  {

  }

}
