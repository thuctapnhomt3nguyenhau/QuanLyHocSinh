using System;
using System.Data;

namespace QuanLyHocSinhTHPT.DTO
{
    class HocSinhDTO
    {
        private int idHocSinh;
        private string tenHocSinh;
        private string gioiTinh;
        private DateTime ngaySinh;
        private int idLopHoc;

        public int IdHocSinh { get => idHocSinh; set => idHocSinh = value; }
        public string TenHocSinh { get => tenHocSinh; set => tenHocSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int IdLopHoc { get => idLopHoc; set => idLopHoc = value; }

        public HocSinhDTO()
        {
            // Default constructor
        }

        public HocSinhDTO(int idHocSinh, string tenHocSinh, string gioiTinh, DateTime ngaySinh, int idLopHoc)
        {
            this.idHocSinh = idHocSinh;
            this.tenHocSinh = tenHocSinh;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.idLopHoc = idLopHoc;
        }

        public HocSinhDTO(DataRow row)
        {
            Int32.TryParse(row["idHocSinh"].ToString(), out this.idHocSinh);
            this.tenHocSinh = row["tenHocSinh"].ToString();
            this.gioiTinh = row["gioiTinh"].ToString();
            this.ngaySinh = (DateTime)row["ngaySinh"];
            Int32.TryParse(row["idLopHoc"].ToString(), out this.idLopHoc);
        }

    }
}
