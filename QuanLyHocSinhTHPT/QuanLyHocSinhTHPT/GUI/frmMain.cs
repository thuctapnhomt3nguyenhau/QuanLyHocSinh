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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {

            frmGiaoVien frm = new frmGiaoVien();
            frm.Show();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh frm = new frmHocSinh();
            frm.Show();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            frmBangDiem frm = new frmBangDiem();
            frm.Show();
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {

        }
    }
}
