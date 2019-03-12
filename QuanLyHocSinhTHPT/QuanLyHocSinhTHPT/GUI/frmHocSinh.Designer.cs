namespace QuanLyHocSinhTHPT.GUI
{
    partial class frmHocSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new MetroFramework.Controls.MetroTextBox();
            this.txtTenHocSinh = new MetroFramework.Controls.MetroTextBox();
            this.txtDiaChi = new MetroFramework.Controls.MetroTextBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.dtpNgaySinh = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.dgvHocSinh = new MetroFramework.Controls.MetroGrid();
            this.maSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuayLai = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(39, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên học sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(38, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(39, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(38, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(38, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // txtMaHocSinh
            // 
            // 
            // 
            // 
            this.txtMaHocSinh.CustomButton.Image = null;
            this.txtMaHocSinh.CustomButton.Location = new System.Drawing.Point(306, 2);
            this.txtMaHocSinh.CustomButton.Name = "";
            this.txtMaHocSinh.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtMaHocSinh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMaHocSinh.CustomButton.TabIndex = 1;
            this.txtMaHocSinh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMaHocSinh.CustomButton.UseSelectable = true;
            this.txtMaHocSinh.CustomButton.Visible = false;
            this.txtMaHocSinh.Lines = new string[0];
            this.txtMaHocSinh.Location = new System.Drawing.Point(42, 127);
            this.txtMaHocSinh.MaxLength = 32767;
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.PasswordChar = '\0';
            this.txtMaHocSinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMaHocSinh.SelectedText = "";
            this.txtMaHocSinh.SelectionLength = 0;
            this.txtMaHocSinh.SelectionStart = 0;
            this.txtMaHocSinh.ShortcutsEnabled = true;
            this.txtMaHocSinh.Size = new System.Drawing.Size(334, 30);
            this.txtMaHocSinh.TabIndex = 1;
            this.txtMaHocSinh.UseSelectable = true;
            this.txtMaHocSinh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMaHocSinh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenHocSinh
            // 
            // 
            // 
            // 
            this.txtTenHocSinh.CustomButton.Image = null;
            this.txtTenHocSinh.CustomButton.Location = new System.Drawing.Point(306, 2);
            this.txtTenHocSinh.CustomButton.Name = "";
            this.txtTenHocSinh.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTenHocSinh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenHocSinh.CustomButton.TabIndex = 1;
            this.txtTenHocSinh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenHocSinh.CustomButton.UseSelectable = true;
            this.txtTenHocSinh.CustomButton.Visible = false;
            this.txtTenHocSinh.Lines = new string[0];
            this.txtTenHocSinh.Location = new System.Drawing.Point(42, 205);
            this.txtTenHocSinh.MaxLength = 32767;
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.PasswordChar = '\0';
            this.txtTenHocSinh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenHocSinh.SelectedText = "";
            this.txtTenHocSinh.SelectionLength = 0;
            this.txtTenHocSinh.SelectionStart = 0;
            this.txtTenHocSinh.ShortcutsEnabled = true;
            this.txtTenHocSinh.Size = new System.Drawing.Size(334, 30);
            this.txtTenHocSinh.TabIndex = 2;
            this.txtTenHocSinh.UseSelectable = true;
            this.txtTenHocSinh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenHocSinh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.CustomButton.Image = null;
            this.txtDiaChi.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.txtDiaChi.CustomButton.Name = "";
            this.txtDiaChi.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txtDiaChi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiaChi.CustomButton.TabIndex = 1;
            this.txtDiaChi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiaChi.CustomButton.UseSelectable = true;
            this.txtDiaChi.CustomButton.Visible = false;
            this.txtDiaChi.Lines = new string[0];
            this.txtDiaChi.Location = new System.Drawing.Point(42, 376);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.SelectionLength = 0;
            this.txtDiaChi.SelectionStart = 0;
            this.txtDiaChi.ShortcutsEnabled = true;
            this.txtDiaChi.Size = new System.Drawing.Size(334, 100);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.UseSelectable = true;
            this.txtDiaChi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiaChi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(270, 261);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(42, 17);
            this.metroRadioButton1.TabIndex = 4;
            this.metroRadioButton1.Text = "Nữ";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(164, 261);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(52, 17);
            this.metroRadioButton2.TabIndex = 3;
            this.metroRadioButton2.Text = "Nam";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(150, 293);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(226, 30);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(60, 514);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(130, 50);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Thêm";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(218, 514);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(130, 50);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Cập nhật";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(218, 590);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(130, 50);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Xóa";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(60, 590);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(130, 50);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "Làm mới";
            this.metroButton4.UseSelectable = true;
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToResizeRows = false;
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHocSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHocSinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHocSinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSinhVien,
            this.tenHocSinh,
            this.gioiTinh,
            this.ngaySinh,
            this.diaChi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocSinh.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHocSinh.EnableHeadersVisualStyles = false;
            this.dgvHocSinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvHocSinh.GridColor = System.Drawing.Color.White;
            this.dgvHocSinh.Location = new System.Drawing.Point(424, 127);
            this.dgvHocSinh.MultiSelect = false;
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHocSinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHocSinh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHocSinh.RowTemplate.Height = 24;
            this.dgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinh.Size = new System.Drawing.Size(1114, 682);
            this.dgvHocSinh.TabIndex = 11;
            // 
            // maSinhVien
            // 
            this.maSinhVien.HeaderText = "Mã sinh viên";
            this.maSinhVien.Name = "maSinhVien";
            // 
            // tenHocSinh
            // 
            this.tenHocSinh.HeaderText = "Tên học sinh";
            this.tenHocSinh.Name = "tenHocSinh";
            // 
            // gioiTinh
            // 
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // ngaySinh
            // 
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // diaChi
            // 
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(1332, 63);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(119, 58);
            this.btnQuayLai.TabIndex = 12;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseSelectable = true;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 864);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenHocSinh);
            this.Controls.Add(this.txtMaHocSinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHocSinh";
            this.Text = "Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtMaHocSinh;
        private MetroFramework.Controls.MetroTextBox txtTenHocSinh;
        private MetroFramework.Controls.MetroTextBox txtDiaChi;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroDateTime dtpNgaySinh;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroGrid dgvHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private MetroFramework.Controls.MetroButton btnQuayLai;
    }
}