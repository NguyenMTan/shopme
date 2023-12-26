using shopme.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shopme.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ImageURL { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public ProductCategory ProductCategory { get; set; }

        //Relationships
        public List<Cart> Carts { get; set; }
        public List<Order_Details> Orders_Details { get; set; }

        //Brand
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]

        public Brand Brand { get; set; }
    }
}
