using System.ComponentModel.DataAnnotations;

namespace Products1.Infrastucture.Data.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(100)]
        public required string Name { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }

        public required string Description { get; set; }
        public required string Specifications { get; set; }


        
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }


        internal static bool Any()
        {
            throw new NotImplementedException();
        }




    }
}
