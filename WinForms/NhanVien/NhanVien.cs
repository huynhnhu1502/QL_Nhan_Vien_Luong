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
    public partial class NhanVien : Form
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        _3Layer.NhanVien nv = new _3Layer.NhanVien();
        _3Layer.BIZ.BIZ_NV biz = new _3Layer.BIZ.BIZ_NV();
        public NhanVien()
        {
            InitializeComponent();
            tonghop();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLuongDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quanLyLuongDataSet.NhanVien);
            // TODO: This line of code loads data into the 'quanLyLuongDataSet.NhanVien' table. You can move, or remove it, as needed.
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = "Xem chi tiết";
            }
        }
        private void tonghop()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            using (QuanLyLuongEntities db = new QuanLyLuongEntities())
            {
                var result1 = from a in db.DonVis select a;
                var result2 = from a in db.ChucVus select a;
                comboBox1.DataSource = result1.ToList();
                comboBox1.ValueMember = "MaDonVi";
                comboBox1.DisplayMember = "TenDonVi";
                comboBox2.DataSource = result2.ToList();
                comboBox2.ValueMember = "MaChucVu";
                comboBox2.DisplayMember = "TenChucVu";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNV themnv = new ThemNV();
            themnv.Show();           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            nv.MaNV = txtMaNV.Text.Trim();
            nv.HoTen = txtTenNV.Text.Trim();
            nv.MaDonVi = comboBox1.SelectedValue.ToString();
            nv.MaChucVu = comboBox2.SelectedValue.ToString();
            if (biz.Search(nv) == true)
            {

                var result = from a in db.NhanViens
                             where (a.MaNV == nv.MaNV) || (a.MaDonVi == nv.MaDonVi) ||
                             (a.MaChucVu == nv.MaChucVu) || (a.HoTen == nv.HoTen)
                             select a;
                dataGridView1.DataSource = result.ToList();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[5].Value = "Xem chi tiết";
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int so = dataGridView1.CurrentCell.RowIndex;
            loadlen(so);
        }
        public void loadlen(int so)
        {
            var a = dataGridView1.Rows[so];
            txtMaNV.Text = a.Cells[1].Value.ToString();
            txtTenNV.Text = a.Cells[2].Value.ToString();
            comboBox1.Text = a.Cells[3].Value.ToString();
            comboBox2.Text = a.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == dataGridView1.Columns["ChiTiet"].Index && e.RowIndex >= 0)
            {
                {
                    ChiTietNV test = new ChiTietNV(a.Cells[1].Value.ToString(), a.Cells[2].Value.ToString());
                    test.Show();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var result2 = from a in db.NhanViens select new { a.MaNV, a.MaDonVi, a.MaChucVu, a.HoTen, a.GioiTinh, a.NgayBatDau };
            dataGridView1.DataSource = result2.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = "Xem chi tiết";
            }
        }

    }
}
