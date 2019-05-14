using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyHocSinhTHPT.DTO;

namespace QuanLyHocSinhTHPT.DAO
{
    class HocSinhDAO
    {
        private static HocSinhDAO instance;

        internal static HocSinhDAO Instance
        {
            get { if (instance == null) instance = new HocSinhDAO(); return instance; }
            private set { instance = value; }
        }
        public List<HocSinhDTO> GetAll()
        {
            List<HocSinhDTO> list = new List<HocSinhDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_HocSinh_GetAll");
            foreach (DataRow item in data.Rows)
            {
                HocSinhDTO entry = new HocSinhDTO(item);
                list.Add(entry);
            }
            return list;
        }

        public bool Insert(string tenHocSinh, string gioiTinh, DateTime ngaySinh, int idLopHoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_HocSinh_Insert @tenHocSinh , @gioiTinh , @ngaySinh , @idLopHoc", new object[] {  tenHocSinh,  gioiTinh,  ngaySinh,  idLopHoc });
            return result > 0;
        }

        public bool Update(int idHocSinh, string tenHocSinh, string gioiTinh, DateTime ngaySinh, int idLopHoc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_HocSinh_Update @idHocSinh , @tenHocSinh , @gioiTinh , @ngaySinh , @idLopHoc", new object[] { idHocSinh, tenHocSinh, gioiTinh, ngaySinh, idLopHoc });

            return result > 0;
        }
        public bool Delete(int idHocSinh)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("SP_HocSinh_Delete @idHocSinh", new object[] { idHocSinh });

            return result > 0;
        }
        public List<HocSinhDTO> Search(string searchValue)
        {
            List<HocSinhDTO> list = new List<HocSinhDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SP_HocSinh_Search @searchValue", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                HocSinhDTO entry = new HocSinhDTO(item);
                list.Add(entry);
            }
            return list;
        }
        public List<LopHocDTO> GetListLopHoc()
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
    }
}
