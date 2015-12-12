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

namespace WinForms
{
    public partial class frm_NhanVien : Form
    {
        BIZ_NV bizNV = new BIZ_NV();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                gridNhanVien.AutoGenerateColumns = false;
                List<NhanVien> list = bizNV.BIZ_LayDuLieuNV();
                //Lấy DL đổ vào grid
                int row = 0;
                foreach(NhanVien nv in list)
                {
                    gridNhanVien.Rows.Add(new DataGridViewRow());
                    gridNhanVien.Rows[row].Cells["MaNhanVien"].Value = nv.MaNV;
                    gridNhanVien.Rows[row].Cells["HoTen"].Value = nv.HoTen;
                    gridNhanVien.Rows[row].Cells["DonVi"].Value = nv.DonVi.TenDonVi;
                    gridNhanVien.Rows[row].Cells["ChucVu"].Value = nv.ChucVu.TenChucVu;
                    gridNhanVien.Rows[row].Cells["ChiTiet"].Value = "Xem chi tiết";
                    row++;
                }

                //Lấy DL đổ vào combobox đơn vị
                List<_3Layer.DonVi> dsDV = bizNV.BIZ_LayDLDonVi();
                cbDonVi.Items.Add("----Tất cả----");
                foreach (_3Layer.DonVi item in dsDV)
                {
                    cbDonVi.Items.Add(item);
                }
                //cbDonVi.DataSource = dsDV;
                cbDonVi.DisplayMember = "TenDonVi";
                cbDonVi.ValueMember = "MaDonVi";
                cbDonVi.SelectedIndex = 0;

                List<_3Layer.ChucVu> dsCV = bizNV.BIZ_LayDLChucVu();
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
    }
}
