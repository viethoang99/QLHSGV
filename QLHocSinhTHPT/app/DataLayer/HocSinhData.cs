using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH hs ,LOP l ,NAMHOC nh,PHANLOP pl"
            + " where pl.MaHocSinh = hs.MaHocSinh and pl.MaLop = l.MaLop and l.MaNamHoc = nh.MaNamHoc" +
            " and l.MaLop = @lop and nh.MaNamHoc = @namHoc");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String namHoc, String khoiLop, String lop)
        {
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoNamHoc(String namHoc)
        {

            return m_HocSinhData;
        }

        public void LuuHSVaoBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
        {

        }

        public void XoaHSKhoiBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
        {

        }

        public DataTable LayDsHocSinhForReport()
        {
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

        public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String noiSinh)
        {
            DataService.OpenConnection();

            String query = "insert HOCSINH values('" + maHocSinh + "', '" + hoTen + "'," +
                " '" + gioiTinh + "', '" + ngaySinh + "', '" + noiSinh + "')";
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
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
