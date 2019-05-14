using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocSinhTHPT.DTO;

namespace QuanLyHocSinhTHPT.DAO
{
    class BangDiemDAO
    {
        private static BangDiemDAO instance;

        internal static BangDiemDAO Instance
        {
            get { if (instance == null) instance = new BangDiemDAO(); return instance; }
            private set { instance = value; }
        }
        public List<BangDiemDTO> GetAll()
        {
            List<BangDiemDTO> list = new List<BangDiemDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_BangDiem_GetAll");
            foreach (DataRow item in data.Rows)
            {
                BangDiemDTO entry = new BangDiemDTO(item);
                list.Add(entry);
            }
            return list;
        }
        public List<BangDiemDTO> GetByIdMonHoc(int idMonHoc)
        {
            List<BangDiemDTO> list = new List<BangDiemDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_BangDiem_GetByIdMonHoc @idMonHoc", new object[] { idMonHoc });
            foreach (DataRow item in data.Rows)
            {
                BangDiemDTO entry = new BangDiemDTO(item);
                list.Add(entry);
            }
            return list;
        }
        public bool Insert(float diem15phut, float diem45phut, float diemHocKi, int idMonHoc, int idHocSinh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_BangDiem_Insert @diem15phut , @diem45phut , @diemHocKi , @idMonHoc , @idHocSinh", new object[] { diem15phut, diem45phut, diemHocKi, idMonHoc, idHocSinh });
            return result > 0;
        }
        public bool Update(int idBangDiem, float diem15phut, float diem45phut, float diemHocKi, int idMonHoc, int idHocSinh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_BangDiem_Update @idBangDiem , @diem15phut , @diem45phut , @diemHocKi , @idMonHoc , @idHocSinh", new object[] {idBangDiem, diem15phut, diem45phut, diemHocKi, idMonHoc, idHocSinh });
            return result > 0;
        }
        public bool Delete(int idBangDiem)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_BangDiem_Delete @idBangDiem", new object[] { idBangDiem });

            return result > 0;
        }
        public List<BangDiemDTO> Search(string searchValue)
        {
            List<BangDiemDTO> list = new List<BangDiemDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_BangDiem_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                BangDiemDTO entry = new BangDiemDTO(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
