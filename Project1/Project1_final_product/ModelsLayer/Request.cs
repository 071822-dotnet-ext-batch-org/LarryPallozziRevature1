using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Request
    {
        /// <summary>
        /// Data trasfer object that will pass the information needed to populate the reimbursement ticket
        /// </summary>
        /// <param name="ticketID"></param>
        /// <param name="fKEmployeeId"></param>
        /// <param name="details"></param>
        /// <param name="amount"></param>
        /// <param name="status"></param>
        public Request(Guid ticketID, Guid fKEmployeeId, string details, decimal amount, int status)
        {
            TicketID = ticketID;
            FKEmployeeId = fKEmployeeId;
            Details = details;
            Amount = amount;
            Status = status;
        }

        public Guid TicketID { get; set; }
        public Guid FKEmployeeId { get; set; }
        public string Details { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }

    }
}
