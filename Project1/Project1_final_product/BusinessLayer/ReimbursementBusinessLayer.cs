using ModelsLayer;
using RepositoryLayer;


namespace BusinessLayer
{
    public class ReimbursementBusinessLayer
    {
        private readonly ReimbursementRepositoryLayer _repoLayer;


        public ReimbursementBusinessLayer()
        {
            this._repoLayer = new ReimbursementRepositoryLayer();
        }
        /// <summary>
        /// #1 add new employee
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<LoginDTO> LoginAsync(LoginDTO login)
        {
            LoginDTO loginDto = await this._repoLayer.LoginAsync(login);
            return loginDto;
        }

        /// <summary>
        /// #2 Created new employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task<Employee> NewEmployeeAsync(Employee employee)
        {
            Employee e = await this._repoLayer.NewEmployeeAsync(employee);
            return e;
        }

        /// <summary>
        /// #3 collects and puts together the models and sql
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<Request> SubmitReimbursementAsync(Request req)
        {

            Request r = await this._repoLayer.SubmitReimbursementAsync(req);
            return r;
        }


        /// <summary>
        /// # 4 Returns the status approval 0-pending, 1-approved, 2-denied
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public async Task<List<Request>> RequestsAsync(Guid? employeeId, int type)
        {
            List<Request> list = await this._repoLayer.RequestsAsync(employeeId, type);
            return list;
        }


        /// <summary>
        /// #4 The Manager can change the status code
        /// </summary>
        /// <param name="approvalDto"></param>
        /// <returns></returns>
        public async Task<UpdatedRequestDto> UpdateRequestAsync(ApprovalDTO approvalDto)
        {
            if (await this._repoLayer.IsManagerAsync(approvalDto.EmployeeID))
            {
                UpdatedRequestDto approvedRequest = await this._repoLayer.UpdateRequestAsync(approvalDto.TicketId, approvalDto.Status);
                return approvedRequest;
            }
            else
            {
                return null;
            }
         }

        /// <summary>
        /// #5 method to help filter results
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public async Task<List<Request>> FilterRequestsAsync(Guid employeeId, int type)
        {
            List<Request> list = await this._repoLayer.FilterRequestsAsync(employeeId, type);
            return list;
        }





    } //EC
}//EN
