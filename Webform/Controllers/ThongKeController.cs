using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3Layer;
using _3Layer.BIZ;
using PagedList;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;

namespace Webform.Controllers
{
    public class ThongKeController : Controller
    {
        BIZ_NV bizNV = new BIZ_NV();
        List<NhanVien> list;
        // GET: ThongKe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VeHuu(int? page)
        {
            //List<NhanVien> list = bizNV.BIZ_LayDuLieuNV();
            list = bizNV.BIZ_LayDuLieuNV();
            TempData["list"] = list;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(list.ToPagedList(pageNumber, pageSize));
        }

        [HttpPost]
        public ActionResult VeHuu(int? page, string from, string to)
        {
            
            list = bizNV.BIZ_ThongKeNhanVienVeHuu(from, to);
            TempData["list"] = list;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(list.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult ExportToExcel()
        {
            try
            {
                list = (List<NhanVien>)TempData["list"];
                if (list != null)
                {
                    GridView gv = new GridView();
                    gv.DataSource = list;
                    gv.DataBind();
                    Response.ClearContent();
                    Response.Buffer = true;
                    Response.AddHeader("content-disposition", "attachment; filename=DanhSachNhanVienVeHuu.xls");
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
                    return Content("<script language='javascript' type='text/javascript'>alert('Không thể xuất file excel');");
                }

                return RedirectToAction("VeHuu");
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
