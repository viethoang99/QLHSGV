using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class KhoiLopData
    {
        DataService m_KhoiLopData = new DataService();

        public DataTable LayDsKhoiLop()
        {
<<<<<<< HEAD
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOILOP");
            m_KhoiLopData.Load(cmd);
=======
            string sql = "SELECT * FROM KHOILOP";
            SqlCommand com = new SqlCommand(sql);
            m_KhoiLopData.Load(com);
>>>>>>> 83f6a6d23b7f20eb673d49b75ae8c5a3ecf95351
            return m_KhoiLopData;
        }

        public DataTable LayDsKhoiLop(String khoiLopCu)
        {
            //string a = khoiLopCu;
            string query = "SELECT * FROM KHOILOP";
            //if (khoiLopCu.ToString().Equals("") == false)
            //{             
            //    query = "SELECT * FROM KHOILOP where MaKhoiLop = '" + khoiLopCu + "'";               
            //}
            SqlCommand cmd = new SqlCommand(query);
            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhoiLopData.NewRow();
        }

        public void ThemKhoiLop(DataRow m_Row)
        {
            m_KhoiLopData.Rows.Add(m_Row);
        }

        public bool LuuKhoiLop()
        {
            return m_KhoiLopData.ExecuteNoneQuery() > 0;
        }
    }
}
