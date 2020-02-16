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
            SqlCommand cmd = new SqlCommand("select * from KQ_HOC_KY_TONG_HOP kqhkth,LOP l,NAMHOC nh,HOCKY hki,HOCSINH hs,HOCLUC hl,HANHKIEM hk where" +
              " kqhkth.MaLop = l.MaLop and kqhkth.MaNamHoc = nh.MaNamHoc and kqhkth.MaHocSinh = hs.MaHocSinh and kqhkth.MaHocLuc = hl.MaHocLuc" +
              " and kqhkth.MaHanhKiem = hk.MaHanhKiem and kqhkth.MaHocky = hki.MaHocKy" +
              " and nh.MaNamHoc = @maNamHoc and l.MaLop = @maLop and hki.MaHocKy = @maHocKy");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            m_KQHocKyTongHopData.Load(cmd);
            return m_KQHocKyTongHopData;
        }
    }
}
