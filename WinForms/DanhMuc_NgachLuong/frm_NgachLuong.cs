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
    public partial class frm_NgachLuong : Form
    {
        QuanLyLuongEntities entity = new QuanLyLuongEntities();
        BIZ_NgachLuong bizNgach = new BIZ_NgachLuong();

        public frm_NgachLuong()
        {
            InitializeComponent();
        }

        private void frm_NgachLuong_Load(object sender, EventArgs e)
        {
            try
            {
                //Đổ DL vào datadgidview
                gridNgachLuong.AutoGenerateColumns = false;//ko cho tự động tạo cột
                List<NgachLuong> ds = bizNgach.BIZ_LayDuLieuNgach();
                int row = 0;
                foreach(NgachLuong ngach in ds)
                {
                    gridNgachLuong.Rows.Add(new DataGridViewRow());//them dong moi trong grid khi them DL
                    gridNgachLuong.Rows[row].Cells["MaNgach"].Value = ngach.MaNgach;
                    gridNgachLuong.Rows[row].Cells["TenNgach"].Value = ngach.TenNgach;
                    gridNgachLuong.Rows[row].Cells["MoTa"].Value = ngach.MoTa;
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu!");
            }
        }

        //Tìm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string maNgach = txtMaNgach.Text.ToString();
                string tenNgach = txtTenNgach.Text.ToString();
                List<NgachLuong> dsTim = bizNgach.BIZ_TimNgachLuong(maNgach, tenNgach);

                if(dsTim.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy!");
                    gridNgachLuong.Rows.Clear();
                }
                else
                {
                    gridNgachLuong.Rows.Clear();
                    //hiển thị danh sách tìm được
                    int row = 0;
                    foreach (NgachLuong item in dsTim)
                    {
                        gridNgachLuong.Rows.Add(new DataGridViewRow());
                        gridNgachLuong.Rows[row].Cells["MaNgach"].Value = item.MaNgach;
                        gridNgachLuong.Rows[row].Cells["TenNgach"].Value = item.TenNgach;
                        gridNgachLuong.Rows[row].Cells["MoTa"].Value = item.MoTa;
                        row++;
                    }
                }
                
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

    }
}
