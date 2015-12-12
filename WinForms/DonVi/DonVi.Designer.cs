namespace WinForms
{
    partial class DonVi
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamThanhLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhiemVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LichSuCongTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldvs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.txtma = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thêm mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbloai
            // 
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(699, 26);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(157, 21);
            this.cbloai.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại đơn vị";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(395, 26);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(181, 20);
            this.txtTenDV.TabIndex = 7;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(0, 104);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(21, 20);
            this.txtMaDV.TabIndex = 6;
            this.txtMaDV.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên đơn vị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã đơn vị";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.MaDV,
            this.TenDV,
            this.MaLoai,
            this.DiaChi,
            this.Dthoai,
            this.NamThanhLap,
            this.ChucNang,
            this.NhiemVu,
            this.NhanVien,
            this.LichSuCongTac,
            this.ldvs,
            this.ChiTiet});
            this.dataGridView1.Location = new System.Drawing.Point(11, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 175);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // MaDV
            // 
            this.MaDV.DataPropertyName = "MaDonVi";
            this.MaDV.HeaderText = "Mã Đơn Vị";
            this.MaDV.Name = "MaDV";
            // 
            // TenDV
            // 
            this.TenDV.DataPropertyName = "TenDonVi";
            this.TenDV.HeaderText = "Tên Đơn Vị";
            this.TenDV.Name = "TenDV";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại Đơn Vị";
            this.MaLoai.Name = "MaLoai";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Dthoai
            // 
            this.Dthoai.DataPropertyName = "DienThoai";
            this.Dthoai.HeaderText = "Điện Thoại";
            this.Dthoai.Name = "Dthoai";
            // 
            // NamThanhLap
            // 
            this.NamThanhLap.DataPropertyName = "NamThanhLap";
            this.NamThanhLap.HeaderText = "NTL";
            this.NamThanhLap.Name = "NamThanhLap";
            this.NamThanhLap.Visible = false;
            // 
            // ChucNang
            // 
            this.ChucNang.DataPropertyName = "ChucNang";
            this.ChucNang.HeaderText = "ChucNang";
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Visible = false;
            // 
            // NhiemVu
            // 
            this.NhiemVu.DataPropertyName = "NhiemVu";
            this.NhiemVu.HeaderText = "NhiemVu";
            this.NhiemVu.Name = "NhiemVu";
            this.NhiemVu.Visible = false;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "NhanViens";
            this.NhanVien.HeaderText = "NhanVien";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Visible = false;
            // 
            // LichSuCongTac
            // 
            this.LichSuCongTac.DataPropertyName = "LichSuCongTacs";
            this.LichSuCongTac.HeaderText = "LichSuCongTac";
            this.LichSuCongTac.Name = "LichSuCongTac";
            this.LichSuCongTac.Visible = false;
            // 
            // ldvs
            // 
            this.ldvs.DataPropertyName = "LoaiDonVi";
            this.ldvs.HeaderText = "LoaiDonVis";
            this.ldvs.Name = "ldvs";
            this.ldvs.Visible = false;
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "Chi Tiết";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "THÔNG TIN CƠ BẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btthoat);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbloai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn vị";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(781, 81);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 16;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(85, 26);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(149, 20);
            this.txtma.TabIndex = 15;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(576, 81);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 14;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(680, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Khởi tạo lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(332, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "QUẢN LÝ ĐƠN VỊ";
            // 
            // DonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(896, 453);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DonVi";
            this.Text = "DonVi";
            this.Load += new System.EventHandler(this.DonVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamThanhLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhiemVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LichSuCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldvs;
        private System.Windows.Forms.DataGridViewLinkColumn ChiTiet;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label4;
    }
}