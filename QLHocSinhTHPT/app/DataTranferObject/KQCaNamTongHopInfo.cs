using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace app.DataTranferObject
{
    public class KQCaNamTongHopInfo
    {
        public KQCaNamTongHopInfo()
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

        private string m_NamHoc;
        public string NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private string m_HocLuc;
        public string HocLuc
        {
            get { return m_HocLuc; }
            set { m_HocLuc = value; }
        }

        private string m_HanhKiem;
        public string HanhKiem
        {
            get { return m_HanhKiem; }
            set { m_HanhKiem = value; }
        }

        private float m_DTBCaNam;
        public float DTBCaNam
        {
            get { return m_DTBCaNam; }
            set { m_DTBCaNam = value; }
        }

        private string m_KetQua;
        public string KetQua
        {
            get { return m_KetQua; }
            set { m_KetQua = value; }
        }
    }
}
