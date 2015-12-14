namespace WinForms.ChucVu
{
    partial class QuanLyChucVu
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
            this.txttimhs = new System.Windows.Forms.TextBox();
            this.txttimten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Thoát = new System.Windows.Forms.Button();
            this.btkhoitao = new System.Windows.Forms.Button();
            this.btthemmoi = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.txttimma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.suahs = new System.Windows.Forms.TextBox();
            this.suaten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LSCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttimhs);
            this.groupBox1.Controls.Add(this.txttimten);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Thoát);
            this.groupBox1.Controls.Add(this.btkhoitao);
            this.groupBox1.Controls.Add(this.btthemmoi);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Controls.Add(this.txttimma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Chức Vụ :";
            // 
            // txttimhs
            // 
            this.txttimhs.Location = new System.Drawing.Point(595, 30);
            this.txttimhs.Name = "txttimhs";
            this.txttimhs.Size = new System.Drawing.Size(133, 20);
            this.txttimhs.TabIndex = 4;
            this.txttimhs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeSo_KeyPress);
            // 
            // txttimten
            // 
            this.txttimten.Location = new System.Drawing.Point(369, 30);
            this.txttimten.Name = "txttimten";
            this.txttimten.Size = new System.Drawing.Size(129, 20);
            this.txttimten.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hệ số:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên chức vụ:";
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(621, 74);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(83, 23);
            this.Thoát.TabIndex = 8;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // btkhoitao
            // 
            this.btkhoitao.Location = new System.Drawing.Point(497, 74);
            this.btkhoitao.Name = "btkhoitao";
            this.btkhoitao.Size = new System.Drawing.Size(83, 23);
            this.btkhoitao.TabIndex = 7;
            this.btkhoitao.Text = "Khởi tạo lại";
            this.btkhoitao.UseVisualStyleBackColor = true;
            this.btkhoitao.Click += new System.EventHandler(this.btkhoitao_Click);
            // 
            // btthemmoi
            // 
            this.btthemmoi.Location = new System.Drawing.Point(369, 74);
            this.btthemmoi.Name = "btthemmoi";
            this.btthemmoi.Size = new System.Drawing.Size(83, 23);
            this.btthemmoi.TabIndex = 6;
            this.btthemmoi.Text = "Thêm Mới";
            this.btthemmoi.UseVisualStyleBackColor = true;
            this.btthemmoi.Click += new System.EventHandler(this.btthemmoi_Click);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(248, 74);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(83, 23);
            this.bttim.TabIndex = 5;
            this.bttim.Text = "Tìm Kiếm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // txttimma
            // 
            this.txttimma.Location = new System.Drawing.Point(85, 33);
            this.txttimma.Name = "txttimma";
            this.txttimma.Size = new System.Drawing.Size(135, 20);
            this.txttimma.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Chức Vụ:";
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(595, 26);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(83, 23);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // suahs
            // 
            this.suahs.Location = new System.Drawing.Point(345, 29);
            this.suahs.Name = "suahs";
            this.suahs.ReadOnly = true;
            this.suahs.Size = new System.Drawing.Size(134, 20);
            this.suahs.TabIndex = 5;
            this.suahs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeSo_KeyPress);
            // 
            // suaten
            // 
            this.suaten.Location = new System.Drawing.Point(85, 29);
            this.suaten.Name = "suaten";
            this.suaten.ReadOnly = true;
            this.suaten.Size = new System.Drawing.Size(135, 20);
            this.suaten.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ Số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Chức Vụ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.txtMaChucVu,
            this.txtTenChucVu,
            this.txtHeSo,
            this.LSCT,
            this.NV});
            this.dataGridView1.Location = new System.Drawing.Point(30, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 189);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.DataPropertyName = "MaChucVu";
            this.txtMaChucVu.HeaderText = "Mã Chức Vụ";
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.ReadOnly = true;
            this.txtMaChucVu.Width = 150;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.DataPropertyName = "TenChucVu";
            this.txtTenChucVu.HeaderText = "Tên Chức Vụ";
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.ReadOnly = true;
            this.txtTenChucVu.Width = 200;
            // 
            // txtHeSo
            // 
            this.txtHeSo.DataPropertyName = "HeSoCV";
            this.txtHeSo.HeaderText = "Hệ Số Chức Vụ";
            this.txtHeSo.Name = "txtHeSo";
            this.txtHeSo.ReadOnly = true;
            this.txtHeSo.Width = 200;
            // 
            // LSCT
            // 
            this.LSCT.DataPropertyName = "LichSuCongTacs";
            this.LSCT.HeaderText = "Lịch Sử Công Tác";
            this.LSCT.Name = "LSCT";
            this.LSCT.ReadOnly = true;
            this.LSCT.Visible = false;
            this.LSCT.Width = 5;
            // 
            // NV
            // 
            this.NV.DataPropertyName = "NhanViens";
            this.NV.HeaderText = "Nhân Viên";
            this.NV.Name = "NV";
            this.NV.ReadOnly = true;
            this.NV.Visible = false;
            this.NV.Width = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh sách Chức Vụ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.suaten);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.suahs);
            this.groupBox2.Location = new System.Drawing.Point(30, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sửa :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(299, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "QUẢN LÝ CHỨC VỤ";
            // 
            // QuanLyChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 486);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyChucVu";
            this.Text = "Quản_Lý_Chức_Vụ";
            this.Load += new System.EventHandler(this.QuanLyChucVu_Load);
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
        private System.Windows.Forms.Button btthemmoi;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox suahs;
        private System.Windows.Forms.TextBox suaten;
        private System.Windows.Forms.TextBox txttimma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button btkhoitao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.TextBox txttimhs;
        private System.Windows.Forms.TextBox txttimten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMaChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtHeSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LSCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
        private System.Windows.Forms.Label label7;
    }
}