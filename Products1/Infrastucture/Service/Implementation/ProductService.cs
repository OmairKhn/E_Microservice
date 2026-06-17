using Products1.Application.DTOs;
using Products1.Infrastucture.Data.Models;
using Products1.Infrastucture.Repository.Interface;
using Products1.Infrastucture.Service.Interface;

namespace Products1.Infrastucture.Service.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public Products? PrdDB { get; private set; }

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> AddProduct(AddProductDTO product)
        {
         var prd = new Products
         {
             Name = product.Name,
             Brand = product.Brand,
             Model = product.Model,
             Description = product.Description,
             Specifications = product.Specifications,
             Price = product.Price

         };
            return await _productRepository.AddProduct(prd);
        }

      

        public async Task<int> DeleteProduct(int id)
        {
            var Product =await _productRepository.GetProductbyid(id);
            if (Product == null)
            {
                throw new Exception("Product not found");
            }
            return await _productRepository.DeleteProduct(Product);
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();

            return products.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Brand = p.Brand,
                Model = p.Model,
                Description = p.Description,
                Specifications = p.Specifications,
                Price = p.Price
            }).ToList();
        }

        public async Task<ProductDTO?> GetProductbyid(int id)
        {
            var product =await _productRepository.GetProductbyid(id);
            if (product == null)
            {
                return null;
            }
            var productDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Brand = product.Brand,
                Model = product.Model,
                Description = product.Description,
                Specifications = product.Specifications,
                Price = product.Price
            };
            return productDTO;
        }
        private async Task<Products?> _getProductbyid(int id)
        {
            var product = await _productRepository.GetProductbyid(id);
            if (product == null)
            {
                return null;
            }
           else
            {
                return product;
            }
        }

        public async Task<int> UpdateProduct(UpdateProductDTO product)
        {
            PrdDB = await _getProductbyid(product.Id);
            if (PrdDB == null)
            {
                throw new Exception("Product not found");
            }
            else
            {
                PrdDB.Name = product.Name;
                PrdDB.Brand = product.Brand;
                PrdDB.Model = product.Model;
                PrdDB.Description = product.Description;
                PrdDB.Specifications = product.Specifications;
                PrdDB.Price = product.Price;

                return await _productRepository.UpdateProduct(PrdDB);
            }
        }

        
    }
}
