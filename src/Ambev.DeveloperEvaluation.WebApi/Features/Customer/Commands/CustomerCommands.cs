using Ambev.DeveloperEvaluation.WebApi.Features.Customer.RequestResponse;
using MediatR;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.Commands;

// Commands
public class CreateCustomerCommand : IRequest<CreateCustomerResponse> { public string Name { get; set; } public string Email { get; set; } }

public interface IRequest<T>
{
}

public class GetCustomerCommand : IRequest<GetCustomerResponse> { public int Id { get; set; } }
public class DeleteCustomerCommand : IRequest { public int Id { get; set; } }