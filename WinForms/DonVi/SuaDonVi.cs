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
    public partial class SuaDonVi : Form
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_DonVi _bizdonvi = new _3Layer.BIZ.BIZ_DonVi();
        _3Layer.DonVi _donvi = new _3Layer.DonVi();

        public SuaDonVi()
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
                txtChucNang.Text = result.ChucNang;
                txtNhiemVu.Text = result.NhiemVu;
            }
        }
        public void loadcb()
        {
            List<_3Layer.LoaiDonVi> dsLDV = _bizdonvi.BIZLayLoai();
            cbloaidv.Items.Add("----Tất cả----");
            foreach (_3Layer.LoaiDonVi item in dsLDV)
            {
                cbloaidv.Items.Add(item);
            }
            //cbDonVi.DataSource = dsDV;
            cbloaidv.DisplayMember = "TenLoai";
            cbloaidv.ValueMember = "MaLoai";
            cbloaidv.SelectedIndex = 0;
        }
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SuaDonVi_Load(object sender, EventArgs e)
        {
            loadcb();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if(txtTenDV.Text != "" && txtSoDT.Text != "" && txtDiaChi.Text != ""  && cbloaidv.SelectedItem.ToString() != "----Tất cả----")
            {
                _3Layer.LoaiDonVi LDV = (_3Layer.LoaiDonVi)cbloaidv.SelectedItem;
                string maloai = LDV.MaLoai;
                _donvi.MaDonVi = txtMaDV.Text;
                _donvi.TenDonVi = txtTenDV.Text;
                _donvi.ChucNang = txtChucNang.Text;
                _donvi.DiaChi = txtDiaChi.Text;
                _donvi.DienThoai = txtSoDT.Text;
                _donvi.MaLoai = maloai;
                _donvi.NhiemVu = txtNhiemVu.Text;       

                if (_bizdonvi.SuaDonVi(_donvi) == true)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sửa !!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
