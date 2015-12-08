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

namespace WinForms.ChucVu
{
    public partial class QuanLyChucVu : Form
    {

        _3Layer.BIZ.BIZ_ChucVu _bizchucvu = new _3Layer.BIZ.BIZ_ChucVu();
        _3Layer.ChucVu _chucvu = new _3Layer.ChucVu();
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        public QuanLyChucVu()
        {
            InitializeComponent();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
     
        public void load()
        {

            dataGridView1.DataSource = _bizchucvu.DSChucVu();
            
            
        }     
        private void dataGridView1_CellClick(object sender, EventArgs e)
        {
            int VT = dataGridView1.CurrentCell.RowIndex;
            loadCV(VT);
        }

        private void loadCV(int VT)
        {
         
            try
            {
                
                    suaten.Text = dataGridView1.Rows[VT].Cells[2].Value.ToString();
                    suahs.Text = dataGridView1.Rows[VT].Cells[3].Value.ToString();
                    suaten.ReadOnly = false;
                    suahs.ReadOnly = false;

            }
            catch (Exception e) { }
          
        }
        public void txtHeSo_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            QuanLyLuongEntities db = new QuanLyLuongEntities();
            string macv = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         
            if (suaten.Text != "" && suahs.Text != "")
            {
                _chucvu.MaChucVu = macv;
                _chucvu.TenChucVu = suaten.Text;
                _chucvu.HeSoCV = Convert.ToDouble(suahs.Text);
                if (_bizchucvu.BizTimKiem(_chucvu) == true)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

                db.SaveChanges();
                load();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!!");
            }
        
            
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (txttimma.Text == "" && txttimten.Text == "" && txttimhs.Text == "")
            {
                load();
            }
            else
            {
                string ma = txttimma.Text;
                string ten = txttimten.Text;
                string heso = txttimhs.Text;
                dataGridView1.DataSource = _bizchucvu.TimKiem(ma,ten,heso);
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cần tìm !!");
                }

            }
        }
        private void btthemmoi_Click(object sender, EventArgs e)
        {
            ThemChucVu themcv = new ThemChucVu();
            themcv.Show();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = dataGridView1.CurrentCell.RowIndex;
            if(VT > -1)
                loadCV(VT);
        }

        private void btkhoitao_Click(object sender, EventArgs e)
        {
            suaten.Text = "";
            suahs.Text = "";
            txttimma.Text = "";
            txttimten.Text = "";
            txttimhs.Text = "";
            load();
        }

        private void QuanLyChucVu_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                load();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
