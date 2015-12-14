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

namespace WinForms.LSCongTac
{
    public partial class frmLichSuCongTac : Form
    {
        BIZ_LichSuCongTac bizLSCongTac = new BIZ_LichSuCongTac();
        public frmLichSuCongTac()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LichSuCongTac_Load(object sender, EventArgs e)
        {
            try
            {
                //đổ DL vào GridTable
                gridLSCongTac.AutoGenerateColumns = false; // ko cho tự động tạo cột
                List<LichSuCongTac> ds = bizLSCongTac.BIZLayDuLieu();
                int row = 0;
                foreach (LichSuCongTac lsct in ds)
                {
                    gridLSCongTac.Rows.Add(new DataGridViewRow()); //them dong moi trong grid khi trong CSDL co them dong
                    gridLSCongTac.Rows[row].Cells["maCongTac"].Value = lsct.MaCongTac;
                    gridLSCongTac.Rows[row].Cells["tenNV"].Value = lsct.NhanVien.HoTen;
                    gridLSCongTac.Rows[row].Cells["tenDonVi"].Value = lsct.DonVi.TenDonVi;
                    gridLSCongTac.Rows[row].Cells["tenChucVu"].Value = lsct.ChucVu.TenChucVu;
                    gridLSCongTac.Rows[row].Cells["tenNgach"].Value = lsct.NgachLuong.TenNgach;
                    gridLSCongTac.Rows[row].Cells["ngayLam"].Value = lsct.NgayLam;
                    if(lsct.NgayChuyen != null)
                        gridLSCongTac.Rows[row].Cells["ngayChuyen"].Value = lsct.NgayChuyen;
                    row++;
                }

                //đổ dữ liệu vào combobox
                List<_3Layer.DonVi> dsDV = bizLSCongTac.BIZLayDLDonVi();
                cbDonVi.Items.Add("----Tất cả----");
                foreach (_3Layer.DonVi item in dsDV)
                {
                    cbDonVi.Items.Add(item);
                }
                //cbDonVi.DataSource = dsDV;
                cbDonVi.DisplayMember = "TenDonVi";
                cbDonVi.ValueMember = "MaDonVi";
                cbDonVi.SelectedIndex = 0;

                List<_3Layer.ChucVu> dsCV = bizLSCongTac.BIZLayDLChucVu();
                cbChucVu.Items.Add("----Tất cả----");
                foreach (_3Layer.ChucVu item in dsCV)
                {
                    cbChucVu.Items.Add(item);
                }
                //cbChucVu.DataSource = dsCV;
                cbChucVu.DisplayMember = "TenChucVu";
                cbChucVu.ValueMember = "MaChucVu";
                cbChucVu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được dữ liệu!");
            }
            
        }

        //Tìm
        private void btnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            string maNV = txtMaNV.Text.ToString();
            string tenNV = txtTenNV.Text.ToString();

            try
            {
                //lấy giá trị của combobox donvi
                string donVi = "";
                if (cbDonVi.SelectedItem.ToString() == "----Tất cả----")
                {
                    donVi = cbDonVi.SelectedItem.ToString();
                }
                else
                {
                    _3Layer.DonVi DV = (_3Layer.DonVi)cbDonVi.SelectedItem;
                    donVi = DV.MaDonVi;
                }

                //lấy giá trị của combobox cbChucvu    
                string chucVu = "";
                if (cbChucVu.SelectedItem.ToString() == "----Tất cả----")
                {
                    chucVu = cbChucVu.SelectedItem.ToString(); //lấy chuỗi trên
                }
                else
                {
                    _3Layer.ChucVu CV = (_3Layer.ChucVu)cbChucVu.SelectedItem; //lấy đối tượng trong ChucVu
                    chucVu = CV.MaChucVu;
                }

                //khởi tạo danh sách tìm từ biz
                List<LichSuCongTac> dsTim = bizLSCongTac.BIZTimLSCongTac(maNV, tenNV, donVi, chucVu);
                if(dsTim.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy!");
                    gridLSCongTac.Rows.Clear();
                }
                else
                {
                    gridLSCongTac.Rows.Clear();
                    //hiển thị danh sách sau khi tìm
                    int row = 0;
                    foreach (LichSuCongTac item in dsTim)
                    {
                        gridLSCongTac.Rows.Add(new DataGridViewRow());
                        gridLSCongTac.Rows[row].Cells["maCongTac"].Value = item.MaChucVu;
                        gridLSCongTac.Rows[row].Cells["tenNV"].Value = item.NhanVien.HoTen;
                        gridLSCongTac.Rows[row].Cells["tenDonVi"].Value = item.DonVi.TenDonVi;
                        gridLSCongTac.Rows[row].Cells["tenChucVu"].Value = item.ChucVu.TenChucVu;
                        gridLSCongTac.Rows[row].Cells["tenNgach"].Value = item.NgachLuong.TenNgach;
                        gridLSCongTac.Rows[row].Cells["ngayLam"].Value = item.NgayLam;
                        if(item.NgayChuyen != null)
                            gridLSCongTac.Rows[row].Cells["ngayChuyen"].Value = item.NgayChuyen;
                        row++;
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemLSCongTac them = new frmThemLSCongTac();
            them.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có chắc muốn xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int viTri = gridLSCongTac.CurrentCell.RowIndex;
                    if (viTri < 0)
                    {
                        MessageBox.Show("Bạn phải chọn mục cần xoá!");
                    }
                    else
                    {
                        string maXoa = gridLSCongTac.Rows[viTri].Cells["maCongTac"].Value.ToString();
                        if (bizLSCongTac.BIZXoaLichSuCongTac(maXoa) == true)
                        {
                            MessageBox.Show("Đã xoá!");
                            LayDanhSach();
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

        //Load danh sách (khi xoá xong...)
        private void LayDanhSach()
        {
            try
            {
                //đổ DL vào GridTable
                gridLSCongTac.Rows.Clear();
                gridLSCongTac.AutoGenerateColumns = false; // ko cho tự động tạo cột
                List<LichSuCongTac> ds = bizLSCongTac.BIZLayDuLieu();
                int row = 0;
                foreach (LichSuCongTac lsct in ds)
                {
                    gridLSCongTac.Rows.Add(new DataGridViewRow()); //them dong moi trong grid khi trong CSDL co them dong
                    gridLSCongTac.Rows[row].Cells["maCongTac"].Value = lsct.MaCongTac;
                    gridLSCongTac.Rows[row].Cells["tenNV"].Value = lsct.NhanVien.HoTen;
                    gridLSCongTac.Rows[row].Cells["tenDonVi"].Value = lsct.DonVi.TenDonVi;
                    gridLSCongTac.Rows[row].Cells["tenChucVu"].Value = lsct.ChucVu.TenChucVu;
                    gridLSCongTac.Rows[row].Cells["tenNgach"].Value = lsct.NgachLuong.TenNgach;
                    gridLSCongTac.Rows[row].Cells["ngayLam"].Value = lsct.NgayLam;
                    if(lsct.NgayChuyen != null)
                        gridLSCongTac.Rows[row].Cells["ngayChuyen"].Value = lsct.NgayChuyen;
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu!");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            try
            {
                 //đổ DL vào GridTable
                gridLSCongTac.AutoGenerateColumns = false; // ko cho tự động tạo cột
                List<LichSuCongTac> ds = bizLSCongTac.BIZLayDuLieu();
                gridLSCongTac.Rows.Clear();
                int row = 0;
                foreach (LichSuCongTac lsct in ds)
                {
                    gridLSCongTac.Rows.Add(new DataGridViewRow()); //them dong moi trong grid khi trong CSDL co them dong
                    gridLSCongTac.Rows[row].Cells["maCongTac"].Value = lsct.MaCongTac;
                    gridLSCongTac.Rows[row].Cells["tenNV"].Value = lsct.NhanVien.HoTen;
                    gridLSCongTac.Rows[row].Cells["tenDonVi"].Value = lsct.DonVi.TenDonVi;
                    gridLSCongTac.Rows[row].Cells["tenChucVu"].Value = lsct.ChucVu.TenChucVu;
                    gridLSCongTac.Rows[row].Cells["tenNgach"].Value = lsct.NgachLuong.TenNgach;
                    gridLSCongTac.Rows[row].Cells["ngayLam"].Value = lsct.NgayLam;
                    if(lsct.NgayChuyen != null)
                        gridLSCongTac.Rows[row].Cells["ngayChuyen"].Value = lsct.NgayChuyen;
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
                int viTri = gridLSCongTac.CurrentCell.RowIndex;
                if (viTri < 0)
                {
                    MessageBox.Show("Bạn phải chọn mục cần sửa!");
                }
                else
                {
                    string maSua = gridLSCongTac.Rows[viTri].Cells["maCongTac"].Value.ToString();
                    frmSuaLSCongTac sua = new frmSuaLSCongTac(maSua);
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
