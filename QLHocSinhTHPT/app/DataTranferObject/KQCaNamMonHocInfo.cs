using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace app.DataTranferObject
{
    public class KQCaNamMonHocInfo
    {
        public KQCaNamMonHocInfo()
        {

        }
        private string ma_HocSinh;
        public string MaHocSinh
        {
            get { return ma_HocSinh; }
            set { ma_HocSinh = value; }
        }
        private string m_HocSinh;
        public string HocSinh
        {
            get { return m_HocSinh; }
            set { m_HocSinh = value; }
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

        private string m_NamHoc;
        public string NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private float m_DiemThiLai;
        public float DiemThiLai
        {
            get { return m_DiemThiLai; }
            set { m_DiemThiLai = value; }
        }

        private float m_DTBCaNam;
        public float DTBCaNam
        {
            get { return m_DTBCaNam; }
            set { m_DTBCaNam = value; }
        }
    }
}
