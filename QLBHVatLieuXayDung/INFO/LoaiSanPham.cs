using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHVatLieuXayDung.INFO
{
    public class LoaiSanPham
    {
        private string maLSP;
        private string tenLSP;

        public LoaiSanPham(string maLSP, string tenLSP)
        {
            this.MaLSP = maLSP;
            this.TenLSP = tenLSP;
        }

        public LoaiSanPham(DataRow row)
        {
            this.MaLSP = row["Mã loại sản phẩm"].ToString();
            this.TenLSP = row["Tên loại sản phẩm"].ToString();
        }

        public string MaLSP { get => maLSP; set => maLSP = value; }
        public string TenLSP { get => tenLSP; set => tenLSP = value; }
    }
}
