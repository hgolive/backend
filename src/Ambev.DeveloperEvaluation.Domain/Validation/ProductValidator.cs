using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class ProductValidator
{
    
}

public class CreateProductRequestValidator : AbstractValidator<Product>
{
    public CreateProductRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Price).GreaterThan(0);
    }

    public async Task<object> ValidateAsync(Product instance, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

public class GetProductRequestValidator : AbstractValidator<Product>
{
    public GetProductRequestValidator()
    {
        RuleFor(x => x.ProductId).GreaterThan(0);
    }
}

public class DeleteProductRequestValidator : AbstractValidator<Product>
{
    public DeleteProductRequestValidator()
    {
        RuleFor(x => x.ProductId).GreaterThan(0);
    }
}
