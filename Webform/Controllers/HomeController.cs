using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3Layer;

namespace Webform.Controllers
{
    public class HomeController : Controller
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
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
        public ActionResult ThongKeNhanVienTrongDonVi()
        {
            var result = (from u in _db.DonVis select u).ToList();
            return View(result);
        }
        public ActionResult DanhSachNhanVienTrongDonVi(string MaDonVi)
        {
            var result = (from u in _db.NhanViens where u.MaDonVi == MaDonVi select u).ToList();
            return View(result);
        }
    }
}