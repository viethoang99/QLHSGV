using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class HocSinhData
    {
        DataService m_HocSinhData = new DataService();

        public DataTable LayDsHocSinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String namHoc, String lop)
        {
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

        }

        public DataTable TimTheoMa(String id)
        {
            return m_HocSinhData;
        }

        public DataTable TimTheoTen(String ten)
        {
            return m_HocSinhData;
        }

        public DataTable TimKiemHocSinh(String hoTen, String theoNSinh, String noiSinh)
        {
            return m_HocSinhData;
        }
    }
}
