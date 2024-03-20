using POC.Domain.Entities.Contracts;

namespace POC.Domain.Interfaces
{
    public interface IContractRepository
    {
        Task<Root> GetContract(Guid contract);
        Task SaveContract(Root contract);
    }
}
