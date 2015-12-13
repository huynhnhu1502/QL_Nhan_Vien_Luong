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
            loadcb();
            lbErr.Visible = false;
        }
        public void loadcb()
        {
            counthieutruong = (from u in _db11.NhanViens where u.MaChucVu == "CV001" select u).Count();
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNgach.DropDownStyle = ComboBoxStyle.DropDownList;
            var result1 = from a in _db11.DonVis select a;
            var result2 = from a in _db11.ChucVus select a;
            //comboBox1.DataSource = result1.ToList();
            //comboBox1.ValueMember = "MaDonVi";
            //comboBox1.DisplayMember = "TenDonVi";
            var result133 = from a in _db11.NgachLuongs select a;
            cbNgach.DataSource = result133.ToList();
            cbNgach.ValueMember = "MaNgach";
            cbNgach.DisplayMember = "TenNgach";
            if (counthieutruong == 0)
            {
                //comboBox2.DataSource = result2.ToList();
                //comboBox2.ValueMember = "MaChucVu";
                //comboBox2.DisplayMember = "TenChucVu";
            }
            else
            {
                var resultnohieutruong = from a in _db11.ChucVus where a.TenChucVu != "Hiệu trưởng" select a;
                //comboBox2.DataSource = resultnohieutruong.ToList();
                //comboBox2.ValueMember = "MaChucVu";
                //comboBox2.DisplayMember = "TenChucVu";
            }
        }
        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
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
            bool flag = true;
            //nv.MaNV = txtMaNV.Text.Trim();
            nv.HoTen = txtHoTen.Text.Trim();
            //nv.MaDonVi = comboBox1.SelectedValue.ToString();
            //nv.MaChucVu = comboBox2.SelectedValue.ToString();
            nv.MaNgach = cbNgach.SelectedValue.ToString();
            nv.DanToc = txtDanToc.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            //nv.NgayBatDau = Convert.ToDateTime(dateTimePicker3.Text.Trim());
            //nv.NgayHuu = Convert.ToDateTime(dateTimePicker2.Text.Trim());
            nv.NgaySinh = Convert.ToDateTime(dateNgaySinh.Text.Trim());
            //nv.NgayNghi = Convert.ToDateTime(dateTimePicker4.Text.Trim());
            nv.HinhAnh =System.IO.Path.GetFileName(ofd.FileName);
            nv.CMND = txtCMND.Text.Trim();
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
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            //comboBox1.Text = "";
            //comboBox2.Text = "";
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
        public void reset()
        {
            txtHoTen.Text = "";
            //comboBox1.Text = "";
            //comboBox2.Text = "";
            txtDanToc.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            picNV.Image = null;
        }


    }
}
