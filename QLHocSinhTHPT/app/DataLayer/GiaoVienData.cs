using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class GiaoVienData
    {
        DataService m_GiaoVienData = new DataService();

        public DataTable LayDsGiaoVien()
        {
            return m_GiaoVienData;
        }

        public DataTable LayDsGiaoVienForReport()
        {
            return m_GiaoVienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_GiaoVienData.NewRow();
        }

        public void ThemGiaoVien(DataRow m_Row)
        {
            m_GiaoVienData.Rows.Add(m_Row);
        }

        public bool LuuGiaoVien()
        {
            return m_GiaoVienData.ExecuteNoneQuery() > 0;
        }

        public void LuuGiaoVien(String maGiaoVien, String tenGiaoVien, String diaChi, String dienThoai, String chuyenMon)
        {
        }

        public DataTable TimTheoMa(String id)
        {
            return m_GiaoVienData;
        }

        public DataTable TimTheoTen(String ten)
        {
            return m_GiaoVienData;
        }

        public DataTable TimKiemGiaoVien(String hoTen, String theoDChi, String diaChi, String theoCMon, String cMon)
        {
            return m_GiaoVienData;
        }
    }
}
