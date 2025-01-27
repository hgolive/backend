using System.Threading;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product, CancellationToken cancellationToken);
        Task<Product> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}