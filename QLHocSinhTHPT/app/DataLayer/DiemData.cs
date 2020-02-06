using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class DiemData
    {
        DataService m_DiemData = new DataService();

        public DataTable LayDsDiem()
        {
            return m_DiemData;
        }

        public DataTable LayDsDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
        {

            return m_DiemData;
        }

        public void LuuDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, float diemSo)
        {
        }

        public void XoaDiem(int stt)
        {
        }

        public DataTable LayDsDiemHocSinh(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
        {
            return m_DiemData;
        }

        public DataTable LayPhieuDiemCaNhanForReport(String maHocSinh, String maLop, String maNamHoc)
        {
           
            return m_DiemData;
        }
    }
}
