using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleSolution.Data;

namespace SampleSolution.DataAccess
{
    public class BankBranchDataAccess: IBankBranchDataAccess
    {
        private SampleDbContext _context;
        public BankBranchDataAccess(SampleDbContext context)
        {
            _context = context;
        }
        public async Task<BankBranch> Get(int id)
        {
            return await _context.BankBranch.SingleAsync(x => x.Id == id);
        }

        public async Task<BankBranch> Insert(BankBranch bankBranch)
        {
            throw new NotImplementedException();
        }

        public async Task<BankBranch> Update(BankBranch bankBranch)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}