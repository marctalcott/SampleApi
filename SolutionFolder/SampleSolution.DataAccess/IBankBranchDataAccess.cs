using System.Threading.Tasks;
using SampleSolution.Data;

namespace SampleSolution.DataAccess
{
    public interface IBankBranchDataAccess
    {
        Task<BankBranch> Get(int id);
        Task<BankBranch> Insert(BankBranch bankBranch);
        Task<BankBranch> Update(BankBranch bankBranch);
        Task Delete(int id);
    }
}