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
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_DonVi _bizdonvi = new _3Layer.BIZ.BIZ_DonVi();
        _3Layer.DonVi _donvi = new _3Layer.DonVi();
        public ThemDonVi()
        {
            InitializeComponent();
            autoMaDV();
            loadcb();
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
                int idthemvao = countid + 1;
                if (idthemvao < 10)
                    txtMaDV.Text = "DV00" + idthemvao;
                else if (idthemvao >= 10 && countid < 100)
                    txtMaDV.Text = "DV0" + idthemvao;
                else if (idthemvao >= 100)
                    txtMaDV.Text = "DV" + idthemvao;
            }
            
       
        }

        public void loadcb()
        {
            List<_3Layer.LoaiDonVi> dsLDV = _bizdonvi.BIZLayLoai();
            comboBox1.Items.Add("----Tất cả----");
            foreach (_3Layer.LoaiDonVi item in dsLDV)
            {
                comboBox1.Items.Add(item);
            }
            //cbDonVi.DataSource = dsDV;
            comboBox1.DisplayMember = "TenLoai";
            comboBox1.ValueMember = "MaLoai";
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtTenDV.Text != "" && txtSoDT.Text != "" && txtDiaChi.Text != "" && comboBox1.SelectedItem.ToString() != "----Tất cả----")
            {
                _3Layer.LoaiDonVi LDV = (_3Layer.LoaiDonVi)comboBox1.SelectedItem;
                string maloai = LDV.MaLoai;
                _donvi.MaDonVi = txtMaDV.Text.Trim();
                _donvi.TenDonVi = txtTenDV.Text.Trim();
                _donvi.MaLoai = maloai;
                _donvi.DienThoai = txtSoDT.Text.Trim();
                _donvi.DiaChi = txtDiaChi.Text.Trim();
                _donvi.NamThanhLap = Convert.ToDateTime(dateTimePicker1.Text.Trim());
                _donvi.ChucNang = txtChucNang.Text.Trim();
                _donvi.NhiemVu = txtNhiemVu.Text.Trim();
                if (_bizdonvi.themDonVi(_donvi) == true)
                {
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
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
