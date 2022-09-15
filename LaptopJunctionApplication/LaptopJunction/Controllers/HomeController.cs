using LaptopJunction.Data;
using LaptopJunction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
namespace LaptopJunction.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
        
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Login()
        {

            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        List<Cart> li = new List<Cart>();
        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Laptop()
        {
            IEnumerable<Laptop> objLaptopList = _db.Laptops.ToList();
            return View(objLaptopList);
        }
        [HttpGet]
        public ActionResult AddtoCart(int id)
        {
            //IEnumerable<Laptop> objLaptopList = _db.Laptops.ToList();
            var query = _db.Laptops.Where(x => x.Id == id).SingleOrDefault();
            return View(query);
        }
        [HttpPost]
        public ActionResult AddtoCart(int id, int qty)
        {
            Laptop l = _db.Laptops.Where(x => x.Id == id).SingleOrDefault();
            Cart c = new Cart();
            c.lid = id;
            c.lprice = l.price;
            c.lname = l.LaptopName;
            c.qty = qty;
            c.total = c.lprice * c.qty;
            if (TempData["cart"] == null)
            {
                li.Add(c);
                TempData["cart"] = li;
            }
            //else
            //{
            //    List<Cart> li2 = TempData["cart"] as List<Cart>;
            //    int flag = 0;
            //    foreach (var item in li2)
            //    {
            //        if (item.lid == c.lid)
            //        {
            //            item.qty += c.qty;
            //            item.total += c.total;
            //            flag = 1;
            //        }

            //    }
            //    if (flag == 0)
            //    {
            //        li2.Add(c);
            //        //new item
            //    }
            //    TempData["cart"] = li2;

            //}

            TempData.Keep();

            return View("ViewCart");
        }
        public IActionResult ViewCart()
        {
            TempData.Keep();
            return View();
        }
    }
}