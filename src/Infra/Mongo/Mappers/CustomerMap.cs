using Fwks.FwksApp.Core.Entities;
using Fwks.FwksApp.Infra.Mongo.Abstractions;
using Fwks.MongoDb.Mappers;

namespace Fwks.FwksApp.Infra.Mongo.Mappers;

public sealed class CustomerMap : EntityClassMap<CustomerDocument>, IEntityMap
{
}