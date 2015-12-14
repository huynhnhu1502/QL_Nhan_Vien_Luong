namespace WinForms.LSCongTac
{
    partial class frmLichSuCongTac
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.gridLSCongTac = new System.Windows.Forms.DataGridView();
            this.maCongTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNgach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLSCongTac)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbChucVu);
            this.groupBox1.Controls.Add(this.cbDonVi);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(920, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(821, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSearch_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(449, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chức vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(449, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên nhân viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(32, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đơn vị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã nhân viên";
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(544, 82);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(242, 21);
            this.cbChucVu.TabIndex = 4;
            // 
            // cbDonVi
            // 
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Location = new System.Drawing.Point(126, 82);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(242, 21);
            this.cbDonVi.TabIndex = 3;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(544, 36);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(242, 20);
            this.txtTenNV.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(125, 36);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(243, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // gridLSCongTac
            // 
            this.gridLSCongTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLSCongTac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCongTac,
            this.tenNV,
            this.tenDonVi,
            this.tenChucVu,
            this.tenNgach,
            this.ngayLam,
            this.ngayChuyen});
            this.gridLSCongTac.Location = new System.Drawing.Point(7, 64);
            this.gridLSCongTac.Name = "gridLSCongTac";
            this.gridLSCongTac.ReadOnly = true;
            this.gridLSCongTac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLSCongTac.Size = new System.Drawing.Size(906, 212);
            this.gridLSCongTac.TabIndex = 0;
            // 
            // maCongTac
            // 
            this.maCongTac.HeaderText = "Mã công tác";
            this.maCongTac.Name = "maCongTac";
            this.maCongTac.ReadOnly = true;
            // 
            // tenNV
            // 
            this.tenNV.HeaderText = "Tên nhân viên";
            this.tenNV.Name = "tenNV";
            this.tenNV.ReadOnly = true;
            // 
            // tenDonVi
            // 
            this.tenDonVi.HeaderText = "Đơn vị";
            this.tenDonVi.Name = "tenDonVi";
            this.tenDonVi.ReadOnly = true;
            // 
            // tenChucVu
            // 
            this.tenChucVu.HeaderText = "Chức vụ";
            this.tenChucVu.Name = "tenChucVu";
            this.tenChucVu.ReadOnly = true;
            // 
            // tenNgach
            // 
            this.tenNgach.HeaderText = "Ngạch lương";
            this.tenNgach.Name = "tenNgach";
            this.tenNgach.ReadOnly = true;
            // 
            // ngayLam
            // 
            this.ngayLam.HeaderText = "Ngày làm";
            this.ngayLam.Name = "ngayLam";
            this.ngayLam.ReadOnly = true;
            // 
            // ngayChuyen
            // 
            this.ngayChuyen.HeaderText = "Ngày chuyển";
            this.ngayChuyen.Name = "ngayChuyen";
            this.ngayChuyen.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnTaiLai);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.gridLSCongTac);
            this.groupBox2.Location = new System.Drawing.Point(13, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(622, 292);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 26);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(823, 21);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(67, 26);
            this.btnTaiLai.TabIndex = 6;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(811, 292);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 26);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(721, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 27);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(525, 292);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 26);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmLichSuCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLichSuCongTac";
            this.Text = "Lịch sử công tác";
            this.Load += new System.EventHandler(this.LichSuCongTac_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLSCongTac)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridLSCongTac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCongTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDonVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNgach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayChuyen;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnSua;
    }
}