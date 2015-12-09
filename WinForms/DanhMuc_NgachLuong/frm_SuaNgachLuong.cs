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

namespace WinForms.DanhMuc_NgachLuong
{
    public partial class frm_SuaNgachLuong : Form
    {
        BIZ_NgachLuong bizNgach = new BIZ_NgachLuong();
        string MaSua;
        NgachLuong ngachLuong;

        public frm_SuaNgachLuong(string maSua)
        {
            this.MaSua = maSua;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenNgach.Text.Trim() == "")
                {
                    MessageBox.Show("Tên ngạch không được trống!");
                }
                else if(txtNienHan.Text.Trim() =="")
                {
                    MessageBox.Show("Niên hạn không được trống!");
                }
                else
                {
                    //Lấy các thuộc tính từ form
                    string maNgach = txtMaNgach.Text;
                    string tenNgach = txtTenNgach.Text;
                    float nienHan;
                    string moTa = txtMoTa.Text;
                    if (float.TryParse(txtNienHan.Text, out nienHan) == false)
                    {
                        MessageBox.Show("Niên hạn là một số");
                    }
                    else if(nienHan < 1 || nienHan > 4)
                    {
                        MessageBox.Show("Niên hạn là một số dương không lớn hơn 4");
                    }
                    else
                    {
                        ngachLuong.TenNgach = tenNgach;
                        ngachLuong.NienHan = nienHan;
                        ngachLuong.MoTa = moTa;
                        if (bizNgach.BIZ_SuaNgachLuong(ngachLuong) == true)
                        {
                            MessageBox.Show("Đã sửa thành công!");
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

        private void frm_SuaNgachLuong_Load(object sender, EventArgs e)
        {
            try
            {
                //Lấy thông tin sửa
                ngachLuong = bizNgach.BIZ_TimNgachLuongTheoMa(MaSua);

                //gán giá trị từ ngạch lương cho form
                txtMaNgach.Text = ngachLuong.MaNgach;
                txtTenNgach.Text = ngachLuong.TenNgach;
                txtNienHan.Text = ngachLuong.NienHan.ToString();
                txtMoTa.Text = ngachLuong.MoTa;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
