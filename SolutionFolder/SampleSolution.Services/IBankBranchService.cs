using System.Threading.Tasks;
using SampleSolution.Data;
using SampleSolution.DTO;

namespace SampleSolution.Services
{
    public interface IBankBranchService
    {
        Task<BankBranchDto> Get(int id);
        Task<BankBranchDto> Insert(BankBranchDto bankBranch);
        Task<BankBranchDto> Update(BankBranchDto bankBranch);
        Task Delete(int id);
    }
}