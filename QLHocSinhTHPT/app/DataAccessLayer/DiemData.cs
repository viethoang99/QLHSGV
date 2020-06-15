using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataAccessLayer
{
    public class DiemData
    {
        DataService m_DiemData = new DataService();

        public DataTable LayDsDiem()
        {
            return m_DiemData;
        }

        public DataTable LayDsDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
        {

            SqlCommand cmd = new SqlCommand("select * from LOAIDIEM ld ,DIEM d , HOCSINH hs , MONHOC mh where d.MaHocSinh = @maHocSinh " +
                 "and d.MaMonHoc = @maMonHoc and d.MaHocKy = @maHocKy and d.MaNamHoc = @maNamHoc and d.MaLop = @maLop " +
                 "	and d.MaHocSinh = hs.MaHocSinh and mh.MaMonHoc = d.MaMonHoc and ld.MaLoai = d.MaLoai ");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;

            m_DiemData.Load(cmd);
            return m_DiemData;
        }

        public void LuuDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, float diemSo)
        {
            SqlCommand cmd = new SqlCommand("INSERT DIEM(MaHocSinh,MaMonHoc,MaHocKy,MaNamHoc,MaLop,MaLoai,Diem)" +
              " VALUES(@maHocSinh,@maMonHoc,@maHocKy,@maNamHoc,@maLop,@maLoaiDiem,@diemSo) ");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maLoaiDiem", SqlDbType.VarChar).Value = maLoaiDiem;
            cmd.Parameters.Add("diemSo", SqlDbType.Float).Value = diemSo;
            m_DiemData.Load(cmd);
        }
        public void CapNhatDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, float diemSo)
        {
            SqlCommand cmd = new SqlCommand("UPDATE DIEM SET" +
             " Diem = @diemSo where MaHocSinh = @maHocSinh and MaHocKy = @maHocky and MaLop = @maLop and " +
             "MaLoai = @maLoaiDiem and MaNamHoc = @maNamHoc");

            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maLoaiDiem", SqlDbType.VarChar).Value = maLoaiDiem;
            cmd.Parameters.Add("diemSo", SqlDbType.Float).Value = diemSo;
            m_DiemData.Load(cmd);
        }



        public void XoaDiem(int stt)
        {

        }

        public DataTable LayDsDiemHocSinh(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
        {
            return m_DiemData;
        }

        public DataTable LayPhieuDiemCaNhanForReport(String maHocSinh, String maLop, String maNamHoc)
        {
           
            return m_DiemData;
        }
    }
}
