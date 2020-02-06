using System;
using System.Data;
using System.Data.SqlClient;

namespace app.DataLayer
{
    public class QuyDinhData
    {
        DataService m_QuyDinhData = new DataService();

        public DataTable LayDsQuyDinh()
        {
            return m_QuyDinhData;
        }

        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
        }

        public void CapNhatQuyDinhTruong(String tenTruong, String diaChiTruong)
        {
        }

        public void CapNhatQuyDinhThangDiem(int thangDiem)
        {
        }
    }
}
