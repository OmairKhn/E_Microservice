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
=======
        // ---------------- ADD PRODUCT ----------------
>>>>>>> 09381af (test)
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
<<<<<<< HEAD
<<<<<<< HEAD
                return Ok(new ApiResponse<ProductDTO>
                {
                    Data = result,
                    TotalCount = 1,
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
=======
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
>>>>>>> 09381af (test)
                    success = true,
                    Message = "Product retrieved successfully"
                });
            }
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 09381af (test)
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<ProductDTO>
                {
                    Data = null,
                    success = false,
                    Message = ex.Message
                });
<<<<<<< HEAD
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
=======
            }
        }

        // ---------------- DELETE ----------------
>>>>>>> 09381af (test)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 09381af (test)
                int result = await _service.DeleteProduct(id);

                return Ok(new APIResponse<object>
                {
<<<<<<< HEAD
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
=======
                    Data = null,
                    success = true,
                    Message = "Product deleted successfully"
                });
>>>>>>> 09381af (test)
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
<<<<<<< HEAD
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
=======

        // ---------------- UPDATE ----------------
>>>>>>> 09381af (test)
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO product)
        {
            try
            {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 09381af (test)
                int result = await _service.UpdateProduct(product);

                return Ok(new APIResponse<object>
                {
<<<<<<< HEAD
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
=======
                    Data = null,
                    success = true,
                    Message = "Product updated successfully"
                });
>>>>>>> 09381af (test)
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
    }
<<<<<<< HEAD
}

>>>>>>> 6f049bb (Add .gitignore and remove generated files)
=======
}
>>>>>>> 09381af (test)
