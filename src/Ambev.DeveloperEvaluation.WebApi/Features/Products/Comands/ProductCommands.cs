using Ambev.DeveloperEvaluation.WebApi.Features.Products.RequestResponse;
using MediatR;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.Commands;

public class ProductCommands
{
    
}

public class CreateProductCommand : IRequest<CreateProductResponse> { public string Name { get; set; } public decimal Price { get; set; } }
public class GetProductCommand : IRequest<GetProductResponse> { public int Id { get; set; } }
public class DeleteProductCommand : IRequest { public int Id { get; set; } }