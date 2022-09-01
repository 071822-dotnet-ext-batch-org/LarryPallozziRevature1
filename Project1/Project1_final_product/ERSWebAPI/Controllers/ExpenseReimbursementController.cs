using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using BusinessLayer;

namespace ERSWebAPI.Controllers
{
    [Route("api/[controller]")] //Layer
    [ApiController]
    public class ExpenseReimbursementController : ControllerBase
    {
        private readonly ReimbursementBusinessLayer _businessLayer; //private variable
        public ExpenseReimbursementController() // making reimbursement business layer
        {
            this._businessLayer = new ReimbursementBusinessLayer();
        }

        /// <summary>
        /// #1 For current players to log in with email
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost("CurrentEmployeeAsync")]
        public async Task<ActionResult> CurrentEmployeeAsync(LoginDTO login)
        {
            if (ModelState.IsValid)
            {   // Creates LoginDto object
                LoginDTO loginDto = await this._businessLayer.LoginAsync(login);
                return Ok(loginDto); //returns 200 status code
            }
            return Conflict(login); // Returns 409 status code
        }



        /// <summary>
        /// #2 Create new account
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost("NewEmployeeAsync")]
        public async Task<ActionResult<Employee>> NewEmployeeAsync(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee e = await this._businessLayer.NewEmployeeAsync(employee);
                return Ok(e);
            }
            else
            {
                return Conflict(employee);
            }
        }

        /// <summary>
        /// #3 Allows new expense requestd
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("Request")]
        public async Task<ActionResult<Request>> SubmitReimbursementAsync(Request request)
        {
            if (ModelState.IsValid) //if models works continue
            {
                Request r = await this._businessLayer.SubmitReimbursementAsync(request);
                return Ok(r);
            }
            else return Conflict(request);
        }


        /// <summary>
        /// #4 Manager changes the status
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        [HttpPut("UpdateRequestAsync")] // Pushes to database through http request
        public async Task<ActionResult<UpdatedRequestDto>> ManagerApprovalAsync(ApprovalDTO approval)
        {
            if (ModelState.IsValid) // Checks to make sure the input can be "binded" to the database with out an error
            {
                UpdatedRequestDto approvedRequest = await this._businessLayer.UpdateRequestAsync(approval);
                return approvedRequest; // Return the Updated data transfer object that goes through the UpdateRequest Async repo layer query method
            }
            else return Conflict(approval);// Produces 409 "Conflict" status code if does not work
        }



        /// <summary>=
        /// #4 Get any request type = status 0 = pending, 1 = approved, 2 = denied
        /// </summary>
        /// <returns></returns>
        //[HttpGet("RequestsAsync")]//
        [HttpGet("RequestsAsync/{type}/")] // GET HTTP request that returns type and optional id
        public async Task<ActionResult<List<Request>>> RequestsAsync(Guid? employeeId, int type)
        {
            List<Request> requestsList = await this._businessLayer.RequestsAsync(employeeId, type); // Returns list from database using requestasync sqerl method
            return Ok(requestsList);
        }

        /// <summary>=
        /// #5 Get any request type = status 0 = pending, 1 = approved, 2 = denied
        /// </summary>
        /// <returns></returns>
        //[HttpGet("FilterRequestsAsync")]//
        [HttpGet("FilterRequestsAsync/{type}/")] // GET HTTP request that returns type and optional id
        public async Task<ActionResult<List<Request>>> FilterRequestsAsync(Guid employeeId, int type)
        {
            List<Request> requestsList = await this._businessLayer.FilterRequestsAsync(employeeId, type); // Returns list from database using requestasync sqerl method
            return Ok(requestsList);
        }

    }
}
