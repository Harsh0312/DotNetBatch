using System.ComponentModel.DataAnnotations;

namespace LaptopJunction.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LaptopName { get; set; }
        [Required]
        public int price { get; set;}
        public string description { get; set; }
        public string path { get; set; }
    }
  

}
