using System.Threading.Tasks;
using AutoMapper;
using SampleSolution.Data;
using SampleSolution.DataAccess;
using SampleSolution.DTO;

namespace SampleSolution.Services
{
    public class BankBranchService:IBankBranchService
    {
        private IBankBranchDataAccess _dataAccess;
        private IMapper _mapper;
        public BankBranchService(IBankBranchDataAccess dataAccess, IMapper mapper)
        {
            _dataAccess = dataAccess;
            _mapper = mapper;
        }
        public async Task<BankBranchDto> Get(int id)
        {
            var bankBranch = await _dataAccess.Get(id);
            var dto = _mapper.Map<BankBranchDto>(bankBranch);
            return dto; 
        }

        public async Task<BankBranchDto> Insert(BankBranchDto bankBranch)
        {
            throw new System.NotImplementedException();
        }

        public async Task<BankBranchDto> Update(BankBranchDto bankBranch)
        {
            throw new System.NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}