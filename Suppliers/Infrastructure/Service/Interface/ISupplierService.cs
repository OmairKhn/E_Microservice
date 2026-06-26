using Suppliers.Application.DTOs;
using Suppliers.Infrastructure.Data.Model;

namespace Suppliers.Infrastructure.Service.Interface
{
    public interface ISupplierService
    {
        Task<int> Create(AddSupplierDTO s);
        Task<int> Update(UpdateSupplierDTO s);
        Task<int> Delete(int id);
        Task<List<SupplierBasicDetailsDTO>> GetAllSuppliersBasic();
        Task<List<SupplierDetailsDTO>> GetAllSuppliers();
        Task<SupplierDetailsDTO?> GetSupplierById(int id);

        Task<List<SupplierDetailsDTO>> GetSuppliersByIdsAsync(IEnumerable<int> ids);
        Task<List<SupplierBasicDetailsDTO>> GetSuppliersByIdsBasicAsync(IEnumerable<int> ids);

    }
}
