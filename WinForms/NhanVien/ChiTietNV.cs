using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Layer;

namespace WinForms
{
    public partial class ChiTietNV : Form
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        public ChiTietNV(string data1, string data2)
        {
            InitializeComponent();
            var search = db.NhanViens.FirstOrDefault(a => a.MaNV.Equals(data1) && a.HoTen.Equals(data2));
            if (search != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                label13.Text = search.HoTen;
                lbMaNV.Text = search.MaNV;
                var donvi = db.DonVis.First(a => a.MaDonVi == search.MaDonVi);
                lbMaDonVi.Text = donvi.TenDonVi;
                var chucvu = db.ChucVus.First(a => a.MaChucVu == search.MaChucVu);
                lbMaChucVu.Text = chucvu.TenChucVu;
                var ngach = db.NgachLuongs.FirstOrDefault(a => a.MaNgach == search.MaNgach);
                label14.Text = ngach.TenNgach;
                lbDC.Text = search.DiaChi;
                lbDT.Text = search.DanToc;
                lbGT.Text = search.GioiTinh;
                lbHoTen.Text = search.HoTen;
                lbNgayBD.Text = search.NgayBatDau.ToShortDateString();
                lbNgayNghi.Text = search.NgayNghi.ToString();
                lbNgayHuu.Text = search.NgayHuu.ToString();
                lbNgaySinh.Text = search.NgaySinh.ToShortDateString();
                //pictureBox1.Image = Image.FromFile(@"../../../Webform/Images/" + search.HinhAnh);
            }
        }

        private void ChiTietNV_Load(object sender, EventArgs e, frm_NhanVien nv)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
