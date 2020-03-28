using System.Threading.Tasks;
using Grpc.Core;
using LookupsService;
using Microsoft.Extensions.Logging;

namespace EmployeeService
{
    public class employee : Employees.EmployeesBase
    {
        private readonly ILogger<employee> _logger;
        private readonly lookupsSVC.lookupsSVCClient _client;
        public employee(ILogger<employee> logger, lookupsSVC.lookupsSVCClient client)
        {
            _logger = logger;
            _client = client;
        }

        public override Task<EmployeeInfo> GetEmployee(EmployeeId request, ServerCallContext context)
        {
            var lookupResponse = _client.GetLookup(new LookupRequest { Id = request.Id });
            return Task.FromResult(new EmployeeInfo
            {
                Id = request.Id,
                Age = lookupResponse.Age,
                Name = lookupResponse.Name,
                Address = lookupResponse.Address,
                
            }); 
        }
    }
}
