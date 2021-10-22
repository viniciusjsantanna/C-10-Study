using Microsoft.AspNetCore.Mvc;
using NET6.Domain.Interfaces.Repositories;
using NET6.Domain.Models.Customers.Inputs;
using NET6.WEbapi2.Filters;

namespace NET6.WEbapi2.Controllers.V1;

[Route("api/customers")]
[ApiController]
public class CustomerController : BaseApiController
{
    private readonly ICustomerRepository customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        this.customerRepository = customerRepository;
    }

    [HttpPost]
    public async Task<IActionResult> RegisterCustomerAsync([FromBody] CustomerInput customer, CancellationToken cancellationToken)
    {
        return Ok(await customerRepository.AddCustomerAsync(customer, cancellationToken));
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] string? customerCode)
    {
        await Task.CompletedTask;
        return Ok(customerCode);
    }
}
