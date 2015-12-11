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
    public partial class frm_SuaHeSoLuong : Form
    {
        BIZ_HeSoLuong bizHeSo = new BIZ_HeSoLuong();
        string maHeSoSua;
        HeSoLuongPhuCap heSoLuong;

        public frm_SuaHeSoLuong(string maSua)
        {
            this.maHeSoSua = maSua;
            InitializeComponent();
        }

        //Load form
        private void frm_SuaHeSoLuong_Load(object sender, EventArgs e)
        {
            try
            {
                //Đổ DL ngạch lương vào combobox
                List<NgachLuong> ngach = bizHeSo.BIZ_LayDLNgach();
                cbNgach.DataSource = ngach;
                cbNgach.ValueMember = "MaNgach";
                cbNgach.DisplayMember = "TenNgach";

                //Lấy thông tin sửa
                heSoLuong = bizHeSo.BIZ_TimHeSoTheoMa(maHeSoSua);

                txtMaHeSo.Text = heSoLuong.MaHeSo;
                cbNgach.SelectedItem = heSoLuong.NgachLuong;
                txtTenHeSo.Text = heSoLuong.TenHeSo;
                txtHeSo.Text = heSoLuong.HeSo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!");
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
                string maHeSo = txtMaHeSo.Text;
                NgachLuong ngach = (NgachLuong)cbNgach.SelectedItem;
                string tenHeSo = txtTenHeSo.Text;
                double heSo;
                if (txtTenHeSo.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập tên hệ số");
                }
                else if (txtHeSo.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập hệ số");
                }
                else if (double.TryParse(txtHeSo.Text, out heSo) == false && txtHeSo.Text != "")
                {
                    MessageBox.Show("Hệ số là số thực!");
                }                
                else
                {
                    if(tenHeSo != heSoLuong.TenHeSo)
                    {
                        if (bizHeSo.BIZ_KiemTraTenHeSo(ngach.MaNgach, tenHeSo) == false)
                        {
                            MessageBox.Show("Tên hệ số đã tồn tại!");
                        }
                        else
                        {
                            heSoLuong.TenHeSo = tenHeSo;
                            heSoLuong.HeSo = heSo;
                            if (bizHeSo.BIZ_SuaHeSoLuong(heSoLuong))
                            {
                                MessageBox.Show("Sửa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không sửa được!");
                            }
                        }
                    }
                    else
                    {
                        heSoLuong.HeSo = heSo;
                        if (bizHeSo.BIZ_SuaHeSoLuong(heSoLuong))
                        {
                            MessageBox.Show("Sửa thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không sửa được!");
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
        }
    }
}
