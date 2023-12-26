using System.ComponentModel.DataAnnotations;

namespace shopme.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        //relationships
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
    }
}
