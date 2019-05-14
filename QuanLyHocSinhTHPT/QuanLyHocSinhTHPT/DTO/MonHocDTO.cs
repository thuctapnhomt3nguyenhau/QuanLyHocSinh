using System;
using System.Data;

namespace QuanLyHocSinhTHPT.DTO
{
    class MonHocDTO
    {
        private int idMonHoc;
        private string tenMonHoc;
        private int soTietHoc;
        private string namHoc;
        private int kiHoc;
        private int idGiaoVien;

        public int IdMonHoc { get => idMonHoc; set => idMonHoc = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTietHoc { get => soTietHoc; set => soTietHoc = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
        public int KiHoc { get => kiHoc; set => kiHoc = value; }
        public int IdGiaoVien { get => idGiaoVien; set => idGiaoVien = value; }

        public MonHocDTO() { }

        public MonHocDTO(int idMonHoc, string tenMonHoc, int soTietHoc, string namHoc, int kiHoc, int idGiaoVien)
        {
            this.idMonHoc = idMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.soTietHoc = soTietHoc;
            this.namHoc = namHoc;
            this.kiHoc = kiHoc;
            this.idGiaoVien = idGiaoVien;
        } 

        public MonHocDTO(DataRow row)
        {
            Int32.TryParse(row["idMonHoc"].ToString(), out this.idMonHoc);
            Int32.TryParse(row["idGiaoVien"].ToString(), out this.idGiaoVien);
            Int32.TryParse(row["kiHoc"].ToString(), out this.kiHoc);
            Int32.TryParse(row["soTietHoc"].ToString(), out this.soTietHoc);
            this.tenMonHoc = row["tenMonHoc"].ToString();
            this.namHoc = row["namHoc"].ToString();
        }
    }
}
