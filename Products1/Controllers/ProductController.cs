using Microsoft.AspNetCore.Mvc;
using Products1.Application.DTOs;
using Products1.Infrastucture.Service.Interface;

namespace Products1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        // ==============================
        // Add Product
        // ==============================
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductDTO product)
        {
            try
            {
                int result = await _service.AddProduct(product);

                if (result > 0)
                {
                    return Ok(new APIResponse<AddProductDTO>
                    {
                        Data = product,
                        TotalCount = 1,
                        success = true,
                        Message = "Product added successfully."
                    });
                }

                return BadRequest(new APIResponse<AddProductDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to add product."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<AddProductDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        // ==============================
        // Get All Products
        // ==============================
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var result = await _service.GetAllProducts();

                return Ok(new APIResponse<List<ProductDTO>>
                {
                    Data = result,
                    TotalCount = result.Count,
                    success = true,
                    Message = "Products retrieved successfully."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<List<ProductDTO>>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        // ==============================
        // Get Product By Id
        // ==============================
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            try
            {
                var result = await _service.GetProductbyid(id);

                if (result == null)
                {
                    return NotFound(new APIResponse<ProductDTO>
                    {
                        Data = null,
                        TotalCount = 0,
                        success = false,
                        Message = "Product not found."
                    });
                }

                return Ok(new APIResponse<ProductDTO>
                {
                    Data = result,
                    TotalCount = 1,
                    success = true,
                    Message = "Product retrieved successfully."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<ProductDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        // ==============================
        // Update Product
        // ==============================
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO product)
        {
            try
            {
                int result = await _service.UpdateProduct(product);

                if (result > 0)
                {
                    return Ok(new APIResponse<UpdateProductDTO>
                    {
                        Data = product,
                        TotalCount = 1,
                        success = true,
                        Message = "Product updated successfully."
                    });
                }

                return BadRequest(new APIResponse<UpdateProductDTO>
                {
                    Data = product,
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to update product."
                });
            }
            catch (Exception ex)
            {
                return NotFound(new APIResponse<UpdateProductDTO>
                {
                    Data = product,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        // ==============================
        // Delete Product
        // ==============================
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                int result = await _service.DeleteProduct(id);

                if (result > 0)
                {
                    return Ok(new APIResponse<int>
                    {
                        Data = id,
                        TotalCount = 1,
                        success = true,
                        Message = "Product deleted successfully."
                    });
                }

                return BadRequest(new APIResponse<int>
                {
                    Data = id,
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to delete product."
                });
            }
            catch (Exception ex)
            {
                return NotFound(new APIResponse<int>
                {
                    Data = id,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        // ==============================
        // Get Products By Ids
        // ==============================
        [HttpPost("products-by-ids")]
        public async Task<IActionResult> GetProductsByIds([FromBody] List<int> ids)
        {
            try
            {
                var result = await _service.GetProductsByIds(ids);

                return Ok(new APIResponse<List<ProductShortDetaisDTO>>
                {
                    Data = result,
                    TotalCount = result?.Count ?? 0,
                    success = true,
                    Message = "Products retrieved successfully."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<List<ProductShortDetaisDTO>>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }
    }
}