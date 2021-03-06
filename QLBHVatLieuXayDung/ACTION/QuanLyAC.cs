﻿using System.Data;

namespace QLBHVatLieuXayDung.DAO
{
    public class QuanLyAC
    {
        private static QuanLyAC instance;

        public static QuanLyAC Instance
        {
            get { if (instance == null) instance = new QuanLyAC(); return instance; }
            private set { instance = value; }
        }

        private QuanLyAC() { }

        //public DataTable LoadListMaHD()
        //{
        //    string query = "EXEC dbo.Show_SoHoaDon";
        //    return DataProvider.Instance.ExecuteQuery(query);
        //}
        #region Hóa đơn
        public DataTable LoadListHoaDon()
        {
            string query = "EXEC dbo.SHOW_HoaDon";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ThemHoaDon(string soHoaDon, string maKhachHang, string ngayHoaDon)
        {
            string query = string.Format("EXEC dbo.USP_InsertHoaDon @soHoaDon = '{0}', @maKhachHang = '{1}', @ngayHoaDon = '{2}'", soHoaDon, maKhachHang, ngayHoaDon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaHoaDon(string soHoaDon, string maKhachHang, string ngayHoaDon)
        {
            string query = string.Format("EXEC dbo.USP_UpdateHoaDon @soHoaDon = '{0}', @maKhachHang = '{1}', @ngayHoaDon = '{2}'", soHoaDon, maKhachHang, ngayHoaDon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaHoaDon(string soHoaDon)
        {
            string query = string.Format("EXEC dbo.USP_DeleteHoaDon @soHoaDon = '{0}'", soHoaDon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion

        #region Chi tiết hóa đơn
        public DataTable LoadListCTHD()
        {
            string query = "EXEC dbo.SHOW_CTHD";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ThemChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, double donGia)
        {
            string query = string.Format("EXEC dbo.USP_InsertChiTietHoaDon @maHoaDon = '{0}', @maSanPham = '{1}', @soLuong = {2}, @donGia = {3}", maHoaDon, maSanPham, soLuong, donGia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool SuaChiTietHoaDon(string maHoaDon, string maSanPham, int soLuong, double donGia)
        {
            string query = string.Format("EXEC dbo.USP_UpdateChiTietHoaDon @maHoaDon = '{0}', @maSanPham = '{1}', @soLuong = {2}, @donGia = {3}", maHoaDon, maSanPham, soLuong, donGia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool XoaChiTietHoaDon(string maHoaDon)
        {
            string query = string.Format("EXEC dbo.USP_DeleteChiTietHonDon @maHoaDon = '{0}'", maHoaDon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        #endregion
        
    }
}
