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
    public partial class frmHocSinh : Form
    {
        BindingSource hocSinhList = new BindingSource();

        public frmHocSinh()
        {
            InitializeComponent();
            LoadFirstTime();
        }
        private void LoadFirstTime()
        {
            dgvHocSinh.DataSource = hocSinhList;
            LoadListHocSinh();
            LoadComboboxLopHoc();
            EditDataGridView();
            BindingDataToFrom();
        }
        private void LoadListHocSinh()
        {
            hocSinhList.DataSource = HocSinhDAO.Instance.GetAll();
        }
        private void EditDataGridView()
        {
            dgvHocSinh.Columns["IDHocSinh"].HeaderText = "ID Học sinh";
            dgvHocSinh.Columns["TenHocSinh"].HeaderText = "Tên học sinh";
            dgvHocSinh.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvHocSinh.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns["IdLopHoc"].HeaderText = "Lớp học";
        }
        private void BindingDataToFrom()
        {
            txtIdHocSinh.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "IDHocSinh", true, DataSourceUpdateMode.Never));
            txtTenHocSinh.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "TenHocSinh", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            cboIdLopHoc.DataBindings.Add(new Binding("Text", dgvHocSinh.DataSource, "IdLopHoc", true, DataSourceUpdateMode.Never));
            var fmaleBinding = new Binding("Checked", dgvHocSinh.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            fmaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nữ";
            fmaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nữ" : "Nam";
            rdbNu.DataBindings.Add(fmaleBinding);
            rdbNu.CheckedChanged += (s, args) => rdbNam.Checked = !rdbNu.Checked;
        }
        private void LoadComboboxLopHoc()
        {
            cboIdLopHoc.DataSource = HocSinhDAO.Instance.GetListLopHoc();
            cboIdLopHoc.DisplayMember = "IdLopHoc";
        }
        private void MakeNull()
        {
            txtIdHocSinh.Text = "";
            txtTenHocSinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtTimKiem.Text = "";
            LoadComboboxLopHoc();
        }
        private void btnLamTrong_Click(object sender, EventArgs e)
        {
            MakeNull();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenHocSinh = txtTenHocSinh.Text;
            int idLopHoc = -1;
            Int32.TryParse(cboIdLopHoc.Text, out idLopHoc);
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh;
            DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
            try
            {
                if (tenHocSinh == "" || idLopHoc == -1 || ngaySinh == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                HocSinhDAO.Instance.Insert(tenHocSinh, gioiTinh, ngaySinh, idLopHoc);
                MessageBox.Show("Thêm thành công");
                LoadListHocSinh();
            } catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListHocSinh();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int idHocSinh ;
            Int32.TryParse(txtIdHocSinh.Text.Trim(), out idHocSinh);
            string tenHocSinh = txtTenHocSinh.Text.Trim();
            int idLopHoc = -1;
            Int32.TryParse(cboIdLopHoc.Text.Trim(), out idLopHoc);
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh;
            DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
            try
            {
                if (tenHocSinh == "" || idLopHoc == -1 || ngaySinh == null || idHocSinh == -1)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                    return;
                }
                HocSinhDAO.Instance.Update(idHocSinh,tenHocSinh, gioiTinh, ngaySinh, idLopHoc);
                MessageBox.Show("Sửa thành công");
                LoadListHocSinh();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListHocSinh();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string str = txtTimKiem.Text.Trim();
            if (str == "") {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm");
                return;
            } 
            hocSinhList.DataSource = HocSinhDAO.Instance.Search(str);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            hocSinhList.DataSource = HocSinhDAO.Instance.GetAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idHocSinh;
            Int32.TryParse(txtIdHocSinh.Text.Trim(), out idHocSinh);
            try
            {
                HocSinhDAO.Instance.Delete(idHocSinh);
                MessageBox.Show("Xóa thành công");
                LoadListHocSinh();
            }
            catch (Exception err)
            {
                MessageBox.Show("Có lỗi xảy ra" + err.ToString());
                LoadListHocSinh();
            }
        }
    }
}
