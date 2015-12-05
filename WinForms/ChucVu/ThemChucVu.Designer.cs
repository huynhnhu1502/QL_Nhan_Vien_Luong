namespace WinForms.ChucVu
{
    partial class ThemChucVu
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
            this.lbmacv = new System.Windows.Forms.Label();
            this.lbtencv = new System.Windows.Forms.Label();
            this.lbhs = new System.Windows.Forms.Label();
            this.txtmacv = new System.Windows.Forms.TextBox();
            this.txttencv = new System.Windows.Forms.TextBox();
            this.txtheso = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbmacv
            // 
            this.lbmacv.AutoSize = true;
            this.lbmacv.Location = new System.Drawing.Point(12, 30);
            this.lbmacv.Name = "lbmacv";
            this.lbmacv.Size = new System.Drawing.Size(67, 13);
            this.lbmacv.TabIndex = 0;
            this.lbmacv.Text = "Mã chức vụ:";
            // 
            // lbtencv
            // 
            this.lbtencv.AutoSize = true;
            this.lbtencv.Location = new System.Drawing.Point(12, 74);
            this.lbtencv.Name = "lbtencv";
            this.lbtencv.Size = new System.Drawing.Size(71, 13);
            this.lbtencv.TabIndex = 1;
            this.lbtencv.Text = "Tên chức vụ:";
            // 
            // lbhs
            // 
            this.lbhs.AutoSize = true;
            this.lbhs.Location = new System.Drawing.Point(12, 125);
            this.lbhs.Name = "lbhs";
            this.lbhs.Size = new System.Drawing.Size(38, 13);
            this.lbhs.TabIndex = 2;
            this.lbhs.Text = "Hệ số:";
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(87, 30);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.ReadOnly = true;
            this.txtmacv.Size = new System.Drawing.Size(139, 20);
            this.txtmacv.TabIndex = 3;
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(87, 74);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(139, 20);
            this.txttencv.TabIndex = 4;
            // 
            // txtheso
            // 
            this.txtheso.Location = new System.Drawing.Point(87, 122);
            this.txtheso.Name = "txtheso";
            this.txtheso.Size = new System.Drawing.Size(139, 20);
            this.txtheso.TabIndex = 5;
            this.txtheso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtheso_KeyPress);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(9, 202);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(111, 202);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 7;
            this.btxoa.Text = "Nhập Lại";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(221, 203);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 8;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // ThemChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 292);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txtheso);
            this.Controls.Add(this.txttencv);
            this.Controls.Add(this.txtmacv);
            this.Controls.Add(this.lbhs);
            this.Controls.Add(this.lbtencv);
            this.Controls.Add(this.lbmacv);
            this.Name = "ThemChucVu";
            this.Text = "ThemChucVu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       

        #endregion

        private System.Windows.Forms.Label lbmacv;
        private System.Windows.Forms.Label lbtencv;
        private System.Windows.Forms.Label lbhs;
        private System.Windows.Forms.TextBox txtmacv;
        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.TextBox txtheso;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
    
    }
}