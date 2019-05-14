using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocSinhTHPT.DTO;

namespace QuanLyHocSinhTHPT.DAO
{
    class LopHocDAO
    {
        private static LopHocDAO instance;

        internal static LopHocDAO Instance
        {
            get { if (instance == null) instance = new LopHocDAO(); return instance; }
            private set { instance = value; }
        }
        public List<LopHocDTO> GetAll()
        {
            List<LopHocDTO> list = new List<LopHocDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_LopHoc_GetAll");
            foreach (DataRow item in data.Rows)
            {
                LopHocDTO entry = new LopHocDTO(item);
                list.Add(entry);
            }
            return list;
        }
        public bool Insert(string tenLopHoc, string tenKhoi, int idGiaoVienChuNhiem, string namHoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_LopHoc_Insert @tenLopHoc , @tenKhoi , @namHoc , @idGiaoVienChuNhiem", new object[] { tenLopHoc, tenKhoi, namHoc, idGiaoVienChuNhiem });
            return result > 0;
        }
        public bool Update(int idLopHoc, string tenLopHoc, string tenKhoi, int idGiaoVienChuNhiem, string namHoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_LopHoc_Update @idLopHoc , @tenLopHoc , @tenKhoi , @namHoc , @idGiaoVienChuNhiem", new object[] {idLopHoc, tenLopHoc, tenKhoi, namHoc, idGiaoVienChuNhiem });
            return result > 0;
        }
        public bool Delete(int idLopHoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_LopHoc_Delete @idLopHoc", new object[] { idLopHoc });

            return result > 0;
        }
        public List<LopHocDTO> Search(string searchValue)
        {
            List<LopHocDTO> list = new List<LopHocDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_LopHoc_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                LopHocDTO entry = new LopHocDTO(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
