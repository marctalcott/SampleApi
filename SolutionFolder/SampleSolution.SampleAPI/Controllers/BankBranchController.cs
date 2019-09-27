using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleSolution.Services;

namespace SampleSolution.SampleAPI.Controllers
{
    [Route("api/[controller]")]
    public class BankBranchController : Controller
    {
        private IBankBranchService _bankBranchService;
        public BankBranchController(IBankBranchService bankBranchService)
        {
            _bankBranchService = bankBranchService;
        }
        
        
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var bankBranchDto = await _bankBranchService.Get(id);
            return Ok(bankBranchDto);
        }
    }
}