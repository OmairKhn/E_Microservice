using Products1.Application.DTOs;
using static Products1.Application.DTOs.AddProductDTO;

namespace Products1.Infrastucture.Service.Interface
{
    public interface IProductService
    {
        public Task<int> AddProduct(AddProductDTO product);

        public Task<int> UpdateProduct(UpdateProductDTO product);

        public Task<int> DeleteProduct(int id);

        public Task<ProductDTO?> GetProductbyid(int id);

<<<<<<< HEAD
        Task<List<ProductShortDetaisDTO>?> GetProductsByIds(List<int> ids);

=======
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
        public Task<List<ProductDTO>> GetAllProducts();
    }
}
