using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SalesValidator
{
    
}


public class CreateSaleRequestValidator : AbstractValidator<Sale>
{
    public CreateSaleRequestValidator()
    {
        // Add validation rules here
    }
}

public class GetSaleRequestValidator : AbstractValidator<Sale>
{
    public GetSaleRequestValidator()
    {
        RuleFor(x => x.SaleId).GreaterThan(0);
    }
}

public class DeleteSaleRequestValidator : AbstractValidator<Sale>
{
    public DeleteSaleRequestValidator()
    {
        RuleFor(x => x.SaleId).GreaterThan(0);
    }
}
