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
using _3Layer.DAL;
using _3Layer.BIZ;

namespace WinForms.LichSuChuyenBac
{
    public partial class DSChuyenBac : Form
    {
        _3Layer.BIZ.BIZ_LichSuChuyenBac _bizlichsucb = new _3Layer.BIZ.BIZ_LichSuChuyenBac();
        _3Layer.LichSuChuyenBac _lichsucb = new _3Layer.LichSuChuyenBac();
        QuanLyLuongEntities db = new QuanLyLuongEntities();
        public DSChuyenBac()
        {
            InitializeComponent();
        }
        public void load()
        {
            DateTime dt = new DateTime(1994, 1, 1);
            dtp1.MinDate = dt;
            dtp2.MinDate = dt;
            dtp1.Value = dtp1.MinDate;
            dtp2.Value = dtp1.MinDate;

            dtp1.CustomFormat = " ";
            dtp1.Format = DateTimePickerFormat.Custom;
            

            dtp2.CustomFormat = " ";
            dtp2.Format = DateTimePickerFormat.Custom;
            

            dataGridView1.DataSource = _bizlichsucb.BIZLayDS();                
        }
        
        private void dtp1_ValueChanged(Object sender, EventArgs e)
        {
            dtp1.CustomFormat = "dd/MM/yyyy";
        }
        private void dtp2_ValueChanged(Object sender, EventArgs e)
        {
            dtp2.CustomFormat = "dd/MM/yyyy";
        }
        private void DSChuyenBac_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "" && dtp1.Value == dtp1.MinDate && dtp2.Value == dtp2.MinDate)
            {
                dataGridView1.DataSource = DAL_LichSuChuyenBac.listall();
            }

            if (dtp1.Value!=dtp1.MinDate || dtp2.Value == dtp2.MinDate)
            {
                string ten = txtmanv.Text.Trim();              
                string ngay1 = dtp1.Value.Month + "/" + dtp1.Value.Day + "/" + dtp1.Value.Year;
                string ngay2 = dtp2.Value.Month + "/" + dtp2.Value.Day + "/" + dtp2.Value.Year;
                if (dtp2.Value == dtp2.MinDate) ngay2 = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
                //DAL_LichSuChuyenBac.timkiem(ten, ngay1, ngay2);
                DateTime dt = new DateTime(1994, 1, 1);
                if (dtp1.Value > dtp2.Value && dtp2.Value != dt )
                {
                    MessageBox.Show("Từ ngày phải nhỏ hơn đến ngày !!");
                }
             
                else

                dataGridView1.DataSource = _bizlichsucb.BIZTimLSChuyenBac(ten, ngay1, ngay2);
                 if(dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cần tìm !!");
                }          

            }
                   
        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            dtp1.CustomFormat = " ";
            dtp1.Format = DateTimePickerFormat.Custom;

            dtp2.CustomFormat = " ";
            dtp2.Format = DateTimePickerFormat.Custom;

            txtmanv.Text = "";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadTT(int VT)
        {

            try
            {
                txtttma.Text = dataGridView1.Rows[VT].Cells[1].Value.ToString();
                txtttngach.Text = dataGridView1.Rows[VT].Cells[6].Value.ToString();
                txttths.Text = dataGridView1.Rows[VT].Cells[5].Value.ToString();
                
            }
            catch (Exception e) { }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int VT = dataGridView1.CurrentCell.RowIndex;
            loadTT(VT);
        }

        private void btchuyenbac_Click(object sender, EventArgs e)
        {
            if(txttths.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn chuyển bậc!");
            }
            else
            { 
            ThemChuyenBac frmthem = new ThemChuyenBac();
            delPassData del = new delPassData(frmthem.Laydulieu);
            del(this.txtttma);
            frmthem.Show();
            }
        }
        public delegate void delPassData(TextBox text);
    }
}
