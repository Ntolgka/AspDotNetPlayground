using AspDotNetPlayground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetPlayground.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult CategoryMenu()
        {
            List<Category> categories = new List<Category>()
            {
                new Category() {CategoryId=1, CategoryName="Mobile Phone"},
                new Category() {CategoryId=2, CategoryName="Laptop"},
                new Category() {CategoryId=3, CategoryName="TV"}
            };

            return PartialView("CategoryMenu", categories);
        }
    }
}