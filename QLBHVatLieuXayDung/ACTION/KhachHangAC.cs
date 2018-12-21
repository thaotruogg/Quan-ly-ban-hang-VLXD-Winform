using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHVatLieuXayDung.DAO
{
    public class KhachHangAC
    {
        private static KhachHangAC instance;

        public static KhachHangAC Instance
        {
            get { if (instance == null) instance = new KhachHangAC(); return KhachHangAC.instance; }
            private set { instance = value; }
        }

        private KhachHangAC() { }

        public DataTable LoadListKhachHang()
        {
            string query = "SHOW_KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadListChonKH()
        {
            string query = "SELECT maKhachHang AS [Mã khách hàng], tenKhachHang AS [Tên khách hàng] FROM dbo.KHACHHANG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemKhachHang(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, float noDauKi, float noCuoiKi)
        {
            string query = string.Format("EXEC dbo.USP_InsertKhachHang @maKhachHang = '{0}', @tenKhachHang = N'{1}', @diaChi = N'{2}', @soDienThoai = '{3}', @noDauKi = {4}, @noHienTai = {5}", maKhachHang, tenKhachHang, diaChi, soDienThoai, noDauKi, noCuoiKi);
            int result =  DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool SuaKhachHang(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, float noDauKi, float noCuoiKi)
        {
            string query = string.Format("EXEC dbo.USP_UpdateKhachHang @maKhachHang = '{0}', @tenKhachHang = N'{1}', @diaChi = N'{2}', @soDienThoai = '{3}', @noDauKi = {4}, @noHienTai = {5}", maKhachHang, tenKhachHang, diaChi, soDienThoai, noDauKi, noCuoiKi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaKhachHang(string maKhachHang)
        {
            string query = string.Format("DELETE dbo.KHACHHANG WHERE maKhachHang = '{0}'", maKhachHang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
