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
                NhanVien nv = new NhanVien();
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
                ChucVu.QuanLyChucVu dv = new ChucVu.QuanLyChucVu();
                dv.TopLevel = false;
                dv.AutoScroll = true;
                dv.Size = panel1.Size;
                panel1.Controls.Add(dv);
                dv.Show();
            }

            if (listBox1.SelectedIndex == 4)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                LichSuChuyenBac.DSChuyenBac dscb = new LichSuChuyenBac.DSChuyenBac();
                dscb.TopLevel = false;
                dscb.AutoScroll = true;
                dscb.Size = panel1.Size;
                panel1.Controls.Add(dscb);
                dscb.Show();
            }

            if (listBox1.SelectedIndex == 5)
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                ThongKeNhanVienTheoDonVi tknv = new ThongKeNhanVienTheoDonVi();
                tknv.TopLevel = false;
                tknv.AutoScroll = true;
                tknv.Size = panel1.Size;
                panel1.Controls.Add(tknv);
                tknv.Show();
            }
        }
    }
}
