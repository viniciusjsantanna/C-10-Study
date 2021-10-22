using FluentValidation;
using NET6.Domain.Models.Customers.Inputs;

namespace NET6.WEbapi2.Validators.V1.Customers
{
    public class CustomerInputValidator : AbstractValidator<CustomerInput>
    {
        public CustomerInputValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage("Campo Nome não pode ser vázio!")
                .NotNull().WithMessage("Campo Nome é Obrigatório");
        }
    }
}
