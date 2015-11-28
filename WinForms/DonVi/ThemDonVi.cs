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
    public partial class ThemDonVi : Form
    {
        QuanLyLuongEntities1 db = new QuanLyLuongEntities1();
        _3Layer.BIZ.BIZ_DonVi _bizdonvi = new _3Layer.BIZ.BIZ_DonVi();
        _3Layer.DonVi _donvi = new _3Layer.DonVi();
        public ThemDonVi()
        {
            InitializeComponent();
            autoMaDV();
            loadcb();
            lbErr.Visible = false;
        }
        public void autoMaDV()
        {
            int idhientai;
            int countid = (from u in db.DonVis select new { u.id }).Count();
            if (countid == 0)
            {
                idhientai = 0;
                int idthemvao = idhientai + 1;
                txtMaDV.Text = "DV00" + idthemvao;
                
            }
            else
            {
                idhientai = db.DonVis.Max(a => a.id);
                int idthemvao = idhientai + 1;
                txtMaDV.Text = "DV00" + idthemvao;
            }
        }
        public void loadcb(){
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; 
            var result = (from u in db.LoaiDonVis select u).ToList();
            comboBox1.DataSource = result;
            comboBox1.ValueMember = "MaLoai";
            comboBox1.DisplayMember = "TenLoai";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            _donvi.MaDonVi = txtMaDV.Text.Trim();
            _donvi.TenDonVi = txtTenDV.Text.Trim();
            _donvi.MaLoai = comboBox1.SelectedValue.ToString();
            _donvi.DienThoai = txtSoDT.Text.Trim();
            _donvi.DiaChi = txtDiaChi.Text.Trim();
            _donvi.NamThanhLap = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            _donvi.ChucNang = txtChucNang.Text.Trim();
            _donvi.NhiemVu = txtNhiemVu.Text.Trim();
            if (_donvi.TenDonVi == "" || _donvi.MaLoai == "" || _donvi.DienThoai == "" || _donvi.DiaChi == "" || _donvi.ChucNang == "" || _donvi.NhiemVu == "")
            {
                flag = false;
                lbErr.Visible = true;
                lbErr.Text = "Nhập đầy đủ thông tin";
            }
            if (flag)
            {
                lbErr.Visible = false;
                if (_bizdonvi.themDonVi(_donvi) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtTenDV.Text = "";
            txtDiaChi.Text = "";
            txtSoDT.Text = "";
            txtChucNang.Text = "";
            txtNhiemVu.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            DonVi dv = new DonVi();
            dv.Show();
        }
    }
}
