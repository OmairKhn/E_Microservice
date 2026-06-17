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

<<<<<<< HEAD
        // ---------------- ADD PRODUCT ----------------
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
                        Message = "Product added successfully"
                    });
                }

                return BadRequest(new APIResponse<AddProductDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to add product"
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

        // ---------------- GET ALL ----------------
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
                    Message = "Products retrieved successfully"
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

        // ---------------- GET BY ID ----------------
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
                        success = false,
                        Message = "Product not found"
                    });
                }

                return Ok(new APIResponse<ProductDTO>
                {
                    Data = result,
=======
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
<<<<<<< HEAD
                return Ok(new ApiResponse<ProductDTO>
                {
                    Data = result,
                    TotalCount = 1,
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
                    success = true,
                    Message = "Product retrieved successfully"
                });
            }
<<<<<<< HEAD
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<ProductDTO>
                {
                    Data = null,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        // ---------------- DELETE ----------------
=======



=======
                return NotFound();
            }
            return Ok(result);
>>>>>>> c2e0b3c (optamization and Apiresponse add)
        }

>>>>>>> 6f049bb (Add .gitignore and remove generated files)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
<<<<<<< HEAD
                int result = await _service.DeleteProduct(id);

                return Ok(new APIResponse<object>
                {
                    Data = result,
                    success = true,
                    Message = "Product deleted successfully"
                });
            }
            catch (Exception ex)
            {
                return NotFound(new APIResponse<object>
                {
                    success = false,
                    Message = ex.Message
                });
            }
        }

        // ---------------- UPDATE ----------------
=======
                var result = await _service.DeleteProduct(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO product)
        {
            try
            {
<<<<<<< HEAD
                int result = await _service.UpdateProduct(product);

                return Ok(new APIResponse<object>
                {
                    Data = result,
                    success = true,
                    Message = "Product updated successfully"
                });
            }
            catch (Exception ex)
            {
                return NotFound(new APIResponse<object>
                {
                    success = false,
                    Message = ex.Message
                });

            }
        }



        [HttpPost("products-by-ids")]
        public async Task<IActionResult> GetProductsByIds([FromBody] List<int> ids)
        {
            var result = await _service.GetProductsByIds(ids);

            return Ok(new APIResponse<List<ProductShortDetaisDTO>>
            {
                Data = result,
                TotalCount = result?.Count ?? 0,
                success = true,
                Message = "Products retrieved successfully"
            });
        }
    }


    

}
=======
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

>>>>>>> 6f049bb (Add .gitignore and remove generated files)
