using System.Threading;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DefaultContext _context;

        public ProductRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(Product product, CancellationToken cancellationToken)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync(cancellationToken);
            return product;
        }

        public async Task<Product> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Products.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(new object[] { id }, cancellationToken);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}