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

namespace WinForms
{
    public partial class ThongKeNhanVienTheoDonVi : Form
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        public ThongKeNhanVienTheoDonVi()
        {
            InitializeComponent();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadlencb();
        }

        private void ThongKeNhanVienTheoDonVi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLuongDataSet3.DonVi' table. You can move, or remove it, as needed.
            this.donViTableAdapter.Fill(this.quanLyLuongDataSet3.DonVi);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    string MaDV = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    int count = (from u in _db.NhanViens where u.MaDonVi == MaDV select u).Count();
                    dataGridView1.Rows[i].Cells[2].Value = count.ToString();
                    dataGridView1.Rows[i].Cells[3].Value = "Danh sách nhân viên";
                }
            }
        }
        public void loadlencb()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            var result = (from u in _db.DonVis select u);
            comboBox1.DataSource = result.ToList();
            comboBox1.ValueMember = "MaDonVi";
            comboBox1.DisplayMember = "TenDonVi";
        }
    }
}
