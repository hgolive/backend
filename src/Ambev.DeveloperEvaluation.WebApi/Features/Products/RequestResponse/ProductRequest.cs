namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.RequestResponse;

public class ProductRequest
{
    
}

public class CreateProductRequest { public string Name { get; set; } public decimal Price { get; set; } }
public class GetProductRequest { public int Id { get; set; } }
public class DeleteProductRequest { public int Id { get; set; } }