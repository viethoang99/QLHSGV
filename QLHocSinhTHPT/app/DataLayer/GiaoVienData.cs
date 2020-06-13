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
            string sql = "SELECT * FROM GIAOVIEN";
            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.Load(com);
            return m_GiaoVienData;

        }

        public DataTable LayDsGiaoVienForReport()
        {
            string sql = "SELECT * FROM GIAOVIEN as gv JOIN MONHOC as mh ON " +
                 "gv.MaMonHoc = mh.MaMonHoc";
            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.Load(com);
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
            string sql = "INSERT INTO GIAOVIEN VALUES ('" + maGiaoVien + "',N'"
                + tenGiaoVien + "',N'" + diaChi + "','" + dienThoai + "',N'" + chuyenMon + "')";
            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.Load(com);

        }

        public DataTable TimTheoMa(String id)
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE MaGiaoVien LIKE '%" + id + "%'";
            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.Load(com);
            return m_GiaoVienData;
        }

        public DataTable TimTheoTen(String ten)
        {
            string sql = "SELECT * FROM GIAOVIEN WHERE TenGiaoVien LIKE '%" + ten + "%'";
            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.Load(com);
            return m_GiaoVienData;
        }

        public DataTable TimKiemGiaoVien(String hoTen)
        {
            string sql = "SELECT G.MaGiaoVien, G.TenGiaoVien, G.DiaChi, G.DienThoai, H.TenMonHoc FROM GIAOVIEN G INNER JOIN MONHOC H ON G.MaMonHoc = H.MaMonHoc"
                + " WHERE G.TenGiaoVien LIKE '%" + hoTen + "%' " +
                "OR G.DiaChi LIKE '%" + hoTen + "%' " +
                "OR G.DienThoai LIKE '%" + hoTen + "%' " +
                "OR H.TenMonHoc LIKE '%" + hoTen + "%' ";
            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.Load(com);
            return m_GiaoVienData;
        }
    }
}
