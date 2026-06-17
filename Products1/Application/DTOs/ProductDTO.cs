using System.ComponentModel.DataAnnotations;

namespace Products1.Application.DTOs
{
<<<<<<< HEAD
   public class APIResponse<T>
    {
        public T? Data { get; set; }
        public int TotalCount { get; set; }
        public bool success { get; set; }

        public string Message { get; set; } = "";


    }
    public class AddProductDTO
=======
   
        public class AddProductDTO
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
        {
            public string Name { get; set; } = "";
            public string Brand { get; set; } = "";
            public string Model { get; set; } = "";
            public string Description { get; set; } = "";
            public string Specifications { get; set; } = "";

            
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

<<<<<<< HEAD
 
=======
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
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
<<<<<<< HEAD

      
    }

    public class ProductShortDetaisDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
=======
>>>>>>> 6f049bb (Add .gitignore and remove generated files)
    }
    public class DelteProductDTO
        {
            public int Id { get; set; }
        }

    }

