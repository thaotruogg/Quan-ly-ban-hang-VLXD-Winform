using System.Data;

namespace QLBHVatLieuXayDung.DAO
{
    public class SanPhamAC
    {
        private static SanPhamAC instance;

        public static SanPhamAC Instance
        {
            get { if (instance == null) instance = new SanPhamAC(); return instance; }
            private set { instance = value; }
        }

        private SanPhamAC() { } 

        public DataTable LoadListSanPham()
        {
            string query = "SHOW_SanPham";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteSanPhamByLoaiSanPham(string maLoai)
        {
            string query = string.Format("DELETE dbo.SANPHAM WHERE maLoaiSanPham = '{0}'", maLoai);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemSanPham(string maSP, string tenSP, string nSX, string maLoaiSP)
        {
            string query = string.Format("EXEC dbo.USP_InsertSanPham @maSanPham = '{0}', @tenSanPham = N'{1}', @nhaSanXuat = N'{2}', @maLoaiSP = '{3}'", maSP, tenSP, nSX, maLoaiSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaSanPham(string maSP, string tenSP, string nSX, string maLoaiSP)
        {
            string query = string.Format("EXEC dbo.USP_UpdateSanPham @maSanPham = '{0}', @tenSanPham = N'{1}', @nhaSanXuat = N'{2}', @maLoaiSP = '{3}'", maSP, tenSP, nSX, maLoaiSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaSanPham(string maSP)
        {
            string query = string.Format("EXEC dbo.USP_DeleteSanPham @maSanPham = '{0}'", maSP);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
