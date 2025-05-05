using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

[ApiController]
[Route("[controller]")]
public class ECommerceController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        throw new NotImplementedException();
    }

}