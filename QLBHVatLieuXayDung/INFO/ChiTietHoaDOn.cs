using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHVatLieuXayDung.INFO
{
    public class ChiTietHoaDOn
    {
        private string maHoaDon;
        private string maSanPham;
        private int soLuong;
        private float donGia;

        public ChiTietHoaDOn(string maHoaDon, string maSanPham, int soLuong, float donGia)
        {
            this.MaHoaDon = maHoaDon;
            this.MaSanPham = maSanPham;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public ChiTietHoaDOn(DataRow row)
        {
            this.MaHoaDon = row["Mã hóa đơn"].ToString();
            this.MaSanPham = row["Mã sản phẩm"].ToString();
            this.SoLuong = (int)row["Số lượng"];
            this.DonGia = (float)row["Đơn giá"];
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
    }
}
