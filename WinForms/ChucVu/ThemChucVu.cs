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

namespace WinForms.ChucVu
{
    public partial class ThemChucVu : Form
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_ChucVu _bizchucvu = new _3Layer.BIZ.BIZ_ChucVu();
        _3Layer.ChucVu _chucvu = new _3Layer.ChucVu();
        public ThemChucVu()
        {
            InitializeComponent();
            autoMaCV();

        }

        public void autoMaCV()
        {
            int idhientai;
            int countid = (from u in db.ChucVus select new { u.id }).Count();
            if (countid == 0)
            {
                idhientai = 0;
                int idthemvao = idhientai + 1;
                txtmacv.Text = "CV00" + idthemvao;

            }
            else
            {
                //idhientai = db.ChucVus.Max(a => a.id);
                int idthemvao = countid + 1;
                if (idthemvao < 10)
                    txtmacv.Text = "CV00" + idthemvao;
                else if (idthemvao >= 10 && countid < 100)
                    txtmacv.Text = "CV0" + idthemvao;
                else if (idthemvao >= 100)
                    txtmacv.Text = "CV" + idthemvao;
            }
        }
        public void txtheso_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
        private void btthem_Click(object sender, EventArgs e)
        {

            if (_chucvu.MaChucVu == "" || _chucvu.TenChucVu == "" || txtheso.Text.Trim() == "")
            {
               
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            var cv = db.ChucVus.ToList();
            foreach (var item in cv)
            {
                if (item.TenChucVu == txttencv.Text)
                {
                    MessageBox.Show("Tên chức vụ bị trùng");
                    return;
                }
            }
            
            _chucvu.MaChucVu = txtmacv.Text.Trim();
            _chucvu.TenChucVu = txttencv.Text.Trim();
            _chucvu.HeSoCV = double.Parse(txtheso.Text.Trim());

            if (_bizchucvu.ThemCV(_chucvu) == true)
            {
                MessageBox.Show("Thêm thành công");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }


        private void btxoa_Click(object sender, EventArgs e)
        {
            txttencv.Text = "";
            txtheso.Text = "";

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
