using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class ApprovalDTO
    {
        public ApprovalDTO(Guid ticketId, Guid employeeId, int status)
        {
            TicketId = ticketId;
            EmployeeID = employeeId;
            Status = status;
        }

        public Guid TicketId { get; set; }
        public Guid EmployeeID { get; set; }
        public int Status { get; set; }
    }
}
