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
    public partial class SuaLoaiDV : Form
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_LoaiDonVi _bizloaidv = new _3Layer.BIZ.BIZ_LoaiDonVi();
        _3Layer.LoaiDonVi _loaidv = new _3Layer.LoaiDonVi();
        public SuaLoaiDV(string data1)
        {
            InitializeComponent();
            lbErr.Visible = false;
            var result = _db.LoaiDonVis.FirstOrDefault(a => a.MaLoai == data1);
            if (result != null)
            {
                txtMaLoai.Text = data1;
                txtTenLoai.Text = result.TenLoai;
                txtMoTa.Text = result.MoTa;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (txtTenLoai.Text == "" )
            {
                lbErr.Visible = true;
                lbErr.Text = "Điền đầy đủ thông tin";
                flag = false;
            }
            _loaidv.MaLoai = txtMaLoai.Text.Trim();
            _loaidv.TenLoai = txtTenLoai.Text.Trim();
            _loaidv.MoTa = txtMoTa.Text.Trim();
            if (flag)
            {
                if (_bizloaidv.SuaLoai(_loaidv) == true)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTenLoai.Text = "";
            txtMoTa.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
