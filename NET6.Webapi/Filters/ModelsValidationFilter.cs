using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NET6.Domain.Exceptions.Base.ValidationFilter;
using NET6.Domain.Models.Customers.Inputs;

namespace NET6.WEbapi2.Filters
{
    public class ModelsValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                List<string>? errors = context.ModelState
                    .SelectMany(x => x.Value is not null ? x.Value.Errors : throw new ValidationFilterException())
                    .Select(e => e.ErrorMessage)
                    .ToList();
                context.Result = new BadRequestObjectResult(errors);
            }
            else
            {
                await next();
            }
        }
    }
}
