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
using _3Layer.BIZ;
using System.IO;

namespace WinForms
{
    public partial class ChiTietNV : Form
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        BIZ_NV bizNV = new BIZ_NV();
        public ChiTietNV(string maNV)
        {
            InitializeComponent();
            //var search = db.NhanViens.FirstOrDefault(a => a.MaNV.Equals(data1));
            try
            {
                _3Layer.NhanVien nVien = bizNV.BIZ_TimNhanVienTheoMa(maNV);
                OpenFileDialog ofd = new OpenFileDialog();
                label13.Text = nVien.HoTen;
                lbMaNV.Text = nVien.MaNV;
                //var donvi = db.DonVis.First(a => a.MaDonVi == search.MaDonVi);
                if(nVien.DonVi != null)
                {
                    lbMaDonVi.Text = nVien.DonVi.TenDonVi;
                }
                //var chucvu = db.ChucVus.First(a => a.MaChucVu == search.MaChucVu);
                if(nVien.ChucVu != null)
                {
                    lbMaChucVu.Text = nVien.ChucVu.TenChucVu;
                }
                //var ngach = db.NgachLuongs.FirstOrDefault(a => a.MaNgach == search.MaNgach);
                if(nVien.HeSoLuongPhuCap != null)
                {
                    lbTenHeSo.Text = nVien.HeSoLuongPhuCap.TenHeSo + " - ";
                    label16.Text = nVien.HeSoLuongPhuCap.HeSo.ToString();
                }
                label14.Text = nVien.NgachLuong.TenNgach;
                lbDC.Text = nVien.DiaChi;
                lbDT.Text = nVien.DanToc;
                lbGT.Text = nVien.GioiTinh;
                lbHoTen.Text = nVien.HoTen;
                if(nVien.NgayBatDau != null)
                {
                    lbNgayBD.Text = nVien.NgayBatDau.ToString();
                }
                if(nVien.NgayNghi != null)
                {
                    lbNgayNghi.Text = nVien.NgayNghi.ToString();
                }
                if(nVien.NgayHuu != null)
                {
                    lbNgayHuu.Text = nVien.NgayHuu.ToString();
                }
                
                lbNgaySinh.Text = nVien.NgaySinh.ToShortDateString();
                lbCMND.Text = nVien.CMND.ToString();
                if (File.Exists(@"../../../Webform/Images/" + nVien.HinhAnh))
                    pictureBox1.Image = Image.FromFile(@"../../../Webform/Images/" + nVien.HinhAnh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bị lỗi lấy dữ liệu");

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
