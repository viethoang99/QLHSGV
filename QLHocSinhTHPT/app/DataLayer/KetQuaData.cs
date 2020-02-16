using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class KetQuaData
    {
        DataService m_KetQuaData = new DataService();

        public DataTable LayDsKetQua()
        {
            SqlCommand cmd = new SqlCommand("select * from KETQUA ");
            m_KetQuaData.Load(cmd);
            return m_KetQuaData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KetQuaData.NewRow();
        }

        public void ThemKetQua(DataRow m_Row)
        {
            m_KetQuaData.Rows.Add(m_Row);
        }

        public bool LuuKetQua()
        {
            return m_KetQuaData.ExecuteNoneQuery() > 0;
        }
    }
}
