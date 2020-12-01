using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageFileUpload.Models;

namespace ImageFileUpload.Controllers
{
    
    public class EmpInfoController : Controller
    {
        ImageUploadEntities db = new ImageUploadEntities();
        // GET: EmpInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddInfo()
        {
            return View();
        }

        public ActionResult GetInfo() // get info with storeprocedure
        {
            SqlParameter[] paramitar = new SqlParameter[] {
            new SqlParameter("@id",1),
            };
            var data = db.Database.SqlQuery<EmployeeInfo>("Getinfo @id", paramitar).ToList();
            return View(data);
        }
    }
}