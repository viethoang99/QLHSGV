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
            SqlCommand cmd = new SqlCommand("select * from KQ_CA_NAM_MON_HOC kqcnmh,LOP l,MONHOC mh,NAMHOC nh,HOCSINH hs where" +
                " kqcnmh.MaLop = l.MaLop and kqcnmh.MaMonHoc = mh.MaMonHoc and kqcnmh.MaNamHoc = nh.MaNamHoc and kqcnmh.MaHocSinh = hs.MaHocSinh" +
                " and nh.MaNamHoc = @maNamHoc and mh.MaMonHoc = @maMonHoc and l.MaLop = @maLop");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;


            m_KQCaNamMonHocData.Load(cmd);
            return m_KQCaNamMonHocData;
        }
    }
}
