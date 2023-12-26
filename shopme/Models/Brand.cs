using System.ComponentModel.DataAnnotations;

namespace shopme.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        public string Logo { get; set; }
        public string NameBrand { get; set; }
        public string Address {  get; set; }
        public int Phone {  get; set; }
        public string Email { get; set; }

        //Relationships
        public List<Product> Products { get; set; }
    }
}
