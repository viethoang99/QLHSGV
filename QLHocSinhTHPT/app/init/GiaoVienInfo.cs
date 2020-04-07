using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace app.init
{
    public class GiaoVienInfo
    {
        public GiaoVienInfo()
        {

        }

        private String m_MaGiaoVien;
        public String MaGiaoVien
        {
            get { return m_MaGiaoVien; }
            set { m_MaGiaoVien = value; }
        }

        private String m_TenGiaoVien;
        public String TenGiaoVien
        {
            get { return m_TenGiaoVien; }
            set { m_TenGiaoVien = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_DienThoai;
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

        private String m_MonHoc;
        public String MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }
    }
}
