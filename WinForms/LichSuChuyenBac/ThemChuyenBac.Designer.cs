namespace WinForms.LichSuChuyenBac
{
    partial class ThemChuyenBac
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
            this.MaNV = new System.Windows.Forms.Label();
            this.lbngach = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.cbngach = new System.Windows.Forms.ComboBox();
            this.lbHS = new System.Windows.Forms.Label();
            this.btluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.cbhs = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(28, 34);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(75, 13);
            this.MaNV.TabIndex = 0;
            this.MaNV.Text = "Mã Nhân Viên";
            // 
            // lbngach
            // 
            this.lbngach.AutoSize = true;
            this.lbngach.Location = new System.Drawing.Point(28, 69);
            this.lbngach.Name = "lbngach";
            this.lbngach.Size = new System.Drawing.Size(61, 13);
            this.lbngach.TabIndex = 1;
            this.lbngach.Text = "Tên Ngạch";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(109, 31);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(180, 20);
            this.txtmanv.TabIndex = 2;
            // 
            // cbngach
            // 
            this.cbngach.AccessibleName = "";
            this.cbngach.FormattingEnabled = true;
            this.cbngach.Location = new System.Drawing.Point(109, 66);
            this.cbngach.Name = "cbngach";
            this.cbngach.Size = new System.Drawing.Size(180, 21);
            this.cbngach.TabIndex = 3;
            this.cbngach.SelectedIndexChanged += new System.EventHandler(this.cbngach_thaydoi);
            // 
            // lbHS
            // 
            this.lbHS.AutoSize = true;
            this.lbHS.Location = new System.Drawing.Point(28, 111);
            this.lbHS.Name = "lbHS";
            this.lbHS.Size = new System.Drawing.Size(59, 13);
            this.lbHS.TabIndex = 4;
            this.lbHS.Text = "Tên Hệ Số";
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(62, 221);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 6;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(183, 221);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // cbhs
            // 
            this.cbhs.FormattingEnabled = true;
            this.cbhs.Location = new System.Drawing.Point(109, 111);
            this.cbhs.Name = "cbhs";
            this.cbhs.Size = new System.Drawing.Size(180, 21);
            this.cbhs.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày Chuyển";
            // 
            // ThemChuyenBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbhs);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.lbHS);
            this.Controls.Add(this.cbngach);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.lbngach);
            this.Controls.Add(this.MaNV);
            this.Name = "ThemChuyenBac";
            this.Text = "ThemChuyenBac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.Label lbngach;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.ComboBox cbngach;
        private System.Windows.Forms.Label lbHS;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.ComboBox cbhs;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}