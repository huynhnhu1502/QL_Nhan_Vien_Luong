namespace WinForms.DanhMuc_HeSoLuong
{
    partial class frm_HeSoLuong
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
            this.cbNgachLuong = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtHeSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.gridHeSoLuong = new System.Windows.Forms.DataGridView();
            this.MaHeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNgach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNgachLuong);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtHeSo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuỳ chọn";
            // 
            // cbNgachLuong
            // 
            this.cbNgachLuong.FormattingEnabled = true;
            this.cbNgachLuong.Location = new System.Drawing.Point(134, 42);
            this.cbNgachLuong.Name = "cbNgachLuong";
            this.cbNgachLuong.Size = new System.Drawing.Size(262, 21);
            this.cbNgachLuong.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(825, 40);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(66, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtHeSo
            // 
            this.txtHeSo.Location = new System.Drawing.Point(562, 43);
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.Size = new System.Drawing.Size(223, 20);
            this.txtHeSo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hệ số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngạch lương";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnTaiLai);
            this.groupBox2.Controls.Add(this.gridHeSoLuong);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(833, 289);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(739, 289);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(644, 289);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(549, 289);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(833, 19);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(65, 22);
            this.btnTaiLai.TabIndex = 4;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // gridHeSoLuong
            // 
            this.gridHeSoLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHeSoLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHeSoLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHeSo,
            this.TenNgach,
            this.TenHeSo,
            this.HeSo});
            this.gridHeSoLuong.Location = new System.Drawing.Point(6, 54);
            this.gridHeSoLuong.Name = "gridHeSoLuong";
            this.gridHeSoLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHeSoLuong.Size = new System.Drawing.Size(921, 220);
            this.gridHeSoLuong.TabIndex = 0;
            // 
            // MaHeSo
            // 
            this.MaHeSo.FillWeight = 64.08393F;
            this.MaHeSo.HeaderText = "Mã hệ số";
            this.MaHeSo.Name = "MaHeSo";
            // 
            // TenNgach
            // 
            this.TenNgach.FillWeight = 174.4825F;
            this.TenNgach.HeaderText = "Ngạch lương";
            this.TenNgach.Name = "TenNgach";
            // 
            // TenHeSo
            // 
            this.TenHeSo.FillWeight = 81.21828F;
            this.TenHeSo.HeaderText = "Tên hệ số";
            this.TenHeSo.Name = "TenHeSo";
            // 
            // HeSo
            // 
            this.HeSo.FillWeight = 80.2153F;
            this.HeSo.HeaderText = "Hệ số";
            this.HeSo.Name = "HeSo";
            // 
            // frm_HeSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HeSoLuong";
            this.Text = "Hệ số lương";
            this.Load += new System.EventHandler(this.frm_HeSoLuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHeSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtHeSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView gridHeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHeSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNgach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHeSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSo;
        private System.Windows.Forms.ComboBox cbNgachLuong;
    }
}