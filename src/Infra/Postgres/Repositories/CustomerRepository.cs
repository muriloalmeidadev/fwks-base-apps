using Fwks.FwksApp.Core.Abstractions.Repositories;
using Fwks.FwksApp.Core.Entities;
using Fwks.FwksApp.Infra.Postgres.Contexts;
using Fwks.Postgres.Repositories;

namespace Fwks.FwksApp.Infra.Postgres.Repositories;

public sealed class CustomerRepository : BaseRepository<Customer, int>, ICustomerRepository<Customer, int>
{
    public CustomerRepository(
        AppServiceContext dbContext) : base(dbContext)
    {
    }
}