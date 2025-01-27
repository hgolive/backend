using System.Threading;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DefaultContext _context;

        public CustomerRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Customer> CreateAsync(Customer customer, CancellationToken cancellationToken)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync(cancellationToken);
            return customer;
        }

        public async Task<Customer> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Customers.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var customer = await _context.Customers.FindAsync(new object[] { id }, cancellationToken);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}