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
                + tenGiaoVien + "',N'" + diaChi + "','" + dienThoai + "','" + chuyenMon + "')";
            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.ExecuteNoneQuery(com);

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
            string sql ="a";
            //if(theoDChi == "NONE")
            //{
            //    if(theoCMon == "NONE")
            //    {
            //        sql = "SELECT " +
            //            "gv.MaGiaoVien, gv.TenGiaoVien,gv.DiaChi, " +
            //            "gv.DienThoai, MONHOC.TenMonHoc FROM GIAOVIEN as gv JOIN MONHOC " +
            //            "ON gv.MaMonHoc = MONHOC.MaMonHoc " +
            //            " WHERE TenGiaoVien LIKE '%" + hoTen + "%'";
            //    } 
            //    else
            //    {
            //        sql = "SELECT " +
            //            "gv.MaGiaoVien, gv.TenGiaoVien,gv.DiaChi, " +
            //            "gv.DienThoai, MONHOC.TenMonHoc FROM GIAOVIEN as gv JOIN MONHOC " +
            //            "ON gv.MaMonHoc = MONHOC.MaMonHoc " +
            //            " WHERE TenGiaoVien LIKE '%" + hoTen + "%' " +
            //        theoCMon + " MONHOC.TenMonHoc = '" + cMon + "'";
            //    }              
            //}
            //else
            //{
            //    if(theoCMon == "NONE")
            //    {
            //        sql = "SELECT " +
            //            "gv.MaGiaoVien, gv.TenGiaoVien,gv.DiaChi, " +
            //            "gv.DienThoai, MONHOC.TenMonHoc FROM GIAOVIEN as gv JOIN MONHOC " +
            //            "ON gv.MaMonHoc = MONHOC.MaMonHoc " +
            //            " WHERE TenGiaoVien LIKE '%" + hoTen + "%' " +
            //            theoDChi + " DiaChi LIKE '" + diaChi + "%'";
            //    }
            //    else
            //    {
            //        sql = "SELECT " +
            //            "gv.MaGiaoVien, gv.TenGiaoVien,gv.DiaChi, " +
            //            "gv.DienThoai, MONHOC.TenMonHoc FROM GIAOVIEN as gv JOIN MONHOC " +
            //            "ON gv.MaMonHoc = MONHOC.MaMonHoc " +
            //            " WHERE TenGiaoVien LIKE '%" + hoTen + "%' " +
            //            theoDChi + " DiaChi LIKE '" + diaChi + "%' " +
            //        theoCMon + " MONHOC.TenMonHoc = '" + cMon + "'";
            //    }
            //}

            SqlCommand com = new SqlCommand(sql);
            m_GiaoVienData.Load(com);
            return m_GiaoVienData;
        }
    }
}
