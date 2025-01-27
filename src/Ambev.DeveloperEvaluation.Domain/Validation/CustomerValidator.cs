using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class CustomerValidator
{
    
}
// Validators
public class CreateCustomerRequestValidator : AbstractValidator<Customer>
{
    public CreateCustomerRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Email).EmailAddress();
    }
}



public class GetCustomerRequestValidator : AbstractValidator<Customer>
{
    public GetCustomerRequestValidator()
    {
        RuleFor(x => x.CustomerId).GreaterThan(0);
    }
}

public class DeleteCustomerRequestValidator : AbstractValidator<Customer>
{
    public DeleteCustomerRequestValidator()
    {
        RuleFor(x => x.CustomerId).GreaterThan(0);
    }
}
