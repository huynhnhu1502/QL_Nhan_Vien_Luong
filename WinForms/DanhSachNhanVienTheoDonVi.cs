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

namespace WinForms
{
    public partial class DanhSachNhanVienTheoDonVi : Form
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        public DanhSachNhanVienTheoDonVi(string data1)
        {
            InitializeComponent();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var timkiem = _db.DonVis.FirstOrDefault(a => a.TenDonVi == data1);
            if (timkiem != null)
            {
                string madv = timkiem.MaDonVi;
                var result = (from u in _db.NhanViens where u.MaDonVi == madv select new { u.MaNV, u.HoTen, u.MaChucVu, u.NgaySinh, u.GioiTinh, u.CMND, u.HinhAnh });
                dataGridView1.DataSource = result.ToList();
            }
        }

        private void DanhSachNhanVienTheoDonVi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLuongDataSet4.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyLuongDataSet4.NhanVien);

        }
    }
}
