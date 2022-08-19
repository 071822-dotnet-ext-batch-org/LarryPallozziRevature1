using ModelsLayer;
using System.Data.SqlClient;
using System.Windows.Input;

namespace RepositoryLayer
{
    public class ReimbursementRepositoryLayer
    {

        /// <summary>
        /// #1 query for login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<LoginDTO> LoginAsync(LoginDTO login)
        {   //DB connection and query
            SqlConnection connection = new SqlConnection("Server = tcp:larrypallozziazureserver.database.windows.net,1433; Initial Catalog = EmployeeReimbursementSystem; Persist Security Info = False; User ID=LarryAzureLogin; Password=Alaska<!13; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            using (SqlCommand command = new SqlCommand($"SELECT Email, Password FROM Employees WHERE Email = @e AND Password = @p", connection))
            {   //stop sql injection
                command.Parameters.AddWithValue("@e", login.Email);
                command.Parameters.AddWithValue("@p", login.Password);
                //open connection
                connection.Open();
                // reads query
                SqlDataReader? ret = await command.ExecuteReaderAsync();
               
                if (ret.Read())
                {
                    LoginDTO l = new LoginDTO(ret.GetString(0), ret.GetString(1));
                    return l; //returns eemail and password
                }
                connection.Close();
                return null; //closes program
            }
        }

        /// <summary>
        /// #2 add new employee
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public async Task<Employee> NewEmployeeAsync(Employee emp)
        {   //
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password= password ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"UPDATE Employees SET EmployeeID = @eid, FirstName = @fn, LastName = @ln, IsManager = @im, Email = @e, Password = @p WHERE Email = @e IF @@ROWCOUNT = 0 INSERT INTO Employees(EmployeeID, FirstName, LastName, IsManager, Email, Password) VALUES(@eid, @fn, @ln, @im, @e, @p)", connect))
            {
                command.Parameters.AddWithValue("@eid", emp.EmployeeID);
                command.Parameters.AddWithValue("@fn", emp.FirstName);
                command.Parameters.AddWithValue("@Ln", emp.LastName);
                command.Parameters.AddWithValue("@im", emp.IsManager);
                command.Parameters.AddWithValue("@e", emp.Email);
                command.Parameters.AddWithValue("@p", emp.Password);

                connect.Open();

                int ret = await command.ExecuteNonQueryAsync();
                // Will continue to run through above params and return DB values
                if (ret > 0)
                {
                    return emp;
                }
                connect.Close();
                return null;


            }
            connect.Close();
            return null;
        }

        /// <summary>
        /// #3 Takes Request and its constructor to be used to pass a new expense request
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        public async Task<Request> SubmitReimbursementAsync(Request req)        
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password= password ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"INSERT INTO Request (TicketID, FK_EmployeeId, Details, Amount, Status) VALUES (@tid, @eid, @d, @a, @s);", connect))
            {
                command.Parameters.AddWithValue("@tid", req.TicketID);
                command.Parameters.AddWithValue("@eid", req.FKEmployeeId);
                command.Parameters.AddWithValue("@d", req.Details);
                command.Parameters.AddWithValue("@a", req.Amount);
                command.Parameters.AddWithValue("@s", req.Status);

                connect.Open();
                // Inserting and not querying 
                int ret = await command.ExecuteNonQueryAsync();
                // Returns params as long as there are more then 0 left
                while (ret == 1)
                {
                    return req;
                }
                connect.Close();
                return null;


            }
            connect.Close();
            return null;
        }

        /// <summary>
        /// #4 Check which status the expense request is,
        /// </summary>
        /// <paramname= 'type' ></param>
        /// <returns></returns>
        public async Task<List<Request>> RequestsAsync(Guid? employeeId, int type)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password= password ;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Request WHERE Status = @status AND FK_EmployeeId = @eid" , connect))
            {
                command.Parameters.AddWithValue("@status", type);
                command.Parameters.AddWithValue("@eid", employeeId);

                connect.Open();
                //creating list of returned values and reading command
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                List<Request> rList = new List<Request>();
                
                while (ret.Read())
                {   
                    Request r = new Request((Guid)ret[0], (Guid)ret[1], ret.GetString(2), ret.GetDecimal(3), ret.GetInt32(4));
                    rList.Add(r);
                }
                    connect.Close();
                    return rList;
                
            }
        }

        /// <summary>
        /// #4 updates the status on Requests table
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task<UpdatedRequestDto> UpdateRequestAsync(Guid ticketId, int status)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password= password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"UPDATE Request SET Status = @status WHERE Status = 0 AND TicketID = @tid", connect)) //0
            {
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@tid", ticketId);
                connect.Open();
                // helps set the request status different from 0
                int ret = await command.ExecuteNonQueryAsync();
                
                if (ret == 1)
                {
                    connect.Close();
                    
                    UpdatedRequestDto urbi = await this.UpdatedRequestByIdAsync(ticketId);
                    
                    return urbi;
                }
                connect.Close();
                return null;
            }
        }

        /// <summary>
        /// #4 Selects the information for the passed ticketId
        /// </summary>
        /// <param name="ticketId"></param>
        /// <returns></returns>
        public async Task<UpdatedRequestDto> UpdatedRequestByIdAsync(Guid ticketId)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password= password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT TicketID, FirstName, LastName, Status FROM Employees LEFT JOIN Request ON EmployeeID = FK_EmployeeId WHERE TicketID = @tid", connect))
              {
                
                command.Parameters.AddWithValue("@tid", ticketId);
                connect.Open();

                SqlDataReader? ret = await command.ExecuteReaderAsync();
                // get updated information
                if (ret.Read())
                {
                    UpdatedRequestDto r = new UpdatedRequestDto(ret.GetGuid(0), ret.GetString(1), ret.GetString(2), ret.GetInt32(3));
                    connect.Close();
                    return r;
                }
                connect.Close();
                return null;
            }
        }
        

            /// <summary>
            /// $4 Checks to see if they are a manager
            /// </summary>
            /// <param name="EmployeeID"></param>
            /// <returns></returns>
        public async Task<bool> IsManagerAsync(Guid employeeId)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password= password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT IsManager FROM Employees WHERE EmployeeID = @id", connect))
            {
                command.Parameters.AddWithValue("@id", employeeId);
                
                connect.Open();
                // Check to see if the employee is a manager
                SqlDataReader? ret = await command.ExecuteReaderAsync();

                if (ret.Read())
                {
                    if (ret.GetBoolean(0))
                    {
                        connect.Close();
                        return true;
                    } 
                          
                }
                connect.Close();
                return false;
            }  
        }

        /// <summary>
        /// #5 Employees filter by status
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public async Task<List<Request>> FilterRequestsAsync(Guid employeeId, int type)
        {       //Create the sql connection and query
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password= password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Request WHERE Status = @status AND FK_EmployeeId = @eid", connect))
            {   ///params to stop sql injection
                command.Parameters.AddWithValue("@status", type);
                command.Parameters.AddWithValue("@eid", employeeId);

                connect.Open();// open connection
                SqlDataReader? ret = await command.ExecuteReaderAsync(); //create vari that reads the query
                List<Request> rList = new List<Request>(); // blank list

                while (ret.Read())
                {   // Puts query results into a list
                    Request r = new Request((Guid)ret[0], (Guid)ret[1], ret.GetString(2), ret.GetDecimal(3), ret.GetInt32(4)); 
                    rList.Add(r);
                }
                connect.Close(); // close connection
                return rList; // return list

            }
        }

  

    }//EC
}//EN