using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace LookupsService
{
    public class Lookups : lookupsSVC.lookupsSVCBase
    {
        #region actions.

        public override Task<LookupResponse> GetLookup(LookupRequest request, ServerCallContext context)
        {
            var lookups = new List<Lookup>{
                new Lookup { Id = 1, Name = "Wael", Age=28, Address="Cairo" },
                new Lookup { Id = 2, Name = "Ahmed", Age= 44, Address="Mansoura"},
                new Lookup { Id = 3, Name = "Mourad",  Age=66, Address="Alex" }
            };

            var lookup = lookups.FirstOrDefault(x => x.Id == request.Id);
            return Task.FromResult(Map(lookup));
        }

        #endregion

        #region helpers

        public LookupResponse Map(Lookup from)
        {
            var to = new LookupResponse
            {
                Id = from.Id,
                Address = from.Address,
                Age = from.Age,
                Name = from.Name,
            };

            return to;
        }

        #endregion

    }

    #region nested.

    public class Lookup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    #endregion
}
