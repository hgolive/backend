using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.WebApi.Features.Sales.RequestResponse;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.Commands;

public class SaleCommands
{
    
}
public class CreateSaleCommand : IRequest<CreateSaleResponse> { /* Add properties here */ }
public class GetSaleCommand : IRequest<GetSaleResponse> { public int Id { get; set; } }
public class DeleteSaleCommand : IRequest { public int Id { get; set; } }