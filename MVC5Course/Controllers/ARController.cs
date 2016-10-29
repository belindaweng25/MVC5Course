using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Notfound()
        {
            return View();
        }

        public  ActionResult ContentTest()
        {
            return Content("翁昉欣", "text/plain", System.Text.Encoding.UTF8);
        }

        public ActionResult FileTest()
        {
            var FilePath = Server.MapPath("~/Content/filetest.jpg");
            return File(FilePath, "image/jpeg");
        }

        public ActionResult FileTest2()
        {
            var FilePath = Server.MapPath("~/Content/filetest.jpg");
            return File(FilePath, "image/jpeg", "PPAP.jpg");
        }

        public ActionResult JsonTest()
        {
            //一定要加
            db.Configuration.LazyLoadingEnabled = false;

            var data = db.Product.OrderBy(p => p.ProductId).Take(10);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}