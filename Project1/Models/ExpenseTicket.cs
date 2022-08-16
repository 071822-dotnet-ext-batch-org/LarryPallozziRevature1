using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ExpenseTicket
    {
      //For reimbursement request
      public int? EmployeeId { get; set; }
      public string? Date { get; set; }
      public string? Details { get; set; }
      public float? Amount { get; set; }
      public string? Approved = "Not Evaluated";

      //Datatype holding approved or denied
      public enum Evaluate
      {
        Approved,
        Denied
      }

      /*
      public void NotEval()
      {
        this.Approved = Convert.ToString(Evaluate.Not_Evaluated);
      } */
      // Will return Approved
      public void Approval()
      {
        this.Approved = Convert.ToString(Evaluate.Approved);
      }

      // Will return denied
      public void Denial()
      {
        this.Approved = Convert.ToString(Evaluate.Denied);
      }

    /// <summary>
    /// Returns the expenses for a current employee
    /// </summary>
    /// <param name="employeeId"></param>
    /// <param name="date"></param>
    /// <param name="details"></param>
    /// <param name="amount"></param>
    /// <param name="approved"></param>
    public void Expenses(int employeeId, string date, string details, float amount, string approved)
      {
        this.EmployeeId = employeeId;
        this.Date = date;
        this.Details = details;
        this.Amount = amount;
        this.Approved = approved;
      }

    }
}
