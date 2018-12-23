﻿using QLBHVatLieuXayDung.DAO;
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
    }
}
