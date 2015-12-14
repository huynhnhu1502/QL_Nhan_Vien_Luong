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
using _3Layer.BIZ;
using System.IO;

namespace WinForms.NhanVien
{
    public partial class frm_SuaNhanVien : Form
    {
        BIZ_NV bizNV = new BIZ_NV();
        string MaSua;
        _3Layer.NhanVien nhanVien;
        OpenFileDialog ofd = new OpenFileDialog();
        private static Random random = new Random((int)DateTime.Now.Ticks);

        public frm_SuaNhanVien(string maSua)
        {
            this.MaSua = maSua;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_SuaNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                //Lấy thông tin sửa
                nhanVien = bizNV.BIZ_TimNhanVienTheoMa(MaSua);

                //OpenFileDialog ofd = new OpenFileDialog();
                if (File.Exists(@"../../../Webform/Images/" + nhanVien.HinhAnh))
                    picNV.Image = Image.FromFile(@"../../../Webform/Images/" + nhanVien.HinhAnh);
                txtMaNV.Text = nhanVien.MaNV;
                txtHoTen.Text = nhanVien.HoTen;
                cbGioiTinh.SelectedItem = nhanVien.GioiTinh;
                if(nhanVien.NgaySinh != null)
                {
                    DateTime ngaySinh = nhanVien.NgaySinh;
                    dateNgaySinh.Value = ngaySinh;
                }
                txtDanToc.Text = nhanVien.DanToc;
                txtDiaChi.Text = nhanVien.DiaChi;
                txtCMND.Text = nhanVien.CMND;
                if(nhanVien.NgayNghi != null)
                {
                    DateTime ngayNghi = nhanVien.NgayNghi.Value;
                    dateNgayNghi.Value = ngayNghi;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            ofd.Title = "Thêm Ảnh";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picNV.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoTen = txtHoTen.Text;
            string gioiTinh = cbGioiTinh.SelectedItem.ToString();
            DateTime ngaySinh = dateNgaySinh.Value.Date;
            string danToc = txtDanToc.Text;
            string diaChi = txtDiaChi.Text;
            string cmnd = txtCMND.Text;
            DateTime ngayNghi = dateNgayNghi.Value.Date;

            int soCMND;

            if(txtHoTen.Text.Trim()=="" || cbGioiTinh.SelectedIndex==-1 || txtDanToc.Text.Trim()=="" || txtDiaChi.Text.Trim()=="" || txtDiaChi.Text.Trim()=="" || txtCMND.Text.Trim()=="")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin!");
            }
            else if(int.TryParse(txtCMND.Text, out soCMND) == false && txtCMND.Text != "")
            {
                MessageBox.Show("CMND là một số!");
            }
            else if(txtCMND.Text.Count() != 9)
            {
                MessageBox.Show("CMND phải có 9 chữ số!");
            }
            else
            {
                nhanVien.HoTen = hoTen;
                nhanVien.GioiTinh = gioiTinh;
                nhanVien.NgaySinh = ngaySinh;
                nhanVien.DanToc = danToc;
                nhanVien.DiaChi = diaChi;
                nhanVien.CMND = cmnd;
                nhanVien.NgayNghi = ngayNghi;
                if(ofd.FileName != "")
                {
                    if (!Directory.Exists(@"../../../Webform/Images"))
                    {
                        Directory.CreateDirectory(@"../../../Webform/Images");
                        if (!File.Exists(@"../../../Webform/Images/" + ofd.SafeFileName))
                        {
                            nhanVien.HinhAnh = ofd.SafeFileName;
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + ofd.SafeFileName);
                        }
                        else
                        {
                            nhanVien.HinhAnh = RandomString(4) + ofd.SafeFileName;
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + nhanVien.HinhAnh);
                        }
                    }
                    else
                    {
                        if (!File.Exists(@"../../../Webform/Images/" + ofd.SafeFileName))
                        {
                            nhanVien.HinhAnh = ofd.SafeFileName;
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + ofd.SafeFileName);
                        }
                        else
                        {
                            nhanVien.HinhAnh = RandomString(4) + ofd.SafeFileName;
                            File.Copy(ofd.FileName, @"../../../Webform/Images/" + nhanVien.HinhAnh);
                        }
                    }
                }

                if (bizNV.BIZ_SuaNhanVien(nhanVien))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Không sửa được!");
                }
            }
        }

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
    }
}
