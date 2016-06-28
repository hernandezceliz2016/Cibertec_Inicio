using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: Razor
        [Route]
        public ActionResult Index()
        {
            var clients = new List<Client>
           {
               new Client {ID =1,LastName ="Perez Rodas", Name ="Jose Luis" ,DateCreation=DateTime.Now},
               new Client {ID =2,LastName ="Perez Alcantara", Name ="Raul" },
               new Client {ID =3,LastName ="Perez Montenegro", Name ="Luis Alberto" ,DateCreation=DateTime.Now},
               new Client {ID =4,LastName ="Perez Hernandez", Name ="Patricia" },
               new Client {ID =5,LastName ="Perez Maytha", Name ="Tania",DateCreation=DateTime.Now }
           };

            return View(clients);
        }

        public ActionResult Product()
        {
            var productData = new ProductData();
            return View(productData.GetFakeProducts());
        }
        [Route("Entry/{date:DateTime}")]
        public ActionResult EntryDate(DateTime date)
        {
           ViewBag.Date = date.ToShortDateString();
            return View();
        }
        [Route("Entry/{id:int}")]
        public string EntryId(int Id)
        {
            return Id.ToString();
        }
    }
}