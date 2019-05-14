using System;
using System.Data;

namespace QuanLyHocSinhTHPT.DTO
{
    class BangDiemDTO
    {
        private int idBangDiem;
        private float diem15phut;
        private float diem45phut;
        private float diemHocKi;
        private int idMonHoc;
        private int idHocSinh;

        public int IdBangDiem { get => idBangDiem; set => idBangDiem = value; }
        public float Diem15phut { get => diem15phut; set => diem15phut = value; }
        public float Diem45phut { get => diem45phut; set => diem45phut = value; }
        public float DiemHocKi { get => diemHocKi; set => diemHocKi = value; }
        public int IdMonHoc { get => idMonHoc; set => idMonHoc = value; }
        public int IdHocSinh { get => idHocSinh; set => idHocSinh = value; }

        public BangDiemDTO() { }

        public BangDiemDTO(int idBangDiem, float diem15phut, float diem45phut, float diemHocKi, int idMonHoc, int idHocSinh)
        {
            this.idBangDiem = idBangDiem;
            this.diem15phut = diem15phut;
            this.diem45phut = diem45phut;
            this.diemHocKi = diemHocKi;
            this.idMonHoc = idMonHoc;
            this.idHocSinh = idHocSinh;
        }

        public BangDiemDTO(DataRow row)
        {
            Int32.TryParse(row["idBangDiem"].ToString(), out this.idBangDiem);
            Int32.TryParse(row["idMonHoc"].ToString(), out this.idMonHoc);
            Int32.TryParse(row["idHocSinh"].ToString(), out this.idHocSinh);
            float.TryParse(row["diem15phut"].ToString(), out this.diem15phut);
            float.TryParse(row["diem45phut"].ToString(), out this.diem45phut);
            float.TryParse(row["diemHocKi"].ToString(), out this.diemHocKi);
        }
    }
}
