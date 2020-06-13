using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace app.init
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
        private LopInfo m_Lop;
        public LopInfo Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }

        private MonHocInfo m_MonHoc;
        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }

        private HocKyInfo m_HocKy;
        public HocKyInfo HocKy
        {
            get { return m_HocKy; }
            set { m_HocKy = value; }
        }

        private NamHocInfo m_NamHoc;
        public NamHocInfo NamHoc
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
