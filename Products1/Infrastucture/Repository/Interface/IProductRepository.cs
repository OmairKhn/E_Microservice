using Products1.Infrastucture.Data.Models;

namespace Products1.Infrastucture.Repository.Interface
{
    public interface IProductRepository

    {
        public Task<int> AddProduct(Products product);

        public Task<int> UpdateProduct(Products product);

        public Task<int> DeleteProduct(Products product);

        public Task<Products?> GetProductbyid(int id);

        public Task<List<Products>> GetAllProducts();

      public  Task<List<Products  >> GetProductByName(string name);
        public   Task<List<Products>?> GetProductsByIds(List<int> ids);


    }
}
