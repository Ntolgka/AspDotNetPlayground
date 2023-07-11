using AspDotNetPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetPlayground.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ItemAndCategory model = new ItemAndCategory();
            model.ItemCount = Data.List.Where(i => i.IsOnSale == true).Count();
            model.Items = Data.List.Where(i => i.IsOnSale == true).ToList();

            //ViewBag.ItemCount = items.Count()
            //ViewBag.Category = Categories;

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var item = Data.List.Where(i => i.ItemId == id).FirstOrDefault();

            return View(item);
        }

        [HttpGet]
        public ActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItem(Item entity)
        {
            Data.AddItem(entity);

            return View("ItemList", Data.List);
        }
    }
}