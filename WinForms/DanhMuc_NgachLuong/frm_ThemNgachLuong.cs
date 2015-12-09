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
    public partial class frm_ThemNgachLuong : Form
    {
        QuanLyLuongEntities entity = new QuanLyLuongEntities();
        BIZ_NgachLuong bizNgach = new BIZ_NgachLuong();

        public frm_ThemNgachLuong()
        {
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
                    string tenNgach = txtTenNgach.Text;
                    float nienHan = float.Parse(txtNienHan.Text);
                    string moTa = txtMoTa.Text;

                    NgachLuong ngach = new NgachLuong();
                    ngach.MaNgach = bizNgach.BIZ_TaoMaNgachLuong();
                    ngach.TenNgach = tenNgach;
                    ngach.NienHan = nienHan;
                    ngach.MoTa = moTa;
                    if(bizNgach.BIZ_ThemNgachLuong(ngach) == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                        txtTenNgach.Text = "";
                        txtNienHan.Text = "";
                        txtMoTa.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
