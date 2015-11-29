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
    public partial class DonVi : Form
    {
        _3Layer.BIZ.BIZ_DonVi _bizdonvi = new _3Layer.BIZ.BIZ_DonVi();
        _3Layer.DonVi _donvi = new _3Layer.DonVi();
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        public DonVi()
        {
            InitializeComponent();
            loadcb();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DonVi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLuongDataSet1.DonVi' table. You can move, or remove it, as needed.
            this.donViTableAdapter.Fill(this.quanLyLuongDataSet1.DonVi);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = "Xem chi tiết";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _donvi.MaDonVi = txtMaDV.Text.Trim();
            _donvi.TenDonVi = txtTenDV.Text.Trim();
            _donvi.MaLoai = comboBox1.SelectedValue.ToString();
            if (_bizdonvi.TimKiem(_donvi) == true)
            {
                var result = (from u in db.DonVis where u.MaDonVi == _donvi.MaDonVi || u.TenDonVi == _donvi.TenDonVi || u.MaLoai == _donvi.MaLoai select new { u.MaDonVi, u.TenDonVi, u.MaLoai, u.DienThoai, u.NamThanhLap }).ToList();
                dataGridView1.DataSource = result;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[5].Value = "Xem chi tiết";
                }
            }
        }
        public void loadcb()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            var result = from u in db.LoaiDonVis select u;
            comboBox1.DataSource = result.ToList();
            comboBox1.ValueMember = "MaLoai";
            comboBox1.DisplayMember = "TenLoai";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemDonVi themdv = new ThemDonVi();
            themdv.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == dataGridView1.Columns["ChiTiet"].Index && e.RowIndex >= 0)
            {
                {
                    ChiTietDonVi test = new ChiTietDonVi(a.Cells[0].Value.ToString());
                    test.Show();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = from u in db.DonVis select new { u.MaDonVi, u.TenDonVi, u.MaLoai, u.DienThoai, u.NamThanhLap };
            dataGridView1.DataSource = result.ToList();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[5].Value = "Xem chi tiết";
            }
        }
    }
}
