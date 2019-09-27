using System;
using System.Collections.Generic;

namespace SampleSolution.Data
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int BankBranchId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual BankBranch BankBranch { get; set; }
    }
}
