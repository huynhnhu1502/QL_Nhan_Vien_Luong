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

namespace WinForms.LSCongTac
{
    public partial class frmThemLSCongTac : Form
    {
        BIZ_LichSuCongTac bizLSCongTac = new BIZ_LichSuCongTac();
        public frmThemLSCongTac()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy các thuộc tính từ form
                string maNV = txtMaNV.Text;
                _3Layer.DonVi donVi = (_3Layer.DonVi)cbDonVi.SelectedItem;
                _3Layer.ChucVu chucVu = (_3Layer.ChucVu)cbChucVu.SelectedItem;
                _3Layer.NgachLuong ngach = (_3Layer.NgachLuong)cbNgachLuong.SelectedItem;
                //string ngayLam = dateNgayLam.Value.ToString("dd-mm-yyyy");
                DateTime ngayLam = this.dateNgayLam.Value.Date;
                //string ngayChuyen = dateNgayChuyen.Value.ToString("dd-mm-yyyy");
                DateTime ngayChuyen = dateNgayChuyen.Value.Date;


                //lấy mã nhân viên từ form -- kiểm tra nhập if(txtManv.trim() == "") thông báo phải nhập
                if (txtMaNV.Text.Trim() == "")
                {
                    MessageBox.Show("Phải nhập mã nhân viên!");
                }
                else if (KiemTraNgayChuyen() == false && checkNgayChuyen.Checked == true)
                {
                    MessageBox.Show("Ngày chuyển phải lớn hơn ngày làm và ngày hiện tại!");
                }
                else
                {
                    //kiểm tra mã nhân viên có tồn tại không - nếu không có thì thông báo
                    if (bizLSCongTac.BIZKiemTraMaNV(maNV) == true)
                    {
                        LichSuCongTac lsct = new LichSuCongTac();
                        lsct.MaCongTac = bizLSCongTac.BIZTaoMaLSCongTac();
                        lsct.MaNV = maNV;
                        lsct.MaDonVi = donVi.MaDonVi;
                        lsct.MaChucVu = chucVu.MaChucVu;
                        lsct.MaNgach = ngach.MaNgach;
                        lsct.NgayLam = ngayLam;
                        if (checkNgayChuyen.Checked == true)
                        {
                            lsct.NgayChuyen = ngayChuyen;
                        }
                        else
                        {
                            lsct.NgayChuyen = null;
                        }

                        if (bizLSCongTac.BIZThemLSCongTac(lsct) == true)
                        {
                            MessageBox.Show("Thêm thành công!");

                            //cập nhật lại thông tin nhân viên
                            _3Layer.NhanVien nvCapNhat = bizLSCongTac.BIZTimNhanVien(maNV);
                            //gán vào thuộc tính của nhân viên tìm được
                            nvCapNhat.MaDonVi = donVi.MaDonVi;
                            nvCapNhat.MaChucVu = chucVu.MaChucVu;
                            bizLSCongTac.BIZCapNhatNhanVien(nvCapNhat);

                            //thêm thành công thì reset lại form thêm để thêm đối tượng khác
                            txtMaNV.Text = "";
                            cbDonVi.SelectedIndex = 0;
                            cbChucVu.SelectedIndex = 0;
                            cbNgachLuong.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Thêm không được dzồi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không đúng!");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống");
            }

            //lấy ngày làm - ngày chuyển
            //kiểm tra ngày làm - ngày chuyển
            //nếu thoả hết đk thì gọi hàm bên biz để lưu          
        }

        public bool KiemTraNgayChuyen()
        {
            DateTime ngayChuyen = dateNgayChuyen.Value.Date;
            DateTime ngayLam = dateNgayLam.Value.Date;
            DateTime ngayHienTai = DateTime.Now;
            if (ngayChuyen > ngayHienTai && ngayChuyen > ngayLam)
            {
                return true;
            }
            return false;
        }
        //hàm tạo mã

        //hàm kiểm tra mã nhân viên

        //hàm kiểm tra ngày
        //if(datengayLam > (new Date().Now) thì thông báo
        //if(dateNgaychuyen < dateNgayLam) thông báo

        private void frmThemLSCongTac_Load(object sender, EventArgs e)
        {
            try
            {
                //đổ dữ liệu vào combobox đơn vị
                List<_3Layer.DonVi> dsDV = bizLSCongTac.BIZLayDLDonVi();
                cbDonVi.DataSource = dsDV;
                cbDonVi.DisplayMember = "TenDonVi";
                cbDonVi.ValueMember = "MaDonVi";

                //đổ dữ liệu vào combobox chức vụ
                List<_3Layer.ChucVu> dsCV = bizLSCongTac.BIZLayDLChucVu();
                cbChucVu.DataSource = dsCV;
                cbChucVu.DisplayMember = "TenChucVu";
                cbChucVu.ValueMember = "MaChucVu";

                //đổ dữ liệu vào combobox ngạch lương
                List<NgachLuong> dsNgach = bizLSCongTac.BIZLayDLNgachLuong();
                cbNgachLuong.DataSource = dsNgach;
                cbNgachLuong.DisplayMember = "TenNgach";
                cbNgachLuong.ValueMember = "MaNgach";
                
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể lấy dữ liệu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtMaNV.Text.Trim();
                if(maNV == "")
                {
                    MessageBox.Show("Nhập mã nhân viên!");
                }
                else
                {
                    _3Layer.NhanVien nhanVien = bizLSCongTac.BIZTimNhanVien(maNV);
                    if (nhanVien==null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên mã " + maNV);
                    }
                    else
                    {
                    txtTenNV.Text = nhanVien.HoTen;
                    cbDonVi.SelectedItem = nhanVien.DonVi;
                    cbChucVu.SelectedItem = nhanVien.ChucVu;
                    cbNgachLuong.SelectedItem = nhanVien.NgachLuong;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void checkNgayChuyen_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNgayChuyen.Checked == true)
            {
                dateNgayChuyen.Enabled = true;
            }
            else
            {
                dateNgayChuyen.Enabled = false;
            }
        }
    }
}
