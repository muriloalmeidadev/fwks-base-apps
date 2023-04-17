using FluentValidation;
using Fwks.Core.Extensions;

namespace Fwks.FwksApp.Core.Requests.Validators;

public class AddCustomerRequestValidator : AbstractValidator<AddCustomerRequest>
{
    public AddCustomerRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();

        RuleFor(x => x.Email).EmailAddress();

        RuleFor(x => x.PhoneNumber).PhoneNumber();
    }
}
