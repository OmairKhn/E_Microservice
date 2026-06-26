using System.ComponentModel.DataAnnotations;

namespace Suppliers.Infrastructure.Data.Model
{
    public class Supplier
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
}
