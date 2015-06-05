using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Information about Mesrure Betül Kaplan.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "MBK's contact page.";

            return View();
        }

         [Authorize]
        public ActionResult Upload()
        {
            return View();
        }
       

         [HttpPost]
         [Authorize]
        public virtual ActionResult Upload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                
                var fileName = Path.GetFileName(file.FileName);
                
                var path = Path.Combine(Server.MapPath("~/Image"), fileName);

                file.SaveAs(path);
            }

            // redirect back to the index action to show the form once again
            return RedirectToAction("Upload","Home");
        }
    }
}