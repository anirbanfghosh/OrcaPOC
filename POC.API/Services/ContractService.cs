using POC.Domain.Entities.Contracts;
using POC.Domain.Interfaces;

namespace POC.API.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _contractRepository;

        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }

        public async Task<Root> GetContract(Guid id)
        {
            return await _contractRepository.GetContract(id);
        }

        public async Task SaveContract(Root contract)
        {
            await _contractRepository.SaveContract(contract);
        }
    }
}
