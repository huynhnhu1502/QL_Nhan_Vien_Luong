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
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        public ChiTietDonVi()
        {
            InitializeComponent();
        }
        public void Laydulieu(TextBox txtmadonvi)
        {
            txtMaDV.Text = txtmadonvi.Text;
            var result = db.DonVis.FirstOrDefault(a => a.MaDonVi == txtMaDV.Text);
            if (result != null)
            {
                label10.Text = result.TenDonVi;
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
        }


    }
}
