using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class KQHocKyTongHopData
    {
        DataService m_KQHocKyTongHopData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc, String maHocLuc, String maHanhKiem, float diemTBChungCacMonHK)
        {
            
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            
        }

        public DataTable LayDsKQHocKyTongHopForReport(String maLop, String maHocKy, String maNamHoc)
        {
           
            return m_KQHocKyTongHopData;
        }
    }
}
