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
                    gridNgachLuong.Rows[row].Cells["NienHan"].Value = ngach.NienHan;
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
                        gridNgachLuong.Rows[row].Cells["NienHan"].Value = item.NienHan;
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

        //Tải lại gridView
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                //Đổ DL vào datadgidview
                gridNgachLuong.AutoGenerateColumns = false;//ko cho tự động tạo cột
                List<NgachLuong> ds = bizNgach.BIZ_LayDuLieuNgach();
                gridNgachLuong.Rows.Clear();
                int row = 0;
                foreach (NgachLuong ngach in ds)
                {
                    gridNgachLuong.Rows.Add(new DataGridViewRow());//them dong moi trong grid khi them DL
                    gridNgachLuong.Rows[row].Cells["MaNgach"].Value = ngach.MaNgach;
                    gridNgachLuong.Rows[row].Cells["TenNgach"].Value = ngach.TenNgach;
                    gridNgachLuong.Rows[row].Cells["NienHan"].Value = ngach.NienHan;
                    gridNgachLuong.Rows[row].Cells["MoTa"].Value = ngach.MoTa;
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ThemNgachLuong them = new frm_ThemNgachLuong();
                them.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có thực sự muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int viTri = gridNgachLuong.CurrentCell.RowIndex;
                    if (viTri < 0)
                    {
                        MessageBox.Show("Bạn phải chọn mục cần xoá!");
                    }
                    else
                    {
                        string maXoa = gridNgachLuong.Rows[viTri].Cells["MaNgach"].Value.ToString();
                        if(bizNgach.BIZ_XoaNgachLuong(maXoa) == true)
                        {
                            MessageBox.Show("Đã xoá!");
                            LayLaiDanhSach();
                        }
                        else
                        {
                            MessageBox.Show("Không xoá được!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
        }

        //Load lại DS sau khi xoá xong
        private void LayLaiDanhSach()
        {
            try
            {
                gridNgachLuong.Rows.Clear();
                gridNgachLuong.AutoGenerateColumns = false;
                List<NgachLuong> list = bizNgach.BIZ_LayDuLieuNgach();
                int row = 0;
                foreach(NgachLuong ngach in list)
                {
                    gridNgachLuong.Rows.Add(new DataGridViewRow());
                    gridNgachLuong.Rows[row].Cells["MaNgach"].Value = ngach.MaNgach;
                    gridNgachLuong.Rows[row].Cells["TenNgach"].Value = ngach.TenNgach;
                    gridNgachLuong.Rows[row].Cells["NienHan"].Value = ngach.NienHan;
                    gridNgachLuong.Rows[row].Cells["MoTa"].Value = ngach.MoTa;
                    row++;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int viTri = gridNgachLuong.CurrentCell.RowIndex;
                if(viTri < 0)
                {
                    MessageBox.Show("Bạn phải chọn mục cần sửa!");
                }
                else
                {
                    string maSua = gridNgachLuong.Rows[viTri].Cells["MaNgach"].Value.ToString();
                    frm_SuaNgachLuong sua = new frm_SuaNgachLuong(maSua);
                    sua.Show();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
