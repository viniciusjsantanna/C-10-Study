using Microsoft.AspNetCore.Mvc;
using NET6.WEbapi2.Filters;

namespace NET6.WEbapi2.Controllers
{
    [ApiController]
    [ServiceFilter(typeof(ModelsValidationFilter), Order = int.MinValue)]
    public abstract class BaseApiController : ControllerBase
    {
    }
}
