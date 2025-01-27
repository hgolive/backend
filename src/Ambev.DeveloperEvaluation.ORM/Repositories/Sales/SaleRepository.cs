using System.Threading;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly DefaultContext _context;

        public SaleRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken)
        {
            _context.Sales.Add(sale);
            await _context.SaveChangesAsync(cancellationToken);
            return sale;
        }

        public async Task<Sale> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Sales.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var sale = await _context.Sales.FindAsync(new object[] { id }, cancellationToken);
            if (sale != null)
            {
                _context.Sales.Remove(sale);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}