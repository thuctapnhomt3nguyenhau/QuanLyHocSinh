using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocSinhTHPT.DTO;

namespace QuanLyHocSinhTHPT.DAO
{
    class MonHocDAO
    {
        private static MonHocDAO instance;

        internal static MonHocDAO Instance
        {
            get { if (instance == null) instance = new MonHocDAO(); return instance; }
            private set { instance = value; }
        }
        public List<MonHocDTO> GetAll()
        {
            List<MonHocDTO> list = new List<MonHocDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_MonHoc_GetAll");
            foreach (DataRow item in data.Rows)
            {
                MonHocDTO entry = new MonHocDTO(item);
                list.Add(entry);
            }
            return list;
        }
        public bool Insert(string tenMonHoc, int soTietHoc, string namHoc, int kiHoc,int idGiaoVien)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_MonHoc_Insert @tenMonHoc , @soTietHoc , @namHoc , @kiHoc , @idGiaoVien", new object[] { tenMonHoc, soTietHoc, namHoc, kiHoc, idGiaoVien });
            return result > 0;
        }
        public bool Update(int idMonHoc, string tenMonHoc, int soTietHoc, string namHoc, int kiHoc, int idGiaoVien)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_MonHoc_Update @idMonHoc , @tenMonHoc , @soTietHoc , @namHoc , @kiHoc , @idGiaoVien", new object[] {idMonHoc, tenMonHoc, soTietHoc, namHoc, kiHoc, idGiaoVien });
            return result > 0;
        }
        public bool Delete(int idMonHoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_MonHoc_Delete @idMonHoc", new object[] { idMonHoc });

            return result > 0;
        }
        public List<MonHocDTO> Search(string searchValue)
        {
            List<MonHocDTO> list = new List<MonHocDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_MonHoc_Search @searchValue", new object[] { searchValue});
            foreach (DataRow item in data.Rows)
            {
                MonHocDTO entry = new MonHocDTO(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
