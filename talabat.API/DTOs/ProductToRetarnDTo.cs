using talabat.DAL.Entities;

namespace talabat.API.DTOs
{
    //data trensfer Object
    public class ProductToRetarnDTo
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public string pictureurl { get; set; }
        public string productBrand { get; set; }
        public int productBrandId { get; set; }
        public string producttype { get; set; }
        public int producttypeid { get; set; }

    }
}
