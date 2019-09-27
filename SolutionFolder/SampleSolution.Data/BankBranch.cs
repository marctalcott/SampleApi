using System;
using System.Collections.Generic;

namespace SampleSolution.Data
{
    public partial class BankBranch
    {
        public BankBranch()
        {
            Employee = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress1 { get; set; }
        public string BranchAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
