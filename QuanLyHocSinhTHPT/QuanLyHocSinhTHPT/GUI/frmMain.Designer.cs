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
            this.btnMonHoc = new MetroFramework.Controls.MetroTile();
            this.btnLopHoc = new MetroFramework.Controls.MetroTile();
            this.btnHocSinh = new MetroFramework.Controls.MetroTile();
            this.btnHuongDan = new MetroFramework.Controls.MetroTile();
            this.btnBangDiem = new MetroFramework.Controls.MetroTile();
            this.btnGiaoVien = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.ActiveControl = null;
            this.btnMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(201)))), ((int)(((byte)(185)))));
            this.btnMonHoc.Location = new System.Drawing.Point(408, 136);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(256, 230);
            this.btnMonHoc.TabIndex = 15;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMonHoc.TileImage = global::QuanLyHocSinhTHPT.Properties.Resources.blackboard_1;
            this.btnMonHoc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMonHoc.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnMonHoc.UseCustomBackColor = true;
            this.btnMonHoc.UseSelectable = true;
            this.btnMonHoc.UseTileImage = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.ActiveControl = null;
            this.btnLopHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(195)))), ((int)(((byte)(109)))));
            this.btnLopHoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLopHoc.Location = new System.Drawing.Point(736, 136);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(256, 230);
            this.btnLopHoc.TabIndex = 17;
            this.btnLopHoc.Text = "Lớp học";
            this.btnLopHoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLopHoc.TileImage = global::QuanLyHocSinhTHPT.Properties.Resources.briefcase1;
            this.btnLopHoc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLopHoc.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnLopHoc.UseCustomBackColor = true;
            this.btnLopHoc.UseSelectable = true;
            this.btnLopHoc.UseStyleColors = true;
            this.btnLopHoc.UseTileImage = true;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.ActiveControl = null;
            this.btnHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(113)))), ((int)(((byte)(102)))));
            this.btnHocSinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHocSinh.Location = new System.Drawing.Point(77, 424);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(256, 230);
            this.btnHocSinh.TabIndex = 18;
            this.btnHocSinh.Text = "Học sinh";
            this.btnHocSinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHocSinh.TileImage = global::QuanLyHocSinhTHPT.Properties.Resources.student;
            this.btnHocSinh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHocSinh.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnHocSinh.UseCustomBackColor = true;
            this.btnHocSinh.UseSelectable = true;
            this.btnHocSinh.UseStyleColors = true;
            this.btnHocSinh.UseTileImage = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.ActiveControl = null;
            this.btnHuongDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(223)))));
            this.btnHuongDan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuongDan.Location = new System.Drawing.Point(736, 424);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(256, 230);
            this.btnHuongDan.TabIndex = 19;
            this.btnHuongDan.Text = "Hướng dẫn sử dụng";
            this.btnHuongDan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongDan.TileImage = global::QuanLyHocSinhTHPT.Properties.Resources.light_bulb;
            this.btnHuongDan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuongDan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnHuongDan.UseCustomBackColor = true;
            this.btnHuongDan.UseSelectable = true;
            this.btnHuongDan.UseStyleColors = true;
            this.btnHuongDan.UseTileImage = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnBangDiem
            // 
            this.btnBangDiem.ActiveControl = null;
            this.btnBangDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(113)))), ((int)(((byte)(102)))));
            this.btnBangDiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBangDiem.Location = new System.Drawing.Point(408, 424);
            this.btnBangDiem.Name = "btnBangDiem";
            this.btnBangDiem.Size = new System.Drawing.Size(256, 230);
            this.btnBangDiem.TabIndex = 20;
            this.btnBangDiem.Text = "Bảng điểm";
            this.btnBangDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBangDiem.TileImage = global::QuanLyHocSinhTHPT.Properties.Resources.test;
            this.btnBangDiem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBangDiem.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnBangDiem.UseSelectable = true;
            this.btnBangDiem.UseStyleColors = true;
            this.btnBangDiem.UseTileImage = true;
            this.btnBangDiem.Click += new System.EventHandler(this.btnBangDiem_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.ActiveControl = null;
            this.btnGiaoVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(139)))), ((int)(((byte)(116)))));
            this.btnGiaoVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGiaoVien.Location = new System.Drawing.Point(77, 136);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(256, 230);
            this.btnGiaoVien.TabIndex = 11;
            this.btnGiaoVien.Text = "Giáo viên";
            this.btnGiaoVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGiaoVien.TileImage = global::QuanLyHocSinhTHPT.Properties.Resources.professor;
            this.btnGiaoVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGiaoVien.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGiaoVien.UseCustomBackColor = true;
            this.btnGiaoVien.UseSelectable = true;
            this.btnGiaoVien.UseStyleColors = true;
            this.btnGiaoVien.UseTileImage = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 734);
            this.Controls.Add(this.btnBangDiem);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnLopHoc);
            this.Controls.Add(this.btnMonHoc);
            this.Controls.Add(this.btnGiaoVien);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Quản Lý Học Sinh - Giáo Viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnMonHoc;
        private MetroFramework.Controls.MetroTile btnGiaoVien;
        private MetroFramework.Controls.MetroTile btnLopHoc;
        private MetroFramework.Controls.MetroTile btnHocSinh;
        private MetroFramework.Controls.MetroTile btnHuongDan;
        private MetroFramework.Controls.MetroTile btnBangDiem;
    }
}