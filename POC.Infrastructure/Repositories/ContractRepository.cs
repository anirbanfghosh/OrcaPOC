using System.Text.Json;
using Microsoft.Extensions.Configuration;
using POC.Domain.Entities.Contracts;
using POC.Domain.Interfaces;
using StackExchange.Redis;

namespace POC.Infrastructure.Repositories
{
    public class ContractRepository : IContractRepository
    {
        private readonly ConnectionMultiplexer _connectionMultiplexer;

        private readonly IConfiguration _configuration;

        public ContractRepository(IConfiguration configuration)
        {
            
            _configuration = configuration;
            _connectionMultiplexer = ConnectionMultiplexer.Connect(_configuration.GetSection("Redis").GetSection("ConnectionString").Value);
        }

        public async Task<Root> GetContract(Guid id)
        {
            var db = _connectionMultiplexer.GetDatabase();
            var contract = await db.StringGetAsync(id.ToString());
            if (contract.IsNullOrEmpty)
            {
                return null;
            }
            return JsonSerializer.Deserialize<Root>(contract);
        }

        public async Task SaveContract(Root contract)
        {
            var db = _connectionMultiplexer.GetDatabase();
            var contractToSave = JsonSerializer.Serialize(contract);
            await db.StringSetAsync(contract.Contracts._id.ToString(), contractToSave);
        }
    }
}
