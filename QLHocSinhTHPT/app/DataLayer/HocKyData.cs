using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class HocKyData
    {
        DataService m_HocKyData = new DataService();

        public DataTable LayDsHocKy()
        {
            return m_HocKyData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocKyData.NewRow();
        }

        public void ThemHocKy(DataRow m_Row)
        {
            m_HocKyData.Rows.Add(m_Row);
        }

        public bool LuuHocKy()
        {
            return m_HocKyData.ExecuteNoneQuery() > 0;
        }
    }
}
