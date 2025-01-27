namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer.RequestResponse;

// Requests
public class CreateCustomerRequest { public string Name { get; set; } public string Email { get; set; } }
public class GetCustomerRequest { public int Id { get; set; } }
public class DeleteCustomerRequest { public int Id { get; set; } }
