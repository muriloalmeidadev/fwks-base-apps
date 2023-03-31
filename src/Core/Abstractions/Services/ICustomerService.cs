using System.Threading.Tasks;
using Fwks.Core.Domain;
using Fwks.FwksApp.Core.Models.Requests;
using Fwks.FwksApp.Core.Models.Responses;

namespace Fwks.FwksApp.Core.Abstractions.Services;

public interface ICustomerService
{
    Task AddAsync(AddCustomerRequest request);
    Task<Page<CustomerResponse>> FindByFilterAsync(GetCustomerByNameRequest filter);
}