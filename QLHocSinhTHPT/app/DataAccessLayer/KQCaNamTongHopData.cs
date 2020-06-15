using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataAccessLayer
{
    public class KQCaNamTongHopData
    {
        DataService m_KQCaNamTongHopData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maNamHoc, String maHocLuc, String maHanhKiem, float diemTBChungCacMonCN, String maKetQua)
        {
            DataService m_KQCNTHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_CA_NAM_TONG_HOP VALUES(@maHocSinh, @maLop, @maNamHoc, @maHocLuc, @maHanhKiem, @diemTBChungCacMonCN, @maKetQua)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maHocLuc", SqlDbType.VarChar).Value = maHocLuc;
            cmd.Parameters.Add("maHanhKiem", SqlDbType.VarChar).Value = maHanhKiem;
            cmd.Parameters.Add("diemTBChungCacMonCN", SqlDbType.Float).Value = Math.Round(diemTBChungCacMonCN, 2);
            cmd.Parameters.Add("maKetQua", SqlDbType.VarChar).Value = maKetQua;

            m_KQCNTHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maNamHoc)
        {
            DataService m_KQCNTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_CA_NAM_TONG_HOP WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCNTHData.Load(cmd);
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
