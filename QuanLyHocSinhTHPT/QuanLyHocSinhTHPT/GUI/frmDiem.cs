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
    public partial class frmDiem : Form
    {
        BindingSource diemSoList = new BindingSource();
        BindingSource monHocList = new BindingSource();

        public frmDiem()
        {
            InitializeComponent();
            LoadFirstTime();
        }
        private void LoadFirstTime()
        {
            dgvMonHoc.DataSource = monHocList;
            dgvDiemSo.DataSource = diemSoList;
            LoadListMonHoc();
            EditDataGridView();
            BindingDataToFrom();
            LoadComboboxIdHocSinh();
            int idMonHoc;
            Int32.TryParse(txtIdMonHoc.Text, out idMonHoc);
            diemSoList.DataSource = BangDiemDAO.Instance.GetByIdMonHoc(idMonHoc);

        }
        private void LoadComboboxIdHocSinh()
        {
            cboHocSinh.DataSource = HocSinhDAO.Instance.GetAll();
            cboHocSinh.DisplayMember = "IdHocSinh";
            cboHocSinh.ValueMember = "IdHocSinh";
        }
  
        private void LoadListMonHoc()
        {
            monHocList.DataSource = MonHocDAO.Instance.GetAll();
            diemSoList.DataSource = BangDiemDAO.Instance.GetAll();
        }
        private void LoadListDiemSo(int idMonHoc)
        {
            diemSoList.DataSource = BangDiemDAO.Instance.GetByIdMonHoc(idMonHoc);
        }
        private void EditDataGridView()
        {
            dgvMonHoc.Columns["IdMonHoc"].HeaderText = "Id Môn học";
            dgvMonHoc.Columns["TenMonHoc"].HeaderText = "Tên môn học";
            dgvMonHoc.Columns["TenMonHoc"].FillWeight = 200;
            dgvMonHoc.Columns["SoTietHoc"].HeaderText = "Số tiết học";
            dgvMonHoc.Columns["NamHoc"].HeaderText = "Năm học";
            dgvMonHoc.Columns["KiHoc"].HeaderText = "Kì học";
            dgvMonHoc.Columns["IdGiaoVien"].HeaderText = "ID Giáo viên";
            dgvMonHoc.Columns["IdGiaoVien"].Visible = false;
            
            dgvDiemSo.Columns["IdBangDiem"].HeaderText = "Id điểm";
            dgvDiemSo.Columns["Diem15phut"].HeaderText = "Điểm 15'";
            dgvDiemSo.Columns["Diem45phut"].HeaderText = "Điểm 45'";
            dgvDiemSo.Columns["DiemHocKi"].HeaderText = "Điểm học kì";
            dgvDiemSo.Columns["IdMonHoc"].HeaderText = "Id môn học";
            dgvDiemSo.Columns["IdMonHoc"].Visible = false;

            txtIdMonHoc.DataBindings.Add(new Binding("Text", dgvMonHoc.DataSource, "IdMonHoc", true, DataSourceUpdateMode.Never));
            dgvDiemSo.Columns["IdHocSinh"].HeaderText = "Id học sinh";
        }
        private void BindingDataToFrom()
        {
            txtIdDiem.DataBindings.Add(new Binding("Text", dgvDiemSo.DataSource, "IdBangDiem", true, DataSourceUpdateMode.Never));
            txtDiem15phut.DataBindings.Add(new Binding("Text", dgvDiemSo.DataSource, "Diem15phut", true, DataSourceUpdateMode.Never));
            txtDiem45phut.DataBindings.Add(new Binding("Text", dgvDiemSo.DataSource, "Diem45phut", true, DataSourceUpdateMode.Never));
            txtDiemHocKi.DataBindings.Add(new Binding("Text", dgvDiemSo.DataSource, "DiemHocKi", true, DataSourceUpdateMode.Never));
            cboHocSinh.DataBindings.Add(new Binding("Text", dgvDiemSo.DataSource, "IdHocSinh", true, DataSourceUpdateMode.Never));
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idMonHoc;
            Int32.TryParse(txtIdMonHoc.Text, out idMonHoc);
            diemSoList.DataSource = BangDiemDAO.Instance.GetByIdMonHoc(idMonHoc);
        }
        private void MakeNull()
        {
            txtDiemHocKi.Text = "";
            txtDiem15phut.Text = "";
            txtDiem45phut.Text = "";
            cboHocSinh.DataSource = HocSinhDAO.Instance.GetAll();
        }
        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            MakeNull();
        }
        private void LoadList()
        {
            int idMonHoc;
            Int32.TryParse(txtIdMonHoc.Text, out idMonHoc);
            diemSoList.DataSource = BangDiemDAO.Instance.GetAll();
            monHocList.DataSource = MonHocDAO.Instance.GetAll();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = txtTimKiem.Text.Trim();
            if (str == "")
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            }
            monHocList.DataSource = MonHocDAO.Instance.Search(str);
            diemSoList.DataSource = BangDiemDAO.Instance.Search(str);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListMonHoc();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idDiem;
            Int32.TryParse(txtIdDiem.Text.Trim(), out idDiem);
            try
            {
                BangDiemDAO.Instance.Delete(idDiem);
                MessageBox.Show("Xóa thành công");
                monHocList.DataSource = MonHocDAO.Instance.GetAll();
                diemSoList.DataSource = BangDiemDAO.Instance.GetAll();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                monHocList.DataSource = MonHocDAO.Instance.GetAll();
                diemSoList.DataSource = BangDiemDAO.Instance.GetAll();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float diem15 = -1;
            float.TryParse(txtDiem15phut.Text.Trim(), out diem15);

            float diem45 = -1;
            float.TryParse(txtDiem45phut.Text.Trim(), out diem45);

            float diemHocKi = -1;
            float.TryParse(txtDiemHocKi.Text.Trim(), out diemHocKi);

            int idMonHoc = -1;
            Int32.TryParse(txtIdMonHoc.Text.Trim(), out idMonHoc);

            int idHocSinh = -1;
            Int32.TryParse(cboHocSinh.Text.Trim(), out idHocSinh);
            try
            {
                if (diem15 == -1 || diem45 == -1 || diemHocKi == -1 || idMonHoc == -1 || idHocSinh == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                BangDiemDAO.Instance.Insert(diem15, diem45, diemHocKi, idMonHoc, idHocSinh);
                MessageBox.Show("Thêm thành công");
                LoadList();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadList();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idDiem = -1;
            Int32.TryParse(txtIdDiem.Text.Trim(), out idDiem);

            float diem15 = -1;
            float.TryParse(txtDiem15phut.Text.Trim(), out diem15);

            float diem45 = -1;
            float.TryParse(txtDiem45phut.Text.Trim(), out diem45);

            float diemHocKi = -1;
            float.TryParse(txtDiemHocKi.Text.Trim(), out diemHocKi);

            int idMonHoc = -1;
            Int32.TryParse(txtIdMonHoc.Text.Trim(), out idMonHoc);

            int idHocSinh = -1;
            Int32.TryParse(cboHocSinh.Text.Trim(), out idHocSinh);
            try
            {
                if (idDiem == -1 || diem15 == -1 || diem45 == -1 || diemHocKi == -1 || idMonHoc == -1 || idHocSinh == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                BangDiemDAO.Instance.Update(idDiem, diem15, diem45, diemHocKi, idMonHoc, idHocSinh);
                MessageBox.Show("Cập nhật thành công");
                LoadList();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadList();
            }
        }
    }
}
