using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Products1.Infrastucture.Data.Models;
using Products1.Infrastucture.Data.Sql;
using Products1.Infrastucture.Repository.Interface;

namespace Products1.Infrastucture.Repository.Implementation
{
    public class ProductRepository : IProductRepository
    {

        private readonly AppDbContext _context;
        
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

         public async Task<int> AddProduct(Products product)
        {
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateProduct(Products product)
        {
            
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Products>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Products?> GetProductbyid(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return null; // or throw an exception, depending on your error handling strategy
            }
            return product; // or return the entire product object if needed
        }

        public async Task<int> DeleteProduct(Products product)
        {
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public Task<List<Products>?> GetProductsByIds(List<int> ids)
  {
            return _context.Products.Where(p => ids.Contains(p.Id)).ToListAsync();

        }

        public Task<List<Products>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
