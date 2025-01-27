using System.Threading;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> CreateAsync(Customer customer, CancellationToken cancellationToken);
        Task<Customer> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task DeleteAsync(int id, CancellationToken cancellationToken);
    }
}