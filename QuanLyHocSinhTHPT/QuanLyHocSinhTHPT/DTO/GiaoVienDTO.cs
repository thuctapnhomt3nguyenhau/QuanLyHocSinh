using System;
using System.Data;


namespace QuanLyHocSinhTHPT.DTO
{
    class GiaoVienDTO
    {
        private int idGiaoVien;
        private string tenGiaoVien;
        private string gioiTinh;
        private DateTime ngaySinh;
        private int soDienThoai;

        public int IdGiaoVien { get => idGiaoVien; set => idGiaoVien = value; }
        public string TenGiaoVien { get => tenGiaoVien; set => tenGiaoVien = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public int SoDienThoai { get => soDienThoai; set => soDienThoai = value; }

        public GiaoVienDTO() { }

        public GiaoVienDTO(int idGiaoVien, string tenGiaoVien, string gioiTinh, DateTime ngaySinh, int soDienThoai)
        {
            this.idGiaoVien = idGiaoVien;
            this.tenGiaoVien = tenGiaoVien;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.soDienThoai = soDienThoai;
        }

        public GiaoVienDTO(DataRow row)
        {
            Int32.TryParse(row["idGiaoVien"].ToString(), out this.idGiaoVien);
            Int32.TryParse(row["soDienThoai"].ToString(), out this.soDienThoai);
            this.tenGiaoVien = row["tenGiaoVien"].ToString();
            this.gioiTinh = row["gioiTinh"].ToString();
            this.ngaySinh = (DateTime)row["ngaySinh"];
        }


    }
}
