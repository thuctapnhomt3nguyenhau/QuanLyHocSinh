using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyHocSinhTHPT.DAO;

namespace QuanLyHocSinhTHPT.GUI
{
    public partial class frmGiaoVien : Form
    {
        BindingSource giaoVienList = new BindingSource();

        public frmGiaoVien()
        {
            InitializeComponent();
            LoadFirstTime();
        }
        private void LoadFirstTime()
        {
            dgvGiaoVien.DataSource = giaoVienList;
            LoadListGiaoVien();
            EditDataGridView();
            BindingDataToFrom();
        }
        private void LoadListGiaoVien()
        {
            giaoVienList.DataSource = GiaoVienDAO.Instance.GetAll(); 
        }
        private void EditDataGridView()
        {
            dgvGiaoVien.Columns["IdGiaoVien"].HeaderText = "ID Giáo viên";
            dgvGiaoVien.Columns["TenGiaoVien"].HeaderText = "Tên giáo viên";
            dgvGiaoVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvGiaoVien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvGiaoVien.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
        }
        private void BindingDataToFrom()
        {
            txtIdGiaoVien.DataBindings.Add(new Binding("Text", dgvGiaoVien.DataSource, "IdGiaoVien", true, DataSourceUpdateMode.Never));
            txtSoDienThoai.DataBindings.Add(new Binding("Text", dgvGiaoVien.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never));
            txtTenGiaoVien.DataBindings.Add(new Binding("Text", dgvGiaoVien.DataSource, "TenGiaoVien", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgvGiaoVien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            var fmaleBinding = new Binding("Checked", dgvGiaoVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            fmaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nữ";
            fmaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nữ" : "Nam";
            rdbNu.DataBindings.Add(fmaleBinding);
            rdbNu.CheckedChanged += (s, args) => rdbNam.Checked = !rdbNu.Checked;
        }
        private void MakeNull()
        {
            txtIdGiaoVien.Text = "";
            txtSoDienThoai.Text = "";
            txtTenGiaoVien.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtTimKiem.Text = "";
        }

        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            MakeNull();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = txtTimKiem.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            giaoVienList.DataSource = GiaoVienDAO.Instance.Search(str);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListGiaoVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idGiaoVien;
            Int32.TryParse(txtIdGiaoVien.Text.Trim(), out idGiaoVien);
            try
            {
                GiaoVienDAO.Instance.Delete(idGiaoVien);
                MessageBox.Show("Xóa thành công");
                LoadListGiaoVien();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListGiaoVien();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenGiaoVien = txtTenGiaoVien.Text.Trim();
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh;
            DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
            string soDienThoai = txtSoDienThoai.Text;

            try
            {
                if(tenGiaoVien == "" || ngaySinh == null || soDienThoai == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                GiaoVienDAO.Instance.Insert(tenGiaoVien, gioiTinh, ngaySinh, soDienThoai);
                MessageBox.Show("Thêm thành công");
                LoadListGiaoVien();
            } catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListGiaoVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idGiaoVien = -1;
            Int32.TryParse(txtIdGiaoVien.Text.Trim(), out idGiaoVien);

            string tenGiaoVien = txtTenGiaoVien.Text.Trim();
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh;
            DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
            string soDienThoai = txtSoDienThoai.Text;

            try
            {
                if (tenGiaoVien == "" || ngaySinh == null || soDienThoai == "" || idGiaoVien == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                GiaoVienDAO.Instance.Update(idGiaoVien, tenGiaoVien, gioiTinh, ngaySinh, soDienThoai);
                MessageBox.Show("Sửa thành công");
                LoadListGiaoVien();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListGiaoVien();
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch!= 46)
            {
                e.Handled = true;
            }
        }
    }
}
