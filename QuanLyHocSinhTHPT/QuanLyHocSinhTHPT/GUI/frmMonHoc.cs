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
    public partial class frmMonHoc : Form
    {
        BindingSource monHocList = new BindingSource();

        public frmMonHoc()
        {
            InitializeComponent();
            LoadFirstTime();
        }
        private void LoadFirstTime()
        {
            dgvMonHoc.DataSource = monHocList;
            LoadListMonHoc();
            EditDataGridView();
            BindingDataToFrom();
            LoadComboboxIdGiaoVien();
        }
        private void LoadListMonHoc()
        {
            monHocList.DataSource = MonHocDAO.Instance.GetAll();
        }
        private void EditDataGridView()
        {
            dgvMonHoc.Columns["IdMonHoc"].HeaderText = "ID Môn học";
            dgvMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
            dgvMonHoc.Columns["SoTietHoc"].HeaderText = "Số tiết học";
            dgvMonHoc.Columns["NamHoc"].HeaderText = "Năm học";
            dgvMonHoc.Columns["KiHoc"].HeaderText = "Kì học";
            dgvMonHoc.Columns["IdGiaoVien"].HeaderText = "Id giáo viên";
        }
        private void BindingDataToFrom()
        {
            txtIdMonHoc.DataBindings.Add(new Binding("Text", dgvMonHoc.DataSource, "IdMonHoc", true, DataSourceUpdateMode.Never));
            txtTenMonHoc.DataBindings.Add(new Binding("Text", dgvMonHoc.DataSource, "TenMonHoc", true, DataSourceUpdateMode.Never));
            txtSoTietHoc.DataBindings.Add(new Binding("Text", dgvMonHoc.DataSource, "SoTietHoc", true, DataSourceUpdateMode.Never));
            txtNamHoc.DataBindings.Add(new Binding("Text", dgvMonHoc.DataSource, "NamHoc", true, DataSourceUpdateMode.Never));
            txtKiHoc.DataBindings.Add(new Binding("Text", dgvMonHoc.DataSource, "KiHoc", true, DataSourceUpdateMode.Never));
            cboIdGiaoVien.DataBindings.Add(new Binding("Text", dgvMonHoc.DataSource, "IdGiaoVien", true, DataSourceUpdateMode.Never));
        }
        private void LoadComboboxIdGiaoVien()
        {
            cboIdGiaoVien.DataSource = GiaoVienDAO.Instance.GetAll();
            cboIdGiaoVien.DisplayMember = "IdGiaoVien";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = txtTimKiem.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            monHocList.DataSource = MonHocDAO.Instance.Search(str);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListMonHoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idMonHoc;
            Int32.TryParse(txtIdMonHoc.Text.Trim(), out idMonHoc);
            try
            {
                MonHocDAO.Instance.Delete(idMonHoc);
                MessageBox.Show("Xóa thành công");
                LoadListMonHoc();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListMonHoc();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMonHoc = txtTenMonHoc.Text;
            int soTietHoc = -1;
            Int32.TryParse(txtSoTietHoc.Text, out soTietHoc);
            int idGiaoVien = -1;
            Int32.TryParse(cboIdGiaoVien.Text, out idGiaoVien);
            string namHoc = txtNamHoc.Text;
            int kiHoc = -1;
            Int32.TryParse(txtKiHoc.Text, out kiHoc);

            try
            {
                if (tenMonHoc == "" || namHoc == "" || soTietHoc == -1 || kiHoc == -1 || idGiaoVien == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                MonHocDAO.Instance.Insert(tenMonHoc, soTietHoc, namHoc, kiHoc, idGiaoVien);
                MessageBox.Show("Thêm thành công");
                LoadListMonHoc();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListMonHoc();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int idMonHoc = -1;
            Int32.TryParse(txtIdMonHoc.Text, out idMonHoc);
            string tenMonHoc = txtTenMonHoc.Text;
            int soTietHoc = -1;
            Int32.TryParse(txtSoTietHoc.Text, out soTietHoc);
            int idGiaoVien = -1;
            Int32.TryParse(cboIdGiaoVien.Text, out idGiaoVien);
            string namHoc = txtNamHoc.Text;
            int kiHoc = -1;
            Int32.TryParse(txtKiHoc.Text, out kiHoc);

            try
            {
                if (idMonHoc == -1 || tenMonHoc == "" || namHoc == "" || soTietHoc == -1 || kiHoc == -1 || idGiaoVien == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                MonHocDAO.Instance.Update(idMonHoc, tenMonHoc, soTietHoc, namHoc, kiHoc, idGiaoVien);
                MessageBox.Show("Cập nhật thành công");
                LoadListMonHoc();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListMonHoc();
            }
        }

        
    }
}
