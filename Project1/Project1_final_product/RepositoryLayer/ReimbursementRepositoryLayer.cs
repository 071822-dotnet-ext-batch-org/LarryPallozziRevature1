using ModelsLayer;
using System.Data.SqlClient;
using System.Windows.Input;

namespace RepositoryLayer
{
    public class ReimbursementRepositoryLayer
    {   
        /*
        public async Task<List<LoginDTO>> ReturningUserAsync(string email, string password)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT Email, Password FROM Employees WHERE Email = @e AND Password = Qp", connect))
            {
                command.Parameters.AddWithValue("@e", email);
                command.Parameters.AddWithValue("@p", password);
                connect.Open();
                
                SqlDataReader? ret = await command.ExecuteReaderAsync();

                if (ret.Read())
                {
                    if (ret != null)
                    {
                        connect.Close();
                        return true;
                    }

                }
                connect.Close();
                return false;

            }
        }

        */


        /// <summary>
        /// Check which status the expense request is,
        /// </summary>
        /// <paramname= 'type' ></param>
        /// <returns></returns>
        public async Task<List<Request>> RequestsAsync(Guid? employeeId, int type)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Request WHERE Status = @status AND FK_EmployeeId = @eid" , connect))
            {
                command.Parameters.AddWithValue("@status", type);
                command.Parameters.AddWithValue("@eid", employeeId);

                connect.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                List<Request> rList = new List<Request>();
                
                while (ret.Read()) //check
                {
                    Request r = new Request((Guid)ret[0], (Guid)ret[1], ret.GetString(2), ret.GetDecimal(3), ret.GetInt32(4));
                    rList.Add(r);
                }
                    connect.Close();
                    return rList;
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task<UpdatedRequestDto> UpdateRequestAsync(Guid ticketId, int status)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"UPDATE Request SET Status = @status WHERE TicketID = @tid", connect))
            {
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@tid", ticketId);
                connect.Open();
                int ret = await command.ExecuteNonQueryAsync();

                if (ret == 1)
                {
                    connect.Close();
                    // RequestById() method
                    // 1 create 2 methods that would be useful and reusable

                    // UpdatedRequestById(); return name and details from dto
                    UpdatedRequestDto urbi = await this.UpdatedRequestByIdAsync(ticketId);
                    
                    return urbi;
                }
                connect.Close();
                return null;
            }
        }

        /// <summary>
        /// Selects the information for the passed ticketId
        /// </summary>
        /// <param name="ticketId"></param>
        /// <returns></returns>
        public async Task<UpdatedRequestDto> UpdatedRequestByIdAsync(Guid ticketId)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT TicketID, FirstName, LastName, Status FROM Employees LEFT JOIN Request ON EmployeeID = FK_EmployeeId WHERE TicketID = @tid", connect))
              {
                
                command.Parameters.AddWithValue("@tid", ticketId);
                connect.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();

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
            /// Checks to see if they are a manager
            /// </summary>
            /// <param name="EmployeeID"></param>
            /// <returns></returns>
        public async Task<bool> IsManagerAsync(Guid employeeId)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT IsManager FROM Employees WHERE EmployeeID = @id", connect))
            {
                command.Parameters.AddWithValue("@id", employeeId);
                
                connect.Open();
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
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Request WHERE Status = @status AND FK_EmployeeId = @eid", connect))
            {
                command.Parameters.AddWithValue("@status", type);
                command.Parameters.AddWithValue("@eid", employeeId);

                connect.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                List<Request> rList = new List<Request>();

                while (ret.Read()) //check
                {
                    Request r = new Request((Guid)ret[0], (Guid)ret[1], ret.GetString(2), ret.GetDecimal(3), ret.GetInt32(4));
                    rList.Add(r);
                }
                connect.Close();
                return rList;

            }
        }


        /*
        /// <summary>
        /// # 3 Add a new reimbursement request.
        /// </summary>
        /// <param name="ticketId"></param>
        /// <param name="fk_employeeId"></param>
        /// <param name="details"></param>
        /// <param name="amount"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public async Task<SubmitDTO> NewReimbursement(Guid ticketId, Guid fk_employeeId, string details, decimal amount, int status)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:larrypallozziazureserver.database.windows.net,1433;Initial Catalog=EmployeeReimbursementSystem;Persist Security Info=False;User ID=LarryAzureLogin;Password=Alaska<!13;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"INSERT INTO Request (TicketID, FK_EmployeeId, Details, Status) VALUES(TicketID = @tid, FK_EmployeeId = @eid, Details = @d, Amount = @a, Status = @s)",connect))
            {
                command.Parameters.AddWithValue(('@tid', ticketId));
                command.Parameters.AddWithValue(('@eid', fk_employeeId));
                command.Parameters.AddWithValue(('@d', details));
                command.Parameters.AddWithValue(('@a', amount));
                command.Parameters.AddWithValue(('@s', status));

                connect.Open();

                int ret = await command.ExecuteNonQueryAsync();

                SubmitDTO sdto= await this.;

                return sdto;
            }
            connect.Close();
            return null;
        }
        }
        */







    }//EC
}//EN