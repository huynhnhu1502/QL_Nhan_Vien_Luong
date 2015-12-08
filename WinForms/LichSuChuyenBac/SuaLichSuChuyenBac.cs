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
    public partial class SuaLichSuChuyenBac : Form
    {
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_LichSuChuyenBac _bizlichsucb = new _3Layer.BIZ.BIZ_LichSuChuyenBac();
        _3Layer.LichSuChuyenBac _lichsuchuyenbac = new _3Layer.LichSuChuyenBac();
        public SuaLichSuChuyenBac()
        {
            InitializeComponent();
        }
        public void Laydulieu(TextBox txtForm1)
        {
            txtmnv.Text = txtForm1.Text;
        }
        public void Layma(TextBox layma )
        {
            txtid.Text = layma.Text;
        }
        public void loadcb ()
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

        private void SuaLichSuChuyenBac_Load(object sender, EventArgs e)
        {
            loadcb();
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

        private void btsua_Click(object sender, EventArgs e)
        {
            if (cbngach.SelectedItem.ToString() == "----Tất cả----")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            { 
                var cv = db.NhanViens.ToList();
                foreach (var item in cv)
                {
                    if (item.MaNV == txtmnv.Text && item.MaHeSo == cbheso.SelectedValue.ToString() && item.MaNgach == cbngach.SelectedValue.ToString())
                    {
                        MessageBox.Show("Nhân viên đang đạt hệ số này!!");
                        return;
                    }
                }
                _3Layer.NgachLuong LDV = (_3Layer.NgachLuong)cbngach.SelectedItem;
                string mangach = LDV.MaNgach;
                _lichsuchuyenbac.id = int.Parse(txtid.Text.Trim());
                _lichsuchuyenbac.MaNV = txtmnv.Text.Trim();
                _lichsuchuyenbac.Mangach = mangach;
                _lichsuchuyenbac.MaHeSo = cbheso.SelectedValue.ToString();
                _lichsuchuyenbac.NgayChuyen = Convert.ToDateTime(dateTimePicker1.Text.Trim());

                if (_bizlichsucb.SuaLichSu(_lichsuchuyenbac) == true)
                {

                    MessageBox.Show("Sửa thành công");
                    

                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
