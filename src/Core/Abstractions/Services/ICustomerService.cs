using System.Threading.Tasks;
using Fwks.Core.Domain;
using Fwks.FwksApp.Core.Requests;
using Fwks.FwksApp.Core.Responses;

namespace Fwks.FwksApp.Core.Abstractions.Services;

public interface ICustomerService
{
    Task<CustomerCreatedResponse> AddAsync(AddCustomerRequest request);
    Task<Page<CustomerResponse>> FindByFilterAsync(GetCustomerByNameRequest filter);
}