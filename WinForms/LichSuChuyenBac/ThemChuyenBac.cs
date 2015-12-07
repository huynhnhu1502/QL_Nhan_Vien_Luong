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
        _3Layer.BIZ.BIZ_LichSuChuyenBac _bizlichsucb = new _3Layer.BIZ.BIZ_LichSuChuyenBac();
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
            List<_3Layer.NgachLuong> dsLDV = _bizlichsucb.BIZLayNgach();
            cbngach.Items.Add("----Tất cả----");
            foreach (_3Layer.NgachLuong item in dsLDV)
            {
                cbngach.Items.Add(item);
            }
            //cbDonVi.DataSource = dsDV;
            cbngach.DisplayMember = "TenNgach";
            cbngach.ValueMember = "MaNgach";
            cbngach.SelectedIndex = 0;

            if (cbngach.SelectedItem.ToString() == "----Tất cả----")
            {
                cbheso.Enabled = false;
            }
            else
            {
                cbheso.Enabled = true;
                _3Layer.NgachLuong LDV = (_3Layer.NgachLuong)cbngach.SelectedItem;
                string mangach = LDV.MaNgach;
                var danhsach2 = from a in db.HeSoLuongPhuCaps where mangach == a.MaNgach select a;
                cbheso.DataSource = danhsach2.ToList();
                cbheso.ValueMember = "MaHeSo";
                cbheso.DisplayMember = "TenHeSo";
            }

        }

        private void cbngach_thaydoi(object sender, EventArgs e)
        {
            if (cbngach.SelectedItem.ToString() == "----Tất cả----")
            {
                cbheso.Enabled = false;
            }
            else
            {
                cbheso.Enabled = true;
                _3Layer.NgachLuong LDV = (_3Layer.NgachLuong)cbngach.SelectedItem;
                string mangach = LDV.MaNgach;
                var danhsach2 = from a in db.HeSoLuongPhuCaps where mangach == a.MaNgach select a;
                cbheso.DataSource = danhsach2.ToList();
                cbheso.ValueMember = "MaHeSo";
                cbheso.DisplayMember = "TenHeSo";
            }
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
                if (item.MaNV == txtmanv.Text && item.MaHeSo == cbheso.SelectedValue.ToString() && item.MaNgach == cbngach.SelectedValue.ToString())
                {
                    MessageBox.Show("Nhân viên đang đạt hệ số này!!");
                    return;
                }
            }
               _3Layer.NgachLuong LDV = (_3Layer.NgachLuong)cbngach.SelectedItem;
                string mangach = LDV.MaNgach;
               _lichsuchuyenbac.MaNV = txtmanv.Text.Trim();
               _lichsuchuyenbac.Mangach = mangach;
               _lichsuchuyenbac.MaHeSo = cbheso.SelectedValue.ToString();
               _lichsuchuyenbac.NgayChuyen = Convert.ToDateTime(dateTimePicker1.Text.Trim());

                if (_bizlichsucb.ThemLichSu(_lichsuchuyenbac) == true)
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
