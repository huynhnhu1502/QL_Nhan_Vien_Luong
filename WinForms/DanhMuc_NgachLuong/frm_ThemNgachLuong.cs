using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.DanhMuc_NgachLuong
{
    public partial class frm_ThemNgachLuong : Form
    {
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
                string tenNgach = txtTenNgach.Text;
                float nienHan = float.Parse(txtNienHan.Text);
                string moTa = txtMoTa.Text;


            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
