using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Layer.BIZ;
using _3Layer;

namespace WinForms.DanhMuc_HeSoLuong
{
    public partial class frm_HeSoLuong : Form
    {
        BIZ_HeSoLuong bizHeSo = new BIZ_HeSoLuong();

        public frm_HeSoLuong()
        {
            InitializeComponent();
        }

        //Lấy DL đổ vào form
        private void frm_HeSoLuong_Load(object sender, EventArgs e)
        {
            try
            {
                //Đổ DL vào grid
                gridHeSoLuong.AutoGenerateColumns = false;
                List<HeSoLuongPhuCap> ds = bizHeSo.BIZ_LayDuLieu();
                int row = 0;
                foreach(HeSoLuongPhuCap hs in ds)
                {
                    gridHeSoLuong.Rows.Add(new DataGridViewRow());
                    gridHeSoLuong.Rows[row].Cells["MaHeSo"].Value = hs.MaHeSo;
                    gridHeSoLuong.Rows[row].Cells["TenNgach"].Value = hs.NgachLuong.TenNgach;
                    gridHeSoLuong.Rows[row].Cells["TenHeSo"].Value = hs.TenHeSo;
                    gridHeSoLuong.Rows[row].Cells["HeSo"].Value = hs.HeSo;
                    row++;
                }

                //Đổ DL vào combobox
                List<NgachLuong> dsNgach = bizHeSo.BIZ_LayDLNgach();
                cbNgachLuong.Items.Add("------Tất cả------");
                foreach(NgachLuong ngach in dsNgach)
                {
                    cbNgachLuong.Items.Add(ngach);
                }
                cbNgachLuong.ValueMember = "MaNgach";
                cbNgachLuong.DisplayMember = "TenNgach";
                cbNgachLuong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu!");
            }
        }

        //Tìm hệ số lương
        private void btnTim_Click(object sender, EventArgs e)
        {
            
            try
            {
                string maNgach = "";
                double heSo; 
                if(double.TryParse(txtHeSo.Text, out heSo) == false && txtHeSo.Text != "")
                {
                    MessageBox.Show("Hệ số là số thực!");
                }
                else
                {
                    if(txtHeSo.Text.Trim() == "")
                    {
                        heSo = -1;
                    }
                    if (cbNgachLuong.SelectedItem.ToString() == "------Tất cả------")
                    {
                        maNgach = cbNgachLuong.SelectedItem.ToString();
                    }
                    else
                    {
                        NgachLuong ngach = (NgachLuong)cbNgachLuong.SelectedItem;
                        maNgach = ngach.MaNgach;
                    }

                    List<HeSoLuongPhuCap> dsTim = bizHeSo.BIZ_TimHeSoLuong(maNgach, heSo);
                    if (dsTim.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy!");
                        gridHeSoLuong.Rows.Clear();
                    }
                    else
                    {
                        gridHeSoLuong.Rows.Clear();
                        int row = 0;
                        foreach (HeSoLuongPhuCap hs in dsTim)
                        {
                            gridHeSoLuong.Rows.Add(new DataGridViewRow());
                            gridHeSoLuong.Rows[row].Cells["MaHeSo"].Value = hs.MaHeSo;
                            gridHeSoLuong.Rows[row].Cells["TenNgach"].Value = hs.NgachLuong.TenNgach;
                            gridHeSoLuong.Rows[row].Cells["TenHeSo"].Value = hs.TenHeSo;
                            gridHeSoLuong.Rows[row].Cells["HeSo"].Value = hs.HeSo;
                            row++;
                        }
                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
        }

        //Tải lại danh sách hệ số
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                //Đổ DL vào grid
                gridHeSoLuong.AutoGenerateColumns = false;
                List<HeSoLuongPhuCap> ds = bizHeSo.BIZ_LayDuLieu();
                gridHeSoLuong.Rows.Clear();
                int row = 0;
                foreach (HeSoLuongPhuCap hs in ds)
                {
                    gridHeSoLuong.Rows.Add(new DataGridViewRow());
                    gridHeSoLuong.Rows[row].Cells["MaHeSo"].Value = hs.MaHeSo;
                    gridHeSoLuong.Rows[row].Cells["TenNgach"].Value = hs.NgachLuong.TenNgach;
                    gridHeSoLuong.Rows[row].Cells["TenHeSo"].Value = hs.TenHeSo;
                    gridHeSoLuong.Rows[row].Cells["HeSo"].Value = hs.HeSo;
                    row++;
                }

                //Đổ DL vào combobox
                List<NgachLuong> dsNgach = bizHeSo.BIZ_LayDLNgach();
                cbNgachLuong.Items.Add("------Tất cả------");
                foreach (NgachLuong ngach in dsNgach)
                {
                    cbNgachLuong.Items.Add(ngach);
                }
                cbNgachLuong.ValueMember = "MaNgach";
                cbNgachLuong.DisplayMember = "TenNgach";
                cbNgachLuong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_ThemHeSoLuong them = new frm_ThemHeSoLuong();
            them.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int viTri = gridHeSoLuong.CurrentCell.RowIndex;
                if(viTri < 0)
                {
                    MessageBox.Show("Bạn phải chọn mục cần sửa!");
                }
                else
                {
                    string maSua = gridHeSoLuong.Rows[viTri].Cells["MaHeSo"].Value.ToString();
                    frm_SuaHeSoLuong sua = new frm_SuaHeSoLuong(maSua);
                    sua.Show();
                }
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
                if (MessageBox.Show("Bạn có chắc muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int viTri = gridHeSoLuong.CurrentCell.RowIndex;
                    if(viTri < 0)
                    {
                        MessageBox.Show("Bạn phải chọn mục cần xoá!");
                    }
                    else
                    {
                        string maXoa = gridHeSoLuong.Rows[viTri].Cells["MaHeSo"].Value.ToString();
                        if(bizHeSo.BIZ_XoaHeSoLuong(maXoa) == true)
                        {
                            MessageBox.Show("Đã xoá!");
                            LayDanhSachHeSo();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá!");
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
        private void LayDanhSachHeSo()
        {
            try
            {
                //Đổ DL vào grid
                gridHeSoLuong.AutoGenerateColumns = false;
                List<HeSoLuongPhuCap> ds = bizHeSo.BIZ_LayDuLieu();
                gridHeSoLuong.Rows.Clear();
                int row = 0;
                foreach (HeSoLuongPhuCap hs in ds)
                {
                    gridHeSoLuong.Rows.Add(new DataGridViewRow());
                    gridHeSoLuong.Rows[row].Cells["MaHeSo"].Value = hs.MaHeSo;
                    gridHeSoLuong.Rows[row].Cells["TenNgach"].Value = hs.NgachLuong.TenNgach;
                    gridHeSoLuong.Rows[row].Cells["TenHeSo"].Value = hs.TenHeSo;
                    gridHeSoLuong.Rows[row].Cells["HeSo"].Value = hs.HeSo;
                    row++;
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
