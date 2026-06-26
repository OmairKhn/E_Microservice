using System.ComponentModel.DataAnnotations;

namespace Suppliers.Application.DTOs
{
    public class APIResponse<T>
    {
        internal bool success;

        public T? Data { get; set; }
        public int TotalCount { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; } = "";
    }

    public class AddSupplierDTO
    {
        [Required, StringLength(150)]
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string? Details { get; set; }
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Region { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";
    }

    public class UpdateSupplierDTO
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string? Details { get; set; }
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Region { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";
    }

    public class SupplierDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string? Details { get; set; }
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string Region { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";
    }

    public class SupplierBasicDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
    }
}
