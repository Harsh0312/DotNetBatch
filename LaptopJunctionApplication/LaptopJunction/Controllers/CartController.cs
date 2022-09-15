using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LaptopJunction.Migrations;
using LaptopJunction.Models;
using LaptopJunction.Controllers;
using LaptopJunction.Data;

namespace LaptopJunction.Controllers
{
    public class CartController : Controller
    {
        //List<Cart> li = new List<Cart>();
        //private readonly ApplicationDbContext _db;
        //public CartController(ApplicationDbContext db)
        //{
        //    _db = db;
        //}
        //[HttpGet]
        //public ActionResult AddtoCart(int id)
        //{
        //    //IEnumerable<Laptop> objLaptopList = _db.Laptops.ToList();
        //    var query = _db.Laptops.Where(x => x.Id == id).SingleOrDefault();
        //    return View(query);
        //}
        //[HttpPost]
        //public ActionResult AddtoCart(int id,int qty)
        //{
        //    Laptop l=_db.Laptops.Where(x => x.Id == id).SingleOrDefault();
        //    Cart c = new Cart();
        //    c.lid = id;
        //    c.lprice =l.price;
        //    c.lname = l.LaptopName;
        //    c.qty = qty;
        //    c.total = c.lprice * c.qty;
        //    if (TempData["cart"]==null)
        //    {
        //        li.Add(c);
        //        TempData["cart"] = li;
        //    }
        //    else
        //    {
        //        List<Cart> li2 = TempData["cart"] as List<Cart>;
        //        int flag = 0;
        //        foreach (var item in li2)
        //        {
        //            if (item.lid == c.lid)
        //            {
        //                item.qty += c.qty;
        //                item.total += c.total;
        //                flag = 1;
        //            }

        //        }
        //        if (flag == 0)
        //        {
        //            li2.Add(c);
        //            //new item
        //        }
        //        TempData["cart"] = li2;

        //    }

        //    TempData.Keep();

        //    return RedirectToAction("Home/Index");
        //}

        //public ActionResult ViewCart()
        //{
        //    TempData.Keep();
        //    return View();
        //}

    }
       
    }

