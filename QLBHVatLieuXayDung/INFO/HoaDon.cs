using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHVatLieuXayDung.INFO
{
    public class HoaDon
    {
        private string soHoaDon;
        private string maKhachHang;
        private string ngayHoaDon;

        public HoaDon(string soHoaDon, string maKhachHang, string ngayHoaDon)
        {
            this.SoHoaDon = soHoaDon;
            this.MaKhachHang = maKhachHang;
            this.NgayHoaDon = ngayHoaDon;
        }

        public HoaDon(DataRow row)
        {
            this.SoHoaDon = row["Số hóa đơn"].ToString();
            this.MaKhachHang = row["Mã khách hàng"].ToString();
            this.NgayHoaDon = row["Ngày hóa đơn"].ToString();
        }

        public string SoHoaDon { get => soHoaDon; set => soHoaDon = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string NgayHoaDon { get => ngayHoaDon; set => ngayHoaDon = value; }
    }
}
