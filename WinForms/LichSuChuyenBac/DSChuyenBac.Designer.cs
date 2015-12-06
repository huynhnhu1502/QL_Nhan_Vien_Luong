namespace WinForms.LichSuChuyenBac
{
    partial class DSChuyenBac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btload = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btthoat = new System.Windows.Forms.Button();
            this.btnhaplai = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.lbdenngay = new System.Windows.Forms.Label();
            this.lbtungay = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.btchuyenbac = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNgach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNgach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NienHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hslpc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaychuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbds = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.txttths = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtttngach = new System.Windows.Forms.TextBox();
            this.txtttma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btload);
            this.groupBox1.Controls.Add(this.dtp2);
            this.groupBox1.Controls.Add(this.dtp1);
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.btnhaplai);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Controls.Add(this.lbdenngay);
            this.groupBox1.Controls.Add(this.lbtungay);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.lbMaNV);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // btload
            // 
            this.btload.Location = new System.Drawing.Point(756, 59);
            this.btload.Name = "btload";
            this.btload.Size = new System.Drawing.Size(75, 23);
            this.btload.TabIndex = 13;
            this.btload.Text = "Tải Lại";
            this.btload.UseVisualStyleBackColor = true;
            this.btload.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(511, 20);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(180, 20);
            this.dtp2.TabIndex = 11;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.CustomFormat = "";
            this.dtp1.Location = new System.Drawing.Point(264, 20);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(183, 20);
            this.dtp1.TabIndex = 10;
            this.dtp1.Value = new System.DateTime(2015, 12, 3, 22, 4, 1, 0);
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(656, 59);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 9;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btnhaplai
            // 
            this.btnhaplai.Location = new System.Drawing.Point(555, 59);
            this.btnhaplai.Name = "btnhaplai";
            this.btnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnhaplai.TabIndex = 8;
            this.btnhaplai.Text = "Nhập Lại";
            this.btnhaplai.UseVisualStyleBackColor = true;
            this.btnhaplai.Click += new System.EventHandler(this.btnhaplai_Click);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(456, 59);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 23);
            this.bttim.TabIndex = 7;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // lbdenngay
            // 
            this.lbdenngay.AutoSize = true;
            this.lbdenngay.Location = new System.Drawing.Point(453, 23);
            this.lbdenngay.Name = "lbdenngay";
            this.lbdenngay.Size = new System.Drawing.Size(56, 13);
            this.lbdenngay.TabIndex = 4;
            this.lbdenngay.Text = "Đến ngày:";
            // 
            // lbtungay
            // 
            this.lbtungay.AutoSize = true;
            this.lbtungay.Location = new System.Drawing.Point(219, 23);
            this.lbtungay.Name = "lbtungay";
            this.lbtungay.Size = new System.Drawing.Size(49, 13);
            this.lbtungay.TabIndex = 2;
            this.lbtungay.Text = "Từ ngày:";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(88, 20);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(125, 20);
            this.txtmanv.TabIndex = 1;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(6, 23);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(75, 13);
            this.lbMaNV.TabIndex = 0;
            this.lbMaNV.Text = "Mã Nhân Viên";
            // 
            // btchuyenbac
            // 
            this.btchuyenbac.Location = new System.Drawing.Point(656, 49);
            this.btchuyenbac.Name = "btchuyenbac";
            this.btchuyenbac.Size = new System.Drawing.Size(75, 23);
            this.btchuyenbac.TabIndex = 6;
            this.btchuyenbac.Text = "Chuyển Bậc";
            this.btchuyenbac.UseVisualStyleBackColor = true;
            this.btchuyenbac.Click += new System.EventHandler(this.btchuyenbac_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MaNV,
            this.TenNV,
            this.MaNgach,
            this.TenNgach,
            this.MaHS,
            this.NienHan,
            this.tenhs,
            this.HeSo,
            this.hslpc,
            this.nv,
            this.Ngaychuyen});
            this.dataGridView1.Location = new System.Drawing.Point(4, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(865, 218);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 170;
            // 
            // MaNgach
            // 
            this.MaNgach.DataPropertyName = "MaNgach";
            this.MaNgach.HeaderText = "Mã Ngạch";
            this.MaNgach.Name = "MaNgach";
            this.MaNgach.ReadOnly = true;
            this.MaNgach.Visible = false;
            // 
            // TenNgach
            // 
            this.TenNgach.DataPropertyName = "TenNgach";
            this.TenNgach.HeaderText = "Tên Ngạch";
            this.TenNgach.Name = "TenNgach";
            this.TenNgach.ReadOnly = true;
            this.TenNgach.Width = 150;
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHeSo";
            this.MaHS.HeaderText = "Mã Hệ Số";
            this.MaHS.Name = "MaHS";
            this.MaHS.ReadOnly = true;
            this.MaHS.Visible = false;
            // 
            // NienHan
            // 
            this.NienHan.DataPropertyName = "NienHan";
            this.NienHan.HeaderText = "Niên Hạn";
            this.NienHan.Name = "NienHan";
            this.NienHan.ReadOnly = true;
            // 
            // tenhs
            // 
            this.tenhs.DataPropertyName = "Tenheso";
            this.tenhs.HeaderText = "Tên hệ số";
            this.tenhs.Name = "tenhs";
            this.tenhs.ReadOnly = true;
            // 
            // HeSo
            // 
            this.HeSo.DataPropertyName = "Heso";
            this.HeSo.HeaderText = "Hệ Số";
            this.HeSo.Name = "HeSo";
            this.HeSo.ReadOnly = true;
            // 
            // hslpc
            // 
            this.hslpc.DataPropertyName = "HeSoLuongPhuCap";
            this.hslpc.HeaderText = "hslpc";
            this.hslpc.Name = "hslpc";
            this.hslpc.Visible = false;
            // 
            // nv
            // 
            this.nv.DataPropertyName = "NhanVien";
            this.nv.HeaderText = "nv";
            this.nv.Name = "nv";
            this.nv.Visible = false;
            // 
            // Ngaychuyen
            // 
            this.Ngaychuyen.DataPropertyName = "NgayChuyen";
            this.Ngaychuyen.HeaderText = "Ngày Chuyển";
            this.Ngaychuyen.Name = "Ngaychuyen";
            this.Ngaychuyen.ReadOnly = true;
            this.Ngaychuyen.Width = 110;
            // 
            // lbds
            // 
            this.lbds.AutoSize = true;
            this.lbds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbds.Location = new System.Drawing.Point(8, 201);
            this.lbds.Name = "lbds";
            this.lbds.Size = new System.Drawing.Size(257, 20);
            this.lbds.TabIndex = 2;
            this.lbds.Text = "Danh sách lịch sử chuyển bậc :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.txttths);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtttngach);
            this.groupBox2.Controls.Add(this.txtttma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btchuyenbac);
            this.groupBox2.Location = new System.Drawing.Point(13, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Nhân Viên chuyển bậc :";
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(756, 49);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txttths
            // 
            this.txttths.Location = new System.Drawing.Point(511, 29);
            this.txttths.Name = "txttths";
            this.txttths.Size = new System.Drawing.Size(137, 20);
            this.txttths.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên Hệ Số";
            // 
            // txtttngach
            // 
            this.txtttngach.Location = new System.Drawing.Point(293, 29);
            this.txtttngach.Name = "txtttngach";
            this.txtttngach.Size = new System.Drawing.Size(134, 20);
            this.txtttngach.TabIndex = 10;
            // 
            // txtttma
            // 
            this.txtttma.Location = new System.Drawing.Point(88, 29);
            this.txtttma.Name = "txtttma";
            this.txtttma.Size = new System.Drawing.Size(125, 20);
            this.txtttma.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Ngạch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(0, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 4;
            this.txtid.Visible = false;
            // 
            // DSChuyenBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbds);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DSChuyenBac";
            this.Text = "DSChuyenBac";
            this.Load += new System.EventHandler(this.DSChuyenBac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbdenngay;
        private System.Windows.Forms.Label lbtungay;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btnhaplai;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btchuyenbac;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbds;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNgach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNgach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NienHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn hslpc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaychuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttths;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtttngach;
        private System.Windows.Forms.TextBox txtttma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btload;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txtid;
    }
}