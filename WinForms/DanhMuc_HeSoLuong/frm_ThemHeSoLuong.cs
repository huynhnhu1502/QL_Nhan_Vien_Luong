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

namespace WinForms.DanhMuc_HeSoLuong
{
    public partial class frm_ThemHeSoLuong : Form
    {
        BIZ_HeSoLuong bizHeSo = new BIZ_HeSoLuong();

        public frm_ThemHeSoLuong()
        {
            InitializeComponent();
        }

        private void frm_ThemHeSoLuong_Load(object sender, EventArgs e)
        {
            try
            {
                //Đổ DL vào combobox ngạch lương
                List<NgachLuong> dsNgach = bizHeSo.BIZ_LayDLNgach();
                cbNgach.DataSource = dsNgach;
                cbNgach.ValueMember = "MaNgach";
                cbNgach.DisplayMember = "TenNgach";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy được dữ liệu ngạch!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                NgachLuong ngach = (NgachLuong)cbNgach.SelectedItem;
                string tenHeSo = txtTenHeSo.Text;
                double HeSo;

                if(txtTenHeSo.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập tên hệ số");
                }
                else if (txtHeSo.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập hệ số");
                }
                else if (double.TryParse(txtHeSo.Text, out HeSo) == false && txtHeSo.Text != "")
                {
                    MessageBox.Show("Hệ số là số thực!");
                }
                else if(bizHeSo.BIZ_KiemTraTenHeSo(ngach.MaNgach, tenHeSo) == false)
                {
                    MessageBox.Show("Tên hệ số đã tồn tại!");
                }
                else
                {
                    HeSoLuongPhuCap heSoLuong = new HeSoLuongPhuCap();
                    heSoLuong.MaHeSo = bizHeSo.BIZ_TaoMaHeSoLuong();
                    heSoLuong.TenHeSo = tenHeSo;
                    heSoLuong.HeSo = HeSo;
                    heSoLuong.MaNgach = ngach.MaNgach;

                    if (bizHeSo.BIZ_ThemHeSoLuong(heSoLuong) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtTenHeSo.Text = "";
                        txtHeSo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm không được dzồi!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }
    }
}
