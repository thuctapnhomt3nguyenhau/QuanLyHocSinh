using System;
using System.Data;


namespace QuanLyHocSinhTHPT.DTO
{
    class LopHocDTO
    {
        private int idLopHoc;
        private string tenLopHoc;
        private string tenKhoi;
        private string namHoc;
        private int idGiaoVienChuNhiem;

        public int IdLopHoc { get => idLopHoc; set => idLopHoc = value; }
        public string TenLopHoc { get => tenLopHoc; set => tenLopHoc = value; }
        public string TenKhoi { get => tenKhoi; set => tenKhoi = value; }
        public string NamHoc { get => namHoc; set => namHoc = value; }
        public int IdGiaoVienChuNhiem { get => idGiaoVienChuNhiem; set => idGiaoVienChuNhiem = value; }

        public LopHocDTO() { }

        public LopHocDTO(int idLopHoc, string tenLopHoc, string tenKhoi, string namHoc, int idGiaoVienChuNhiem)
        {
            this.idLopHoc = idLopHoc;
            this.tenLopHoc = tenLopHoc;
            this.tenKhoi = tenKhoi;
            this.namHoc = namHoc;
            this.idGiaoVienChuNhiem = idGiaoVienChuNhiem;
        }

        public LopHocDTO(DataRow row)
        {
            Int32.TryParse(row["idLopHoc"].ToString(), out this.idLopHoc);
            Int32.TryParse(row["idGiaoVienChuNhiem"].ToString(), out this.idGiaoVienChuNhiem);
            this.tenLopHoc = row["tenLopHoc"].ToString();
            this.tenKhoi = row["tenKhoi"].ToString();
            this.namHoc = row["namHoc"].ToString();
        }
    }
}
