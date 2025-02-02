﻿using System;
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
    public partial class ThemLoaiDV : Form
    {
        QuanLyLuongEntities _db = new QuanLyLuongEntities();
        _3Layer.BIZ.BIZ_LoaiDonVi _bizloaidv = new _3Layer.BIZ.BIZ_LoaiDonVi();
        _3Layer.LoaiDonVi _loaidv = new _3Layer.LoaiDonVi();
        public ThemLoaiDV()
        {
            InitializeComponent();
           
            autoMa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if ( txtTenLoai.Text == "")
            {

                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            _loaidv.MaLoai = txtMaLoai.Text.Trim();
            _loaidv.TenLoai = txtTenLoai.Text.Trim();
            _loaidv.MoTa = txtMoTa.Text.Trim();
            if (flag)
            {
                if (_bizloaidv.ThemLoai(_loaidv) == true)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        public void autoMa()
        {
            int idhientai;
            int countid = (from u in _db.LoaiDonVis select new { u.id }).Count();
            if (countid == 0)
            {
                idhientai = 0;
                int idthemvao = idhientai + 1;
                txtMaLoai.Text = "LDV00" + idthemvao;

            }
            else
            {
                idhientai = _db.LoaiDonVis.Max(a => a.id);
                int idthemvao = idhientai + 1;  
                if (idthemvao < 10)
                    txtMaLoai.Text = "LDV00" + idthemvao;
                else if (idthemvao >= 10 && countid < 100)
                    txtMaLoai.Text = "LDV0" + idthemvao;
                else if (idthemvao >= 100)
                    txtMaLoai.Text = "LDV" + idthemvao;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTenLoai.Text = "";
            txtMoTa.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
