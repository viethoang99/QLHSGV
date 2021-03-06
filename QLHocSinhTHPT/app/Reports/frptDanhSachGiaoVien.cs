using System;
using System.Text;
using System.Drawing;
using app.DataTranferObject;
using app.Component;
using app.BusinessLayer;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace app.Reports
{
    public partial class frptDanhSachGiaoVien : Office2007Form
    {
        //Constructor
        public frptDanhSachGiaoVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        

        //Load
        private void frptDanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.reportViewerDSGV.LocalReport.SetParameters(param);

            IList<GiaoVienInfo> giaovien = GiaoVienCtrl.LayDsGiaoVien();
            this.bSDSGiaoVien.DataSource = giaovien;

            this.reportViewerDSGV.RefreshReport();
        }
        
    }
}