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
using System.IO;

namespace WinForms
{
    public partial class frmThemNV : Form
    {
        _3Layer.NhanVien nv = new _3Layer.NhanVien();
        _3Layer.BIZ.BIZ_NV biz = new _3Layer.BIZ.BIZ_NV();
        QuanLyLuongEntities _db11 = new QuanLyLuongEntities();
        int counthieutruong;
        public frmThemNV()
        {
            InitializeComponent();
            lbErr.Visible = false;
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            ofd.Title = "Thêm Ảnh";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picNV.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                nv.MaNV = biz.BIZ_TaoMaNV();
                nv.HoTen = txtHoTen.Text.Trim();
                nv.MaNgach = cbNgach.SelectedValue.ToString();
                nv.DanToc = txtDanToc.Text.Trim();
                nv.DiaChi = txtDiaChi.Text.Trim();
                nv.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text.Trim());
                nv.HinhAnh = System.IO.Path.GetFileName(ofd.FileName);
                nv.CMND = txtCMND.Text.Trim();
                nv.NgayHuu = biz.BIZ_TinhNgayHuu(dateNgaySinh.Value, cbGioiTinh.SelectedItem.ToString());

                if (nv.HoTen == "" || nv.DanToc == "" || nv.DiaChi == "" || ofd.CheckFileExists == false || cbGioiTinh.SelectedIndex == -1 || nv.CMND == "")
                {
                    flag = false;
                    lbErr.Visible = true;
                    lbErr.Text = "Nhập đầy đủ và chọn hình ảnh đại diện";
                }
                if (flag)
                {
                    nv.GioiTinh = cbGioiTinh.SelectedItem.ToString();
                    if (!Directory.Exists(@"../../../Webform/Images"))
                    {
                        Directory.CreateDirectory(@"../../../Webform/Images");
                        if (!File.Exists(@"../../../Webform/Images/" + ofd.SafeFileName))
                        {
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + ofd.SafeFileName);
                        }
                        else
                        {
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + ofd.SafeFileName + RandomString(4) + ".jpg");
                        }
                    }
                    else
                    {
                        if (!File.Exists(@"../../../Webform/Images/" + ofd.SafeFileName))
                        {
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + ofd.SafeFileName);
                        }
                        else
                        {
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + ofd.SafeFileName + RandomString(4) + ".jpg");
                        }
                    }
                    if (biz.Create(nv) == true)
                    {
                        MessageBox.Show("Đã thêm!");
                        txtHoTen.Text = "";
                        txtDanToc.Text = "";
                        txtDiaChi.Text = "";
                        txtCMND.Text = "";
                        picNV.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtDanToc.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            picNV.Image = null;            
        }       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            try
            {
                cbGioiTinh.SelectedIndex = 0;
                List<NgachLuong> list = biz.BIZ_LayDLNgachLuong();
                cbNgach.DataSource = list;
                cbNgach.ValueMember = "MaNgach";
                cbNgach.DisplayMember = "TenNgach";
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        
    }
}
