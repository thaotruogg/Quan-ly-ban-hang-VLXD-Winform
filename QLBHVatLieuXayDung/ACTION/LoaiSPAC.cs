using QLBHVatLieuXayDung.INFO;
using System.Data;

namespace QLBHVatLieuXayDung.DAO
{
    public class LoaiSPAC
    {
        private static LoaiSPAC instance;

        public static LoaiSPAC Instance
        {
            get { if (instance == null) instance = new LoaiSPAC(); return instance; }
            private set { instance = value; }
        }

        private LoaiSPAC() { }

        public DataTable LoadListLoaiSP()
        {
            string query = "SHOW_LoaiSanPham";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ThemLoaiSP(string maLoai, string tenLoai)
        {
            string query = string.Format("EXEC dbo.USP_InsertLoaiSP @maLoaiSanPham = '{0}', @tenLoaiSanPham = N'{1}'", maLoai, tenLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaLoaiSP(string maLoai, string tenLoai)
        {
            string query = string.Format("EXEC dbo.USP_UpdateLoaiSP @maLoaiSanPham = '{0}', @tenLoaiSanPham = N'{1}'", maLoai, tenLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaLoaiSP(string maLoai)
        {
            SanPhamAC.Instance.DeleteSanPhamByLoaiSanPham(maLoai);
            string query = string.Format("EXEC dbo.USP_DeleteLoaiSP @maLoaiSanPham = '{0}'", maLoai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public LoaiSanPham GetLoaiSanPhamByMaSP(string maSP)
        {
            LoaiSanPham loai = null;
            string query = string.Format("SELECT * FROM dbo.LOAISANPHAM WHERE maLoaiSanPham = {0}", maSP);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                loai = new LoaiSanPham(item);
                return loai;
            }
            return loai;
        }
    }
}
