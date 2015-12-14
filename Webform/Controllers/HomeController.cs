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
            gv.DataSource = _bizDonVi.ExportDataNVTrongDV(maDonVi);
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
            gv.DataSource = _bizLSct.XuatChiTietCongTac(maNhanVien);
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
                GridView gv = new GridView();
                gv.DataSource = _biztinhluong.ThongKeLuong(MaDonVi, thang, nam);
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

            return RedirectToAction("ThongKeLuong");
        }

        public ActionResult XemLuongThang(string MaNV)
        {
            return View(_biztinhluong.XuatLuongThang(MaNV));
        }
    }
}