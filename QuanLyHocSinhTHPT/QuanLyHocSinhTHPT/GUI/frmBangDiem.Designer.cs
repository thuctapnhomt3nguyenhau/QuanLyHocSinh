namespace QuanLyHocSinhTHPT.GUI
{
    partial class frmBangDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangDiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSua = new MetroFramework.Controls.MetroButton();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvGiaoVien = new MetroFramework.Controls.MetroGrid();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiemHocKi = new MetroFramework.Controls.MetroTextBox();
            this.txtDiem45Phut = new MetroFramework.Controls.MetroTextBox();
            this.txtDiem15Phut = new MetroFramework.Controls.MetroTextBox();
            this.cboMaHocSinh = new System.Windows.Forms.ComboBox();
            this.cboMaMonHoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::QuanLyHocSinhTHPT.Properties.Resources.loupe;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearch.Location = new System.Drawing.Point(310, 301);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSearch.UseSelectable = true;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(175, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(84, 311);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(203, 30);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSua.Location = new System.Drawing.Point(841, 251);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 110);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSua.UseSelectable = true;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnReset.Location = new System.Drawing.Point(1103, 251);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 110);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReset.UseSelectable = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnXoa.Location = new System.Drawing.Point(971, 251);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 110);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnXoa.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(853, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Mã môn học";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToResizeRows = false;
            this.dgvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiaoVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvGiaoVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiaoVien.EnableHeadersVisualStyles = false;
            this.dgvGiaoVien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvGiaoVien.GridColor = System.Drawing.Color.White;
            this.dgvGiaoVien.Location = new System.Drawing.Point(23, 399);
            this.dgvGiaoVien.MultiSelect = false;
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaoVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiaoVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGiaoVien.RowTemplate.Height = 24;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1220, 422);
            this.dgvGiaoVien.TabIndex = 45;
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThem.Location = new System.Drawing.Point(711, 251);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 110);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThem.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(485, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Điểm 45 phút";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(493, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(857, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Điểm học kì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(53, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã bảng điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(53, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Điểm 15 phút";
            // 
            // txtDiemHocKi
            // 
            // 
            // 
            // 
            this.txtDiemHocKi.CustomButton.Image = null;
            this.txtDiemHocKi.CustomButton.Location = new System.Drawing.Point(114, 2);
            this.txtDiemHocKi.CustomButton.Name = "";
            this.txtDiemHocKi.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtDiemHocKi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiemHocKi.CustomButton.TabIndex = 1;
            this.txtDiemHocKi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiemHocKi.CustomButton.UseSelectable = true;
            this.txtDiemHocKi.CustomButton.Visible = false;
            this.txtDiemHocKi.Lines = new string[0];
            this.txtDiemHocKi.Location = new System.Drawing.Point(976, 184);
            this.txtDiemHocKi.MaxLength = 32767;
            this.txtDiemHocKi.Multiline = true;
            this.txtDiemHocKi.Name = "txtDiemHocKi";
            this.txtDiemHocKi.PasswordChar = '\0';
            this.txtDiemHocKi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiemHocKi.SelectedText = "";
            this.txtDiemHocKi.SelectionLength = 0;
            this.txtDiemHocKi.SelectionStart = 0;
            this.txtDiemHocKi.ShortcutsEnabled = true;
            this.txtDiemHocKi.Size = new System.Drawing.Size(136, 24);
            this.txtDiemHocKi.TabIndex = 47;
            this.txtDiemHocKi.UseSelectable = true;
            this.txtDiemHocKi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiemHocKi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiem45Phut
            // 
            // 
            // 
            // 
            this.txtDiem45Phut.CustomButton.Image = null;
            this.txtDiem45Phut.CustomButton.Location = new System.Drawing.Point(114, 2);
            this.txtDiem45Phut.CustomButton.Name = "";
            this.txtDiem45Phut.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtDiem45Phut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiem45Phut.CustomButton.TabIndex = 1;
            this.txtDiem45Phut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiem45Phut.CustomButton.UseSelectable = true;
            this.txtDiem45Phut.CustomButton.Visible = false;
            this.txtDiem45Phut.Lines = new string[0];
            this.txtDiem45Phut.Location = new System.Drawing.Point(619, 180);
            this.txtDiem45Phut.MaxLength = 32767;
            this.txtDiem45Phut.Multiline = true;
            this.txtDiem45Phut.Name = "txtDiem45Phut";
            this.txtDiem45Phut.PasswordChar = '\0';
            this.txtDiem45Phut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiem45Phut.SelectedText = "";
            this.txtDiem45Phut.SelectionLength = 0;
            this.txtDiem45Phut.SelectionStart = 0;
            this.txtDiem45Phut.ShortcutsEnabled = true;
            this.txtDiem45Phut.Size = new System.Drawing.Size(136, 24);
            this.txtDiem45Phut.TabIndex = 48;
            this.txtDiem45Phut.UseSelectable = true;
            this.txtDiem45Phut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiem45Phut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiem15Phut
            // 
            // 
            // 
            // 
            this.txtDiem15Phut.CustomButton.Image = null;
            this.txtDiem15Phut.CustomButton.Location = new System.Drawing.Point(114, 2);
            this.txtDiem15Phut.CustomButton.Name = "";
            this.txtDiem15Phut.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtDiem15Phut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiem15Phut.CustomButton.TabIndex = 1;
            this.txtDiem15Phut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiem15Phut.CustomButton.UseSelectable = true;
            this.txtDiem15Phut.CustomButton.Visible = false;
            this.txtDiem15Phut.Lines = new string[0];
            this.txtDiem15Phut.Location = new System.Drawing.Point(183, 180);
            this.txtDiem15Phut.MaxLength = 32767;
            this.txtDiem15Phut.Multiline = true;
            this.txtDiem15Phut.Name = "txtDiem15Phut";
            this.txtDiem15Phut.PasswordChar = '\0';
            this.txtDiem15Phut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiem15Phut.SelectedText = "";
            this.txtDiem15Phut.SelectionLength = 0;
            this.txtDiem15Phut.SelectionStart = 0;
            this.txtDiem15Phut.ShortcutsEnabled = true;
            this.txtDiem15Phut.Size = new System.Drawing.Size(136, 24);
            this.txtDiem15Phut.TabIndex = 49;
            this.txtDiem15Phut.UseSelectable = true;
            this.txtDiem15Phut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiem15Phut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboMaHocSinh
            // 
            this.cboMaHocSinh.FormattingEnabled = true;
            this.cboMaHocSinh.Location = new System.Drawing.Point(619, 112);
            this.cboMaHocSinh.Name = "cboMaHocSinh";
            this.cboMaHocSinh.Size = new System.Drawing.Size(136, 24);
            this.cboMaHocSinh.TabIndex = 50;
            // 
            // cboMaMonHoc
            // 
            this.cboMaMonHoc.FormattingEnabled = true;
            this.cboMaMonHoc.Location = new System.Drawing.Point(976, 118);
            this.cboMaMonHoc.Name = "cboMaMonHoc";
            this.cboMaMonHoc.Size = new System.Drawing.Size(136, 24);
            this.cboMaMonHoc.TabIndex = 51;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 825);
            this.Controls.Add(this.cboMaMonHoc);
            this.Controls.Add(this.cboMaHocSinh);
            this.Controls.Add(this.txtDiem15Phut);
            this.Controls.Add(this.txtDiem45Phut);
            this.Controls.Add(this.txtDiemHocKi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBangDiem";
            this.Text = "Bảng điểm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSua;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnXoa;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroGrid dgvGiaoVien;
        private MetroFramework.Controls.MetroButton btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtDiemHocKi;
        private MetroFramework.Controls.MetroTextBox txtDiem45Phut;
        private MetroFramework.Controls.MetroTextBox txtDiem15Phut;
        private System.Windows.Forms.ComboBox cboMaHocSinh;
        private System.Windows.Forms.ComboBox cboMaMonHoc;
    }
}