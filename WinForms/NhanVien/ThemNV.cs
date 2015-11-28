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
    public partial class ThemNV : Form
    {
        _3Layer.NhanVien nv = new _3Layer.NhanVien();
        _3Layer.BIZ.BIZ_NV biz = new _3Layer.BIZ.BIZ_NV();
        QuanLyLuongEntities1 _db11 = new QuanLyLuongEntities1();
        public ThemNV()
        {
            InitializeComponent();           
            loadcb();
            autoMaNV();
            lbErr.Visible = false;
        }
        public void loadcb()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            var result1 = from a in _db11.DonVis select a;
            var result2 = from a in _db11.ChucVus select a;
            comboBox1.DataSource = result1.ToList();
            comboBox1.ValueMember = "MaDonVi";
            comboBox1.DisplayMember = "TenDonVi";
            comboBox2.DataSource = result2.ToList();
            comboBox2.ValueMember = "MaChucVu";
            comboBox2.DisplayMember = "TenChucVu";
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
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool flag = true;
            nv.MaNV = txtMaNV.Text.Trim();
            nv.HoTen = txtHoTen.Text.Trim();
            nv.MaDonVi = comboBox1.SelectedValue.ToString();
            nv.MaChucVu = comboBox2.SelectedValue.ToString();
            nv.DanToc = txtDT.Text.Trim();
            nv.DiaChi = txtDC.Text.Trim();
            nv.NgayBatDau = Convert.ToDateTime(dateTimePicker3.Text.Trim());
            nv.NgayHuu = Convert.ToDateTime(dateTimePicker2.Text.Trim());
            nv.NgaySinh = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            nv.NgayNghi = Convert.ToDateTime(dateTimePicker4.Text.Trim());
            nv.HinhAnh =System.IO.Path.GetFileName(ofd.FileName);
            if (nv.HoTen == "" || nv.DanToc == "" || nv.DiaChi == "" || ofd.CheckFileExists == false || comboBox3.SelectedIndex == -1)
            {
                flag = false;
                lbErr.Visible = true;
                lbErr.Text = "Nhập đầy đủ và chọn hình ảnh đại diện";
            }
            if (flag)
            {
                nv.GioiTinh = comboBox3.SelectedItem.ToString();
                if (!Directory.Exists(@"~/Image"))
                {
                    Directory.CreateDirectory(@"~/Image");
                    if (!File.Exists(@"~/Image/" + ofd.SafeFileName))
                    {
                        File.Copy(ofd.FileName, @"~/Image/" + ofd.SafeFileName);
                    }
                    else
                    {
                        File.Copy(ofd.FileName, @"~/Image/" + ofd.SafeFileName + RandomString(4) + ".jpg");
                    }
                }
                else
                {
                    if (!File.Exists(@"~/Image/" + ofd.SafeFileName))
                    {
                        File.Copy(ofd.FileName, @"~/Image/" + ofd.SafeFileName);
                    }
                    else
                    {
                        File.Copy(ofd.FileName, @"~/Image/" + ofd.SafeFileName + RandomString(4) + ".jpg");
                    }
                }
                if (biz.Create(nv) == true)
                {
                    MessageBox.Show("Đã thêm!");
                    this.Close();
                    Form a = new NhanVien();
                    a.Show();
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
            comboBox1.Text = "";
            comboBox2.Text = "";
            txtDT.Text = "";
            txtDC.Text = "";
            pictureBox1.Image = null;
            
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void autoMaNV()
        {
            int idhientai;
            int countid = (from u in _db11.NhanViens select new { u.id }).Count();
            if (countid == 0)
            {
                idhientai = 0;
                int idthemvao = idhientai + 1;
                txtMaNV.Text = "NV00" + idthemvao;
            }
            else
            {
                idhientai = _db11.NhanViens.Max(a => a.id);
                int idthemvao = idhientai + 1;
                txtMaNV.Text = "NV00" + idthemvao;
            }
        }
    }
}
