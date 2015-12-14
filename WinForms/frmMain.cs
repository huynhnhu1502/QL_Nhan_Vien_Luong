using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                frm_NhanVien nv = new frm_NhanVien();
                nv.TopLevel = false;
                nv.Size = panel1.Size;
                nv.AutoScroll = true;
                panel1.Controls.Add(nv);
                nv.Show();
            }
            if (listBox1.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                DonVi dv = new DonVi();
                dv.TopLevel = false;
                dv.AutoScroll = true;
                dv.Size = panel1.Size;
                panel1.Controls.Add(dv);
                dv.Show();
            }
            if (listBox1.SelectedIndex == 2)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                LoaiDonVi ldv = new LoaiDonVi();
                ldv.TopLevel = false;
                ldv.AutoScroll = true;
                ldv.Size = panel1.Size;
                panel1.Controls.Add(ldv);
                ldv.Show();
            }

            if (listBox1.SelectedIndex == 3)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                DanhMuc_NgachLuong.frm_NgachLuong ngach = new DanhMuc_NgachLuong.frm_NgachLuong();
                ngach.TopLevel = false;
                ngach.AutoScroll = true;
                ngach.Size = panel1.Size;
                panel1.Controls.Add(ngach);
                ngach.Show();
            }

            if (listBox1.SelectedIndex == 4)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                DanhMuc_HeSoLuong.frm_HeSoLuong hsl = new DanhMuc_HeSoLuong.frm_HeSoLuong();
                hsl.TopLevel = false;
                hsl.AutoScroll = true;
                hsl.Size = panel1.Size;
                panel1.Controls.Add(hsl);
                hsl.Show();
            }

            if (listBox1.SelectedIndex == 5)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                ChucVu.QuanLyChucVu cv = new ChucVu.QuanLyChucVu();
                cv.TopLevel = false;
                cv.AutoScroll = true;
                cv.Size = panel1.Size;
                panel1.Controls.Add(cv);
                cv.Show();
            }

            if (listBox1.SelectedIndex == 6)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                LSCongTac.frmLichSuCongTac lsct = new LSCongTac.frmLichSuCongTac();
                lsct.TopLevel = false;
                lsct.AutoScroll = true;
                lsct.Size = panel1.Size;
                panel1.Controls.Add(lsct);
                lsct.Show();
            }

            if (listBox1.SelectedIndex == 7)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                LichSuChuyenBac.DSChuyenBac lscb = new LichSuChuyenBac.DSChuyenBac();
                lscb.TopLevel = false;
                lscb.AutoScroll = true;
                lscb.Size = panel1.Size;
                panel1.Controls.Add(lscb);
                lscb.Show();
            }
        }
    }
}
