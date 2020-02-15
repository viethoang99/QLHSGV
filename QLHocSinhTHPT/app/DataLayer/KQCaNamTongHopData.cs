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
            SqlCommand cmd = new SqlCommand("select * from KQ_CA_NAM_TONG_HOP kqcnth,LOP l,NAMHOC nh,HOCSINH hs,HOCLUC hl,HANHKIEM hk,KETQUA kq where" +
               " kqcnth.MaLop = l.MaLop and kqcnth.MaNamHoc = nh.MaNamHoc and kqcnth.MaHocSinh = hs.MaHocSinh " +
               "and kqcnth.MaHocLuc = hl.MaHocLuc and kqcnth.MaHanhKiem = hk.MaHanhKiem " +
               " and nh.MaNamHoc = @maNamHoc and l.MaLop = @maLop");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            m_KQCaNamTongHopData.Load(cmd);
            return m_KQCaNamTongHopData;
        }
    }
}
