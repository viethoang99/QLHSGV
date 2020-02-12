using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class KQHocKyMonHocData
    {
        DataService m_KQHocKyMonHocData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maHocKy, String maNamHoc, float diemTBKT, float diemTBMonHK)
        {
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            
        }

        public DataTable LayDsKQHocKyMonHocForReport(String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            return m_KQHocKyMonHocData;
        }
    }
}
