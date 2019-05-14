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
    public partial class frmLopHoc : Form
    {
        BindingSource lopHocList = new BindingSource();

        public frmLopHoc()
        {
            InitializeComponent();
            LoadFirstTime();

        }
        private void LoadFirstTime()
        {
            dgvLopHoc.DataSource = lopHocList;
            LoadListLopHoc();
            EditDataGridView();
            LoadComboboxIdGiaoVienChuNhiem();
            BindingDataToFrom();
        }
        private void LoadListLopHoc()
        {
            lopHocList.DataSource = LopHocDAO.Instance.GetAll();
        }
        private void EditDataGridView()
        {
            dgvLopHoc.Columns["IdLopHoc"].HeaderText = "ID Lớp học";
            dgvLopHoc.Columns["TenLopHoc"].HeaderText = "Tên lớp học";
            dgvLopHoc.Columns["TenKhoi"].HeaderText = "Tên khối";
            dgvLopHoc.Columns["NamHoc"].HeaderText = "Năm học";
            dgvLopHoc.Columns["IdGiaoVienChuNhiem"].HeaderText = "ID Giáo viên chủ nhiệm";
        }
        private void BindingDataToFrom()
        {
            txtIdLopHoc.DataBindings.Add(new Binding("Text", dgvLopHoc.DataSource, "IdLopHoc", true, DataSourceUpdateMode.Never));
            txtTenLopHoc.DataBindings.Add(new Binding("Text", dgvLopHoc.DataSource, "TenLopHoc", true, DataSourceUpdateMode.Never));
            txtTenKhoi.DataBindings.Add(new Binding("Text", dgvLopHoc.DataSource, "TenKhoi", true, DataSourceUpdateMode.Never));
            txtNamHoc.DataBindings.Add(new Binding("Text", dgvLopHoc.DataSource, "NamHoc", true, DataSourceUpdateMode.Never));
            cboIdGiaoVien.DataBindings.Add(new Binding("Text", dgvLopHoc.DataSource, "IdGiaoVienChuNhiem", true, DataSourceUpdateMode.Never));
        }
        private void LoadComboboxIdGiaoVienChuNhiem()
        {
            cboIdGiaoVien.DataSource = GiaoVienDAO.Instance.GetAll();
            cboIdGiaoVien.DisplayMember = "IdGiaoVien";
        }
        private void MakeNull()
        {
            txtIdLopHoc.Text = "";
            txtTenLopHoc.Text = "";
            txtTenKhoi.Text = "";
            txtNamHoc.Text = "";
            txtTimKiem.Text = "";
            LoadComboboxIdGiaoVienChuNhiem();
        }
        
        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            MakeNull();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = txtTimKiem.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            lopHocList.DataSource = LopHocDAO.Instance.Search(str);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListLopHoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idLopHoc;
            Int32.TryParse(txtIdLopHoc.Text.Trim(), out idLopHoc);
            try
            {
                LopHocDAO.Instance.Delete(idLopHoc);
                MessageBox.Show("Xóa thành công");
                LoadListLopHoc();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListLopHoc();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLopHoc = txtTenLopHoc.Text;
            string tenKhoi = txtTenKhoi.Text;
            string namHoc = txtNamHoc.Text;
            int idGiaoVienChuNhiem;
            Int32.TryParse(cboIdGiaoVien.Text, out idGiaoVienChuNhiem);

            try
            {
                if (tenLopHoc == "" || tenKhoi == "" || namHoc == "" || idGiaoVienChuNhiem == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                LopHocDAO.Instance.Insert(tenLopHoc, tenKhoi, idGiaoVienChuNhiem, namHoc);
                MessageBox.Show("Thêm thành công");
                LoadListLopHoc();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListLopHoc();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int idLopHoc = -1;
            Int32.TryParse(txtIdLopHoc.Text, out idLopHoc);
            string tenLopHoc = txtTenLopHoc.Text;
            string tenKhoi = txtTenKhoi.Text;
            string namHoc = txtNamHoc.Text;
            int idGiaoVienChuNhiem;
            Int32.TryParse(cboIdGiaoVien.Text, out idGiaoVienChuNhiem);

            try
            {
                if (idLopHoc == -1 || tenLopHoc == "" || tenKhoi == "" || namHoc == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                LopHocDAO.Instance.Update(idLopHoc, tenLopHoc, tenKhoi, idGiaoVienChuNhiem, namHoc);
                MessageBox.Show("Sửa thành công");
                LoadListLopHoc();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListLopHoc();
            }
        }
    }
}
