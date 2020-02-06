using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class PhanCongData
    {
        DataService m_PhanCongData = new DataService();

        public DataTable LayDsPhanCong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHANCONG");
            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }

        public DataRow ThemDongMoi()
        {
            return m_PhanCongData.NewRow();
        }

        public void ThemPhanCong(DataRow m_Row)
        {
            m_PhanCongData.Rows.Add(m_Row);
        }

        public bool LuuPhanCong()
        {
            return m_PhanCongData.ExecuteNoneQuery() > 0;
        }

        public void LuuPhanCong(String maNamHoc, String maLop, String maMonHoc, String maGiaoVien)
        {
        }

        public DataTable TimTheoTenLop(String ten)
        {
            return m_PhanCongData;
        }

        public DataTable TimTheoTenGV(String ten)
        {
            return m_PhanCongData;
        }
    }
}
