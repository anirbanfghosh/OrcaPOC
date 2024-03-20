using POC.Domain.Entities.Contracts;

namespace POC.API.Services
{
    public interface IContractService
    {
        Task<Root> GetContract(Guid id);
        Task SaveContract(Root contract);
    }
}
