using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocSinhTHPT.DTO;

namespace QuanLyHocSinhTHPT.DAO
{
    class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        internal static GiaoVienDAO Instance
        {
            get { if (instance == null) instance = new GiaoVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<GiaoVienDTO> GetAll()
        {
            List<GiaoVienDTO> list = new List<GiaoVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GiaoVien_GetAll");
            foreach (DataRow item in data.Rows)
            {
                GiaoVienDTO entry = new GiaoVienDTO(item);
                list.Add(entry);
            }
            return list;
        }

        public bool Insert(string tenGiaoVien, string gioiTinh, DateTime ngaySinh, string soDienThoai)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_GiaoVien_Insert @tenGiaoVien , @gioiTinh , @ngaySinh , @soDienThoai", new object[] { tenGiaoVien, gioiTinh, ngaySinh, soDienThoai });
            return result > 0;
        }

        public bool Update(int idGiaoVien, string tenGiaoVien, string gioiTinh, DateTime ngaySinh, string soDienThoai)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_GiaoVien_Update @idGiaoVien , @tenGiaoVien , @gioiTinh , @ngaySinh , @soDienThoai", new object[] { idGiaoVien, tenGiaoVien, gioiTinh, ngaySinh, soDienThoai });

            return result > 0;
        }
        public bool Delete(int idGiaoVien)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_GiaoVien_Delete @idGiaoVien", new object[] { idGiaoVien });

            return result > 0;
        }
        public List<GiaoVienDTO> Search(string searchValue)
        {
            List<GiaoVienDTO> list = new List<GiaoVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_GiaoVien_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                GiaoVienDTO entry = new GiaoVienDTO(item);
                list.Add(entry);
            }
            return list;
        }
    }
}
