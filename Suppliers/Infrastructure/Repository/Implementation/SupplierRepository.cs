using Microsoft.EntityFrameworkCore;
using Suppliers.Infrastructure.Data;
using Suppliers.Infrastructure.Data.Model;
using Suppliers.Infrastructure.Repository.Interface;

namespace Suppliers.Infrastructure.Repository.Implementation
{
    public class SupplierRepository : ISupplierRepository
    {

        private readonly AppDbContext _context;
        public SupplierRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(Supplier s)
        {
            _context.Suppliers.Add(s);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Supplier s)
        {
            
            _context.Suppliers.Remove(s);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Supplier>> GetAllSuppliers()
        {
           return await _context.Suppliers.ToListAsync();
           
        }

        public async Task<List<Supplier>> GetAllSuppliersBasic()
        {
            return await _context.Suppliers.ToListAsync();

        }

        public async Task<Supplier?> GetSupplierById(int id)
        {
            var supplier = _context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return null;
            }
            return await supplier;
        }

       

        public async Task<List<Supplier>> GetSuppliersByIdsAsync(IEnumerable<int> ids)
        {
            return await _context.Suppliers
                .Where(s => ids.Contains(s.Id))
                .ToListAsync();
        }

        public async Task<List<Supplier>> GetSuppliersByIdsBasicAsync(IEnumerable<int> ids)
        {
            return await _context.Suppliers
                .Where(s => ids.Contains(s.Id))
                .ToListAsync();
        }

        public async Task<int> Update(Supplier s)
        {
            return await _context.SaveChangesAsync();
        }
    }
}
