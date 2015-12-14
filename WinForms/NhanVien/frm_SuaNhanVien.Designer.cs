namespace WinForms.NhanVien
{
    partial class frm_SuaNhanVien
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
            this.cbNgach = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErr = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThemAnh = new System.Windows.Forms.Button();
            this.picNV = new System.Windows.Forms.PictureBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDanToc = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateNgayNghi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNgach
            // 
            this.cbNgach.FormattingEnabled = true;
            this.cbNgach.Location = new System.Drawing.Point(415, 364);
            this.cbNgach.Name = "cbNgach";
            this.cbNgach.Size = new System.Drawing.Size(214, 21);
            this.cbNgach.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Ngạch";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(415, 324);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(214, 20);
            this.txtCMND.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "CMND";
            // 
            // lbErr
            // 
            this.lbErr.AutoSize = true;
            this.lbErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbErr.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbErr.Location = new System.Drawing.Point(219, 24);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(230, 18);
            this.lbErr.TabIndex = 57;
            this.lbErr.Text = "SỬA THÔNG TIN NHÂN VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(554, 456);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 56;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(415, 157);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(214, 21);
            this.cbGioiTinh.TabIndex = 55;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Location = new System.Drawing.Point(415, 201);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(214, 20);
            this.dateNgaySinh.TabIndex = 54;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(453, 456);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 53;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.Location = new System.Drawing.Point(207, 76);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(72, 32);
            this.btnThemAnh.TabIndex = 52;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.UseVisualStyleBackColor = true;
            // 
            // picNV
            // 
            this.picNV.Location = new System.Drawing.Point(35, 76);
            this.picNV.Name = "picNV";
            this.picNV.Size = new System.Drawing.Size(156, 189);
            this.picNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNV.TabIndex = 51;
            this.picNV.TabStop = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(415, 284);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(214, 20);
            this.txtDiaChi.TabIndex = 50;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Location = new System.Drawing.Point(415, 242);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.Size = new System.Drawing.Size(214, 20);
            this.txtDanToc.TabIndex = 49;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(415, 116);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(214, 20);
            this.txtHoTen.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Họ tên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Dân tộc";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(351, 456);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dateNgayNghi
            // 
            this.dateNgayNghi.Location = new System.Drawing.Point(415, 408);
            this.dateNgayNghi.Name = "dateNgayNghi";
            this.dateNgayNghi.Size = new System.Drawing.Size(214, 20);
            this.dateNgayNghi.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Ngày nghỉ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(415, 76);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(214, 20);
            this.txtMaNV.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã nhân viên";
            // 
            // frm_SuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 502);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateNgayNghi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNgach);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbErr);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThemAnh);
            this.Controls.Add(this.picNV);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDanToc);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThem);
            this.Name = "frm_SuaNhanVien";
            this.Text = "Sửa thông tin nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNgach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbErr;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThemAnh;
        private System.Windows.Forms.PictureBox picNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDanToc;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateNgayNghi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
    }
}