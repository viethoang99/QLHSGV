using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataAccessLayer
{
    public class HocSinhData
    {
        DataService m_HocSinhData = new DataService();
        SqlConnection connection = new SqlConnection();

        public DataTable LayDsHocSinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String namHoc, String lop)
        {
            string query = "SELECT HS.MaHocSinh,HS.HoTen,HS.GioiTinh,HS.NgaySinh,HS.NoiSinh from HOCSINH HS, " +
                "PHANLOP PL WHERE HS.MaHocSinh = PL.MaHocSinh AND " +
                "PL.MaLop = '" + lop + "' AND MaNamHoc = '" + namHoc + "'";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String namHoc, String khoiLop, String lop)
        {
            string query = "SELECT HS.MaHocSinh,HS.HoTen,HS.GioiTinh,HS.NgaySinh,HS.NoiSinh from HOCSINH HS, " +
                "PHANLOP PL WHERE HS.MaHocSinh = PL.MaHocSinh AND PL.MaKhoiLop = '" + khoiLop + "' AND " +
                "PL.MaLop = '" + lop + "' AND PL.MaNamHoc = '" + namHoc + "'";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoNamHoc(String namHoc)
        {
            string query = "SELECT HS.MaHocSinh,HS.HoTen,HS.GioiTinh,HS.NgaySinh,HS.NoiSinh,L.TenLop from HOCSINH HS, " +
                "PHANLOP PL, LOP L WHERE HS.MaHocSinh = PL.MaHocSinh AND PL.MaLop = L.MaLop AND " +
                "PL.MaNamHoc = '" + namHoc + "'";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public void LuuHSVaoBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
        {
            string query = "INSERT PHANLOP VALUES " +
                "('" + maNamHoc + "','" + maKhoiLop + "','" + maLop + "','" + maHS + "')";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
        }

        public void XoaHSKhoiBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
        {
            string query = "DELETE FROM PHANLOP WHERE MaNamHoc = '" + maNamHoc + "' AND " +
                "MaKhoiLop = '" + maKhoiLop + "' AND MaLop = '" + maLop + "' AND MaHocSinh = '" + maHS + "'";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
        }

        public DataTable LayDsHocSinhForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.NewRow();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.Rows.Add(m_Row);
        }

        public bool LuuHocSinh()
        {
            return m_HocSinhData.ExecuteNoneQuery() > 0;
        }

        public void LuuHocSinh(String maHocSinh, String hoTen, string gioiTinh, DateTime ngaySinh, String noiSinh)
        {
            DataService.OpenConnection();

            String query = "insert HOCSINH values('" + maHocSinh + "', N'" + hoTen + "'," +
                " N'" + gioiTinh + "', '" + ngaySinh + "', N'" + noiSinh + "')";
            SqlCommand command = new SqlCommand(query);
            m_HocSinhData.Load(command);
        }

        public DataTable TimTheoMa(String id)
        {
            string query = "select * from HOCSINH where MaHocSinh like '%" + id + "%'";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable TimTheoTen(String ten)
        {
            string query = "select * from HOCSINH where HoTen like '%" + ten + "%'";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable TimKiemHocSinh(String hoTen)
        {
            string query = "SELECT * FROM HOCSINH WHERE " +
                "HoTen LIKE '%" + hoTen + "%' " +
                "OR NgaySinh LIKE '%" + hoTen + "%' " +
                "OR MaHocSinh LIKE '%" + hoTen + "%' " +
                "OR GioiTinh LIKE '%" + hoTen + "%' " +
                "OR NoiSinh LIKE '%" + hoTen + "%'";
            SqlCommand cmd = new SqlCommand(query);
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }
    }
}

//DESKTOP-8V08BMC\SQLEXPRESS
