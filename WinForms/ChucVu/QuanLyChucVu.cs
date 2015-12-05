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
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //Sửa  
            //Xác định thanh viên cần sửa  
            var chucvu = (from n in db.ChucVus
                             where n.id == id//Chọn thành viên nào có tên giống tên nhập vào  
                             select n
                            ).SingleOrDefault();
            chucvu.TenChucVu= suaten.Text;
            chucvu.HeSoCV = double.Parse(this.suahs.Text);
           

            db.SaveChanges();
            load();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            _chucvu.MaChucVu = txttimma.Text.Trim(); 
            _chucvu.TenChucVu = txttimten.Text.Trim();
            if(txttimhs.Text.Trim()=="")
            {
                var result = (from u in db.ChucVus where u.MaChucVu.Contains(_chucvu.MaChucVu) && u.TenChucVu.Contains(_chucvu.TenChucVu)  select u).ToList();
                dataGridView1.DataSource = result;
            }
            else
            {
                _chucvu.HeSoCV = double.Parse(txttimhs.Text.Trim());
                
                if (_bizchucvu.TimKiem(_chucvu) == true)
                {
                    var result = (from u in db.ChucVus where u.MaChucVu.Contains(_chucvu.MaChucVu) && u.TenChucVu.Contains(_chucvu.TenChucVu) &&u.HeSoCV ==_chucvu.HeSoCV select u).ToList();
                    dataGridView1.DataSource = result;
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
