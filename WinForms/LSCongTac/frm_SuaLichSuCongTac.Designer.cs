namespace WinForms.LSCongTac
{
    partial class frmSuaLSCongTac
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbDonVi = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbNgachLuong = new System.Windows.Forms.ComboBox();
            this.dateNgayLam = new System.Windows.Forms.DateTimePicker();
            this.dateNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaCongTac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT LỊCH SỬ CÔNG TÁC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(414, 85);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(72, 13);
            this.lbMaNV.TabIndex = 3;
            this.lbMaNV.Text = "Mã nhân viên";
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Location = new System.Drawing.Point(415, 139);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(38, 13);
            this.lbDonVi.TabIndex = 4;
            this.lbDonVi.Text = "Đơn vị";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(49, 197);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(47, 13);
            this.lbChucVu.TabIndex = 5;
            this.lbChucVu.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngạch lương";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày làm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày chuyển";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(509, 78);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(164, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // cbDonVi
            // 
            this.cbDonVi.Enabled = false;
            this.cbDonVi.FormattingEnabled = true;
            this.cbDonVi.Location = new System.Drawing.Point(509, 131);
            this.cbDonVi.Name = "cbDonVi";
            this.cbDonVi.Size = new System.Drawing.Size(164, 21);
            this.cbDonVi.TabIndex = 4;
            // 
            // cbChucVu
            // 
            this.cbChucVu.Enabled = false;
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(144, 189);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(164, 21);
            this.cbChucVu.TabIndex = 5;
            // 
            // cbNgachLuong
            // 
            this.cbNgachLuong.Enabled = false;
            this.cbNgachLuong.FormattingEnabled = true;
            this.cbNgachLuong.Location = new System.Drawing.Point(509, 189);
            this.cbNgachLuong.Name = "cbNgachLuong";
            this.cbNgachLuong.Size = new System.Drawing.Size(164, 21);
            this.cbNgachLuong.TabIndex = 6;
            // 
            // dateNgayLam
            // 
            this.dateNgayLam.Enabled = false;
            this.dateNgayLam.Location = new System.Drawing.Point(144, 250);
            this.dateNgayLam.Name = "dateNgayLam";
            this.dateNgayLam.Size = new System.Drawing.Size(163, 20);
            this.dateNgayLam.TabIndex = 7;
            // 
            // dateNgayChuyen
            // 
            this.dateNgayChuyen.Location = new System.Drawing.Point(510, 250);
            this.dateNgayChuyen.Name = "dateNgayChuyen";
            this.dateNgayChuyen.Size = new System.Drawing.Size(163, 20);
            this.dateNgayChuyen.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(494, 325);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 28);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(601, 325);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 28);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(49, 139);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(76, 13);
            this.lbTenNV.TabIndex = 21;
            this.lbTenNV.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(144, 132);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(163, 20);
            this.txtTenNV.TabIndex = 3;
            // 
            // txtMaCongTac
            // 
            this.txtMaCongTac.Enabled = false;
            this.txtMaCongTac.Location = new System.Drawing.Point(144, 78);
            this.txtMaCongTac.Name = "txtMaCongTac";
            this.txtMaCongTac.Size = new System.Drawing.Size(164, 20);
            this.txtMaCongTac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã công tác";
            // 
            // frmSuaLSCongTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 381);
            this.Controls.Add(this.txtMaCongTac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dateNgayChuyen);
            this.Controls.Add(this.dateNgayLam);
            this.Controls.Add(this.cbNgachLuong);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbDonVi);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbDonVi);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label1);
            this.Name = "frmSuaLSCongTac";
            this.Text = "Sửa lịch sử công tác";
            this.Load += new System.EventHandler(this.frmSuaLSCongTac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbDonVi;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cbDonVi;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbNgachLuong;
        private System.Windows.Forms.DateTimePicker dateNgayLam;
        private System.Windows.Forms.DateTimePicker dateNgayChuyen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaCongTac;
        private System.Windows.Forms.Label label2;
    }
}