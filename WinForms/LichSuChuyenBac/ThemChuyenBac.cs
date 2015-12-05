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

namespace WinForms.LichSuChuyenBac
{
    public partial class ThemChuyenBac : Form
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_LichSuChuyenBac _bizchucvu = new _3Layer.BIZ.BIZ_LichSuChuyenBac();
        _3Layer.LichSuChuyenBac _lichsuchuyenbac = new _3Layer.LichSuChuyenBac();
        public ThemChuyenBac()
        {
            InitializeComponent();
            loadcb();
        }

        public void Laydulieu(TextBox txtForm1)
        {
             txtmanv.Text = txtForm1.Text; 
        }
        public void loadcb()
        {
            cbngach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbhs.DropDownStyle = ComboBoxStyle.DropDownList;
            var danhsach1 = _bizchucvu.BIZLayNgach();
            cbngach.DataSource = danhsach1.ToList();
            cbngach.ValueMember = "MaNgach";
            cbngach.DisplayMember = "TenNgach";

            var mn = cbngach.SelectedValue.ToString();
            var danhsach2 = from a in db.HeSoLuongPhuCaps where mn == a.MaNgach select a;
            cbhs.DataSource = danhsach2.ToList();
            cbhs.ValueMember = "MaHeSo";
            cbhs.DisplayMember = "TenHeSo";
            
        }

        private void cbngach_thaydoi(object sender, EventArgs e)
        {
            var mn = cbngach.SelectedValue.ToString();
            var danhsach2 = from a in db.HeSoLuongPhuCaps where mn == a.MaNgach select a;
            cbhs.DataSource = danhsach2.ToList();
            cbhs.ValueMember = "MaHeSo";
            cbhs.DisplayMember = "TenHeSo";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtp1_ValueChanged(Object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }
        private void btluu_Click(object sender, EventArgs e)
        {

            var cv = db.NhanViens.ToList();
            foreach (var item in cv)
            {
                if (item.MaNV == txtmanv.Text && item.MaHeSo == cbhs.SelectedValue.ToString() && item.MaNgach == cbngach.SelectedValue.ToString())
                {
                    MessageBox.Show("Nhân viên đang đạt hệ số này!!");
                    return;
                }
            }

            _lichsuchuyenbac.MaNV = txtmanv.Text.Trim();
                _lichsuchuyenbac.Mangach = cbngach.SelectedValue.ToString();
                _lichsuchuyenbac.MaHeSo = cbhs.SelectedValue.ToString();
                _lichsuchuyenbac.NgayChuyen = Convert.ToDateTime(dateTimePicker1.Text.Trim());

                if (_bizchucvu.ThemLichSu(_lichsuchuyenbac) == true)
                {
                    MessageBox.Show("Thêm thành công");

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            
        }
    }
    

}
