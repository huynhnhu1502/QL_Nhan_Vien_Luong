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
            cbngach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbheso.DropDownStyle = ComboBoxStyle.DropDownList;
            var danhsach1 = _bizlichsucb.BIZLayNgach();
            cbngach.DataSource = danhsach1.ToList();
            cbngach.ValueMember = "MaNgach";
            cbngach.DisplayMember = "TenNgach";

            var mn = cbngach.SelectedValue.ToString();
            var danhsach2 = from a in db.HeSoLuongPhuCaps where mn == a.MaNgach select a;
            cbheso.DataSource = danhsach2.ToList();
            cbheso.ValueMember = "MaHeSo";
            cbheso.DisplayMember = "TenHeSo";

        }

        private void SuaLichSuChuyenBac_Load(object sender, EventArgs e)
        {
            loadcb();
        }

        private void cbngach_thaydoi(object sender, EventArgs e)
        {
            var mn = cbngach.SelectedValue.ToString();
            var danhsach2 = from a in db.HeSoLuongPhuCaps where mn == a.MaNgach select a;
            cbheso.DataSource = danhsach2.ToList();
            cbheso.ValueMember = "MaHeSo";
            cbheso.DisplayMember = "TenHeSo";
        }

        private void btsua_Click(object sender, EventArgs e)
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
            _lichsuchuyenbac.id = int.Parse(txtid.Text.Trim());
            _lichsuchuyenbac.MaNV = txtmnv.Text.Trim();
            _lichsuchuyenbac.Mangach = cbngach.SelectedValue.ToString();
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
}
