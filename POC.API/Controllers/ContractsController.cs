using Microsoft.AspNetCore.Mvc;
using POC.API.Services;
using POC.Domain.Entities.Contracts;


namespace POC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService _contractService;

        public ContractsController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContract(Guid id)
        {
            var contract = await _contractService.GetContract(id);
            if (contract == null)
            {
                return NotFound();
            }
            return Ok(contract);
        }


        [HttpPost]
        public async Task<IActionResult> SaveContract([FromBody] Root contract)
        {
            if (contract == null)
            {
                return BadRequest();
            }
            await _contractService.SaveContract(contract);
            return Ok(new { Message = "Contract created successfully"});
        }
    }
}
