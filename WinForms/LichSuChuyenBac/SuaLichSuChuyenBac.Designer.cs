namespace WinForms.LichSuChuyenBac
{
    partial class SuaLichSuChuyenBac
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
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbngach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbheso = new System.Windows.Forms.ComboBox();
            this.btsua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btthoat = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtmnv
            // 
            this.txtmnv.Location = new System.Drawing.Point(92, 27);
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.ReadOnly = true;
            this.txtmnv.Size = new System.Drawing.Size(200, 20);
            this.txtmnv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngạch";
            // 
            // cbngach
            // 
            this.cbngach.FormattingEnabled = true;
            this.cbngach.Location = new System.Drawing.Point(92, 72);
            this.cbngach.Name = "cbngach";
            this.cbngach.Size = new System.Drawing.Size(200, 21);
            this.cbngach.TabIndex = 3;
            this.cbngach.SelectedIndexChanged += new System.EventHandler(this.cbngach_thaydoi);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hệ Số";
            // 
            // cbheso
            // 
            this.cbheso.FormattingEnabled = true;
            this.cbheso.Location = new System.Drawing.Point(92, 117);
            this.cbheso.Name = "cbheso";
            this.cbheso.Size = new System.Drawing.Size(200, 21);
            this.cbheso.TabIndex = 5;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(138, 246);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày Chuyển";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(246, 246);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 9;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(322, 296);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(25, 20);
            this.txtid.TabIndex = 10;
            this.txtid.Visible = false;
            // 
            // SuaLichSuChuyenBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 313);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.cbheso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbngach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmnv);
            this.Controls.Add(this.label1);
            this.Name = "SuaLichSuChuyenBac";
            this.Text = "SuaLichSuChuyenBac";
            this.Load += new System.EventHandler(this.SuaLichSuChuyenBac_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbngach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbheso;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TextBox txtid;
    }
}