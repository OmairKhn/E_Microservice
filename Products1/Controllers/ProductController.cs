using Microsoft.AspNetCore.Mvc;
using Products1.Application.DTOs;
using Products1.Infrastucture.Service.Interface;

namespace Products1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductDTO product)
        {
           int  result = await _service.AddProduct(product);
            if (result > 0)
            {
                return Ok(new APIResponse<AddProductDTO>
                {
                    Data = product,
                    TotalCount = 1,
                    success = true,
                    Message = "Product added successfully"
                });
            }
            else
            {
                return BadRequest(new APIResponse<AddProductDTO>
                {
                    
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to add product"
                });
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _service.GetAllProducts();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await _service.GetProductbyid(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var result = await _service.DeleteProduct(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO product)
        {
            try
            {
                var result = await _service.UpdateProduct(product);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}

