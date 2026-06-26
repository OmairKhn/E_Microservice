using Microsoft.AspNetCore.Mvc;
using Suppliers.Application.DTOs;
using Suppliers.Infrastructure.Service.Implementation;
using Suppliers.Infrastructure.Service.Interface;

namespace Suppliers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplerService;

        public SupplierController(ISupplierService IsupplerService)
        {
            _supplerService = IsupplerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddSupplierDTO s)
        {
            try
            {
                int result = await _supplerService.Create(s);

                if (result > 0)
                {
                    return Ok(new APIResponse<AddSupplierDTO>
                    {
                        Data = s,
                        TotalCount = 1,
                        success = true,
                        Message = "Supplier added successfully"
                    });
                }

                return BadRequest(new APIResponse<AddSupplierDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to add supplier"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<AddSupplierDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                int result = await _supplerService.Delete(id);

                if (result > 0)
                {
                    return Ok(new APIResponse<int>
                    {
                        Data = id,
                        TotalCount = 1,
                        success = true,
                        Message = "Supplier deleted successfully"
                    });
                }

                return BadRequest(new APIResponse<int>
                {
                    Data = id,
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to delete supplier"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<int>
                {
                    Data = id,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("basic")]
        public async Task<IActionResult> GetAllSuppliersBasic()
        {
            try
            {
                var result = await _supplerService.GetAllSuppliersBasic();

                return Ok(new APIResponse<List<SupplierBasicDetailsDTO>>
                {
                    Data = result,
                    TotalCount = result.Count,
                    success = true,
                    Message = "Suppliers retrieved successfully"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<List<SupplierBasicDetailsDTO>>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSuppliers()      
        {
            try
            {
                var result = await _supplerService.GetAllSuppliers();

                return Ok(new APIResponse<List<SupplierDetailsDTO>>
                {
                    Data = result,
                    TotalCount = result.Count,
                    success = true,
                    Message = "Suppliers retrieved successfully"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<List<SupplierDetailsDTO>>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierById(int id)
        {
            try
            {
                var result = await _supplerService.GetSupplierById(id);

                if (result != null)
                {
                    return Ok(new APIResponse<SupplierDetailsDTO>
                    {
                        Data = result,
                        TotalCount = 1,
                        success = true,
                        Message = "Supplier retrieved successfully"
                    });
                }

                return NotFound(new APIResponse<SupplierDetailsDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = $"Supplier with Id {id} was not found."
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<SupplierDetailsDTO>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateSupplierDTO s)
        {
            try
            {
                int result = await _supplerService.Update(s);

                if (result > 0)
                {
                    return Ok(new APIResponse<UpdateSupplierDTO>
                    {
                        Data = s,
                        TotalCount = 1,
                        success = true,
                        Message = "Supplier updated successfully"
                    });
                }

                return BadRequest(new APIResponse<UpdateSupplierDTO>
                {
                    Data = s,
                    TotalCount = 0,
                    success = false,
                    Message = "Failed to update supplier"
                });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new APIResponse<UpdateSupplierDTO>
                {
                    Data = s,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<UpdateSupplierDTO>
                {
                    Data = s,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("byIds")]
        public async Task<IActionResult> GetSuppliersByIdsAsync([FromQuery] List<int> ids)
        {
            try
            {
                var result = await _supplerService.GetSuppliersByIdsAsync(ids);

                return Ok(new APIResponse<List<SupplierDetailsDTO>>
                {
                    Data = result,
                    TotalCount = result.Count,
                    success = true,
                    Message = "Suppliers retrieved successfully"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<List<SupplierDetailsDTO>>
                {
                    Data = null,
                    TotalCount = 0,
                    success = false,
                    Message = ex.Message
                });
            }
        }

        [HttpGet("basic/byIds")]
        public async Task<IActionResult> GetSuppliersByIdsBasicAsync([FromQuery] List<int> ids)
        {
            try
            {
                var result = await _supplerService.GetSuppliersByIdsBasicAsync(ids);
                return Ok(new APIResponse<List<SupplierBasicDetailsDTO>>
                {
                    Data = result,
                    TotalCount = result.Count,
                    success = true,
                    Message = "Suppliers retrieved successfully"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new APIResponse<List<SupplierBasicDetailsDTO>>
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
