using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHVatLieuXayDung.INFO
{
    public class SanPham
    {
        private string maSP;
        private string tenSP;
        private string nSX;
        private string maLoaiSP;

        public SanPham(string maSP, string tenSP, string nSX, string maLoaiSP)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.NSX = nSX;
            this.MaLoaiSP = maLoaiSP;
        }

        public SanPham(DataRow row)
        {
            this.maSP = row["Mã sản phẩm"].ToString();
            this.TenSP = row["Tên sản phẩm"].ToString();
            this.NSX = row["Nhà sản xuất"].ToString();
            this.MaLoaiSP = row["Mã loại sản phẩm"].ToString();
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string NSX { get => nSX; set => nSX = value; }
        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
    }
}
