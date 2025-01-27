using System.Threading;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISaleRepository
    {
        Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken);
        Task<Sale> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}