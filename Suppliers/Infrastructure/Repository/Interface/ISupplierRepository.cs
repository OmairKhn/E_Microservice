using Suppliers.Infrastructure.Data.Model;

namespace Suppliers.Infrastructure.Repository.Interface
{
    public interface ISupplierRepository
    {
        Task<int> Create(Supplier s);
        Task<int> Update(Supplier s);
        Task<int> Delete(Supplier s);
        Task<List<Supplier>> GetAllSuppliersBasic();
        Task<List<Supplier>> GetAllSuppliers();
        Task<Supplier?> GetSupplierById(int id);

        Task<List<Supplier>> GetSuppliersByIdsAsync(IEnumerable<int> ids);
        Task<List<Supplier>> GetSuppliersByIdsBasicAsync(IEnumerable<int> ids);
    }
}
