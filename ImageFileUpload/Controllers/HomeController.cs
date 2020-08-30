using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageFileUpload.Models;

namespace ImageFileUpload.Controllers
{
    public class HomeController : Controller
    {
      ImageUploadEntities db = new ImageUploadEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult ImageUpload(Image image)
        {
            return View();
        }

        [HttpPost]
        public ActionResult ImageUpload(Image image, HttpPostedFileBase filename)
        {
            Image image1 = new Image();
            string path = UploadImage(filename);
            if (path.Equals("-1"))
            {
                return View(image);
            }
            else
            {
            
                image1.ImageName = path;
                image1.MakeDate = System.DateTime.Now;
                db.Images.Add(image1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public string UploadImage(HttpPostedFileBase file)
        {
            Random ran = new Random();
            string path = "-1";
            int random = ran.Next();
            if(file!=null && file.ContentLength > 0)
            {
                string extention = Path.GetExtension(file.FileName);
                if (extention.ToLower().Equals(".jpg")|| extention.ToUpper().Equals(".JPG")|| extention.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload/"),random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path ="~/Content/upload/" + random + Path.GetFileName(file.FileName);
                    }
                    catch(Exception ex)
                    {
                        path = "-1";
                    }

                }
                else
                {
                    Response.Write("<script>alrt('Only jpg or JPG or png formate'); <script>");
                }

            }
            else
            {
                Response.Write("<script>alrt('Please select file ..'); <script>");
                path = "-1";

            }


            return path;
        }

        public ActionResult ViewImage()
        {
            return View(db.Images.ToList());
        }
    }
}