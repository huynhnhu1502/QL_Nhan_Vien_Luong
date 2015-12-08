using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _3Layer.DAL;
using _3Layer;
using _3Layer.BIZ;


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
            load();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void load()
        {

            dataGridView1.DataSource = _bizdonvi.DSDonVi();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "Xem chi tiết";
            }


        }
        private void DonVi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLuongDataSet1.DonVi' table. You can move, or remove it, as needed.
            try
            {
                load();         
                loadcb();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        public delegate void laymadonvi(TextBox madv);       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = dataGridView1.CurrentCell.RowIndex;
            loadCV(VT);
            var a = dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex == dataGridView1.Columns["ChiTiet"].Index && e.RowIndex >= 0)
            {
                {
                    ChiTietDonVi frmchitiet = new ChiTietDonVi();
                    frmchitiet.Show();
                    laymadonvi del = new laymadonvi(frmchitiet.Laydulieu);
                    del(this.txtMaDV);
                    frmchitiet.Show();
                }
            }
        }

        private void loadCV(int VT)
        {

            try
            {
                txtMaDV.Text = dataGridView1.Rows[VT].Cells[2].Value.ToString();
            }
            catch (Exception e) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maloai = "";
            if (cbloai.SelectedItem.ToString() == "----Tất cả----")
            {
                maloai = "";
            }
            else
            {
                _3Layer.LoaiDonVi LDV = (_3Layer.LoaiDonVi)cbloai.SelectedItem;
                maloai = LDV.MaLoai;
            }
            if (txtma.Text == "" && txtTenDV.Text == "" && maloai == "")
            {
                load();
            }
            else
            {
                string ma = txtma.Text;
                string ten = txtTenDV.Text;
                dataGridView1.DataSource = _bizdonvi.BIZTimKiem(ma,ten,maloai);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = "Xem chi tiết";
                }

                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cần tìm !!");
                }
            }
            }
        

        public void loadcb()
        {
            List<_3Layer.LoaiDonVi> dsLDV = _bizdonvi.BIZLayLoai();
            cbloai.Items.Add("----Tất cả----");
            foreach (_3Layer.LoaiDonVi item in dsLDV)
            {
                cbloai.Items.Add(item);
            }
            //cbDonVi.DataSource = dsDV;
            cbloai.DisplayMember = "TenLoai";
            cbloai.ValueMember = "MaLoai";
            cbloai.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemDonVi themdv = new ThemDonVi();
            themdv.Show();
        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            load();
            txtma.Text = "";
            txtTenDV.Text = "";
            loadcb();


        }

        private void btSua_Click(object sender, EventArgs e)
        {
            
            if (txtMaDV.Text != "")
            {
                {
                    SuaDonVi frmsua = new SuaDonVi();
                    frmsua.Show();
                    laymadonvi del = new laymadonvi(frmsua.Laydulieu);
                    del(this.txtMaDV);
                    frmsua.Show();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn vị muốn sửa!");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
