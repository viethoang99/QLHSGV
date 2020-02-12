using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class KQCaNamTongHopData
    {
        DataService m_KQCaNamTongHopData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maNamHoc, String maHocLuc, String maHanhKiem, float diemTBChungCacMonCN, String maKetQua)
        {
            
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maNamHoc)
        {

        }

        public DataTable LayDsKQCaNamTongHopForReport(String maLop, String maNamHoc)
        {
            
            return m_KQCaNamTongHopData;
        }
    }
}
