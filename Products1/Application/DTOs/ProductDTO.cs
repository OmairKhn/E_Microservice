using System.ComponentModel.DataAnnotations;

namespace Products1.Application.DTOs
{
   public class APIResponse<T>
    {
        public T? Data { get; set; }
        public int TotalCount { get; set; }
        public bool success { get; set; }

        public string Message { get; set; } = "";


    }
    public class AddProductDTO
        {
            public string Name { get; set; } = "";
            public string Brand { get; set; } = "";
            public string Model { get; set; } = "";
            public string Description { get; set; } = "";
            public string Specifications { get; set; } = "";

            
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

 
    }

    public class UpdateProductDTO
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public string Brand { get; set; } = "";
            public string Model { get; set; } = "";
            public string Description { get; set; } = "";
            public string Specifications { get; set; } = "";

            [Range(0, double.MaxValue)]
   
        public decimal Price { get; set; }
    }

    public  class ProductDTO
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public string Brand { get; set; } = "";
            public string Model { get; set; } = "";
            public string Description { get; set; } = "";
            public string Specifications { get; set; } = "";

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

      
    }

    public class ProductShortDetaisDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
    public class DelteProductDTO
        {
            public int Id { get; set; }
        }

    }

