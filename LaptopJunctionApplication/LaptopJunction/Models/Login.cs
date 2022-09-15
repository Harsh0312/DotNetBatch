using Microsoft.Build.Framework;

namespace LaptopJunction.Models
{
    public class Login
    {
       
       [Required]
        public string userName { get; set;}
        [Required]
        public string password { get; set; }
    }
}
