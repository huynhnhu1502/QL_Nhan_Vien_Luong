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
    public partial class frmSuaLSCongTac : Form
    {
        BIZ_LichSuCongTac bizLSCongTac = new BIZ_LichSuCongTac();
        string MaSua;
        LichSuCongTac LichSuCT;

        public frmSuaLSCongTac(string maSua)
        {
            this.MaSua = maSua;
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //lấy các thuộc tính từ form
            string maCT = txtMaCongTac.Text;
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            _3Layer.DonVi donVi = (_3Layer.DonVi)cbDonVi.SelectedItem;
            _3Layer.ChucVu chucVu = (_3Layer.ChucVu)cbChucVu.SelectedItem;
            _3Layer.NgachLuong ngach = (_3Layer.NgachLuong)cbNgachLuong.SelectedItem;
            //string ngayLam = dateNgayLam.Value.ToString("dd-mm-yyyy");
            DateTime ngayLam = this.dateNgayLam.Value.Date;
            //string ngayChuyen = dateNgayChuyen.Value.ToString("dd-mm-yyyy");
            DateTime ngayChuyen = dateNgayChuyen.Value.Date;
            
            if(KiemTraNgayChuyen() == false)
            {
                MessageBox.Show("Ngày chuyển phải lớn hơn ngày làm và ngày hiện tại!");
            }
            else
            {
                LichSuCT.NgayChuyen = ngayChuyen;//giá trị của đối tượng Lịch sử công tác đã được gán ở hàm Load

                if (bizLSCongTac.BIZSuaLichSuCongTac(LichSuCT) == true)
                {
                    MessageBox.Show("Đã sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không sửa được!");
                }
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
            int kq = DateTime.Compare(ngayLam, ngayChuyen);
            if (kq < 0)
            {
                return true;
            }
            //if (ngayChuyen > ngayHienTai && ngayChuyen > ngayLam)
            //{
            //    return true;
            //}
            return false;
        }
        //hàm tạo mã

        //hàm kiểm tra mã nhân viên

        //hàm kiểm tra ngày
        //if(datengayLam > (new Date().Now) thì thông báo
        //if(dateNgaychuyen < dateNgayLam) thông báo

        private void frmSuaLSCongTac_Load(object sender, EventArgs e)
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

                //Lấy thông tin sửa
                LichSuCT = bizLSCongTac.BIZTimLSCongTacTheoMa(MaSua);//gán giá trị cho LichSuCT (biến toàn cục đã khai báo ở trên)

                //gán các giá trị từ LichSuCT cho các thuộc tính trên form
                txtMaCongTac.Text = LichSuCT.MaCongTac;
                txtMaNV.Text = LichSuCT.NhanVien.MaNV;
                txtTenNV.Text = LichSuCT.NhanVien.HoTen;
                cbDonVi.SelectedItem = LichSuCT.DonVi;
                cbChucVu.SelectedItem = LichSuCT.ChucVu;
                cbNgachLuong.SelectedItem = LichSuCT.NgachLuong;
                dateNgayLam.Value = LichSuCT.NgayLam;
                if(LichSuCT.NgayChuyen != null)
                {
                    DateTime ngayChuyen = LichSuCT.NgayChuyen.Value;
                    dateNgayChuyen.Value = ngayChuyen;
                }
                else
                {
                    //dateNgayChuyen.Visible = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi tải dữ liệu!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
