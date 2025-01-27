using Ambev.DeveloperEvaluation.WebApi.Features.Customer.Commands;

namespace Ambev.DeveloperEvaluation.Unit.Domain;

public static class CreateProductHandlerTestData
{
    public static CreateProductCommand GenerateValidCommand()
    {
        return new CreateProductCommand
        {
            Name = "Test Product",
            Price = 100.00m
        };
    }
}