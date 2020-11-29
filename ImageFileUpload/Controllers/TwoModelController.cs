using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageFileUpload.Models;


namespace ImageFileUpload.Controllers
{
    public class TwoModelController : Controller
    {
        // GET: TwoModel
        public ActionResult Index()
        {
            List<ModelA> listA = new List<ModelA>();
            List<ModelB> listB = new List<ModelB>();
            listA.Add(new ModelA { Name="Shuvo"});
            listA.Add(new ModelA { Name = "Roy" });
            listA.Add(new ModelA { Name = "Hridoy" });

            listB.Add(new ModelB { City = "Dhaka" });
            listB.Add(new ModelB { City = "Rangpur" });
            listB.Add(new ModelB { City = "Dhaka" });

            ModelC finalItem = new ModelC();
            finalItem.ListA = listA;
            finalItem.ListB = listB;
            finalItem.age = 28;
            return View(finalItem);
        }
    }
}