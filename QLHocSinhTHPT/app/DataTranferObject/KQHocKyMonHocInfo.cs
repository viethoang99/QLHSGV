using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace app.DataTranferObject
{
    public class KQHocKyMonHocInfo
    {
        public KQHocKyMonHocInfo()
        {

        }

        private String m_HocSinh;
        public String MaHocSinh
        {
            get { return m_HocSinh; }
            set { m_HocSinh = value; }
        }
        private String m_HocSinh_1;
        public String TenHocSinh
        {
            get { return m_HocSinh_1; }
            set { m_HocSinh_1 = value; }
        }
        private string m_Lop;
        public string Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }

        private string m_MonHoc;
        public string MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }

        private string m_HocKy;
        public string HocKy
        {
            get { return m_HocKy; }
            set { m_HocKy = value; }
        }

        private string m_NamHoc;
        public string NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private float m_DTBKiemTra;
        public float DTBKiemTra
        {
            get { return m_DTBKiemTra; }
            set { m_DTBKiemTra = value; }
        }

        private float m_DTBMonHocKy;
        public float DTBMonHocKy
        {
            get { return m_DTBMonHocKy; }
            set { m_DTBMonHocKy = value; }
        }
    }
}
