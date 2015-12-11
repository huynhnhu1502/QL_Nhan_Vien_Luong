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
                             select new { u.MaNV, u.HoTen, e.TenChucVu, u.NgaySinh, u.DanToc, u.GioiTinh, u.CMND, u.DiaChi });
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
            var nhanvien = (from u in _db.NhanViens select u);
            if (!String.IsNullOrEmpty(HoTen))
            {
                nhanvien = nhanvien.Where(c => c.HoTen.Contains(HoTen));
            }
            return View(nhanvien);
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
        public ActionResult TinhLuong(string Hoten)
        {
            var nhanvien = (from u in _db.NhanViens
                            select u);
            if (!String.IsNullOrEmpty(Hoten))
            {
                nhanvien = _db.NhanViens.Where(a => a.HoTen.Contains(Hoten));
            }
            return View(nhanvien);
        }
        public ActionResult ThucHienTinhLuong(string MaNV)
        {
            var nhanvien = (from u in _db.NhanViens
                            where u.MaNV.Equals(MaNV)
                            select u).ToList();
            return View(nhanvien);
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
            var result = (from u in _db.DonVis select u).ToList();
            return View(result);
        }
        public ActionResult ThucHienThongKeLuong(string MaDonVi, string thang, string nam)
        {
            var result = (from e in _db.NhanViens
                          from o in _db.LuongThucTes
                          where e.MaDonVi == MaDonVi && e.MaNV == o.MaNV
                          select o).OrderByDescending(a => a.NgayLap).ToList();
            if (!String.IsNullOrEmpty(thang) && !String.IsNullOrEmpty(nam))
            {
                int thang1 = int.Parse(thang);
                int nam1 = int.Parse(nam);
                result = (from e in _db.NhanViens
                          from o in _db.LuongThucTes
                          where e.MaDonVi == MaDonVi && e.MaNV == o.MaNV && o.NgayLap.Month == thang1 && o.NgayLap.Year == nam1
                          select o).OrderByDescending(a => a.NgayLap).ToList();
                if (result == null)
                {
                    Response.Write("Không tìm thấy");
                }
            }
            return View(result);
        }
    }
}