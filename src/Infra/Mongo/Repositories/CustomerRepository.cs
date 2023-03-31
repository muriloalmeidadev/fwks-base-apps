using System;
using Fwks.FwksApp.Core.Abstractions.Repositories;
using Fwks.FwksApp.Core.Entities;
using Fwks.MongoDb.Repositories;
using MongoDB.Driver;

namespace Fwks.FwksApp.Infra.Mongo.Repositories;

public sealed class CustomerRepository : BaseRepository<CustomerDocument>, ICustomerRepository<CustomerDocument, Guid>
{
    public CustomerRepository(
        IMongoDatabase database)
        : base(database, "customers")
    {
    }
}