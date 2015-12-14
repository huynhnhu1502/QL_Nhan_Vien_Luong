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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbmacv
            // 
            this.lbmacv.AutoSize = true;
            this.lbmacv.Location = new System.Drawing.Point(12, 68);
            this.lbmacv.Name = "lbmacv";
            this.lbmacv.Size = new System.Drawing.Size(67, 13);
            this.lbmacv.TabIndex = 0;
            this.lbmacv.Text = "Mã chức vụ:";
            // 
            // lbtencv
            // 
            this.lbtencv.AutoSize = true;
            this.lbtencv.Location = new System.Drawing.Point(12, 112);
            this.lbtencv.Name = "lbtencv";
            this.lbtencv.Size = new System.Drawing.Size(71, 13);
            this.lbtencv.TabIndex = 1;
            this.lbtencv.Text = "Tên chức vụ:";
            // 
            // lbhs
            // 
            this.lbhs.AutoSize = true;
            this.lbhs.Location = new System.Drawing.Point(12, 163);
            this.lbhs.Name = "lbhs";
            this.lbhs.Size = new System.Drawing.Size(38, 13);
            this.lbhs.TabIndex = 2;
            this.lbhs.Text = "Hệ số:";
            // 
            // txtmacv
            // 
            this.txtmacv.Location = new System.Drawing.Point(87, 68);
            this.txtmacv.Name = "txtmacv";
            this.txtmacv.ReadOnly = true;
            this.txtmacv.Size = new System.Drawing.Size(178, 20);
            this.txtmacv.TabIndex = 1;
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(87, 112);
            this.txttencv.Name = "txttencv";
            this.txttencv.Size = new System.Drawing.Size(178, 20);
            this.txttencv.TabIndex = 2;
            // 
            // txtheso
            // 
            this.txtheso.Location = new System.Drawing.Point(87, 160);
            this.txtheso.Name = "txtheso";
            this.txtheso.Size = new System.Drawing.Size(178, 20);
            this.txtheso.TabIndex = 3;
            this.txtheso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtheso_KeyPress);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(21, 219);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 4;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(114, 219);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 5;
            this.btxoa.Text = "Nhập Lại";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(208, 220);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(89, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÊM CHỨC VỤ";
            // 
            // ThemChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 292);
            this.Controls.Add(this.label1);
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
            this.Text = "Thêm chức vụ";
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
        private System.Windows.Forms.Label label1;
    }
}