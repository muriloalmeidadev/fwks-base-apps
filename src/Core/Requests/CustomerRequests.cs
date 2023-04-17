using Fwks.Core.Domain;
using Fwks.FwksApp.Core.Enums;

namespace Fwks.FwksApp.Core.Requests;

public sealed record GetCustomerByNameRequest(DbType DbType, string Name = "") : BasePageQuery;

public sealed record AddCustomerRequest(string Name, string DateOfBirth, string Email, string PhoneNumber);