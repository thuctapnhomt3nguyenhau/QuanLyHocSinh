namespace QuanLyHocSinhTHPT.GUI
{
    partial class frmMain
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
            this.btnGiaoVien = new MetroFramework.Controls.MetroTile();
            this.btnHocSinh = new MetroFramework.Controls.MetroTile();
            this.btnGiangDuong = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnTaiKhoan = new MetroFramework.Controls.MetroTile();
            this.btnHuongDanSuDung = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuongDanSuDung);
            this.groupBox1.Controls.Add(this.btnTaiKhoan);
            this.groupBox1.Controls.Add(this.metroTile1);
            this.groupBox1.Controls.Add(this.btnGiangDuong);
            this.groupBox1.Controls.Add(this.btnHocSinh);
            this.groupBox1.Controls.Add(this.btnGiaoVien);
            this.groupBox1.Location = new System.Drawing.Point(68, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.ActiveControl = null;
            this.btnGiaoVien.Location = new System.Drawing.Point(45, 80);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(198, 140);
            this.btnGiaoVien.TabIndex = 3;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.UseSelectable = true;
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.ActiveControl = null;
            this.btnHocSinh.Location = new System.Drawing.Point(263, 80);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(198, 140);
            this.btnHocSinh.TabIndex = 4;
            this.btnHocSinh.Text = "Học Sinh";
            this.btnHocSinh.UseSelectable = true;
            // 
            // btnGiangDuong
            // 
            this.btnGiangDuong.ActiveControl = null;
            this.btnGiangDuong.Location = new System.Drawing.Point(45, 253);
            this.btnGiangDuong.Name = "btnGiangDuong";
            this.btnGiangDuong.Size = new System.Drawing.Size(198, 140);
            this.btnGiangDuong.TabIndex = 5;
            this.btnGiangDuong.Text = "Giảng đường";
            this.btnGiangDuong.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(263, 253);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(198, 140);
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Giảng đường";
            this.metroTile1.UseSelectable = true;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.ActiveControl = null;
            this.btnTaiKhoan.Location = new System.Drawing.Point(482, 80);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(198, 140);
            this.btnTaiKhoan.TabIndex = 7;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseSelectable = true;
            // 
            // btnHuongDanSuDung
            // 
            this.btnHuongDanSuDung.ActiveControl = null;
            this.btnHuongDanSuDung.Location = new System.Drawing.Point(482, 253);
            this.btnHuongDanSuDung.Name = "btnHuongDanSuDung";
            this.btnHuongDanSuDung.Size = new System.Drawing.Size(198, 140);
            this.btnHuongDanSuDung.TabIndex = 8;
            this.btnHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            this.btnHuongDanSuDung.UseSelectable = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 631);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Quản Lý Học Sinh - Giáo Viên";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btnTaiKhoan;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile btnGiangDuong;
        private MetroFramework.Controls.MetroTile btnHocSinh;
        private MetroFramework.Controls.MetroTile btnGiaoVien;
        private MetroFramework.Controls.MetroTile btnHuongDanSuDung;
    }
}