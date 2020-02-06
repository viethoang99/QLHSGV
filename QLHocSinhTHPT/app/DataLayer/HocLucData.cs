using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class HocLucData
    {
        DataService m_HocLucData = new DataService();

        public DataTable LayDsHocLuc()
        {
            return m_HocLucData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocLucData.NewRow();
        }

        public void ThemHocLuc(DataRow m_Row)
        {
            m_HocLucData.Rows.Add(m_Row);
        }

        public bool LuuHocLuc()
        {
            return m_HocLucData.ExecuteNoneQuery() > 0;
        }
    }
}
