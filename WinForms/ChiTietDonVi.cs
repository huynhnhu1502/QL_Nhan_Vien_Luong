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
    public partial class ChiTietDonVi : Form
    {
        QuanLyLuongEntities1 db = new QuanLyLuongEntities1();
        public ChiTietDonVi(string data1)
        {
            InitializeComponent();
            var result = db.DonVis.FirstOrDefault(a => a.MaDonVi == data1);
            if (result != null)
            {
                label10.Text = result.TenDonVi;
                txtMaDV.Text = result.MaDonVi;
                txtTenDV.Text = result.TenDonVi;
                txtDiaChi.Text = result.DiaChi;
                txtSoDT.Text = result.DienThoai;
                var result1 = db.LoaiDonVis.FirstOrDefault(a => a.MaLoai == result.MaLoai);
                if (result1 != null)
                {
                    txtLoaiDV.Text = result1.TenLoai;
                }
                txtnamThanhLap.Text = result.NamThanhLap.ToShortDateString();
                txtChucNang.Text = result.ChucNang;
                txtNhiemVu.Text = result.NhiemVu;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DonVi dv = new DonVi();
            dv.Show();
        }
    }
}
