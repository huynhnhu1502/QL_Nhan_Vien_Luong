using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3Layer;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;
using _3Layer;
namespace Webform.Controllers
{
    public class HomeController : Controller
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_TinhLuong _biztinhluong = new _3Layer.BIZ.BIZ_TinhLuong();
        _3Layer.DAL.DAL_TinhLuong _daltinhluong = new _3Layer.DAL.DAL_TinhLuong();
        _3Layer.BIZ.BIZ_LichSuCongTac _bizLSct = new _3Layer.BIZ.BIZ_LichSuCongTac();
        _3Layer.BIZ.BIZ_DonVi _bizDonVi = new _3Layer.BIZ.BIZ_DonVi();
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
            return View(_bizDonVi.DSDonVi());
        }
        public ActionResult DanhSachNhanVienTrongDonVi(string MaDonVi)
        {
            return View(_bizDonVi.XuatDSNVTrongDonVi(MaDonVi));
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
        public ActionResult ThongKeLichSuCongTac(string HoTen)
        {
            List<NhanVien> list = _bizLSct.XuatThongKeLichSuCongTac(HoTen);
            return View(list);
        }
        public ActionResult ChiTietCongTac(string MaNV)
        {
            return View(_bizLSct.XuatChiTietCongTac(MaNV));
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
        public ActionResult TinhLuong(string Hoten)
        {
            return View(_biztinhluong.XuatTinhLuong(Hoten));
        }
        public ActionResult ThucHienTinhLuong(string MaNV)
        {
            List<NhanVien> list = _biztinhluong.XuatThucHienTinhLuong(MaNV);
            foreach (NhanVien nv in list)
            {
                ViewBag.TenDonVi = nv.DonVi.TenDonVi;
                ViewBag.TenChucVu = nv.ChucVu.TenChucVu;
                ViewBag.Ngach = nv.NgachLuong.TenNgach;
            }
            return View(_biztinhluong.XuatThucHienTinhLuong(MaNV));
        }
        [HttpPost]
        public ActionResult ThucHienTinhLuong(FormCollection fcl)
        {
            string MaNV = fcl["MaNV"];
            if (_biztinhluong.TinhLuong(MaNV) == true)
            {
                return RedirectToAction("TinhLuong");
            }
            return RedirectToAction("Contact");
        }
        public ActionResult ThongKeLuong()
        {
            return View(_daltinhluong.XuatThongKeLuongTheoDonVi());
        }
        public ActionResult ThucHienThongKeLuong(string MaDonVi, string thang, string nam)
        {
            return View(_biztinhluong.ThongKeLuong(MaDonVi, thang, nam));
        }
        public ActionResult ExportDataThongKeLuong(string MaDonVi, string thang, string nam)
        {
            if (thang == null && nam == null)
            {
                GridView gv = new GridView();
                var result111 = (from e in _db.NhanViens
                                 from o in _db.LuongThucTes
                                 where e.MaDonVi == MaDonVi && e.MaNV == o.MaNV
                                 select o).OrderByDescending(a => a.NgayLap);
                gv.DataSource = result111.ToList();
                gv.DataBind();
                Response.ClearContent();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment; filename=ThongKeLuong.xls");
                Response.ContentType = "application/ms-excel";
                Response.Charset = "";
                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                gv.RenderControl(htw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
            else
            {
                GridView gv = new GridView();
                int thang1 = int.Parse(thang);
                int nam1 = int.Parse(nam);
                var result111 = (from e in _db.NhanViens
                          from o in _db.LuongThucTes
                          where e.MaDonVi == MaDonVi && e.MaNV == o.MaNV && o.NgayLap.Month == thang1 && o.NgayLap.Year == nam1
                          select o).OrderByDescending(a => a.NgayLap).ToList();
                gv.DataSource = result111.ToList();
                gv.DataBind();
                Response.ClearContent();
                Response.Buffer = true;
                Response.AddHeader("content-disposition", "attachment; filename=ThongKeLuongThang.xls");
                Response.ContentType = "application/ms-excel";
                Response.Charset = "";
                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                gv.RenderControl(htw);
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }

            return RedirectToAction("ThongKeLuong");
        }
    }
}