using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace app.DataTranferObject
{
    public class HocSinhInfo
    {
        public HocSinhInfo()
        {

        }

        private String m_MaHocSinh;
        public String MaHocSinh
        {
            get { return m_MaHocSinh; }
            set { m_MaHocSinh = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private String m_GioiTinh;
        public String GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        private String m_NoiSinh;
        public String NoiSinh
        {
            get { return m_NoiSinh; }
            set { m_NoiSinh = value; }
        }
    }
}