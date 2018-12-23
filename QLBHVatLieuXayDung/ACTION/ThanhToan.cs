using QLBHVatLieuXayDung.DAO;
using System.Data;

namespace QLBHVatLieuXayDung.ACTION
{
    public class ThanhToan
    {
        private static ThanhToan instance;

        public static ThanhToan Instance
        {
            get { if (instance == null) instance = new ThanhToan(); return instance; }
            private set { instance = value; }
        }
        private ThanhToan() { }

        public DataTable LoadListThanhToan()
        {
            string query = "EXEC dbo.SHOW_ThanhToan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ThemThanhToan()
        {
            string query = string.Format("");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaThanhToan()
        {
            string query = string.Format("");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaThanhToan(int soPhieu)
        {
            string query = string.Format("EXEC dbo.Delete_ThanhToan @soPhieu = '{0}'", soPhieu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
