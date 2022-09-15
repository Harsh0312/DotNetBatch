using LaptopJunction.Data;
using LaptopJunction.Controllers;
using Microsoft.AspNetCore.Mvc;
using LaptopJunction.Models;

namespace LaptopJunction.Controllers
{
    public class LaptopController:Controller

    {
        private readonly ApplicationDbContext _db;
        public LaptopController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Laptop()
        {
            IEnumerable<Laptop> objLaptopList = _db.Laptops.ToList();
            return View(objLaptopList);
        }
       
    }
}
