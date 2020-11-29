using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageFileUpload.Controllers
{
    public class EmpInfoController : Controller
    {
        // GET: EmpInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddInfo()
        {
            return View();
        }
    }
}