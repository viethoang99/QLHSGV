using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class LopData
    {
        DataService m_LopData = new DataService();

        public DataTable LayDsLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP");
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLop(String namHoc)
        {

            SqlCommand cmd = new SqlCommand("SELECT l.MaLop,l.TenLop,l.MaKhoiLop,l.MaNamHoc,l.SiSo,l.MaGiaoVien" +
                " FROM LOP as l ,NAMHOC as nh" +
                " where l.MaNamHoc = nh.MaNamHoc and nh.MaNamHoc = @namHoc ");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLop(String khoiLop, String namHoc)
        {
            return m_LopData;
        }

        public DataTable LayDsLopForReport()
        {
            return m_LopData;
        }

        public DataTable LayDsLopForReport(String namHoc)
        {
            return m_LopData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LopData.NewRow();
        }

        public void ThemLop(DataRow m_Row)
        {
            m_LopData.Rows.Add(m_Row);
        }

        public bool LuuLop()
        {
            return m_LopData.ExecuteNoneQuery() > 0;
        }

        public void LuuLop(String maLop, String tenLop, String maKhoiLop, String maNamHoc, int siSo, String maGiaoVien)
        {
        }

        public DataTable TimTheoMa(String id)
        {
            return m_LopData;
        }

        public DataTable TimTheoTen(String ten)
        {
            return m_LopData;
        }
    }
}
