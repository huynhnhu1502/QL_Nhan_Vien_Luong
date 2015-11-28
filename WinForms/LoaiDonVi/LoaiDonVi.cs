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
    public partial class LoaiDonVi : Form
    {
        QuanLyLuongEntities1 _db = new QuanLyLuongEntities1();
        _3Layer.LoaiDonVi _loaidv = new _3Layer.LoaiDonVi();
        _3Layer.BIZ.BIZ_LoaiDonVi _bizloaidv = new _3Layer.BIZ.BIZ_LoaiDonVi();
        public LoaiDonVi()
        {
            InitializeComponent();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lbErr.Visible = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = "Sửa";
            }
        }

        private void LoaiDonVi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLuongDataSet2.LoaiDonVi' table. You can move, or remove it, as needed.
            this.loaiDonViTableAdapter.Fill(this.quanLyLuongDataSet2.LoaiDonVi);
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (txtMaLoai.Text == "" && txtTenLoai.Text == "")
            {
                lbErr.Visible = true;
                lbErr.Text = "Nhập dữ liệu cần tìm";
                flag = false;
            }
            if (flag)
            {
                _loaidv.MaLoai = txtMaLoai.Text.Trim();
                _loaidv.TenLoai = txtTenLoai.Text.Trim();
                if (_bizloaidv.TimKiem(_loaidv) == true)
                {
                    var result = from u in _db.LoaiDonVis where u.MaLoai.Equals(_loaidv.MaLoai) || u.TenLoai.Equals(_loaidv.TenLoai) select u;
                    dataGridView1.DataSource = result.ToList();
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[4].Value = "Sửa";
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemLoaiDV them = new ThemLoaiDV();
            them.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var result = (from u in _db.LoaiDonVis select new { u.id, u.MaLoai, u.TenLoai, u.MoTa });
            dataGridView1.DataSource = result.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[4].Value = "Sửa";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == dataGridView1.Columns["Sua"].Index && e.RowIndex >= 0)
            {
                {
                    SuaLoaiDV test = new SuaLoaiDV(a.Cells[1].Value.ToString());
                    test.Show();
                }
            }
        }
    }
}
