using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhTHPT.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc frm = new frmMonHoc();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            frmDiem frm = new frmDiem();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien frm = new frmGiaoVien();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            frmLopHoc frm = new frmLopHoc();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
