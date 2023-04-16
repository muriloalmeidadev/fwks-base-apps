using System.Threading.Tasks;
using Fwks.AspNetCore.Attributes;
using Fwks.FwksApp.Core.Abstractions.Services;
using Fwks.FwksApp.Core.Models.Requests;
using Fwks.FwksApp.Core.Models.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fwks.FwksApp.App.Api.Controllers.V1;

//[Authorize]
[ApiController]
[ApiVersion("1.0")]
[Route("v{v:apiVersion}/[controller]")]
public sealed class CustomersController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomersController(
        ICustomerService service)
    {
        _service = service;
    }

    [HttpPost("")]
    [ProducesResponseType(typeof(CustomerCreatedResponse), StatusCodes.Status200OK)]
    [ProducesApplicationNotificationResponse(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync([FromBody] AddCustomerRequest request)
    {
        return Ok(await _service.AddAsync(request));
    }

    [HttpGet("")]
    [ProducesPagedResponse<CustomerResponse>(StatusCodes.Status200OK)]
    [ProducesApplicationNotificationResponse(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAsync([FromQuery] GetCustomerByNameRequest request)
    {
        return Ok(await _service.FindByFilterAsync(request));
    }
}