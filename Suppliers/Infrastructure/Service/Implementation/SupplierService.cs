using Suppliers.Application.DTOs;
using Suppliers.Infrastructure.Data.Model;
using Suppliers.Infrastructure.Repository.Interface;
using Suppliers.Infrastructure.Service.Interface;

namespace Suppliers.Infrastructure.Service.Implementation
{
    public class SupplierService : ISupplierService
    {

        private readonly ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }




        public async Task<int> Create(AddSupplierDTO s)
        {
            var supplier = new Supplier
            {
                Name = s.Name,
                Description = s.Description,
                Details = s.Details,
                Address = s.Address,
                City = s.City,
                Region = s.Region,
                PostalCode = s.PostalCode,
                Country = s.Country

            };
            return await _supplierRepository.Create(supplier);

        }

    

        public async Task<int> Delete(int id)
        {
            var supplier = await _supplierRepository.GetSupplierById(id);

            if (supplier == null)
            {
                throw new KeyNotFoundException($"Supplier with Id {id} was not found.");
            }

            return await _supplierRepository.Delete(supplier);
        }
        public async Task<List<SupplierDetailsDTO>> GetAllSuppliers()
        {
            var suppliers = await _supplierRepository.GetAllSuppliers();
            return  suppliers.Select(S => new SupplierDetailsDTO
            {
                Id = S.Id,
                Name = S.Name,
                Description = S.Description,
                Details = S.Details,
                Address = S.Address,
                City = S.City,
                Region = S.Region,
                PostalCode = S.PostalCode,
                Country = S.Country
            }).ToList();
        }

        public async Task<List<SupplierBasicDetailsDTO>> GetAllSuppliersBasic()
        {
            var suppliers = await _supplierRepository.GetAllSuppliersBasic();

            return suppliers.Select(s => new SupplierBasicDetailsDTO
            {
                Id = s.Id,
                Name = s.Name
            }).ToList();
        }

        public async  Task<SupplierDetailsDTO?> GetSupplierById(int id)
        {
           var suplier = await _supplierRepository.GetSupplierById(id);
            if (suplier == null)
            {
                return null;
            }
            var SuplierDto = new SupplierDetailsDTO
            {
                Id = suplier.Id,
                Name = suplier.Name,
                Description = suplier.Description,
                Details = suplier.Details,
                Address = suplier.Address,
                City = suplier.City,
                Region = suplier.Region,
                PostalCode = suplier.PostalCode,
                Country = suplier.Country
            };
            return SuplierDto;

        }

        public async Task<int> Update(UpdateSupplierDTO s)
        {
            var  supplier = await _supplierRepository.GetSupplierById(s.Id);
          if (supplier== null)
            {
                throw new KeyNotFoundException($"Supplier with Id {s.Id} was not found.");
            }
            supplier.Name = s.Name;
            supplier.Description = s.Description;
            supplier.Details = s.Details;
            supplier.Address = s.Address;
            supplier.City = s.City;
            supplier.Region = s.Region;
            supplier.PostalCode = s.PostalCode;
            supplier.Country = s.Country;

            return await _supplierRepository.Update(supplier);
         }

        public async Task<List<SupplierDetailsDTO>> GetSuppliersByIdsAsync(IEnumerable<int> ids)
        {   
            var suppliers = await _supplierRepository.GetSuppliersByIdsAsync(ids);
            return suppliers.Select(s => new SupplierDetailsDTO
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Details = s.Details,
                Address = s.Address,
                City = s.City,
                Region = s.Region,
                PostalCode = s.PostalCode,
                Country = s.Country
            }).ToList();
        }

        public async Task<List<SupplierBasicDetailsDTO>> GetSuppliersByIdsBasicAsync(IEnumerable<int> ids)
        {
            var suppliers = await _supplierRepository.GetSuppliersByIdsBasicAsync(ids);
            return suppliers.Select(s => new SupplierBasicDetailsDTO
            {
                Id = s.Id,
                Name = s.Name
            }).ToList();
        }


    }
}
