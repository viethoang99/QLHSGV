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
            string query = "SELECT * FROM LOP WHERE MaNamHoc = '" + namHoc + "'";
            SqlCommand cmd = new SqlCommand(query);
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLop(String khoiLop, String namHoc)
        {
            string query = "SELECT * FROM LOP WHERE MaNamHoc = '" + namHoc + "' AND MaKhoiLop = '" + khoiLop + "'";
            SqlCommand cmd = new SqlCommand(query);
            m_LopData.Load(cmd);
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
