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
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        _3Layer.LoaiDonVi _loaidv = new _3Layer.LoaiDonVi();
        _3Layer.BIZ.BIZ_LoaiDonVi _bizloaidv = new _3Layer.BIZ.BIZ_LoaiDonVi();
        public LoaiDonVi()
        {
            InitializeComponent();
            load();

        }

     
        public void load()
        {

            dataGridView1.DataSource = _bizloaidv.DSLoaidv();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "Sửa";
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string ma = txtMaLoai.Text;
            string ten = txtTenLoai.Text;
            dataGridView1.DataSource = _bizloaidv.BIZTimKiem(ma, ten);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "Sửa";
            }

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu cần tìm !!");
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
                dataGridView1.Rows[i].Cells[0].Value = "Sửa";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == dataGridView1.Columns["Sua"].Index && e.RowIndex >= 0)
            {
                {
                    SuaLoaiDV test = new SuaLoaiDV(a.Cells[2].Value.ToString());
                    test.Show();
                }
            }
        }

        private void LoaiDonVi_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
