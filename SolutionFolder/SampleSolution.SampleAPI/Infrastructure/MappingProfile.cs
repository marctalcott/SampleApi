using AutoMapper;
using SampleSolution.Data;
using SampleSolution.DTO;

namespace SampleSolution.SampleAPI.Infrastructure
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<BankBranch, BankBranchDto>().ReverseMap();
            
            // TODO: Add one mapping per DataEntity, DTO you need to map
            // could be more if you have some really special mapping setups.
            // Learn more about AutoMapper
        }
    }
}