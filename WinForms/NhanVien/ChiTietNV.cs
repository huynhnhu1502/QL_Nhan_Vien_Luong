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
        QuanLyLuongEntities1 db = new QuanLyLuongEntities1();
        public ChiTietNV(string data1, string data2)
        {
            InitializeComponent();
            var search = db.NhanViens.FirstOrDefault(a => a.MaNV.Equals(data1) && a.HoTen.Equals(data2));
            if (search != null)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                label13.Text = search.HoTen;
                lbMaNV.Text = search.MaNV;
                lbMaDonVi.Text = search.MaDonVi;
                lbMaChucVu.Text = search.MaChucVu;
                lbDC.Text = search.DiaChi;
                lbDT.Text = search.DanToc;
                lbGT.Text = search.GioiTinh;
                lbHoTen.Text = search.HoTen;
                lbNgayBD.Text = search.NgayBatDau.ToShortDateString();
                lbNgayNghi.Text = search.NgayNghi.ToString();
                lbNgayHuu.Text = search.NgayHuu.ToString();
                lbNgaySinh.Text = search.NgaySinh.ToShortDateString();
                pictureBox1.Image = Image.FromFile(@"~/Image/"+search.HinhAnh);
            }
        }

        private void ChiTietNV_Load(object sender, EventArgs e, NhanVien nv)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
