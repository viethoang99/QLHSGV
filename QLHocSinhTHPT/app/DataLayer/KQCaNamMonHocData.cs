using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class KQCaNamMonHocData
    {
        DataService m_KQCaNamMonHocData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc, float diemThiLai, float diemTBMonCN)
        {

        }

        public void XoaKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            
        }

        public DataTable LayDsKQCaNamMonHocForReport(String maLop, String maMonHoc, String maNamHoc)
        {
           
            return m_KQCaNamMonHocData;
        }
    }
}
