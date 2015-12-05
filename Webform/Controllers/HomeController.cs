using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3Layer;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;

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
        public ActionResult ExportDataNVTrongDV(string maDonVi)
        {
            
            GridView gv = new GridView();
            var result111 = (from u in _db.NhanViens
                             from e in _db.ChucVus
                             where u.MaDonVi == maDonVi && u.MaChucVu == e.MaChucVu
                             select new {u.MaNV,u.HoTen,e.TenChucVu,u.NgaySinh,u.DanToc,u.GioiTinh,u.CMND,u.DiaChi});
            gv.DataSource = result111.ToList();
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=danhSachNVTrongDV.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            gv.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();

            return RedirectToAction("ThongKeNhanVienTrongDonVi");
        }
        public ActionResult ThongKeLichSuCongTac()
        {
            var nhanvien = (from u in _db.NhanViens select u).ToList();
            return View(nhanvien);
        }
        public ActionResult ChiTietCongTac(string MaNV)
        {
            var congtac = (from u in _db.LichSuCongTacs where u.MaNV.Equals(MaNV) select u).ToList();
            return View(congtac);
        }
        public ActionResult ExportDataLichSuCongTac(string maNhanVien)
        {

            GridView gv = new GridView();
            var result111 = (from u in _db.LichSuCongTacs
                             from q in _db.DonVis
                             from t in _db.ChucVus
                             from p in _db.NgachLuongs
                             from m in _db.NhanViens
                             where u.MaNV == maNhanVien && u.MaDonVi == q.MaDonVi && u.MaChucVu == t.MaChucVu && u.MaNgach == p.MaNgach && u.MaNV == m.MaNV
                             select new { u.MaCongTac, m.HoTen, q.TenDonVi, t.TenChucVu, p.TenNgach, u.NgayLam, u.NgayChuyen });
            gv.DataSource = result111.ToList();
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=LichSuCongTac.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            gv.RenderControl(htw);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();

            return RedirectToAction("ThongKeNhanVienTrongDonVi");
        }
    }
}